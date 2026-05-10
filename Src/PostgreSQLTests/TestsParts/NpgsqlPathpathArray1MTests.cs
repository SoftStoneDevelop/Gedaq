

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5968443270148517d, y: 0.5882502942558328d), new NpgsqlTypes.NpgsqlPoint(x: 0.8042631213104371d, y: 0.6248474351447719d), new NpgsqlTypes.NpgsqlPoint(x: 0.7153626523447002d, y: 0.5591784663814304d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6634468825346674d, y: 0.6872426602996838d), new NpgsqlTypes.NpgsqlPoint(x: 0.23917831674596368d, y: 0.5713218866770192d), new NpgsqlTypes.NpgsqlPoint(x: 0.3285876114517263d, y: 0.7320781367608272d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31574063643097083d, y: 0.4918181707888867d), new NpgsqlTypes.NpgsqlPoint(x: 0.45485957256606535d, y: 0.7461005798429897d), new NpgsqlTypes.NpgsqlPoint(x: 0.5538402152357448d, y: 0.7629204547309203d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01781053222779605d, y: 0.5585900355464261d), new NpgsqlTypes.NpgsqlPoint(x: 0.3210595615055528d, y: 0.8646917550779765d), new NpgsqlTypes.NpgsqlPoint(x: 0.11717326293906316d, y: 0.8690187255514188d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7875856250180473d, y: 0.9146645017221409d), new NpgsqlTypes.NpgsqlPoint(x: 0.19309615942735758d, y: 0.8527193798655546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6641789274006559d, y: 0.08441243588579261d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5424557887944991d, y: 0.16459875323865092d), new NpgsqlTypes.NpgsqlPoint(x: 0.4752643151543132d, y: 0.6362601249123054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8865583335470322d, y: 0.45489174319772774d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4560298284774672d, y: 0.0873730001000893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6431488812797298d, y: 0.6047675152874237d), new NpgsqlTypes.NpgsqlPoint(x: 0.0595631634060666d, y: 0.3057528684852012d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 4.070474886208597E-05d, y: 0.5074584025010281d), new NpgsqlTypes.NpgsqlPoint(x: 0.9154960328861708d, y: 0.9603585641770612d), new NpgsqlTypes.NpgsqlPoint(x: 0.37624628544567096d, y: 0.46781396077090387d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3439073352809153d, y: 0.6000161439003635d), new NpgsqlTypes.NpgsqlPoint(x: 0.25824440907925117d, y: 0.6330867621575811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9883411737342576d, y: 0.45975875152090917d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.044702967173607666d, y: 0.7661717134953123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6157289350422589d, y: 0.5377306902921338d), new NpgsqlTypes.NpgsqlPoint(x: 0.5250641015744524d, y: 0.4066888106673018d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5890145673558228d, y: 0.9182697232512669d), new NpgsqlTypes.NpgsqlPoint(x: 0.34726803419214536d, y: 0.7046377592822521d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680294448998979d, y: 0.5218091044955051d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20344241462524648d, y: 0.265420514119207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5195615983796326d, y: 0.9843797838756114d), new NpgsqlTypes.NpgsqlPoint(x: 0.4641110729460187d, y: 0.9259645888659784d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5069743896883894d, y: 0.8476623243269154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9013681395247333d, y: 0.7028824782666605d), new NpgsqlTypes.NpgsqlPoint(x: 0.05576808685503343d, y: 0.6074092238105344d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.716182663198087d, y: 0.653551800473859d), new NpgsqlTypes.NpgsqlPoint(x: 0.3771887900248774d, y: 0.7891607219549766d), new NpgsqlTypes.NpgsqlPoint(x: 0.0037081017980308273d, y: 0.7180991560545749d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3443447807560571d, y: 0.031074711395595145d), new NpgsqlTypes.NpgsqlPoint(x: 0.03176457414472422d, y: 0.18177431122091792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9720947835131782d, y: 0.6876388307201297d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7326964941637746d, y: 0.11230938454413208d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894509649624346d, y: 0.43158552119044413d), new NpgsqlTypes.NpgsqlPoint(x: 0.1173841099748022d, y: 0.9069998974712269d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9006112101397625d, y: 0.0623973110478484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5035208059332179d, y: 0.8298014491744246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934231492595596d, y: 0.7522792827935704d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009068143263088246d, y: 0.06115064953212346d), new NpgsqlTypes.NpgsqlPoint(x: 0.3795252224613145d, y: 0.5215518672020742d), new NpgsqlTypes.NpgsqlPoint(x: 0.5001083124061809d, y: 0.6480071698130978d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07062236986855519d, y: 0.04710238486632434d), new NpgsqlTypes.NpgsqlPoint(x: 0.17635608588234808d, y: 0.6541089558472825d), new NpgsqlTypes.NpgsqlPoint(x: 0.44376976429320125d, y: 0.8639652861503466d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44106187892708926d, y: 0.4531548548940446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5526030565596858d, y: 0.7521542166028862d), new NpgsqlTypes.NpgsqlPoint(x: 0.3124051939084689d, y: 0.4585892558734178d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3448728800589054d, y: 0.5285778368210775d), new NpgsqlTypes.NpgsqlPoint(x: 0.33263423035152817d, y: 0.20468561650964623d), new NpgsqlTypes.NpgsqlPoint(x: 0.32016227457119084d, y: 0.46871354123106357d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4639980661602552d, y: 0.7071274336355363d), new NpgsqlTypes.NpgsqlPoint(x: 0.4495692691507941d, y: 0.05050301233723753d), new NpgsqlTypes.NpgsqlPoint(x: 0.8066499087149618d, y: 0.4493546104706426d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49593067571312555d, y: 0.4808408658782425d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769520891146164d, y: 0.3780462857556639d), new NpgsqlTypes.NpgsqlPoint(x: 0.34562972822874893d, y: 0.2710707593283016d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02331897704780017d, y: 0.3540731236579877d), new NpgsqlTypes.NpgsqlPoint(x: 0.22368265033863366d, y: 0.32910218142241765d), new NpgsqlTypes.NpgsqlPoint(x: 0.15594768174803308d, y: 0.016098721772042746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9439576639264523d, y: 0.5032532889611884d), new NpgsqlTypes.NpgsqlPoint(x: 0.8136038374901394d, y: 0.2913972281269729d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328558050893596d, y: 0.004929606587417257d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4565240163884837d, y: 0.21350760813596115d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015055600055734d, y: 0.29911730873354814d), new NpgsqlTypes.NpgsqlPoint(x: 0.06368270796965225d, y: 0.4274950388023797d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5643247312464599d, y: 0.6907431229760442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5352004783378976d, y: 0.8998921357577468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2828214443775534d, y: 0.6023721696641807d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8890011096771568d, y: 0.32899004119050135d), new NpgsqlTypes.NpgsqlPoint(x: 0.6692355244688726d, y: 0.1215142207135218d), new NpgsqlTypes.NpgsqlPoint(x: 0.2823515212672456d, y: 0.08562174970381653d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4247364023967768d, y: 0.7113270604781718d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245199982312606d, y: 0.5181592874290137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8108869937211756d, y: 0.8565127828147376d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07987310260704839d, y: 0.7178404477864765d), new NpgsqlTypes.NpgsqlPoint(x: 0.42112581565268814d, y: 0.42525144906325274d), new NpgsqlTypes.NpgsqlPoint(x: 0.2424925741405335d, y: 0.39031835511902035d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.442755118454911d, y: 0.44446455588745193d), new NpgsqlTypes.NpgsqlPoint(x: 0.2646307431966649d, y: 0.6983704529513348d), new NpgsqlTypes.NpgsqlPoint(x: 0.823506040870858d, y: 0.9889616462891028d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12457866498234016d, y: 0.5224918078580488d), new NpgsqlTypes.NpgsqlPoint(x: 0.3148005805977858d, y: 0.8621548259379108d), new NpgsqlTypes.NpgsqlPoint(x: 0.7673746202095427d, y: 0.5037580673329014d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4248763244622632d, y: 0.47740857899036127d), new NpgsqlTypes.NpgsqlPoint(x: 0.056663184662349764d, y: 0.1907052621297366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5091099178717193d, y: 0.4290548230865532d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2170495824745804d, y: 0.5068945529403334d), new NpgsqlTypes.NpgsqlPoint(x: 0.06675528464072633d, y: 0.8278111766467289d), new NpgsqlTypes.NpgsqlPoint(x: 0.03997278593653586d, y: 0.10715342413427731d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6750078887906511d, y: 0.13062385500478624d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479852420059243d, y: 0.20911048941638222d), new NpgsqlTypes.NpgsqlPoint(x: 0.15090904458845966d, y: 0.28785980548243273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15094021913826827d, y: 0.37065330356991755d), new NpgsqlTypes.NpgsqlPoint(x: 0.18917965960424743d, y: 0.556602583928015d), new NpgsqlTypes.NpgsqlPoint(x: 0.7225321288063414d, y: 0.7347073763883262d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.683080762280172d, y: 0.98443674613679d), new NpgsqlTypes.NpgsqlPoint(x: 0.3634876806868196d, y: 0.38556948583133643d), new NpgsqlTypes.NpgsqlPoint(x: 0.9088448939584323d, y: 0.09140195354179392d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4263204007555802d, y: 0.7415491706122284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3747809916215604d, y: 0.21730829447142597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5555725059638451d, y: 0.2917124128955133d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03784685366317153d, y: 0.8523375351923641d), new NpgsqlTypes.NpgsqlPoint(x: 0.9224851980361359d, y: 0.9323394584052785d), new NpgsqlTypes.NpgsqlPoint(x: 0.834503068828579d, y: 0.3531938858650644d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9845174059764409d, y: 0.015700898043949807d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584654317509369d, y: 0.8886689616853739d), new NpgsqlTypes.NpgsqlPoint(x: 0.44548164294255566d, y: 0.7729834926005191d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6298461783910901d, y: 0.4393587155197908d), new NpgsqlTypes.NpgsqlPoint(x: 0.3612293598674595d, y: 0.2748797771046856d), new NpgsqlTypes.NpgsqlPoint(x: 0.21659367173894595d, y: 0.5605260489552616d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5909921298544021d, y: 0.28659315824851084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7236970286538835d, y: 0.8558485758424315d), new NpgsqlTypes.NpgsqlPoint(x: 0.5093791115585872d, y: 0.886245466302096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2160082920082287d, y: 0.3529220064148618d), new NpgsqlTypes.NpgsqlPoint(x: 0.20399774251745006d, y: 0.9295244767891169d), new NpgsqlTypes.NpgsqlPoint(x: 0.6927375327805007d, y: 0.23269621049254574d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4640961049884327d, y: 0.2138677590324617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7557075081700855d, y: 0.5045666725671007d), new NpgsqlTypes.NpgsqlPoint(x: 0.4103840621847127d, y: 0.8348965281951839d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8844723828533287d, y: 0.793049914588066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6562950687871255d, y: 0.1901895039524263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257374746750375d, y: 0.22071649592285647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7818031012344899d, y: 0.43956049623668547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595522369035696d, y: 0.5910471443494253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5544649241117013d, y: 0.859810025696914d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9827625331649066d, y: 0.043794009401728395d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364217727523663d, y: 0.21733050168670665d), new NpgsqlTypes.NpgsqlPoint(x: 0.38223800862643076d, y: 0.5216948171152038d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1883370062105051d, y: 0.9981364068392019d), new NpgsqlTypes.NpgsqlPoint(x: 0.960407115797332d, y: 0.33567566288700357d), new NpgsqlTypes.NpgsqlPoint(x: 0.1281147586133906d, y: 0.6289007100898556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6398749999726983d, y: 0.6800271568015953d), new NpgsqlTypes.NpgsqlPoint(x: 0.7814081104534264d, y: 0.053611657782606126d), new NpgsqlTypes.NpgsqlPoint(x: 0.8595634411505707d, y: 0.8973634671397964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6129611068607473d, y: 0.697411090336065d), new NpgsqlTypes.NpgsqlPoint(x: 0.5365558825017821d, y: 0.7226265828164034d), new NpgsqlTypes.NpgsqlPoint(x: 0.2602690727580689d, y: 0.5349535757293247d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20108384282207314d, y: 0.06077882215369701d), new NpgsqlTypes.NpgsqlPoint(x: 0.6243426328091883d, y: 0.06789730340911715d), new NpgsqlTypes.NpgsqlPoint(x: 0.3383164104251649d, y: 0.9022279367261731d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.650073826209348d, y: 0.9741599275667013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5782286207739753d, y: 0.7703372999089265d), new NpgsqlTypes.NpgsqlPoint(x: 0.09443097679145007d, y: 0.943973870778215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21134472298763785d, y: 0.08292080694204618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8529839690813892d, y: 0.8457659044438618d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718318417969816d, y: 0.9282407225744768d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15041368725495285d, y: 0.014860335438591887d), new NpgsqlTypes.NpgsqlPoint(x: 0.9063488351283164d, y: 0.857030033480517d), new NpgsqlTypes.NpgsqlPoint(x: 0.5235581875902343d, y: 0.8687863706664958d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8566954447640895d, y: 0.7159854879311364d), new NpgsqlTypes.NpgsqlPoint(x: 0.5433056867087885d, y: 0.564217337660592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9505301701168811d, y: 0.6627151901156784d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4035654703496968d, y: 0.9482763311881219d), new NpgsqlTypes.NpgsqlPoint(x: 0.18421457770586225d, y: 0.7430863999529276d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671464965074758d, y: 0.7784006704201667d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17376641771870793d, y: 0.4354483796705153d), new NpgsqlTypes.NpgsqlPoint(x: 0.8744182611539161d, y: 0.5582057892309698d), new NpgsqlTypes.NpgsqlPoint(x: 0.04216655418272097d, y: 0.8169857872232561d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8477183601498393d, y: 0.25673503514574414d), new NpgsqlTypes.NpgsqlPoint(x: 0.19869097068015606d, y: 0.48539939390859554d), new NpgsqlTypes.NpgsqlPoint(x: 0.1556799770844257d, y: 0.25098848621080216d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.80320501678897d, y: 0.20111793040591397d), new NpgsqlTypes.NpgsqlPoint(x: 0.27437322886186066d, y: 0.25639088026934376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7302115051421586d, y: 0.5967375545874457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7078010091783142d, y: 0.617679628343846d), new NpgsqlTypes.NpgsqlPoint(x: 0.595026644792333d, y: 0.9712849002674564d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574195834877008d, y: 0.7875716810137972d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5492469470052395d, y: 0.09250517342139208d), new NpgsqlTypes.NpgsqlPoint(x: 0.04798023814893837d, y: 0.20483081878867782d), new NpgsqlTypes.NpgsqlPoint(x: 0.20641260353919177d, y: 0.4325130313821822d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7441865612249987d, y: 0.49037010018705396d), new NpgsqlTypes.NpgsqlPoint(x: 0.29968381089722707d, y: 0.9807126887826206d), new NpgsqlTypes.NpgsqlPoint(x: 0.0811269311620747d, y: 0.22714827752232458d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0512190282873094d, y: 0.06736978604229371d), new NpgsqlTypes.NpgsqlPoint(x: 0.21335333378658017d, y: 0.5292494281960683d), new NpgsqlTypes.NpgsqlPoint(x: 0.2674956824493586d, y: 0.9563345476514157d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7591597265353663d, y: 0.6103965353855642d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274030154733113d, y: 0.5182871968207918d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837979274427968d, y: 0.9418527770081513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6158411655274171d, y: 0.7294330798464336d), new NpgsqlTypes.NpgsqlPoint(x: 0.8104327713942644d, y: 0.6703431775033167d), new NpgsqlTypes.NpgsqlPoint(x: 0.81612009516635d, y: 0.3112870608859759d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5802156017776178d, y: 0.10918420607764578d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873070236829312d, y: 0.5967955620842043d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222602538777108d, y: 0.5294756983520089d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3606969520940557d, y: 0.06888968185058986d), new NpgsqlTypes.NpgsqlPoint(x: 0.2938422015173112d, y: 0.41512466284537686d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151637985637047d, y: 0.4237329923686195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14010210554272018d, y: 0.1839697279936d), new NpgsqlTypes.NpgsqlPoint(x: 0.09586428389475254d, y: 0.8264512519086696d), new NpgsqlTypes.NpgsqlPoint(x: 0.15238867980028725d, y: 0.4964220426141769d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6040565471056424d, y: 0.49831864391259884d), new NpgsqlTypes.NpgsqlPoint(x: 0.31492556457663456d, y: 0.08901707426927152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5571886924240538d, y: 0.42131616349532397d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9113534031666157d, y: 0.31221030726191834d), new NpgsqlTypes.NpgsqlPoint(x: 0.9206643860850282d, y: 0.004695320377418266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5911929772424521d, y: 0.8913004942950765d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20872117629171527d, y: 0.12403254149424658d), new NpgsqlTypes.NpgsqlPoint(x: 0.44814112091149594d, y: 0.34800887682964765d), new NpgsqlTypes.NpgsqlPoint(x: 0.4265576679047376d, y: 0.48158281777438305d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003470274704285292d, y: 0.050496916819422255d), new NpgsqlTypes.NpgsqlPoint(x: 0.18115693952333622d, y: 0.9647577803349849d), new NpgsqlTypes.NpgsqlPoint(x: 0.7380040139105606d, y: 0.1886921624414334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.380301011464138d, y: 0.9878341472048445d), new NpgsqlTypes.NpgsqlPoint(x: 0.19792322355478376d, y: 0.40923072330497445d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244320790560609d, y: 0.054618098265087345d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10666652607748872d, y: 0.527549577516374d), new NpgsqlTypes.NpgsqlPoint(x: 0.010775277246709902d, y: 0.3072018026438438d), new NpgsqlTypes.NpgsqlPoint(x: 0.8621658322643138d, y: 0.40641283341329304d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8913360592272151d, y: 0.12165977164066355d), new NpgsqlTypes.NpgsqlPoint(x: 0.35193366601366016d, y: 0.18813893286772543d), new NpgsqlTypes.NpgsqlPoint(x: 0.37963984986218025d, y: 0.5802008313442345d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06648310496425902d, y: 0.43220665068132835d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499538896860207d, y: 0.3916388714496395d), new NpgsqlTypes.NpgsqlPoint(x: 0.5414258398005003d, y: 0.3319972333926492d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9229386673370314d, y: 0.6186440490449645d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364117916320045d, y: 0.12516998470959473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9743613212930721d, y: 0.9431575292030991d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34843482574242346d, y: 0.7485156224340396d), new NpgsqlTypes.NpgsqlPoint(x: 0.20482081682647768d, y: 0.7383589065785876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5171680436846414d, y: 0.9650098600235706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8229985061055882d, y: 0.2004130674187513d), new NpgsqlTypes.NpgsqlPoint(x: 0.0788195222275182d, y: 0.8091931292704954d), new NpgsqlTypes.NpgsqlPoint(x: 0.3444718863751006d, y: 0.13867139664897588d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6418205887170106d, y: 0.1740617017870263d), new NpgsqlTypes.NpgsqlPoint(x: 0.62509236497897d, y: 0.18998634237968992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6083963753249289d, y: 0.5178013125471749d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7361862714312288d, y: 0.276358710381026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6426404131931865d, y: 0.6940988282553299d), new NpgsqlTypes.NpgsqlPoint(x: 0.8486257570483333d, y: 0.11189808258186629d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6649431968881417d, y: 0.5944320249484436d), new NpgsqlTypes.NpgsqlPoint(x: 0.7658921089098194d, y: 0.4925830449237487d), new NpgsqlTypes.NpgsqlPoint(x: 0.48522893219160024d, y: 0.7596371629660574d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9581412483538905d, y: 0.42292557103975703d), new NpgsqlTypes.NpgsqlPoint(x: 0.48016357653183506d, y: 0.4830943238784142d), new NpgsqlTypes.NpgsqlPoint(x: 0.18547114714845703d, y: 0.7891909339948991d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6473254792124795d, y: 0.10998763951630652d), new NpgsqlTypes.NpgsqlPoint(x: 0.11517948258166189d, y: 0.2625019572986401d), new NpgsqlTypes.NpgsqlPoint(x: 0.9628039177392422d, y: 0.132999717973043d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05169271761351091d, y: 0.9227106773028109d), new NpgsqlTypes.NpgsqlPoint(x: 0.8197697604215265d, y: 0.3234663967139718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6229334905364089d, y: 0.600388624551168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9214804419018365d, y: 0.04874276531187316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309934643132717d, y: 0.148574110078857d), new NpgsqlTypes.NpgsqlPoint(x: 0.3412002945865321d, y: 0.8937460956712494d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33409488004659393d, y: 0.7012313099612403d), new NpgsqlTypes.NpgsqlPoint(x: 0.02219224985411783d, y: 0.49283915404530065d), new NpgsqlTypes.NpgsqlPoint(x: 0.34366264221281473d, y: 0.17408175906684697d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5431653712147684d, y: 0.059048317556238406d), new NpgsqlTypes.NpgsqlPoint(x: 0.386940334354297d, y: 0.10212003982431284d), new NpgsqlTypes.NpgsqlPoint(x: 0.5580651632230047d, y: 0.6359459090014d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5978926811352508d, y: 0.9040456072389897d), new NpgsqlTypes.NpgsqlPoint(x: 0.9475055751417802d, y: 0.14286127556969608d), new NpgsqlTypes.NpgsqlPoint(x: 0.02999405120044152d, y: 0.9905310373902951d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33210386893155086d, y: 0.14064745973501358d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407698510550899d, y: 0.24805752260434044d), new NpgsqlTypes.NpgsqlPoint(x: 0.18691094164419664d, y: 0.348837843726838d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8051131765131475d, y: 0.9812963567277203d), new NpgsqlTypes.NpgsqlPoint(x: 0.2935241962952527d, y: 0.9239800165950417d), new NpgsqlTypes.NpgsqlPoint(x: 0.9624587597396729d, y: 0.23670046709529735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8037683833448358d, y: 0.12383732572995154d), new NpgsqlTypes.NpgsqlPoint(x: 0.4847395485712297d, y: 0.5263541451387564d), new NpgsqlTypes.NpgsqlPoint(x: 0.4616748137027388d, y: 0.968443671068256d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3338311516259249d, y: 0.5800996970287821d), new NpgsqlTypes.NpgsqlPoint(x: 0.31787401819623795d, y: 0.01601550024603937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450835617901881d, y: 0.2002075244154884d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9893388075000887d, y: 0.4555258502263484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155939285742718d, y: 0.7709688871830114d), new NpgsqlTypes.NpgsqlPoint(x: 0.0916873314193043d, y: 0.5311822281420173d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6806156361057027d, y: 0.01814983093003797d), new NpgsqlTypes.NpgsqlPoint(x: 0.5021182286764934d, y: 0.7447358924364718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915488751016555d, y: 0.3533526141477311d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9271021902840417d, y: 0.13673177415287274d), new NpgsqlTypes.NpgsqlPoint(x: 0.32250506733677065d, y: 0.05804014416777881d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618604361071059d, y: 0.3113191553740343d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15794079793618432d, y: 0.7539918848450162d), new NpgsqlTypes.NpgsqlPoint(x: 0.4813248771437987d, y: 0.6001851343255544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9196068823677547d, y: 0.8932786644428343d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17691498253459104d, y: 0.6092669428717966d), new NpgsqlTypes.NpgsqlPoint(x: 0.37061287736368376d, y: 0.06167735542211805d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358768165674643d, y: 0.01974878112109235d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.638956330577774d, y: 0.4692132774920843d), new NpgsqlTypes.NpgsqlPoint(x: 0.19221625624429306d, y: 0.867181819545362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6121835667478116d, y: 0.25098896471970966d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2378537360396209d, y: 0.38981915147757107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7427998094678578d, y: 0.3340379709273208d), new NpgsqlTypes.NpgsqlPoint(x: 0.2767587625266176d, y: 0.8689442817447066d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00862470703568674d, y: 0.6816361987563917d), new NpgsqlTypes.NpgsqlPoint(x: 0.3039767519199018d, y: 0.6894600931336184d), new NpgsqlTypes.NpgsqlPoint(x: 0.7773592131091434d, y: 0.3231994033373905d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6397224963024369d, y: 0.7014196285620902d), new NpgsqlTypes.NpgsqlPoint(x: 0.08662710424058095d, y: 0.1950531264259907d), new NpgsqlTypes.NpgsqlPoint(x: 0.47702521088758565d, y: 0.5540783720619497d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.582064994588138d, y: 0.07810171821299738d), new NpgsqlTypes.NpgsqlPoint(x: 0.39362868765848347d, y: 0.8617914414821869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746922160361727d, y: 0.48869843746541597d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6839479343683836d, y: 0.13593904500819132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6316121078908975d, y: 0.6296792606021525d), new NpgsqlTypes.NpgsqlPoint(x: 0.930284803938735d, y: 0.22306117172989304d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7659180344773493d, y: 0.04785994472239563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6844782691460403d, y: 0.3653758306157272d), new NpgsqlTypes.NpgsqlPoint(x: 0.6693673097780123d, y: 0.12485656043186588d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21929779504575586d, y: 0.4818641644894821d), new NpgsqlTypes.NpgsqlPoint(x: 0.20947600802266841d, y: 0.9938872708168226d), new NpgsqlTypes.NpgsqlPoint(x: 0.626189797460782d, y: 0.16894857531394736d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09337475402243245d, y: 0.20067621497454458d), new NpgsqlTypes.NpgsqlPoint(x: 0.03723950074982485d, y: 0.27285465166242795d), new NpgsqlTypes.NpgsqlPoint(x: 0.18937237091470405d, y: 0.061907730705744846d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27743368699920024d, y: 0.5495117814573584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9955916576061192d, y: 0.8628147516215323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9605703461708504d, y: 0.9622633553829525d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20990788338391386d, y: 0.5484177651251343d), new NpgsqlTypes.NpgsqlPoint(x: 0.9146113329902886d, y: 0.37735641392592423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7647914920206703d, y: 0.5487632105908067d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2991914119805319d, y: 0.8373958850491507d), new NpgsqlTypes.NpgsqlPoint(x: 0.2133184689369012d, y: 0.40936931679541d), new NpgsqlTypes.NpgsqlPoint(x: 0.06399240474595058d, y: 0.9038185598343527d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45952032649414487d, y: 0.5544258217634356d), new NpgsqlTypes.NpgsqlPoint(x: 0.02225631339776757d, y: 0.07967228267754056d), new NpgsqlTypes.NpgsqlPoint(x: 0.47733336486927047d, y: 0.731938695389977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24519330599942446d, y: 0.23601387047635292d), new NpgsqlTypes.NpgsqlPoint(x: 0.052085223669652736d, y: 0.021969053113705117d), new NpgsqlTypes.NpgsqlPoint(x: 0.10740179315716525d, y: 0.4668508715673978d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.971867777577689d, y: 0.568950841888912d), new NpgsqlTypes.NpgsqlPoint(x: 0.9098048222269759d, y: 0.9649504406978097d), new NpgsqlTypes.NpgsqlPoint(x: 0.15918877195331937d, y: 0.8110087937811952d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1536954119594951d, y: 0.5802363597710557d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993978817466206d, y: 0.12201729726378718d), new NpgsqlTypes.NpgsqlPoint(x: 0.09987476415444196d, y: 0.6403314071666861d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3906105446086653d, y: 0.21135379361439532d), new NpgsqlTypes.NpgsqlPoint(x: 0.18562918172803322d, y: 0.2614841787872868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4409331551094877d, y: 0.06523288972511032d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4892725467677479d, y: 0.9787489097049032d), new NpgsqlTypes.NpgsqlPoint(x: 0.5838177278558002d, y: 0.1414390215867386d), new NpgsqlTypes.NpgsqlPoint(x: 0.1538451974135011d, y: 0.26740287126372975d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3549642743762005d, y: 0.9542878840965137d), new NpgsqlTypes.NpgsqlPoint(x: 0.5282773080225923d, y: 0.9119761843915417d), new NpgsqlTypes.NpgsqlPoint(x: 0.15879588030120684d, y: 0.9804727198646674d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1171125868523869d, y: 0.3947818948180505d), new NpgsqlTypes.NpgsqlPoint(x: 0.14075641997842803d, y: 0.8144577387914896d), new NpgsqlTypes.NpgsqlPoint(x: 0.13456674434697902d, y: 0.9884340200449777d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1887578167539664d, y: 0.8823335993684113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7888952558268698d, y: 0.06196476560283459d), new NpgsqlTypes.NpgsqlPoint(x: 0.7013044783713196d, y: 0.970967083519697d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45485475191744307d, y: 0.3931426624228198d), new NpgsqlTypes.NpgsqlPoint(x: 0.08660470382163588d, y: 0.8364917725853406d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503451827344751d, y: 0.5292868219597757d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03673033243963031d, y: 0.6509705139212689d), new NpgsqlTypes.NpgsqlPoint(x: 0.4003498117817865d, y: 0.7337842844399248d), new NpgsqlTypes.NpgsqlPoint(x: 0.3770880851624685d, y: 0.955499386408892d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6944239463668876d, y: 0.6867138498712339d), new NpgsqlTypes.NpgsqlPoint(x: 0.452647231746912d, y: 0.35051408880868984d), new NpgsqlTypes.NpgsqlPoint(x: 0.677172531739404d, y: 0.6184078165215415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16841005096257777d, y: 0.9247678636510717d), new NpgsqlTypes.NpgsqlPoint(x: 0.4795349630384995d, y: 0.7533106268755185d), new NpgsqlTypes.NpgsqlPoint(x: 0.8438460292342332d, y: 0.7998318566745733d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3130290690212275d, y: 0.6044197477771035d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877059457444856d, y: 0.009488759369368549d), new NpgsqlTypes.NpgsqlPoint(x: 0.543677750062409d, y: 0.594974720293625d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6909354630540667d, y: 0.6736754605546288d), new NpgsqlTypes.NpgsqlPoint(x: 0.09540440369420577d, y: 0.1932792264928026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9059048097159552d, y: 0.24408259005124788d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6283467210426857d, y: 0.8178126546886304d), new NpgsqlTypes.NpgsqlPoint(x: 0.697561033049365d, y: 0.44079581209118246d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165908976861078d, y: 0.12369623875997893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2167152470664765d, y: 0.7822848771667585d), new NpgsqlTypes.NpgsqlPoint(x: 0.85817760179536d, y: 0.16182087182051474d), new NpgsqlTypes.NpgsqlPoint(x: 0.7047432791666705d, y: 0.40066181713721827d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7665531616471196d, y: 0.7755452859607238d), new NpgsqlTypes.NpgsqlPoint(x: 0.6953252035948958d, y: 0.2246191879033047d), new NpgsqlTypes.NpgsqlPoint(x: 0.40858648236285233d, y: 0.13085403245270555d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5079272167363306d, y: 0.9625873786040828d), new NpgsqlTypes.NpgsqlPoint(x: 0.27432588038669337d, y: 0.9286004093993522d), new NpgsqlTypes.NpgsqlPoint(x: 0.14075324597897165d, y: 0.2687856515753848d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9983259862616343d, y: 0.6406686629697268d), new NpgsqlTypes.NpgsqlPoint(x: 0.24619669849259473d, y: 0.00716329057658438d), new NpgsqlTypes.NpgsqlPoint(x: 0.13042748541714622d, y: 0.07062473583526774d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8938830480868106d, y: 0.6824724915301d), new NpgsqlTypes.NpgsqlPoint(x: 0.2809996196314716d, y: 0.21168393847845945d), new NpgsqlTypes.NpgsqlPoint(x: 0.4351558172312292d, y: 0.10609009877637088d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38673621255618407d, y: 0.022348137706813653d), new NpgsqlTypes.NpgsqlPoint(x: 0.501962133231939d, y: 0.7307932136110868d), new NpgsqlTypes.NpgsqlPoint(x: 0.12063999820646643d, y: 0.24654414767817767d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8819524567727676d, y: 0.18026161377343475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7949752131552208d, y: 0.027202004711467387d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413368215299171d, y: 0.4754311057902799d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6791746235410929d, y: 0.19288758190126487d), new NpgsqlTypes.NpgsqlPoint(x: 0.24645876107071907d, y: 0.5977911002147098d), new NpgsqlTypes.NpgsqlPoint(x: 0.39296261228825125d, y: 0.35216848828185965d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8808638147379727d, y: 0.67607299302495d), new NpgsqlTypes.NpgsqlPoint(x: 0.635487382822263d, y: 0.6701222369327727d), new NpgsqlTypes.NpgsqlPoint(x: 0.8706754621897416d, y: 0.3288824411362109d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9847142891703781d, y: 0.3529905737237634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9854864496149915d, y: 0.9551587887041968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5578654824266165d, y: 0.8530075895207357d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6168892833135798d, y: 0.3637211393879062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515441577862165d, y: 0.3487334347678348d), new NpgsqlTypes.NpgsqlPoint(x: 0.8343225031686d, y: 0.9945807463186289d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47760155239037627d, y: 0.8000115964135344d), new NpgsqlTypes.NpgsqlPoint(x: 0.15612959421403838d, y: 0.8806967796997649d), new NpgsqlTypes.NpgsqlPoint(x: 0.36879276129826777d, y: 0.9898793536616819d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21523156178686964d, y: 0.8693912799983233d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567704870212613d, y: 0.5959507726463042d), new NpgsqlTypes.NpgsqlPoint(x: 0.50839802309455d, y: 0.9700365823459933d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35279678341302245d, y: 0.028731264342940377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919410397768372d, y: 0.1727088238985638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7559037108733788d, y: 0.17227340808569136d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6877600614463658d, y: 0.12182309709562866d), new NpgsqlTypes.NpgsqlPoint(x: 0.45283058794508546d, y: 0.5072061474663578d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809938033711073d, y: 0.8141357602726179d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9369202768352801d, y: 0.815400847103479d), new NpgsqlTypes.NpgsqlPoint(x: 0.8591734999140406d, y: 0.6749987336533994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9146808544661755d, y: 0.8781031164968152d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4916101923101376d, y: 0.9820734834169038d), new NpgsqlTypes.NpgsqlPoint(x: 0.21899190111183364d, y: 0.2216237246213152d), new NpgsqlTypes.NpgsqlPoint(x: 0.3377143387799576d, y: 0.8052319563532241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47448493291455096d, y: 0.1161290970876343d), new NpgsqlTypes.NpgsqlPoint(x: 0.6135275649049595d, y: 0.31971088903735356d), new NpgsqlTypes.NpgsqlPoint(x: 0.24866253913439096d, y: 0.7787962332256508d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9366709773757611d, y: 0.852716352921207d), new NpgsqlTypes.NpgsqlPoint(x: 0.45787199430794445d, y: 0.7507462905145437d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328133791248744d, y: 0.5990061473067738d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7684402353361396d, y: 0.5948151534747477d), new NpgsqlTypes.NpgsqlPoint(x: 0.46850162978048193d, y: 0.7998268676949973d), new NpgsqlTypes.NpgsqlPoint(x: 0.10325253476515783d, y: 0.06744608270599617d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8343601530265815d, y: 0.7250326604862193d), new NpgsqlTypes.NpgsqlPoint(x: 0.20680700104352046d, y: 0.013042112987642906d), new NpgsqlTypes.NpgsqlPoint(x: 0.25122427254010626d, y: 0.16276601388545164d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11402040275454661d, y: 0.10192887865387812d), new NpgsqlTypes.NpgsqlPoint(x: 0.38903732044837036d, y: 0.136164726453058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7615763669042734d, y: 0.3751258528811636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3280853296265728d, y: 0.51397916475179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277566938775056d, y: 0.657650695287348d), new NpgsqlTypes.NpgsqlPoint(x: 0.9616708356467708d, y: 0.21344700576112507d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16193491837168028d, y: 0.09810308757220199d), new NpgsqlTypes.NpgsqlPoint(x: 0.468133642626007d, y: 0.6555734283068335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512551560350171d, y: 0.5254373602922016d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3330589448057364d, y: 0.3627202575974845d), new NpgsqlTypes.NpgsqlPoint(x: 0.12599635386010744d, y: 0.23543991953221288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217748485035322d, y: 0.41334439419498725d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6780854671318336d, y: 0.5592365332428239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7402561983971486d, y: 0.9664287651592331d), new NpgsqlTypes.NpgsqlPoint(x: 0.516744134743369d, y: 0.6982235437923819d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0074759021138386395d, y: 0.01476034766766321d), new NpgsqlTypes.NpgsqlPoint(x: 0.1921314426657187d, y: 0.6713823895961182d), new NpgsqlTypes.NpgsqlPoint(x: 0.732911484418221d, y: 0.7709066318103577d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5949557183408739d, y: 0.5739220788301164d), new NpgsqlTypes.NpgsqlPoint(x: 0.945904817019805d, y: 0.5663127401040231d), new NpgsqlTypes.NpgsqlPoint(x: 0.05731208134334553d, y: 0.183722255773636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35659992759941517d, y: 0.8329705392950352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868620078664556d, y: 0.7458687378226119d), new NpgsqlTypes.NpgsqlPoint(x: 0.23675513771467038d, y: 0.7368917774923266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9675913162094061d, y: 0.04952722916277197d), new NpgsqlTypes.NpgsqlPoint(x: 0.16582691414524386d, y: 0.9008511291987638d), new NpgsqlTypes.NpgsqlPoint(x: 0.8916863113443377d, y: 0.30719736240667306d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3226269131538916d, y: 0.48125495305420196d), new NpgsqlTypes.NpgsqlPoint(x: 0.37142619378976127d, y: 0.6891317353290414d), new NpgsqlTypes.NpgsqlPoint(x: 0.27402681735035905d, y: 0.9412779072603934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3768404842571105d, y: 0.3544768537964781d), new NpgsqlTypes.NpgsqlPoint(x: 0.06018604060110633d, y: 0.5043373301385682d), new NpgsqlTypes.NpgsqlPoint(x: 0.11127592204086323d, y: 0.5515543816038786d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42533366220583746d, y: 0.4640058662218539d), new NpgsqlTypes.NpgsqlPoint(x: 0.179690010002715d, y: 0.9893619190147731d), new NpgsqlTypes.NpgsqlPoint(x: 0.31794780031507275d, y: 0.8853797956903229d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6368894273328545d, y: 0.7146437250590549d), new NpgsqlTypes.NpgsqlPoint(x: 0.549099897646338d, y: 0.41737689736469163d), new NpgsqlTypes.NpgsqlPoint(x: 0.990642523729544d, y: 0.8533634043813679d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1302330448152348d, y: 0.09600499589443534d), new NpgsqlTypes.NpgsqlPoint(x: 0.06717135242458316d, y: 0.8021333466594446d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136012008479207d, y: 0.7712478398765311d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39839737169762823d, y: 0.7830288306968299d), new NpgsqlTypes.NpgsqlPoint(x: 0.024960099651421763d, y: 0.7136974133522183d), new NpgsqlTypes.NpgsqlPoint(x: 0.7815665354476381d, y: 0.09447527728334337d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6878146317845014d, y: 0.5079726989052473d), new NpgsqlTypes.NpgsqlPoint(x: 0.8078715238456659d, y: 0.34997978023242227d), new NpgsqlTypes.NpgsqlPoint(x: 0.3153769516684305d, y: 0.5343435583346955d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49215205188489086d, y: 0.06304441981243503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5544217723511131d, y: 0.8119716976163397d), new NpgsqlTypes.NpgsqlPoint(x: 0.7021786396902265d, y: 0.06864261165993313d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36855415213671716d, y: 0.6601476152455208d), new NpgsqlTypes.NpgsqlPoint(x: 0.7520497453606266d, y: 0.904705372911408d), new NpgsqlTypes.NpgsqlPoint(x: 0.2212582711229295d, y: 0.2787087881368365d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.70111430987717d, y: 0.968659668081293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5606762335374097d, y: 0.22269823956313717d), new NpgsqlTypes.NpgsqlPoint(x: 0.07726329576051405d, y: 0.2999287285079717d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6735131816529079d, y: 0.21200519019577813d), new NpgsqlTypes.NpgsqlPoint(x: 0.43725361455269973d, y: 0.7185399079354059d), new NpgsqlTypes.NpgsqlPoint(x: 0.31970774892794984d, y: 0.28850099801456885d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9057005920009772d, y: 0.7655898258289474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6238123698642586d, y: 0.7638329178680785d), new NpgsqlTypes.NpgsqlPoint(x: 0.40212046730053397d, y: 0.519661212939202d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28530965307928113d, y: 0.7992504947256359d), new NpgsqlTypes.NpgsqlPoint(x: 0.11244289657166451d, y: 0.2248414817819976d), new NpgsqlTypes.NpgsqlPoint(x: 0.08921882345503729d, y: 0.15598852495810678d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.95236518844541d, y: 0.8263358805912745d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005883021987398429d, y: 0.6047003190741804d), new NpgsqlTypes.NpgsqlPoint(x: 0.6168255366027646d, y: 0.7904091405744068d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31548956340618994d, y: 0.386074070826276d), new NpgsqlTypes.NpgsqlPoint(x: 0.19483360400679517d, y: 0.9244011238465848d), new NpgsqlTypes.NpgsqlPoint(x: 0.039011427519382025d, y: 0.7595486339039412d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20870606153688298d, y: 0.87459658540505d), new NpgsqlTypes.NpgsqlPoint(x: 0.2657130477240671d, y: 0.7082697057364674d), new NpgsqlTypes.NpgsqlPoint(x: 0.22110554891196532d, y: 0.4692044443462493d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48308030732681184d, y: 0.8539917009149868d), new NpgsqlTypes.NpgsqlPoint(x: 0.8970818217846356d, y: 0.5023720207163832d), new NpgsqlTypes.NpgsqlPoint(x: 0.574058873238288d, y: 0.30771676742702636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14357241107595142d, y: 0.4950669658488712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8070983378161662d, y: 0.49242804753789404d), new NpgsqlTypes.NpgsqlPoint(x: 0.5089372269767379d, y: 0.20794504437187267d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030666056276779097d, y: 0.0034380045339398313d), new NpgsqlTypes.NpgsqlPoint(x: 0.18913086547525204d, y: 0.6330703552034612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865125191871759d, y: 0.3456149825234798d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5394214342000866d, y: 0.6372450338400146d), new NpgsqlTypes.NpgsqlPoint(x: 0.2912304911594523d, y: 0.9955316888410561d), new NpgsqlTypes.NpgsqlPoint(x: 0.5351879391716088d, y: 0.19557608207674793d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5655094385087075d, y: 0.35331935500855305d), new NpgsqlTypes.NpgsqlPoint(x: 0.1335168921498775d, y: 0.49274750452030114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7653589909861238d, y: 0.054222973575393185d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3175539014000218d, y: 0.5971874817216573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766434116703881d, y: 0.42822254380253466d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403985670657521d, y: 0.5644460762680512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8563653837673074d, y: 0.9533911874162206d), new NpgsqlTypes.NpgsqlPoint(x: 0.9958263439231617d, y: 0.9679576264630048d), new NpgsqlTypes.NpgsqlPoint(x: 0.7911284672274159d, y: 0.6545405408756407d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5452461843073994d, y: 0.37657599473747894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6785561587132326d, y: 0.9633247528874577d), new NpgsqlTypes.NpgsqlPoint(x: 0.5222306890661569d, y: 0.42071884405542403d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5831284167009666d, y: 0.44681957681166906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8183283593289947d, y: 0.26928621683987075d), new NpgsqlTypes.NpgsqlPoint(x: 0.72175733663094d, y: 0.1532612971590942d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2859277005604194d, y: 0.5558939068009978d), new NpgsqlTypes.NpgsqlPoint(x: 0.6990680513235913d, y: 0.4055995781626539d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349200480967508d, y: 0.8924077325209901d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23237592185005473d, y: 0.6958870345221665d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641353903991166d, y: 0.9587535342779863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541771155301114d, y: 0.21614216534852826d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.043360668648826484d, y: 0.31570353411509766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8281127251188085d, y: 0.15028871673148603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6032898262531773d, y: 0.6583370757423462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6527630562349148d, y: 0.5216747130689813d), new NpgsqlTypes.NpgsqlPoint(x: 0.19738265278152123d, y: 0.499646494189655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868945541939412d, y: 0.1390861410713622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25894902922114016d, y: 0.44288838211415726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5319222175033808d, y: 0.2467714611136652d), new NpgsqlTypes.NpgsqlPoint(x: 0.2519190201644339d, y: 0.8665008515585186d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5633253192183749d, y: 0.4333575445310416d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277857965356067d, y: 0.8220853379981796d), new NpgsqlTypes.NpgsqlPoint(x: 0.04623278562670452d, y: 0.507977074719653d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9020679919635591d, y: 0.6062066117908405d), new NpgsqlTypes.NpgsqlPoint(x: 0.5541414706419469d, y: 0.23406907351674788d), new NpgsqlTypes.NpgsqlPoint(x: 0.05750057274524101d, y: 0.9995012159192657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23578763144988357d, y: 0.8636832002669725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5356320397914982d, y: 0.35451174540746355d), new NpgsqlTypes.NpgsqlPoint(x: 0.1888699997126725d, y: 0.03982375047948905d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4438208150021279d, y: 0.7878617898814299d), new NpgsqlTypes.NpgsqlPoint(x: 0.2300534211280053d, y: 0.8648552241185749d), new NpgsqlTypes.NpgsqlPoint(x: 0.7956380009259048d, y: 0.40796355687290886d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9167240082456192d, y: 0.4310442082458925d), new NpgsqlTypes.NpgsqlPoint(x: 0.0698856013815734d, y: 0.3989545978286142d), new NpgsqlTypes.NpgsqlPoint(x: 0.26403727143227074d, y: 0.9534871360759234d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5191649104856492d, y: 0.893012485711849d), new NpgsqlTypes.NpgsqlPoint(x: 0.7121594960890444d, y: 0.7472339510095097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995120946415357d, y: 0.9744667350779033d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6495212612600721d, y: 0.26128879567633034d), new NpgsqlTypes.NpgsqlPoint(x: 0.05027803222484972d, y: 0.9512459323875156d), new NpgsqlTypes.NpgsqlPoint(x: 0.06429307303751708d, y: 0.4573112867705664d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2566179814770957d, y: 0.34077253720128564d), new NpgsqlTypes.NpgsqlPoint(x: 0.2674349906358986d, y: 0.8779213681406365d), new NpgsqlTypes.NpgsqlPoint(x: 0.49454355575950004d, y: 0.38886818034056647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05004145150715267d, y: 0.9583714936022d), new NpgsqlTypes.NpgsqlPoint(x: 0.018206619052099082d, y: 0.6730083681913183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5361348134603993d, y: 0.5094719627445298d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6618349513287318d, y: 0.8953315754432812d), new NpgsqlTypes.NpgsqlPoint(x: 0.1660690806620818d, y: 0.03264337327415767d), new NpgsqlTypes.NpgsqlPoint(x: 0.4504399444249316d, y: 0.1510094391748107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3445707622015135d, y: 0.009472347081753152d), new NpgsqlTypes.NpgsqlPoint(x: 0.4742168678416604d, y: 0.02725860223665877d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702979022235175d, y: 0.9322764841813566d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5783905406962612d, y: 0.3662543950910885d), new NpgsqlTypes.NpgsqlPoint(x: 0.2784251592131828d, y: 0.2199566606062653d), new NpgsqlTypes.NpgsqlPoint(x: 0.12213126700253407d, y: 0.5076929899340332d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8365153145020017d, y: 0.27516782025424247d), new NpgsqlTypes.NpgsqlPoint(x: 0.5857872111647465d, y: 0.27562123180255704d), new NpgsqlTypes.NpgsqlPoint(x: 0.09706224756544046d, y: 0.5244165782468041d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17732385294057296d, y: 0.6155670946767826d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411392878711776d, y: 0.7781662237365173d), new NpgsqlTypes.NpgsqlPoint(x: 0.6897735372173961d, y: 0.9901904260899469d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42664956700598466d, y: 0.14548583684445537d), new NpgsqlTypes.NpgsqlPoint(x: 0.39778146340980425d, y: 0.998826133200753d), new NpgsqlTypes.NpgsqlPoint(x: 0.40529630606659306d, y: 0.5087567360957473d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9431354260698561d, y: 0.6097271238118277d), new NpgsqlTypes.NpgsqlPoint(x: 0.42935317413626195d, y: 0.8447006172389837d), new NpgsqlTypes.NpgsqlPoint(x: 0.05527710230330751d, y: 0.1706372563610168d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4802009544408824d, y: 0.1080414853652586d), new NpgsqlTypes.NpgsqlPoint(x: 0.7840217378872528d, y: 0.31669190887608845d), new NpgsqlTypes.NpgsqlPoint(x: 0.2512710642335918d, y: 0.9770201270458335d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9819105717967859d, y: 0.2310420385928026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622488603850143d, y: 0.5952283188696902d), new NpgsqlTypes.NpgsqlPoint(x: 0.41237343168835017d, y: 0.8847135301468717d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6467494258442991d, y: 0.2071301756167967d), new NpgsqlTypes.NpgsqlPoint(x: 0.21352769280175354d, y: 0.28581341876786226d), new NpgsqlTypes.NpgsqlPoint(x: 0.2964941324568826d, y: 0.3446921425114904d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8229102140311958d, y: 0.9516302053148247d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618578446904421d, y: 0.6142527435941046d), new NpgsqlTypes.NpgsqlPoint(x: 0.2663438595040408d, y: 0.25094377111391275d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4097989363456077d, y: 0.8670071444720139d), new NpgsqlTypes.NpgsqlPoint(x: 0.15166532385284204d, y: 0.49284985637495904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076073253925836d, y: 0.14112602597105495d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3802923795253883d, y: 0.8771073291712522d), new NpgsqlTypes.NpgsqlPoint(x: 0.03946401045223957d, y: 0.027052023912417678d), new NpgsqlTypes.NpgsqlPoint(x: 0.5451994289801736d, y: 0.06436679758810204d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.785431405249883d, y: 0.5696222604680282d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766582704154323d, y: 0.6510920373864982d), new NpgsqlTypes.NpgsqlPoint(x: 0.1632462006822306d, y: 0.7596517207627814d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012651035057940074d, y: 0.7045531987383481d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844131092710002d, y: 0.8742614244527708d), new NpgsqlTypes.NpgsqlPoint(x: 0.3598656526911074d, y: 0.8929783411114779d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4511558789224632d, y: 0.30409920060628404d), new NpgsqlTypes.NpgsqlPoint(x: 0.5420857412641833d, y: 0.4482541964299256d), new NpgsqlTypes.NpgsqlPoint(x: 0.7690747736553619d, y: 0.26081691333977164d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46329423250922663d, y: 0.37032220112805125d), new NpgsqlTypes.NpgsqlPoint(x: 0.3992133555823888d, y: 0.10371883198925547d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319646258111027d, y: 0.4421343560200657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7252959931709203d, y: 0.9792225770516738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054988881540916d, y: 0.1359391715389502d), new NpgsqlTypes.NpgsqlPoint(x: 0.281957392522194d, y: 0.15764255888540668d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9298291745536297d, y: 0.8245805085787459d), new NpgsqlTypes.NpgsqlPoint(x: 0.20762010450086266d, y: 0.44969318106009026d), new NpgsqlTypes.NpgsqlPoint(x: 0.3070140120219147d, y: 0.5289077269328413d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9221915980033506d, y: 0.7712903125974789d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964734332195083d, y: 0.8865079126981663d), new NpgsqlTypes.NpgsqlPoint(x: 0.3282455462617072d, y: 0.24970300577560856d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9267262282693602d, y: 0.39783023328110023d), new NpgsqlTypes.NpgsqlPoint(x: 0.5577300052455979d, y: 0.9975331773222197d), new NpgsqlTypes.NpgsqlPoint(x: 0.4580723281497172d, y: 0.6604095015254974d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6100391034943614d, y: 0.6745921424136035d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926236455092993d, y: 0.4450176930943075d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747819053257384d, y: 0.31526608012575563d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4156531967192437d, y: 0.992371375053288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8956272046328404d, y: 0.3568352815568926d), new NpgsqlTypes.NpgsqlPoint(x: 0.5020368126053893d, y: 0.7527324220254936d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2542374769911636d, y: 0.41811971281645566d), new NpgsqlTypes.NpgsqlPoint(x: 0.18112931593901993d, y: 0.8282894947934065d), new NpgsqlTypes.NpgsqlPoint(x: 0.15042024520396502d, y: 0.9874379899801912d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.160400064733079d, y: 0.271610619692226d), new NpgsqlTypes.NpgsqlPoint(x: 0.9647612570453163d, y: 0.37499692129593687d), new NpgsqlTypes.NpgsqlPoint(x: 0.4233047584920292d, y: 0.9409296483105967d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31055823043276454d, y: 0.3002709801650837d), new NpgsqlTypes.NpgsqlPoint(x: 0.9475465237241226d, y: 0.24155215753129777d), new NpgsqlTypes.NpgsqlPoint(x: 0.23105316102538132d, y: 0.7301107012380931d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2314846290205781d, y: 0.04227801049360924d), new NpgsqlTypes.NpgsqlPoint(x: 0.11900360519732978d, y: 0.4246032350299298d), new NpgsqlTypes.NpgsqlPoint(x: 0.37408109471745465d, y: 0.5390348206822924d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9227821672716373d, y: 0.23133986151206876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268500677247911d, y: 0.156875533546335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6305950989012319d, y: 0.7346231115295897d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6044494966421985d, y: 0.8816298323960611d), new NpgsqlTypes.NpgsqlPoint(x: 0.208488296315124d, y: 0.3535027249168744d), new NpgsqlTypes.NpgsqlPoint(x: 0.40750641020192235d, y: 0.15635720773959683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5662262513481957d, y: 0.4376796634779845d), new NpgsqlTypes.NpgsqlPoint(x: 0.28431231245492306d, y: 0.8126010327519713d), new NpgsqlTypes.NpgsqlPoint(x: 0.4887767460182112d, y: 0.08030514184580673d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1692068273817d, y: 0.97008467651379d), new NpgsqlTypes.NpgsqlPoint(x: 0.41879572739556825d, y: 0.21334176426274387d), new NpgsqlTypes.NpgsqlPoint(x: 0.1449051119953434d, y: 0.031971260018996084d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5106972008121148d, y: 0.23031286241845073d), new NpgsqlTypes.NpgsqlPoint(x: 0.06478624924512089d, y: 0.11578031304279757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8204014412234518d, y: 0.036470146433280504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7726391313776645d, y: 0.7609862661412095d), new NpgsqlTypes.NpgsqlPoint(x: 0.3924886166008771d, y: 0.8435270497225142d), new NpgsqlTypes.NpgsqlPoint(x: 0.10818635497432272d, y: 0.07286219711757647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31015067342529035d, y: 0.25472780420177554d), new NpgsqlTypes.NpgsqlPoint(x: 0.016520734292903128d, y: 0.57430064200315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180033913223518d, y: 0.7769845214334774d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9905752403062784d, y: 0.15726837067841637d), new NpgsqlTypes.NpgsqlPoint(x: 0.9128869619893444d, y: 0.7989943199497954d), new NpgsqlTypes.NpgsqlPoint(x: 0.3056129214894058d, y: 0.5750641990389057d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1835170012216154d, y: 0.8213824938838459d), new NpgsqlTypes.NpgsqlPoint(x: 0.7500014706813514d, y: 0.3853088074694335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6906383484837223d, y: 0.6866376744145724d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24003867563023906d, y: 0.5494905366550171d), new NpgsqlTypes.NpgsqlPoint(x: 0.7763530048093776d, y: 0.37736542919993354d), new NpgsqlTypes.NpgsqlPoint(x: 0.4526907474311256d, y: 0.44502923439168396d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7258311812648954d, y: 0.8936330129113209d), new NpgsqlTypes.NpgsqlPoint(x: 0.17901707479585427d, y: 0.714475409227726d), new NpgsqlTypes.NpgsqlPoint(x: 0.11282834344067239d, y: 0.9889212877102106d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22111378138421656d, y: 0.6129788389449413d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106386563849653d, y: 0.18815733081760866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487135667621728d, y: 0.25725388401975935d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2247484082357336d, y: 0.1963309932832208d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595710433997666d, y: 0.9859185554874376d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008865170034394465d, y: 0.42926018436560187d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.806379491059425d, y: 0.3467414348723513d), new NpgsqlTypes.NpgsqlPoint(x: 0.9829893473655182d, y: 0.9478685866906339d), new NpgsqlTypes.NpgsqlPoint(x: 0.12755976686143522d, y: 0.9788932578663578d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1725160197657627d, y: 0.38006758901218873d), new NpgsqlTypes.NpgsqlPoint(x: 0.35695509472077824d, y: 0.4554439918324863d), new NpgsqlTypes.NpgsqlPoint(x: 0.4176182431509845d, y: 0.7079716441240467d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.276228802223767d, y: 0.24139304753305135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433123317818296d, y: 0.7750326663532522d), new NpgsqlTypes.NpgsqlPoint(x: 0.8806860322333054d, y: 0.7615374350399577d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9365914131802111d, y: 0.17408783891376012d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110863642711747d, y: 0.8614416859376008d), new NpgsqlTypes.NpgsqlPoint(x: 0.751536089612927d, y: 0.38704630594455103d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8468160457859097d, y: 0.9277290063227497d), new NpgsqlTypes.NpgsqlPoint(x: 0.8524497731806036d, y: 0.8579550890636767d), new NpgsqlTypes.NpgsqlPoint(x: 0.5219885658954397d, y: 0.2273704639373758d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6734851542337381d, y: 0.23222631251943948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801296045741373d, y: 0.6685996943716563d), new NpgsqlTypes.NpgsqlPoint(x: 0.4256722333362437d, y: 0.10968138531377991d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3091366192614118d, y: 0.19215309743923137d), new NpgsqlTypes.NpgsqlPoint(x: 0.20436937714472603d, y: 0.8747390613195313d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374906703131727d, y: 0.489717350547787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8636431966093089d, y: 0.03464115077701735d), new NpgsqlTypes.NpgsqlPoint(x: 0.19980116611031795d, y: 0.5175008455248431d), new NpgsqlTypes.NpgsqlPoint(x: 0.2479235696954617d, y: 0.16126089254934828d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3798791550056059d, y: 0.26644468128584864d), new NpgsqlTypes.NpgsqlPoint(x: 0.17484229270808938d, y: 0.37251103952744713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9498425457747126d, y: 0.8489516018394935d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.337564271179738d, y: 0.22499040348669552d), new NpgsqlTypes.NpgsqlPoint(x: 0.11879233853033366d, y: 0.9496603590914686d), new NpgsqlTypes.NpgsqlPoint(x: 0.11146512476495007d, y: 0.9269167999798934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9045598914658513d, y: 0.515961119590351d), new NpgsqlTypes.NpgsqlPoint(x: 0.09772277614158109d, y: 0.442000578606203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126194662159036d, y: 0.4338481665381334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6076362351453248d, y: 0.734922362183141d), new NpgsqlTypes.NpgsqlPoint(x: 0.6325213341883434d, y: 0.511601250828639d), new NpgsqlTypes.NpgsqlPoint(x: 0.48952522137342735d, y: 0.7883912669126382d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08854337693054015d, y: 0.9676688260754083d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515694243885817d, y: 0.11524894921318651d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283884737326116d, y: 0.42333094272744365d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8661912314211128d, y: 0.8801464546887107d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418764354892354d, y: 0.8294496509595554d), new NpgsqlTypes.NpgsqlPoint(x: 0.22333058844904363d, y: 0.4555933116200285d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14506740726427347d, y: 0.11382183933587375d), new NpgsqlTypes.NpgsqlPoint(x: 0.048317512232254d, y: 0.062472748304697734d), new NpgsqlTypes.NpgsqlPoint(x: 0.666601673928176d, y: 0.16284927096984192d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11816034302904177d, y: 0.09149550223150948d), new NpgsqlTypes.NpgsqlPoint(x: 0.8675517495798071d, y: 0.1122348983722542d), new NpgsqlTypes.NpgsqlPoint(x: 0.24835063435618165d, y: 0.9211754463184952d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3401138056194202d, y: 0.834275840604391d), new NpgsqlTypes.NpgsqlPoint(x: 0.5776375413986283d, y: 0.45675158737030774d), new NpgsqlTypes.NpgsqlPoint(x: 0.5596309280149996d, y: 0.014227660099879746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10624710526837466d, y: 0.7233830503444855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6143060754063193d, y: 0.6324583477471071d), new NpgsqlTypes.NpgsqlPoint(x: 0.22671307345516578d, y: 0.5687580389324868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6345583079489449d, y: 0.5929328120494095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8624810127688329d, y: 0.6692035696291861d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367087850684353d, y: 0.14376591948424056d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6977592882089055d, y: 0.598973223742764d), new NpgsqlTypes.NpgsqlPoint(x: 0.17808382958727986d, y: 0.17855329237048545d), new NpgsqlTypes.NpgsqlPoint(x: 0.9601437076578799d, y: 0.36205370690308736d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9695655402354126d, y: 0.3992454703896514d), new NpgsqlTypes.NpgsqlPoint(x: 0.30255789552738666d, y: 0.6032648019605971d), new NpgsqlTypes.NpgsqlPoint(x: 0.06206403779790126d, y: 0.355970867682736d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4246649475050679d, y: 0.5156562717880843d), new NpgsqlTypes.NpgsqlPoint(x: 0.16329555041565436d, y: 0.9566550679572907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638978596813534d, y: 0.5989722371950275d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.637150166758562d, y: 0.6776125655623373d), new NpgsqlTypes.NpgsqlPoint(x: 0.949132749464416d, y: 0.8359107014146455d), new NpgsqlTypes.NpgsqlPoint(x: 0.10744040009319533d, y: 0.7174943466243426d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9714708315295311d, y: 0.2804608631859675d), new NpgsqlTypes.NpgsqlPoint(x: 0.40912944753324754d, y: 0.6364821101837014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8054443332686032d, y: 0.1933430440629249d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45816869435115837d, y: 0.3011058715230258d), new NpgsqlTypes.NpgsqlPoint(x: 0.2726054189337306d, y: 0.5402067956575975d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028166602056534d, y: 0.31820910275643843d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 178,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11136859895204132d, y: 0.6827094059007424d), new NpgsqlTypes.NpgsqlPoint(x: 0.2918777429547167d, y: 0.6302709271952422d), new NpgsqlTypes.NpgsqlPoint(x: 0.34126659440044993d, y: 0.9285490307722929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33619105163795837d, y: 0.3902436856719188d), new NpgsqlTypes.NpgsqlPoint(x: 0.7979122406738411d, y: 0.8831255076070254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627585958897878d, y: 0.21550091801801663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5236237075369494d, y: 0.03647875155005165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9011290732246281d, y: 0.3224037118649632d), new NpgsqlTypes.NpgsqlPoint(x: 0.41516331778892257d, y: 0.5346057917375249d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8133753759233113d, y: 0.5361124404716217d), new NpgsqlTypes.NpgsqlPoint(x: 0.0068802645753812675d, y: 0.9138672702768642d), new NpgsqlTypes.NpgsqlPoint(x: 0.5448759606866466d, y: 0.5339189290063965d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9829802832022472d, y: 0.044013985401606726d), new NpgsqlTypes.NpgsqlPoint(x: 0.20273982312715078d, y: 0.7708073254937723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6218206045049715d, y: 0.04130837682397237d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9269700474374648d, y: 0.9964186859302645d), new NpgsqlTypes.NpgsqlPoint(x: 0.6263508113807724d, y: 0.5369636455069624d), new NpgsqlTypes.NpgsqlPoint(x: 0.4972966335777491d, y: 0.7172155554341931d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26419346656430787d, y: 0.8340555406796243d), new NpgsqlTypes.NpgsqlPoint(x: 0.414648384660776d, y: 0.9116467770727488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8709781425928707d, y: 0.35210654711022815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7789060294822335d, y: 0.4299320321293949d), new NpgsqlTypes.NpgsqlPoint(x: 0.5521620816107303d, y: 0.3197614302743381d), new NpgsqlTypes.NpgsqlPoint(x: 0.9221096337290084d, y: 0.16288782064622565d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4372935814038986d, y: 0.25048562728281243d), new NpgsqlTypes.NpgsqlPoint(x: 0.2568939235932073d, y: 0.4941034764397947d), new NpgsqlTypes.NpgsqlPoint(x: 0.046896094214032735d, y: 0.873904773443533d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 185,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9320805415034408d, y: 0.3480614572999835d), new NpgsqlTypes.NpgsqlPoint(x: 0.15785496449345893d, y: 0.879662861176201d), new NpgsqlTypes.NpgsqlPoint(x: 0.26962037026918817d, y: 0.8290802752716852d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47384840399773165d, y: 0.8135799166353669d), new NpgsqlTypes.NpgsqlPoint(x: 0.01592575533143059d, y: 0.21511121430317237d), new NpgsqlTypes.NpgsqlPoint(x: 0.25567945972193895d, y: 0.8496347044329982d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6313889031140137d, y: 0.9321797476127182d), new NpgsqlTypes.NpgsqlPoint(x: 0.3810488373462575d, y: 0.46351789932492815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5098161416505521d, y: 0.3148223462527199d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9158617868142374d, y: 0.37302841078299387d), new NpgsqlTypes.NpgsqlPoint(x: 0.12320437135695816d, y: 0.5244027219626362d), new NpgsqlTypes.NpgsqlPoint(x: 0.7662936415400694d, y: 0.2314571795228354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5060576741635265d, y: 0.6548880169474344d), new NpgsqlTypes.NpgsqlPoint(x: 0.9478298482051334d, y: 0.6460271673154283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046351852402987d, y: 0.6556042284525955d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19545594235122288d, y: 0.11234354171278971d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739522193743224d, y: 0.5734692945207311d), new NpgsqlTypes.NpgsqlPoint(x: 0.08829705785248931d, y: 0.38248765612778d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7295491337514108d, y: 0.07801592488401121d), new NpgsqlTypes.NpgsqlPoint(x: 0.511848528931342d, y: 0.03370498365400787d), new NpgsqlTypes.NpgsqlPoint(x: 0.8249474393523277d, y: 0.20173557858482094d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4640961049884327d, y: 0.2138677590324617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7557075081700855d, y: 0.5045666725671007d), new NpgsqlTypes.NpgsqlPoint(x: 0.4103840621847127d, y: 0.8348965281951839d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8844723828533287d, y: 0.793049914588066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6562950687871255d, y: 0.1901895039524263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257374746750375d, y: 0.22071649592285647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7818031012344899d, y: 0.43956049623668547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595522369035696d, y: 0.5910471443494253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5544649241117013d, y: 0.859810025696914d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9827625331649066d, y: 0.043794009401728395d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364217727523663d, y: 0.21733050168670665d), new NpgsqlTypes.NpgsqlPoint(x: 0.38223800862643076d, y: 0.5216948171152038d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4035654703496968d, y: 0.9482763311881219d), new NpgsqlTypes.NpgsqlPoint(x: 0.18421457770586225d, y: 0.7430863999529276d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671464965074758d, y: 0.7784006704201667d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17376641771870793d, y: 0.4354483796705153d), new NpgsqlTypes.NpgsqlPoint(x: 0.8744182611539161d, y: 0.5582057892309698d), new NpgsqlTypes.NpgsqlPoint(x: 0.04216655418272097d, y: 0.8169857872232561d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8477183601498393d, y: 0.25673503514574414d), new NpgsqlTypes.NpgsqlPoint(x: 0.19869097068015606d, y: 0.48539939390859554d), new NpgsqlTypes.NpgsqlPoint(x: 0.1556799770844257d, y: 0.25098848621080216d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003470274704285292d, y: 0.050496916819422255d), new NpgsqlTypes.NpgsqlPoint(x: 0.18115693952333622d, y: 0.9647577803349849d), new NpgsqlTypes.NpgsqlPoint(x: 0.7380040139105606d, y: 0.1886921624414334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.380301011464138d, y: 0.9878341472048445d), new NpgsqlTypes.NpgsqlPoint(x: 0.19792322355478376d, y: 0.40923072330497445d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244320790560609d, y: 0.054618098265087345d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10666652607748872d, y: 0.527549577516374d), new NpgsqlTypes.NpgsqlPoint(x: 0.010775277246709902d, y: 0.3072018026438438d), new NpgsqlTypes.NpgsqlPoint(x: 0.8621658322643138d, y: 0.40641283341329304d)),
}));
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05169271761351091d, y: 0.9227106773028109d), new NpgsqlTypes.NpgsqlPoint(x: 0.8197697604215265d, y: 0.3234663967139718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6229334905364089d, y: 0.600388624551168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9214804419018365d, y: 0.04874276531187316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309934643132717d, y: 0.148574110078857d), new NpgsqlTypes.NpgsqlPoint(x: 0.3412002945865321d, y: 0.8937460956712494d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33409488004659393d, y: 0.7012313099612403d), new NpgsqlTypes.NpgsqlPoint(x: 0.02219224985411783d, y: 0.49283915404530065d), new NpgsqlTypes.NpgsqlPoint(x: 0.34366264221281473d, y: 0.17408175906684697d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 51;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 54, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 82, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 170, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 35, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 12, query1, 149, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 49, query1, 170, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 61, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 10, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 10, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 10, 170))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MI),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray1M),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI), typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                await ((INpgsqlPathArraypathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                ((INpgsqlPathArraypathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

