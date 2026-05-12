

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
    internal partial interface INpgsqlBoxMArrayboxMMArrayD1
    {
    }
    
    internal partial class NpgsqlBoxMArrayboxMMArrayD1 : INpgsqlBoxMArrayboxMMArrayD1
    {


#region TestData

        private readonly NpgsqlBoxboxMMArrayD1E1M[] _testData = new NpgsqlBoxboxMMArrayD1E1M[]
        {
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6513765444925906d,right: 0.24678078482137555d,bottom: 0.1502683266298942d,left: 0.05396562715843045d),
new NpgsqlTypes.NpgsqlBox(top: 0.6417696586548456d,right: 0.9354097585733d,bottom: 0.04827586379326143d,left: 0.7978372650102856d),
new NpgsqlTypes.NpgsqlBox(top: 0.726263425658658d,right: 0.9723557272835757d,bottom: 0.013041023176097566d,left: 0.24360108237611588d),
new NpgsqlTypes.NpgsqlBox(top: 0.6283071706471658d,right: 0.7634251151091264d,bottom: 0.3531821362686175d,left: 0.22421332258757543d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5659134240739444d,right: 0.7798555396226549d,bottom: 0.2199703445265776d,left: 0.2130200214877761d),
new NpgsqlTypes.NpgsqlBox(top: 0.9600807330243168d,right: 0.45102256976485766d,bottom: 0.029180297971352243d,left: 0.07953430044550425d),
new NpgsqlTypes.NpgsqlBox(top: 0.9869433137916752d,right: 0.40992829420763566d,bottom: 0.808537213868504d,left: 0.06841762665994566d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9306200318270483d,right: 0.6632579285234796d,bottom: 0.06844003914449337d,left: 0.34278461345168554d),
new NpgsqlTypes.NpgsqlBox(top: 0.8194071292548781d,right: 0.2694263661839402d,bottom: 0.24728846149278927d,left: 0.03318710080720588d),
new NpgsqlTypes.NpgsqlBox(top: 0.9624384560724656d,right: 0.23613807973524192d,bottom: 0.4235813700548574d,left: 0.2273587454591358d),
new NpgsqlTypes.NpgsqlBox(top: 0.7524063492407213d,right: 0.604531622678741d,bottom: 0.3152499785031827d,left: 0.5103950111523428d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4703727306245683d,right: 0.7543661817996609d,bottom: 0.03265229866151442d,left: 0.31355268347496057d),
new NpgsqlTypes.NpgsqlBox(top: 0.3847571018061996d,right: 0.5760346423232617d,bottom: 0.03209927830912407d,left: 0.5577573168777417d),
new NpgsqlTypes.NpgsqlBox(top: 0.7469821340153551d,right: 0.7561568412936256d,bottom: 0.380186803612084d,left: 0.2094462676670239d),
new NpgsqlTypes.NpgsqlBox(top: 0.8062879940190506d,right: 0.4717456308859773d,bottom: 0.7418188072112797d,left: 0.14768556995054338d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8555025534910549d,right: 0.47508924563566046d,bottom: 0.7352376251493902d,left: 0.05505087740774983d),
new NpgsqlTypes.NpgsqlBox(top: 0.9348520105997701d,right: 0.9036462672553794d,bottom: 0.5408762426120979d,left: 0.21152346877301964d),
new NpgsqlTypes.NpgsqlBox(top: 0.8885180671120456d,right: 0.676507401250224d,bottom: 0.5338581986582245d,left: 0.026279793365777127d),
new NpgsqlTypes.NpgsqlBox(top: 0.8034900456742823d,right: 0.8358692495978237d,bottom: 0.03263263423437879d,left: 0.3383625306073358d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7388391446898813d,right: 0.5739258069721396d,bottom: 0.5927385545054759d,left: 0.007440213035899923d),
new NpgsqlTypes.NpgsqlBox(top: 0.15791914263858486d,right: 0.9847060070570828d,bottom: 0.09010378677236452d,left: 0.8186109808980424d),
new NpgsqlTypes.NpgsqlBox(top: 0.8887916153697182d,right: 0.9430523601182463d,bottom: 0.6897938616237096d,left: 0.30154362900088294d),
new NpgsqlTypes.NpgsqlBox(top: 0.6752398114981779d,right: 0.561154805642632d,bottom: 0.656518429804906d,left: 0.03909939346142555d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8116686705788783d,right: 0.7519171880886995d,bottom: 0.3358956981431257d,left: 0.1769705445273021d),
new NpgsqlTypes.NpgsqlBox(top: 0.6429890970871045d,right: 0.7436300754574079d,bottom: 0.5738394694190659d,left: 0.355913159477097d),
new NpgsqlTypes.NpgsqlBox(top: 0.9935928595124579d,right: 0.415944430444129d,bottom: 0.2915300073622511d,left: 0.33336053491247464d),
new NpgsqlTypes.NpgsqlBox(top: 0.6108250076793234d,right: 0.947384185595444d,bottom: 0.010405730711158467d,left: 0.011173096492030687d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8903615100442408d,right: 0.9299467527104759d,bottom: 0.8648418944237131d,left: 0.37978441806271657d),
new NpgsqlTypes.NpgsqlBox(top: 0.6802082707314254d,right: 0.8021081264710265d,bottom: 0.1344244190666114d,left: 0.27432103692826826d),
new NpgsqlTypes.NpgsqlBox(top: 0.6383355901722494d,right: 0.8406687300311303d,bottom: 0.472522600549246d,left: 0.7530119828852286d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.16152063513361536d,right: 0.909902482827113d,bottom: 0.15638393818710483d,left: 0.3941484777217936d),
new NpgsqlTypes.NpgsqlBox(top: 0.6278529116458015d,right: 0.9901214585527711d,bottom: 0.26754837395253284d,left: 0.11073587250437422d),
new NpgsqlTypes.NpgsqlBox(top: 0.62936999247154d,right: 0.6450123669275633d,bottom: 0.611652968515243d,left: 0.1018496724554373d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5762798509662919d,right: 0.675965131200839d,bottom: 0.17307705724766909d,left: 0.6624855172591857d),
new NpgsqlTypes.NpgsqlBox(top: 0.5108881468429937d,right: 0.7264082167574014d,bottom: 0.26849314323583795d,left: 0.26401417017611883d),
new NpgsqlTypes.NpgsqlBox(top: 0.749669984351792d,right: 0.6515065241645028d,bottom: 0.48688648429220593d,left: 0.285194886258367d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7544276011360844d,right: 0.539037380339224d,bottom: 0.4171701631367416d,left: 0.002948524349606574d),
new NpgsqlTypes.NpgsqlBox(top: 0.34853906109095034d,right: 0.8317064579679593d,bottom: 0.31467543669549647d,left: 0.5236594876397835d),
new NpgsqlTypes.NpgsqlBox(top: 0.6286789327669786d,right: 0.9737207904643645d,bottom: 0.34033884808605086d,left: 0.5329766680682221d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8585657760730904d,right: 0.2812309779224429d,bottom: 0.24535423213500518d,left: 0.14012611254543583d),
new NpgsqlTypes.NpgsqlBox(top: 0.9946984670698253d,right: 0.6109184993977795d,bottom: 0.5590596883182998d,left: 0.36025299037356173d),
new NpgsqlTypes.NpgsqlBox(top: 0.6593575463785715d,right: 0.9798265055077086d,bottom: 0.6505428176675313d,left: 0.16217070091404373d),
new NpgsqlTypes.NpgsqlBox(top: 0.15972508672817032d,right: 0.7386383037847705d,bottom: 0.00801458729615967d,left: 0.6032057606766601d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8727207943266921d,right: 0.6709709227966424d,bottom: 0.27459260298140675d,left: 0.2836878574836721d),
new NpgsqlTypes.NpgsqlBox(top: 0.9276169709899337d,right: 0.9712609869333835d,bottom: 0.9035755626177291d,left: 0.5967508898696919d),
new NpgsqlTypes.NpgsqlBox(top: 0.4318957799389602d,right: 0.5512388684901073d,bottom: 0.26997410179160597d,left: 0.27838188413311493d),
new NpgsqlTypes.NpgsqlBox(top: 0.49801091720229773d,right: 0.8637300426316948d,bottom: 0.1008113398135998d,left: 0.7869347662558017d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9038924295586198d,right: 0.9436003293288324d,bottom: 0.04023882046779104d,left: 0.04501255426613293d),
new NpgsqlTypes.NpgsqlBox(top: 0.2578340445133056d,right: 0.7658349917727713d,bottom: 0.1584602856314924d,left: 0.14556950731108464d),
new NpgsqlTypes.NpgsqlBox(top: 0.38188509784807767d,right: 0.7642471198864927d,bottom: 0.27006084833309785d,left: 0.719944101098174d),
new NpgsqlTypes.NpgsqlBox(top: 0.6487999403148655d,right: 0.7053003133476462d,bottom: 0.4114320604570354d,left: 0.32763240729773d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.88996978979196d,right: 0.7160608237667149d,bottom: 0.5172972488449448d,left: 0.02425606447143991d),
new NpgsqlTypes.NpgsqlBox(top: 0.9500197617611421d,right: 0.7801864090316449d,bottom: 0.09003003254406883d,left: 0.19377012985942443d),
new NpgsqlTypes.NpgsqlBox(top: 0.9025947011397099d,right: 0.31144117911066505d,bottom: 0.766828728025756d,left: 0.30472468698868727d),
new NpgsqlTypes.NpgsqlBox(top: 0.5843863972436976d,right: 0.6445901677524701d,bottom: 0.22847015665988646d,left: 0.11306078077415527d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4518603403978406d,right: 0.6027882687349296d,bottom: 0.006790195510432362d,left: 0.058950842404802084d),
new NpgsqlTypes.NpgsqlBox(top: 0.27813684666598226d,right: 0.6923914200234766d,bottom: 0.029701392330609422d,left: 0.3066589204058854d),
new NpgsqlTypes.NpgsqlBox(top: 0.9525217153909205d,right: 0.8978473397140186d,bottom: 0.4340313649662614d,left: 0.4876724715809494d),
new NpgsqlTypes.NpgsqlBox(top: 0.42298877841024396d,right: 0.3863307826617287d,bottom: 0.16193330687441398d,left: 0.02294590790962514d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7574954304585635d,right: 0.5360238910429668d,bottom: 0.19712830423490413d,left: 0.40503183932669373d),
new NpgsqlTypes.NpgsqlBox(top: 0.9217910196048824d,right: 0.26747168589918247d,bottom: 0.7959180955886622d,left: 0.08486977618096903d),
new NpgsqlTypes.NpgsqlBox(top: 0.7829664996284672d,right: 0.239729401497508d,bottom: 0.42782538794408376d,left: 0.13525150030029076d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8819302900353917d,right: 0.9421533497147526d,bottom: 0.20895470208607125d,left: 0.5993738645181107d),
new NpgsqlTypes.NpgsqlBox(top: 0.23061853795894416d,right: 0.3045373930250109d,bottom: 0.1441171668854394d,left: 0.09899474007217945d),
new NpgsqlTypes.NpgsqlBox(top: 0.8024645183016592d,right: 0.9296334540149669d,bottom: 0.33274439294089275d,left: 0.18249115407918404d),
new NpgsqlTypes.NpgsqlBox(top: 0.5412086392282043d,right: 0.969553217000824d,bottom: 0.2395400870728449d,left: 0.3545405874913191d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7375752466338465d,right: 0.11449752015634085d,bottom: 0.2595473682790045d,left: 0.11333498309617451d),
new NpgsqlTypes.NpgsqlBox(top: 0.4201086680268996d,right: 0.9257110488346155d,bottom: 0.17337580143780418d,left: 0.09507278134772112d),
new NpgsqlTypes.NpgsqlBox(top: 0.8035107695823445d,right: 0.6945340952577407d,bottom: 0.006381733230842901d,left: 0.09373368692077177d),
new NpgsqlTypes.NpgsqlBox(top: 0.35980138830195085d,right: 0.4548022219522839d,bottom: 0.23073050435648024d,left: 0.3189773952816546d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33946172918325135d,right: 0.5549027248562913d,bottom: 0.3000974546088898d,left: 0.018316392156858763d),
new NpgsqlTypes.NpgsqlBox(top: 0.4163467268894788d,right: 0.5890150026594488d,bottom: 0.11392274819413495d,left: 0.49382100468626167d),
new NpgsqlTypes.NpgsqlBox(top: 0.5655488157484788d,right: 0.6234669076086927d,bottom: 0.30715572883748665d,left: 0.5294716188989501d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7049743678039019d,right: 0.8249939307861683d,bottom: 0.21471222450904603d,left: 0.7496688137673518d),
new NpgsqlTypes.NpgsqlBox(top: 0.7020367106794363d,right: 0.5085496106368274d,bottom: 0.2722740882571486d,left: 0.15921956190852649d),
new NpgsqlTypes.NpgsqlBox(top: 0.7603501042555989d,right: 0.705621180282738d,bottom: 0.07875394253412937d,left: 0.03222408125633769d),
new NpgsqlTypes.NpgsqlBox(top: 0.6249762402501899d,right: 0.5381010632216764d,bottom: 0.4457700610158887d,left: 0.0721532522945123d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7890959585807521d,right: 0.9541220591675542d,bottom: 0.678542931343924d,left: 0.2849443869260262d),
new NpgsqlTypes.NpgsqlBox(top: 0.5233697800760656d,right: 0.9070782130924814d,bottom: 0.08639533693636559d,left: 0.6368043056511843d),
new NpgsqlTypes.NpgsqlBox(top: 0.4342732071976977d,right: 0.8942073918237843d,bottom: 0.2825073138653835d,left: 0.2765295120795671d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2270131082533875d,right: 0.8263765187984375d,bottom: 0.025798853202167793d,left: 0.749029791819656d),
new NpgsqlTypes.NpgsqlBox(top: 0.8978322377882617d,right: 0.9922800008338731d,bottom: 0.6106485506653759d,left: 0.4665840097594689d),
new NpgsqlTypes.NpgsqlBox(top: 0.675453451340436d,right: 0.934725824614385d,bottom: 0.006666141514983681d,left: 0.6970651088803003d),
new NpgsqlTypes.NpgsqlBox(top: 0.6892929862724657d,right: 0.3122250449724935d,bottom: 0.26922415395865995d,left: 0.010378720548119058d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6104470538895079d,right: 0.7056996021302525d,bottom: 0.515058408878154d,left: 0.3651533036538792d),
new NpgsqlTypes.NpgsqlBox(top: 0.8230587560986776d,right: 0.5124275712155534d,bottom: 0.22484163858341677d,left: 0.09719241241958088d),
new NpgsqlTypes.NpgsqlBox(top: 0.2975628873849331d,right: 0.7204791692573166d,bottom: 0.23246835260741738d,left: 0.3309668074651203d),
new NpgsqlTypes.NpgsqlBox(top: 0.600444772963835d,right: 0.21967797280441637d,bottom: 0.4019392125962171d,left: 0.05747381088325976d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5489303950579131d,right: 0.9698894171775913d,bottom: 0.37412748903230364d,left: 0.21494427242666114d),
new NpgsqlTypes.NpgsqlBox(top: 0.7379801961410327d,right: 0.9804061362881668d,bottom: 0.4212924246819556d,left: 0.13886119613883452d),
new NpgsqlTypes.NpgsqlBox(top: 0.5085203084377462d,right: 0.482565861695624d,bottom: 0.3023581362487727d,left: 0.42523135797616485d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6585543659802708d,right: 0.4722465063934189d,bottom: 0.41245029709396874d,left: 0.429947818859317d),
new NpgsqlTypes.NpgsqlBox(top: 0.4711333643017247d,right: 0.8935269439424602d,bottom: 0.11650073339450007d,left: 0.6554239811105845d),
new NpgsqlTypes.NpgsqlBox(top: 0.8462317664575452d,right: 0.746712371093753d,bottom: 0.722328274219064d,left: 0.016109850179239937d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6529222349602097d,right: 0.7888025541669512d,bottom: 0.5408297666058826d,left: 0.5068156192251809d),
new NpgsqlTypes.NpgsqlBox(top: 0.7345939446360594d,right: 0.9065817316905942d,bottom: 0.3924196513948611d,left: 0.8459687857241677d),
new NpgsqlTypes.NpgsqlBox(top: 0.6171419059832352d,right: 0.7755147461761643d,bottom: 0.5044721363775323d,left: 0.5192148638895558d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6477238978880124d,right: 0.9160961226814837d,bottom: 0.2080448089229644d,left: 0.04785740756533485d),
new NpgsqlTypes.NpgsqlBox(top: 0.8011326925945133d,right: 0.7176312318752239d,bottom: 0.5032898310541628d,left: 0.5740489546376039d),
new NpgsqlTypes.NpgsqlBox(top: 0.7991139995662025d,right: 0.31264904584909237d,bottom: 0.6212366508172706d,left: 0.08246985048636368d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8201089889452129d,right: 0.2590621878523661d,bottom: 0.26410775852489565d,left: 0.2539852164516372d),
new NpgsqlTypes.NpgsqlBox(top: 0.8430017479959153d,right: 0.6532916683532182d,bottom: 0.595237409410368d,left: 0.1313674585209461d),
new NpgsqlTypes.NpgsqlBox(top: 0.47812487863590836d,right: 0.3971544767993588d,bottom: 0.1939220946568635d,left: 0.035714548560713655d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9957546969590497d,right: 0.9077771865447549d,bottom: 0.14633826331231303d,left: 0.2893307540191219d),
new NpgsqlTypes.NpgsqlBox(top: 0.15115890131312926d,right: 0.6356084782325572d,bottom: 0.14018145127804693d,left: 0.5616093064073554d),
new NpgsqlTypes.NpgsqlBox(top: 0.963106687419863d,right: 0.42086674186727235d,bottom: 0.7480934807017547d,left: 0.2801681233558283d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9554377330988403d,right: 0.5090081525341767d,bottom: 0.5515384172781238d,left: 0.21695763516676525d),
new NpgsqlTypes.NpgsqlBox(top: 0.9780288902772657d,right: 0.2132670316943942d,bottom: 0.4588214160129884d,left: 0.03248255248425902d),
new NpgsqlTypes.NpgsqlBox(top: 0.9623142343608091d,right: 0.5619723540470047d,bottom: 0.806126133970769d,left: 0.25477825361287854d),
new NpgsqlTypes.NpgsqlBox(top: 0.7086739359941288d,right: 0.5088644182749034d,bottom: 0.05384668046182661d,left: 0.24320017105493574d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.32028334472074416d,right: 0.3924125375072235d,bottom: 0.09336841676000929d,left: 0.16365446118026883d),
new NpgsqlTypes.NpgsqlBox(top: 0.9165657156812714d,right: 0.7827823485779748d,bottom: 0.6826894227675646d,left: 0.7403336157353219d),
new NpgsqlTypes.NpgsqlBox(top: 0.1715695511227019d,right: 0.5869957726461462d,bottom: 0.1311764451474915d,left: 0.03742390547911689d),
new NpgsqlTypes.NpgsqlBox(top: 0.8511709539973017d,right: 0.7249801556603658d,bottom: 0.45905110154678974d,left: 0.3523911739448692d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4832859243297615d,right: 0.7984909661668549d,bottom: 0.38779114898895206d,left: 0.5662094216853516d),
new NpgsqlTypes.NpgsqlBox(top: 0.7721963067080849d,right: 0.4042196349625221d,bottom: 0.3487317059025131d,left: 0.0819422817164227d),
new NpgsqlTypes.NpgsqlBox(top: 0.8801865658888043d,right: 0.8475145379040182d,bottom: 0.7994995800482619d,left: 0.7519017718278841d),
new NpgsqlTypes.NpgsqlBox(top: 0.9526702826273902d,right: 0.5652989640408811d,bottom: 0.8043822577962d,left: 0.07335369433186012d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5715279502716665d,right: 0.5895862603492493d,bottom: 0.18834343930302366d,left: 0.2216410144936356d),
new NpgsqlTypes.NpgsqlBox(top: 0.6567613573317449d,right: 0.9954095661194892d,bottom: 0.4820204302778722d,left: 0.9186064949099694d),
new NpgsqlTypes.NpgsqlBox(top: 0.5607385661190164d,right: 0.7033121322304072d,bottom: 0.020153904338671702d,left: 0.399263449280736d),
new NpgsqlTypes.NpgsqlBox(top: 0.6136213428183216d,right: 0.48784453844267395d,bottom: 0.16859424485035968d,left: 0.1909141595627838d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.738211662190172d,right: 0.2881877571235657d,bottom: 0.04715641209024679d,left: 0.18193307175607565d),
new NpgsqlTypes.NpgsqlBox(top: 0.7444781003688835d,right: 0.8864983590159172d,bottom: 0.6453939653299139d,left: 0.10270945592350655d),
new NpgsqlTypes.NpgsqlBox(top: 0.7802261480907073d,right: 0.6869978947995259d,bottom: 0.38173887361996584d,left: 0.5903721124150237d),
new NpgsqlTypes.NpgsqlBox(top: 0.17870723976085057d,right: 0.9222930844140562d,bottom: 0.10796021945655632d,left: 0.2638553387116578d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7927250073127788d,right: 0.8080593586537503d,bottom: 0.07350083793114803d,left: 0.3068006290585569d),
new NpgsqlTypes.NpgsqlBox(top: 0.88005022026729d,right: 0.7060799120179191d,bottom: 0.09789417262557865d,left: 0.4520107339572075d),
new NpgsqlTypes.NpgsqlBox(top: 0.6972219357454665d,right: 0.9836090946459464d,bottom: 0.32231389424036827d,left: 0.7473863974979061d),
new NpgsqlTypes.NpgsqlBox(top: 0.8043622012632925d,right: 0.33710832076850494d,bottom: 0.3879331527170198d,left: 0.24641568400254277d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5963160602375921d,right: 0.6459368896450373d,bottom: 0.09229445976389772d,left: 0.5595898705094566d),
new NpgsqlTypes.NpgsqlBox(top: 0.8073998127284394d,right: 0.47302876683377504d,bottom: 0.4931359766020723d,left: 0.014210373985601876d),
new NpgsqlTypes.NpgsqlBox(top: 0.5853673284686821d,right: 0.5915884160416993d,bottom: 0.5275084515926607d,left: 0.45536738015310907d),
new NpgsqlTypes.NpgsqlBox(top: 0.6284520109736942d,right: 0.9453072738370454d,bottom: 0.2863819528748225d,left: 0.028188405373905545d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7460456536090115d,right: 0.6842234377125866d,bottom: 0.5487783130690976d,left: 0.24875648349215618d),
new NpgsqlTypes.NpgsqlBox(top: 0.8233909836672021d,right: 0.5035187899609836d,bottom: 0.6834860884185212d,left: 0.07168541423948704d),
new NpgsqlTypes.NpgsqlBox(top: 0.42675740391902306d,right: 0.20152237007463092d,bottom: 0.024096949626184028d,left: 0.0588297723843082d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9528955632800505d,right: 0.7049678914500048d,bottom: 0.3933834058020643d,left: 0.16106290747570762d),
new NpgsqlTypes.NpgsqlBox(top: 0.3480904953824936d,right: 0.861906606086655d,bottom: 0.0598028820780252d,left: 0.4762645707971275d),
new NpgsqlTypes.NpgsqlBox(top: 0.44092838178134786d,right: 0.666035270051733d,bottom: 0.39301038615923445d,left: 0.2760184686958914d),
new NpgsqlTypes.NpgsqlBox(top: 0.43835841163667477d,right: 0.6295069223628351d,bottom: 0.19709579639250108d,left: 0.24789886845041764d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.827287335371022d,right: 0.5785508734357868d,bottom: 0.3140558790999577d,left: 0.16046265130282455d),
new NpgsqlTypes.NpgsqlBox(top: 0.12574378215394533d,right: 0.6209008476771433d,bottom: 0.07851792011081005d,left: 0.4794990455788659d),
new NpgsqlTypes.NpgsqlBox(top: 0.9993407340974655d,right: 0.786568028215401d,bottom: 0.43179841262829255d,left: 0.6743317219528407d),
new NpgsqlTypes.NpgsqlBox(top: 0.9369554246883136d,right: 0.5708342461527004d,bottom: 0.6656992415772833d,left: 0.013911852263734037d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49914379364425643d,right: 0.996247835931957d,bottom: 0.46430273400272815d,left: 0.3980311747539832d),
new NpgsqlTypes.NpgsqlBox(top: 0.9496245653876184d,right: 0.9629542604900717d,bottom: 0.14296596550871055d,left: 0.1725208264385394d),
new NpgsqlTypes.NpgsqlBox(top: 0.5427252876717271d,right: 0.9136408901512182d,bottom: 0.10579194932073266d,left: 0.009700759467033304d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7479416508148719d,right: 0.8557882258324943d,bottom: 0.5657973203966817d,left: 0.4487670464679744d),
new NpgsqlTypes.NpgsqlBox(top: 0.38009923448383187d,right: 0.8074117078839605d,bottom: 0.21623912366756792d,left: 0.37219319149371877d),
new NpgsqlTypes.NpgsqlBox(top: 0.9917462618080926d,right: 0.12551255027005292d,bottom: 0.7489339562818139d,left: 0.11522041535646887d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8931328654690811d,right: 0.9781715786934184d,bottom: 0.504772916068255d,left: 0.022830169950911583d),
new NpgsqlTypes.NpgsqlBox(top: 0.7249692102845016d,right: 0.9315256198799827d,bottom: 0.34064795743604204d,left: 0.543608972434173d),
new NpgsqlTypes.NpgsqlBox(top: 0.8438761755626882d,right: 0.8362208029367096d,bottom: 0.3097713151682422d,left: 0.17709150941412732d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6216936344786613d,right: 0.7404162807657075d,bottom: 0.6005274431278184d,left: 0.28086510128954656d),
new NpgsqlTypes.NpgsqlBox(top: 0.8387605899867319d,right: 0.8346831074976604d,bottom: 0.6733450098813698d,left: 0.7070922808652209d),
new NpgsqlTypes.NpgsqlBox(top: 0.9003987942472373d,right: 0.9053520028397212d,bottom: 0.539224324270116d,left: 0.33437978656383494d),
new NpgsqlTypes.NpgsqlBox(top: 0.25444101156015286d,right: 0.5168735708184395d,bottom: 0.006071490866503049d,left: 0.12770910834790417d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8302153042282524d,right: 0.8871248583484591d,bottom: 0.01749317181529897d,left: 0.8616753199115353d),
new NpgsqlTypes.NpgsqlBox(top: 0.3852374964021743d,right: 0.9510611701770658d,bottom: 0.15337133893139365d,left: 0.030607580520296218d),
new NpgsqlTypes.NpgsqlBox(top: 0.19352891847004927d,right: 0.5247852464166832d,bottom: 0.10246421223560631d,left: 0.22657392398456033d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9736432751285117d,right: 0.6899446310071135d,bottom: 0.8852848946018346d,left: 0.6291521319008233d),
new NpgsqlTypes.NpgsqlBox(top: 0.69584880805089d,right: 0.2561114132468236d,bottom: 0.43045934294421506d,left: 0.13441516842926537d),
new NpgsqlTypes.NpgsqlBox(top: 0.5238951909427096d,right: 0.7178804458543036d,bottom: 0.12757544687628497d,left: 0.6697925195822578d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6130730921796077d,right: 0.5473164789058798d,bottom: 0.14065074798026334d,left: 0.48157498426373035d),
new NpgsqlTypes.NpgsqlBox(top: 0.9091192765476176d,right: 0.9029231566685305d,bottom: 0.7046813848581921d,left: 0.6775592272071294d),
new NpgsqlTypes.NpgsqlBox(top: 0.4253860966323555d,right: 0.607230862067946d,bottom: 0.21155539001847057d,left: 0.5365014989295669d),
new NpgsqlTypes.NpgsqlBox(top: 0.7949472734705387d,right: 0.6732919587216051d,bottom: 0.5688704338105595d,left: 0.6068166745984686d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9712049671344626d,right: 0.4212676267116189d,bottom: 0.41817669806094127d,left: 0.11326332342059231d),
new NpgsqlTypes.NpgsqlBox(top: 0.34821256833945335d,right: 0.9573964369164104d,bottom: 0.33355175957293637d,left: 0.143104900203592d),
new NpgsqlTypes.NpgsqlBox(top: 0.43586032177660594d,right: 0.3405577524082498d,bottom: 0.20860680260507025d,left: 0.13365673891547936d),
new NpgsqlTypes.NpgsqlBox(top: 0.602465528950445d,right: 0.18878176543226555d,bottom: 0.3102683817378755d,left: 0.09520167097181398d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7977679524328359d,right: 0.7966818529225793d,bottom: 0.0012585665936530877d,left: 0.18285907990514272d),
new NpgsqlTypes.NpgsqlBox(top: 0.7109322209407863d,right: 0.9060021089171804d,bottom: 0.16373420630172741d,left: 0.22820720448715115d),
new NpgsqlTypes.NpgsqlBox(top: 0.7088975106360744d,right: 0.2635918514080351d,bottom: 0.3440661785682424d,left: 0.16675200053207617d),
new NpgsqlTypes.NpgsqlBox(top: 0.2625543994981072d,right: 0.9335367589486654d,bottom: 0.1170432125122125d,left: 0.042563157026466736d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8113983059351426d,right: 0.5302738628869063d,bottom: 0.27753197371721605d,left: 0.3079392576890754d),
new NpgsqlTypes.NpgsqlBox(top: 0.6086877709579155d,right: 0.9950369575655147d,bottom: 0.5181664781157878d,left: 0.36843949250953323d),
new NpgsqlTypes.NpgsqlBox(top: 0.9695038369962884d,right: 0.452968285659306d,bottom: 0.49171291986838517d,left: 0.39063315242665675d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.936922590212945d,right: 0.6265695153626176d,bottom: 0.13531376805202167d,left: 0.5456349616122461d),
new NpgsqlTypes.NpgsqlBox(top: 0.3203660854021678d,right: 0.24631174403255862d,bottom: 0.17737305322138586d,left: 0.22809151788108173d),
new NpgsqlTypes.NpgsqlBox(top: 0.8505015381381308d,right: 0.638152171164029d,bottom: 0.23105409257988363d,left: 0.3914235104347987d),
new NpgsqlTypes.NpgsqlBox(top: 0.3793623095142731d,right: 0.4521113478293045d,bottom: 0.2961234158101598d,left: 0.2626541212071809d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7840473327637072d,right: 0.6401544907011398d,bottom: 0.16161234979132177d,left: 0.037164973332343476d),
new NpgsqlTypes.NpgsqlBox(top: 0.9426977279255769d,right: 0.9919200296082434d,bottom: 0.6699743867728954d,left: 0.40911332572584536d),
new NpgsqlTypes.NpgsqlBox(top: 0.5081478996583939d,right: 0.2797602636992408d,bottom: 0.29523089223946464d,left: 0.019411691693280497d),
new NpgsqlTypes.NpgsqlBox(top: 0.46877640790799546d,right: 0.9247468434194255d,bottom: 0.07175046833071475d,left: 0.31476711169800964d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6288168102001791d,right: 0.9419293566233498d,bottom: 0.0995158178612724d,left: 0.4622476850977977d),
new NpgsqlTypes.NpgsqlBox(top: 0.7426525418159036d,right: 0.43325601541113146d,bottom: 0.14661626154063956d,left: 0.11679715403853608d),
new NpgsqlTypes.NpgsqlBox(top: 0.9277480738359846d,right: 0.48898898606247077d,bottom: 0.8668347620451996d,left: 0.3946234668553016d),
new NpgsqlTypes.NpgsqlBox(top: 0.6188280206620032d,right: 0.4975264703325125d,bottom: 0.26878508416251135d,left: 0.048333471144624385d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.30135140803427685d,right: 0.5410298347558575d,bottom: 0.04089404338206415d,left: 0.016059768320449863d),
new NpgsqlTypes.NpgsqlBox(top: 0.35661689240679506d,right: 0.565006014953489d,bottom: 0.14797018080350832d,left: 0.36982682961845514d),
new NpgsqlTypes.NpgsqlBox(top: 0.9255578754267714d,right: 0.9091082216909262d,bottom: 0.3084930103178182d,left: 0.48266853864629744d),
new NpgsqlTypes.NpgsqlBox(top: 0.7238664341341455d,right: 0.3502686190912637d,bottom: 0.06022340621300992d,left: 0.214373111892331d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.84337563112879d,right: 0.39450098935276334d,bottom: 0.5320636440832199d,left: 0.008142699193310343d),
new NpgsqlTypes.NpgsqlBox(top: 0.2705664763046203d,right: 0.7258473179852576d,bottom: 0.22265203331765193d,left: 0.10992669241527242d),
new NpgsqlTypes.NpgsqlBox(top: 0.2746467635713098d,right: 0.907427377496534d,bottom: 0.009068883158591778d,left: 0.35410513553519274d),
new NpgsqlTypes.NpgsqlBox(top: 0.9684298743637444d,right: 0.9549276998309186d,bottom: 0.13572540631711072d,left: 0.3328168096767433d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9761237902516688d,right: 0.9819757630347961d,bottom: 0.6378441187796919d,left: 0.20604970480866425d),
new NpgsqlTypes.NpgsqlBox(top: 0.7889127200986126d,right: 0.5751876587058017d,bottom: 0.46796358176179664d,left: 0.1323076472531911d),
new NpgsqlTypes.NpgsqlBox(top: 0.5633669313618812d,right: 0.45453330724122876d,bottom: 0.31996933908246006d,left: 0.4482003664427575d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6341974673929667d,right: 0.45365379129474903d,bottom: 0.32378354933144704d,left: 0.06076381544209919d),
new NpgsqlTypes.NpgsqlBox(top: 0.49955350347042904d,right: 0.5692445746942948d,bottom: 0.16777671044949038d,left: 0.11608349200511048d),
new NpgsqlTypes.NpgsqlBox(top: 0.8826318426779586d,right: 0.9727994023814044d,bottom: 0.8218636190657916d,left: 0.1503858443753172d),
new NpgsqlTypes.NpgsqlBox(top: 0.6983888659260757d,right: 0.836600803704597d,bottom: 0.5669590143667785d,left: 0.1399927379872321d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.41418576272360386d,right: 0.800190639847335d,bottom: 0.32859930465063747d,left: 0.5642123745369897d),
new NpgsqlTypes.NpgsqlBox(top: 0.8250618090636825d,right: 0.8824485432573537d,bottom: 0.0009196463735222649d,left: 0.4955534452280166d),
new NpgsqlTypes.NpgsqlBox(top: 0.9448121674689877d,right: 0.5078788897713618d,bottom: 0.13253176988937287d,left: 0.49832163499413173d),
new NpgsqlTypes.NpgsqlBox(top: 0.8203428084329629d,right: 0.5999881839928588d,bottom: 0.4012997523081103d,left: 0.5054459190134344d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.939884507963979d,right: 0.641937108015303d,bottom: 0.644965182192973d,left: 0.5778020788942345d),
new NpgsqlTypes.NpgsqlBox(top: 0.9862403709285325d,right: 0.9361411022806901d,bottom: 0.4625164830170171d,left: 0.21800677148875036d),
new NpgsqlTypes.NpgsqlBox(top: 0.4972372256943479d,right: 0.4219492914775044d,bottom: 0.21840977545732077d,left: 0.31320289947803615d),
new NpgsqlTypes.NpgsqlBox(top: 0.9732060580116839d,right: 0.9641946474976846d,bottom: 0.4543457666833044d,left: 0.3247322742169534d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6645891032711886d,right: 0.7849887461391034d,bottom: 0.23803691042595765d,left: 0.03546413662198866d),
new NpgsqlTypes.NpgsqlBox(top: 0.43386296580399064d,right: 0.9475199440197588d,bottom: 0.3570294996751412d,left: 0.5351263571663836d),
new NpgsqlTypes.NpgsqlBox(top: 0.859491039530222d,right: 0.7043784694891195d,bottom: 0.162956832854399d,left: 0.5398602611110797d),
new NpgsqlTypes.NpgsqlBox(top: 0.6462133260129851d,right: 0.43506788011165964d,bottom: 0.6360004681478655d,left: 0.298421843197351d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6747917462402457d,right: 0.3489565161071646d,bottom: 0.35192294713285266d,left: 0.020249356203108193d),
new NpgsqlTypes.NpgsqlBox(top: 0.5700980307323635d,right: 0.8105678925769773d,bottom: 0.18830449705438546d,left: 0.08312967329352905d),
new NpgsqlTypes.NpgsqlBox(top: 0.6541171215784931d,right: 0.9855068475149447d,bottom: 0.3628532606631184d,left: 0.4111965185528298d),
new NpgsqlTypes.NpgsqlBox(top: 0.7706277667897877d,right: 0.5793674105976344d,bottom: 0.15590884994551224d,left: 0.4787613929668272d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5905733245706346d,right: 0.7993703424442378d,bottom: 0.5078661944691767d,left: 0.2232345621813281d),
new NpgsqlTypes.NpgsqlBox(top: 0.599383332216142d,right: 0.718677289792774d,bottom: 0.4890645270207531d,left: 0.008952580786096287d),
new NpgsqlTypes.NpgsqlBox(top: 0.49917076257627546d,right: 0.5935935668310472d,bottom: 0.34207178824448725d,left: 0.5394354679364713d),
new NpgsqlTypes.NpgsqlBox(top: 0.3299287429767357d,right: 0.343628049878718d,bottom: 0.2071344563173203d,left: 0.09694868569146164d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8319179402606129d,right: 0.10097503644927197d,bottom: 0.5225701673109376d,left: 0.017771413115602486d),
new NpgsqlTypes.NpgsqlBox(top: 0.6511114456836042d,right: 0.31138676521799347d,bottom: 0.008331322890398951d,left: 0.23262444945973548d),
new NpgsqlTypes.NpgsqlBox(top: 0.6305363254667853d,right: 0.9700429119055368d,bottom: 0.06934307354567637d,left: 0.8263413255703806d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4937256683219319d,right: 0.5523465292719478d,bottom: 0.46824870614924696d,left: 0.0940318010162603d),
new NpgsqlTypes.NpgsqlBox(top: 0.88062279782346d,right: 0.9181110908589684d,bottom: 0.5541086259803119d,left: 0.60569010536302d),
new NpgsqlTypes.NpgsqlBox(top: 0.9962963315365331d,right: 0.9708244085653455d,bottom: 0.174016678526145d,left: 0.8205648201749601d),
new NpgsqlTypes.NpgsqlBox(top: 0.711645620389103d,right: 0.9034362604865824d,bottom: 0.12173100479376353d,left: 0.4163628234493899d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9141237226108206d,right: 0.9885257197155009d,bottom: 0.735618118226875d,left: 0.0794986603258111d),
new NpgsqlTypes.NpgsqlBox(top: 0.7570760954560201d,right: 0.9206743589514025d,bottom: 0.20941523749268742d,left: 0.19845892412977795d),
new NpgsqlTypes.NpgsqlBox(top: 0.858594717851421d,right: 0.6163208416139864d,bottom: 0.1848505736236974d,left: 0.4289120062024975d),
new NpgsqlTypes.NpgsqlBox(top: 0.658464353297515d,right: 0.5858453300807667d,bottom: 0.18645132904076755d,left: 0.40216262195013885d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.34538859411088385d,right: 0.9078655912978101d,bottom: 0.08692802695496749d,left: 0.6875850357053741d),
new NpgsqlTypes.NpgsqlBox(top: 0.9193068143352616d,right: 0.7478330928475343d,bottom: 0.05677423175938301d,left: 0.12163332739901345d),
new NpgsqlTypes.NpgsqlBox(top: 0.7949176414570267d,right: 0.22037032368217113d,bottom: 0.17237479773124886d,left: 0.15675101152150417d),
new NpgsqlTypes.NpgsqlBox(top: 0.9538062964038023d,right: 0.6483095356210489d,bottom: 0.08257733940682876d,left: 0.004568911090560901d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7799123113247284d,right: 0.5333507992285976d,bottom: 0.5857087233475756d,left: 0.4480006771238544d),
new NpgsqlTypes.NpgsqlBox(top: 0.6811608014849636d,right: 0.9551429542765681d,bottom: 0.1081014654469048d,left: 0.5039515128306522d),
new NpgsqlTypes.NpgsqlBox(top: 0.890051934306264d,right: 0.9515382183055804d,bottom: 0.28028500028537795d,left: 0.9137103786767506d),
new NpgsqlTypes.NpgsqlBox(top: 0.5144722443077612d,right: 0.8893752422823825d,bottom: 0.46552637633231586d,left: 0.726253452825739d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5251103453751773d,right: 0.42012963509726275d,bottom: 0.029601991906721525d,left: 0.36350076359982864d),
new NpgsqlTypes.NpgsqlBox(top: 0.8852409508803056d,right: 0.460410510738808d,bottom: 0.7632035051188378d,left: 0.29807482912648486d),
new NpgsqlTypes.NpgsqlBox(top: 0.8270508580749477d,right: 0.48160440947462124d,bottom: 0.6506189626238644d,left: 0.09333680089081331d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4268743953051315d,right: 0.7434174388729234d,bottom: 0.2330645636653892d,left: 0.5890087435530511d),
new NpgsqlTypes.NpgsqlBox(top: 0.7416205436007555d,right: 0.7356066682691477d,bottom: 0.2899191083945285d,left: 0.021736407359837395d),
new NpgsqlTypes.NpgsqlBox(top: 0.26275549567470047d,right: 0.5869329624367009d,bottom: 0.16033200499675215d,left: 0.019425274620596622d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6991063393756476d,right: 0.9497195389517926d,bottom: 0.42621200189085373d,left: 0.3506295304747493d),
new NpgsqlTypes.NpgsqlBox(top: 0.605568977218202d,right: 0.7744853196744003d,bottom: 0.21760138385102834d,left: 0.0971440458430487d),
new NpgsqlTypes.NpgsqlBox(top: 0.8289052785845682d,right: 0.9005026182207103d,bottom: 0.73027562476196d,left: 0.08755573145112594d),
},
    ModelInner = new NpgsqlBoxboxMMArrayD1E1MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.19170722341897184d,right: 0.8353727458547803d,bottom: 0.18563384009389539d,left: 0.6895740233986349d),
new NpgsqlTypes.NpgsqlBox(top: 0.4210705852593476d,right: 0.8967505195267079d,bottom: 0.325236585486838d,left: 0.49832812239236735d),
new NpgsqlTypes.NpgsqlBox(top: 0.3158497210237883d,right: 0.9141658009144893d,bottom: 0.3085119146488505d,left: 0.2692448596700383d),
new NpgsqlTypes.NpgsqlBox(top: 0.3391467654393733d,right: 0.6729994387426269d,bottom: 0.05606793796457532d,left: 0.310611157266627d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5524538718919533d,right: 0.47733704280608436d,bottom: 0.38114642038011304d,left: 0.11884542940886111d),
new NpgsqlTypes.NpgsqlBox(top: 0.7110085571219616d,right: 0.812480589641975d,bottom: 0.012935569912596923d,left: 0.6767772178187825d),
new NpgsqlTypes.NpgsqlBox(top: 0.8808335023971127d,right: 0.9563527277613968d,bottom: 0.5133145538217759d,left: 0.06020499460460016d),
new NpgsqlTypes.NpgsqlBox(top: 0.7459991820939248d,right: 0.734502195634324d,bottom: 0.31957246296983277d,left: 0.5264620487197015d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9624259300787419d,right: 0.6707543751809711d,bottom: 0.8546075899739091d,left: 0.5751312201090077d),
new NpgsqlTypes.NpgsqlBox(top: 0.6331779477730815d,right: 0.8327786654626013d,bottom: 0.48854542639748066d,left: 0.28149340095905895d),
new NpgsqlTypes.NpgsqlBox(top: 0.5366035246053882d,right: 0.5287415322713622d,bottom: 0.11031414305783616d,left: 0.046478569230600786d),
new NpgsqlTypes.NpgsqlBox(top: 0.8651074973222734d,right: 0.13701462102475936d,bottom: 0.7409596203520953d,left: 0.012524601216965858d),
},
},
            new NpgsqlBoxboxMMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9153734611078468d,right: 0.5382132651138452d,bottom: 0.3548436747925302d,left: 0.05931230307093194d),
new NpgsqlTypes.NpgsqlBox(top: 0.9689499846110331d,right: 0.9745396784905647d,bottom: 0.18651611003391255d,left: 0.6979837628622749d),
new NpgsqlTypes.NpgsqlBox(top: 0.9747691780749358d,right: 0.8196991863996494d,bottom: 0.6145459655016404d,left: 0.07130094344292937d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
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

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8585657760730904d,right: 0.2812309779224429d,bottom: 0.24535423213500518d,left: 0.14012611254543583d),
new NpgsqlTypes.NpgsqlBox(top: 0.9946984670698253d,right: 0.6109184993977795d,bottom: 0.5590596883182998d,left: 0.36025299037356173d),
new NpgsqlTypes.NpgsqlBox(top: 0.6593575463785715d,right: 0.9798265055077086d,bottom: 0.6505428176675313d,left: 0.16217070091404373d),
new NpgsqlTypes.NpgsqlBox(top: 0.15972508672817032d,right: 0.7386383037847705d,bottom: 0.00801458729615967d,left: 0.6032057606766601d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9038924295586198d,right: 0.9436003293288324d,bottom: 0.04023882046779104d,left: 0.04501255426613293d),
new NpgsqlTypes.NpgsqlBox(top: 0.2578340445133056d,right: 0.7658349917727713d,bottom: 0.1584602856314924d,left: 0.14556950731108464d),
new NpgsqlTypes.NpgsqlBox(top: 0.38188509784807767d,right: 0.7642471198864927d,bottom: 0.27006084833309785d,left: 0.719944101098174d),
new NpgsqlTypes.NpgsqlBox(top: 0.6487999403148655d,right: 0.7053003133476462d,bottom: 0.4114320604570354d,left: 0.32763240729773d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7574954304585635d,right: 0.5360238910429668d,bottom: 0.19712830423490413d,left: 0.40503183932669373d),
new NpgsqlTypes.NpgsqlBox(top: 0.9217910196048824d,right: 0.26747168589918247d,bottom: 0.7959180955886622d,left: 0.08486977618096903d),
new NpgsqlTypes.NpgsqlBox(top: 0.7829664996284672d,right: 0.239729401497508d,bottom: 0.42782538794408376d,left: 0.13525150030029076d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd1e1mi_id
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
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2270131082533875d,right: 0.8263765187984375d,bottom: 0.025798853202167793d,left: 0.749029791819656d),
new NpgsqlTypes.NpgsqlBox(top: 0.8978322377882617d,right: 0.9922800008338731d,bottom: 0.6106485506653759d,left: 0.4665840097594689d),
new NpgsqlTypes.NpgsqlBox(top: 0.675453451340436d,right: 0.934725824614385d,bottom: 0.006666141514983681d,left: 0.6970651088803003d),
new NpgsqlTypes.NpgsqlBox(top: 0.6892929862724657d,right: 0.3122250449724935d,bottom: 0.26922415395865995d,left: 0.010378720548119058d),
}));
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6529222349602097d,right: 0.7888025541669512d,bottom: 0.5408297666058826d,left: 0.5068156192251809d),
new NpgsqlTypes.NpgsqlBox(top: 0.7345939446360594d,right: 0.9065817316905942d,bottom: 0.3924196513948611d,left: 0.8459687857241677d),
new NpgsqlTypes.NpgsqlBox(top: 0.6171419059832352d,right: 0.7755147461761643d,bottom: 0.5044721363775323d,left: 0.5192148638895558d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD1E1M> models = null;

                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD1E1M> models = null;

                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M), typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 99, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 83, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 34, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 93, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 27, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 110, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
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
FROM public.npgsqlboxboxmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD1E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 34, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 90, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 24, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxMArrayboxMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxMArrayboxMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 2);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                NpgsqlBoxboxMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
FROM public.binary_npgsqlboxboxmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlboxboxmmarrayd1e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
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
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI), typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MI>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA), typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD1E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD1))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

