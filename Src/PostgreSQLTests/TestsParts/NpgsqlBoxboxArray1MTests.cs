

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.14809001953465717d,right: 0.15498001598806554d,bottom: 0.08737533723377666d,left: 0.05828326749551027d),
new NpgsqlTypes.NpgsqlBox(top: 0.3499243504813545d,right: 0.33164976576974714d,bottom: 0.23330237716587388d,left: 0.18496625750532936d),
new NpgsqlTypes.NpgsqlBox(top: 0.3774654115795223d,right: 0.4329872862013855d,bottom: 0.05122920864779146d,left: 0.36672454542395483d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8216271146509357d,right: 0.9444626436488921d,bottom: 0.7160441009762449d,left: 0.27566798692273664d),
new NpgsqlTypes.NpgsqlBox(top: 0.2517593008354898d,right: 0.8169936974295506d,bottom: 0.02066173168351715d,left: 0.6622332516952835d),
new NpgsqlTypes.NpgsqlBox(top: 0.7875865253057281d,right: 0.588560391533046d,bottom: 0.35033469273938245d,left: 0.1645838472683515d),
new NpgsqlTypes.NpgsqlBox(top: 0.32297574270859697d,right: 0.7314173050232585d,bottom: 0.3032652463338317d,left: 0.6458706265165178d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.35648353227568663d,right: 0.5011007720226477d,bottom: 0.14624894779069364d,left: 0.24160006971978187d),
new NpgsqlTypes.NpgsqlBox(top: 0.8928825286131186d,right: 0.526391570059452d,bottom: 0.5203466904420633d,left: 0.29068952224199296d),
new NpgsqlTypes.NpgsqlBox(top: 0.7053604344198131d,right: 0.7635562762997443d,bottom: 0.029786971795898398d,left: 0.37972852858661577d),
new NpgsqlTypes.NpgsqlBox(top: 0.6707458859490625d,right: 0.8212904572973965d,bottom: 0.43433775609858294d,left: 0.6691001170238381d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.652004001570081d,right: 0.46905949225361165d,bottom: 0.11071079263624273d,left: 0.1557809977319703d),
new NpgsqlTypes.NpgsqlBox(top: 0.8705311833787501d,right: 0.9490769704112081d,bottom: 0.43041846074712564d,left: 0.11203106014744069d),
new NpgsqlTypes.NpgsqlBox(top: 0.905614529946883d,right: 0.5847621301787571d,bottom: 0.41655296122464613d,left: 0.037355557839178766d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8896530454603484d,right: 0.8777335301116731d,bottom: 0.10072599198820509d,left: 0.7983654519685764d),
new NpgsqlTypes.NpgsqlBox(top: 0.6628706545293347d,right: 0.26296114385111946d,bottom: 0.6358093039533493d,left: 0.12164622369087841d),
new NpgsqlTypes.NpgsqlBox(top: 0.4302763507075268d,right: 0.05146966423905708d,bottom: 0.012029490755152472d,left: 0.03136547431390602d),
new NpgsqlTypes.NpgsqlBox(top: 0.37672790459370353d,right: 0.253391378743986d,bottom: 0.30397142972655733d,left: 0.16253061058221185d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.97899036712221d,right: 0.7320865417856182d,bottom: 0.06619387994285897d,left: 0.12469026597636346d),
new NpgsqlTypes.NpgsqlBox(top: 0.4677474184362366d,right: 0.8404723616038655d,bottom: 0.1821150581929013d,left: 0.6830158209722951d),
new NpgsqlTypes.NpgsqlBox(top: 0.9130306123416864d,right: 0.6958365390415918d,bottom: 0.6862786128999531d,left: 0.6501194454115963d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4124670016190798d,right: 0.35789301137393426d,bottom: 0.08603062737239964d,left: 0.32358332112341914d),
new NpgsqlTypes.NpgsqlBox(top: 0.8591348891277797d,right: 0.8812899881713212d,bottom: 0.8461699325402253d,left: 0.6522215966925864d),
new NpgsqlTypes.NpgsqlBox(top: 0.8636514780321017d,right: 0.49004634723763907d,bottom: 0.18843722174809963d,left: 0.4734249707938071d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2522353333913252d,right: 0.38775972918946766d,bottom: 0.2429663856393368d,left: 0.24975106120642643d),
new NpgsqlTypes.NpgsqlBox(top: 0.7350191504993675d,right: 0.3367194330888106d,bottom: 0.42186924593682884d,left: 0.14062690494521324d),
new NpgsqlTypes.NpgsqlBox(top: 0.8532445937139688d,right: 0.7516874811888482d,bottom: 0.03837325791490065d,left: 0.30247947890962423d),
new NpgsqlTypes.NpgsqlBox(top: 0.35517970009021815d,right: 0.8110058612077252d,bottom: 0.1518696964644859d,left: 0.7989026448519033d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8917210269631889d,right: 0.9262442210501821d,bottom: 0.8762177779214875d,left: 0.2501761075518377d),
new NpgsqlTypes.NpgsqlBox(top: 0.6238887220021108d,right: 0.8917278828526958d,bottom: 0.3075572252570884d,left: 0.43286373727754046d),
new NpgsqlTypes.NpgsqlBox(top: 0.7242577236290784d,right: 0.5761210528127532d,bottom: 0.367840334177138d,left: 0.5475437170273652d),
new NpgsqlTypes.NpgsqlBox(top: 0.9510828068212324d,right: 0.40213946610739704d,bottom: 0.6781099248398907d,left: 0.25925673458752063d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.44396738563112503d,right: 0.5169219201413359d,bottom: 0.4340869781482498d,left: 0.4395352404636935d),
new NpgsqlTypes.NpgsqlBox(top: 0.7271718660402982d,right: 0.8865751083533641d,bottom: 0.1983236932037904d,left: 0.4576388678787302d),
new NpgsqlTypes.NpgsqlBox(top: 0.9379228659113976d,right: 0.7438255555407418d,bottom: 0.28270233876461515d,left: 0.7083758922685d),
new NpgsqlTypes.NpgsqlBox(top: 0.7728197970324076d,right: 0.5530625681465235d,bottom: 0.7016336713464713d,left: 0.4972554073386921d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.421282117783619d,right: 0.500626007785357d,bottom: 0.12446838931851534d,left: 0.16537468764659002d),
new NpgsqlTypes.NpgsqlBox(top: 0.8026917419926277d,right: 0.5930081063317035d,bottom: 0.46953201831301206d,left: 0.5473084040219396d),
new NpgsqlTypes.NpgsqlBox(top: 0.4005844405027321d,right: 0.6242825595912508d,bottom: 0.37547911931934463d,left: 0.16207793977637264d),
new NpgsqlTypes.NpgsqlBox(top: 0.9258415650124497d,right: 0.9339413388972833d,bottom: 0.8109474406457098d,left: 0.5607602453492153d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7924600441883586d,right: 0.15756728161803424d,bottom: 0.24575482313426555d,left: 0.11165476246552453d),
new NpgsqlTypes.NpgsqlBox(top: 0.7164662502712409d,right: 0.38423383651339993d,bottom: 0.6864602646027528d,left: 0.3812793194428118d),
new NpgsqlTypes.NpgsqlBox(top: 0.6655029847989972d,right: 0.5390319745059529d,bottom: 0.19101969265462793d,left: 0.0045912960264058444d),
new NpgsqlTypes.NpgsqlBox(top: 0.9722084930273285d,right: 0.6529470623802407d,bottom: 0.20305509653846565d,left: 0.16787211431427163d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.12422845810761596d,right: 0.8282654747154764d,bottom: 0.07570386658750339d,left: 0.3361962057514958d),
new NpgsqlTypes.NpgsqlBox(top: 0.2983596616884505d,right: 0.37365614089348276d,bottom: 0.23525801596834406d,left: 0.04287317690471937d),
new NpgsqlTypes.NpgsqlBox(top: 0.5572512720456875d,right: 0.5026434080909371d,bottom: 0.1853539599455677d,left: 0.33135357250505115d),
new NpgsqlTypes.NpgsqlBox(top: 0.930167131654684d,right: 0.7659897829721083d,bottom: 0.370404827692819d,left: 0.6921080114864306d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3183810562455739d,right: 0.5933464413887222d,bottom: 0.015075341166807532d,left: 0.12624867802247497d),
new NpgsqlTypes.NpgsqlBox(top: 0.8991803501541149d,right: 0.8896110133615569d,bottom: 0.7160197946167963d,left: 0.7712796358043997d),
new NpgsqlTypes.NpgsqlBox(top: 0.7664115511322291d,right: 0.6921442720905313d,bottom: 0.5830120783095193d,left: 0.6609783251799902d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.24856696486640295d,right: 0.41391095614724394d,bottom: 0.16048841998229135d,left: 0.14722731870105799d),
new NpgsqlTypes.NpgsqlBox(top: 0.9483095484751669d,right: 0.6282978705565776d,bottom: 0.5647814791578261d,left: 0.6062672425343933d),
new NpgsqlTypes.NpgsqlBox(top: 0.867103011241251d,right: 0.6290661965800975d,bottom: 0.2929165049303518d,left: 0.3711430100483597d),
new NpgsqlTypes.NpgsqlBox(top: 0.486997563877947d,right: 0.5240241547981386d,bottom: 0.4283277520798686d,left: 0.07396183626755937d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7360038636052882d,right: 0.5032010392004007d,bottom: 0.2843439133504315d,left: 0.33210012411530765d),
new NpgsqlTypes.NpgsqlBox(top: 0.41181612166121007d,right: 0.8830355224306017d,bottom: 0.3238133730147492d,left: 0.20886422772295554d),
new NpgsqlTypes.NpgsqlBox(top: 0.09009617601828912d,right: 0.9817802941559588d,bottom: 0.028295673286752532d,left: 0.4992617826934024d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.774418979203776d,right: 0.580593183049146d,bottom: 0.43434305142727736d,left: 0.22785828640551553d),
new NpgsqlTypes.NpgsqlBox(top: 0.9548749136069445d,right: 0.21660188926588186d,bottom: 0.3467409561238539d,left: 0.02033260159102357d),
new NpgsqlTypes.NpgsqlBox(top: 0.5915566195241074d,right: 0.7656256090632307d,bottom: 0.24525264996795038d,left: 0.31148291785163407d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4645549710795791d,right: 0.9330836764877342d,bottom: 0.08706337320100432d,left: 0.04098348881764824d),
new NpgsqlTypes.NpgsqlBox(top: 0.6091942584443136d,right: 0.37078546652218736d,bottom: 0.0059909385390992664d,left: 0.3656385259324684d),
new NpgsqlTypes.NpgsqlBox(top: 0.8805302318867012d,right: 0.849559035858525d,bottom: 0.0773886192584502d,left: 0.208760345778094d),
new NpgsqlTypes.NpgsqlBox(top: 0.9497875347541955d,right: 0.5885970917286509d,bottom: 0.40967184320802297d,left: 0.2168910315782776d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9604990770794694d,right: 0.7352673493134023d,bottom: 0.47243744976901036d,left: 0.3761799997121714d),
new NpgsqlTypes.NpgsqlBox(top: 0.9307033454999196d,right: 0.8602000251128086d,bottom: 0.41561295383276387d,left: 0.581600256324208d),
new NpgsqlTypes.NpgsqlBox(top: 0.5302770421224314d,right: 0.7217567951187529d,bottom: 0.27504071297177224d,left: 0.5903783502114598d),
new NpgsqlTypes.NpgsqlBox(top: 0.36754456827130955d,right: 0.9553749645252735d,bottom: 0.3557162666533271d,left: 0.7658933936603939d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.28935865764738766d,right: 0.6270238915502568d,bottom: 0.21676576178991902d,left: 0.27089093766805017d),
new NpgsqlTypes.NpgsqlBox(top: 0.9324349217463204d,right: 0.5636270843369585d,bottom: 0.16575157760367842d,left: 0.250296808805233d),
new NpgsqlTypes.NpgsqlBox(top: 0.7987031662397329d,right: 0.8643910254675287d,bottom: 0.42328742423292887d,left: 0.17390967905809174d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8592682452646099d,right: 0.756937239517283d,bottom: 0.2542747758624898d,left: 0.2989049020457868d),
new NpgsqlTypes.NpgsqlBox(top: 0.6283795177681624d,right: 0.953920326808027d,bottom: 0.49688394709272077d,left: 0.12848315880268402d),
new NpgsqlTypes.NpgsqlBox(top: 0.9321018565776652d,right: 0.8957616770556036d,bottom: 0.07051922201107597d,left: 0.3255951451703385d),
new NpgsqlTypes.NpgsqlBox(top: 0.7006254078877499d,right: 0.816768937761683d,bottom: 0.22053533578647255d,left: 0.32406328598335443d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6694575204372025d,right: 0.8962766156839799d,bottom: 0.014678812872671032d,left: 0.7890968327155317d),
new NpgsqlTypes.NpgsqlBox(top: 0.5485120561836538d,right: 0.8326969427901696d,bottom: 0.36118662564171067d,left: 0.6966011349371222d),
new NpgsqlTypes.NpgsqlBox(top: 0.9173659221073094d,right: 0.5267385167370794d,bottom: 0.3377221992839301d,left: 0.2524569105901977d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9170192142300412d,right: 0.9416573729231605d,bottom: 0.16998974670561806d,left: 0.8809338681856841d),
new NpgsqlTypes.NpgsqlBox(top: 0.2541401741706133d,right: 0.7324977608212124d,bottom: 0.23615991967315042d,left: 0.6564578485228375d),
new NpgsqlTypes.NpgsqlBox(top: 0.19780884564565993d,right: 0.9815464775007742d,bottom: 0.1395297401564145d,left: 0.5401993570491467d),
new NpgsqlTypes.NpgsqlBox(top: 0.8185680211228309d,right: 0.6205792098377219d,bottom: 0.2946946019873d,left: 0.005790471545976006d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.784138673266883d,right: 0.544397764705575d,bottom: 0.38073794441438435d,left: 0.10555196157432478d),
new NpgsqlTypes.NpgsqlBox(top: 0.586583677095079d,right: 0.37049258786621053d,bottom: 0.28649029506334345d,left: 0.3037449631764052d),
new NpgsqlTypes.NpgsqlBox(top: 0.9392273014513765d,right: 0.26633442823233433d,bottom: 0.22613087991036507d,left: 0.03675313304960737d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8884355290398338d,right: 0.7461927448528918d,bottom: 0.18023593827221274d,left: 0.10264876476915397d),
new NpgsqlTypes.NpgsqlBox(top: 0.9671241685289238d,right: 0.8134275627219807d,bottom: 0.1870533519643104d,left: 0.6201706914629282d),
new NpgsqlTypes.NpgsqlBox(top: 0.8235791769072341d,right: 0.785750994088557d,bottom: 0.12312175976787831d,left: 0.31429080132081944d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9145845154862872d,right: 0.7205591194026169d,bottom: 0.9124497824867738d,left: 0.3912200632962457d),
new NpgsqlTypes.NpgsqlBox(top: 0.21899591935224705d,right: 0.46154162889535033d,bottom: 0.20271038156314436d,left: 0.20069468200179463d),
new NpgsqlTypes.NpgsqlBox(top: 0.4430911932592728d,right: 0.31319070159503126d,bottom: 0.33221398507318733d,left: 0.23378518305924678d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9623172861315711d,right: 0.313426646270749d,bottom: 0.772834124053366d,left: 0.18394786864113843d),
new NpgsqlTypes.NpgsqlBox(top: 0.46817832439653495d,right: 0.6665804075115634d,bottom: 0.3284443858875945d,left: 0.4009352740684714d),
new NpgsqlTypes.NpgsqlBox(top: 0.6569417003747059d,right: 0.7705892682654492d,bottom: 0.45956963418477614d,left: 0.5511068078217053d),
new NpgsqlTypes.NpgsqlBox(top: 0.19241293061906362d,right: 0.789405823975982d,bottom: 0.04171273050805624d,left: 0.5803697727682078d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9097081837489298d,right: 0.5466603772094906d,bottom: 0.8398991176293593d,left: 0.16377433091577542d),
new NpgsqlTypes.NpgsqlBox(top: 0.5002650918422782d,right: 0.7845810890667927d,bottom: 0.199718653119474d,left: 0.6408355565075892d),
new NpgsqlTypes.NpgsqlBox(top: 0.8153109457504061d,right: 0.8336973464228634d,bottom: 0.7366652116102874d,left: 0.12371611081075162d),
new NpgsqlTypes.NpgsqlBox(top: 0.8596110286635753d,right: 0.9749602758868918d,bottom: 0.6566080894457247d,left: 0.1293215602721498d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9884962928651182d,right: 0.7599923669243009d,bottom: 0.4874779902044958d,left: 0.6082902935214788d),
new NpgsqlTypes.NpgsqlBox(top: 0.9137844590944824d,right: 0.8481661070265604d,bottom: 0.30790477531671645d,left: 0.6166759268159634d),
new NpgsqlTypes.NpgsqlBox(top: 0.45104767290305336d,right: 0.5314466725978678d,bottom: 0.10496014791996333d,left: 0.25635370977782623d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7242558725490803d,right: 0.5421896500641646d,bottom: 0.28684144718299065d,left: 0.2816098268446905d),
new NpgsqlTypes.NpgsqlBox(top: 0.918504455919651d,right: 0.7259664478898672d,bottom: 0.8009383350903873d,left: 0.4038307867136395d),
new NpgsqlTypes.NpgsqlBox(top: 0.4631981193892518d,right: 0.6240595524694245d,bottom: 0.22923916018122592d,left: 0.3783791027301643d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9759527272220078d,right: 0.20832035917676095d,bottom: 0.3038592102234662d,left: 0.019866309593270848d),
new NpgsqlTypes.NpgsqlBox(top: 0.5163945223325839d,right: 0.5029007370227472d,bottom: 0.35169020146838104d,left: 0.15588546950371018d),
new NpgsqlTypes.NpgsqlBox(top: 0.9585975248038092d,right: 0.8098822958719766d,bottom: 0.40982344985878205d,left: 0.3973755638633134d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9827170263591867d,right: 0.6889651438409707d,bottom: 0.39419801475317984d,left: 0.4210160397078664d),
new NpgsqlTypes.NpgsqlBox(top: 0.6115962396539664d,right: 0.26762284347932064d,bottom: 0.34800660972649944d,left: 0.0952531679937233d),
new NpgsqlTypes.NpgsqlBox(top: 0.22553566873601105d,right: 0.6049531669206766d,bottom: 0.15875128005088657d,left: 0.3689558497716843d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5067205699787986d,right: 0.5848056419336637d,bottom: 0.4535584856993795d,left: 0.024848476610766612d),
new NpgsqlTypes.NpgsqlBox(top: 0.9981093298122414d,right: 0.966499952286631d,bottom: 0.07064883768857355d,left: 0.7292469916095503d),
new NpgsqlTypes.NpgsqlBox(top: 0.5855739845646033d,right: 0.7127362561136431d,bottom: 0.5321327394742258d,left: 0.7064983946550959d),
new NpgsqlTypes.NpgsqlBox(top: 0.7034110550952014d,right: 0.7955114775401099d,bottom: 0.24552630266518083d,left: 0.2510384861361995d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2727953317540418d,right: 0.9789808191775826d,bottom: 0.05749266586361712d,left: 0.9249091086508354d),
new NpgsqlTypes.NpgsqlBox(top: 0.7904541854291687d,right: 0.8546225946846854d,bottom: 0.08150776069542243d,left: 0.6102155392875444d),
new NpgsqlTypes.NpgsqlBox(top: 0.5679200018329491d,right: 0.11313280783407043d,bottom: 0.06536466758805937d,left: 0.10766734199982209d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7832862188291284d,right: 0.7776940297821523d,bottom: 0.11803429790659303d,left: 0.03350193454347483d),
new NpgsqlTypes.NpgsqlBox(top: 0.9042123227154524d,right: 0.9850964520462807d,bottom: 0.7157708684376283d,left: 0.9097593652731806d),
new NpgsqlTypes.NpgsqlBox(top: 0.3679095819015459d,right: 0.9051078688583081d,bottom: 0.16465797375924118d,left: 0.8477382745177986d),
new NpgsqlTypes.NpgsqlBox(top: 0.7294187348655754d,right: 0.8429629876075759d,bottom: 0.24995408900338456d,left: 0.1333634837652442d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9937659605505365d,right: 0.938448595373226d,bottom: 0.9565282432630274d,left: 0.8723967926268448d),
new NpgsqlTypes.NpgsqlBox(top: 0.8840351443924319d,right: 0.4480732540555772d,bottom: 0.5160179751921019d,left: 0.16215602257230655d),
new NpgsqlTypes.NpgsqlBox(top: 0.3767971523228394d,right: 0.68152196921292d,bottom: 0.3359134608690464d,left: 0.5267932013518519d),
new NpgsqlTypes.NpgsqlBox(top: 0.7934937116087678d,right: 0.7875994998887272d,bottom: 0.09343194362355134d,left: 0.12661104124547273d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6571926529065989d,right: 0.7866452874865426d,bottom: 0.505145725167523d,left: 0.3169209915167719d),
new NpgsqlTypes.NpgsqlBox(top: 0.6019311913494463d,right: 0.13380185376802722d,bottom: 0.5251538770004897d,left: 0.07444687510278247d),
new NpgsqlTypes.NpgsqlBox(top: 0.8022325028428987d,right: 0.9992616719420534d,bottom: 0.3701365857593638d,left: 0.5858987286826598d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9742993454606512d,right: 0.363600718367983d,bottom: 0.7847904509482817d,left: 0.10989413239385482d),
new NpgsqlTypes.NpgsqlBox(top: 0.6616971888825476d,right: 0.8034300787171987d,bottom: 0.2306127082332694d,left: 0.24279748885408703d),
new NpgsqlTypes.NpgsqlBox(top: 0.8687849354084654d,right: 0.4716318197138587d,bottom: 0.13376785817061043d,left: 0.41892353133284843d),
new NpgsqlTypes.NpgsqlBox(top: 0.6537020441600018d,right: 0.7313727063606678d,bottom: 0.028292264051180016d,left: 0.41805438823953966d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.38143633574956193d,right: 0.8568897439995011d,bottom: 0.25772431303707266d,left: 0.6412653834880278d),
new NpgsqlTypes.NpgsqlBox(top: 0.9790352615723443d,right: 0.9773683863377606d,bottom: 0.1880672906338745d,left: 0.7112211470212381d),
new NpgsqlTypes.NpgsqlBox(top: 0.7032841958733319d,right: 0.611926205378789d,bottom: 0.439970431408784d,left: 0.35903355632494127d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7970233262417951d,right: 0.6513561013146248d,bottom: 0.24214467239342696d,left: 0.5194675732705215d),
new NpgsqlTypes.NpgsqlBox(top: 0.11468987866875924d,right: 0.4347626912451943d,bottom: 0.10486497601781308d,left: 0.07074106518772605d),
new NpgsqlTypes.NpgsqlBox(top: 0.6307374336560125d,right: 0.36848752753692116d,bottom: 0.5935613756990676d,left: 0.31443396257685374d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5040908801857711d,right: 0.4922854877453938d,bottom: 0.5031790473016198d,left: 0.3015514207602542d),
new NpgsqlTypes.NpgsqlBox(top: 0.6326600746300461d,right: 0.16554656107381982d,bottom: 0.32647140728626856d,left: 0.10177917869006858d),
new NpgsqlTypes.NpgsqlBox(top: 0.6278395017765331d,right: 0.884642972378206d,bottom: 0.343634427846238d,left: 0.46070878156042716d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7670798305910481d,right: 0.9922468412149836d,bottom: 0.2575156646611624d,left: 0.908137679028307d),
new NpgsqlTypes.NpgsqlBox(top: 0.5858825393609947d,right: 0.5549852260045133d,bottom: 0.18961150705322116d,left: 0.5139151674906336d),
new NpgsqlTypes.NpgsqlBox(top: 0.9615486009197087d,right: 0.18746738499181193d,bottom: 0.6265633421914446d,left: 0.10738838756717917d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9402713173560788d,right: 0.45720837074223697d,bottom: 0.5640258897782303d,left: 0.21356066216644654d),
new NpgsqlTypes.NpgsqlBox(top: 0.7604697985215214d,right: 0.9570636972151827d,bottom: 0.7349039640204201d,left: 0.0325789266420774d),
new NpgsqlTypes.NpgsqlBox(top: 0.5790496201931551d,right: 0.16252557191263517d,bottom: 0.22034539540491305d,left: 0.07261909472411165d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7968139026906201d,right: 0.14603491064258534d,bottom: 0.3162182853774106d,left: 0.06804316839440727d),
new NpgsqlTypes.NpgsqlBox(top: 0.9991462365976124d,right: 0.6710383610718424d,bottom: 0.9493581300075009d,left: 0.5402635556778865d),
new NpgsqlTypes.NpgsqlBox(top: 0.7376946023659277d,right: 0.31045604140591887d,bottom: 0.2013835602133427d,left: 0.25097773274211266d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4158731346892127d,right: 0.6527969472918437d,bottom: 0.229375237332209d,left: 0.2469133978643241d),
new NpgsqlTypes.NpgsqlBox(top: 0.5841615099124373d,right: 0.8517714487500062d,bottom: 0.10513903396960844d,left: 0.07669625983857697d),
new NpgsqlTypes.NpgsqlBox(top: 0.74786860472991d,right: 0.9473857793723971d,bottom: 0.2529509696065346d,left: 0.006350569949375995d),
new NpgsqlTypes.NpgsqlBox(top: 0.8149361359175075d,right: 0.9379850118687694d,bottom: 0.2341119245583032d,left: 0.3822122376964786d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7529737365784246d,right: 0.9988154176277717d,bottom: 0.3608672577511227d,left: 0.6988345715424874d),
new NpgsqlTypes.NpgsqlBox(top: 0.46705764006908057d,right: 0.6671541704496455d,bottom: 0.11382384253125932d,left: 0.14154383177258245d),
new NpgsqlTypes.NpgsqlBox(top: 0.3634800365525921d,right: 0.3585737504898012d,bottom: 0.31899852306897036d,left: 0.07570098499021871d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6866525846919093d,right: 0.6463870128657455d,bottom: 0.4259989115854138d,left: 0.3898293783520794d),
new NpgsqlTypes.NpgsqlBox(top: 0.5489805900412895d,right: 0.8825057517694582d,bottom: 0.372540531214295d,left: 0.5725992852885011d),
new NpgsqlTypes.NpgsqlBox(top: 0.955092425515567d,right: 0.5274300366509225d,bottom: 0.7628323030977884d,left: 0.19211963676731503d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3638311171132046d,right: 0.36053954188053894d,bottom: 0.039071691814911325d,left: 0.27772439311586006d),
new NpgsqlTypes.NpgsqlBox(top: 0.541804013118132d,right: 0.6448206133243861d,bottom: 0.016412414574552447d,left: 0.5015051151996057d),
new NpgsqlTypes.NpgsqlBox(top: 0.8848086127527169d,right: 0.47175899999658677d,bottom: 0.27224302384636456d,left: 0.25037868581380174d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5983751399514804d,right: 0.746615442328496d,bottom: 0.21854196118868596d,left: 0.12212433340302364d),
new NpgsqlTypes.NpgsqlBox(top: 0.9027075532746207d,right: 0.7387289843486268d,bottom: 0.8473519125469029d,left: 0.3111888015347969d),
new NpgsqlTypes.NpgsqlBox(top: 0.6098117417474336d,right: 0.6743938775975593d,bottom: 0.1763230192019306d,left: 0.3151152771654928d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8065084801140345d,right: 0.9109618331782249d,bottom: 0.7798750126066724d,left: 0.7072756174557894d),
new NpgsqlTypes.NpgsqlBox(top: 0.8483444251764433d,right: 0.6325945718454347d,bottom: 0.6506465083468397d,left: 0.2537782855260543d),
new NpgsqlTypes.NpgsqlBox(top: 0.4930796928149468d,right: 0.7414018148460217d,bottom: 0.07216056630037249d,left: 0.04285608534567231d),
new NpgsqlTypes.NpgsqlBox(top: 0.0386841144483161d,right: 0.5345609556835857d,bottom: 0.03585031008661743d,left: 0.3713292641296777d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8155879038469955d,right: 0.7884332336027082d,bottom: 0.6729571773024856d,left: 0.3720024393628478d),
new NpgsqlTypes.NpgsqlBox(top: 0.7459214455876603d,right: 0.617001893160781d,bottom: 0.07677944543804383d,left: 0.5626989831674126d),
new NpgsqlTypes.NpgsqlBox(top: 0.8855443972188116d,right: 0.549455766295494d,bottom: 0.46195311908608105d,left: 0.4591527529670629d),
new NpgsqlTypes.NpgsqlBox(top: 0.9132701619510001d,right: 0.8892201416951733d,bottom: 0.55971598636534d,left: 0.6898660454130664d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.43123488325473014d,right: 0.9814416982890275d,bottom: 0.2118606347320069d,left: 0.29671853184100305d),
new NpgsqlTypes.NpgsqlBox(top: 0.4099432870245938d,right: 0.4108951657135531d,bottom: 0.3640593640533585d,left: 0.3976431978409458d),
new NpgsqlTypes.NpgsqlBox(top: 0.3804104213396349d,right: 0.8231165385392455d,bottom: 0.11728534620813769d,left: 0.2479544334959376d),
new NpgsqlTypes.NpgsqlBox(top: 0.25866725097240495d,right: 0.688400535030711d,bottom: 0.21007610297345258d,left: 0.562917796047386d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3534103472895098d,right: 0.9428877250524134d,bottom: 0.22584504325630073d,left: 0.0065328075589289325d),
new NpgsqlTypes.NpgsqlBox(top: 0.6632092464338185d,right: 0.5689511612388104d,bottom: 0.4067823368042186d,left: 0.4683566470325531d),
new NpgsqlTypes.NpgsqlBox(top: 0.512458977288914d,right: 0.921517259980934d,bottom: 0.34867211143033605d,left: 0.5985751267193277d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9119370611113141d,right: 0.9974590224017145d,bottom: 0.44709958701929986d,left: 0.9458161069261242d),
new NpgsqlTypes.NpgsqlBox(top: 0.9718260226359331d,right: 0.48433734705734555d,bottom: 0.9113248830424173d,left: 0.4123807466098415d),
new NpgsqlTypes.NpgsqlBox(top: 0.8711343913770555d,right: 0.7605278223129948d,bottom: 0.8219268635848175d,left: 0.48534839645277805d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6922708397529326d,right: 0.7555789734047443d,bottom: 0.3335164023488263d,left: 0.20316813999061967d),
new NpgsqlTypes.NpgsqlBox(top: 0.22447021623009222d,right: 0.4427649351786951d,bottom: 0.04602609307199079d,left: 0.3219982650956813d),
new NpgsqlTypes.NpgsqlBox(top: 0.31906083236830474d,right: 0.8915883048390292d,bottom: 0.10103950149419494d,left: 0.20958710235735656d),
new NpgsqlTypes.NpgsqlBox(top: 0.6173624404496261d,right: 0.815087966088257d,bottom: 0.19333588894406128d,left: 0.320355923080583d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4868481161616178d,right: 0.9367071965011368d,bottom: 0.4820186652954601d,left: 0.08279664534788045d),
new NpgsqlTypes.NpgsqlBox(top: 0.7547962290245657d,right: 0.546617945794048d,bottom: 0.38492854806967025d,left: 0.4911084934155737d),
new NpgsqlTypes.NpgsqlBox(top: 0.6364740210697354d,right: 0.8654710491880362d,bottom: 0.5115410069873693d,left: 0.7092911773549433d),
new NpgsqlTypes.NpgsqlBox(top: 0.3956248793001692d,right: 0.4133322743961386d,bottom: 0.029820947450201696d,left: 0.35484943105515265d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8942293838100998d,right: 0.8602732998210404d,bottom: 0.009590542100680555d,left: 0.5879177274439322d),
new NpgsqlTypes.NpgsqlBox(top: 0.5857464909898963d,right: 0.666817770562055d,bottom: 0.23096771889043155d,left: 0.2648395307387815d),
new NpgsqlTypes.NpgsqlBox(top: 0.33474665351564414d,right: 0.45387969547759643d,bottom: 0.04662374155276661d,left: 0.2742087147989797d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5649327099405673d,right: 0.9110600513241915d,bottom: 0.5595854119754129d,left: 0.4829691653914707d),
new NpgsqlTypes.NpgsqlBox(top: 0.6123768325903041d,right: 0.7542437982265058d,bottom: 0.20202464444720936d,left: 0.4704292913922987d),
new NpgsqlTypes.NpgsqlBox(top: 0.9688114574428826d,right: 0.811195551906944d,bottom: 0.6784238198532697d,left: 0.7830138498611572d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.35994134118469556d,right: 0.6465754647986969d,bottom: 0.06016059210347735d,left: 0.369482125605359d),
new NpgsqlTypes.NpgsqlBox(top: 0.8197759189302317d,right: 0.8706188122993005d,bottom: 0.6336359137823591d,left: 0.4074939470939636d),
new NpgsqlTypes.NpgsqlBox(top: 0.8634856970895342d,right: 0.5218954373801257d,bottom: 0.20317740494578596d,left: 0.12585233168276566d),
new NpgsqlTypes.NpgsqlBox(top: 0.2716195713203927d,right: 0.34624204540742265d,bottom: 0.13359929445962926d,left: 0.310510731066578d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8279356241803671d,right: 0.5938956231742881d,bottom: 0.3718407675491805d,left: 0.5056388350292602d),
new NpgsqlTypes.NpgsqlBox(top: 0.4032661586416325d,right: 0.1288776959328145d,bottom: 0.3272109079951723d,left: 0.046210373656239034d),
new NpgsqlTypes.NpgsqlBox(top: 0.4610674428384893d,right: 0.8347614151141379d,bottom: 0.014357371724128987d,left: 0.3451667082657033d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49599571315897606d,right: 0.453292273651402d,bottom: 0.0168792410237234d,left: 0.1456534262429291d),
new NpgsqlTypes.NpgsqlBox(top: 0.9966396931414242d,right: 0.31460748955360707d,bottom: 0.7961343594432604d,left: 0.03596241541328449d),
new NpgsqlTypes.NpgsqlBox(top: 0.7669106668359079d,right: 0.8909217659913132d,bottom: 0.5434471012698647d,left: 0.4668729932304191d),
new NpgsqlTypes.NpgsqlBox(top: 0.9845494738519722d,right: 0.5801416508775395d,bottom: 0.43883645451706155d,left: 0.4118540699604767d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5483079638242526d,right: 0.8888484747365231d,bottom: 0.018332670356896563d,left: 0.07713216861918049d),
new NpgsqlTypes.NpgsqlBox(top: 0.4210743818103243d,right: 0.5005651657484409d,bottom: 0.4008617964136625d,left: 0.3573213076413625d),
new NpgsqlTypes.NpgsqlBox(top: 0.7011674012715646d,right: 0.6884773396892528d,bottom: 0.5912001018871268d,left: 0.051726913311988754d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8983087979224024d,right: 0.692614190943638d,bottom: 0.7801340812775578d,left: 0.2757396831738256d),
new NpgsqlTypes.NpgsqlBox(top: 0.2828959503140961d,right: 0.6638270250845625d,bottom: 0.09462691371930732d,left: 0.11609284229086392d),
new NpgsqlTypes.NpgsqlBox(top: 0.657371202955193d,right: 0.6242774245924346d,bottom: 0.6230215126305929d,left: 0.20845381875043667d),
new NpgsqlTypes.NpgsqlBox(top: 0.9075255542248247d,right: 0.7203617778779492d,bottom: 0.25003876453289453d,left: 0.6373789359343004d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6439110496525257d,right: 0.8404085923796466d,bottom: 0.3475160643376385d,left: 0.671253395792941d),
new NpgsqlTypes.NpgsqlBox(top: 0.4116276666072609d,right: 0.9580671326692104d,bottom: 0.3965356197259663d,left: 0.3461917161338014d),
new NpgsqlTypes.NpgsqlBox(top: 0.5861253591166032d,right: 0.6646475497156353d,bottom: 0.4007134220107009d,left: 0.12150589575375648d),
new NpgsqlTypes.NpgsqlBox(top: 0.34847226798023645d,right: 0.6945683380957076d,bottom: 0.10945040517711502d,left: 0.28640593167955986d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8903999340654716d,right: 0.47804125744890213d,bottom: 0.8057702229845121d,left: 0.3297534453537364d),
new NpgsqlTypes.NpgsqlBox(top: 0.8093055925027884d,right: 0.7787891251957249d,bottom: 0.12973886693814252d,left: 0.17115687405384228d),
new NpgsqlTypes.NpgsqlBox(top: 0.8339083602493347d,right: 0.5627117702742604d,bottom: 0.7248247925626347d,left: 0.4033060617841885d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9435333683494714d,right: 0.9783839524329724d,bottom: 0.21782994884379314d,left: 0.7565259201886466d),
new NpgsqlTypes.NpgsqlBox(top: 0.36504595730859457d,right: 0.69754834835126d,bottom: 0.354063112974372d,left: 0.5060573387222213d),
new NpgsqlTypes.NpgsqlBox(top: 0.2611481434170745d,right: 0.8840587302582622d,bottom: 0.2596278970721093d,left: 0.26231700872426555d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7846483790366853d,right: 0.6862481865078275d,bottom: 0.4929544944490959d,left: 0.010093217869147963d),
new NpgsqlTypes.NpgsqlBox(top: 0.7229187840012952d,right: 0.6387130946185338d,bottom: 0.10962464651413273d,left: 0.5285203537702117d),
new NpgsqlTypes.NpgsqlBox(top: 0.7337279257379449d,right: 0.9477415504160274d,bottom: 0.1986008224257021d,left: 0.6277513239145254d),
new NpgsqlTypes.NpgsqlBox(top: 0.7450464083583205d,right: 0.9937782716189822d,bottom: 0.48017766832720177d,left: 0.9537456373382485d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8879159010975697d,right: 0.4713370380575831d,bottom: 0.4036776909719917d,left: 0.33500632148265963d),
new NpgsqlTypes.NpgsqlBox(top: 0.8345309138920197d,right: 0.6118235253006601d,bottom: 0.3219008336380671d,left: 0.1878259074476566d),
new NpgsqlTypes.NpgsqlBox(top: 0.46264164237399563d,right: 0.39337026241168094d,bottom: 0.010776249957779593d,left: 0.35418934175597305d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8641983292041343d,right: 0.7485345463959261d,bottom: 0.2602713925861888d,left: 0.1985649050300372d),
new NpgsqlTypes.NpgsqlBox(top: 0.9092445609430012d,right: 0.8888080007002688d,bottom: 0.34260081691610544d,left: 0.5226090612630825d),
new NpgsqlTypes.NpgsqlBox(top: 0.3575765176831587d,right: 0.9470071003750046d,bottom: 0.19227662356514386d,left: 0.03414248185748203d),
new NpgsqlTypes.NpgsqlBox(top: 0.6892413109607564d,right: 0.8646648666259168d,bottom: 0.033956420886200545d,left: 0.23112128706702428d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.858918735566618d,right: 0.19690001035997118d,bottom: 0.35047628442874d,left: 0.0013132458536656566d),
new NpgsqlTypes.NpgsqlBox(top: 0.5520522072239267d,right: 0.3428023389383341d,bottom: 0.27530675194423004d,left: 0.17492334966507805d),
new NpgsqlTypes.NpgsqlBox(top: 0.7717351729565309d,right: 0.911632068425286d,bottom: 0.6889897085244651d,left: 0.4435413554502299d),
new NpgsqlTypes.NpgsqlBox(top: 0.7484817624859235d,right: 0.7094154563250782d,bottom: 0.4290356703699296d,left: 0.012292508936404545d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9747999754594358d,right: 0.7631263760941779d,bottom: 0.760138345072602d,left: 0.1617449331839782d),
new NpgsqlTypes.NpgsqlBox(top: 0.9152568338704522d,right: 0.9962148466356809d,bottom: 0.8362112024221322d,left: 0.5845106715555841d),
new NpgsqlTypes.NpgsqlBox(top: 0.8967768207333642d,right: 0.8159766631872769d,bottom: 0.6320526028644043d,left: 0.1211599497178314d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3255881574990547d,right: 0.5966166722784891d,bottom: 0.014418625340490987d,left: 0.4194135660946333d),
new NpgsqlTypes.NpgsqlBox(top: 0.8229900166829756d,right: 0.574605578978829d,bottom: 0.7386770092736873d,left: 0.06385193488019703d),
new NpgsqlTypes.NpgsqlBox(top: 0.6777679726080229d,right: 0.9113266217032304d,bottom: 0.5631426024187554d,left: 0.5082221596843729d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9801187454145014d,right: 0.5851704638655791d,bottom: 0.49350481415004765d,left: 0.12273458901834977d),
new NpgsqlTypes.NpgsqlBox(top: 0.8232519522185762d,right: 0.6764208414240409d,bottom: 0.05312759776247d,left: 0.0816342620445587d),
new NpgsqlTypes.NpgsqlBox(top: 0.8799709424352166d,right: 0.9969369258402622d,bottom: 0.5108556749558536d,left: 0.297531201820473d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.04605549965055078d,right: 0.3183169413140632d,bottom: 0.03366036509113046d,left: 0.07279857512396348d),
new NpgsqlTypes.NpgsqlBox(top: 0.12473271947669529d,right: 0.30302040617406445d,bottom: 0.11133376962626507d,left: 0.2910593129942711d),
new NpgsqlTypes.NpgsqlBox(top: 0.9046070762462811d,right: 0.8532939283851465d,bottom: 0.3339128840529566d,left: 0.6841835714509685d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
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
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.12422845810761596d,right: 0.8282654747154764d,bottom: 0.07570386658750339d,left: 0.3361962057514958d),
new NpgsqlTypes.NpgsqlBox(top: 0.2983596616884505d,right: 0.37365614089348276d,bottom: 0.23525801596834406d,left: 0.04287317690471937d),
new NpgsqlTypes.NpgsqlBox(top: 0.5572512720456875d,right: 0.5026434080909371d,bottom: 0.1853539599455677d,left: 0.33135357250505115d),
new NpgsqlTypes.NpgsqlBox(top: 0.930167131654684d,right: 0.7659897829721083d,bottom: 0.370404827692819d,left: 0.6921080114864306d),
}));
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7360038636052882d,right: 0.5032010392004007d,bottom: 0.2843439133504315d,left: 0.33210012411530765d),
new NpgsqlTypes.NpgsqlBox(top: 0.41181612166121007d,right: 0.8830355224306017d,bottom: 0.3238133730147492d,left: 0.20886422772295554d),
new NpgsqlTypes.NpgsqlBox(top: 0.09009617601828912d,right: 0.9817802941559588d,bottom: 0.028295673286752532d,left: 0.4992617826934024d),
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4645549710795791d,right: 0.9330836764877342d,bottom: 0.08706337320100432d,left: 0.04098348881764824d),
new NpgsqlTypes.NpgsqlBox(top: 0.6091942584443136d,right: 0.37078546652218736d,bottom: 0.0059909385390992664d,left: 0.3656385259324684d),
new NpgsqlTypes.NpgsqlBox(top: 0.8805302318867012d,right: 0.849559035858525d,bottom: 0.0773886192584502d,left: 0.208760345778094d),
new NpgsqlTypes.NpgsqlBox(top: 0.9497875347541955d,right: 0.5885970917286509d,bottom: 0.40967184320802297d,left: 0.2168910315782776d),
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6694575204372025d,right: 0.8962766156839799d,bottom: 0.014678812872671032d,left: 0.7890968327155317d),
new NpgsqlTypes.NpgsqlBox(top: 0.5485120561836538d,right: 0.8326969427901696d,bottom: 0.36118662564171067d,left: 0.6966011349371222d),
new NpgsqlTypes.NpgsqlBox(top: 0.9173659221073094d,right: 0.5267385167370794d,bottom: 0.3377221992839301d,left: 0.2524569105901977d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.784138673266883d,right: 0.544397764705575d,bottom: 0.38073794441438435d,left: 0.10555196157432478d),
new NpgsqlTypes.NpgsqlBox(top: 0.586583677095079d,right: 0.37049258786621053d,bottom: 0.28649029506334345d,left: 0.3037449631764052d),
new NpgsqlTypes.NpgsqlBox(top: 0.9392273014513765d,right: 0.26633442823233433d,bottom: 0.22613087991036507d,left: 0.03675313304960737d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9623172861315711d,right: 0.313426646270749d,bottom: 0.772834124053366d,left: 0.18394786864113843d),
new NpgsqlTypes.NpgsqlBox(top: 0.46817832439653495d,right: 0.6665804075115634d,bottom: 0.3284443858875945d,left: 0.4009352740684714d),
new NpgsqlTypes.NpgsqlBox(top: 0.6569417003747059d,right: 0.7705892682654492d,bottom: 0.45956963418477614d,left: 0.5511068078217053d),
new NpgsqlTypes.NpgsqlBox(top: 0.19241293061906362d,right: 0.789405823975982d,bottom: 0.04171273050805624d,left: 0.5803697727682078d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9884962928651182d,right: 0.7599923669243009d,bottom: 0.4874779902044958d,left: 0.6082902935214788d),
new NpgsqlTypes.NpgsqlBox(top: 0.9137844590944824d,right: 0.8481661070265604d,bottom: 0.30790477531671645d,left: 0.6166759268159634d),
new NpgsqlTypes.NpgsqlBox(top: 0.45104767290305336d,right: 0.5314466725978678d,bottom: 0.10496014791996333d,left: 0.25635370977782623d),
}));
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 85, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 124, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatchAsync(connection, 127, 62))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatch(connection, 85, 1))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 78);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1M>(15);

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
                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

