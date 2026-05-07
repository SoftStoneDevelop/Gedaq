

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8922175661565556d, b: 0.554755945297918d, c: 0.36788277595714036d),

new NpgsqlTypes.NpgsqlLine(a: 0.2325045982813394d, b: 0.3477978765665012d, c: 0.1133216283938242d),

new NpgsqlTypes.NpgsqlLine(a: 0.6284811894423241d, b: 0.9332529915382364d, c: 0.02043016265800346d),

new NpgsqlTypes.NpgsqlLine(a: 0.43001305027173875d, b: 0.9330786626210437d, c: 0.17014432491880527d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9417498758116656d, b: 0.8030089282449401d, c: 0.7106573878603119d),

new NpgsqlTypes.NpgsqlLine(a: 0.12027954946273689d, b: 0.19426728911746438d, c: 0.001002565990854687d),

new NpgsqlTypes.NpgsqlLine(a: 0.6799394611105287d, b: 0.3438144393911271d, c: 0.4153399697313894d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6153544285305567d, b: 0.2536383858865249d, c: 0.2621016849133453d),

new NpgsqlTypes.NpgsqlLine(a: 0.3307773989430337d, b: 0.5993077709314458d, c: 0.5792247396470261d),

new NpgsqlTypes.NpgsqlLine(a: 0.11707604553267781d, b: 0.40690181725046193d, c: 0.89125013742895d),

new NpgsqlTypes.NpgsqlLine(a: 0.7677294362387475d, b: 0.9250788463306291d, c: 0.27450022191715384d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7817078952684162d, b: 0.5935828178746453d, c: 0.2995682009966214d),

new NpgsqlTypes.NpgsqlLine(a: 0.1590835660943707d, b: 0.9097873518371676d, c: 0.027671616373022845d),

new NpgsqlTypes.NpgsqlLine(a: 0.710045156325843d, b: 0.9575966834826646d, c: 0.73207318595342d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25861947713196454d, b: 0.7704707522573487d, c: 0.9169235832637732d),

new NpgsqlTypes.NpgsqlLine(a: 0.4920126827547603d, b: 0.8097100823224013d, c: 0.07793596786242518d),

new NpgsqlTypes.NpgsqlLine(a: 0.0026990176211241224d, b: 0.8687120593279574d, c: 0.43288696821015493d),

new NpgsqlTypes.NpgsqlLine(a: 0.7102970462679892d, b: 0.15313200693704643d, c: 0.6703104938210255d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7377308547814019d, b: 0.6644875905121256d, c: 0.2804686574760489d),

new NpgsqlTypes.NpgsqlLine(a: 0.7436142353456782d, b: 0.6921180192456603d, c: 0.8119176622174994d),

new NpgsqlTypes.NpgsqlLine(a: 0.883110364266848d, b: 0.7288251471120161d, c: 0.17207951254093112d),

new NpgsqlTypes.NpgsqlLine(a: 0.6606972686623473d, b: 0.5560589374208015d, c: 0.1331584328233707d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13730051925221742d, b: 0.5947245581263737d, c: 0.5819253512001293d),

new NpgsqlTypes.NpgsqlLine(a: 0.41088899227764886d, b: 0.018368976810575144d, c: 0.810902671506937d),

new NpgsqlTypes.NpgsqlLine(a: 0.18606805713764618d, b: 0.5068680818839891d, c: 0.9318096497198463d),

new NpgsqlTypes.NpgsqlLine(a: 0.25087569024969336d, b: 0.5790243353191284d, c: 0.316047821782079d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7456204633212971d, b: 0.748000378005635d, c: 0.3203266629295358d),

new NpgsqlTypes.NpgsqlLine(a: 0.5097235868478769d, b: 0.3178964011778196d, c: 0.6382451518468188d),

new NpgsqlTypes.NpgsqlLine(a: 0.09024394678670566d, b: 0.001897551317994961d, c: 0.5129054252969897d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9740525005722963d, b: 0.12502690772728253d, c: 0.6831611210897994d),

new NpgsqlTypes.NpgsqlLine(a: 0.9954522451733476d, b: 0.3712697965087892d, c: 0.77227981998672d),

new NpgsqlTypes.NpgsqlLine(a: 0.7274960754351588d, b: 0.1791858802085221d, c: 0.8319335595085741d),

new NpgsqlTypes.NpgsqlLine(a: 0.2123558380182462d, b: 0.21543738641961963d, c: 0.9416985735875631d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17564319565103392d, b: 0.6632167631071287d, c: 0.12299415155803983d),

new NpgsqlTypes.NpgsqlLine(a: 0.5400439111666104d, b: 0.38981066024299327d, c: 0.42692479923103455d),

new NpgsqlTypes.NpgsqlLine(a: 0.4145595266724813d, b: 0.45200455540036466d, c: 0.6917181508803766d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45815487209703676d, b: 0.9822864066066633d, c: 0.6930990590999234d),

new NpgsqlTypes.NpgsqlLine(a: 0.4874147375121183d, b: 0.941807769901683d, c: 0.731373605331171d),

new NpgsqlTypes.NpgsqlLine(a: 0.07452195221848978d, b: 0.09891021914778231d, c: 0.4651537572179475d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5341459422074794d, b: 0.44996636765173026d, c: 0.8816059799422782d),

new NpgsqlTypes.NpgsqlLine(a: 0.8722140410642645d, b: 0.2915156582887226d, c: 0.9952596592181935d),

new NpgsqlTypes.NpgsqlLine(a: 0.7880937454976376d, b: 0.7535182955059605d, c: 0.166973655201051d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7341891286589327d, b: 0.23389151753302184d, c: 0.07247693680580924d),

new NpgsqlTypes.NpgsqlLine(a: 0.6699458277284299d, b: 0.4311093525676801d, c: 0.7521124256526801d),

new NpgsqlTypes.NpgsqlLine(a: 0.7239108183736518d, b: 0.858137085322127d, c: 0.47073947810860806d),

new NpgsqlTypes.NpgsqlLine(a: 0.9737642276670246d, b: 0.32751904189561476d, c: 0.20450362444477244d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04415759760664284d, b: 0.3464469421201859d, c: 0.08497147485209522d),

new NpgsqlTypes.NpgsqlLine(a: 0.7319237231144972d, b: 0.32209789443793735d, c: 0.4807811438682963d),

new NpgsqlTypes.NpgsqlLine(a: 0.9157536311227569d, b: 0.5578383598594232d, c: 0.3224487687198183d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6345044460412694d, b: 0.959243582650612d, c: 0.2788344982840444d),

new NpgsqlTypes.NpgsqlLine(a: 0.0714773062651014d, b: 0.8931882069986207d, c: 0.07821632326492944d),

new NpgsqlTypes.NpgsqlLine(a: 0.029606738821025158d, b: 0.49800500718740337d, c: 0.08100693917288226d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4515855783165903d, b: 0.16935797567226174d, c: 0.4481430615862996d),

new NpgsqlTypes.NpgsqlLine(a: 0.5769803124191858d, b: 0.8932529359310104d, c: 0.7350978746621705d),

new NpgsqlTypes.NpgsqlLine(a: 0.120837530717116d, b: 0.3550427597654293d, c: 0.0794238944840503d),

new NpgsqlTypes.NpgsqlLine(a: 0.31272274316725446d, b: 0.9806352125458448d, c: 0.9287227260918376d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9089595399059008d, b: 0.7828248436445497d, c: 0.6723053537566256d),

new NpgsqlTypes.NpgsqlLine(a: 0.3711904904023138d, b: 0.6373621221262402d, c: 0.23975893119422942d),

new NpgsqlTypes.NpgsqlLine(a: 0.2599349685014538d, b: 0.46699225454080195d, c: 0.5852129901984215d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8247956941105136d, b: 0.5552936916822502d, c: 0.6296338740484205d),

new NpgsqlTypes.NpgsqlLine(a: 0.8668121004987077d, b: 0.5226973831754177d, c: 0.9953002287665648d),

new NpgsqlTypes.NpgsqlLine(a: 0.3797783871844975d, b: 0.7578056599865521d, c: 0.7602022471945623d),

new NpgsqlTypes.NpgsqlLine(a: 0.5242478348103172d, b: 0.0019265352876696173d, c: 0.25288487200913967d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.37050062131516104d, b: 0.08420385208940473d, c: 0.825835751246398d),

new NpgsqlTypes.NpgsqlLine(a: 0.5681563234391429d, b: 0.6826035083852091d, c: 0.6515083402181597d),

new NpgsqlTypes.NpgsqlLine(a: 0.5572383706102207d, b: 0.8657050450951695d, c: 0.11183226798690504d),

new NpgsqlTypes.NpgsqlLine(a: 0.12536718492966048d, b: 0.37025792197551344d, c: 0.46308351868731423d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9594196703812118d, b: 0.31577759287931373d, c: 0.6292446832203847d),

new NpgsqlTypes.NpgsqlLine(a: 0.5273224034796575d, b: 0.0695730031986661d, c: 0.32620000040924546d),

new NpgsqlTypes.NpgsqlLine(a: 0.40402614701706885d, b: 0.05336987361048373d, c: 0.2348256529081144d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45785852225452206d, b: 0.6601037269193528d, c: 0.05773865723361382d),

new NpgsqlTypes.NpgsqlLine(a: 0.5191299123469099d, b: 0.6167994130561975d, c: 0.565754633350703d),

new NpgsqlTypes.NpgsqlLine(a: 0.0654466836487737d, b: 0.7499575801456396d, c: 0.03623323854095806d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9757560455172432d, b: 0.983291092330776d, c: 0.380025797384408d),

new NpgsqlTypes.NpgsqlLine(a: 0.5390525505723032d, b: 0.10255949520362773d, c: 0.10608236646416247d),

new NpgsqlTypes.NpgsqlLine(a: 0.6654916414383977d, b: 0.6019607464153899d, c: 0.5616431573903677d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1601498755098193d, b: 0.19440562144865114d, c: 0.9549749747387725d),

new NpgsqlTypes.NpgsqlLine(a: 0.16177389844066026d, b: 0.7109689977200561d, c: 0.5108299861820552d),

new NpgsqlTypes.NpgsqlLine(a: 0.6470543732344843d, b: 0.629183346454982d, c: 0.9279827620954892d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.013244315808741192d, b: 0.4088361974511686d, c: 0.33876618664086233d),

new NpgsqlTypes.NpgsqlLine(a: 0.15399552741920763d, b: 0.4884958406454186d, c: 0.37562325465948065d),

new NpgsqlTypes.NpgsqlLine(a: 0.7505995646301432d, b: 0.5690299071902435d, c: 0.9668366613984183d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4984020306914049d, b: 0.3053487493052701d, c: 0.20379056059583367d),

new NpgsqlTypes.NpgsqlLine(a: 0.47609374895153356d, b: 0.8966724291090727d, c: 0.19076971171883206d),

new NpgsqlTypes.NpgsqlLine(a: 0.16055350544577351d, b: 0.17656239056297918d, c: 0.647132496725441d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22560666633376703d, b: 0.18744488240396207d, c: 0.060597735931051444d),

new NpgsqlTypes.NpgsqlLine(a: 0.06574358939508951d, b: 0.8970365723989187d, c: 0.9410043211622922d),

new NpgsqlTypes.NpgsqlLine(a: 0.2552134247373925d, b: 0.8781399625066809d, c: 0.32669444727443375d),

new NpgsqlTypes.NpgsqlLine(a: 0.16715962128623207d, b: 0.3205931038781509d, c: 0.46347134592621864d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46015900500342044d, b: 0.06978265823608099d, c: 0.19709982245708846d),

new NpgsqlTypes.NpgsqlLine(a: 0.17952515230524735d, b: 0.03536340315133735d, c: 0.9831105615667838d),

new NpgsqlTypes.NpgsqlLine(a: 0.5250022609383782d, b: 0.3466448855335966d, c: 0.6381940394917222d),

new NpgsqlTypes.NpgsqlLine(a: 0.24355881185931116d, b: 0.5114878227439045d, c: 0.8501537314457607d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.58006154996106d, b: 0.5845289177132594d, c: 0.5902585489114178d),

new NpgsqlTypes.NpgsqlLine(a: 0.4948096836685195d, b: 0.8979569486231798d, c: 0.6403878318043933d),

new NpgsqlTypes.NpgsqlLine(a: 0.6274102708983473d, b: 0.09457099651441414d, c: 0.6750002095753269d),

new NpgsqlTypes.NpgsqlLine(a: 0.09130240639984766d, b: 0.24830821042301743d, c: 0.12263847260204619d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.057406910548004175d, b: 0.49780064606447405d, c: 0.07611082500134225d),

new NpgsqlTypes.NpgsqlLine(a: 0.4138675976082532d, b: 0.5768663517596854d, c: 0.4872176715657427d),

new NpgsqlTypes.NpgsqlLine(a: 0.6184328627573932d, b: 0.5119106195438266d, c: 0.9511676960458706d),

new NpgsqlTypes.NpgsqlLine(a: 0.5393168292715518d, b: 0.304213192399826d, c: 0.5233046546734703d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5314130142852183d, b: 0.5758962103173777d, c: 0.7625822393502198d),

new NpgsqlTypes.NpgsqlLine(a: 0.9639687320682894d, b: 0.9417326090052621d, c: 0.7821738483669449d),

new NpgsqlTypes.NpgsqlLine(a: 0.06839889337974592d, b: 0.8216545664231718d, c: 0.5335130260065442d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21666435604918133d, b: 0.4182598071328666d, c: 0.6403656273568938d),

new NpgsqlTypes.NpgsqlLine(a: 0.6737006627975506d, b: 0.44530551637681914d, c: 0.8474645484980244d),

new NpgsqlTypes.NpgsqlLine(a: 0.30722843165410363d, b: 0.6337539013501565d, c: 0.6903750773174082d),

new NpgsqlTypes.NpgsqlLine(a: 0.006388966603877666d, b: 0.33796929030327594d, c: 0.8997646202814796d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12866420826286484d, b: 0.30737269991468985d, c: 0.3324347911581348d),

new NpgsqlTypes.NpgsqlLine(a: 0.9190367873055619d, b: 0.3635595978167181d, c: 0.7416915451640856d),

new NpgsqlTypes.NpgsqlLine(a: 0.19677751014597122d, b: 0.4368803399161182d, c: 0.2749991316204461d),

new NpgsqlTypes.NpgsqlLine(a: 0.3152696398206556d, b: 0.8373640014276057d, c: 0.6134823854914683d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7370188768223421d, b: 0.2909603102511644d, c: 0.9027584668543618d),

new NpgsqlTypes.NpgsqlLine(a: 0.9834968816243858d, b: 0.35389808588533467d, c: 0.8819702213902746d),

new NpgsqlTypes.NpgsqlLine(a: 0.7257194998501711d, b: 0.24362688580704273d, c: 0.5534588978141521d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16734095379819325d, b: 0.5960922271880227d, c: 0.9082841458832596d),

new NpgsqlTypes.NpgsqlLine(a: 0.12698130054373724d, b: 0.48359968918694607d, c: 0.4593170525081247d),

new NpgsqlTypes.NpgsqlLine(a: 0.048675916245436546d, b: 0.2644208409810971d, c: 0.0630610944829686d),

new NpgsqlTypes.NpgsqlLine(a: 0.6316794440234035d, b: 0.6819737537468786d, c: 0.9801465641247916d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13816151026120782d, b: 0.5073706266479351d, c: 0.06396832618233461d),

new NpgsqlTypes.NpgsqlLine(a: 0.8150832046233879d, b: 0.5861444945305498d, c: 0.7564079957038364d),

new NpgsqlTypes.NpgsqlLine(a: 0.42659759321691915d, b: 0.0520064173789343d, c: 0.6121117532676178d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.134148098300925d, b: 0.4933963119788587d, c: 0.1992789478266973d),

new NpgsqlTypes.NpgsqlLine(a: 0.49168447843605945d, b: 0.1071351985540615d, c: 0.4245012717203318d),

new NpgsqlTypes.NpgsqlLine(a: 0.8307446990817545d, b: 0.12233419590047179d, c: 0.7926148009412274d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44948199392462784d, b: 0.5975570191954597d, c: 0.6778264813505605d),

new NpgsqlTypes.NpgsqlLine(a: 0.822910312128702d, b: 0.6000816764133284d, c: 0.6421749735524996d),

new NpgsqlTypes.NpgsqlLine(a: 0.5384446827284628d, b: 0.7493962069629391d, c: 0.8542984275442324d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32461667702767816d, b: 0.08627955733720527d, c: 0.8572343740354009d),

new NpgsqlTypes.NpgsqlLine(a: 0.36487365651237236d, b: 0.5540854118478316d, c: 0.36565162298526654d),

new NpgsqlTypes.NpgsqlLine(a: 0.65357454413186d, b: 0.9593446512929357d, c: 0.060764235957706414d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6132905240808562d, b: 0.6053144595372136d, c: 0.6274583326023538d),

new NpgsqlTypes.NpgsqlLine(a: 0.07519190637217865d, b: 0.8136460162681609d, c: 0.43734389006397145d),

new NpgsqlTypes.NpgsqlLine(a: 0.15930952452741964d, b: 0.26604580924320587d, c: 0.25581379996020903d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7314114753456985d, b: 0.8284141340506592d, c: 0.16565193332791672d),

new NpgsqlTypes.NpgsqlLine(a: 0.9463384489284983d, b: 0.16417594847815253d, c: 0.5727741172630612d),

new NpgsqlTypes.NpgsqlLine(a: 0.6169325349761896d, b: 0.28371776912116387d, c: 0.6897855910483176d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48687016039948594d, b: 0.5873195038758388d, c: 0.5377188314593644d),

new NpgsqlTypes.NpgsqlLine(a: 0.5806728800746604d, b: 0.11036535030502026d, c: 0.5270465034021942d),

new NpgsqlTypes.NpgsqlLine(a: 0.0186983098754554d, b: 0.5101662670887903d, c: 0.5538882460916746d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7615478520423625d, b: 0.3542847207622817d, c: 0.05008318075075879d),

new NpgsqlTypes.NpgsqlLine(a: 0.6096707183324089d, b: 0.26534540308094345d, c: 0.6723230335594309d),

new NpgsqlTypes.NpgsqlLine(a: 0.516589795093849d, b: 0.9481439564705978d, c: 0.22379655923357344d),

new NpgsqlTypes.NpgsqlLine(a: 0.04356728666214715d, b: 0.9650351797124631d, c: 0.4107065726775677d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03707631254220922d, b: 0.46099111569187823d, c: 0.5045711189507648d),

new NpgsqlTypes.NpgsqlLine(a: 0.6037820991457074d, b: 0.3659533333104905d, c: 0.5131947777832278d),

new NpgsqlTypes.NpgsqlLine(a: 0.32852744117753196d, b: 0.5433925177458011d, c: 0.60790082818235d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5908437762306484d, b: 0.6596397899673464d, c: 0.8925662229871797d),

new NpgsqlTypes.NpgsqlLine(a: 0.36506003138165044d, b: 0.8681279261866771d, c: 0.7482473471583431d),

new NpgsqlTypes.NpgsqlLine(a: 0.5859333398286597d, b: 0.8394965373473328d, c: 0.5841754086038686d),

new NpgsqlTypes.NpgsqlLine(a: 0.10900183968623522d, b: 0.7767299496691346d, c: 0.07592330013230963d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2589219161271705d, b: 0.10810605234586235d, c: 0.499196359969343d),

new NpgsqlTypes.NpgsqlLine(a: 0.2193379350924234d, b: 0.4161554589347011d, c: 0.10818735210308938d),

new NpgsqlTypes.NpgsqlLine(a: 0.8397524114312374d, b: 0.5158767821247845d, c: 0.5418573418711987d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45402504851570435d, b: 0.48904917533000447d, c: 0.2510452513968986d),

new NpgsqlTypes.NpgsqlLine(a: 0.8397038372035002d, b: 0.16248690208109273d, c: 0.914564508171482d),

new NpgsqlTypes.NpgsqlLine(a: 0.7208286846362731d, b: 0.7751828220084861d, c: 0.44791594475405605d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17919991354501086d, b: 0.0887261429763474d, c: 0.7468043377102167d),

new NpgsqlTypes.NpgsqlLine(a: 0.23221660616554363d, b: 0.2158230447412639d, c: 0.6689146202706113d),

new NpgsqlTypes.NpgsqlLine(a: 0.22560793585632888d, b: 0.17093311949459777d, c: 0.7319249979839271d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4273217435064962d, b: 0.10006035306912187d, c: 0.4395274838471156d),

new NpgsqlTypes.NpgsqlLine(a: 0.38766945562279087d, b: 0.5594868913322898d, c: 0.7074832404490773d),

new NpgsqlTypes.NpgsqlLine(a: 0.8141781236730273d, b: 0.3263508507292662d, c: 0.9133162340184897d),

new NpgsqlTypes.NpgsqlLine(a: 0.41982954918667703d, b: 0.903759962375636d, c: 0.4946626926382104d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5621259004861235d, b: 0.9216947076728793d, c: 0.567106712060323d),

new NpgsqlTypes.NpgsqlLine(a: 0.5272003047031276d, b: 0.6960739452977642d, c: 0.7869142466966647d),

new NpgsqlTypes.NpgsqlLine(a: 0.2332012250060459d, b: 0.3163300460956725d, c: 0.7375436786999908d),

new NpgsqlTypes.NpgsqlLine(a: 0.5849174493757133d, b: 0.48692351738018835d, c: 0.5063830989854995d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5239586035013939d, b: 0.4978552548661863d, c: 0.6012732399027135d),

new NpgsqlTypes.NpgsqlLine(a: 0.12749354990215378d, b: 0.5093879776129345d, c: 0.5092524622934756d),

new NpgsqlTypes.NpgsqlLine(a: 0.0930264855109525d, b: 0.8655203896569579d, c: 0.9203014474991822d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9537555975647162d, b: 0.7156476447143802d, c: 0.19594655226199587d),

new NpgsqlTypes.NpgsqlLine(a: 0.8811767665661003d, b: 0.6957909933684193d, c: 0.863414325478477d),

new NpgsqlTypes.NpgsqlLine(a: 0.5765483632131316d, b: 0.7418380019648394d, c: 0.2931556314502316d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8181235837741904d, b: 0.6696972870557006d, c: 0.9380404365853515d),

new NpgsqlTypes.NpgsqlLine(a: 0.48125323107422324d, b: 0.2994646994601413d, c: 0.8258011998982845d),

new NpgsqlTypes.NpgsqlLine(a: 0.5908215426937148d, b: 0.3548301643410401d, c: 0.03433074827024407d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7004662329125996d, b: 0.43077732940682034d, c: 0.2730965206052218d),

new NpgsqlTypes.NpgsqlLine(a: 0.07562143186365156d, b: 0.7625365637665444d, c: 0.09005660022910267d),

new NpgsqlTypes.NpgsqlLine(a: 0.8836259114297412d, b: 0.15638095983170408d, c: 0.9251007907644769d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3337902433381599d, b: 0.000486270258270749d, c: 0.984159049219047d),

new NpgsqlTypes.NpgsqlLine(a: 0.5393679760321153d, b: 0.2961288052993559d, c: 0.8684850495916021d),

new NpgsqlTypes.NpgsqlLine(a: 0.9750138060356552d, b: 0.548255935086973d, c: 0.5955263700410548d),

new NpgsqlTypes.NpgsqlLine(a: 0.10451301989696049d, b: 0.5764888081207593d, c: 0.7910108595331405d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8040723113370046d, b: 0.854863473717526d, c: 0.7896644270388157d),

new NpgsqlTypes.NpgsqlLine(a: 0.5599146567469208d, b: 0.05942763897584624d, c: 0.5910527481217478d),

new NpgsqlTypes.NpgsqlLine(a: 0.3273999569276965d, b: 0.5076879713671555d, c: 0.8225480658913036d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12235523060111997d, b: 0.8020826301230998d, c: 0.3816181426455926d),

new NpgsqlTypes.NpgsqlLine(a: 0.6302380563070507d, b: 0.6838956857183434d, c: 0.7983498662841825d),

new NpgsqlTypes.NpgsqlLine(a: 0.1790406217495032d, b: 0.8431833027132889d, c: 0.44302552311608157d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40407781194311665d, b: 0.7265045516147423d, c: 0.8761142094999018d),

new NpgsqlTypes.NpgsqlLine(a: 0.4832015257702187d, b: 0.27960260421488736d, c: 0.18206093149325497d),

new NpgsqlTypes.NpgsqlLine(a: 0.010116255038919109d, b: 0.6765783664916464d, c: 0.5580111957853382d),

new NpgsqlTypes.NpgsqlLine(a: 0.16644533590992716d, b: 0.9389756321657954d, c: 0.07823222592433077d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4733303724701514d, b: 0.3078207288420648d, c: 0.8484754893917121d),

new NpgsqlTypes.NpgsqlLine(a: 0.4412961890189607d, b: 0.09529066092304472d, c: 0.3096306211592956d),

new NpgsqlTypes.NpgsqlLine(a: 0.558196303752381d, b: 0.033006990735817365d, c: 0.7271091542755593d),

new NpgsqlTypes.NpgsqlLine(a: 0.038820314493959285d, b: 0.9852709824593787d, c: 0.6991844365322566d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3683819570266884d, b: 0.544598272519915d, c: 0.48577703092893243d),

new NpgsqlTypes.NpgsqlLine(a: 0.14897504038052967d, b: 0.24377760263447645d, c: 0.702223864909313d),

new NpgsqlTypes.NpgsqlLine(a: 0.2721242197048507d, b: 0.6137091558812828d, c: 0.692161604062003d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.770618670013581d, b: 0.9988907533527426d, c: 0.9420318429694166d),

new NpgsqlTypes.NpgsqlLine(a: 0.8798929447470258d, b: 0.4715407239460504d, c: 0.9077431447595959d),

new NpgsqlTypes.NpgsqlLine(a: 0.992277974416226d, b: 0.1604572353488133d, c: 0.714553796542857d),

new NpgsqlTypes.NpgsqlLine(a: 0.23785628444109363d, b: 0.2751490888709268d, c: 0.7932456241929445d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8481438989061189d, b: 0.30881737818484856d, c: 0.2612539637925796d),

new NpgsqlTypes.NpgsqlLine(a: 0.865148642980441d, b: 0.4853813899886592d, c: 0.7234600552127937d),

new NpgsqlTypes.NpgsqlLine(a: 0.463628278398869d, b: 0.49009168207589804d, c: 0.3040690633197436d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7853160157983758d, b: 0.20283270744100246d, c: 0.2895535131781678d),

new NpgsqlTypes.NpgsqlLine(a: 0.6206038082998296d, b: 0.26669928525493014d, c: 0.3926913909944195d),

new NpgsqlTypes.NpgsqlLine(a: 0.06903704761726881d, b: 0.7870397319752895d, c: 0.16128032993682062d),

new NpgsqlTypes.NpgsqlLine(a: 0.5863784268495579d, b: 0.2765003994276177d, c: 0.7708155561908173d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03698401584784816d, b: 0.23892591380458228d, c: 0.7970014883123328d),

new NpgsqlTypes.NpgsqlLine(a: 0.5320182536185517d, b: 0.50594762917315d, c: 0.45038550190252946d),

new NpgsqlTypes.NpgsqlLine(a: 0.5991394597551274d, b: 0.3750092231069685d, c: 0.2558963339250031d),

new NpgsqlTypes.NpgsqlLine(a: 0.7753585999537398d, b: 0.8387303015923819d, c: 0.4739907571999642d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7275617963363753d, b: 0.008011436307958086d, c: 0.24646254563813297d),

new NpgsqlTypes.NpgsqlLine(a: 0.19760496361276503d, b: 0.24117395597270486d, c: 0.4327506197597767d),

new NpgsqlTypes.NpgsqlLine(a: 0.17082814889953846d, b: 0.4108047254860595d, c: 0.5823017540405546d),

new NpgsqlTypes.NpgsqlLine(a: 0.5492381320712376d, b: 0.9034489116926586d, c: 0.8963074885509723d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30582539222444405d, b: 0.3734566917731673d, c: 0.6236452244697662d),

new NpgsqlTypes.NpgsqlLine(a: 0.6617227870605434d, b: 0.7556730497421037d, c: 0.7151182066622899d),

new NpgsqlTypes.NpgsqlLine(a: 0.5161736708415335d, b: 0.4158146229854329d, c: 0.9075212597860636d),

new NpgsqlTypes.NpgsqlLine(a: 0.22462687450515562d, b: 0.6824815731662436d, c: 0.6805250710016653d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5125906621398737d, b: 0.5147587294216293d, c: 0.09634984891422971d),

new NpgsqlTypes.NpgsqlLine(a: 0.38841541598526697d, b: 0.28692586052855906d, c: 0.8414869016289852d),

new NpgsqlTypes.NpgsqlLine(a: 0.12954442300830138d, b: 0.9982085583410213d, c: 0.36956286315515985d),

new NpgsqlTypes.NpgsqlLine(a: 0.683670282286741d, b: 0.05106099961454902d, c: 0.8044620354367561d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4172950741840947d, b: 0.9994163354944496d, c: 0.24004896924947616d),

new NpgsqlTypes.NpgsqlLine(a: 0.9798265105235454d, b: 0.5837400658144305d, c: 0.9685663754071595d),

new NpgsqlTypes.NpgsqlLine(a: 0.5759989191107028d, b: 0.6593392685336521d, c: 0.056460830997841605d),

new NpgsqlTypes.NpgsqlLine(a: 0.3286694217439161d, b: 0.08760071509574874d, c: 0.03361544014223539d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3132760301314136d, b: 0.5383392012545539d, c: 0.2633293792136864d),

new NpgsqlTypes.NpgsqlLine(a: 0.4604783753652859d, b: 0.8810513520450335d, c: 0.8242879123663441d),

new NpgsqlTypes.NpgsqlLine(a: 0.05789510766309258d, b: 0.7183242707576353d, c: 0.9986929293399408d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3353359866245541d, b: 0.8876494610407241d, c: 0.15014872570219617d),

new NpgsqlTypes.NpgsqlLine(a: 0.8068454051410848d, b: 0.486168128609871d, c: 0.4909018720332817d),

new NpgsqlTypes.NpgsqlLine(a: 0.794659401349791d, b: 0.5820416072353122d, c: 0.8487403945315665d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3608865723825897d, b: 0.8034027445207097d, c: 0.7088124292551474d),

new NpgsqlTypes.NpgsqlLine(a: 0.27819283766126257d, b: 0.06010891492383119d, c: 0.7881234329754724d),

new NpgsqlTypes.NpgsqlLine(a: 0.4014227822360966d, b: 0.42187051387116614d, c: 0.21440028924833288d),

new NpgsqlTypes.NpgsqlLine(a: 0.2812289443749104d, b: 0.3170614603019426d, c: 0.7320225440475538d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6160601347273584d, b: 0.347412375968263d, c: 0.466503306045962d),

new NpgsqlTypes.NpgsqlLine(a: 0.15592700089294753d, b: 0.6719842014633981d, c: 0.994246601710284d),

new NpgsqlTypes.NpgsqlLine(a: 0.5885500984372526d, b: 0.16523156126977956d, c: 0.8143350393627707d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7215429538983d, b: 0.1617152142748446d, c: 0.4721032647196175d),

new NpgsqlTypes.NpgsqlLine(a: 0.6104236549122802d, b: 0.05702212381407723d, c: 0.5248528625384676d),

new NpgsqlTypes.NpgsqlLine(a: 0.829061721960026d, b: 0.8834741820013556d, c: 0.14531249025917292d),

new NpgsqlTypes.NpgsqlLine(a: 0.7915521772424751d, b: 0.4810509794728469d, c: 0.18011282815992447d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6836357154587399d, b: 0.8819600715342857d, c: 0.7863296436874805d),

new NpgsqlTypes.NpgsqlLine(a: 0.09902725648466781d, b: 0.2768422996801838d, c: 0.7061315086618751d),

new NpgsqlTypes.NpgsqlLine(a: 0.19578656314593212d, b: 0.5518856023113755d, c: 0.03678706519505626d),

new NpgsqlTypes.NpgsqlLine(a: 0.9979102682728431d, b: 0.17094010621256894d, c: 0.7442257177884465d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.29987685154652477d, b: 0.4814809322225506d, c: 0.03625509847625208d),

new NpgsqlTypes.NpgsqlLine(a: 0.13940319988987238d, b: 0.6910089153052512d, c: 0.6894026211878942d),

new NpgsqlTypes.NpgsqlLine(a: 0.5426369434369982d, b: 0.618999594292415d, c: 0.6443713170324697d),

new NpgsqlTypes.NpgsqlLine(a: 0.18934745227349792d, b: 0.19866081977032368d, c: 0.26831484124117944d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 122, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 7, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 107, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 68, query1, 152, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 46, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 56, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 99, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 72, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 46, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 137);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
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
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI), typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                await ((INpgsqlLineListlineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                ((INpgsqlLineListlineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

