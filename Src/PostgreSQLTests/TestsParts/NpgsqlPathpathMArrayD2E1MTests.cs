

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
    internal partial interface INpgsqlPathMArraypathMArrayD2
    {
    }
    
    internal partial class NpgsqlPathMArraypathMArrayD2 : INpgsqlPathMArraypathMArrayD2
    {


#region TestData

        private readonly NpgsqlPathpathMArrayD2E1M[] _testData = new NpgsqlPathpathMArrayD2E1M[]
        {
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3449976648749964d, y: 0.39605062838917693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8175221319085956d, y: 0.9964672747796504d), new NpgsqlTypes.NpgsqlPoint(x: 0.6319981347973641d, y: 0.5403160657736757d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6007881318855955d, y: 0.5484997104496998d), new NpgsqlTypes.NpgsqlPoint(x: 0.9228670083966817d, y: 0.8521746388944502d), new NpgsqlTypes.NpgsqlPoint(x: 0.6203808880756343d, y: 0.28731591310828d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3393389956922461d, y: 0.3810703279465125d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978479358760173d, y: 0.1663403832151341d), new NpgsqlTypes.NpgsqlPoint(x: 0.2296235397258085d, y: 0.7617111054182921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9682140137686677d, y: 0.7002742933778392d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573835684526044d, y: 0.02128325304781853d), new NpgsqlTypes.NpgsqlPoint(x: 0.4111950521315273d, y: 0.24711211858482485d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8080809285242304d, y: 0.9908041671878081d), new NpgsqlTypes.NpgsqlPoint(x: 0.16196631749256218d, y: 0.9366743099689361d), new NpgsqlTypes.NpgsqlPoint(x: 0.006817744039677276d, y: 0.7759642699601108d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5376210599349166d, y: 0.5000393476419114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9938800148367315d, y: 0.6548146376312333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2600505364983523d, y: 0.7505676374226413d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45237342944632164d, y: 0.5982675143417494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9196452205245724d, y: 0.6090331418260385d), new NpgsqlTypes.NpgsqlPoint(x: 0.4229820394200202d, y: 0.10153633189641098d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33884670989105425d, y: 0.49414914514896335d), new NpgsqlTypes.NpgsqlPoint(x: 0.2788163623758616d, y: 0.5381968881590847d), new NpgsqlTypes.NpgsqlPoint(x: 0.34349143697832407d, y: 0.7579634863429079d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8100842000330347d, y: 0.7993555598349408d), new NpgsqlTypes.NpgsqlPoint(x: 0.4674467155649119d, y: 0.23957009186277423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959524291193937d, y: 0.6842604238558108d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.855569499612884d, y: 0.48887604099224646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7002055334321672d, y: 0.32134701614604944d), new NpgsqlTypes.NpgsqlPoint(x: 0.3245954423802625d, y: 0.9897490929437807d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3073648190203263d, y: 0.4674140835160151d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635949212917937d, y: 0.7926572326629499d), new NpgsqlTypes.NpgsqlPoint(x: 0.11423282608084029d, y: 0.6399351493665865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7197256938981984d, y: 0.4383633721566661d), new NpgsqlTypes.NpgsqlPoint(x: 0.9145134188447471d, y: 0.9616782480709973d), new NpgsqlTypes.NpgsqlPoint(x: 0.7345033448320676d, y: 0.9974750242539218d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5469627922970188d, y: 0.6783250113563646d), new NpgsqlTypes.NpgsqlPoint(x: 0.22786581838621445d, y: 0.21090232791957708d), new NpgsqlTypes.NpgsqlPoint(x: 0.799087270818297d, y: 0.1294266854616969d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.817041574000449d, y: 0.6213585250050605d), new NpgsqlTypes.NpgsqlPoint(x: 0.39357744601486566d, y: 0.8188986294458662d), new NpgsqlTypes.NpgsqlPoint(x: 0.5855277030237965d, y: 0.4238827263053916d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4290874663056202d, y: 0.3793485197920814d), new NpgsqlTypes.NpgsqlPoint(x: 0.27029152001160694d, y: 0.017330870372000318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5360236058519436d, y: 0.7300806342831586d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46391294063200295d, y: 0.5260633615238152d), new NpgsqlTypes.NpgsqlPoint(x: 0.13287462906540115d, y: 0.8661030854842005d), new NpgsqlTypes.NpgsqlPoint(x: 0.40300424619170727d, y: 0.28301444379487206d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6781488507554811d, y: 0.227419771061938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9209942359508776d, y: 0.19404175042044403d), new NpgsqlTypes.NpgsqlPoint(x: 0.7243421584894187d, y: 0.018247638246085107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34512260519211224d, y: 0.48648923552372003d), new NpgsqlTypes.NpgsqlPoint(x: 0.334374125049422d, y: 0.5510493282482889d), new NpgsqlTypes.NpgsqlPoint(x: 0.47393039764670664d, y: 0.4436544200478917d)), } },
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8047692831937632d, y: 0.43365731383766526d), new NpgsqlTypes.NpgsqlPoint(x: 0.3665683380149175d, y: 0.32262309579986703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8710265008348497d, y: 0.039595238153053325d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36799233819187016d, y: 0.8667034682760858d), new NpgsqlTypes.NpgsqlPoint(x: 0.9714839518686709d, y: 0.03173611515516028d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272132213934867d, y: 0.5859343717675197d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7136721194004577d, y: 0.19490582232950748d), new NpgsqlTypes.NpgsqlPoint(x: 0.5521389164164496d, y: 0.6696328952807973d), new NpgsqlTypes.NpgsqlPoint(x: 0.13894485429341263d, y: 0.794032125403994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8703581350330888d, y: 0.5686266471075059d), new NpgsqlTypes.NpgsqlPoint(x: 0.3872103527361924d, y: 0.35475282587612433d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307430630345372d, y: 0.6627067021904217d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29354392840954957d, y: 0.26209310409208797d), new NpgsqlTypes.NpgsqlPoint(x: 0.2577737148730286d, y: 0.6303812284933736d), new NpgsqlTypes.NpgsqlPoint(x: 0.47951417300386656d, y: 0.8948785236583582d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31393954680391345d, y: 0.002644280974471225d), new NpgsqlTypes.NpgsqlPoint(x: 0.47162508598634734d, y: 0.24487415913162924d), new NpgsqlTypes.NpgsqlPoint(x: 0.9476261439859988d, y: 0.45434652128197794d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03099808646212643d, y: 0.9040413868561368d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622794375064731d, y: 0.04119144443803002d), new NpgsqlTypes.NpgsqlPoint(x: 0.24974233678273317d, y: 0.5768622386737793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6306791758594884d, y: 0.8354902469516741d), new NpgsqlTypes.NpgsqlPoint(x: 0.4681138119204782d, y: 0.48519751281220436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302917078657841d, y: 0.4678184029943119d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08493607816336901d, y: 0.114645458358967d), new NpgsqlTypes.NpgsqlPoint(x: 0.15064247461275238d, y: 0.9555602057752052d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534264125206102d, y: 0.7622411357804633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41839604603438496d, y: 0.9710618659771851d), new NpgsqlTypes.NpgsqlPoint(x: 0.3905734343638897d, y: 0.13694409503208105d), new NpgsqlTypes.NpgsqlPoint(x: 0.4888284811630005d, y: 0.607822645278205d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2243253045005026d, y: 0.3204525164772324d), new NpgsqlTypes.NpgsqlPoint(x: 0.9749551068927684d, y: 0.7204313572339492d), new NpgsqlTypes.NpgsqlPoint(x: 0.733851463163569d, y: 0.8530634646578324d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11644099036100108d, y: 0.325386369464005d), new NpgsqlTypes.NpgsqlPoint(x: 0.1529029705753081d, y: 0.3279573733122101d), new NpgsqlTypes.NpgsqlPoint(x: 0.7798076548339573d, y: 0.7234721420212031d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.472827875758584d, y: 0.013359544353951702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361466446206653d, y: 0.09238442699315286d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652437393890181d, y: 0.659434640981486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43333411605193695d, y: 0.8804560223746344d), new NpgsqlTypes.NpgsqlPoint(x: 0.4684561106724643d, y: 0.9649967121791494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6936020213694494d, y: 0.4419791200089479d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5712221527761216d, y: 0.7808673966465063d), new NpgsqlTypes.NpgsqlPoint(x: 0.4279896461276963d, y: 0.9539092792691161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9509800256926151d, y: 0.431017819012825d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09155173539334527d, y: 0.9358754950550858d), new NpgsqlTypes.NpgsqlPoint(x: 0.12572068650626944d, y: 0.9383610094715317d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277677971733697d, y: 0.6855083514447355d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2995620404840812d, y: 0.6206988907895413d), new NpgsqlTypes.NpgsqlPoint(x: 0.07307433292918941d, y: 0.05351396703623246d), new NpgsqlTypes.NpgsqlPoint(x: 0.9610212803342121d, y: 0.621429697217762d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4158934992466733d, y: 0.7466944042798318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5140833099525172d, y: 0.7035922651349372d), new NpgsqlTypes.NpgsqlPoint(x: 0.16402066467640775d, y: 0.5778803523824502d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4977190578027758d, y: 0.585576592778293d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313785139477861d, y: 0.7385289154270588d), new NpgsqlTypes.NpgsqlPoint(x: 0.6101204428099147d, y: 0.9024071821145642d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1706007143256837d, y: 0.6357309138246563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8415212141852397d, y: 0.4752203720484046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738929382175279d, y: 0.7675488230196317d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2592019369810121d, y: 0.4339877928751208d), new NpgsqlTypes.NpgsqlPoint(x: 0.125541218074934d, y: 0.3087329543395826d), new NpgsqlTypes.NpgsqlPoint(x: 0.1276784849373519d, y: 0.40247458964844307d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.461229939989514d, y: 0.2951308932632085d), new NpgsqlTypes.NpgsqlPoint(x: 0.6136864465348745d, y: 0.14408311155471032d), new NpgsqlTypes.NpgsqlPoint(x: 0.45504828165272326d, y: 0.9481749004577383d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6760807852528795d, y: 0.038334825829754116d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487277777140051d, y: 0.9041787284800686d), new NpgsqlTypes.NpgsqlPoint(x: 0.5596739885915196d, y: 0.35478030655931014d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31840171534539385d, y: 0.5169489585714593d), new NpgsqlTypes.NpgsqlPoint(x: 0.05110439848683246d, y: 0.8273696896071285d), new NpgsqlTypes.NpgsqlPoint(x: 0.20875545043209331d, y: 0.4406392968980667d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2844412595301119d, y: 0.12795128625178953d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476508003301541d, y: 0.7376236221079902d), new NpgsqlTypes.NpgsqlPoint(x: 0.05522335037234072d, y: 0.5864604674981578d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1592749709996477d, y: 0.6369183666036041d), new NpgsqlTypes.NpgsqlPoint(x: 0.2659129740257723d, y: 0.7260201654212542d), new NpgsqlTypes.NpgsqlPoint(x: 0.3568826115136202d, y: 0.8976396586305421d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6005173428014714d, y: 0.1378177628893179d), new NpgsqlTypes.NpgsqlPoint(x: 0.529833221084337d, y: 0.7087178007711943d), new NpgsqlTypes.NpgsqlPoint(x: 0.617447456591905d, y: 0.4805570668217154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42124791519324933d, y: 0.650021766193874d), new NpgsqlTypes.NpgsqlPoint(x: 0.056060631406096406d, y: 0.08325793204953824d), new NpgsqlTypes.NpgsqlPoint(x: 0.07014684236917101d, y: 0.44221872655107064d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20679901907764975d, y: 0.7871767881963148d), new NpgsqlTypes.NpgsqlPoint(x: 0.3763446163194929d, y: 0.6824626444623898d), new NpgsqlTypes.NpgsqlPoint(x: 0.09008944023069154d, y: 0.40598325148055525d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48729722388867336d, y: 0.059303088154342154d), new NpgsqlTypes.NpgsqlPoint(x: 0.6613474284469445d, y: 0.8870216460504683d), new NpgsqlTypes.NpgsqlPoint(x: 0.128864336624683d, y: 0.189133926593398d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024201742113359015d, y: 0.3405681737259837d), new NpgsqlTypes.NpgsqlPoint(x: 0.5690841320521164d, y: 0.8882647612199854d), new NpgsqlTypes.NpgsqlPoint(x: 0.15543397749610555d, y: 0.21856636098618243d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0543532967504774d, y: 0.49412605931784614d), new NpgsqlTypes.NpgsqlPoint(x: 0.17076657128987693d, y: 0.10170244410575546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379790731904018d, y: 0.15632062766688337d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5652508128359904d, y: 0.934080046941853d), new NpgsqlTypes.NpgsqlPoint(x: 0.760521243545654d, y: 0.38740547643389567d), new NpgsqlTypes.NpgsqlPoint(x: 0.998799819322962d, y: 0.9731847697035977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2532128591551642d, y: 0.8440184450334213d), new NpgsqlTypes.NpgsqlPoint(x: 0.46334139541468333d, y: 0.3302505940943238d), new NpgsqlTypes.NpgsqlPoint(x: 0.9947973968772246d, y: 0.5552323956623753d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7946051191177759d, y: 0.024279244375763342d), new NpgsqlTypes.NpgsqlPoint(x: 0.48611241555786056d, y: 0.84415917706d), new NpgsqlTypes.NpgsqlPoint(x: 0.6209509592524176d, y: 0.32654228495149207d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9240849002295837d, y: 0.3653684323494262d), new NpgsqlTypes.NpgsqlPoint(x: 0.05280074340590002d, y: 0.008098320932276581d), new NpgsqlTypes.NpgsqlPoint(x: 0.2140024310939308d, y: 0.07930936380644438d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.83479018486275d, y: 0.8754378216367236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7908517693366971d, y: 0.22466176439618502d), new NpgsqlTypes.NpgsqlPoint(x: 0.33580440544056145d, y: 0.1469069690641973d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2953240284193809d, y: 0.5545192598772186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054199740076558d, y: 0.3174311334115226d), new NpgsqlTypes.NpgsqlPoint(x: 0.19838833421795365d, y: 0.2337554922491515d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5874950332488206d, y: 0.41101235250262624d), new NpgsqlTypes.NpgsqlPoint(x: 0.30761602134904453d, y: 0.9120446490040387d), new NpgsqlTypes.NpgsqlPoint(x: 0.2021168957920344d, y: 0.09064441599429585d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.481891110212327d, y: 0.9024936053896808d), new NpgsqlTypes.NpgsqlPoint(x: 0.007361113351339266d, y: 0.31821892272066954d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327911426549578d, y: 0.0028227670315471576d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18051904399608387d, y: 0.6421740453524137d), new NpgsqlTypes.NpgsqlPoint(x: 0.07157100844085607d, y: 0.857635050297575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2317604728120226d, y: 0.25547606852524907d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7508153276437934d, y: 0.6701893257975072d), new NpgsqlTypes.NpgsqlPoint(x: 0.5148697925426757d, y: 0.0024200089455463925d), new NpgsqlTypes.NpgsqlPoint(x: 0.12212130877158245d, y: 0.5522334223488445d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8921466699836396d, y: 0.5085148959801911d), new NpgsqlTypes.NpgsqlPoint(x: 0.39846892510409326d, y: 0.5115067904403475d), new NpgsqlTypes.NpgsqlPoint(x: 0.33960595196902943d, y: 0.28119565331846075d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4219729388428717d, y: 0.7871744099302953d), new NpgsqlTypes.NpgsqlPoint(x: 0.4818122687129469d, y: 0.6922509601583313d), new NpgsqlTypes.NpgsqlPoint(x: 0.5467035602499232d, y: 0.45256033584105837d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4263505577938703d, y: 0.2976089090176015d), new NpgsqlTypes.NpgsqlPoint(x: 0.38312903114827623d, y: 0.9490236771319992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954573413960434d, y: 0.9298264804194802d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13563139229157795d, y: 0.14673032599172608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5869431000550112d, y: 0.31904613467710996d), new NpgsqlTypes.NpgsqlPoint(x: 0.13787210079548684d, y: 0.37802025879379697d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8675691680572298d, y: 0.5774787840406913d), new NpgsqlTypes.NpgsqlPoint(x: 0.44658231644237467d, y: 0.23338852198794002d), new NpgsqlTypes.NpgsqlPoint(x: 0.3982562088332382d, y: 0.35800030082033363d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7114046109355567d, y: 0.3209852313038415d), new NpgsqlTypes.NpgsqlPoint(x: 0.27653076733994797d, y: 0.1931545376103172d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262670273515434d, y: 0.32749164324258884d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2590117347320231d, y: 0.14187082786383987d), new NpgsqlTypes.NpgsqlPoint(x: 0.7057106904053512d, y: 0.3408960542602665d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539617548257332d, y: 0.3691512191870834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26087463818538026d, y: 0.8503239741642827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5792537924319991d, y: 0.13198644002675863d), new NpgsqlTypes.NpgsqlPoint(x: 0.77199772963281d, y: 0.0964764208755039d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9095776668250436d, y: 0.10431364813909139d), new NpgsqlTypes.NpgsqlPoint(x: 0.3168559353675844d, y: 0.6155400434061792d), new NpgsqlTypes.NpgsqlPoint(x: 0.2781380808500069d, y: 0.44809408346052215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9941325600889391d, y: 0.4714702371617139d), new NpgsqlTypes.NpgsqlPoint(x: 0.11250590507362856d, y: 0.8627885991376533d), new NpgsqlTypes.NpgsqlPoint(x: 0.45617983091396586d, y: 0.01220111770276222d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14492873308732934d, y: 0.7415415264334547d), new NpgsqlTypes.NpgsqlPoint(x: 0.22664883160022664d, y: 0.15493863203148617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166683598855744d, y: 0.8998218152969222d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5893297040680202d, y: 0.8282230187805272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469053127211534d, y: 0.13630669210478175d), new NpgsqlTypes.NpgsqlPoint(x: 0.12952707741845348d, y: 0.680882893538693d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.537000446184284d, y: 0.7616685143215906d), new NpgsqlTypes.NpgsqlPoint(x: 0.9100816414399302d, y: 0.8416986650395784d), new NpgsqlTypes.NpgsqlPoint(x: 0.4312968967514236d, y: 0.36899735762257524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5173610752657746d, y: 0.7672507151078571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7711465013416291d, y: 0.647845434169314d), new NpgsqlTypes.NpgsqlPoint(x: 0.8556464028128813d, y: 0.7844896522148773d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1175988300647618d, y: 0.8739124630516806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5420192432848409d, y: 0.8846839119827444d), new NpgsqlTypes.NpgsqlPoint(x: 0.9121744248599273d, y: 0.23800717191561782d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20893529876245942d, y: 0.3922782270915993d), new NpgsqlTypes.NpgsqlPoint(x: 0.4836915736022377d, y: 0.03553440037793565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254784627679637d, y: 0.8950389343880195d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9927280133605364d, y: 0.2070954361829338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7391286517242993d, y: 0.7650081712386986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5558941180279948d, y: 0.5885694972532807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3735472849106334d, y: 0.06612216287918449d), new NpgsqlTypes.NpgsqlPoint(x: 0.7983213908372289d, y: 0.25174377997045894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745405111419807d, y: 0.543107321847133d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5421681866233675d, y: 0.7448313370738627d), new NpgsqlTypes.NpgsqlPoint(x: 0.40924863446254d, y: 0.3538371315358698d), new NpgsqlTypes.NpgsqlPoint(x: 0.5390159762384616d, y: 0.08033197232105482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28209301000267306d, y: 0.5254568138941694d), new NpgsqlTypes.NpgsqlPoint(x: 0.1908079268417966d, y: 0.8978200386970028d), new NpgsqlTypes.NpgsqlPoint(x: 0.04957784851697011d, y: 0.032972001462947764d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.059537433678561014d, y: 0.983410607455999d), new NpgsqlTypes.NpgsqlPoint(x: 0.6878712068659119d, y: 0.2715105593799224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627427234127001d, y: 0.21603801879947282d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9324015426007974d, y: 0.12056901686625998d), new NpgsqlTypes.NpgsqlPoint(x: 0.5569825653444481d, y: 0.16741740931298477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8050545343596048d, y: 0.9529541378921944d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7715684805765812d, y: 0.8746116252512823d), new NpgsqlTypes.NpgsqlPoint(x: 0.44869988344573486d, y: 0.6232215224333658d), new NpgsqlTypes.NpgsqlPoint(x: 0.8589731484686646d, y: 0.16634425192559799d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8759348744057837d, y: 0.07941578091790635d), new NpgsqlTypes.NpgsqlPoint(x: 0.34171533050107783d, y: 0.9173559541056504d), new NpgsqlTypes.NpgsqlPoint(x: 0.4350748911048976d, y: 0.7891070923725464d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38566114134405516d, y: 0.22165837703270874d), new NpgsqlTypes.NpgsqlPoint(x: 0.617028436330635d, y: 0.7277532335107656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806595987585514d, y: 0.18727338873783128d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5320226191444448d, y: 0.844651097271619d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219314766708567d, y: 0.4834146089337539d), new NpgsqlTypes.NpgsqlPoint(x: 0.6505877328113311d, y: 0.282086653709662d)), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.857884885039508d, y: 0.9621268699562048d), new NpgsqlTypes.NpgsqlPoint(x: 0.883948683071468d, y: 0.9649369143561437d), new NpgsqlTypes.NpgsqlPoint(x: 0.39840707899564165d, y: 0.42864819325600767d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9888200237887877d, y: 0.21134389393349207d), new NpgsqlTypes.NpgsqlPoint(x: 0.04354919852939887d, y: 0.8878543543287686d), new NpgsqlTypes.NpgsqlPoint(x: 0.37294266128683984d, y: 0.1859990362100289d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9752752018976495d, y: 0.927905425268659d), new NpgsqlTypes.NpgsqlPoint(x: 0.48917339935063253d, y: 0.45028631118076357d), new NpgsqlTypes.NpgsqlPoint(x: 0.687555501585095d, y: 0.5653371846656965d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7963056979809978d, y: 0.2381183328732812d), new NpgsqlTypes.NpgsqlPoint(x: 0.37423905195806095d, y: 0.44400716670279294d), new NpgsqlTypes.NpgsqlPoint(x: 0.5188127468033971d, y: 0.9600378377332046d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7034575353212205d, y: 0.9471438407202171d), new NpgsqlTypes.NpgsqlPoint(x: 0.868897201378037d, y: 0.52289343286634d), new NpgsqlTypes.NpgsqlPoint(x: 0.794535678269478d, y: 0.6543270781634708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057757098960503406d, y: 0.05473652771993476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7517709960617482d, y: 0.21947482519059647d), new NpgsqlTypes.NpgsqlPoint(x: 0.2750117051034856d, y: 0.8463743656642339d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.386933090210447d, y: 0.753241091548368d), new NpgsqlTypes.NpgsqlPoint(x: 0.036110421223609634d, y: 0.16670806600167276d), new NpgsqlTypes.NpgsqlPoint(x: 0.7935306975235636d, y: 0.7475427578505852d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5807090926029264d, y: 0.4224409994206917d), new NpgsqlTypes.NpgsqlPoint(x: 0.13545066927278326d, y: 0.739820227710305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9580695557909206d, y: 0.7274044693132891d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7989416155225363d, y: 0.35414632959654035d), new NpgsqlTypes.NpgsqlPoint(x: 0.05776657063076207d, y: 0.4177509222508352d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062091588120314d, y: 0.3108867576253882d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4422493439998755d, y: 0.4865108480403202d), new NpgsqlTypes.NpgsqlPoint(x: 0.38659318391049147d, y: 0.7654444443282347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8224307969604716d, y: 0.3990343379070781d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8396301367571051d, y: 0.5400462613571446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6275710975970992d, y: 0.026255081011981596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9257223505052937d, y: 0.5107614399994996d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49665742428780923d, y: 0.8927086486633218d), new NpgsqlTypes.NpgsqlPoint(x: 0.19790055103272852d, y: 0.08377501937024368d), new NpgsqlTypes.NpgsqlPoint(x: 0.23891461335698716d, y: 0.9834036263458974d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9235249764350714d, y: 0.4116919669571444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6492000988669756d, y: 0.2672060212087207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180226804398677d, y: 0.7822178209153968d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.731926258552831d, y: 0.0524076659445708d), new NpgsqlTypes.NpgsqlPoint(x: 0.3164251969821462d, y: 0.4267014217412991d), new NpgsqlTypes.NpgsqlPoint(x: 0.46561950843542554d, y: 0.6528298390742772d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33543563074053884d, y: 0.17808575438545593d), new NpgsqlTypes.NpgsqlPoint(x: 0.5624999413553786d, y: 0.6087040915029023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6131202082073286d, y: 0.2549763808839044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6903172380658379d, y: 0.5757357648268911d), new NpgsqlTypes.NpgsqlPoint(x: 0.42651103835413984d, y: 0.33070397590695244d), new NpgsqlTypes.NpgsqlPoint(x: 0.35300440463633387d, y: 0.7381112229711986d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.075553652660447d, y: 0.17861797016710024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268315644208145d, y: 0.2553293391716176d), new NpgsqlTypes.NpgsqlPoint(x: 0.271335613037738d, y: 0.7520591202446896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7567312198567232d, y: 0.4386389378181421d), new NpgsqlTypes.NpgsqlPoint(x: 0.6167753102159774d, y: 0.041549765103370606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5697284941031533d, y: 0.652894625260469d)), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11916012550182753d, y: 0.05483181456508879d), new NpgsqlTypes.NpgsqlPoint(x: 0.4847167884582424d, y: 0.7820497244646822d), new NpgsqlTypes.NpgsqlPoint(x: 0.23924268910611235d, y: 0.006560149445055674d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6134583983713064d, y: 0.5037151818481567d), new NpgsqlTypes.NpgsqlPoint(x: 0.8234850704055982d, y: 0.44995829997058034d), new NpgsqlTypes.NpgsqlPoint(x: 0.41757442105668974d, y: 0.045310461974212735d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025454426787629547d, y: 0.18862677575895836d), new NpgsqlTypes.NpgsqlPoint(x: 0.22334901838026855d, y: 0.5629149913204604d), new NpgsqlTypes.NpgsqlPoint(x: 0.371692509743914d, y: 0.7976812534310632d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07017190761820402d, y: 0.734853237715427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6583768688300458d, y: 0.13529943091318952d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169105736496021d, y: 0.49760813464106446d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7560801438723475d, y: 0.65152350763787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5744956581870958d, y: 0.5600668697177963d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009580281531675894d, y: 0.9875124244817545d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8393357670213407d, y: 0.18993875904317647d), new NpgsqlTypes.NpgsqlPoint(x: 0.03294206985214354d, y: 0.769884171780198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8603410753609104d, y: 0.777539019704688d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17284837097126837d, y: 0.9334117824916738d), new NpgsqlTypes.NpgsqlPoint(x: 0.10446491165308602d, y: 0.9293792748907215d), new NpgsqlTypes.NpgsqlPoint(x: 0.2586609679602835d, y: 0.35247740407536043d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30695897470738664d, y: 0.9019253352650278d), new NpgsqlTypes.NpgsqlPoint(x: 0.242461074964463d, y: 0.02032060453625595d), new NpgsqlTypes.NpgsqlPoint(x: 0.557045222117167d, y: 0.9609932006653327d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21119407822638447d, y: 0.565734148640486d), new NpgsqlTypes.NpgsqlPoint(x: 0.17848309339154866d, y: 0.6033954949281866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5026784036836771d, y: 0.7688041371833924d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46208897905471025d, y: 0.5663830005515157d), new NpgsqlTypes.NpgsqlPoint(x: 0.4769770635150711d, y: 0.6510749260568982d), new NpgsqlTypes.NpgsqlPoint(x: 0.758138969916167d, y: 0.33049371276902384d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3169619848359396d, y: 0.35746364668277597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5778099119714337d, y: 0.5579520684765618d), new NpgsqlTypes.NpgsqlPoint(x: 0.4571267349415089d, y: 0.5900917457509633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3728403945438563d, y: 0.1136491740913319d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051101858960079d, y: 0.3711639844422844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445367526925377d, y: 0.6114697961234065d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9837336751697515d, y: 0.7545800379197544d), new NpgsqlTypes.NpgsqlPoint(x: 0.03217058377555482d, y: 0.34520460290092114d), new NpgsqlTypes.NpgsqlPoint(x: 0.8151592315714573d, y: 0.37917714592541407d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2483559495917741d, y: 0.4229439176433425d), new NpgsqlTypes.NpgsqlPoint(x: 0.012007767871005881d, y: 0.11514113577412888d), new NpgsqlTypes.NpgsqlPoint(x: 0.08100380917569638d, y: 0.41255441368096424d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2502314485812043d, y: 0.5539200170644196d), new NpgsqlTypes.NpgsqlPoint(x: 0.3311808466405275d, y: 0.41853114228217037d), new NpgsqlTypes.NpgsqlPoint(x: 0.12827409749202123d, y: 0.7745119313993267d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6549360268171943d, y: 0.845659606523698d), new NpgsqlTypes.NpgsqlPoint(x: 0.11963729739850537d, y: 0.8937182026778259d), new NpgsqlTypes.NpgsqlPoint(x: 0.15065472070881447d, y: 0.24824743337220978d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23262497769204293d, y: 0.2887161799685646d), new NpgsqlTypes.NpgsqlPoint(x: 0.22555930997636942d, y: 0.4021415202925901d), new NpgsqlTypes.NpgsqlPoint(x: 0.4501751064055747d, y: 0.8878664022654504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3997672967281817d, y: 0.22507177727860472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5145761703882588d, y: 0.554009484782672d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824113645622396d, y: 0.33952185911223376d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8952427589128302d, y: 0.7817744066622494d), new NpgsqlTypes.NpgsqlPoint(x: 0.35957902405684794d, y: 0.5778260668065626d), new NpgsqlTypes.NpgsqlPoint(x: 0.48395403638202983d, y: 0.628683315475008d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7825961971280679d, y: 0.6720296137056231d), new NpgsqlTypes.NpgsqlPoint(x: 0.5531675766008592d, y: 0.6905079371494427d), new NpgsqlTypes.NpgsqlPoint(x: 0.9506481890201949d, y: 0.1562215856583422d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5620235592358326d, y: 0.9744155952369601d), new NpgsqlTypes.NpgsqlPoint(x: 0.3879858835750004d, y: 0.8477582771128934d), new NpgsqlTypes.NpgsqlPoint(x: 0.66692359376641d, y: 0.991713826920562d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021503220438718884d, y: 0.5650574504000905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584497470354719d, y: 0.4385476147196501d), new NpgsqlTypes.NpgsqlPoint(x: 0.7478231931761183d, y: 0.804566501787803d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7699271829519321d, y: 0.08518011071309073d), new NpgsqlTypes.NpgsqlPoint(x: 0.4948580918913127d, y: 0.09794925107934338d), new NpgsqlTypes.NpgsqlPoint(x: 0.19335389753289423d, y: 0.04538293835476914d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07441962949294711d, y: 0.14280700935571655d), new NpgsqlTypes.NpgsqlPoint(x: 0.27961455810827773d, y: 0.9570440367995989d), new NpgsqlTypes.NpgsqlPoint(x: 0.2832780339548261d, y: 0.41967751111382456d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3942711688721172d, y: 0.22481928912933669d), new NpgsqlTypes.NpgsqlPoint(x: 0.12536238969207947d, y: 0.01893033094878127d), new NpgsqlTypes.NpgsqlPoint(x: 0.24510491266322398d, y: 0.14146967607513095d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8370313910052235d, y: 0.8862119979260251d), new NpgsqlTypes.NpgsqlPoint(x: 0.810825757045811d, y: 0.5218683931799759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824769630347825d, y: 0.6521095805451949d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42547405080778633d, y: 0.05290410605169582d), new NpgsqlTypes.NpgsqlPoint(x: 0.842633162272699d, y: 0.8743198200398443d), new NpgsqlTypes.NpgsqlPoint(x: 0.33955375612881755d, y: 0.9239481546582471d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8200074260034054d, y: 0.29371016536048555d), new NpgsqlTypes.NpgsqlPoint(x: 0.24963117375359423d, y: 0.027750881382594073d), new NpgsqlTypes.NpgsqlPoint(x: 0.11707381694086083d, y: 0.045538478065400234d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4624057552796573d, y: 0.5813695185643434d), new NpgsqlTypes.NpgsqlPoint(x: 0.3196129587598179d, y: 0.9472683780663567d), new NpgsqlTypes.NpgsqlPoint(x: 0.8367143084432715d, y: 0.9065332832801337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27175156034433245d, y: 0.3841070567779784d), new NpgsqlTypes.NpgsqlPoint(x: 0.9145608411540229d, y: 0.25964061338115174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7171448240469342d, y: 0.945363992460882d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7404295347550122d, y: 0.22328896717694335d), new NpgsqlTypes.NpgsqlPoint(x: 0.5164366150104747d, y: 0.23399476993332413d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088171391779d, y: 0.24620608137033606d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6253898259844061d, y: 0.7314461988269445d), new NpgsqlTypes.NpgsqlPoint(x: 0.956422851078299d, y: 0.9915916329929007d), new NpgsqlTypes.NpgsqlPoint(x: 0.25742025236859223d, y: 0.09179496416045307d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6893632008541896d, y: 0.2835623279254359d), new NpgsqlTypes.NpgsqlPoint(x: 0.5182433289972154d, y: 0.6997212308553273d), new NpgsqlTypes.NpgsqlPoint(x: 0.4388084112427424d, y: 0.269564737761234d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05629916753404318d, y: 0.637766642944211d), new NpgsqlTypes.NpgsqlPoint(x: 0.10158432651672d, y: 0.7136360543160793d), new NpgsqlTypes.NpgsqlPoint(x: 0.13456718652698296d, y: 0.6422771861802259d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8165581418051525d, y: 0.7672037625908158d), new NpgsqlTypes.NpgsqlPoint(x: 0.6127104437733033d, y: 0.38421644934574783d), new NpgsqlTypes.NpgsqlPoint(x: 0.19854835574752483d, y: 0.668724966280749d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7416045124484402d, y: 0.8335996081303275d), new NpgsqlTypes.NpgsqlPoint(x: 0.43704653423941586d, y: 0.688476956652703d), new NpgsqlTypes.NpgsqlPoint(x: 0.12222274589889515d, y: 0.41091592912989194d)), } },
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8957056250757255d, y: 0.9693600592142342d), new NpgsqlTypes.NpgsqlPoint(x: 0.8757622502986736d, y: 0.9230792800747335d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184504170107294d, y: 0.1558130284449627d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354964273237645d, y: 0.2016717555794939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2546689931153896d, y: 0.04982173774724308d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525919268319522d, y: 0.7617205438753334d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21429524477543327d, y: 0.5660811829079367d), new NpgsqlTypes.NpgsqlPoint(x: 0.2992905011734933d, y: 0.4959922941300231d), new NpgsqlTypes.NpgsqlPoint(x: 0.41616097839032695d, y: 0.7692091705205816d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4188850132305566d, y: 0.5643451287272248d), new NpgsqlTypes.NpgsqlPoint(x: 0.9616834078973355d, y: 0.8403770301837219d), new NpgsqlTypes.NpgsqlPoint(x: 0.6921024625358418d, y: 0.5137281642488346d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20471286194198635d, y: 0.318907231738324d), new NpgsqlTypes.NpgsqlPoint(x: 0.4621147916769358d, y: 0.7931455363697045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9118471448474184d, y: 0.05625197528197812d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38961617524610836d, y: 0.8305640635457402d), new NpgsqlTypes.NpgsqlPoint(x: 0.4275352327115085d, y: 0.714617049825285d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995839607611869d, y: 0.2480634391662171d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03257046902294303d, y: 0.33529161728908463d), new NpgsqlTypes.NpgsqlPoint(x: 0.48109426810385914d, y: 0.43271716808238236d), new NpgsqlTypes.NpgsqlPoint(x: 0.6939448413971819d, y: 0.7151561368832872d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7991464857129311d, y: 0.832011136306533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6811162972850978d, y: 0.009678589908920343d), new NpgsqlTypes.NpgsqlPoint(x: 0.8848614812321478d, y: 0.5623089736534063d)), } },
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5370599661031085d, y: 0.4147619893105726d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123974731375873d, y: 0.6803981057578024d), new NpgsqlTypes.NpgsqlPoint(x: 0.2006276207837312d, y: 0.9998771245010083d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9786425562493007d, y: 0.3565528983556404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7658973799850135d, y: 0.3792995845076639d), new NpgsqlTypes.NpgsqlPoint(x: 0.3637767008943623d, y: 0.06397332975194414d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6010905195143882d, y: 0.8589077331328533d), new NpgsqlTypes.NpgsqlPoint(x: 0.42218595645927715d, y: 0.8522982562531882d), new NpgsqlTypes.NpgsqlPoint(x: 0.899996207765745d, y: 0.05970199155281153d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4644335121100005d, y: 0.4100907732540656d), new NpgsqlTypes.NpgsqlPoint(x: 0.1854608185205603d, y: 0.41411614030359656d), new NpgsqlTypes.NpgsqlPoint(x: 0.5145598588601678d, y: 0.9191428832733053d)), } },
    ModelInner = new NpgsqlPathpathMArrayD21MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002783467417123431d, y: 0.8436116323342279d), new NpgsqlTypes.NpgsqlPoint(x: 0.20224660639235037d, y: 0.7556867045531255d), new NpgsqlTypes.NpgsqlPoint(x: 0.002390444950586712d, y: 0.14812534007062683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8446654742529163d, y: 0.9736201838246252d), new NpgsqlTypes.NpgsqlPoint(x: 0.48775752889882096d, y: 0.7394935145086914d), new NpgsqlTypes.NpgsqlPoint(x: 0.3863668642582717d, y: 0.677492478006544d)), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD2E1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5731424347642211d, y: 0.7881558564123206d), new NpgsqlTypes.NpgsqlPoint(x: 0.2204066980286209d, y: 0.9249001882682032d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236589150446559d, y: 0.5870218550559416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31209587011552997d, y: 0.8295755516115806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5081046567305798d, y: 0.8174481348454951d), new NpgsqlTypes.NpgsqlPoint(x: 0.46776930547312734d, y: 0.38500957274353964d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.845115258887587d, y: 0.48704347295708683d), new NpgsqlTypes.NpgsqlPoint(x: 0.49972739986351034d, y: 0.5492272671747661d), new NpgsqlTypes.NpgsqlPoint(x: 0.38632927998122146d, y: 0.904450004375974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069642036575138d, y: 0.6624158383284495d), new NpgsqlTypes.NpgsqlPoint(x: 0.1112330159169096d, y: 0.7574475946852004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8706269422541445d, y: 0.5936972288001754d)), } },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmarrayd21mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
INSERT INTO public.npgsqlpathpathmarrayd21mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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

                changedRows =  ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmarrayd21mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)), 
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
                methodParametrName: "npgsqlpathpathmarrayd21mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmarrayd21mi_id
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
    npgsqlpathpathmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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

                    nullable =  ((INpgsqlPathMArraypathMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7136721194004577d, y: 0.19490582232950748d), new NpgsqlTypes.NpgsqlPoint(x: 0.5521389164164496d, y: 0.6696328952807973d), new NpgsqlTypes.NpgsqlPoint(x: 0.13894485429341263d, y: 0.794032125403994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8703581350330888d, y: 0.5686266471075059d), new NpgsqlTypes.NpgsqlPoint(x: 0.3872103527361924d, y: 0.35475282587612433d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307430630345372d, y: 0.6627067021904217d)), } }));
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

                    nullable =  ((INpgsqlPathMArraypathMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08493607816336901d, y: 0.114645458358967d), new NpgsqlTypes.NpgsqlPoint(x: 0.15064247461275238d, y: 0.9555602057752052d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534264125206102d, y: 0.7622411357804633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41839604603438496d, y: 0.9710618659771851d), new NpgsqlTypes.NpgsqlPoint(x: 0.3905734343638897d, y: 0.13694409503208105d), new NpgsqlTypes.NpgsqlPoint(x: 0.4888284811630005d, y: 0.607822645278205d)), } }));
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

                    nullable = await ((INpgsqlPathMArraypathMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((INpgsqlPathMArraypathMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2995620404840812d, y: 0.6206988907895413d), new NpgsqlTypes.NpgsqlPoint(x: 0.07307433292918941d, y: 0.05351396703623246d), new NpgsqlTypes.NpgsqlPoint(x: 0.9610212803342121d, y: 0.621429697217762d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4158934992466733d, y: 0.7466944042798318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5140833099525172d, y: 0.7035922651349372d), new NpgsqlTypes.NpgsqlPoint(x: 0.16402066467640775d, y: 0.5778803523824502d)), } }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmarrayd21mi_id
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
    npgsqlpathpathmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
                methodParametrName: "npgsqlpathpathmarrayd21mi_id", 
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
                nullable =  ((INpgsqlPathMArraypathMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathMArraypathMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6005173428014714d, y: 0.1378177628893179d), new NpgsqlTypes.NpgsqlPoint(x: 0.529833221084337d, y: 0.7087178007711943d), new NpgsqlTypes.NpgsqlPoint(x: 0.617447456591905d, y: 0.4805570668217154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42124791519324933d, y: 0.650021766193874d), new NpgsqlTypes.NpgsqlPoint(x: 0.056060631406096406d, y: 0.08325793204953824d), new NpgsqlTypes.NpgsqlPoint(x: 0.07014684236917101d, y: 0.44221872655107064d)), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024201742113359015d, y: 0.3405681737259837d), new NpgsqlTypes.NpgsqlPoint(x: 0.5690841320521164d, y: 0.8882647612199854d), new NpgsqlTypes.NpgsqlPoint(x: 0.15543397749610555d, y: 0.21856636098618243d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0543532967504774d, y: 0.49412605931784614d), new NpgsqlTypes.NpgsqlPoint(x: 0.17076657128987693d, y: 0.10170244410575546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379790731904018d, y: 0.15632062766688337d)), } }));
                nullable = await ((INpgsqlPathMArraypathMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.83479018486275d, y: 0.8754378216367236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7908517693366971d, y: 0.22466176439618502d), new NpgsqlTypes.NpgsqlPoint(x: 0.33580440544056145d, y: 0.1469069690641973d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2953240284193809d, y: 0.5545192598772186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054199740076558d, y: 0.3174311334115226d), new NpgsqlTypes.NpgsqlPoint(x: 0.19838833421795365d, y: 0.2337554922491515d)), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMArrayD2E1M> models = null;

                models =  ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMArrayD2E1M> models = null;

                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD2E1M), typeof(FlatNpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                ((INpgsqlPathMArraypathMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmarrayd21mi mi ON mi.id = m.npgsqlpathpathmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD2E1M), typeof(FlatNpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                ((INpgsqlPathMArraypathMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmarrayd21mi mi ON mi.id = m.npgsqlpathpathmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD2E1M), typeof(FlatNpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                await((INpgsqlPathMArraypathMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmarrayd21mi mi ON mi.id = m.npgsqlpathpathmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD2E1M), typeof(FlatNpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                await((INpgsqlPathMArraypathMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 79, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 60, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 60, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 159, query1, 139, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 23, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 29, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
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
FROM public.npgsqlpathpathmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 29, query1, 101, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmarrayd21mi mi ON mi.id = m.npgsqlpathpathmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 133, 41))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 63, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models =  ((INpgsqlPathMArraypathMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlPathpathMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                NpgsqlPathpathMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMArrayD21MIWA),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMArrayD21MI),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
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
FROM public.binary_npgsqlpathpathmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpathpathmarrayd21mi mi ON mi.id = m.npgsqlpathpathmarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
                var models =  ((INpgsqlPathMArraypathMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MIWA), typeof(NpgsqlPathpathMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
                var models1 = new List<NpgsqlPathpathMArrayD21MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD21MIWA>();
                await ((INpgsqlPathMArraypathMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMArrayD21MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD21MIWA>();
                ((INpgsqlPathMArraypathMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmarrayd21mi
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
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmarrayd21mi
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
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MIWA), typeof(NpgsqlPathpathMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMArrayD21MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD21MIWA>();
                await ((INpgsqlPathMArraypathMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMArrayD21MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD21MIWA>();
                ((INpgsqlPathMArraypathMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmarrayd21mi
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
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmarrayd21mi
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
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MI), typeof(NpgsqlPathpathMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
                var models1 = new List<NpgsqlPathpathMArrayD21MI>();
                var models2 = new List<NpgsqlPathpathMArrayD21MI>();
                await ((INpgsqlPathMArraypathMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMArrayD21MI>();
                var models2 = new List<NpgsqlPathpathMArrayD21MI>();
                ((INpgsqlPathMArraypathMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MIWA), typeof(NpgsqlPathpathMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMArrayD21MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD21MIWA>();
                await ((INpgsqlPathMArraypathMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMArrayD21MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD21MIWA>();
                ((INpgsqlPathMArraypathMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

