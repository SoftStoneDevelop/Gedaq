

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5847722747933105d, b: 0.2365674398606531d, c: 0.8933723685465087d),
new NpgsqlTypes.NpgsqlLine(a: 0.05133502049366134d, b: 0.6979495145571056d, c: 0.7551343291636401d),
new NpgsqlTypes.NpgsqlLine(a: 0.10257171835235357d, b: 0.7848124210293598d, c: 0.8870448444327953d),
new NpgsqlTypes.NpgsqlLine(a: 0.07962191419864606d, b: 0.05023667673907106d, c: 0.22556680114257455d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4435327720776806d, b: 0.7430190042656992d, c: 0.15492196032788008d),
new NpgsqlTypes.NpgsqlLine(a: 0.9036221186255267d, b: 0.5857542217618259d, c: 0.722428299436237d),
new NpgsqlTypes.NpgsqlLine(a: 0.7147303361240822d, b: 0.06452111297547325d, c: 0.528659880363152d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33488432344103425d, b: 0.8639870660257563d, c: 0.9894650963410081d),
new NpgsqlTypes.NpgsqlLine(a: 0.43441157857023394d, b: 0.5331158165010835d, c: 0.5271971622232237d),
new NpgsqlTypes.NpgsqlLine(a: 0.8533019204014433d, b: 0.12413847016383683d, c: 0.16550636814797437d),
new NpgsqlTypes.NpgsqlLine(a: 0.31161130453220154d, b: 0.2653445523300546d, c: 0.5870782927379903d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.36723784389847447d, b: 0.8756642552804357d, c: 0.7889079021547694d),
new NpgsqlTypes.NpgsqlLine(a: 0.43721539955774047d, b: 0.5488662952839143d, c: 0.10669173579408853d),
new NpgsqlTypes.NpgsqlLine(a: 0.017380871269798814d, b: 0.8934152705994912d, c: 0.16046474585420534d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18845496226041603d, b: 0.4633584915614233d, c: 0.8086548789813375d),
new NpgsqlTypes.NpgsqlLine(a: 0.907553387062203d, b: 0.9346639851326595d, c: 0.6815566979035029d),
new NpgsqlTypes.NpgsqlLine(a: 0.7581745737996534d, b: 0.82986970113588d, c: 0.9494526191803989d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08413178631059726d, b: 0.44525387126529214d, c: 0.6847450613571974d),
new NpgsqlTypes.NpgsqlLine(a: 0.2040180265113053d, b: 0.2811853240344828d, c: 0.21038507278766394d),
new NpgsqlTypes.NpgsqlLine(a: 0.7602873553281004d, b: 0.39942271980213373d, c: 0.18862263456496564d),
new NpgsqlTypes.NpgsqlLine(a: 0.6546088050831433d, b: 0.7313257628383437d, c: 0.22331885141336738d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28259570488414587d, b: 0.32392232775716745d, c: 0.7454785861406351d),
new NpgsqlTypes.NpgsqlLine(a: 0.20725182208225845d, b: 0.7661404467824949d, c: 0.4902525044158017d),
new NpgsqlTypes.NpgsqlLine(a: 0.48009896841115596d, b: 0.42601009892814123d, c: 0.003353279704191414d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8360952705031678d, b: 0.6232353797088179d, c: 0.8566663023471182d),
new NpgsqlTypes.NpgsqlLine(a: 0.20035705744469734d, b: 0.39640883128922544d, c: 0.8622723716628218d),
new NpgsqlTypes.NpgsqlLine(a: 0.4098074898702746d, b: 0.4133113270937434d, c: 0.5936240205115687d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9200562292341056d, b: 0.6356449771859843d, c: 0.49968958675950703d),
new NpgsqlTypes.NpgsqlLine(a: 0.6332168311019207d, b: 0.65566217497792d, c: 0.47922325083584183d),
new NpgsqlTypes.NpgsqlLine(a: 0.34499642847562295d, b: 0.12486842363439021d, c: 0.38744729378620746d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2621871362763275d, b: 0.528358117317691d, c: 0.7239558085249431d),
new NpgsqlTypes.NpgsqlLine(a: 0.26575674998605103d, b: 0.5578134985873588d, c: 0.9083402538468265d),
new NpgsqlTypes.NpgsqlLine(a: 0.40770093517784667d, b: 0.5240460870543847d, c: 0.4715164027264628d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29102114697878956d, b: 0.5777326322496367d, c: 0.8107904850417371d),
new NpgsqlTypes.NpgsqlLine(a: 0.1335734783911079d, b: 0.8911676015965553d, c: 0.7407261916179363d),
new NpgsqlTypes.NpgsqlLine(a: 0.4763853618633297d, b: 0.16958487404575162d, c: 0.13448693887390395d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2626777506373107d, b: 0.21913862315121269d, c: 0.8248582364180425d),
new NpgsqlTypes.NpgsqlLine(a: 0.26345490026422924d, b: 0.9366661205978781d, c: 0.650734325471885d),
new NpgsqlTypes.NpgsqlLine(a: 0.623105241124593d, b: 0.8991414554482015d, c: 0.8442277246584443d),
new NpgsqlTypes.NpgsqlLine(a: 0.1985964578967112d, b: 0.3649315792943303d, c: 0.8165407586820884d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07436444884038951d, b: 0.4717087472235013d, c: 0.055759282862418824d),
new NpgsqlTypes.NpgsqlLine(a: 0.797558833254463d, b: 0.0769979843513281d, c: 0.473840107253928d),
new NpgsqlTypes.NpgsqlLine(a: 0.8223595498827573d, b: 0.16255322676410133d, c: 0.47825540933288924d),
new NpgsqlTypes.NpgsqlLine(a: 0.06173023010815515d, b: 0.6117801739483747d, c: 0.6382261553435242d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8078606848417665d, b: 0.08531800044505322d, c: 0.770372757156655d),
new NpgsqlTypes.NpgsqlLine(a: 0.12738134694691305d, b: 0.005720536625723471d, c: 0.5363272262856199d),
new NpgsqlTypes.NpgsqlLine(a: 0.46173390365171274d, b: 0.9578882241603215d, c: 0.546809114868469d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6518779826731147d, b: 0.9930407542690245d, c: 0.9674451450689103d),
new NpgsqlTypes.NpgsqlLine(a: 0.2932869458634433d, b: 0.6069475470130521d, c: 0.8342485572872784d),
new NpgsqlTypes.NpgsqlLine(a: 0.03941607933681179d, b: 0.9968476594998315d, c: 0.5502896121669683d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6366732279643562d, b: 0.8106530547480632d, c: 0.5466542261924485d),
new NpgsqlTypes.NpgsqlLine(a: 0.198376663082503d, b: 0.8965393839229083d, c: 0.8921720211788663d),
new NpgsqlTypes.NpgsqlLine(a: 0.06770633852932217d, b: 0.6561584829631621d, c: 0.8049602224670956d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25178202113611214d, b: 0.18257695099345095d, c: 0.765207192293358d),
new NpgsqlTypes.NpgsqlLine(a: 0.7822801343370541d, b: 0.2570417216120712d, c: 0.3390471364125457d),
new NpgsqlTypes.NpgsqlLine(a: 0.005518285397919875d, b: 0.7426563655607546d, c: 0.6048082088697403d),
new NpgsqlTypes.NpgsqlLine(a: 0.47332160540819057d, b: 0.810482857343758d, c: 0.8326295776726444d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28961244298371835d, b: 0.4751712173027812d, c: 0.7393577326629345d),
new NpgsqlTypes.NpgsqlLine(a: 0.3018761758942077d, b: 0.2514960337164316d, c: 0.6606699052541098d),
new NpgsqlTypes.NpgsqlLine(a: 0.4838966532685529d, b: 0.690395663962448d, c: 0.20846403989772988d),
new NpgsqlTypes.NpgsqlLine(a: 0.1922946963526192d, b: 0.8167027214802516d, c: 0.3571584204837591d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40493674452054607d, b: 0.5017038684963985d, c: 0.5250492533920617d),
new NpgsqlTypes.NpgsqlLine(a: 0.9297684541727301d, b: 0.9630743348164245d, c: 0.4108526971066647d),
new NpgsqlTypes.NpgsqlLine(a: 0.19358565074994016d, b: 0.536856990101136d, c: 0.525905936839518d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32675186382763877d, b: 0.5824066185800859d, c: 0.6832393749522342d),
new NpgsqlTypes.NpgsqlLine(a: 0.20036178153316542d, b: 0.77647471459415d, c: 0.8044880427178757d),
new NpgsqlTypes.NpgsqlLine(a: 0.6198747428569679d, b: 0.31878982487080443d, c: 0.2652533400066306d),
new NpgsqlTypes.NpgsqlLine(a: 0.22049913929025877d, b: 0.263058893942677d, c: 0.7724831056089789d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22469774953747723d, b: 0.5717575657650138d, c: 0.4586079576269554d),
new NpgsqlTypes.NpgsqlLine(a: 0.1941053060463871d, b: 0.12970613241338913d, c: 0.28198893825517446d),
new NpgsqlTypes.NpgsqlLine(a: 0.41202578657421995d, b: 0.5169944890494714d, c: 0.12072995463463598d),
new NpgsqlTypes.NpgsqlLine(a: 0.6344324056591596d, b: 0.09469592631923196d, c: 0.7911073974280906d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.77541866909597d, b: 0.9527665803026916d, c: 0.051600431232305066d),
new NpgsqlTypes.NpgsqlLine(a: 0.5406747109165838d, b: 0.30505345916750815d, c: 0.02216568199806379d),
new NpgsqlTypes.NpgsqlLine(a: 0.22148635133325967d, b: 0.041811545873627565d, c: 0.14618002623510906d),
new NpgsqlTypes.NpgsqlLine(a: 0.17218042296191738d, b: 0.14523610253360064d, c: 0.6780543711945102d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3694075948501585d, b: 0.7015837704539346d, c: 0.6189590152038927d),
new NpgsqlTypes.NpgsqlLine(a: 0.7841336733741994d, b: 0.15212478142664154d, c: 0.392263218252049d),
new NpgsqlTypes.NpgsqlLine(a: 0.15743798908461215d, b: 0.0696816290666803d, c: 0.18512960422774571d),
new NpgsqlTypes.NpgsqlLine(a: 0.229803163233671d, b: 0.139135341148362d, c: 0.5979393136748486d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8792535041506391d, b: 0.29665741661737166d, c: 0.11100868871237879d),
new NpgsqlTypes.NpgsqlLine(a: 0.45570989997070843d, b: 0.620272540620475d, c: 0.7195659059256102d),
new NpgsqlTypes.NpgsqlLine(a: 0.14492057628448107d, b: 0.9018891145677768d, c: 0.06420223967368988d),
new NpgsqlTypes.NpgsqlLine(a: 0.6710007739719913d, b: 0.6668711729714295d, c: 0.18379335712467326d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9882286541867676d, b: 0.5579512382870755d, c: 0.6733175182676452d),
new NpgsqlTypes.NpgsqlLine(a: 0.41360508818889297d, b: 0.028573417519427546d, c: 0.8513811517615963d),
new NpgsqlTypes.NpgsqlLine(a: 0.16632470410773326d, b: 0.7105381342436213d, c: 0.5807463905003922d),
new NpgsqlTypes.NpgsqlLine(a: 0.4107918039560252d, b: 0.6387745886681574d, c: 0.3450968211377933d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39650179050561274d, b: 0.5720142646150732d, c: 0.5626940973389607d),
new NpgsqlTypes.NpgsqlLine(a: 0.5116423696453897d, b: 0.480285079672786d, c: 0.5129463192130068d),
new NpgsqlTypes.NpgsqlLine(a: 0.8143084848060522d, b: 0.992267305966781d, c: 0.8056010078370773d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01670335326950212d, b: 0.8865917221860109d, c: 0.6021008231847255d),
new NpgsqlTypes.NpgsqlLine(a: 0.624560945410661d, b: 0.8107821260045607d, c: 0.7021396182981305d),
new NpgsqlTypes.NpgsqlLine(a: 0.030267700942018028d, b: 0.5986837964480682d, c: 0.31967186160923367d),
new NpgsqlTypes.NpgsqlLine(a: 0.6731809331049315d, b: 0.2786816266797838d, c: 0.0069987411840900515d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4293400281281835d, b: 0.2989815039244682d, c: 0.6651808015618238d),
new NpgsqlTypes.NpgsqlLine(a: 0.0713573460243937d, b: 0.6464155632681876d, c: 0.018103359910408123d),
new NpgsqlTypes.NpgsqlLine(a: 0.6418415867802847d, b: 0.7508418327552443d, c: 0.15654433129978296d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8625877818308401d, b: 0.22926924100031376d, c: 0.42285358073169654d),
new NpgsqlTypes.NpgsqlLine(a: 0.9862538067546334d, b: 0.9667316768686111d, c: 0.12543630299816433d),
new NpgsqlTypes.NpgsqlLine(a: 0.6182411880946415d, b: 0.9406237809950728d, c: 0.11966095117055542d),
new NpgsqlTypes.NpgsqlLine(a: 0.1969765271697118d, b: 0.5016566158131797d, c: 0.8957689672303321d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.03064007099611843d, b: 0.5590538283578118d, c: 0.9120945371510241d),
new NpgsqlTypes.NpgsqlLine(a: 0.8021305378238263d, b: 0.9983460806066917d, c: 0.394467351202651d),
new NpgsqlTypes.NpgsqlLine(a: 0.34444855628822024d, b: 0.6189634603294459d, c: 0.9301721709494505d),
new NpgsqlTypes.NpgsqlLine(a: 0.5162093125025831d, b: 0.4984534921985605d, c: 0.9261350260839729d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.36557604199857696d, b: 0.3409741007609085d, c: 0.32053208824917023d),
new NpgsqlTypes.NpgsqlLine(a: 0.7054549974486433d, b: 0.2069243184446442d, c: 0.48856086286052935d),
new NpgsqlTypes.NpgsqlLine(a: 0.957766759170447d, b: 0.7296147548443175d, c: 0.7033971953922306d),
new NpgsqlTypes.NpgsqlLine(a: 0.010668384739844439d, b: 0.41230535730846063d, c: 0.5273372889195133d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12231866652560563d, b: 0.13777782289962248d, c: 0.25765027745767977d),
new NpgsqlTypes.NpgsqlLine(a: 0.2086064514259428d, b: 0.4052008552578832d, c: 0.8783034611491585d),
new NpgsqlTypes.NpgsqlLine(a: 0.49174762856032905d, b: 0.1894560039325509d, c: 0.8379040138219993d),
new NpgsqlTypes.NpgsqlLine(a: 0.2892064409803278d, b: 0.9723590447563768d, c: 0.44646200089919963d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10687032087151893d, b: 0.03416349918199524d, c: 0.12253778816092142d),
new NpgsqlTypes.NpgsqlLine(a: 0.37065550886259047d, b: 0.8656623630844107d, c: 0.2687117321813435d),
new NpgsqlTypes.NpgsqlLine(a: 0.7084725041016133d, b: 0.6231386435346423d, c: 0.34688255015057423d),
new NpgsqlTypes.NpgsqlLine(a: 0.4559770723385915d, b: 0.8235753581378836d, c: 0.9678685677603704d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32981192404265314d, b: 0.7994576972379038d, c: 0.1270144211564288d),
new NpgsqlTypes.NpgsqlLine(a: 0.4696966722288526d, b: 0.0823646836519083d, c: 0.9816026785531289d),
new NpgsqlTypes.NpgsqlLine(a: 0.6936707332808792d, b: 0.22028418426075513d, c: 0.4684411058454777d),
new NpgsqlTypes.NpgsqlLine(a: 0.8215974703266834d, b: 0.38421145205679386d, c: 0.2908591867630139d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1416007187021634d, b: 0.4256876879406224d, c: 0.030968950253568384d),
new NpgsqlTypes.NpgsqlLine(a: 0.915356000273161d, b: 0.08129412169668604d, c: 0.9743438790753842d),
new NpgsqlTypes.NpgsqlLine(a: 0.8433266663342182d, b: 0.3357471505639301d, c: 0.9827942974358328d),
new NpgsqlTypes.NpgsqlLine(a: 0.9685702354638074d, b: 0.1483519967070901d, c: 0.8813270924377916d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24691614167996767d, b: 0.7993578768290687d, c: 0.6594492192323221d),
new NpgsqlTypes.NpgsqlLine(a: 0.34988262601261855d, b: 0.08959428148883719d, c: 0.5181405161240029d),
new NpgsqlTypes.NpgsqlLine(a: 0.49048526433068873d, b: 0.24466994564648248d, c: 0.6880929078436723d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9054466787573903d, b: 0.599641200582577d, c: 0.7176763053790358d),
new NpgsqlTypes.NpgsqlLine(a: 0.39177293996033447d, b: 0.1408958163362264d, c: 0.20832603140376527d),
new NpgsqlTypes.NpgsqlLine(a: 0.29837747076292387d, b: 0.2260632686690881d, c: 0.46337780866116873d),
new NpgsqlTypes.NpgsqlLine(a: 0.40292827500081363d, b: 0.7880381200411326d, c: 0.8705086860348967d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.569418656749006d, b: 0.5029216941014342d, c: 0.595763154405931d),
new NpgsqlTypes.NpgsqlLine(a: 0.9039175637742445d, b: 0.26923855829353316d, c: 0.1353529882706842d),
new NpgsqlTypes.NpgsqlLine(a: 0.5245192242164752d, b: 0.31292692392224863d, c: 0.4682707372017826d),
new NpgsqlTypes.NpgsqlLine(a: 0.43551771972262965d, b: 0.5878364702417991d, c: 0.7404234140073432d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6726108121090704d, b: 0.1523725925128746d, c: 0.45785670501111986d),
new NpgsqlTypes.NpgsqlLine(a: 0.2714205054757214d, b: 0.7308198871006325d, c: 0.5980988056284984d),
new NpgsqlTypes.NpgsqlLine(a: 0.08019165410859375d, b: 0.301320156598581d, c: 0.0778835244731102d),
new NpgsqlTypes.NpgsqlLine(a: 0.5217658567525918d, b: 0.46055875623355425d, c: 0.17977206273681579d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7831879382468084d, b: 0.5736575287212932d, c: 0.64994562999031d),
new NpgsqlTypes.NpgsqlLine(a: 0.6241540581991467d, b: 0.8347110623518798d, c: 0.05564611535505182d),
new NpgsqlTypes.NpgsqlLine(a: 0.22570519398290534d, b: 0.3082512459013136d, c: 0.05313785764791501d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6864529720143908d, b: 0.02082332349044136d, c: 0.27014472997862704d),
new NpgsqlTypes.NpgsqlLine(a: 0.24826916363004992d, b: 0.2592507197976194d, c: 0.027761132515433662d),
new NpgsqlTypes.NpgsqlLine(a: 0.08553132496216931d, b: 0.17404608939431587d, c: 0.2597297549259292d),
new NpgsqlTypes.NpgsqlLine(a: 0.11167062564832408d, b: 0.9436857903418677d, c: 0.9409092790328663d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9564710511918147d, b: 0.5561874424823178d, c: 0.6828279453694749d),
new NpgsqlTypes.NpgsqlLine(a: 0.5770281960844734d, b: 0.06935160219713399d, c: 0.597032068118651d),
new NpgsqlTypes.NpgsqlLine(a: 0.010576566600518866d, b: 0.8846354995317285d, c: 0.4789348296422088d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8068016392357877d, b: 0.7005256162406203d, c: 0.5664966601431999d),
new NpgsqlTypes.NpgsqlLine(a: 0.5668029209452643d, b: 0.5982979139982769d, c: 0.5654645070166425d),
new NpgsqlTypes.NpgsqlLine(a: 0.15151195410082774d, b: 0.6938859948626771d, c: 0.3277909388704664d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5262229669512056d, b: 0.5304689811876632d, c: 0.05491998885174021d),
new NpgsqlTypes.NpgsqlLine(a: 0.746745079759778d, b: 0.5241801671546565d, c: 0.13322138478498935d),
new NpgsqlTypes.NpgsqlLine(a: 0.05721372595520313d, b: 0.2513646595292768d, c: 0.3069474114527023d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3310193737765007d, b: 0.16190369102582725d, c: 0.1954762698533551d),
new NpgsqlTypes.NpgsqlLine(a: 0.36575457627949637d, b: 0.1964511355082208d, c: 0.8139102608351335d),
new NpgsqlTypes.NpgsqlLine(a: 0.16339421243602448d, b: 0.6203923519331962d, c: 0.10000394987487238d),
new NpgsqlTypes.NpgsqlLine(a: 0.019473103823166915d, b: 0.3213252807969097d, c: 0.22331340811075584d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5617449769962688d, b: 0.47599918002513186d, c: 0.5064394775105093d),
new NpgsqlTypes.NpgsqlLine(a: 0.40101023437411876d, b: 0.5892651193708917d, c: 0.06479688610061607d),
new NpgsqlTypes.NpgsqlLine(a: 0.4878517034583493d, b: 0.953409034306037d, c: 0.6471485595034743d),
new NpgsqlTypes.NpgsqlLine(a: 0.8149178227129722d, b: 0.31405766175434346d, c: 0.9516629597249266d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12021087748975667d, b: 0.27480451185672883d, c: 0.823868449444749d),
new NpgsqlTypes.NpgsqlLine(a: 0.2598148647985826d, b: 0.45243271326204004d, c: 0.05162370821351725d),
new NpgsqlTypes.NpgsqlLine(a: 0.30538421981410524d, b: 0.33993153213183924d, c: 0.11729355075573056d),
new NpgsqlTypes.NpgsqlLine(a: 0.01837994638389917d, b: 0.1651345825576228d, c: 0.47525898981205894d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6167610542755358d, b: 0.4310371732770937d, c: 0.03814411086304337d),
new NpgsqlTypes.NpgsqlLine(a: 0.3424959045394399d, b: 0.7165825352680545d, c: 0.22613757383155242d),
new NpgsqlTypes.NpgsqlLine(a: 0.3728611881347923d, b: 0.3991650673726389d, c: 0.03827162115250249d),
new NpgsqlTypes.NpgsqlLine(a: 0.12213305114180861d, b: 0.5294107491265304d, c: 0.4257065050821175d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6288575832692718d, b: 0.7809302311980172d, c: 0.6511756761461961d),
new NpgsqlTypes.NpgsqlLine(a: 0.8634980848244466d, b: 0.019976361769599715d, c: 0.0844617556561329d),
new NpgsqlTypes.NpgsqlLine(a: 0.3885963999441079d, b: 0.22809020914207878d, c: 0.4562550756635402d),
new NpgsqlTypes.NpgsqlLine(a: 0.2054048095768708d, b: 0.4749164590204631d, c: 0.5763486161946756d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.20726680693657495d, b: 0.17943766673547445d, c: 0.42007701406124287d),
new NpgsqlTypes.NpgsqlLine(a: 0.9756497002079836d, b: 0.8049086698286723d, c: 0.22774868160463246d),
new NpgsqlTypes.NpgsqlLine(a: 0.9488257387901533d, b: 0.6956720950529538d, c: 0.2131855106304078d),
new NpgsqlTypes.NpgsqlLine(a: 0.24203131705790415d, b: 0.46686568302624d, c: 0.17534353205037556d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5443974974423947d, b: 0.3871865846184689d, c: 0.7728932088654454d),
new NpgsqlTypes.NpgsqlLine(a: 0.9181505314638866d, b: 0.02748062965974496d, c: 0.1609815323938829d),
new NpgsqlTypes.NpgsqlLine(a: 0.4973928702440321d, b: 0.9341091399913045d, c: 0.8714513901936107d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24575236660165056d, b: 0.9903567043210875d, c: 0.6961793611531268d),
new NpgsqlTypes.NpgsqlLine(a: 0.6183745219566736d, b: 0.20837605536831694d, c: 0.5083112867558339d),
new NpgsqlTypes.NpgsqlLine(a: 0.4656345472368667d, b: 0.09218405327459933d, c: 0.9351316753669231d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6827835374189986d, b: 0.020864292710487953d, c: 0.39565522745629544d),
new NpgsqlTypes.NpgsqlLine(a: 0.7974627019823519d, b: 0.37664947735459486d, c: 0.0662358886884632d),
new NpgsqlTypes.NpgsqlLine(a: 0.35182837796912536d, b: 0.9251892913224202d, c: 0.2274155310958007d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9255869354765138d, b: 0.5761843241921656d, c: 0.6330795765267747d),
new NpgsqlTypes.NpgsqlLine(a: 0.8329306795736036d, b: 0.29895197354649206d, c: 0.37415031373876706d),
new NpgsqlTypes.NpgsqlLine(a: 0.6580182220602853d, b: 0.2596607556939494d, c: 0.4584874479611303d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15047481396607554d, b: 0.58362614537306d, c: 0.8902589275547759d),
new NpgsqlTypes.NpgsqlLine(a: 0.6294116429889324d, b: 0.701814052119123d, c: 0.4202361854351876d),
new NpgsqlTypes.NpgsqlLine(a: 0.7023664183331715d, b: 0.041505020756821165d, c: 0.24783136123291605d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9600592024111169d, b: 0.1991353038517948d, c: 0.9684154139440354d),
new NpgsqlTypes.NpgsqlLine(a: 0.9298503604748891d, b: 0.7063347491641289d, c: 0.3843579778553944d),
new NpgsqlTypes.NpgsqlLine(a: 0.03428934689124352d, b: 0.5454799082367892d, c: 0.4393110713529812d),
new NpgsqlTypes.NpgsqlLine(a: 0.6982737200233288d, b: 0.4234256837290231d, c: 0.3303957875642535d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7334904885567172d, b: 0.9809286154826622d, c: 0.1141526952863392d),
new NpgsqlTypes.NpgsqlLine(a: 0.5201387504655787d, b: 0.4269134780420809d, c: 0.2559323637841662d),
new NpgsqlTypes.NpgsqlLine(a: 0.009578641593327886d, b: 0.1995309945417012d, c: 0.19362534761395134d),
new NpgsqlTypes.NpgsqlLine(a: 0.04015596665842602d, b: 0.8426739764289595d, c: 0.1167285716476738d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8521271660044348d, b: 0.4405321144987804d, c: 0.2430502921772445d),
new NpgsqlTypes.NpgsqlLine(a: 0.09082504955230697d, b: 0.7060814601813103d, c: 0.09615555658817543d),
new NpgsqlTypes.NpgsqlLine(a: 0.1721782470788047d, b: 0.714330472254458d, c: 0.47994291647463705d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7039806372005702d, b: 0.1149813257334713d, c: 0.0454991964658944d),
new NpgsqlTypes.NpgsqlLine(a: 0.464580537470788d, b: 0.5826497712143359d, c: 0.24103723870711202d),
new NpgsqlTypes.NpgsqlLine(a: 0.31213098854858945d, b: 0.7859396087163109d, c: 0.4112293379254688d),
new NpgsqlTypes.NpgsqlLine(a: 0.358976734020946d, b: 0.44938974532780973d, c: 0.9252605515280912d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6342858999008374d, b: 0.5454594380844381d, c: 0.10555889967420728d),
new NpgsqlTypes.NpgsqlLine(a: 0.46874785743438174d, b: 0.7905882680978237d, c: 0.26823929894348086d),
new NpgsqlTypes.NpgsqlLine(a: 0.7626823624761506d, b: 0.8095292746926864d, c: 0.598870083929304d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7177226475111731d, b: 0.30712958039507976d, c: 0.12474554296850049d),
new NpgsqlTypes.NpgsqlLine(a: 0.7097510083503313d, b: 0.25731232537839255d, c: 0.05907362241735925d),
new NpgsqlTypes.NpgsqlLine(a: 0.02218963089060544d, b: 0.951476926322201d, c: 0.39090565853978054d),
new NpgsqlTypes.NpgsqlLine(a: 0.9497411789712471d, b: 0.6463301199934839d, c: 0.19873543476469047d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7216730050532882d, b: 0.48810230788498254d, c: 0.041603556724479684d),
new NpgsqlTypes.NpgsqlLine(a: 0.011889486646378788d, b: 0.6689580353158534d, c: 0.5688481657607682d),
new NpgsqlTypes.NpgsqlLine(a: 0.803171064832625d, b: 0.6282977003487066d, c: 0.778347351075274d),
new NpgsqlTypes.NpgsqlLine(a: 0.2184603145970061d, b: 0.7721638511049621d, c: 0.4631486663529052d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08488106942590368d, b: 0.576227775289638d, c: 0.3742341260443174d),
new NpgsqlTypes.NpgsqlLine(a: 0.8537506901317582d, b: 0.7154319522270157d, c: 0.22390851792810185d),
new NpgsqlTypes.NpgsqlLine(a: 0.9732201279198934d, b: 0.19597484730008863d, c: 0.8505962140446665d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5081243267517151d, b: 0.4386661193610011d, c: 0.6514209945508742d),
new NpgsqlTypes.NpgsqlLine(a: 0.16275577464334634d, b: 0.508237840869582d, c: 0.019164449081439328d),
new NpgsqlTypes.NpgsqlLine(a: 0.6725493645002245d, b: 0.867790277083919d, c: 0.9071407595912436d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5916296809097285d, b: 0.9363501735818575d, c: 0.19812090562005202d),
new NpgsqlTypes.NpgsqlLine(a: 0.6564966028858777d, b: 0.44290098663968924d, c: 0.06506654368518217d),
new NpgsqlTypes.NpgsqlLine(a: 0.2316474326750012d, b: 0.7031757167182449d, c: 0.6221933532499615d),
new NpgsqlTypes.NpgsqlLine(a: 0.1961739987224307d, b: 0.46350671361744933d, c: 0.14356582328822654d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2649394018599588d, b: 0.7447626513101944d, c: 0.8978118111968251d),
new NpgsqlTypes.NpgsqlLine(a: 0.6958475097016038d, b: 0.5274875819553354d, c: 0.5707683765843312d),
new NpgsqlTypes.NpgsqlLine(a: 0.026127531837242368d, b: 0.606767641948173d, c: 0.7018886504941988d),
new NpgsqlTypes.NpgsqlLine(a: 0.9392895161971507d, b: 0.8414084304007398d, c: 0.47017151053552975d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5281081097123637d, b: 0.06565569902167834d, c: 0.7529695836804846d),
new NpgsqlTypes.NpgsqlLine(a: 0.6418575388088174d, b: 0.9719007755644101d, c: 0.22210998733520337d),
new NpgsqlTypes.NpgsqlLine(a: 0.16536242188263905d, b: 0.8392429334917003d, c: 0.29055083597332987d),
new NpgsqlTypes.NpgsqlLine(a: 0.6862104424062316d, b: 0.04186346206717895d, c: 0.13526077849991003d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.38827962614667355d, b: 0.6616812717130722d, c: 0.29281849040796315d),
new NpgsqlTypes.NpgsqlLine(a: 0.8379361743207434d, b: 0.12001370950219492d, c: 0.10306157672602057d),
new NpgsqlTypes.NpgsqlLine(a: 0.3031702101218384d, b: 0.36694993354110417d, c: 0.22811109687763187d),
new NpgsqlTypes.NpgsqlLine(a: 0.8440729811510609d, b: 0.9172037235228285d, c: 0.3613649506039749d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0841136799301464d, b: 0.86959555182288d, c: 0.8906353564609936d),
new NpgsqlTypes.NpgsqlLine(a: 0.6958308144631867d, b: 0.39198852765654124d, c: 0.13666529540824768d),
new NpgsqlTypes.NpgsqlLine(a: 0.4321288254613628d, b: 0.18603374740605438d, c: 0.9118317198262785d),
new NpgsqlTypes.NpgsqlLine(a: 0.08008989296284885d, b: 0.4100037627599945d, c: 0.38177818312511125d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23043837835571157d, b: 0.3500258841291075d, c: 0.9562790277107887d),
new NpgsqlTypes.NpgsqlLine(a: 0.25118395329825105d, b: 0.7810582100881769d, c: 0.203167568789264d),
new NpgsqlTypes.NpgsqlLine(a: 0.7975667030652539d, b: 0.8704029037620955d, c: 0.44207582966691616d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5805197311114854d, b: 0.08486325730111055d, c: 0.5117877558861801d),
new NpgsqlTypes.NpgsqlLine(a: 0.45305131580991187d, b: 0.36849874946536465d, c: 0.4617508162859352d),
new NpgsqlTypes.NpgsqlLine(a: 0.09324120846201378d, b: 0.00999970729493549d, c: 0.7871141776015788d),
new NpgsqlTypes.NpgsqlLine(a: 0.039000871674939486d, b: 0.2396066054660284d, c: 0.560308801257511d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15927766723666825d, b: 0.8679756267387168d, c: 0.050486295551331994d),
new NpgsqlTypes.NpgsqlLine(a: 0.27507433969190875d, b: 0.8730219607149062d, c: 0.6227463577819191d),
new NpgsqlTypes.NpgsqlLine(a: 0.5463823399292734d, b: 0.8069650646238767d, c: 0.7259140470309922d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8230762654708078d, b: 0.6748356485047075d, c: 0.22923501374610789d),
new NpgsqlTypes.NpgsqlLine(a: 0.42531582029968784d, b: 0.6593840601372357d, c: 0.6266360029032683d),
new NpgsqlTypes.NpgsqlLine(a: 0.21648773802930266d, b: 0.41842887099390913d, c: 0.8011527527323206d),
new NpgsqlTypes.NpgsqlLine(a: 0.5448656005471605d, b: 0.8283137727156944d, c: 0.23993509791995737d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17093100342180056d, b: 0.803509448153176d, c: 0.017591873241904588d),
new NpgsqlTypes.NpgsqlLine(a: 0.9282004434241083d, b: 0.6357516014827845d, c: 0.4326392928580318d),
new NpgsqlTypes.NpgsqlLine(a: 0.2972910783320166d, b: 0.10158297699357899d, c: 0.7272663728792313d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21410686967896775d, b: 0.4788590354472171d, c: 0.8738495204283434d),
new NpgsqlTypes.NpgsqlLine(a: 0.1311380084007352d, b: 0.6345894134688788d, c: 0.2527649628648114d),
new NpgsqlTypes.NpgsqlLine(a: 0.41434036795605944d, b: 0.9797051170679592d, c: 0.16492080311270274d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9844004540070624d, b: 0.4716360177741997d, c: 0.7128329632257303d),
new NpgsqlTypes.NpgsqlLine(a: 0.351236366998561d, b: 0.9602758126652701d, c: 0.683140880089993d),
new NpgsqlTypes.NpgsqlLine(a: 0.493566639851895d, b: 0.7508409654518519d, c: 0.8016651349242816d),
new NpgsqlTypes.NpgsqlLine(a: 0.6442359120756121d, b: 0.4216275258959137d, c: 0.9361045150750342d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7968534140013471d, b: 0.5523810691598696d, c: 0.6790642757732661d),
new NpgsqlTypes.NpgsqlLine(a: 0.5389626425749328d, b: 0.5777540378487867d, c: 0.19944079542591509d),
new NpgsqlTypes.NpgsqlLine(a: 0.05801582325169108d, b: 0.6970866037329736d, c: 0.001983081746461224d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6014416107241705d, b: 0.8084594249537089d, c: 0.15167277817513913d),
new NpgsqlTypes.NpgsqlLine(a: 0.48680346095248594d, b: 0.709161529996548d, c: 0.45225550180727303d),
new NpgsqlTypes.NpgsqlLine(a: 0.45179779157020894d, b: 0.7248818372330404d, c: 0.5681257112680186d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29373886304467134d, b: 0.11614634330790974d, c: 0.6824346195358104d),
new NpgsqlTypes.NpgsqlLine(a: 0.988900875118928d, b: 0.7631748776745791d, c: 0.7789165140935674d),
new NpgsqlTypes.NpgsqlLine(a: 0.8293085277092263d, b: 0.053286954165490785d, c: 0.3560420516913342d),
new NpgsqlTypes.NpgsqlLine(a: 0.9619778247019457d, b: 0.7414174316092857d, c: 0.7633868804076551d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16027756777920588d, b: 0.6529733174768836d, c: 0.014210220869084078d),
new NpgsqlTypes.NpgsqlLine(a: 0.06959936639890396d, b: 0.040764242055078115d, c: 0.11438359455374514d),
new NpgsqlTypes.NpgsqlLine(a: 0.7059405031352276d, b: 0.9972256391632718d, c: 0.29970151807319323d),
new NpgsqlTypes.NpgsqlLine(a: 0.7194927955762588d, b: 0.5820561893695555d, c: 0.745938960679025d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5079558572513336d, b: 0.6582215249269291d, c: 0.10252336442971588d),
new NpgsqlTypes.NpgsqlLine(a: 0.6359802658627687d, b: 0.5468903419688668d, c: 0.627395480894448d),
new NpgsqlTypes.NpgsqlLine(a: 0.20803345891820535d, b: 0.5165231790713075d, c: 0.9340805922022957d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08577013227629415d, b: 0.5749356461349996d, c: 0.2735313539625718d),
new NpgsqlTypes.NpgsqlLine(a: 0.3035460883091423d, b: 0.9887518375668298d, c: 0.1957546651846781d),
new NpgsqlTypes.NpgsqlLine(a: 0.3406067304278615d, b: 0.6152890281120422d, c: 0.6168124069915546d),
new NpgsqlTypes.NpgsqlLine(a: 0.28307676550194105d, b: 0.6478004862852609d, c: 0.5558572183115521d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2621871362763275d, b: 0.528358117317691d, c: 0.7239558085249431d),
new NpgsqlTypes.NpgsqlLine(a: 0.26575674998605103d, b: 0.5578134985873588d, c: 0.9083402538468265d),
new NpgsqlTypes.NpgsqlLine(a: 0.40770093517784667d, b: 0.5240460870543847d, c: 0.4715164027264628d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07436444884038951d, b: 0.4717087472235013d, c: 0.055759282862418824d),
new NpgsqlTypes.NpgsqlLine(a: 0.797558833254463d, b: 0.0769979843513281d, c: 0.473840107253928d),
new NpgsqlTypes.NpgsqlLine(a: 0.8223595498827573d, b: 0.16255322676410133d, c: 0.47825540933288924d),
new NpgsqlTypes.NpgsqlLine(a: 0.06173023010815515d, b: 0.6117801739483747d, c: 0.6382261553435242d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6518779826731147d, b: 0.9930407542690245d, c: 0.9674451450689103d),
new NpgsqlTypes.NpgsqlLine(a: 0.2932869458634433d, b: 0.6069475470130521d, c: 0.8342485572872784d),
new NpgsqlTypes.NpgsqlLine(a: 0.03941607933681179d, b: 0.9968476594998315d, c: 0.5502896121669683d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40493674452054607d, b: 0.5017038684963985d, c: 0.5250492533920617d),
new NpgsqlTypes.NpgsqlLine(a: 0.9297684541727301d, b: 0.9630743348164245d, c: 0.4108526971066647d),
new NpgsqlTypes.NpgsqlLine(a: 0.19358565074994016d, b: 0.536856990101136d, c: 0.525905936839518d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8792535041506391d, b: 0.29665741661737166d, c: 0.11100868871237879d),
new NpgsqlTypes.NpgsqlLine(a: 0.45570989997070843d, b: 0.620272540620475d, c: 0.7195659059256102d),
new NpgsqlTypes.NpgsqlLine(a: 0.14492057628448107d, b: 0.9018891145677768d, c: 0.06420223967368988d),
new NpgsqlTypes.NpgsqlLine(a: 0.6710007739719913d, b: 0.6668711729714295d, c: 0.18379335712467326d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 48;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 2;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 33, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 7, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 64, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 49, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 107, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 7, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 48, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 78, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 59, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[29], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[30], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[31], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[32], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[33], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[30], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[31], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[32], false);NpgsqlLinelineArray1M.AssertModel(models[26],_testData[33], false);NpgsqlLinelineArray1M.AssertModel(models[27],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI), typeof(NpgsqlLinelineArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                await ((INpgsqlLineArraylineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                ((INpgsqlLineArraylineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineArraylineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

