

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
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18724119497476288d, y: 0.588345759845697d), new NpgsqlTypes.NpgsqlPoint(x: 0.47874264876910155d, y: 0.3844030599646975d), new NpgsqlTypes.NpgsqlPoint(x: 0.26343576266428625d, y: 0.04259502715506036d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.366211389376337d, y: 0.17381475076758068d), new NpgsqlTypes.NpgsqlPoint(x: 0.480597914541706d, y: 0.6153216263159834d), new NpgsqlTypes.NpgsqlPoint(x: 0.11210027301014869d, y: 0.8361187011575091d)),
},
            new NpgsqlPathpath0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9603330713361637d, y: 0.7938307935981902d), new NpgsqlTypes.NpgsqlPoint(x: 0.7103661366929976d, y: 0.8262620264475448d), new NpgsqlTypes.NpgsqlPoint(x: 0.902007820817942d, y: 0.25858992142302784d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4114122918748052d, y: 0.5156750999994811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5715603122245678d, y: 0.4230181783076169d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948053954960892d, y: 0.8071935145290086d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3992938249126696d, y: 0.9780933009962849d), new NpgsqlTypes.NpgsqlPoint(x: 0.5422438725874879d, y: 0.6787765412050306d), new NpgsqlTypes.NpgsqlPoint(x: 0.7306462442787277d, y: 0.14604747248919392d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7470676662609671d, y: 0.8150976069771612d), new NpgsqlTypes.NpgsqlPoint(x: 0.3240868533559369d, y: 0.11966121873371882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954674515308288d, y: 0.7770146216438979d)),
},
            new NpgsqlPathpath0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47966050690081996d, y: 0.4512588686408284d), new NpgsqlTypes.NpgsqlPoint(x: 0.2624322811489417d, y: 0.852277316773758d), new NpgsqlTypes.NpgsqlPoint(x: 0.2807316336475646d, y: 0.16138386114270276d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014727717609603896d, y: 0.30141663061432167d), new NpgsqlTypes.NpgsqlPoint(x: 0.5778365788660546d, y: 0.4534659697051935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472707844831901d, y: 0.6516912425270835d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3236811790800833d, y: 0.9431657467649316d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005679685395901801d, y: 0.9898488622516944d), new NpgsqlTypes.NpgsqlPoint(x: 0.1757076220165641d, y: 0.21636307166789304d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3714779878266523d, y: 0.7550274060392936d), new NpgsqlTypes.NpgsqlPoint(x: 0.3345259937732632d, y: 0.6838277779318365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877068150354603d, y: 0.2191902753471947d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7994868720443418d, y: 0.34333674115588075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4757982060119238d, y: 0.967946844511465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9932743335594306d, y: 0.31290589159818827d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4144401686457182d, y: 0.4615903733875032d), new NpgsqlTypes.NpgsqlPoint(x: 0.4640753367503495d, y: 0.8313260502402335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015942883443816d, y: 0.2480571432746408d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046917379360778444d, y: 0.17032998779617037d), new NpgsqlTypes.NpgsqlPoint(x: 0.0734348153982064d, y: 0.7806477449362915d), new NpgsqlTypes.NpgsqlPoint(x: 0.2194986452684784d, y: 0.2295633154993455d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16118519070492732d, y: 0.4230642922211306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8638624756671395d, y: 0.1331614494717026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7727801424283015d, y: 0.3685759607882456d)),
},
            new NpgsqlPathpath0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2695587788628583d, y: 0.9550423252608936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9391867275874735d, y: 0.5373092167098753d), new NpgsqlTypes.NpgsqlPoint(x: 0.1512484793745159d, y: 0.9829497662642862d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6952620269979009d, y: 0.5752408097581339d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883825989578209d, y: 0.38652128370130356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050276966659759d, y: 0.3774338686609149d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7577942453164883d, y: 0.3808101480335315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9101098254846639d, y: 0.25504050902630016d), new NpgsqlTypes.NpgsqlPoint(x: 0.4279665387740429d, y: 0.4785393779432561d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4201107521752181d, y: 0.12080793500937603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924993185879562d, y: 0.10851428578264388d), new NpgsqlTypes.NpgsqlPoint(x: 0.7031930390153626d, y: 0.1614306045304693d)),
},
            new NpgsqlPathpath0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7030268567699237d, y: 0.6162565793536902d), new NpgsqlTypes.NpgsqlPoint(x: 0.0572947425214293d, y: 0.32872989832612776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8731220964476536d, y: 0.9547802918935016d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7728831069294965d, y: 0.8471724427312384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753960990218326d, y: 0.31993577046165333d), new NpgsqlTypes.NpgsqlPoint(x: 0.4181868655055234d, y: 0.7190984662208418d)),
},
            new NpgsqlPathpath0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.130734899108764d, y: 0.27035689290635323d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183130491079859d, y: 0.2163162472884529d), new NpgsqlTypes.NpgsqlPoint(x: 0.07181622402856813d, y: 0.5160680639301751d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15090271850631443d, y: 0.39068638000069955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991422165158317d, y: 0.188673200139707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9017436676665392d, y: 0.9932655510000384d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.943202927821438d, y: 0.6297415790577029d), new NpgsqlTypes.NpgsqlPoint(x: 0.21225767421829655d, y: 0.11865887031756794d), new NpgsqlTypes.NpgsqlPoint(x: 0.798034036851413d, y: 0.3705968699981599d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7061083175150747d, y: 0.09985136270451977d), new NpgsqlTypes.NpgsqlPoint(x: 0.36642431223594485d, y: 0.14083419601706793d), new NpgsqlTypes.NpgsqlPoint(x: 0.11437559385787155d, y: 0.1328337100315845d)),
},
            new NpgsqlPathpath0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7305484038752686d, y: 0.33870187031290777d), new NpgsqlTypes.NpgsqlPoint(x: 0.6902043218740063d, y: 0.5971033757147765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994207296918796d, y: 0.5422283173819186d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5959219994350948d, y: 0.18663176180578323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182755321726813d, y: 0.5953782562982449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328639749111964d, y: 0.9482625808386559d)),
},
            new NpgsqlPathpath0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28941864178177534d, y: 0.33283484940936436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5867211803105309d, y: 0.9008127766521649d), new NpgsqlTypes.NpgsqlPoint(x: 0.013916719569929459d, y: 0.13969399981472364d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12608284253541702d, y: 0.45053308127826885d), new NpgsqlTypes.NpgsqlPoint(x: 0.3044888122439139d, y: 0.021488047401271082d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680367007075556d, y: 0.8400007174916833d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22927360397612728d, y: 0.3453835257913547d), new NpgsqlTypes.NpgsqlPoint(x: 0.3584308324366402d, y: 0.8566527709701639d), new NpgsqlTypes.NpgsqlPoint(x: 0.73964326235438d, y: 0.36266370360882083d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.340799463288492d, y: 0.9621646001979524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5223694210808406d, y: 0.18669480694180285d), new NpgsqlTypes.NpgsqlPoint(x: 0.9250287253803708d, y: 0.5840030718331077d)),
},
            new NpgsqlPathpath0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9299931405318909d, y: 0.6730167607419857d), new NpgsqlTypes.NpgsqlPoint(x: 0.08025567685552404d, y: 0.9857848019421499d), new NpgsqlTypes.NpgsqlPoint(x: 0.14972919231252524d, y: 0.7583630143878995d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23534629906650106d, y: 0.708399078106541d), new NpgsqlTypes.NpgsqlPoint(x: 0.5930531665703562d, y: 0.4888937110764138d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137159093889546d, y: 0.8842105519001785d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5717214568433736d, y: 0.4315455012722449d), new NpgsqlTypes.NpgsqlPoint(x: 0.4255737001482164d, y: 0.6794913069392933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8777153170861218d, y: 0.4647316073591983d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7042184397443526d, y: 0.9844043180172202d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395352755206913d, y: 0.8885562710266246d), new NpgsqlTypes.NpgsqlPoint(x: 0.06668969376243383d, y: 0.8985455045241846d)),
},
            new NpgsqlPathpath0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6747563784335224d, y: 0.5861056261634096d), new NpgsqlTypes.NpgsqlPoint(x: 0.16761228800399286d, y: 0.5968491011007813d), new NpgsqlTypes.NpgsqlPoint(x: 0.08549272521304419d, y: 0.9859415747816617d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7383528555848756d, y: 0.03452777737708934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131768868166604d, y: 0.5967413357259902d), new NpgsqlTypes.NpgsqlPoint(x: 0.1622381027802242d, y: 0.7055277134363778d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33585658136651786d, y: 0.048110595397884204d), new NpgsqlTypes.NpgsqlPoint(x: 0.30088994136964586d, y: 0.8069299997106589d), new NpgsqlTypes.NpgsqlPoint(x: 0.5644970298974414d, y: 0.1634379890858263d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5035668091266922d, y: 0.3172065010302676d), new NpgsqlTypes.NpgsqlPoint(x: 0.041143186782532815d, y: 0.42705360438345963d), new NpgsqlTypes.NpgsqlPoint(x: 0.5497800064543905d, y: 0.37481698708677746d)),
},
            new NpgsqlPathpath0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9545937978246701d, y: 0.7692123525231876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488911086144785d, y: 0.8023112550128328d), new NpgsqlTypes.NpgsqlPoint(x: 0.4394921297079992d, y: 0.02439561636620291d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.669131609679064d, y: 0.2106611510784948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624090980814793d, y: 0.1736128138943075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936639844691042d, y: 0.2626247064433045d)),
},
            new NpgsqlPathpath0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9767600948423414d, y: 0.35146405971461614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7572272129964396d, y: 0.9908760764807274d), new NpgsqlTypes.NpgsqlPoint(x: 0.3628447447646691d, y: 0.5060184086654422d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6900556246608486d, y: 0.7287842728792081d), new NpgsqlTypes.NpgsqlPoint(x: 0.701180034283516d, y: 0.38801226845987413d), new NpgsqlTypes.NpgsqlPoint(x: 0.5628299499576989d, y: 0.4655343725893569d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3425873542120449d, y: 0.5671643410682664d), new NpgsqlTypes.NpgsqlPoint(x: 0.2651562122248411d, y: 0.07221972188031767d), new NpgsqlTypes.NpgsqlPoint(x: 0.26457009519243135d, y: 0.044126873616235796d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7480841829311443d, y: 0.13366540208680255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958851688834965d, y: 0.8349274870108292d), new NpgsqlTypes.NpgsqlPoint(x: 0.18162587269109132d, y: 0.18074765338829102d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06426205523072848d, y: 0.9714918918084687d), new NpgsqlTypes.NpgsqlPoint(x: 0.471020929702475d, y: 0.22229970415553701d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205483961008753d, y: 0.7971850302224609d)),
},
            new NpgsqlPathpath0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2768492242103936d, y: 0.9552422245117141d), new NpgsqlTypes.NpgsqlPoint(x: 0.05540726012063868d, y: 0.9353896251761684d), new NpgsqlTypes.NpgsqlPoint(x: 0.31084472181307055d, y: 0.8908174365886767d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.79024413469512d, y: 0.25461042509270115d), new NpgsqlTypes.NpgsqlPoint(x: 0.03882040038064549d, y: 0.621277670011357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517065865244739d, y: 0.24604151509113903d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07657653499368489d, y: 0.903625875885802d), new NpgsqlTypes.NpgsqlPoint(x: 0.17260793615099956d, y: 0.9910947535271954d), new NpgsqlTypes.NpgsqlPoint(x: 0.2355989091764431d, y: 0.8672215925341847d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8916072574337138d, y: 0.11485359772028458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711603149864909d, y: 0.7383885090496338d), new NpgsqlTypes.NpgsqlPoint(x: 0.419563839877821d, y: 0.6874295054671542d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5067043587220077d, y: 0.5432639023651199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4075355223012158d, y: 0.5002213738680565d), new NpgsqlTypes.NpgsqlPoint(x: 0.4367695541874984d, y: 0.6615399394770075d)),
},
            new NpgsqlPathpath0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5665348079116024d, y: 0.811137189762757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404027648144609d, y: 0.8743335024542606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010923221521543d, y: 0.5488827140776554d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9608327330288475d, y: 0.8914285088258205d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856325123060866d, y: 0.8495181028891203d), new NpgsqlTypes.NpgsqlPoint(x: 0.11202793532805044d, y: 0.29875159302178234d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020317725943291065d, y: 0.5041922891867837d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006954637042758d, y: 0.47832391640037863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6545241348834702d, y: 0.5666901497226421d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11590115154089775d, y: 0.58508808094913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899229960229526d, y: 0.44363630422041345d), new NpgsqlTypes.NpgsqlPoint(x: 0.28075994874075216d, y: 0.10427825359964948d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18066611659935938d, y: 0.768674207083653d), new NpgsqlTypes.NpgsqlPoint(x: 0.1502465346468751d, y: 0.7602145224319091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026465643574016d, y: 0.4537617894801269d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5143940674312295d, y: 0.11733898085492034d), new NpgsqlTypes.NpgsqlPoint(x: 0.252812390580359d, y: 0.5715700831284948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032704164264642d, y: 0.3378225883056589d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03439245361357057d, y: 0.23351194775070572d), new NpgsqlTypes.NpgsqlPoint(x: 0.14880271337838846d, y: 0.08629887724086993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5733378022377759d, y: 0.726204061835806d)),
},
            new NpgsqlPathpath0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24302590672497237d, y: 0.5975836911611564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301837499912438d, y: 0.0002802919244051516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277236600924461d, y: 0.11044314901303143d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32675537310203995d, y: 0.2248160809124814d), new NpgsqlTypes.NpgsqlPoint(x: 0.6313478742243732d, y: 0.4353437689008962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7163745730411513d, y: 0.7585841735433122d)),
},
            new NpgsqlPathpath0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9824287749315539d, y: 0.5935073990110206d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168959275092575d, y: 0.26458488348610976d), new NpgsqlTypes.NpgsqlPoint(x: 0.1698571105821438d, y: 0.4855211904383161d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5120196591421666d, y: 0.4491708043481991d), new NpgsqlTypes.NpgsqlPoint(x: 0.9284767240477737d, y: 0.24942415081981284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255893890680413d, y: 0.8231101320402209d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6938902482319861d, y: 0.4520077349167342d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172056446925724d, y: 0.32873631803248093d), new NpgsqlTypes.NpgsqlPoint(x: 0.16066970011910764d, y: 0.7282747203802123d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2819858173354337d, y: 0.18947599658033332d), new NpgsqlTypes.NpgsqlPoint(x: 0.351714436941474d, y: 0.24018031740862456d), new NpgsqlTypes.NpgsqlPoint(x: 0.02707993171064116d, y: 0.8611262798323729d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6536933814927974d, y: 0.09294765559009899d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846026272911043d, y: 0.9212343454921655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792859571008314d, y: 0.8000287885025551d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2989142104940854d, y: 0.19233207594917368d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227949455576899d, y: 0.8445403446117589d), new NpgsqlTypes.NpgsqlPoint(x: 0.38041718235029776d, y: 0.13316031842149323d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29026774075211015d, y: 0.7624012857770948d), new NpgsqlTypes.NpgsqlPoint(x: 0.10919345123345447d, y: 0.7340028677451814d), new NpgsqlTypes.NpgsqlPoint(x: 0.3854392636888777d, y: 0.3713633022455175d)),
},
            new NpgsqlPathpath0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2774327000926635d, y: 0.2655063871786728d), new NpgsqlTypes.NpgsqlPoint(x: 0.06059294555833661d, y: 0.8069082643217995d), new NpgsqlTypes.NpgsqlPoint(x: 0.24482301281459518d, y: 0.34617654605151316d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3062940321336012d, y: 0.21173280509142367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7115137560585215d, y: 0.7009477829359634d), new NpgsqlTypes.NpgsqlPoint(x: 0.023869224266664157d, y: 0.6792305013394314d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3770554207641055d, y: 0.7894365362043887d), new NpgsqlTypes.NpgsqlPoint(x: 0.355469017044029d, y: 0.7009410961075432d), new NpgsqlTypes.NpgsqlPoint(x: 0.5141516134964754d, y: 0.8012419969893461d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23376002121709671d, y: 0.5742317243036872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291375013783725d, y: 0.7932578902850127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9684099369323466d, y: 0.43822602884986583d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1951525627050299d, y: 0.658351934798546d), new NpgsqlTypes.NpgsqlPoint(x: 0.1130321392257061d, y: 0.6534521171669252d), new NpgsqlTypes.NpgsqlPoint(x: 0.9931101446945739d, y: 0.8681859439604662d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47576406197997245d, y: 0.17171946868021626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6797879049727017d, y: 0.19850621514050837d), new NpgsqlTypes.NpgsqlPoint(x: 0.922074657700578d, y: 0.029785532468991516d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22113012630193563d, y: 0.3065245781220931d), new NpgsqlTypes.NpgsqlPoint(x: 0.397452005072358d, y: 0.8589313163650546d), new NpgsqlTypes.NpgsqlPoint(x: 0.41521957964208045d, y: 0.1615675576946487d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3236264668323392d, y: 0.15601850158229447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9480179504545654d, y: 0.2411637471247341d), new NpgsqlTypes.NpgsqlPoint(x: 0.967122172217707d, y: 0.9914444065204009d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12151229101781358d, y: 0.38118482139853815d), new NpgsqlTypes.NpgsqlPoint(x: 0.0342022939867479d, y: 0.9421729798277841d), new NpgsqlTypes.NpgsqlPoint(x: 0.5299072446785201d, y: 0.39149465372536163d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.963766291769422d, y: 0.42280406768340606d), new NpgsqlTypes.NpgsqlPoint(x: 0.13082013628429356d, y: 0.2711120307435615d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859802511685374d, y: 0.25004366670011424d)),
},
            new NpgsqlPathpath0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02468767367235203d, y: 0.7002625995140124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492245732608698d, y: 0.07189129822704143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503766402657961d, y: 0.642958523620737d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7070028047484044d, y: 0.16573800180544007d), new NpgsqlTypes.NpgsqlPoint(x: 0.29829200003846223d, y: 0.553744795307192d), new NpgsqlTypes.NpgsqlPoint(x: 0.4295367710187119d, y: 0.07443821387144078d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6422595551174183d, y: 0.800284411334509d), new NpgsqlTypes.NpgsqlPoint(x: 0.2515389162892686d, y: 0.7263694159402251d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807844962691691d, y: 0.27435498594219376d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1710303066830794d, y: 0.14999808195035247d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906140422549117d, y: 0.614302177732061d), new NpgsqlTypes.NpgsqlPoint(x: 0.3807930298181035d, y: 0.5393678680879622d)),
},
            new NpgsqlPathpath0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37705903682808806d, y: 0.22870000629955278d), new NpgsqlTypes.NpgsqlPoint(x: 0.42588269033879567d, y: 0.18715851512977644d), new NpgsqlTypes.NpgsqlPoint(x: 0.017554821089426853d, y: 0.8142269870746024d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6984130464151567d, y: 0.4741555355028203d), new NpgsqlTypes.NpgsqlPoint(x: 0.9983957397308761d, y: 0.8476244462785083d), new NpgsqlTypes.NpgsqlPoint(x: 0.588977156832916d, y: 0.6123138433049774d)),
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16118519070492732d, y: 0.4230642922211306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8638624756671395d, y: 0.1331614494717026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7727801424283015d, y: 0.3685759607882456d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4201107521752181d, y: 0.12080793500937603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924993185879562d, y: 0.10851428578264388d), new NpgsqlTypes.NpgsqlPoint(x: 0.7031930390153626d, y: 0.1614306045304693d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7728831069294965d, y: 0.8471724427312384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753960990218326d, y: 0.31993577046165333d), new NpgsqlTypes.NpgsqlPoint(x: 0.4181868655055234d, y: 0.7190984662208418d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7061083175150747d, y: 0.09985136270451977d), new NpgsqlTypes.NpgsqlPoint(x: 0.36642431223594485d, y: 0.14083419601706793d), new NpgsqlTypes.NpgsqlPoint(x: 0.11437559385787155d, y: 0.1328337100315845d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5959219994350948d, y: 0.18663176180578323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182755321726813d, y: 0.5953782562982449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328639749111964d, y: 0.9482625808386559d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.340799463288492d, y: 0.9621646001979524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5223694210808406d, y: 0.18669480694180285d), new NpgsqlTypes.NpgsqlPoint(x: 0.9250287253803708d, y: 0.5840030718331077d))));
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[34], false);
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
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 34, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
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
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[31],_testData[34], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 59, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 8, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 50, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 131, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[34], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 102, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 113, query1, 74, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 40, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 28, 128))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 113, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[34], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));
NpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);NpgsqlPathpath0M.AssertModel(models[29],_testData[30], false);NpgsqlPathpath0M.AssertModel(models[30],_testData[31], false);NpgsqlPathpath0M.AssertModel(models[31],_testData[32], false);NpgsqlPathpath0M.AssertModel(models[32],_testData[33], false);NpgsqlPathpath0M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPathpath0M.AssertModel(models[0],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[29], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[30], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[31], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[32], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[33], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18724119497476288d, y: 0.588345759845697d), new NpgsqlTypes.NpgsqlPoint(x: 0.47874264876910155d, y: 0.3844030599646975d), new NpgsqlTypes.NpgsqlPoint(x: 0.26343576266428625d, y: 0.04259502715506036d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.366211389376337d, y: 0.17381475076758068d), new NpgsqlTypes.NpgsqlPoint(x: 0.480597914541706d, y: 0.6153216263159834d), new NpgsqlTypes.NpgsqlPoint(x: 0.11210027301014869d, y: 0.8361187011575091d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9603330713361637d, y: 0.7938307935981902d), new NpgsqlTypes.NpgsqlPoint(x: 0.7103661366929976d, y: 0.8262620264475448d), new NpgsqlTypes.NpgsqlPoint(x: 0.902007820817942d, y: 0.25858992142302784d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4114122918748052d, y: 0.5156750999994811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5715603122245678d, y: 0.4230181783076169d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948053954960892d, y: 0.8071935145290086d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3992938249126696d, y: 0.9780933009962849d), new NpgsqlTypes.NpgsqlPoint(x: 0.5422438725874879d, y: 0.6787765412050306d), new NpgsqlTypes.NpgsqlPoint(x: 0.7306462442787277d, y: 0.14604747248919392d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7470676662609671d, y: 0.8150976069771612d), new NpgsqlTypes.NpgsqlPoint(x: 0.3240868533559369d, y: 0.11966121873371882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954674515308288d, y: 0.7770146216438979d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47966050690081996d, y: 0.4512588686408284d), new NpgsqlTypes.NpgsqlPoint(x: 0.2624322811489417d, y: 0.852277316773758d), new NpgsqlTypes.NpgsqlPoint(x: 0.2807316336475646d, y: 0.16138386114270276d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014727717609603896d, y: 0.30141663061432167d), new NpgsqlTypes.NpgsqlPoint(x: 0.5778365788660546d, y: 0.4534659697051935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472707844831901d, y: 0.6516912425270835d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3236811790800833d, y: 0.9431657467649316d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005679685395901801d, y: 0.9898488622516944d), new NpgsqlTypes.NpgsqlPoint(x: 0.1757076220165641d, y: 0.21636307166789304d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3714779878266523d, y: 0.7550274060392936d), new NpgsqlTypes.NpgsqlPoint(x: 0.3345259937732632d, y: 0.6838277779318365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877068150354603d, y: 0.2191902753471947d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7994868720443418d, y: 0.34333674115588075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4757982060119238d, y: 0.967946844511465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9932743335594306d, y: 0.31290589159818827d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4144401686457182d, y: 0.4615903733875032d), new NpgsqlTypes.NpgsqlPoint(x: 0.4640753367503495d, y: 0.8313260502402335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015942883443816d, y: 0.2480571432746408d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046917379360778444d, y: 0.17032998779617037d), new NpgsqlTypes.NpgsqlPoint(x: 0.0734348153982064d, y: 0.7806477449362915d), new NpgsqlTypes.NpgsqlPoint(x: 0.2194986452684784d, y: 0.2295633154993455d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16118519070492732d, y: 0.4230642922211306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8638624756671395d, y: 0.1331614494717026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7727801424283015d, y: 0.3685759607882456d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2695587788628583d, y: 0.9550423252608936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9391867275874735d, y: 0.5373092167098753d), new NpgsqlTypes.NpgsqlPoint(x: 0.1512484793745159d, y: 0.9829497662642862d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6952620269979009d, y: 0.5752408097581339d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883825989578209d, y: 0.38652128370130356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050276966659759d, y: 0.3774338686609149d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7577942453164883d, y: 0.3808101480335315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9101098254846639d, y: 0.25504050902630016d), new NpgsqlTypes.NpgsqlPoint(x: 0.4279665387740429d, y: 0.4785393779432561d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4201107521752181d, y: 0.12080793500937603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924993185879562d, y: 0.10851428578264388d), new NpgsqlTypes.NpgsqlPoint(x: 0.7031930390153626d, y: 0.1614306045304693d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7030268567699237d, y: 0.6162565793536902d), new NpgsqlTypes.NpgsqlPoint(x: 0.0572947425214293d, y: 0.32872989832612776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8731220964476536d, y: 0.9547802918935016d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7728831069294965d, y: 0.8471724427312384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753960990218326d, y: 0.31993577046165333d), new NpgsqlTypes.NpgsqlPoint(x: 0.4181868655055234d, y: 0.7190984662208418d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.130734899108764d, y: 0.27035689290635323d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183130491079859d, y: 0.2163162472884529d), new NpgsqlTypes.NpgsqlPoint(x: 0.07181622402856813d, y: 0.5160680639301751d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15090271850631443d, y: 0.39068638000069955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991422165158317d, y: 0.188673200139707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9017436676665392d, y: 0.9932655510000384d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.943202927821438d, y: 0.6297415790577029d), new NpgsqlTypes.NpgsqlPoint(x: 0.21225767421829655d, y: 0.11865887031756794d), new NpgsqlTypes.NpgsqlPoint(x: 0.798034036851413d, y: 0.3705968699981599d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7061083175150747d, y: 0.09985136270451977d), new NpgsqlTypes.NpgsqlPoint(x: 0.36642431223594485d, y: 0.14083419601706793d), new NpgsqlTypes.NpgsqlPoint(x: 0.11437559385787155d, y: 0.1328337100315845d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7305484038752686d, y: 0.33870187031290777d), new NpgsqlTypes.NpgsqlPoint(x: 0.6902043218740063d, y: 0.5971033757147765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994207296918796d, y: 0.5422283173819186d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5959219994350948d, y: 0.18663176180578323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182755321726813d, y: 0.5953782562982449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328639749111964d, y: 0.9482625808386559d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28941864178177534d, y: 0.33283484940936436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5867211803105309d, y: 0.9008127766521649d), new NpgsqlTypes.NpgsqlPoint(x: 0.013916719569929459d, y: 0.13969399981472364d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12608284253541702d, y: 0.45053308127826885d), new NpgsqlTypes.NpgsqlPoint(x: 0.3044888122439139d, y: 0.021488047401271082d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680367007075556d, y: 0.8400007174916833d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22927360397612728d, y: 0.3453835257913547d), new NpgsqlTypes.NpgsqlPoint(x: 0.3584308324366402d, y: 0.8566527709701639d), new NpgsqlTypes.NpgsqlPoint(x: 0.73964326235438d, y: 0.36266370360882083d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.340799463288492d, y: 0.9621646001979524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5223694210808406d, y: 0.18669480694180285d), new NpgsqlTypes.NpgsqlPoint(x: 0.9250287253803708d, y: 0.5840030718331077d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9299931405318909d, y: 0.6730167607419857d), new NpgsqlTypes.NpgsqlPoint(x: 0.08025567685552404d, y: 0.9857848019421499d), new NpgsqlTypes.NpgsqlPoint(x: 0.14972919231252524d, y: 0.7583630143878995d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23534629906650106d, y: 0.708399078106541d), new NpgsqlTypes.NpgsqlPoint(x: 0.5930531665703562d, y: 0.4888937110764138d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137159093889546d, y: 0.8842105519001785d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5717214568433736d, y: 0.4315455012722449d), new NpgsqlTypes.NpgsqlPoint(x: 0.4255737001482164d, y: 0.6794913069392933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8777153170861218d, y: 0.4647316073591983d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7042184397443526d, y: 0.9844043180172202d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395352755206913d, y: 0.8885562710266246d), new NpgsqlTypes.NpgsqlPoint(x: 0.06668969376243383d, y: 0.8985455045241846d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6747563784335224d, y: 0.5861056261634096d), new NpgsqlTypes.NpgsqlPoint(x: 0.16761228800399286d, y: 0.5968491011007813d), new NpgsqlTypes.NpgsqlPoint(x: 0.08549272521304419d, y: 0.9859415747816617d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7383528555848756d, y: 0.03452777737708934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131768868166604d, y: 0.5967413357259902d), new NpgsqlTypes.NpgsqlPoint(x: 0.1622381027802242d, y: 0.7055277134363778d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33585658136651786d, y: 0.048110595397884204d), new NpgsqlTypes.NpgsqlPoint(x: 0.30088994136964586d, y: 0.8069299997106589d), new NpgsqlTypes.NpgsqlPoint(x: 0.5644970298974414d, y: 0.1634379890858263d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5035668091266922d, y: 0.3172065010302676d), new NpgsqlTypes.NpgsqlPoint(x: 0.041143186782532815d, y: 0.42705360438345963d), new NpgsqlTypes.NpgsqlPoint(x: 0.5497800064543905d, y: 0.37481698708677746d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9545937978246701d, y: 0.7692123525231876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488911086144785d, y: 0.8023112550128328d), new NpgsqlTypes.NpgsqlPoint(x: 0.4394921297079992d, y: 0.02439561636620291d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.669131609679064d, y: 0.2106611510784948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624090980814793d, y: 0.1736128138943075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936639844691042d, y: 0.2626247064433045d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9767600948423414d, y: 0.35146405971461614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7572272129964396d, y: 0.9908760764807274d), new NpgsqlTypes.NpgsqlPoint(x: 0.3628447447646691d, y: 0.5060184086654422d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6900556246608486d, y: 0.7287842728792081d), new NpgsqlTypes.NpgsqlPoint(x: 0.701180034283516d, y: 0.38801226845987413d), new NpgsqlTypes.NpgsqlPoint(x: 0.5628299499576989d, y: 0.4655343725893569d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3425873542120449d, y: 0.5671643410682664d), new NpgsqlTypes.NpgsqlPoint(x: 0.2651562122248411d, y: 0.07221972188031767d), new NpgsqlTypes.NpgsqlPoint(x: 0.26457009519243135d, y: 0.044126873616235796d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7480841829311443d, y: 0.13366540208680255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958851688834965d, y: 0.8349274870108292d), new NpgsqlTypes.NpgsqlPoint(x: 0.18162587269109132d, y: 0.18074765338829102d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06426205523072848d, y: 0.9714918918084687d), new NpgsqlTypes.NpgsqlPoint(x: 0.471020929702475d, y: 0.22229970415553701d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205483961008753d, y: 0.7971850302224609d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2768492242103936d, y: 0.9552422245117141d), new NpgsqlTypes.NpgsqlPoint(x: 0.05540726012063868d, y: 0.9353896251761684d), new NpgsqlTypes.NpgsqlPoint(x: 0.31084472181307055d, y: 0.8908174365886767d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.79024413469512d, y: 0.25461042509270115d), new NpgsqlTypes.NpgsqlPoint(x: 0.03882040038064549d, y: 0.621277670011357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517065865244739d, y: 0.24604151509113903d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07657653499368489d, y: 0.903625875885802d), new NpgsqlTypes.NpgsqlPoint(x: 0.17260793615099956d, y: 0.9910947535271954d), new NpgsqlTypes.NpgsqlPoint(x: 0.2355989091764431d, y: 0.8672215925341847d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8916072574337138d, y: 0.11485359772028458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711603149864909d, y: 0.7383885090496338d), new NpgsqlTypes.NpgsqlPoint(x: 0.419563839877821d, y: 0.6874295054671542d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5067043587220077d, y: 0.5432639023651199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4075355223012158d, y: 0.5002213738680565d), new NpgsqlTypes.NpgsqlPoint(x: 0.4367695541874984d, y: 0.6615399394770075d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5665348079116024d, y: 0.811137189762757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404027648144609d, y: 0.8743335024542606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010923221521543d, y: 0.5488827140776554d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9608327330288475d, y: 0.8914285088258205d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856325123060866d, y: 0.8495181028891203d), new NpgsqlTypes.NpgsqlPoint(x: 0.11202793532805044d, y: 0.29875159302178234d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020317725943291065d, y: 0.5041922891867837d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006954637042758d, y: 0.47832391640037863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6545241348834702d, y: 0.5666901497226421d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11590115154089775d, y: 0.58508808094913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899229960229526d, y: 0.44363630422041345d), new NpgsqlTypes.NpgsqlPoint(x: 0.28075994874075216d, y: 0.10427825359964948d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18066611659935938d, y: 0.768674207083653d), new NpgsqlTypes.NpgsqlPoint(x: 0.1502465346468751d, y: 0.7602145224319091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026465643574016d, y: 0.4537617894801269d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5143940674312295d, y: 0.11733898085492034d), new NpgsqlTypes.NpgsqlPoint(x: 0.252812390580359d, y: 0.5715700831284948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032704164264642d, y: 0.3378225883056589d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03439245361357057d, y: 0.23351194775070572d), new NpgsqlTypes.NpgsqlPoint(x: 0.14880271337838846d, y: 0.08629887724086993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5733378022377759d, y: 0.726204061835806d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24302590672497237d, y: 0.5975836911611564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301837499912438d, y: 0.0002802919244051516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277236600924461d, y: 0.11044314901303143d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32675537310203995d, y: 0.2248160809124814d), new NpgsqlTypes.NpgsqlPoint(x: 0.6313478742243732d, y: 0.4353437689008962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7163745730411513d, y: 0.7585841735433122d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9824287749315539d, y: 0.5935073990110206d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168959275092575d, y: 0.26458488348610976d), new NpgsqlTypes.NpgsqlPoint(x: 0.1698571105821438d, y: 0.4855211904383161d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5120196591421666d, y: 0.4491708043481991d), new NpgsqlTypes.NpgsqlPoint(x: 0.9284767240477737d, y: 0.24942415081981284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255893890680413d, y: 0.8231101320402209d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6938902482319861d, y: 0.4520077349167342d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172056446925724d, y: 0.32873631803248093d), new NpgsqlTypes.NpgsqlPoint(x: 0.16066970011910764d, y: 0.7282747203802123d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2819858173354337d, y: 0.18947599658033332d), new NpgsqlTypes.NpgsqlPoint(x: 0.351714436941474d, y: 0.24018031740862456d), new NpgsqlTypes.NpgsqlPoint(x: 0.02707993171064116d, y: 0.8611262798323729d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6536933814927974d, y: 0.09294765559009899d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846026272911043d, y: 0.9212343454921655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792859571008314d, y: 0.8000287885025551d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2989142104940854d, y: 0.19233207594917368d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227949455576899d, y: 0.8445403446117589d), new NpgsqlTypes.NpgsqlPoint(x: 0.38041718235029776d, y: 0.13316031842149323d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29026774075211015d, y: 0.7624012857770948d), new NpgsqlTypes.NpgsqlPoint(x: 0.10919345123345447d, y: 0.7340028677451814d), new NpgsqlTypes.NpgsqlPoint(x: 0.3854392636888777d, y: 0.3713633022455175d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2774327000926635d, y: 0.2655063871786728d), new NpgsqlTypes.NpgsqlPoint(x: 0.06059294555833661d, y: 0.8069082643217995d), new NpgsqlTypes.NpgsqlPoint(x: 0.24482301281459518d, y: 0.34617654605151316d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3062940321336012d, y: 0.21173280509142367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7115137560585215d, y: 0.7009477829359634d), new NpgsqlTypes.NpgsqlPoint(x: 0.023869224266664157d, y: 0.6792305013394314d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3770554207641055d, y: 0.7894365362043887d), new NpgsqlTypes.NpgsqlPoint(x: 0.355469017044029d, y: 0.7009410961075432d), new NpgsqlTypes.NpgsqlPoint(x: 0.5141516134964754d, y: 0.8012419969893461d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23376002121709671d, y: 0.5742317243036872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291375013783725d, y: 0.7932578902850127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9684099369323466d, y: 0.43822602884986583d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1951525627050299d, y: 0.658351934798546d), new NpgsqlTypes.NpgsqlPoint(x: 0.1130321392257061d, y: 0.6534521171669252d), new NpgsqlTypes.NpgsqlPoint(x: 0.9931101446945739d, y: 0.8681859439604662d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47576406197997245d, y: 0.17171946868021626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6797879049727017d, y: 0.19850621514050837d), new NpgsqlTypes.NpgsqlPoint(x: 0.922074657700578d, y: 0.029785532468991516d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22113012630193563d, y: 0.3065245781220931d), new NpgsqlTypes.NpgsqlPoint(x: 0.397452005072358d, y: 0.8589313163650546d), new NpgsqlTypes.NpgsqlPoint(x: 0.41521957964208045d, y: 0.1615675576946487d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3236264668323392d, y: 0.15601850158229447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9480179504545654d, y: 0.2411637471247341d), new NpgsqlTypes.NpgsqlPoint(x: 0.967122172217707d, y: 0.9914444065204009d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12151229101781358d, y: 0.38118482139853815d), new NpgsqlTypes.NpgsqlPoint(x: 0.0342022939867479d, y: 0.9421729798277841d), new NpgsqlTypes.NpgsqlPoint(x: 0.5299072446785201d, y: 0.39149465372536163d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.963766291769422d, y: 0.42280406768340606d), new NpgsqlTypes.NpgsqlPoint(x: 0.13082013628429356d, y: 0.2711120307435615d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859802511685374d, y: 0.25004366670011424d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02468767367235203d, y: 0.7002625995140124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492245732608698d, y: 0.07189129822704143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503766402657961d, y: 0.642958523620737d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7070028047484044d, y: 0.16573800180544007d), new NpgsqlTypes.NpgsqlPoint(x: 0.29829200003846223d, y: 0.553744795307192d), new NpgsqlTypes.NpgsqlPoint(x: 0.4295367710187119d, y: 0.07443821387144078d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6422595551174183d, y: 0.800284411334509d), new NpgsqlTypes.NpgsqlPoint(x: 0.2515389162892686d, y: 0.7263694159402251d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807844962691691d, y: 0.27435498594219376d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1710303066830794d, y: 0.14999808195035247d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906140422549117d, y: 0.614302177732061d), new NpgsqlTypes.NpgsqlPoint(x: 0.3807930298181035d, y: 0.5393678680879622d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37705903682808806d, y: 0.22870000629955278d), new NpgsqlTypes.NpgsqlPoint(x: 0.42588269033879567d, y: 0.18715851512977644d), new NpgsqlTypes.NpgsqlPoint(x: 0.017554821089426853d, y: 0.8142269870746024d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6984130464151567d, y: 0.4741555355028203d), new NpgsqlTypes.NpgsqlPoint(x: 0.9983957397308761d, y: 0.8476244462785083d), new NpgsqlTypes.NpgsqlPoint(x: 0.588977156832916d, y: 0.6123138433049774d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18724119497476288d, y: 0.588345759845697d), new NpgsqlTypes.NpgsqlPoint(x: 0.47874264876910155d, y: 0.3844030599646975d), new NpgsqlTypes.NpgsqlPoint(x: 0.26343576266428625d, y: 0.04259502715506036d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.366211389376337d, y: 0.17381475076758068d), new NpgsqlTypes.NpgsqlPoint(x: 0.480597914541706d, y: 0.6153216263159834d), new NpgsqlTypes.NpgsqlPoint(x: 0.11210027301014869d, y: 0.8361187011575091d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9603330713361637d, y: 0.7938307935981902d), new NpgsqlTypes.NpgsqlPoint(x: 0.7103661366929976d, y: 0.8262620264475448d), new NpgsqlTypes.NpgsqlPoint(x: 0.902007820817942d, y: 0.25858992142302784d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4114122918748052d, y: 0.5156750999994811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5715603122245678d, y: 0.4230181783076169d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948053954960892d, y: 0.8071935145290086d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3992938249126696d, y: 0.9780933009962849d), new NpgsqlTypes.NpgsqlPoint(x: 0.5422438725874879d, y: 0.6787765412050306d), new NpgsqlTypes.NpgsqlPoint(x: 0.7306462442787277d, y: 0.14604747248919392d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7470676662609671d, y: 0.8150976069771612d), new NpgsqlTypes.NpgsqlPoint(x: 0.3240868533559369d, y: 0.11966121873371882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954674515308288d, y: 0.7770146216438979d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47966050690081996d, y: 0.4512588686408284d), new NpgsqlTypes.NpgsqlPoint(x: 0.2624322811489417d, y: 0.852277316773758d), new NpgsqlTypes.NpgsqlPoint(x: 0.2807316336475646d, y: 0.16138386114270276d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014727717609603896d, y: 0.30141663061432167d), new NpgsqlTypes.NpgsqlPoint(x: 0.5778365788660546d, y: 0.4534659697051935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472707844831901d, y: 0.6516912425270835d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3236811790800833d, y: 0.9431657467649316d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005679685395901801d, y: 0.9898488622516944d), new NpgsqlTypes.NpgsqlPoint(x: 0.1757076220165641d, y: 0.21636307166789304d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3714779878266523d, y: 0.7550274060392936d), new NpgsqlTypes.NpgsqlPoint(x: 0.3345259937732632d, y: 0.6838277779318365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877068150354603d, y: 0.2191902753471947d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7994868720443418d, y: 0.34333674115588075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4757982060119238d, y: 0.967946844511465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9932743335594306d, y: 0.31290589159818827d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4144401686457182d, y: 0.4615903733875032d), new NpgsqlTypes.NpgsqlPoint(x: 0.4640753367503495d, y: 0.8313260502402335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015942883443816d, y: 0.2480571432746408d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046917379360778444d, y: 0.17032998779617037d), new NpgsqlTypes.NpgsqlPoint(x: 0.0734348153982064d, y: 0.7806477449362915d), new NpgsqlTypes.NpgsqlPoint(x: 0.2194986452684784d, y: 0.2295633154993455d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16118519070492732d, y: 0.4230642922211306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8638624756671395d, y: 0.1331614494717026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7727801424283015d, y: 0.3685759607882456d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2695587788628583d, y: 0.9550423252608936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9391867275874735d, y: 0.5373092167098753d), new NpgsqlTypes.NpgsqlPoint(x: 0.1512484793745159d, y: 0.9829497662642862d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6952620269979009d, y: 0.5752408097581339d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883825989578209d, y: 0.38652128370130356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050276966659759d, y: 0.3774338686609149d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7577942453164883d, y: 0.3808101480335315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9101098254846639d, y: 0.25504050902630016d), new NpgsqlTypes.NpgsqlPoint(x: 0.4279665387740429d, y: 0.4785393779432561d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4201107521752181d, y: 0.12080793500937603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924993185879562d, y: 0.10851428578264388d), new NpgsqlTypes.NpgsqlPoint(x: 0.7031930390153626d, y: 0.1614306045304693d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7030268567699237d, y: 0.6162565793536902d), new NpgsqlTypes.NpgsqlPoint(x: 0.0572947425214293d, y: 0.32872989832612776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8731220964476536d, y: 0.9547802918935016d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7728831069294965d, y: 0.8471724427312384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753960990218326d, y: 0.31993577046165333d), new NpgsqlTypes.NpgsqlPoint(x: 0.4181868655055234d, y: 0.7190984662208418d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.130734899108764d, y: 0.27035689290635323d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183130491079859d, y: 0.2163162472884529d), new NpgsqlTypes.NpgsqlPoint(x: 0.07181622402856813d, y: 0.5160680639301751d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15090271850631443d, y: 0.39068638000069955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991422165158317d, y: 0.188673200139707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9017436676665392d, y: 0.9932655510000384d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.943202927821438d, y: 0.6297415790577029d), new NpgsqlTypes.NpgsqlPoint(x: 0.21225767421829655d, y: 0.11865887031756794d), new NpgsqlTypes.NpgsqlPoint(x: 0.798034036851413d, y: 0.3705968699981599d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7061083175150747d, y: 0.09985136270451977d), new NpgsqlTypes.NpgsqlPoint(x: 0.36642431223594485d, y: 0.14083419601706793d), new NpgsqlTypes.NpgsqlPoint(x: 0.11437559385787155d, y: 0.1328337100315845d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7305484038752686d, y: 0.33870187031290777d), new NpgsqlTypes.NpgsqlPoint(x: 0.6902043218740063d, y: 0.5971033757147765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994207296918796d, y: 0.5422283173819186d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5959219994350948d, y: 0.18663176180578323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182755321726813d, y: 0.5953782562982449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328639749111964d, y: 0.9482625808386559d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28941864178177534d, y: 0.33283484940936436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5867211803105309d, y: 0.9008127766521649d), new NpgsqlTypes.NpgsqlPoint(x: 0.013916719569929459d, y: 0.13969399981472364d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12608284253541702d, y: 0.45053308127826885d), new NpgsqlTypes.NpgsqlPoint(x: 0.3044888122439139d, y: 0.021488047401271082d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680367007075556d, y: 0.8400007174916833d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22927360397612728d, y: 0.3453835257913547d), new NpgsqlTypes.NpgsqlPoint(x: 0.3584308324366402d, y: 0.8566527709701639d), new NpgsqlTypes.NpgsqlPoint(x: 0.73964326235438d, y: 0.36266370360882083d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.340799463288492d, y: 0.9621646001979524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5223694210808406d, y: 0.18669480694180285d), new NpgsqlTypes.NpgsqlPoint(x: 0.9250287253803708d, y: 0.5840030718331077d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9299931405318909d, y: 0.6730167607419857d), new NpgsqlTypes.NpgsqlPoint(x: 0.08025567685552404d, y: 0.9857848019421499d), new NpgsqlTypes.NpgsqlPoint(x: 0.14972919231252524d, y: 0.7583630143878995d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23534629906650106d, y: 0.708399078106541d), new NpgsqlTypes.NpgsqlPoint(x: 0.5930531665703562d, y: 0.4888937110764138d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137159093889546d, y: 0.8842105519001785d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5717214568433736d, y: 0.4315455012722449d), new NpgsqlTypes.NpgsqlPoint(x: 0.4255737001482164d, y: 0.6794913069392933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8777153170861218d, y: 0.4647316073591983d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7042184397443526d, y: 0.9844043180172202d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395352755206913d, y: 0.8885562710266246d), new NpgsqlTypes.NpgsqlPoint(x: 0.06668969376243383d, y: 0.8985455045241846d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6747563784335224d, y: 0.5861056261634096d), new NpgsqlTypes.NpgsqlPoint(x: 0.16761228800399286d, y: 0.5968491011007813d), new NpgsqlTypes.NpgsqlPoint(x: 0.08549272521304419d, y: 0.9859415747816617d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7383528555848756d, y: 0.03452777737708934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131768868166604d, y: 0.5967413357259902d), new NpgsqlTypes.NpgsqlPoint(x: 0.1622381027802242d, y: 0.7055277134363778d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33585658136651786d, y: 0.048110595397884204d), new NpgsqlTypes.NpgsqlPoint(x: 0.30088994136964586d, y: 0.8069299997106589d), new NpgsqlTypes.NpgsqlPoint(x: 0.5644970298974414d, y: 0.1634379890858263d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5035668091266922d, y: 0.3172065010302676d), new NpgsqlTypes.NpgsqlPoint(x: 0.041143186782532815d, y: 0.42705360438345963d), new NpgsqlTypes.NpgsqlPoint(x: 0.5497800064543905d, y: 0.37481698708677746d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9545937978246701d, y: 0.7692123525231876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488911086144785d, y: 0.8023112550128328d), new NpgsqlTypes.NpgsqlPoint(x: 0.4394921297079992d, y: 0.02439561636620291d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.669131609679064d, y: 0.2106611510784948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624090980814793d, y: 0.1736128138943075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936639844691042d, y: 0.2626247064433045d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9767600948423414d, y: 0.35146405971461614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7572272129964396d, y: 0.9908760764807274d), new NpgsqlTypes.NpgsqlPoint(x: 0.3628447447646691d, y: 0.5060184086654422d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6900556246608486d, y: 0.7287842728792081d), new NpgsqlTypes.NpgsqlPoint(x: 0.701180034283516d, y: 0.38801226845987413d), new NpgsqlTypes.NpgsqlPoint(x: 0.5628299499576989d, y: 0.4655343725893569d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3425873542120449d, y: 0.5671643410682664d), new NpgsqlTypes.NpgsqlPoint(x: 0.2651562122248411d, y: 0.07221972188031767d), new NpgsqlTypes.NpgsqlPoint(x: 0.26457009519243135d, y: 0.044126873616235796d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7480841829311443d, y: 0.13366540208680255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958851688834965d, y: 0.8349274870108292d), new NpgsqlTypes.NpgsqlPoint(x: 0.18162587269109132d, y: 0.18074765338829102d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06426205523072848d, y: 0.9714918918084687d), new NpgsqlTypes.NpgsqlPoint(x: 0.471020929702475d, y: 0.22229970415553701d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205483961008753d, y: 0.7971850302224609d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2768492242103936d, y: 0.9552422245117141d), new NpgsqlTypes.NpgsqlPoint(x: 0.05540726012063868d, y: 0.9353896251761684d), new NpgsqlTypes.NpgsqlPoint(x: 0.31084472181307055d, y: 0.8908174365886767d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.79024413469512d, y: 0.25461042509270115d), new NpgsqlTypes.NpgsqlPoint(x: 0.03882040038064549d, y: 0.621277670011357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517065865244739d, y: 0.24604151509113903d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07657653499368489d, y: 0.903625875885802d), new NpgsqlTypes.NpgsqlPoint(x: 0.17260793615099956d, y: 0.9910947535271954d), new NpgsqlTypes.NpgsqlPoint(x: 0.2355989091764431d, y: 0.8672215925341847d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8916072574337138d, y: 0.11485359772028458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711603149864909d, y: 0.7383885090496338d), new NpgsqlTypes.NpgsqlPoint(x: 0.419563839877821d, y: 0.6874295054671542d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5067043587220077d, y: 0.5432639023651199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4075355223012158d, y: 0.5002213738680565d), new NpgsqlTypes.NpgsqlPoint(x: 0.4367695541874984d, y: 0.6615399394770075d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5665348079116024d, y: 0.811137189762757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404027648144609d, y: 0.8743335024542606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010923221521543d, y: 0.5488827140776554d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9608327330288475d, y: 0.8914285088258205d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856325123060866d, y: 0.8495181028891203d), new NpgsqlTypes.NpgsqlPoint(x: 0.11202793532805044d, y: 0.29875159302178234d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020317725943291065d, y: 0.5041922891867837d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006954637042758d, y: 0.47832391640037863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6545241348834702d, y: 0.5666901497226421d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11590115154089775d, y: 0.58508808094913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899229960229526d, y: 0.44363630422041345d), new NpgsqlTypes.NpgsqlPoint(x: 0.28075994874075216d, y: 0.10427825359964948d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18066611659935938d, y: 0.768674207083653d), new NpgsqlTypes.NpgsqlPoint(x: 0.1502465346468751d, y: 0.7602145224319091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026465643574016d, y: 0.4537617894801269d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5143940674312295d, y: 0.11733898085492034d), new NpgsqlTypes.NpgsqlPoint(x: 0.252812390580359d, y: 0.5715700831284948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032704164264642d, y: 0.3378225883056589d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03439245361357057d, y: 0.23351194775070572d), new NpgsqlTypes.NpgsqlPoint(x: 0.14880271337838846d, y: 0.08629887724086993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5733378022377759d, y: 0.726204061835806d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24302590672497237d, y: 0.5975836911611564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301837499912438d, y: 0.0002802919244051516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277236600924461d, y: 0.11044314901303143d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32675537310203995d, y: 0.2248160809124814d), new NpgsqlTypes.NpgsqlPoint(x: 0.6313478742243732d, y: 0.4353437689008962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7163745730411513d, y: 0.7585841735433122d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9824287749315539d, y: 0.5935073990110206d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168959275092575d, y: 0.26458488348610976d), new NpgsqlTypes.NpgsqlPoint(x: 0.1698571105821438d, y: 0.4855211904383161d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5120196591421666d, y: 0.4491708043481991d), new NpgsqlTypes.NpgsqlPoint(x: 0.9284767240477737d, y: 0.24942415081981284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255893890680413d, y: 0.8231101320402209d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6938902482319861d, y: 0.4520077349167342d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172056446925724d, y: 0.32873631803248093d), new NpgsqlTypes.NpgsqlPoint(x: 0.16066970011910764d, y: 0.7282747203802123d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2819858173354337d, y: 0.18947599658033332d), new NpgsqlTypes.NpgsqlPoint(x: 0.351714436941474d, y: 0.24018031740862456d), new NpgsqlTypes.NpgsqlPoint(x: 0.02707993171064116d, y: 0.8611262798323729d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6536933814927974d, y: 0.09294765559009899d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846026272911043d, y: 0.9212343454921655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792859571008314d, y: 0.8000287885025551d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2989142104940854d, y: 0.19233207594917368d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227949455576899d, y: 0.8445403446117589d), new NpgsqlTypes.NpgsqlPoint(x: 0.38041718235029776d, y: 0.13316031842149323d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29026774075211015d, y: 0.7624012857770948d), new NpgsqlTypes.NpgsqlPoint(x: 0.10919345123345447d, y: 0.7340028677451814d), new NpgsqlTypes.NpgsqlPoint(x: 0.3854392636888777d, y: 0.3713633022455175d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2774327000926635d, y: 0.2655063871786728d), new NpgsqlTypes.NpgsqlPoint(x: 0.06059294555833661d, y: 0.8069082643217995d), new NpgsqlTypes.NpgsqlPoint(x: 0.24482301281459518d, y: 0.34617654605151316d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3062940321336012d, y: 0.21173280509142367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7115137560585215d, y: 0.7009477829359634d), new NpgsqlTypes.NpgsqlPoint(x: 0.023869224266664157d, y: 0.6792305013394314d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3770554207641055d, y: 0.7894365362043887d), new NpgsqlTypes.NpgsqlPoint(x: 0.355469017044029d, y: 0.7009410961075432d), new NpgsqlTypes.NpgsqlPoint(x: 0.5141516134964754d, y: 0.8012419969893461d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23376002121709671d, y: 0.5742317243036872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291375013783725d, y: 0.7932578902850127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9684099369323466d, y: 0.43822602884986583d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1951525627050299d, y: 0.658351934798546d), new NpgsqlTypes.NpgsqlPoint(x: 0.1130321392257061d, y: 0.6534521171669252d), new NpgsqlTypes.NpgsqlPoint(x: 0.9931101446945739d, y: 0.8681859439604662d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47576406197997245d, y: 0.17171946868021626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6797879049727017d, y: 0.19850621514050837d), new NpgsqlTypes.NpgsqlPoint(x: 0.922074657700578d, y: 0.029785532468991516d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22113012630193563d, y: 0.3065245781220931d), new NpgsqlTypes.NpgsqlPoint(x: 0.397452005072358d, y: 0.8589313163650546d), new NpgsqlTypes.NpgsqlPoint(x: 0.41521957964208045d, y: 0.1615675576946487d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3236264668323392d, y: 0.15601850158229447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9480179504545654d, y: 0.2411637471247341d), new NpgsqlTypes.NpgsqlPoint(x: 0.967122172217707d, y: 0.9914444065204009d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12151229101781358d, y: 0.38118482139853815d), new NpgsqlTypes.NpgsqlPoint(x: 0.0342022939867479d, y: 0.9421729798277841d), new NpgsqlTypes.NpgsqlPoint(x: 0.5299072446785201d, y: 0.39149465372536163d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.963766291769422d, y: 0.42280406768340606d), new NpgsqlTypes.NpgsqlPoint(x: 0.13082013628429356d, y: 0.2711120307435615d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859802511685374d, y: 0.25004366670011424d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02468767367235203d, y: 0.7002625995140124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492245732608698d, y: 0.07189129822704143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503766402657961d, y: 0.642958523620737d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7070028047484044d, y: 0.16573800180544007d), new NpgsqlTypes.NpgsqlPoint(x: 0.29829200003846223d, y: 0.553744795307192d), new NpgsqlTypes.NpgsqlPoint(x: 0.4295367710187119d, y: 0.07443821387144078d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6422595551174183d, y: 0.800284411334509d), new NpgsqlTypes.NpgsqlPoint(x: 0.2515389162892686d, y: 0.7263694159402251d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807844962691691d, y: 0.27435498594219376d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1710303066830794d, y: 0.14999808195035247d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906140422549117d, y: 0.614302177732061d), new NpgsqlTypes.NpgsqlPoint(x: 0.3807930298181035d, y: 0.5393678680879622d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37705903682808806d, y: 0.22870000629955278d), new NpgsqlTypes.NpgsqlPoint(x: 0.42588269033879567d, y: 0.18715851512977644d), new NpgsqlTypes.NpgsqlPoint(x: 0.017554821089426853d, y: 0.8142269870746024d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6984130464151567d, y: 0.4741555355028203d), new NpgsqlTypes.NpgsqlPoint(x: 0.9983957397308761d, y: 0.8476244462785083d), new NpgsqlTypes.NpgsqlPoint(x: 0.588977156832916d, y: 0.6123138433049774d)))));

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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
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

