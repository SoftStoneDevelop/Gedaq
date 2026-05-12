

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
    internal partial interface INpgsqlPathMArraypathMMArrayD2
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD2 : INpgsqlPathMArraypathMMArrayD2
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD2E1M[] _testData = new NpgsqlPathpathMMArrayD2E1M[]
        {
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2732863603241943d, y: 0.4625821227027247d), new NpgsqlTypes.NpgsqlPoint(x: 0.0049993921613333825d, y: 0.5227050377068659d), new NpgsqlTypes.NpgsqlPoint(x: 0.989562663855755d, y: 0.6536686046671716d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42406601205044037d, y: 0.05489867194740272d), new NpgsqlTypes.NpgsqlPoint(x: 0.2920155521562323d, y: 0.18641820743504267d), new NpgsqlTypes.NpgsqlPoint(x: 0.026231174423281378d, y: 0.08408942115610407d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6447888412139839d, y: 0.4962901697727663d), new NpgsqlTypes.NpgsqlPoint(x: 0.24945096189694438d, y: 0.40588569897683646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8935812392799587d, y: 0.017203532276349076d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025132914695885633d, y: 0.6691712337203471d), new NpgsqlTypes.NpgsqlPoint(x: 0.1298227258114335d, y: 0.19148789120911314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6072389269583205d, y: 0.007896622136267406d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7961119764053385d, y: 0.634605379764194d), new NpgsqlTypes.NpgsqlPoint(x: 0.45217148242934746d, y: 0.4618823705223468d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517070937017595d, y: 0.5499313899290232d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43051842690001807d, y: 0.7261783154704471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6940147745484705d, y: 0.22513251035837056d), new NpgsqlTypes.NpgsqlPoint(x: 0.49221915609503075d, y: 0.1179382258866567d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39781328455952447d, y: 0.569120718544419d), new NpgsqlTypes.NpgsqlPoint(x: 0.08593770257207745d, y: 0.6508454882438811d), new NpgsqlTypes.NpgsqlPoint(x: 0.1686145483133309d, y: 0.7039660574691287d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3119771614272068d, y: 0.4312628865051621d), new NpgsqlTypes.NpgsqlPoint(x: 0.15763813989504738d, y: 0.9163164233746698d), new NpgsqlTypes.NpgsqlPoint(x: 0.3667995731566098d, y: 0.967287820968289d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22198713022886474d, y: 0.10126482674416004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5361719292697751d, y: 0.9723122512338352d), new NpgsqlTypes.NpgsqlPoint(x: 0.07953147488703716d, y: 0.896138436834765d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3352898820942427d, y: 0.45763371177407064d), new NpgsqlTypes.NpgsqlPoint(x: 0.4337966567372882d, y: 0.21227429225879035d), new NpgsqlTypes.NpgsqlPoint(x: 0.35362672300449693d, y: 0.7114207012375319d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4520342233460094d, y: 0.15795903747267015d), new NpgsqlTypes.NpgsqlPoint(x: 0.012872015739221587d, y: 0.2738228856371656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6447330098987784d, y: 0.7628194940455537d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2551206676421285d, y: 0.7656493637184182d), new NpgsqlTypes.NpgsqlPoint(x: 0.9641870595237996d, y: 0.13818980192061725d), new NpgsqlTypes.NpgsqlPoint(x: 0.8947829984206901d, y: 0.01726424560837858d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4206084523572242d, y: 0.7415894887126122d), new NpgsqlTypes.NpgsqlPoint(x: 0.9862093848885912d, y: 0.2392051608485607d), new NpgsqlTypes.NpgsqlPoint(x: 0.6894901932513124d, y: 0.7320014830199262d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18290178129243495d, y: 0.35013501664240543d), new NpgsqlTypes.NpgsqlPoint(x: 0.4612375559812337d, y: 0.284093252305307d), new NpgsqlTypes.NpgsqlPoint(x: 0.523964344702271d, y: 0.5075578333444088d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21402250507908638d, y: 0.30712882700334065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439307758319717d, y: 0.20626904960762027d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484980798333757d, y: 0.20736195713527605d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3335490318792633d, y: 0.09993322190398057d), new NpgsqlTypes.NpgsqlPoint(x: 0.31237534304404313d, y: 0.23510249276819883d), new NpgsqlTypes.NpgsqlPoint(x: 0.4040560846232897d, y: 0.5545740165310179d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.867544904795589d, y: 0.14713323538271605d), new NpgsqlTypes.NpgsqlPoint(x: 0.2180256725001395d, y: 0.36894877542583226d), new NpgsqlTypes.NpgsqlPoint(x: 0.23799262581433978d, y: 0.9224093340736594d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5441370585274277d, y: 0.6000294495788665d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971600550760622d, y: 0.9282323525096031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9224215695803261d, y: 0.032323755666099796d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6857247863649951d, y: 0.797356693589672d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577508399029006d, y: 0.39665859751676713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840654198557254d, y: 0.03863903265161661d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7394213080025982d, y: 0.053482643679208075d), new NpgsqlTypes.NpgsqlPoint(x: 0.2771937552966056d, y: 0.0018025755846701186d), new NpgsqlTypes.NpgsqlPoint(x: 0.31160505618228584d, y: 0.5791764481187699d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4666486885693857d, y: 0.1706191994134404d), new NpgsqlTypes.NpgsqlPoint(x: 0.8518653599179485d, y: 0.789133423936801d), new NpgsqlTypes.NpgsqlPoint(x: 0.25705144730614227d, y: 0.5848639878379487d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2832206762936538d, y: 0.8218439670266889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8485620882129877d, y: 0.14384121180013887d), new NpgsqlTypes.NpgsqlPoint(x: 0.08792507912141623d, y: 0.6709394018241054d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3455790342649936d, y: 0.8726387865906008d), new NpgsqlTypes.NpgsqlPoint(x: 0.08152202647404916d, y: 0.7348674626455429d), new NpgsqlTypes.NpgsqlPoint(x: 0.30965104088394624d, y: 0.9877343550518994d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6075876099514859d, y: 0.3850320692200514d), new NpgsqlTypes.NpgsqlPoint(x: 0.9294962312496282d, y: 0.9577126919092221d), new NpgsqlTypes.NpgsqlPoint(x: 0.14400791832872029d, y: 0.9951500237500659d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6921937643481831d, y: 0.06168885073406005d), new NpgsqlTypes.NpgsqlPoint(x: 0.04814699826156765d, y: 0.8923717657509219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8178868350941599d, y: 0.7447348511103997d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6565409082691285d, y: 0.28062517202847337d), new NpgsqlTypes.NpgsqlPoint(x: 0.45883718986851296d, y: 0.6548185208591919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5305078794846794d, y: 0.7101470801572396d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02860225236781322d, y: 0.15802586446552924d), new NpgsqlTypes.NpgsqlPoint(x: 0.044482577641510646d, y: 0.6038878104635707d), new NpgsqlTypes.NpgsqlPoint(x: 0.3809570595497672d, y: 0.8536697969672933d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34360538556786513d, y: 0.9655091877868649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8650540888630368d, y: 0.09582359053402201d), new NpgsqlTypes.NpgsqlPoint(x: 0.10174253168743697d, y: 0.6443856610932306d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7749910711577322d, y: 0.6401128149395883d), new NpgsqlTypes.NpgsqlPoint(x: 0.29080444869584265d, y: 0.6356433445550999d), new NpgsqlTypes.NpgsqlPoint(x: 0.9261343709857186d, y: 0.17964581330437868d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9722518980228785d, y: 0.5948956013208065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8731488569532316d, y: 0.82546553225871d), new NpgsqlTypes.NpgsqlPoint(x: 0.41717476127305153d, y: 0.5717842630461165d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058695506678811404d, y: 0.4793240156183485d), new NpgsqlTypes.NpgsqlPoint(x: 0.14204906205211254d, y: 0.8767096060036512d), new NpgsqlTypes.NpgsqlPoint(x: 0.037635222960579084d, y: 0.9669295339195567d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18077160475474852d, y: 0.3642034217079919d), new NpgsqlTypes.NpgsqlPoint(x: 0.8836113735665493d, y: 0.5092412462058314d), new NpgsqlTypes.NpgsqlPoint(x: 0.018361546677291618d, y: 0.39243474414557933d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8717732143419205d, y: 0.13013123191270304d), new NpgsqlTypes.NpgsqlPoint(x: 0.009975292523088042d, y: 0.5078561991487097d), new NpgsqlTypes.NpgsqlPoint(x: 0.49350190246118386d, y: 0.22697755470482672d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2663530701075675d, y: 0.14874059290615915d), new NpgsqlTypes.NpgsqlPoint(x: 0.48800019440641473d, y: 0.8916254558244721d), new NpgsqlTypes.NpgsqlPoint(x: 0.17547939668531864d, y: 0.3823155230599693d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6031849234955557d, y: 0.8095475983116466d), new NpgsqlTypes.NpgsqlPoint(x: 0.251957640935878d, y: 0.24362500654729413d), new NpgsqlTypes.NpgsqlPoint(x: 0.1475066024718693d, y: 0.7308465672608745d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8227865181552892d, y: 0.8054768265251003d), new NpgsqlTypes.NpgsqlPoint(x: 0.3134419576443277d, y: 0.006032187601105243d), new NpgsqlTypes.NpgsqlPoint(x: 0.11780526294855398d, y: 0.7960959102843818d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9730466504179371d, y: 0.9605676938707065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061941596365191d, y: 0.8728563443280707d), new NpgsqlTypes.NpgsqlPoint(x: 0.507570193794547d, y: 0.4140644173408542d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31727455308878716d, y: 0.25131893588264986d), new NpgsqlTypes.NpgsqlPoint(x: 0.1269224274562878d, y: 0.4656487106360522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7679882285510359d, y: 0.4782664818419404d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19325051741642674d, y: 0.7398354508427711d), new NpgsqlTypes.NpgsqlPoint(x: 0.1929800703621598d, y: 0.5905968546835741d), new NpgsqlTypes.NpgsqlPoint(x: 0.6024169400196627d, y: 0.24789140929904452d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6339932033283614d, y: 0.42940083333693757d), new NpgsqlTypes.NpgsqlPoint(x: 0.3629259718978838d, y: 0.8673151875893262d), new NpgsqlTypes.NpgsqlPoint(x: 0.627815412718521d, y: 0.6656807774768343d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8446255083842679d, y: 0.23119822242421284d), new NpgsqlTypes.NpgsqlPoint(x: 0.15480010180535353d, y: 0.9124244675307702d), new NpgsqlTypes.NpgsqlPoint(x: 0.42147041885201675d, y: 0.6725449238226787d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7958977660484241d, y: 0.3579003950940407d), new NpgsqlTypes.NpgsqlPoint(x: 0.07332661603736679d, y: 0.8154489145609266d), new NpgsqlTypes.NpgsqlPoint(x: 0.1335178941451779d, y: 0.5021949700050768d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8393443460572836d, y: 0.04815672738482979d), new NpgsqlTypes.NpgsqlPoint(x: 0.27322963510668286d, y: 0.4236383304996766d), new NpgsqlTypes.NpgsqlPoint(x: 0.013435130008974894d, y: 0.27685576232011944d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8641007311548766d, y: 0.7522220184433502d), new NpgsqlTypes.NpgsqlPoint(x: 0.19183027746863135d, y: 0.6601494843489292d), new NpgsqlTypes.NpgsqlPoint(x: 0.4416712235255451d, y: 0.31022496816618894d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03675599994728884d, y: 0.48538821156397616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855403969046333d, y: 0.5589621502835724d), new NpgsqlTypes.NpgsqlPoint(x: 0.11991038580016822d, y: 0.9502943462138291d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3272500312230706d, y: 0.9901312342368329d), new NpgsqlTypes.NpgsqlPoint(x: 0.901911954978806d, y: 0.4200639656959684d), new NpgsqlTypes.NpgsqlPoint(x: 0.30464624285820596d, y: 0.11403916308161854d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4250759229976291d, y: 0.3476527279771776d), new NpgsqlTypes.NpgsqlPoint(x: 0.3463756276764237d, y: 0.5990313380555976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9505666164611775d, y: 0.4776740907917997d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1009475143051457d, y: 0.1778622688536955d), new NpgsqlTypes.NpgsqlPoint(x: 0.7631851724779007d, y: 0.9406474076253731d), new NpgsqlTypes.NpgsqlPoint(x: 0.3188357178512169d, y: 0.4888966821351781d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.460184527522293d, y: 0.7876884894989311d), new NpgsqlTypes.NpgsqlPoint(x: 0.16209523710968243d, y: 0.7031124650303754d), new NpgsqlTypes.NpgsqlPoint(x: 0.1823563761222743d, y: 0.34699752172941767d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.952852395319598d, y: 0.44528093784720757d), new NpgsqlTypes.NpgsqlPoint(x: 0.5311872757882762d, y: 0.10614810002856978d), new NpgsqlTypes.NpgsqlPoint(x: 0.0029905581170170947d, y: 0.7599741493210069d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.949771590552489d, y: 0.6255311631691427d), new NpgsqlTypes.NpgsqlPoint(x: 0.904078418480425d, y: 0.9109327853590976d), new NpgsqlTypes.NpgsqlPoint(x: 0.5586337906915165d, y: 0.5105795963219911d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15460555571283885d, y: 0.8431416488505926d), new NpgsqlTypes.NpgsqlPoint(x: 0.3164703770729401d, y: 0.9756240493275745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111866490449106d, y: 0.5257932528693482d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17692011718817546d, y: 0.809404051899705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7149277346978676d, y: 0.8885512684121761d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321546015272767d, y: 0.6052836089043944d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8106301098483266d, y: 0.5571274479625421d), new NpgsqlTypes.NpgsqlPoint(x: 0.23793747560902856d, y: 0.6433568323683585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9392890536411779d, y: 0.5495495204087579d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18521052435438679d, y: 0.9568702856928486d), new NpgsqlTypes.NpgsqlPoint(x: 0.28810309095055475d, y: 0.5599581474336384d), new NpgsqlTypes.NpgsqlPoint(x: 0.38771357930439065d, y: 0.6461172049829043d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20286040685761875d, y: 0.7589432805306104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3396154468268383d, y: 0.8751085494524781d), new NpgsqlTypes.NpgsqlPoint(x: 0.24050912696116877d, y: 0.7445088185862097d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7700835158974749d, y: 0.8132272621858724d), new NpgsqlTypes.NpgsqlPoint(x: 0.21736590591536165d, y: 0.5439947425741741d), new NpgsqlTypes.NpgsqlPoint(x: 0.41069442980854254d, y: 0.2249519903909356d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049127194847973565d, y: 0.23016175778075665d), new NpgsqlTypes.NpgsqlPoint(x: 0.033070709964047706d, y: 0.07289983934087585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9041744790646803d, y: 0.3370528841710708d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5394681859781554d, y: 0.28413704003725504d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025111621398935d, y: 0.8780673158695944d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412785274451746d, y: 0.3578121225339599d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03244722715409565d, y: 0.6790550271005631d), new NpgsqlTypes.NpgsqlPoint(x: 0.7515855805942658d, y: 0.663706079157187d), new NpgsqlTypes.NpgsqlPoint(x: 0.19581995606126834d, y: 0.7530138327339726d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8085749054349726d, y: 0.7589498131776257d), new NpgsqlTypes.NpgsqlPoint(x: 0.02809323753676307d, y: 0.207881391225073d), new NpgsqlTypes.NpgsqlPoint(x: 0.19741443212803678d, y: 0.07933971200499101d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3594417158490939d, y: 0.4469751069273795d), new NpgsqlTypes.NpgsqlPoint(x: 0.509644594472989d, y: 0.16344607817665324d), new NpgsqlTypes.NpgsqlPoint(x: 0.4941664743639943d, y: 0.15473789414371153d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.974308930340855d, y: 0.786180158948958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745878795222311d, y: 0.6513419476028743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9325808308779231d, y: 0.25761374022574424d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9248624209644525d, y: 0.09912537880480277d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825073735143083d, y: 0.7871221331080173d), new NpgsqlTypes.NpgsqlPoint(x: 0.30851811169775134d, y: 0.6836733493748577d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8794189295563418d, y: 0.11392878441740506d), new NpgsqlTypes.NpgsqlPoint(x: 0.27395169173440537d, y: 0.043954363541816255d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646765839923859d, y: 0.7035603411945295d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7107876298976188d, y: 0.6678829705036656d), new NpgsqlTypes.NpgsqlPoint(x: 0.7489042398000014d, y: 0.02272911078190254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9064299849327201d, y: 0.3424667940289251d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43309124160081547d, y: 0.4131814848022366d), new NpgsqlTypes.NpgsqlPoint(x: 0.37266515152500923d, y: 0.5482858482438042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411640983010101d, y: 0.9022354239389925d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8876597351998414d, y: 0.6302595359700872d), new NpgsqlTypes.NpgsqlPoint(x: 0.07202667660879924d, y: 0.19094785659033997d), new NpgsqlTypes.NpgsqlPoint(x: 0.40330932046343493d, y: 0.9681687583498637d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38295595542615035d, y: 0.9219589215224187d), new NpgsqlTypes.NpgsqlPoint(x: 0.6182422063121338d, y: 0.65457856369721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477665011088941d, y: 0.057247974149340575d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.585141521119526d, y: 0.14203201655976605d), new NpgsqlTypes.NpgsqlPoint(x: 0.1516793035919125d, y: 0.3008404588820789d), new NpgsqlTypes.NpgsqlPoint(x: 0.8948892915228133d, y: 0.3920069534692827d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03389950753115467d, y: 0.4930316719942869d), new NpgsqlTypes.NpgsqlPoint(x: 0.33678647310494736d, y: 0.2852601974308743d), new NpgsqlTypes.NpgsqlPoint(x: 0.06134443884213703d, y: 0.7926361866171823d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9448086355860421d, y: 0.3276696152870623d), new NpgsqlTypes.NpgsqlPoint(x: 0.8823732838757599d, y: 0.19743628845329075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7758400916549381d, y: 0.05020533174808284d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45646648784391863d, y: 0.5053812359609651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8035610333424174d, y: 0.7356608576444796d), new NpgsqlTypes.NpgsqlPoint(x: 0.8425922640866036d, y: 0.9262167413548529d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24596923673831306d, y: 0.6336193682568237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8948514012179479d, y: 0.8278114857435092d), new NpgsqlTypes.NpgsqlPoint(x: 0.4122173251242768d, y: 0.2813378355218875d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5136415091417441d, y: 0.6192180646012464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7607975887423687d, y: 0.14861617096584645d), new NpgsqlTypes.NpgsqlPoint(x: 0.05817439439177785d, y: 0.5566959208058762d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.775794333722429d, y: 0.8707409453077332d), new NpgsqlTypes.NpgsqlPoint(x: 0.22255902100810443d, y: 0.5878074664097811d), new NpgsqlTypes.NpgsqlPoint(x: 0.20341949596101538d, y: 0.8678184755858551d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22238201914861544d, y: 0.17960341787528666d), new NpgsqlTypes.NpgsqlPoint(x: 0.9428940886693664d, y: 0.8908673530100082d), new NpgsqlTypes.NpgsqlPoint(x: 0.14012097465006357d, y: 0.13699926893296677d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13613937951373267d, y: 0.6017701327908799d), new NpgsqlTypes.NpgsqlPoint(x: 0.08042702704583593d, y: 0.24856877010056222d), new NpgsqlTypes.NpgsqlPoint(x: 0.14675844101372892d, y: 0.7668267705855266d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.043717040088242065d, y: 0.5081410318762912d), new NpgsqlTypes.NpgsqlPoint(x: 0.10256444126659081d, y: 0.022521040882175103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8511269312855748d, y: 0.3314935592694216d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10412008126990446d, y: 0.06681457732393647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7310880009812479d, y: 0.576845755615075d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331643506405233d, y: 0.19065488979038547d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9935548726489021d, y: 0.19110009680647289d), new NpgsqlTypes.NpgsqlPoint(x: 0.131930885766533d, y: 0.552421844833404d), new NpgsqlTypes.NpgsqlPoint(x: 0.8933341339836215d, y: 0.6416369033805372d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4790704041123037d, y: 0.055211721081042886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8707548753618114d, y: 0.30868083671699176d), new NpgsqlTypes.NpgsqlPoint(x: 0.23133427657222916d, y: 0.15025050532171158d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12666527986542953d, y: 0.4682817321262035d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567398092842245d, y: 0.37978058605043385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8554919644766145d, y: 0.019461136109546806d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9120744348882239d, y: 0.1960308889157827d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139124533562378d, y: 0.0457391893185054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989862948646298d, y: 0.5538051104455295d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3347277310871851d, y: 0.10377912348079266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335116243343436d, y: 0.8766721256759711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2912870595527036d, y: 0.19181369097811973d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.038190843048909295d, y: 0.6213849382255088d), new NpgsqlTypes.NpgsqlPoint(x: 0.84210921328244d, y: 0.0662143835233594d), new NpgsqlTypes.NpgsqlPoint(x: 0.23098523831495832d, y: 0.40310800718212336d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7417968036414917d, y: 0.6759416258376357d), new NpgsqlTypes.NpgsqlPoint(x: 0.26537626458504004d, y: 0.9664466448248302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9705721596680746d, y: 0.39315866508568276d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.277863134147581d, y: 0.4499102841685889d), new NpgsqlTypes.NpgsqlPoint(x: 0.7145640624620626d, y: 0.21028423914628802d), new NpgsqlTypes.NpgsqlPoint(x: 0.8199735230578058d, y: 0.20441975432717385d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8998330367905853d, y: 0.7881824292555518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393563638412943d, y: 0.4967413723912629d), new NpgsqlTypes.NpgsqlPoint(x: 0.25488398278938096d, y: 0.11669276199139345d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.371569242888242d, y: 0.020904684586485756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9032999293441764d, y: 0.6095496385478716d), new NpgsqlTypes.NpgsqlPoint(x: 0.03461674633962075d, y: 0.8744865559211108d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8489390604743896d, y: 0.6200213501476082d), new NpgsqlTypes.NpgsqlPoint(x: 0.3038123968132226d, y: 0.8513796568273848d), new NpgsqlTypes.NpgsqlPoint(x: 0.4145916260099549d, y: 0.6762788003421498d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5457076939460648d, y: 0.6549061134797091d), new NpgsqlTypes.NpgsqlPoint(x: 0.6841064790973018d, y: 0.0961116803298756d), new NpgsqlTypes.NpgsqlPoint(x: 0.2216375478693996d, y: 0.7839190553827187d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15146655591682168d, y: 0.5287742490112961d), new NpgsqlTypes.NpgsqlPoint(x: 0.1094527367417637d, y: 0.3664023927358897d), new NpgsqlTypes.NpgsqlPoint(x: 0.6851458598163123d, y: 0.19777896959351393d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26597604260311547d, y: 0.17228888037222223d), new NpgsqlTypes.NpgsqlPoint(x: 0.38259339376667567d, y: 0.41580482661375207d), new NpgsqlTypes.NpgsqlPoint(x: 0.46448973379698955d, y: 0.6830317001715932d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20416551901297175d, y: 0.09775207967485877d), new NpgsqlTypes.NpgsqlPoint(x: 0.0012004100234420667d, y: 0.9349723204161022d), new NpgsqlTypes.NpgsqlPoint(x: 0.6316094514329516d, y: 0.634001220610494d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49806642238510945d, y: 0.5841581827264078d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699305928565704d, y: 0.6418389646897403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377497729014896d, y: 0.9701195300361943d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.890937371183309d, y: 0.7295747156555321d), new NpgsqlTypes.NpgsqlPoint(x: 0.32117979220428516d, y: 0.07018406164522362d), new NpgsqlTypes.NpgsqlPoint(x: 0.49877701908211136d, y: 0.44035470128023835d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7474626196612792d, y: 0.842477013577923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5884751432724112d, y: 0.645545565760825d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946896452135034d, y: 0.41128265140800324d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28377843473853726d, y: 0.626553882456756d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235728673279205d, y: 0.9963175403615309d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586272938891055d, y: 0.9491712024312583d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8438395827468198d, y: 0.6009455833258602d), new NpgsqlTypes.NpgsqlPoint(x: 0.5914466773896562d, y: 0.22876426894957924d), new NpgsqlTypes.NpgsqlPoint(x: 0.41979527990637855d, y: 0.6306023945078697d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9329178662253125d, y: 0.49316856359738537d), new NpgsqlTypes.NpgsqlPoint(x: 0.46148483856780886d, y: 0.855700542111343d), new NpgsqlTypes.NpgsqlPoint(x: 0.20245509339824685d, y: 0.22344480339131279d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.650387887660208d, y: 0.7630773219725568d), new NpgsqlTypes.NpgsqlPoint(x: 0.5088364540079813d, y: 0.6163308966321304d), new NpgsqlTypes.NpgsqlPoint(x: 0.7915076523774202d, y: 0.8306276101309965d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27590351665431545d, y: 0.9926975228559882d), new NpgsqlTypes.NpgsqlPoint(x: 0.873371460365695d, y: 0.2354320285493129d), new NpgsqlTypes.NpgsqlPoint(x: 0.5743084037574177d, y: 0.5414490079118749d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.828796023381461d, y: 0.624542668778342d), new NpgsqlTypes.NpgsqlPoint(x: 0.7464488348515389d, y: 0.4092342987350277d), new NpgsqlTypes.NpgsqlPoint(x: 0.32362841013265076d, y: 0.27123503612895294d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4186837491527666d, y: 0.3306498464704585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6261834716703343d, y: 0.9985042059353374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3619524669806703d, y: 0.35374471837869925d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8050287833546436d, y: 0.18409592432037525d), new NpgsqlTypes.NpgsqlPoint(x: 0.46823306709327417d, y: 0.33236722437379107d), new NpgsqlTypes.NpgsqlPoint(x: 0.038104958257689d, y: 0.423492779306365d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5720676561568907d, y: 0.5240957196883181d), new NpgsqlTypes.NpgsqlPoint(x: 0.007289896331012513d, y: 0.6091651265087236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7801371581695623d, y: 0.5570429696727556d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5299731995392747d, y: 0.2075935551123692d), new NpgsqlTypes.NpgsqlPoint(x: 0.7950310993177433d, y: 0.14317671330114035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390020476703376d, y: 0.16783852855153736d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43939422580168075d, y: 0.2499319861729663d), new NpgsqlTypes.NpgsqlPoint(x: 0.30980656491961633d, y: 0.7246245630470474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479023184947364d, y: 0.6251244812953972d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4506675974656188d, y: 0.9371191552391804d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461698804762356d, y: 0.5138490306616197d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084857472322128d, y: 0.8802544294208876d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25988909276298444d, y: 0.17584664862181887d), new NpgsqlTypes.NpgsqlPoint(x: 0.33579283085163336d, y: 0.9803468098777094d), new NpgsqlTypes.NpgsqlPoint(x: 0.975997311682013d, y: 0.6683684007395306d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03005213270936291d, y: 0.7357532259456604d), new NpgsqlTypes.NpgsqlPoint(x: 0.3097579073743504d, y: 0.3901302451131454d), new NpgsqlTypes.NpgsqlPoint(x: 0.5558932298363778d, y: 0.24718009988076772d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8409864872573976d, y: 0.23217100084186937d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231480219292522d, y: 0.1220466120206436d), new NpgsqlTypes.NpgsqlPoint(x: 0.1868418184463767d, y: 0.43138165241916804d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31606030340527014d, y: 0.2919050066745983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323162010375605d, y: 0.5178845642617639d), new NpgsqlTypes.NpgsqlPoint(x: 0.6749844760736706d, y: 0.060755790677082366d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9297184800349179d, y: 0.9489311160990327d), new NpgsqlTypes.NpgsqlPoint(x: 0.0480180590976258d, y: 0.04509386155971551d), new NpgsqlTypes.NpgsqlPoint(x: 0.07871934026081306d, y: 0.47147592479637657d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014248002930340897d, y: 0.5661423628833739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671468356979469d, y: 0.6062225133358188d), new NpgsqlTypes.NpgsqlPoint(x: 0.6707806766386021d, y: 0.33072965497927576d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1820553958839488d, y: 0.32236325825532597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8392546368911152d, y: 0.0231049861558128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080967696707859d, y: 0.6810700405965642d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41384180555189665d, y: 0.5310937372509469d), new NpgsqlTypes.NpgsqlPoint(x: 0.421575725942547d, y: 0.3443521680094791d), new NpgsqlTypes.NpgsqlPoint(x: 0.49052873619327864d, y: 0.9331233580071582d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5875677923969529d, y: 0.956760722310836d), new NpgsqlTypes.NpgsqlPoint(x: 0.06288752085990879d, y: 0.6915974084870621d), new NpgsqlTypes.NpgsqlPoint(x: 0.3109024781134443d, y: 0.5032115870399302d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9678018627828827d, y: 0.060225934552676774d), new NpgsqlTypes.NpgsqlPoint(x: 0.3922231620672979d, y: 0.3325616873489883d), new NpgsqlTypes.NpgsqlPoint(x: 0.49523791722278976d, y: 0.02157369674555465d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5966518861964262d, y: 0.006333459979801392d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920243279753338d, y: 0.8378443830826194d), new NpgsqlTypes.NpgsqlPoint(x: 0.8000119156324967d, y: 0.6478829688080139d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6740291626134844d, y: 0.2305589662651517d), new NpgsqlTypes.NpgsqlPoint(x: 0.13330707503666428d, y: 0.4683987810360456d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298422751808003d, y: 0.6601825307307997d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2076372169115307d, y: 0.09112265367434313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7036947790070206d, y: 0.29015253229842564d), new NpgsqlTypes.NpgsqlPoint(x: 0.44352892403493516d, y: 0.9443791385678427d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9999912574991677d, y: 0.09591059106377209d), new NpgsqlTypes.NpgsqlPoint(x: 0.19158956356816215d, y: 0.236688341054197d), new NpgsqlTypes.NpgsqlPoint(x: 0.802759237106619d, y: 0.9038970629018717d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9239649164038158d, y: 0.6777076128395563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6310991400350393d, y: 0.9294920122792101d), new NpgsqlTypes.NpgsqlPoint(x: 0.526588447925108d, y: 0.4156059525987822d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37891509177013327d, y: 0.24611972286955341d), new NpgsqlTypes.NpgsqlPoint(x: 0.36811089624834414d, y: 0.36059753191488264d), new NpgsqlTypes.NpgsqlPoint(x: 0.4371220076213259d, y: 0.797610176768584d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2834076821413898d, y: 0.5348643617582954d), new NpgsqlTypes.NpgsqlPoint(x: 0.6937116937403898d, y: 0.06948604829479854d), new NpgsqlTypes.NpgsqlPoint(x: 0.008076988563978094d, y: 0.9543821087394526d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8109726086851946d, y: 0.7502899923014673d), new NpgsqlTypes.NpgsqlPoint(x: 0.6136695243607679d, y: 0.3420878522315379d), new NpgsqlTypes.NpgsqlPoint(x: 0.10133320776535026d, y: 0.5332572051754456d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4191162314837136d, y: 0.12353126597239372d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939886282056636d, y: 0.8922503135227801d), new NpgsqlTypes.NpgsqlPoint(x: 0.2807386472755894d, y: 0.6798380883385542d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.552812868449149d, y: 0.2314918309414944d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514546998100875d, y: 0.5239534325721517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194632147985141d, y: 0.0848095713348126d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6040527415419114d, y: 0.35382122310967057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573276006720755d, y: 0.05999642673093564d), new NpgsqlTypes.NpgsqlPoint(x: 0.22953750967177555d, y: 0.816935834956796d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21897507753153833d, y: 0.05371349720215213d), new NpgsqlTypes.NpgsqlPoint(x: 0.6962106699657351d, y: 0.9287311822588088d), new NpgsqlTypes.NpgsqlPoint(x: 0.28347512260315455d, y: 0.9719345946446001d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2424908023653093d, y: 0.40854319697466435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6420419009275438d, y: 0.8327703885708205d), new NpgsqlTypes.NpgsqlPoint(x: 0.25985508624100107d, y: 0.0410856942132215d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6062320958231805d, y: 0.607398709943817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8240446040473713d, y: 0.5941881577513691d), new NpgsqlTypes.NpgsqlPoint(x: 0.9365508539735649d, y: 0.33446017057715527d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2909162012797797d, y: 0.19808518519455076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485639051680412d, y: 0.95126042305338d), new NpgsqlTypes.NpgsqlPoint(x: 0.5042031437439581d, y: 0.7074357031331319d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22119876158542218d, y: 0.8123780508090935d), new NpgsqlTypes.NpgsqlPoint(x: 0.46048996099859574d, y: 0.17290595324379066d), new NpgsqlTypes.NpgsqlPoint(x: 0.45621691736338177d, y: 0.902066829896915d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.603754928691477d, y: 0.10603124359307126d), new NpgsqlTypes.NpgsqlPoint(x: 0.3698105169679613d, y: 0.33063333449582644d), new NpgsqlTypes.NpgsqlPoint(x: 0.3230828009891612d, y: 0.993940847362172d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.543573790955919d, y: 0.47215190187647205d), new NpgsqlTypes.NpgsqlPoint(x: 0.19025681123173188d, y: 0.2940404930526538d), new NpgsqlTypes.NpgsqlPoint(x: 0.1138622306435253d, y: 0.8700580947681515d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17937034856898892d, y: 0.46325590931602867d), new NpgsqlTypes.NpgsqlPoint(x: 0.1942894279080447d, y: 0.9452813929779148d), new NpgsqlTypes.NpgsqlPoint(x: 0.5483231055072703d, y: 0.21486601374310454d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6835475317016786d, y: 0.43317368368638065d), new NpgsqlTypes.NpgsqlPoint(x: 0.42092308148847046d, y: 0.49133232080528244d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827648538463619d, y: 0.8679088454957191d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1431406627536298d, y: 0.7219416404399296d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627127834840064d, y: 0.7704962548264855d), new NpgsqlTypes.NpgsqlPoint(x: 0.04993305225592437d, y: 0.13161475938887024d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4707534765254646d, y: 0.4261792065925165d), new NpgsqlTypes.NpgsqlPoint(x: 0.07727034440029623d, y: 0.1628254994996785d), new NpgsqlTypes.NpgsqlPoint(x: 0.5244968014118779d, y: 0.1081639763691542d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6159380831108584d, y: 0.6817102075911989d), new NpgsqlTypes.NpgsqlPoint(x: 0.798177208036233d, y: 0.3713839407781925d), new NpgsqlTypes.NpgsqlPoint(x: 0.10363901234823225d, y: 0.057880256611354874d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7166918330582704d, y: 0.11780487688432206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8050903577855423d, y: 0.2771683333282162d), new NpgsqlTypes.NpgsqlPoint(x: 0.32146452921244906d, y: 0.2744921197528952d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4023548031192208d, y: 0.9453900556721212d), new NpgsqlTypes.NpgsqlPoint(x: 0.46621967884191606d, y: 0.9097794955504873d), new NpgsqlTypes.NpgsqlPoint(x: 0.08834579938424214d, y: 0.015813703273876767d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3766730642732813d, y: 0.16319996981595108d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124733958249171d, y: 0.17516805078177167d), new NpgsqlTypes.NpgsqlPoint(x: 0.033523043505255035d, y: 0.061173020780793674d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8539012376294347d, y: 0.8907077747942452d), new NpgsqlTypes.NpgsqlPoint(x: 0.29428490592685963d, y: 0.4225489906639225d), new NpgsqlTypes.NpgsqlPoint(x: 0.2609547450700973d, y: 0.8252865264372331d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29384948076265294d, y: 0.9276730283833506d), new NpgsqlTypes.NpgsqlPoint(x: 0.5546703732234856d, y: 0.3024496582249868d), new NpgsqlTypes.NpgsqlPoint(x: 0.6963923921256995d, y: 0.5985453316434214d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8420048312140399d, y: 0.6169459955884125d), new NpgsqlTypes.NpgsqlPoint(x: 0.4411156879803293d, y: 0.8493479732277731d), new NpgsqlTypes.NpgsqlPoint(x: 0.4942423754863471d, y: 0.3297427015642115d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1732443871398447d, y: 0.9662362824077483d), new NpgsqlTypes.NpgsqlPoint(x: 0.3999111625418085d, y: 0.9501639750939386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112985440894117d, y: 0.19247501171694958d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8229030929289907d, y: 0.9333728130896969d), new NpgsqlTypes.NpgsqlPoint(x: 0.2929842816127993d, y: 0.5485898217318776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054142087912294d, y: 0.9037017432429321d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3668189907549886d, y: 0.9122613724822369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9637769989524743d, y: 0.2899468452489956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5325640570516763d, y: 0.46058342388873463d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31639227418280513d, y: 0.6655157595154367d), new NpgsqlTypes.NpgsqlPoint(x: 0.698165632982348d, y: 0.8005046481419441d), new NpgsqlTypes.NpgsqlPoint(x: 0.860212117962798d, y: 0.4483395318873753d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07897435274197595d, y: 0.39715238276727716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9956030623265902d, y: 0.23656779136985118d), new NpgsqlTypes.NpgsqlPoint(x: 0.39723373053449573d, y: 0.7353509126640847d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6353783274270873d, y: 0.373181866447147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6528476354061991d, y: 0.16975383009409906d), new NpgsqlTypes.NpgsqlPoint(x: 0.19456433236287263d, y: 0.8650267221798543d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25883179594938965d, y: 0.26438588354597725d), new NpgsqlTypes.NpgsqlPoint(x: 0.953991029615781d, y: 0.9261664996799873d), new NpgsqlTypes.NpgsqlPoint(x: 0.8117579167741037d, y: 0.23921752697230647d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23629992908704245d, y: 0.5830567695654435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6043030820283797d, y: 0.9000775564503394d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827659944288395d, y: 0.7867264198650594d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22841285881636086d, y: 0.5355058663297426d), new NpgsqlTypes.NpgsqlPoint(x: 0.32672397721723434d, y: 0.03235624786221547d), new NpgsqlTypes.NpgsqlPoint(x: 0.32923765897937896d, y: 0.8005117173484235d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36028004021393767d, y: 0.8228043060362069d), new NpgsqlTypes.NpgsqlPoint(x: 0.4721158068365676d, y: 0.9245501711097159d), new NpgsqlTypes.NpgsqlPoint(x: 0.6191431201247903d, y: 0.6964224049839699d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3958433278598109d, y: 0.8364765957527749d), new NpgsqlTypes.NpgsqlPoint(x: 0.34255539267559165d, y: 0.7471807384754284d), new NpgsqlTypes.NpgsqlPoint(x: 0.003582449418466971d, y: 0.3345727037780192d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1485982503287685d, y: 0.5903310485824306d), new NpgsqlTypes.NpgsqlPoint(x: 0.11718531584548542d, y: 0.35959387827781863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9635758260857076d, y: 0.08011404227472119d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3716317816267375d, y: 0.4506220462126338d), new NpgsqlTypes.NpgsqlPoint(x: 0.37082243002113247d, y: 0.8264807312887378d), new NpgsqlTypes.NpgsqlPoint(x: 0.4763550368215166d, y: 0.5352265714991347d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5742601801955126d, y: 0.2345626852254754d), new NpgsqlTypes.NpgsqlPoint(x: 0.42065876275678127d, y: 0.01311264176997684d), new NpgsqlTypes.NpgsqlPoint(x: 0.22533378208050958d, y: 0.4087528599641935d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8435350673199865d, y: 0.6831823026737285d), new NpgsqlTypes.NpgsqlPoint(x: 0.23474453628015224d, y: 0.5888259334445836d), new NpgsqlTypes.NpgsqlPoint(x: 0.9244558407963372d, y: 0.33331472719178157d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6711409973253717d, y: 0.9978248034588677d), new NpgsqlTypes.NpgsqlPoint(x: 0.04421704939675564d, y: 0.41084440933945854d), new NpgsqlTypes.NpgsqlPoint(x: 0.15141927006390776d, y: 0.22810854920059687d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5250735166321915d, y: 0.9993944930770163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7716276746164865d, y: 0.8159677389235735d), new NpgsqlTypes.NpgsqlPoint(x: 0.5854474763586793d, y: 0.0967169323838547d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5977131292055318d, y: 0.0007924310108360366d), new NpgsqlTypes.NpgsqlPoint(x: 0.21269349280561822d, y: 0.5423838137598032d), new NpgsqlTypes.NpgsqlPoint(x: 0.4859870508497094d, y: 0.7533870588164774d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34494402263318236d, y: 0.2717889630362257d), new NpgsqlTypes.NpgsqlPoint(x: 0.6414187012218325d, y: 0.6209616876880499d), new NpgsqlTypes.NpgsqlPoint(x: 0.037219060707578744d, y: 0.8672405871152191d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07609307690925948d, y: 0.7666506368890476d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260069679621245d, y: 0.1923091921696748d), new NpgsqlTypes.NpgsqlPoint(x: 0.3592474919461486d, y: 0.7706698417610248d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29416001101695777d, y: 0.28610056912711535d), new NpgsqlTypes.NpgsqlPoint(x: 0.19090027715415714d, y: 0.5718715195715764d), new NpgsqlTypes.NpgsqlPoint(x: 0.03473768359832452d, y: 0.7083363243738903d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2049945321930121d, y: 0.6973084909885406d), new NpgsqlTypes.NpgsqlPoint(x: 0.43695701892646155d, y: 0.9604895793634171d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733653965985649d, y: 0.07163983213094882d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41699070676959604d, y: 0.2820920035281259d), new NpgsqlTypes.NpgsqlPoint(x: 0.3399521764576343d, y: 0.9193956132876419d), new NpgsqlTypes.NpgsqlPoint(x: 0.1248943828989526d, y: 0.43529783563848223d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7109191851624216d, y: 0.4037307135020365d), new NpgsqlTypes.NpgsqlPoint(x: 0.0022791925403238267d, y: 0.8682269272735895d), new NpgsqlTypes.NpgsqlPoint(x: 0.015881095502857545d, y: 0.38571515652286326d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35216646348828473d, y: 0.018978137716663346d), new NpgsqlTypes.NpgsqlPoint(x: 0.6073702572843146d, y: 0.707796304561718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8868443298167679d, y: 0.19828951678794016d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.629286238905489d, y: 0.3049158610036128d), new NpgsqlTypes.NpgsqlPoint(x: 0.13521132078944142d, y: 0.7771999739009583d), new NpgsqlTypes.NpgsqlPoint(x: 0.13678696692305337d, y: 0.33093499152457384d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049409914096092744d, y: 0.17751648515616014d), new NpgsqlTypes.NpgsqlPoint(x: 0.03325601475674744d, y: 0.6821337424883626d), new NpgsqlTypes.NpgsqlPoint(x: 0.850212144674135d, y: 0.638715529402969d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47865833046641193d, y: 0.5975824918257515d), new NpgsqlTypes.NpgsqlPoint(x: 0.687963261889018d, y: 0.5299615014571892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9279710902550456d, y: 0.4781371531099088d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4161302572957889d, y: 0.7991217599261112d), new NpgsqlTypes.NpgsqlPoint(x: 0.02407060029267505d, y: 0.4216697230793752d), new NpgsqlTypes.NpgsqlPoint(x: 0.08766152450868947d, y: 0.5750142317019505d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9105290354452619d, y: 0.2559712351930771d), new NpgsqlTypes.NpgsqlPoint(x: 0.24881798909562614d, y: 0.5834662427851449d), new NpgsqlTypes.NpgsqlPoint(x: 0.2929327432833485d, y: 0.8929340239367618d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2237532773932709d, y: 0.10268206606333607d), new NpgsqlTypes.NpgsqlPoint(x: 0.1926882602337251d, y: 0.5220606848664335d), new NpgsqlTypes.NpgsqlPoint(x: 0.3654764511606161d, y: 0.4332099169322309d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18589920076421584d, y: 0.0013391149203810793d), new NpgsqlTypes.NpgsqlPoint(x: 0.48730229043170425d, y: 0.4274243986428581d), new NpgsqlTypes.NpgsqlPoint(x: 0.4850426807537105d, y: 0.06395796809701482d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04820403373066673d, y: 0.151475286330092d), new NpgsqlTypes.NpgsqlPoint(x: 0.69080903551768d, y: 0.8927995536101412d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468314634453139d, y: 0.8660887015678764d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3452554404342646d, y: 0.9331915037042094d), new NpgsqlTypes.NpgsqlPoint(x: 0.24013678013801765d, y: 0.9151302808020767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9677749999583188d, y: 0.49444326227277613d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.80478428716844d, y: 0.3163820875725436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412538362276547d, y: 0.8073381186670229d), new NpgsqlTypes.NpgsqlPoint(x: 0.28537155855494833d, y: 0.16507496696419166d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9356941792303054d, y: 0.030855398932450262d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522914300943557d, y: 0.7126424483747092d), new NpgsqlTypes.NpgsqlPoint(x: 0.30184225718372126d, y: 0.03429445563978095d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8927120744778234d, y: 0.7126501531891591d), new NpgsqlTypes.NpgsqlPoint(x: 0.34548258262103215d, y: 0.6800024376408107d), new NpgsqlTypes.NpgsqlPoint(x: 0.15911466719622536d, y: 0.4018725676541086d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3586417874346245d, y: 0.7634730817837831d), new NpgsqlTypes.NpgsqlPoint(x: 0.9370643785816255d, y: 0.6966873441958651d), new NpgsqlTypes.NpgsqlPoint(x: 0.6067028468957267d, y: 0.3091778167903325d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.637207331213588d, y: 0.5906106384018687d), new NpgsqlTypes.NpgsqlPoint(x: 0.40265851755541227d, y: 0.7782630038236767d), new NpgsqlTypes.NpgsqlPoint(x: 0.022148465266100703d, y: 0.1685879835900671d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9624154017581077d, y: 0.0030101494108295546d), new NpgsqlTypes.NpgsqlPoint(x: 0.4125429230457688d, y: 0.736423522065579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739398979526205d, y: 0.09274801016327794d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14947587005233398d, y: 0.409022041957968d), new NpgsqlTypes.NpgsqlPoint(x: 0.6870207185571809d, y: 0.23841981638731524d), new NpgsqlTypes.NpgsqlPoint(x: 0.11064657978576709d, y: 0.16059788184499024d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9159345096951027d, y: 0.61152627788106d), new NpgsqlTypes.NpgsqlPoint(x: 0.2917892154364735d, y: 0.5015473764244703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7133068510295545d, y: 0.6967936010973762d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9993673495125255d, y: 0.3829512829457963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7659278311281359d, y: 0.9148795136341393d), new NpgsqlTypes.NpgsqlPoint(x: 0.5144533071110775d, y: 0.9114412059699329d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10863848697145706d, y: 0.5433927329987162d), new NpgsqlTypes.NpgsqlPoint(x: 0.09700302794047289d, y: 0.8190293873313629d), new NpgsqlTypes.NpgsqlPoint(x: 0.5117650793567484d, y: 0.46571072494871957d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4142025766842903d, y: 0.4795338961151251d), new NpgsqlTypes.NpgsqlPoint(x: 0.08325246208082449d, y: 0.28143775196844534d), new NpgsqlTypes.NpgsqlPoint(x: 0.10024538554715245d, y: 0.6157215488627893d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4241718960731765d, y: 0.8660272705376073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878615824588876d, y: 0.21899625709620885d), new NpgsqlTypes.NpgsqlPoint(x: 0.42076161647377763d, y: 0.6541579007171882d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7326457733044428d, y: 0.03394431467322245d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564195345999208d, y: 0.1718819206264962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5837783810385835d, y: 0.9871562397337224d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6748879643111398d, y: 0.15361560895356985d), new NpgsqlTypes.NpgsqlPoint(x: 0.21329503895185786d, y: 0.21557267919586154d), new NpgsqlTypes.NpgsqlPoint(x: 0.3569461227841575d, y: 0.47389113748670586d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012107999579117679d, y: 0.7289905636429963d), new NpgsqlTypes.NpgsqlPoint(x: 0.8386613265465875d, y: 0.09568733787392836d), new NpgsqlTypes.NpgsqlPoint(x: 0.534538274551274d, y: 0.8453181226434063d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35588217557858703d, y: 0.39572104664751495d), new NpgsqlTypes.NpgsqlPoint(x: 0.36447391531177387d, y: 0.8875052205593374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521272940916326d, y: 0.21484194824987146d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.670608708835334d, y: 0.15441042444823339d), new NpgsqlTypes.NpgsqlPoint(x: 0.8921431641402325d, y: 0.6033259593188351d), new NpgsqlTypes.NpgsqlPoint(x: 0.6321004834395381d, y: 0.48478773545721565d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24049596541765783d, y: 0.17155192674669273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142160956940032d, y: 0.4331859121451168d), new NpgsqlTypes.NpgsqlPoint(x: 0.7497044858298707d, y: 0.8761267900978181d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8613973367550585d, y: 0.4656538698481846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7595180134212538d, y: 0.8642573199720048d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639484611937537d, y: 0.4103430623821209d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8069148957645282d, y: 0.02159294326810879d), new NpgsqlTypes.NpgsqlPoint(x: 0.9193747719755632d, y: 0.6647669610156928d), new NpgsqlTypes.NpgsqlPoint(x: 0.07267912296668655d, y: 0.39975388993369776d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28444823477389924d, y: 0.9643187821436886d), new NpgsqlTypes.NpgsqlPoint(x: 0.4255239056068576d, y: 0.6788297273173051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8300507063433498d, y: 0.5847137989056121d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.988012576261172d, y: 0.02575406950191994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5226528745121175d, y: 0.639755771240824d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991334846041003d, y: 0.16039573330104584d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1507351312666999d, y: 0.9110043525644824d), new NpgsqlTypes.NpgsqlPoint(x: 0.15918041383592052d, y: 0.4989901335010982d), new NpgsqlTypes.NpgsqlPoint(x: 0.07868536901529699d, y: 0.7086312085639431d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32389100663316894d, y: 0.39795497121397727d), new NpgsqlTypes.NpgsqlPoint(x: 0.30373766587689854d, y: 0.013685903218271567d), new NpgsqlTypes.NpgsqlPoint(x: 0.4521858413108951d, y: 0.07464039498284458d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6307327228712988d, y: 0.36940885302397386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7909231259417092d, y: 0.2416371501812703d), new NpgsqlTypes.NpgsqlPoint(x: 0.2621770517231018d, y: 0.716330403698145d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9361767834824424d, y: 0.13688454577092402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7805557598926202d, y: 0.47521370167761756d), new NpgsqlTypes.NpgsqlPoint(x: 0.39581174718346424d, y: 0.03317112777618736d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9942255396811753d, y: 0.31088372742454606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036115487583918d, y: 0.022499899369338383d), new NpgsqlTypes.NpgsqlPoint(x: 0.11804751460788665d, y: 0.43735979494676136d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8500034263859048d, y: 0.535833887737045d), new NpgsqlTypes.NpgsqlPoint(x: 0.3987602488380807d, y: 0.09130841418551072d), new NpgsqlTypes.NpgsqlPoint(x: 0.35911301021063d, y: 0.3265001145382209d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.919071055559675d, y: 0.47953266688470686d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601241877975068d, y: 0.2998432925836251d), new NpgsqlTypes.NpgsqlPoint(x: 0.7637984986722636d, y: 0.13832521283313337d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6728909247202508d, y: 0.16568887465089133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814560691100165d, y: 0.4050079113812449d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686813167397479d, y: 0.5734111915925966d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5025770246460409d, y: 0.42665571156686444d), new NpgsqlTypes.NpgsqlPoint(x: 0.05436864906268846d, y: 0.9849111337709624d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206164728223499d, y: 0.5058365316814922d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6276670730178702d, y: 0.6710043933536333d), new NpgsqlTypes.NpgsqlPoint(x: 0.20380384810825503d, y: 0.5741400962725324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7683398224166603d, y: 0.029911477630159777d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3291702164924598d, y: 0.9918511737186252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6699001262742831d, y: 0.5288841559548844d), new NpgsqlTypes.NpgsqlPoint(x: 0.2077141997353631d, y: 0.6968578976362002d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8300288574008533d, y: 0.8678959787922186d), new NpgsqlTypes.NpgsqlPoint(x: 0.34411228359270074d, y: 0.5314823253257898d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584562115347626d, y: 0.17400140817912402d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4854211053846381d, y: 0.5535452238012889d), new NpgsqlTypes.NpgsqlPoint(x: 0.6598456684010099d, y: 0.40107836186021817d), new NpgsqlTypes.NpgsqlPoint(x: 0.7740578892728891d, y: 0.46027086462019373d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21614996158071764d, y: 0.8954402368266776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9679231049234297d, y: 0.4456926414468435d), new NpgsqlTypes.NpgsqlPoint(x: 0.46776638680246496d, y: 0.21710417190106046d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1772227455207842d, y: 0.9529216435803455d), new NpgsqlTypes.NpgsqlPoint(x: 0.3592805717826414d, y: 0.6797154158203422d), new NpgsqlTypes.NpgsqlPoint(x: 0.47103360790397675d, y: 0.7551690586692742d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4325811876759711d, y: 0.6483809033693783d), new NpgsqlTypes.NpgsqlPoint(x: 0.7800016491750867d, y: 0.4370153331075597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8753894737196709d, y: 0.6954280674682245d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9835853420313084d, y: 0.7858690694263538d), new NpgsqlTypes.NpgsqlPoint(x: 0.4120765868419498d, y: 0.9576930519379537d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971131908929008d, y: 0.492145864926406d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8071692416312094d, y: 0.278868968441604d), new NpgsqlTypes.NpgsqlPoint(x: 0.08751475703528133d, y: 0.41822844220570865d), new NpgsqlTypes.NpgsqlPoint(x: 0.2250038572994869d, y: 0.47700451475284344d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9172330487681992d, y: 0.4479875039629765d), new NpgsqlTypes.NpgsqlPoint(x: 0.23552800864240675d, y: 0.024384512912850598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6237137706392262d, y: 0.5858096000192751d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7912500693831538d, y: 0.5361840235297917d), new NpgsqlTypes.NpgsqlPoint(x: 0.011395848038310397d, y: 0.6513774808803668d), new NpgsqlTypes.NpgsqlPoint(x: 0.41687732494352014d, y: 0.41809633783939126d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9508354859271995d, y: 0.44049190248407777d), new NpgsqlTypes.NpgsqlPoint(x: 0.5842570224033914d, y: 0.8530047715657386d), new NpgsqlTypes.NpgsqlPoint(x: 0.07465981513129571d, y: 0.6452534058758345d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9379787400005704d, y: 0.4588591564778177d), new NpgsqlTypes.NpgsqlPoint(x: 0.03094601298031474d, y: 0.16373219445555587d), new NpgsqlTypes.NpgsqlPoint(x: 0.2281443897135882d, y: 0.7159913834974536d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.922124245323407d, y: 0.790907522381219d), new NpgsqlTypes.NpgsqlPoint(x: 0.9187558005222306d, y: 0.5898451998413272d), new NpgsqlTypes.NpgsqlPoint(x: 0.34452087820679955d, y: 0.15369656794917652d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7274830164060895d, y: 0.8355264564835757d), new NpgsqlTypes.NpgsqlPoint(x: 0.28854495186237805d, y: 0.9276175922921855d), new NpgsqlTypes.NpgsqlPoint(x: 0.19342664900176842d, y: 0.2528788520727451d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8087491129326692d, y: 0.3173173235045652d), new NpgsqlTypes.NpgsqlPoint(x: 0.5916617353461142d, y: 0.6941766054579653d), new NpgsqlTypes.NpgsqlPoint(x: 0.03620049123790792d, y: 0.9757046823870275d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11994413249729285d, y: 0.6557380335254496d), new NpgsqlTypes.NpgsqlPoint(x: 0.42509498492568676d, y: 0.5254532727449899d), new NpgsqlTypes.NpgsqlPoint(x: 0.24260375911825982d, y: 0.2190311086312875d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8315577690034637d, y: 0.9468269091009527d), new NpgsqlTypes.NpgsqlPoint(x: 0.544036992852175d, y: 0.7584194166051911d), new NpgsqlTypes.NpgsqlPoint(x: 0.7072974915209636d, y: 0.4288250394760733d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2397738285900589d, y: 0.000918953570063219d), new NpgsqlTypes.NpgsqlPoint(x: 0.3263216138368523d, y: 0.23248995646576776d), new NpgsqlTypes.NpgsqlPoint(x: 0.10136061802471508d, y: 0.7940108774199278d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7928003214348237d, y: 0.4319406267634269d), new NpgsqlTypes.NpgsqlPoint(x: 0.04958103864553487d, y: 0.43752102145964766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152177827874071d, y: 0.4741777078064102d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5082116329703361d, y: 0.5633415740511144d), new NpgsqlTypes.NpgsqlPoint(x: 0.33927295777815303d, y: 0.8691610779853388d), new NpgsqlTypes.NpgsqlPoint(x: 0.992099214498277d, y: 0.6788174709250671d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32394362815772026d, y: 0.23022219293020008d), new NpgsqlTypes.NpgsqlPoint(x: 0.86801430287852d, y: 0.5346085577347846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5883945669397107d, y: 0.3265479818154726d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5253251116345625d, y: 0.6051225243979734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968343794644591d, y: 0.22392721473649158d), new NpgsqlTypes.NpgsqlPoint(x: 0.23347025604663996d, y: 0.4947500523082864d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44557363235518155d, y: 0.7142375358230064d), new NpgsqlTypes.NpgsqlPoint(x: 0.936736573192084d, y: 0.39508025521038503d), new NpgsqlTypes.NpgsqlPoint(x: 0.26005205030874046d, y: 0.6118301642282475d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42090466576134133d, y: 0.885864370662475d), new NpgsqlTypes.NpgsqlPoint(x: 0.2117283719757186d, y: 0.9559097192906546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073092607396916d, y: 0.1840536582607304d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8653522264075633d, y: 0.2565189104214394d), new NpgsqlTypes.NpgsqlPoint(x: 0.8823795240318978d, y: 0.7989653448467033d), new NpgsqlTypes.NpgsqlPoint(x: 0.5821381299539299d, y: 0.9956005504507945d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9095440319544679d, y: 0.18486832941315257d), new NpgsqlTypes.NpgsqlPoint(x: 0.22881574503286595d, y: 0.6696681469481359d), new NpgsqlTypes.NpgsqlPoint(x: 0.06548515598047622d, y: 0.7425106717130805d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5023673871853995d, y: 0.5478533903112311d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091089987893233d, y: 0.32306191499233383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7320207950021191d, y: 0.47304475390010037d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2735915533157105d, y: 0.5304633706013288d), new NpgsqlTypes.NpgsqlPoint(x: 0.35443267140543067d, y: 0.13839995631113278d), new NpgsqlTypes.NpgsqlPoint(x: 0.5951873252743263d, y: 0.581462876440364d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49468665965120395d, y: 0.4240616086255028d), new NpgsqlTypes.NpgsqlPoint(x: 0.3526987914158842d, y: 0.35885891903940503d), new NpgsqlTypes.NpgsqlPoint(x: 0.13693589778718285d, y: 0.7973538756991048d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41602363138886644d, y: 0.4787699624984677d), new NpgsqlTypes.NpgsqlPoint(x: 0.29316550622623494d, y: 0.2924210333631333d), new NpgsqlTypes.NpgsqlPoint(x: 0.4444101477476481d, y: 0.7521263211244896d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4716362738815285d, y: 0.34307514285659746d), new NpgsqlTypes.NpgsqlPoint(x: 0.22101269490336128d, y: 0.03283233526012497d), new NpgsqlTypes.NpgsqlPoint(x: 0.5945212890559535d, y: 0.32703654027705087d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8519689798587401d, y: 0.5899178543728629d), new NpgsqlTypes.NpgsqlPoint(x: 0.9817201526360733d, y: 0.7210421539282826d), new NpgsqlTypes.NpgsqlPoint(x: 0.9872738907935924d, y: 0.11072141159827176d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5840916259333746d, y: 0.8317451947260348d), new NpgsqlTypes.NpgsqlPoint(x: 0.5745470091421205d, y: 0.2117208874571448d), new NpgsqlTypes.NpgsqlPoint(x: 0.3379478482329674d, y: 0.4351449141384901d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2126059942066878d, y: 0.20490354401981614d), new NpgsqlTypes.NpgsqlPoint(x: 0.8438859123747721d, y: 0.7252299104597113d), new NpgsqlTypes.NpgsqlPoint(x: 0.9580778284848726d, y: 0.010626986906694835d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45678613795800227d, y: 0.2931202498335975d), new NpgsqlTypes.NpgsqlPoint(x: 0.1932883775859372d, y: 0.40584164773441433d), new NpgsqlTypes.NpgsqlPoint(x: 0.7603455497521319d, y: 0.1754007059785999d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3659414576467519d, y: 0.8138789994588941d), new NpgsqlTypes.NpgsqlPoint(x: 0.531912767665498d, y: 0.7124517540366764d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169804606681776d, y: 0.09127045604734418d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9202085252234332d, y: 0.7993235041516514d), new NpgsqlTypes.NpgsqlPoint(x: 0.11512042225456365d, y: 0.37459127290739824d), new NpgsqlTypes.NpgsqlPoint(x: 0.23026487604766932d, y: 0.9109791954092328d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9497086758853099d, y: 0.8364028855284148d), new NpgsqlTypes.NpgsqlPoint(x: 0.37319023481781033d, y: 0.559882767847947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167752623869023d, y: 0.03065375160980921d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6897481216048104d, y: 0.8817147574106172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6634214049853282d, y: 0.58843762905367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5022642825005937d, y: 0.8400567131105902d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3373805368740528d, y: 0.39202608680963325d), new NpgsqlTypes.NpgsqlPoint(x: 0.22295516156798667d, y: 0.9932995720688795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5803648078676905d, y: 0.7768894626832539d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3277127243193272d, y: 0.3036175814602263d), new NpgsqlTypes.NpgsqlPoint(x: 0.07934043616815223d, y: 0.9077393907978918d), new NpgsqlTypes.NpgsqlPoint(x: 0.22348771494018482d, y: 0.6261460569581995d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.042893826860569306d, y: 0.4730970845392104d), new NpgsqlTypes.NpgsqlPoint(x: 0.19254817383715417d, y: 0.7296894972649888d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903329467997205d, y: 0.5968455127149341d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7812052585025981d, y: 0.29210108585081573d), new NpgsqlTypes.NpgsqlPoint(x: 0.24939230645485422d, y: 0.5093659775846988d), new NpgsqlTypes.NpgsqlPoint(x: 0.7932466354660496d, y: 0.12253766355695883d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.349147571581232d, y: 0.70651105593631d), new NpgsqlTypes.NpgsqlPoint(x: 0.5065464703272639d, y: 0.6690992850558427d), new NpgsqlTypes.NpgsqlPoint(x: 0.9327713768114225d, y: 0.3434268117891295d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8872143058039718d, y: 0.5955391228907716d), new NpgsqlTypes.NpgsqlPoint(x: 0.7294654427291708d, y: 0.09844196955475693d), new NpgsqlTypes.NpgsqlPoint(x: 0.6419182947211723d, y: 0.8533023354470297d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6389102856996366d, y: 0.3806582123474249d), new NpgsqlTypes.NpgsqlPoint(x: 0.9118488572024194d, y: 0.2669268455424687d), new NpgsqlTypes.NpgsqlPoint(x: 0.4773982966729391d, y: 0.43167609418759856d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16657228269786306d, y: 0.13880220657430242d), new NpgsqlTypes.NpgsqlPoint(x: 0.701136636138663d, y: 0.44352253373538486d), new NpgsqlTypes.NpgsqlPoint(x: 0.1747314283335054d, y: 0.6932006338379151d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7394216287317376d, y: 0.7859803533219095d), new NpgsqlTypes.NpgsqlPoint(x: 0.571809964246335d, y: 0.15302519616975452d), new NpgsqlTypes.NpgsqlPoint(x: 0.22518777824527458d, y: 0.2649301354891219d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5508191217758672d, y: 0.5848268461311751d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402270718290238d, y: 0.3045555792483329d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467941129328777d, y: 0.11482920792380547d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.451611186289263d, y: 0.6232520603757647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7614338939115131d, y: 0.8582803212727185d), new NpgsqlTypes.NpgsqlPoint(x: 0.1128492510727771d, y: 0.8889583397033672d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41422574888060437d, y: 0.7416426043749864d), new NpgsqlTypes.NpgsqlPoint(x: 0.7192292000333408d, y: 0.27093844966479785d), new NpgsqlTypes.NpgsqlPoint(x: 0.4236893335639572d, y: 0.6861802153884824d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7616334601738731d, y: 0.9831325753429381d), new NpgsqlTypes.NpgsqlPoint(x: 0.1606551608888056d, y: 0.0537858304734139d), new NpgsqlTypes.NpgsqlPoint(x: 0.4725828547180583d, y: 0.9361037377782571d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16117484583046782d, y: 0.05927504348788859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053392809150607d, y: 0.9978925048783382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9804801806568976d, y: 0.7864989196309797d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09019560604506371d, y: 0.6967825784992624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5368174903300252d, y: 0.2427727744931647d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936432096358376d, y: 0.627532136930069d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6770171488287842d, y: 0.6492275351573511d), new NpgsqlTypes.NpgsqlPoint(x: 0.6074244757452762d, y: 0.695294034724357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5200862899672003d, y: 0.7775191599768674d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6641655921833457d, y: 0.5896555295478397d), new NpgsqlTypes.NpgsqlPoint(x: 0.04317653543911115d, y: 0.6507044343063767d), new NpgsqlTypes.NpgsqlPoint(x: 0.0614229580975626d, y: 0.7812277198752117d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2975432211844875d, y: 0.4435795709249021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205097880564967d, y: 0.9752591968723855d), new NpgsqlTypes.NpgsqlPoint(x: 0.128829323326085d, y: 0.31977353712657786d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7868225112824359d, y: 0.9224552480531534d), new NpgsqlTypes.NpgsqlPoint(x: 0.015863677468519688d, y: 0.9848601355039082d), new NpgsqlTypes.NpgsqlPoint(x: 0.30204593317224215d, y: 0.4161048358764138d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.435925527637231d, y: 0.9190837859096526d), new NpgsqlTypes.NpgsqlPoint(x: 0.07768035613776947d, y: 0.7042408967235776d), new NpgsqlTypes.NpgsqlPoint(x: 0.1691234872642271d, y: 0.9848318051254462d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0012134610158146542d, y: 0.5809391551252535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3473261513465675d, y: 0.6792365444934166d), new NpgsqlTypes.NpgsqlPoint(x: 0.2210924655119313d, y: 0.9560342264991283d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023062255240483d, y: 0.07023039013035837d), new NpgsqlTypes.NpgsqlPoint(x: 0.3292956820370294d, y: 0.037180696317531514d), new NpgsqlTypes.NpgsqlPoint(x: 0.07759372537756293d, y: 0.03866051280755223d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45670403353837286d, y: 0.858285261834425d), new NpgsqlTypes.NpgsqlPoint(x: 0.6103412666099403d, y: 0.9054339280814814d), new NpgsqlTypes.NpgsqlPoint(x: 0.7360698491162817d, y: 0.11755213794777875d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6485520908780256d, y: 0.6159028634675883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9484476173082368d, y: 0.020739881633267232d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892548764324105d, y: 0.6172740699566748d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2303311829921566d, y: 0.03296086203987736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701211980198894d, y: 0.15229023025658772d), new NpgsqlTypes.NpgsqlPoint(x: 0.6050743301042516d, y: 0.2755031790673913d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2895060843329771d, y: 0.5842927239419308d), new NpgsqlTypes.NpgsqlPoint(x: 0.7520579386772115d, y: 0.1992845270986342d), new NpgsqlTypes.NpgsqlPoint(x: 0.13961248348393784d, y: 0.0428226213209304d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08579397183598703d, y: 0.5532367063156917d), new NpgsqlTypes.NpgsqlPoint(x: 0.230261275654842d, y: 0.2723095863748377d), new NpgsqlTypes.NpgsqlPoint(x: 0.6327425024351742d, y: 0.17996748461971346d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5231359222110675d, y: 0.8475640203526053d), new NpgsqlTypes.NpgsqlPoint(x: 0.42289616340682734d, y: 0.0209780306626568d), new NpgsqlTypes.NpgsqlPoint(x: 0.2815973938026485d, y: 0.9805370159494635d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8730928940264961d, y: 0.8900502554622595d), new NpgsqlTypes.NpgsqlPoint(x: 0.03917529092196448d, y: 0.012574279590122361d), new NpgsqlTypes.NpgsqlPoint(x: 0.16005937148364802d, y: 0.82831910573857d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07050971456575916d, y: 0.7931705532505144d), new NpgsqlTypes.NpgsqlPoint(x: 0.4144102773854088d, y: 0.0546997528034463d), new NpgsqlTypes.NpgsqlPoint(x: 0.19504360321382974d, y: 0.24651781519705174d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7549463705797871d, y: 0.6497732975005518d), new NpgsqlTypes.NpgsqlPoint(x: 0.6585508518722926d, y: 0.3107636878239858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702199570014179d, y: 0.26522477867636607d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7782905052051243d, y: 0.14274251083933764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8000368759897584d, y: 0.7013078732444911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8286416182650097d, y: 0.8567144854855993d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23092367799094204d, y: 0.2830335718528816d), new NpgsqlTypes.NpgsqlPoint(x: 0.44833727316814265d, y: 0.24734356269461955d), new NpgsqlTypes.NpgsqlPoint(x: 0.6318907686478543d, y: 0.8542466438846599d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3995707506181654d, y: 0.5174944428603567d), new NpgsqlTypes.NpgsqlPoint(x: 0.4869630682809397d, y: 0.8705378924963928d), new NpgsqlTypes.NpgsqlPoint(x: 0.2592652509585095d, y: 0.6875296779856069d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3166057347578276d, y: 0.7588831602559378d), new NpgsqlTypes.NpgsqlPoint(x: 0.18298622403006304d, y: 0.4744627218141132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6929322672472696d, y: 0.2736844918265854d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6797816067411808d, y: 0.9083001281957022d), new NpgsqlTypes.NpgsqlPoint(x: 0.5978207926796325d, y: 0.5313915995596094d), new NpgsqlTypes.NpgsqlPoint(x: 0.5877327337897693d, y: 0.8274879123466479d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6212591144812739d, y: 0.20964443860186832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8780802339696666d, y: 0.8227799865840337d), new NpgsqlTypes.NpgsqlPoint(x: 0.09583601979262191d, y: 0.8164464772928083d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.925678093910644d, y: 0.5751285628225623d), new NpgsqlTypes.NpgsqlPoint(x: 0.3121415183387021d, y: 0.2374686799738993d), new NpgsqlTypes.NpgsqlPoint(x: 0.16254271768339046d, y: 0.8236915094898711d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04280115710476606d, y: 0.5152096349828779d), new NpgsqlTypes.NpgsqlPoint(x: 0.01796098989829298d, y: 0.8029198993824069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8876778618295267d, y: 0.5459282259006832d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8122609773227144d, y: 0.610825468599507d), new NpgsqlTypes.NpgsqlPoint(x: 0.657487607571213d, y: 0.16779025793798696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298591841665107d, y: 0.5098447765884392d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4406225685596177d, y: 0.505404517524588d), new NpgsqlTypes.NpgsqlPoint(x: 0.506482032409833d, y: 0.024361292907133625d), new NpgsqlTypes.NpgsqlPoint(x: 0.37356742306641166d, y: 0.5921166669468496d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3714689437079223d, y: 0.6409653184409569d), new NpgsqlTypes.NpgsqlPoint(x: 0.24333234648868995d, y: 0.8588981754038231d), new NpgsqlTypes.NpgsqlPoint(x: 0.840829193485032d, y: 0.9055188433147126d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6919529022782916d, y: 0.4099628061925876d), new NpgsqlTypes.NpgsqlPoint(x: 0.4864701896928124d, y: 0.13691358022162337d), new NpgsqlTypes.NpgsqlPoint(x: 0.4990741791196971d, y: 0.054328800169993086d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46143305297035375d, y: 0.46338629015735844d), new NpgsqlTypes.NpgsqlPoint(x: 0.6434235048115192d, y: 0.7155784767971685d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583487953760489d, y: 0.4864178320212518d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22797678388080733d, y: 0.9015106247500279d), new NpgsqlTypes.NpgsqlPoint(x: 0.18042477170611837d, y: 0.5196073390092256d), new NpgsqlTypes.NpgsqlPoint(x: 0.38819793918893375d, y: 0.37960653206957173d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.936435053121756d, y: 0.7113955204066945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7306923758769696d, y: 0.2599286440751297d), new NpgsqlTypes.NpgsqlPoint(x: 0.047330620043324d, y: 0.1691774427339391d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4705873194099488d, y: 0.9075360662478519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5867096017621275d, y: 0.23345887042596747d), new NpgsqlTypes.NpgsqlPoint(x: 0.5334752871640097d, y: 0.20352358672393567d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6270973832465745d, y: 0.699140235763319d), new NpgsqlTypes.NpgsqlPoint(x: 0.4364328794846425d, y: 0.45690078558125236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776435366268628d, y: 0.9276136735376768d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46206553582880217d, y: 0.06837757073926909d), new NpgsqlTypes.NpgsqlPoint(x: 0.6271740586975413d, y: 0.19047139516422296d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167017548047185d, y: 0.5564058712843777d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34780273166458064d, y: 0.3134085916561625d), new NpgsqlTypes.NpgsqlPoint(x: 0.7541368969331456d, y: 0.05658027187828918d), new NpgsqlTypes.NpgsqlPoint(x: 0.23858262805458852d, y: 0.6939780007877714d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12224305228988142d, y: 0.6039091204671334d), new NpgsqlTypes.NpgsqlPoint(x: 0.360238257486321d, y: 0.7966263547276551d), new NpgsqlTypes.NpgsqlPoint(x: 0.05211282750111956d, y: 0.749514976328062d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.692959755795636d, y: 0.1041704767521463d), new NpgsqlTypes.NpgsqlPoint(x: 0.6296803020435863d, y: 0.530186582633137d), new NpgsqlTypes.NpgsqlPoint(x: 0.33610241579580236d, y: 0.8283969915050141d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.938554337303263d, y: 0.7042429727119478d), new NpgsqlTypes.NpgsqlPoint(x: 0.18793927530745447d, y: 0.36848353002894885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9938362798716412d, y: 0.5859402836244676d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2188417691657264d, y: 0.6414675820058822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9245540099807251d, y: 0.7354704549744514d), new NpgsqlTypes.NpgsqlPoint(x: 0.16584661186381755d, y: 0.643472017781281d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45411874402780505d, y: 0.7866180529785624d), new NpgsqlTypes.NpgsqlPoint(x: 0.030134141149234073d, y: 0.5762596604933163d), new NpgsqlTypes.NpgsqlPoint(x: 0.04622399789534948d, y: 0.15981637943217952d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1622032444833903d, y: 0.8499574452956522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765483425745861d, y: 0.7101828760473674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7548486544385004d, y: 0.5304120364499337d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5642078623132505d, y: 0.2885979436886654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8130382282521356d, y: 0.7046718567643478d), new NpgsqlTypes.NpgsqlPoint(x: 0.03320392826460894d, y: 0.6414807045487013d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9260419208604977d, y: 0.8662607430956121d), new NpgsqlTypes.NpgsqlPoint(x: 0.9177567751903536d, y: 0.986415232153477d), new NpgsqlTypes.NpgsqlPoint(x: 0.07347685162471573d, y: 0.4628759043055578d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4931679734116171d, y: 0.9515856103927331d), new NpgsqlTypes.NpgsqlPoint(x: 0.1703243001333753d, y: 0.02835552119684792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5899292720779947d, y: 0.9266799245988654d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5279827275483313d, y: 0.9760457381396715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8349159526127997d, y: 0.5513453860615934d), new NpgsqlTypes.NpgsqlPoint(x: 0.38579324055381237d, y: 0.2703218843025448d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7195114814462248d, y: 0.8780237144607306d), new NpgsqlTypes.NpgsqlPoint(x: 0.41169397054529266d, y: 0.4467436517732857d), new NpgsqlTypes.NpgsqlPoint(x: 0.060386666881334095d, y: 0.24559479713097532d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6985380959981171d, y: 0.41663125763202047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302497119868703d, y: 0.26523296936918583d), new NpgsqlTypes.NpgsqlPoint(x: 0.723496980857089d, y: 0.664873503606773d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6846138228664364d, y: 0.4190259488682444d), new NpgsqlTypes.NpgsqlPoint(x: 0.09087857821997958d, y: 0.8325811483342235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6394502853286017d, y: 0.6058189976231924d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11363956917848539d, y: 0.740290227956147d), new NpgsqlTypes.NpgsqlPoint(x: 0.883445363483641d, y: 0.4148904616031145d), new NpgsqlTypes.NpgsqlPoint(x: 0.20525893878461743d, y: 0.5676308870765396d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7812776174397524d, y: 0.8788523263399264d), new NpgsqlTypes.NpgsqlPoint(x: 0.1370526674396677d, y: 0.809359566306466d), new NpgsqlTypes.NpgsqlPoint(x: 0.3210622594044089d, y: 0.9103276308728736d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24917106727631566d, y: 0.0063364483650334424d), new NpgsqlTypes.NpgsqlPoint(x: 0.45205118870269745d, y: 0.07049428487961407d), new NpgsqlTypes.NpgsqlPoint(x: 0.23609484330821784d, y: 0.5889533101091698d)), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9730466504179371d, y: 0.9605676938707065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061941596365191d, y: 0.8728563443280707d), new NpgsqlTypes.NpgsqlPoint(x: 0.507570193794547d, y: 0.4140644173408542d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31727455308878716d, y: 0.25131893588264986d), new NpgsqlTypes.NpgsqlPoint(x: 0.1269224274562878d, y: 0.4656487106360522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7679882285510359d, y: 0.4782664818419404d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19325051741642674d, y: 0.7398354508427711d), new NpgsqlTypes.NpgsqlPoint(x: 0.1929800703621598d, y: 0.5905968546835741d), new NpgsqlTypes.NpgsqlPoint(x: 0.6024169400196627d, y: 0.24789140929904452d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6339932033283614d, y: 0.42940083333693757d), new NpgsqlTypes.NpgsqlPoint(x: 0.3629259718978838d, y: 0.8673151875893262d), new NpgsqlTypes.NpgsqlPoint(x: 0.627815412718521d, y: 0.6656807774768343d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7700835158974749d, y: 0.8132272621858724d), new NpgsqlTypes.NpgsqlPoint(x: 0.21736590591536165d, y: 0.5439947425741741d), new NpgsqlTypes.NpgsqlPoint(x: 0.41069442980854254d, y: 0.2249519903909356d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049127194847973565d, y: 0.23016175778075665d), new NpgsqlTypes.NpgsqlPoint(x: 0.033070709964047706d, y: 0.07289983934087585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9041744790646803d, y: 0.3370528841710708d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5394681859781554d, y: 0.28413704003725504d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025111621398935d, y: 0.8780673158695944d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412785274451746d, y: 0.3578121225339599d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03244722715409565d, y: 0.6790550271005631d), new NpgsqlTypes.NpgsqlPoint(x: 0.7515855805942658d, y: 0.663706079157187d), new NpgsqlTypes.NpgsqlPoint(x: 0.19581995606126834d, y: 0.7530138327339726d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22238201914861544d, y: 0.17960341787528666d), new NpgsqlTypes.NpgsqlPoint(x: 0.9428940886693664d, y: 0.8908673530100082d), new NpgsqlTypes.NpgsqlPoint(x: 0.14012097465006357d, y: 0.13699926893296677d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13613937951373267d, y: 0.6017701327908799d), new NpgsqlTypes.NpgsqlPoint(x: 0.08042702704583593d, y: 0.24856877010056222d), new NpgsqlTypes.NpgsqlPoint(x: 0.14675844101372892d, y: 0.7668267705855266d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.043717040088242065d, y: 0.5081410318762912d), new NpgsqlTypes.NpgsqlPoint(x: 0.10256444126659081d, y: 0.022521040882175103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8511269312855748d, y: 0.3314935592694216d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10412008126990446d, y: 0.06681457732393647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7310880009812479d, y: 0.576845755615075d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331643506405233d, y: 0.19065488979038547d)), }, }));
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.890937371183309d, y: 0.7295747156555321d), new NpgsqlTypes.NpgsqlPoint(x: 0.32117979220428516d, y: 0.07018406164522362d), new NpgsqlTypes.NpgsqlPoint(x: 0.49877701908211136d, y: 0.44035470128023835d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7474626196612792d, y: 0.842477013577923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5884751432724112d, y: 0.645545565760825d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946896452135034d, y: 0.41128265140800324d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28377843473853726d, y: 0.626553882456756d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235728673279205d, y: 0.9963175403615309d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586272938891055d, y: 0.9491712024312583d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8438395827468198d, y: 0.6009455833258602d), new NpgsqlTypes.NpgsqlPoint(x: 0.5914466773896562d, y: 0.22876426894957924d), new NpgsqlTypes.NpgsqlPoint(x: 0.41979527990637855d, y: 0.6306023945078697d)), }, }));
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 32;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr2.Value = 147;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 120, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 7, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 39, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 115, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 88, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 107, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 59, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 117, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 140);
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
FROM public.binary_npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI), typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

