

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
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9576332401391544d, y: 0.45933792254324013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5669357941994934d, y: 0.8316377089895566d), new NpgsqlTypes.NpgsqlPoint(x: 0.24010972982507062d, y: 0.3785523657324379d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12817534682505582d, y: 0.2030970856906371d), new NpgsqlTypes.NpgsqlPoint(x: 0.9039359448400527d, y: 0.1633169140103896d), new NpgsqlTypes.NpgsqlPoint(x: 0.6013680519849313d, y: 0.9703658896348872d)),
},
            new NpgsqlPathpath0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41455066097019155d, y: 0.3239078417847501d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207543542182583d, y: 0.5825799671994152d), new NpgsqlTypes.NpgsqlPoint(x: 0.0696159651773347d, y: 0.9213219330001826d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41339520012401465d, y: 0.9314948630059997d), new NpgsqlTypes.NpgsqlPoint(x: 0.05431302410564254d, y: 0.37159105078100896d), new NpgsqlTypes.NpgsqlPoint(x: 0.2401032975744276d, y: 0.6447833852493334d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46554670392840536d, y: 0.6572102250967231d), new NpgsqlTypes.NpgsqlPoint(x: 0.060324195383359314d, y: 0.08922795308993536d), new NpgsqlTypes.NpgsqlPoint(x: 0.3339548916219509d, y: 0.9598620871498563d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8649639591530802d, y: 0.3447115768815129d), new NpgsqlTypes.NpgsqlPoint(x: 0.5005216051093212d, y: 0.5863297767445865d), new NpgsqlTypes.NpgsqlPoint(x: 0.14952387881888185d, y: 0.6325210607131629d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06231766747062406d, y: 0.4676650717252725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5101954358736812d, y: 0.18616856999556175d), new NpgsqlTypes.NpgsqlPoint(x: 0.08474439685792357d, y: 0.10033139875269292d)),
},
            new NpgsqlPathpath0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23974000144413765d, y: 0.0869508979519723d), new NpgsqlTypes.NpgsqlPoint(x: 0.563486398658351d, y: 0.5457473854702763d), new NpgsqlTypes.NpgsqlPoint(x: 0.07235758711617313d, y: 0.7201088431095325d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1316242258083291d, y: 0.023433697264384823d), new NpgsqlTypes.NpgsqlPoint(x: 0.6876138688735479d, y: 0.8357173192024563d), new NpgsqlTypes.NpgsqlPoint(x: 0.4301767540618672d, y: 0.9430756348646541d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3677704707095584d, y: 0.6574651504497302d), new NpgsqlTypes.NpgsqlPoint(x: 0.8500887804940094d, y: 0.6918559290980766d), new NpgsqlTypes.NpgsqlPoint(x: 0.18224497450493493d, y: 0.2683189924732716d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24257157752617475d, y: 0.8215802150488843d), new NpgsqlTypes.NpgsqlPoint(x: 0.8229383234066496d, y: 0.5954216703027906d), new NpgsqlTypes.NpgsqlPoint(x: 0.26565029419363817d, y: 0.07669302769539954d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354353651359225d, y: 0.8854103394748938d), new NpgsqlTypes.NpgsqlPoint(x: 0.819969453519607d, y: 0.7022812923696471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960579457055688d, y: 0.17210326279731458d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5521006217096874d, y: 0.13876334587300265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973205602615336d, y: 0.7937909211487328d), new NpgsqlTypes.NpgsqlPoint(x: 0.017517222537700605d, y: 0.1538133296845572d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.947314469746037d, y: 0.06007397787650026d), new NpgsqlTypes.NpgsqlPoint(x: 0.07026861376780802d, y: 0.8950388583226042d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217389562349547d, y: 0.7973302440415543d)),
},
            new NpgsqlPathpath0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6205177193239438d, y: 0.20994117784086286d), new NpgsqlTypes.NpgsqlPoint(x: 0.522972591423427d, y: 0.2416550207705308d), new NpgsqlTypes.NpgsqlPoint(x: 0.0791123464433231d, y: 0.2217676059432635d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10761291193897804d, y: 0.6187684733496859d), new NpgsqlTypes.NpgsqlPoint(x: 0.35180376289399473d, y: 0.5779251270649599d), new NpgsqlTypes.NpgsqlPoint(x: 0.39419596679725355d, y: 0.98468134665941d)),
},
            new NpgsqlPathpath0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21024477127272934d, y: 0.550597896722954d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274107196613242d, y: 0.9859771352033649d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612738971175555d, y: 0.02085838092590886d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35210455094627446d, y: 0.2668185967315283d), new NpgsqlTypes.NpgsqlPoint(x: 0.17286526469784746d, y: 0.7431287192441925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229772024425825d, y: 0.2324860852870918d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9022065408787371d, y: 0.5472991102200998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6426159137928417d, y: 0.5647336559153662d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756034820627494d, y: 0.4758419833525773d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5699498984523695d, y: 0.0914711729221992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6918453197609624d, y: 0.21420742930940984d), new NpgsqlTypes.NpgsqlPoint(x: 0.10987898838186083d, y: 0.9800856485260594d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4619052556522326d, y: 0.07934164830325274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163081908253618d, y: 0.4576592687921499d), new NpgsqlTypes.NpgsqlPoint(x: 0.649840136654796d, y: 0.8930361580619783d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04939404501959532d, y: 0.6874369660468862d), new NpgsqlTypes.NpgsqlPoint(x: 0.05439326279069312d, y: 0.5769137137387955d), new NpgsqlTypes.NpgsqlPoint(x: 0.11773396378647372d, y: 0.47020554138577164d)),
},
            new NpgsqlPathpath0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222809592562837d, y: 0.9738618803458092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491586423828622d, y: 0.22533177351224576d), new NpgsqlTypes.NpgsqlPoint(x: 0.31988227231952593d, y: 0.945272418311167d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4295506661069428d, y: 0.9036653251072669d), new NpgsqlTypes.NpgsqlPoint(x: 0.1692904983900404d, y: 0.8550543929533848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6287599048998377d, y: 0.6585342960356948d)),
},
            new NpgsqlPathpath0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.694034981486849d, y: 0.04430737019948938d), new NpgsqlTypes.NpgsqlPoint(x: 0.4056372509688374d, y: 0.5779892595510484d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396478855276732d, y: 0.31333431685066626d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5576897391122688d, y: 0.38353227793844225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7489326528665347d, y: 0.8552367973124373d), new NpgsqlTypes.NpgsqlPoint(x: 0.8085846594818833d, y: 0.008238872780806705d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3374057393139125d, y: 0.5486346922371237d), new NpgsqlTypes.NpgsqlPoint(x: 0.09576555871112025d, y: 0.7825180082476294d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843808669277987d, y: 0.9362464370755582d)),
},
            new NpgsqlPathpath0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9720693465440645d, y: 0.3096734806368232d), new NpgsqlTypes.NpgsqlPoint(x: 0.14576011157544488d, y: 0.03120260935552366d), new NpgsqlTypes.NpgsqlPoint(x: 0.739704470462192d, y: 0.6967629676152025d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5183420508505665d, y: 0.1388532113650367d), new NpgsqlTypes.NpgsqlPoint(x: 0.6263210605022433d, y: 0.8047571642346553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5399126006892919d, y: 0.03737085746016755d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8958341042196535d, y: 0.10279651935572165d), new NpgsqlTypes.NpgsqlPoint(x: 0.574219991103604d, y: 0.261990623804758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8706790794021695d, y: 0.1279408306319425d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5418835879300005d, y: 0.22600440709265845d), new NpgsqlTypes.NpgsqlPoint(x: 0.6263334935758723d, y: 0.8004685943673262d), new NpgsqlTypes.NpgsqlPoint(x: 0.5727468735198786d, y: 0.5139094969157693d)),
},
            new NpgsqlPathpath0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8124797694247746d, y: 0.9548516934780014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8116115177281236d, y: 0.2545642605368048d), new NpgsqlTypes.NpgsqlPoint(x: 0.498019517790544d, y: 0.02940323617940288d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795445700748453d, y: 0.2607357949204845d), new NpgsqlTypes.NpgsqlPoint(x: 0.38447584856096717d, y: 0.15967812959852168d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071305312799851d, y: 0.524500173758869d)),
},
            new NpgsqlPathpath0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7186711577886449d, y: 0.9359489938077897d), new NpgsqlTypes.NpgsqlPoint(x: 0.38881714783556265d, y: 0.5322584812434725d), new NpgsqlTypes.NpgsqlPoint(x: 0.847686911097251d, y: 0.7946429684981555d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1841874549641629d, y: 0.9434637134837148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126906977622609d, y: 0.6245756552838977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982821754929959d, y: 0.1870141423139957d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0819523614451313d, y: 0.3004451493034578d), new NpgsqlTypes.NpgsqlPoint(x: 0.39596056288849446d, y: 0.6147011781339276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662446547110525d, y: 0.3519876998978879d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8623866128314602d, y: 0.05634031427757735d), new NpgsqlTypes.NpgsqlPoint(x: 0.5891068849329306d, y: 0.6587545721974166d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751013432614151d, y: 0.21526893572754935d)),
},
            new NpgsqlPathpath0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06902651476308985d, y: 0.8409820686490553d), new NpgsqlTypes.NpgsqlPoint(x: 0.29126566126630304d, y: 0.08572379055472068d), new NpgsqlTypes.NpgsqlPoint(x: 0.4217330385932673d, y: 0.6511328182827587d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5229585355211653d, y: 0.959239951722031d), new NpgsqlTypes.NpgsqlPoint(x: 0.2928351653116944d, y: 0.7237609040262412d), new NpgsqlTypes.NpgsqlPoint(x: 0.0831010419233581d, y: 0.9011388438377497d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5988224351748479d, y: 0.25932213210371413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8961647037721452d, y: 0.929980108936219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8357710218478897d, y: 0.28390779114080134d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6347842474485562d, y: 0.7607499714469502d), new NpgsqlTypes.NpgsqlPoint(x: 0.7113406433075561d, y: 0.17572141650671036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9301328763726033d, y: 0.0691358343947196d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5511407819039968d, y: 0.7787917614597706d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273884879860537d, y: 0.23981728207183206d), new NpgsqlTypes.NpgsqlPoint(x: 0.4747456608079288d, y: 0.32221254124968435d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5173518906456204d, y: 0.9968297190731441d), new NpgsqlTypes.NpgsqlPoint(x: 0.17410753691081426d, y: 0.7292874962771108d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601494347474687d, y: 0.6148139549956915d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6146146888849903d, y: 0.7073506604419352d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018926643094706597d, y: 0.5021464513934448d), new NpgsqlTypes.NpgsqlPoint(x: 0.42079486035217617d, y: 0.902534502124119d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5403194525488011d, y: 0.9533691228964871d), new NpgsqlTypes.NpgsqlPoint(x: 0.017191704706036925d, y: 0.03974320062100045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315856205792646d, y: 0.39244988580009843d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3955965254301419d, y: 0.3752870331568158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371525288175237d, y: 0.5591289863571156d), new NpgsqlTypes.NpgsqlPoint(x: 0.17789367662307787d, y: 0.8289231355737624d)),
},
            new NpgsqlPathpath0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8262731055790727d, y: 0.16767765446592464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042855504473733d, y: 0.21872582744975655d), new NpgsqlTypes.NpgsqlPoint(x: 0.3169869361266602d, y: 0.39494171915533105d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07822768234778421d, y: 0.13771095274644463d), new NpgsqlTypes.NpgsqlPoint(x: 0.923948438616294d, y: 0.5467712184052453d), new NpgsqlTypes.NpgsqlPoint(x: 0.6532555252953447d, y: 0.6133663375493064d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.929963150461812d, y: 0.338469437669366d), new NpgsqlTypes.NpgsqlPoint(x: 0.49439683114449373d, y: 0.19446539541261265d), new NpgsqlTypes.NpgsqlPoint(x: 0.618833136997932d, y: 0.1519541485546012d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9967086587333408d, y: 0.7093923149507592d), new NpgsqlTypes.NpgsqlPoint(x: 0.6258176842356615d, y: 0.4601201666005158d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435307116523932d, y: 0.5876990935984988d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3756708266287435d, y: 0.5295407652471135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428941000431274d, y: 0.31337301932291217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7643189552296205d, y: 0.3483512298412649d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13804227112590617d, y: 0.4458709715692465d), new NpgsqlTypes.NpgsqlPoint(x: 0.2643701786114073d, y: 0.7503285116382882d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276793288758353d, y: 0.28959598786148666d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4742843142821741d, y: 0.324177863462361d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311696084871482d, y: 0.36115699605553164d), new NpgsqlTypes.NpgsqlPoint(x: 0.7566901261640911d, y: 0.09426813046258042d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3244293143272736d, y: 0.8731786374822194d), new NpgsqlTypes.NpgsqlPoint(x: 0.9305938335532001d, y: 0.06114908859423629d), new NpgsqlTypes.NpgsqlPoint(x: 0.33872194116289633d, y: 0.004669839167800838d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18108602558933717d, y: 0.9926539866618206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093257214320234d, y: 0.38269104734490855d), new NpgsqlTypes.NpgsqlPoint(x: 0.19223657998051047d, y: 0.3585589325846862d)),
},
            new NpgsqlPathpath0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41978014346704273d, y: 0.06555123878624314d), new NpgsqlTypes.NpgsqlPoint(x: 0.20947842282639095d, y: 0.47672115588239883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594584413117544d, y: 0.5641960699857139d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3501027966494873d, y: 0.33043488424471645d), new NpgsqlTypes.NpgsqlPoint(x: 0.678733469899695d, y: 0.2711072254483866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9218423551471759d, y: 0.6840439003812102d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9182166401319757d, y: 0.9162881047545324d), new NpgsqlTypes.NpgsqlPoint(x: 0.34840434028878375d, y: 0.0887096205791631d), new NpgsqlTypes.NpgsqlPoint(x: 0.9323250039880013d, y: 0.8989704645859633d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28621860154057854d, y: 0.9157556233269856d), new NpgsqlTypes.NpgsqlPoint(x: 0.9626100463583657d, y: 0.36673693866118307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4159119610351285d, y: 0.06837627964897008d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27040318368279204d, y: 0.8654584609755478d), new NpgsqlTypes.NpgsqlPoint(x: 0.7656509326255835d, y: 0.531739886542281d), new NpgsqlTypes.NpgsqlPoint(x: 0.6851405220578008d, y: 0.7113918964459949d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611478874095123d, y: 0.152028595026523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614379732455213d, y: 0.6487440057003333d), new NpgsqlTypes.NpgsqlPoint(x: 0.9794184804886265d, y: 0.05745259414089576d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5832118343154867d, y: 0.44233346332529266d), new NpgsqlTypes.NpgsqlPoint(x: 0.20370130329042002d, y: 0.07456128874653034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5862382153581306d, y: 0.904072999909252d)),
},
            new NpgsqlPathpath0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8689754745982123d, y: 0.04620129657728711d), new NpgsqlTypes.NpgsqlPoint(x: 0.6147757419711256d, y: 0.7366021685606154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7811435546515358d, y: 0.16420244452138022d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7340808424142611d, y: 0.7762024950120616d), new NpgsqlTypes.NpgsqlPoint(x: 0.03339435290324744d, y: 0.8052726723716244d), new NpgsqlTypes.NpgsqlPoint(x: 0.20042799440473735d, y: 0.569273200028685d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.944247213169102d, y: 0.5030685733913408d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468449309552925d, y: 0.2403747928451131d), new NpgsqlTypes.NpgsqlPoint(x: 0.9778425013646432d, y: 0.3622665355264729d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7099704717525804d, y: 0.36456774172560913d), new NpgsqlTypes.NpgsqlPoint(x: 0.4071527746829502d, y: 0.8839769950978815d), new NpgsqlTypes.NpgsqlPoint(x: 0.1113484103081045d, y: 0.5710763051376342d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3406287819690962d, y: 0.9321572207538695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5959350410541862d, y: 0.34904229924104124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725877546571891d, y: 0.2693766354447227d)),
},
            new NpgsqlPathpath0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35507387793526024d, y: 0.2987233767145968d), new NpgsqlTypes.NpgsqlPoint(x: 0.67382890118405d, y: 0.01297662858046078d), new NpgsqlTypes.NpgsqlPoint(x: 0.0821669844603895d, y: 0.5390458099413197d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6180794370246705d, y: 0.3291832363030336d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006938903166756d, y: 0.4374744327632266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598287023223462d, y: 0.0523231926258787d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1482437504562042d, y: 0.9752859882537578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6818542425810106d, y: 0.9981942000360424d), new NpgsqlTypes.NpgsqlPoint(x: 0.4214187979483256d, y: 0.1883435158458805d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047849028441635855d, y: 0.9267641731412695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217212745433409d, y: 0.8687364311745326d), new NpgsqlTypes.NpgsqlPoint(x: 0.3336729406156044d, y: 0.400438998691952d)),
},
            new NpgsqlPathpath0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4127893120796464d, y: 0.6131585877383213d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342828549274372d, y: 0.930527661785199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022399150075754d, y: 0.8835157501790787d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4310165646511491d, y: 0.877823267297954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8567037169397427d, y: 0.0510105144305496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8918799507986028d, y: 0.04614915594992908d)),
},
            new NpgsqlPathpath0M
{
    Id = 175,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4698270144885348d, y: 0.6965932620902773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871074064020384d, y: 0.7313776499490173d), new NpgsqlTypes.NpgsqlPoint(x: 0.5123229628011189d, y: 0.6856332971548607d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2919958491994423d, y: 0.06109346573409835d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131527226370466d, y: 0.6161449903584771d), new NpgsqlTypes.NpgsqlPoint(x: 0.46733182597951173d, y: 0.06804883921970295d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4691039378086621d, y: 0.2816145715926309d), new NpgsqlTypes.NpgsqlPoint(x: 0.535909444884509d, y: 0.9828621602897348d), new NpgsqlTypes.NpgsqlPoint(x: 0.2591682702606164d, y: 0.023907915785195577d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 181,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34291793167736107d, y: 0.306266946363833d), new NpgsqlTypes.NpgsqlPoint(x: 0.942577797847795d, y: 0.5979384155066992d), new NpgsqlTypes.NpgsqlPoint(x: 0.4272663288762747d, y: 0.1659409236220949d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024025295536953983d, y: 0.20926841798524654d), new NpgsqlTypes.NpgsqlPoint(x: 0.03814627799616088d, y: 0.7767498755130715d), new NpgsqlTypes.NpgsqlPoint(x: 0.838166430185729d, y: 0.7424786065454436d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.947314469746037d, y: 0.06007397787650026d), new NpgsqlTypes.NpgsqlPoint(x: 0.07026861376780802d, y: 0.8950388583226042d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217389562349547d, y: 0.7973302440415543d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10761291193897804d, y: 0.6187684733496859d), new NpgsqlTypes.NpgsqlPoint(x: 0.35180376289399473d, y: 0.5779251270649599d), new NpgsqlTypes.NpgsqlPoint(x: 0.39419596679725355d, y: 0.98468134665941d))));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04939404501959532d, y: 0.6874369660468862d), new NpgsqlTypes.NpgsqlPoint(x: 0.05439326279069312d, y: 0.5769137137387955d), new NpgsqlTypes.NpgsqlPoint(x: 0.11773396378647372d, y: 0.47020554138577164d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4295506661069428d, y: 0.9036653251072669d), new NpgsqlTypes.NpgsqlPoint(x: 0.1692904983900404d, y: 0.8550543929533848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6287599048998377d, y: 0.6585342960356948d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3374057393139125d, y: 0.5486346922371237d), new NpgsqlTypes.NpgsqlPoint(x: 0.09576555871112025d, y: 0.7825180082476294d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843808669277987d, y: 0.9362464370755582d))));
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[32],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 48, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[34], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 138, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 59, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 23, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
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
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 69, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 51, query1, 161, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 152, query1, 49, query2))
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 14, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 150, 59))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 161, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[34], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 140);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[29], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[30], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[31], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[30], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[31], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9576332401391544d, y: 0.45933792254324013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5669357941994934d, y: 0.8316377089895566d), new NpgsqlTypes.NpgsqlPoint(x: 0.24010972982507062d, y: 0.3785523657324379d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12817534682505582d, y: 0.2030970856906371d), new NpgsqlTypes.NpgsqlPoint(x: 0.9039359448400527d, y: 0.1633169140103896d), new NpgsqlTypes.NpgsqlPoint(x: 0.6013680519849313d, y: 0.9703658896348872d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41455066097019155d, y: 0.3239078417847501d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207543542182583d, y: 0.5825799671994152d), new NpgsqlTypes.NpgsqlPoint(x: 0.0696159651773347d, y: 0.9213219330001826d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41339520012401465d, y: 0.9314948630059997d), new NpgsqlTypes.NpgsqlPoint(x: 0.05431302410564254d, y: 0.37159105078100896d), new NpgsqlTypes.NpgsqlPoint(x: 0.2401032975744276d, y: 0.6447833852493334d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46554670392840536d, y: 0.6572102250967231d), new NpgsqlTypes.NpgsqlPoint(x: 0.060324195383359314d, y: 0.08922795308993536d), new NpgsqlTypes.NpgsqlPoint(x: 0.3339548916219509d, y: 0.9598620871498563d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8649639591530802d, y: 0.3447115768815129d), new NpgsqlTypes.NpgsqlPoint(x: 0.5005216051093212d, y: 0.5863297767445865d), new NpgsqlTypes.NpgsqlPoint(x: 0.14952387881888185d, y: 0.6325210607131629d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06231766747062406d, y: 0.4676650717252725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5101954358736812d, y: 0.18616856999556175d), new NpgsqlTypes.NpgsqlPoint(x: 0.08474439685792357d, y: 0.10033139875269292d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23974000144413765d, y: 0.0869508979519723d), new NpgsqlTypes.NpgsqlPoint(x: 0.563486398658351d, y: 0.5457473854702763d), new NpgsqlTypes.NpgsqlPoint(x: 0.07235758711617313d, y: 0.7201088431095325d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1316242258083291d, y: 0.023433697264384823d), new NpgsqlTypes.NpgsqlPoint(x: 0.6876138688735479d, y: 0.8357173192024563d), new NpgsqlTypes.NpgsqlPoint(x: 0.4301767540618672d, y: 0.9430756348646541d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3677704707095584d, y: 0.6574651504497302d), new NpgsqlTypes.NpgsqlPoint(x: 0.8500887804940094d, y: 0.6918559290980766d), new NpgsqlTypes.NpgsqlPoint(x: 0.18224497450493493d, y: 0.2683189924732716d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24257157752617475d, y: 0.8215802150488843d), new NpgsqlTypes.NpgsqlPoint(x: 0.8229383234066496d, y: 0.5954216703027906d), new NpgsqlTypes.NpgsqlPoint(x: 0.26565029419363817d, y: 0.07669302769539954d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354353651359225d, y: 0.8854103394748938d), new NpgsqlTypes.NpgsqlPoint(x: 0.819969453519607d, y: 0.7022812923696471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960579457055688d, y: 0.17210326279731458d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5521006217096874d, y: 0.13876334587300265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973205602615336d, y: 0.7937909211487328d), new NpgsqlTypes.NpgsqlPoint(x: 0.017517222537700605d, y: 0.1538133296845572d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.947314469746037d, y: 0.06007397787650026d), new NpgsqlTypes.NpgsqlPoint(x: 0.07026861376780802d, y: 0.8950388583226042d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217389562349547d, y: 0.7973302440415543d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6205177193239438d, y: 0.20994117784086286d), new NpgsqlTypes.NpgsqlPoint(x: 0.522972591423427d, y: 0.2416550207705308d), new NpgsqlTypes.NpgsqlPoint(x: 0.0791123464433231d, y: 0.2217676059432635d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10761291193897804d, y: 0.6187684733496859d), new NpgsqlTypes.NpgsqlPoint(x: 0.35180376289399473d, y: 0.5779251270649599d), new NpgsqlTypes.NpgsqlPoint(x: 0.39419596679725355d, y: 0.98468134665941d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21024477127272934d, y: 0.550597896722954d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274107196613242d, y: 0.9859771352033649d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612738971175555d, y: 0.02085838092590886d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35210455094627446d, y: 0.2668185967315283d), new NpgsqlTypes.NpgsqlPoint(x: 0.17286526469784746d, y: 0.7431287192441925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229772024425825d, y: 0.2324860852870918d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9022065408787371d, y: 0.5472991102200998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6426159137928417d, y: 0.5647336559153662d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756034820627494d, y: 0.4758419833525773d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5699498984523695d, y: 0.0914711729221992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6918453197609624d, y: 0.21420742930940984d), new NpgsqlTypes.NpgsqlPoint(x: 0.10987898838186083d, y: 0.9800856485260594d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4619052556522326d, y: 0.07934164830325274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163081908253618d, y: 0.4576592687921499d), new NpgsqlTypes.NpgsqlPoint(x: 0.649840136654796d, y: 0.8930361580619783d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04939404501959532d, y: 0.6874369660468862d), new NpgsqlTypes.NpgsqlPoint(x: 0.05439326279069312d, y: 0.5769137137387955d), new NpgsqlTypes.NpgsqlPoint(x: 0.11773396378647372d, y: 0.47020554138577164d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222809592562837d, y: 0.9738618803458092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491586423828622d, y: 0.22533177351224576d), new NpgsqlTypes.NpgsqlPoint(x: 0.31988227231952593d, y: 0.945272418311167d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4295506661069428d, y: 0.9036653251072669d), new NpgsqlTypes.NpgsqlPoint(x: 0.1692904983900404d, y: 0.8550543929533848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6287599048998377d, y: 0.6585342960356948d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.694034981486849d, y: 0.04430737019948938d), new NpgsqlTypes.NpgsqlPoint(x: 0.4056372509688374d, y: 0.5779892595510484d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396478855276732d, y: 0.31333431685066626d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5576897391122688d, y: 0.38353227793844225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7489326528665347d, y: 0.8552367973124373d), new NpgsqlTypes.NpgsqlPoint(x: 0.8085846594818833d, y: 0.008238872780806705d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3374057393139125d, y: 0.5486346922371237d), new NpgsqlTypes.NpgsqlPoint(x: 0.09576555871112025d, y: 0.7825180082476294d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843808669277987d, y: 0.9362464370755582d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9720693465440645d, y: 0.3096734806368232d), new NpgsqlTypes.NpgsqlPoint(x: 0.14576011157544488d, y: 0.03120260935552366d), new NpgsqlTypes.NpgsqlPoint(x: 0.739704470462192d, y: 0.6967629676152025d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5183420508505665d, y: 0.1388532113650367d), new NpgsqlTypes.NpgsqlPoint(x: 0.6263210605022433d, y: 0.8047571642346553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5399126006892919d, y: 0.03737085746016755d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8958341042196535d, y: 0.10279651935572165d), new NpgsqlTypes.NpgsqlPoint(x: 0.574219991103604d, y: 0.261990623804758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8706790794021695d, y: 0.1279408306319425d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5418835879300005d, y: 0.22600440709265845d), new NpgsqlTypes.NpgsqlPoint(x: 0.6263334935758723d, y: 0.8004685943673262d), new NpgsqlTypes.NpgsqlPoint(x: 0.5727468735198786d, y: 0.5139094969157693d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8124797694247746d, y: 0.9548516934780014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8116115177281236d, y: 0.2545642605368048d), new NpgsqlTypes.NpgsqlPoint(x: 0.498019517790544d, y: 0.02940323617940288d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795445700748453d, y: 0.2607357949204845d), new NpgsqlTypes.NpgsqlPoint(x: 0.38447584856096717d, y: 0.15967812959852168d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071305312799851d, y: 0.524500173758869d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7186711577886449d, y: 0.9359489938077897d), new NpgsqlTypes.NpgsqlPoint(x: 0.38881714783556265d, y: 0.5322584812434725d), new NpgsqlTypes.NpgsqlPoint(x: 0.847686911097251d, y: 0.7946429684981555d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1841874549641629d, y: 0.9434637134837148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126906977622609d, y: 0.6245756552838977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982821754929959d, y: 0.1870141423139957d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0819523614451313d, y: 0.3004451493034578d), new NpgsqlTypes.NpgsqlPoint(x: 0.39596056288849446d, y: 0.6147011781339276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662446547110525d, y: 0.3519876998978879d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8623866128314602d, y: 0.05634031427757735d), new NpgsqlTypes.NpgsqlPoint(x: 0.5891068849329306d, y: 0.6587545721974166d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751013432614151d, y: 0.21526893572754935d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06902651476308985d, y: 0.8409820686490553d), new NpgsqlTypes.NpgsqlPoint(x: 0.29126566126630304d, y: 0.08572379055472068d), new NpgsqlTypes.NpgsqlPoint(x: 0.4217330385932673d, y: 0.6511328182827587d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5229585355211653d, y: 0.959239951722031d), new NpgsqlTypes.NpgsqlPoint(x: 0.2928351653116944d, y: 0.7237609040262412d), new NpgsqlTypes.NpgsqlPoint(x: 0.0831010419233581d, y: 0.9011388438377497d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5988224351748479d, y: 0.25932213210371413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8961647037721452d, y: 0.929980108936219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8357710218478897d, y: 0.28390779114080134d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6347842474485562d, y: 0.7607499714469502d), new NpgsqlTypes.NpgsqlPoint(x: 0.7113406433075561d, y: 0.17572141650671036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9301328763726033d, y: 0.0691358343947196d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5511407819039968d, y: 0.7787917614597706d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273884879860537d, y: 0.23981728207183206d), new NpgsqlTypes.NpgsqlPoint(x: 0.4747456608079288d, y: 0.32221254124968435d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5173518906456204d, y: 0.9968297190731441d), new NpgsqlTypes.NpgsqlPoint(x: 0.17410753691081426d, y: 0.7292874962771108d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601494347474687d, y: 0.6148139549956915d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6146146888849903d, y: 0.7073506604419352d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018926643094706597d, y: 0.5021464513934448d), new NpgsqlTypes.NpgsqlPoint(x: 0.42079486035217617d, y: 0.902534502124119d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5403194525488011d, y: 0.9533691228964871d), new NpgsqlTypes.NpgsqlPoint(x: 0.017191704706036925d, y: 0.03974320062100045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315856205792646d, y: 0.39244988580009843d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3955965254301419d, y: 0.3752870331568158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371525288175237d, y: 0.5591289863571156d), new NpgsqlTypes.NpgsqlPoint(x: 0.17789367662307787d, y: 0.8289231355737624d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8262731055790727d, y: 0.16767765446592464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042855504473733d, y: 0.21872582744975655d), new NpgsqlTypes.NpgsqlPoint(x: 0.3169869361266602d, y: 0.39494171915533105d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07822768234778421d, y: 0.13771095274644463d), new NpgsqlTypes.NpgsqlPoint(x: 0.923948438616294d, y: 0.5467712184052453d), new NpgsqlTypes.NpgsqlPoint(x: 0.6532555252953447d, y: 0.6133663375493064d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.929963150461812d, y: 0.338469437669366d), new NpgsqlTypes.NpgsqlPoint(x: 0.49439683114449373d, y: 0.19446539541261265d), new NpgsqlTypes.NpgsqlPoint(x: 0.618833136997932d, y: 0.1519541485546012d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9967086587333408d, y: 0.7093923149507592d), new NpgsqlTypes.NpgsqlPoint(x: 0.6258176842356615d, y: 0.4601201666005158d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435307116523932d, y: 0.5876990935984988d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3756708266287435d, y: 0.5295407652471135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428941000431274d, y: 0.31337301932291217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7643189552296205d, y: 0.3483512298412649d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13804227112590617d, y: 0.4458709715692465d), new NpgsqlTypes.NpgsqlPoint(x: 0.2643701786114073d, y: 0.7503285116382882d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276793288758353d, y: 0.28959598786148666d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4742843142821741d, y: 0.324177863462361d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311696084871482d, y: 0.36115699605553164d), new NpgsqlTypes.NpgsqlPoint(x: 0.7566901261640911d, y: 0.09426813046258042d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3244293143272736d, y: 0.8731786374822194d), new NpgsqlTypes.NpgsqlPoint(x: 0.9305938335532001d, y: 0.06114908859423629d), new NpgsqlTypes.NpgsqlPoint(x: 0.33872194116289633d, y: 0.004669839167800838d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18108602558933717d, y: 0.9926539866618206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093257214320234d, y: 0.38269104734490855d), new NpgsqlTypes.NpgsqlPoint(x: 0.19223657998051047d, y: 0.3585589325846862d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41978014346704273d, y: 0.06555123878624314d), new NpgsqlTypes.NpgsqlPoint(x: 0.20947842282639095d, y: 0.47672115588239883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594584413117544d, y: 0.5641960699857139d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3501027966494873d, y: 0.33043488424471645d), new NpgsqlTypes.NpgsqlPoint(x: 0.678733469899695d, y: 0.2711072254483866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9218423551471759d, y: 0.6840439003812102d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9182166401319757d, y: 0.9162881047545324d), new NpgsqlTypes.NpgsqlPoint(x: 0.34840434028878375d, y: 0.0887096205791631d), new NpgsqlTypes.NpgsqlPoint(x: 0.9323250039880013d, y: 0.8989704645859633d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28621860154057854d, y: 0.9157556233269856d), new NpgsqlTypes.NpgsqlPoint(x: 0.9626100463583657d, y: 0.36673693866118307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4159119610351285d, y: 0.06837627964897008d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27040318368279204d, y: 0.8654584609755478d), new NpgsqlTypes.NpgsqlPoint(x: 0.7656509326255835d, y: 0.531739886542281d), new NpgsqlTypes.NpgsqlPoint(x: 0.6851405220578008d, y: 0.7113918964459949d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611478874095123d, y: 0.152028595026523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614379732455213d, y: 0.6487440057003333d), new NpgsqlTypes.NpgsqlPoint(x: 0.9794184804886265d, y: 0.05745259414089576d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5832118343154867d, y: 0.44233346332529266d), new NpgsqlTypes.NpgsqlPoint(x: 0.20370130329042002d, y: 0.07456128874653034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5862382153581306d, y: 0.904072999909252d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8689754745982123d, y: 0.04620129657728711d), new NpgsqlTypes.NpgsqlPoint(x: 0.6147757419711256d, y: 0.7366021685606154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7811435546515358d, y: 0.16420244452138022d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7340808424142611d, y: 0.7762024950120616d), new NpgsqlTypes.NpgsqlPoint(x: 0.03339435290324744d, y: 0.8052726723716244d), new NpgsqlTypes.NpgsqlPoint(x: 0.20042799440473735d, y: 0.569273200028685d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.944247213169102d, y: 0.5030685733913408d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468449309552925d, y: 0.2403747928451131d), new NpgsqlTypes.NpgsqlPoint(x: 0.9778425013646432d, y: 0.3622665355264729d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7099704717525804d, y: 0.36456774172560913d), new NpgsqlTypes.NpgsqlPoint(x: 0.4071527746829502d, y: 0.8839769950978815d), new NpgsqlTypes.NpgsqlPoint(x: 0.1113484103081045d, y: 0.5710763051376342d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3406287819690962d, y: 0.9321572207538695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5959350410541862d, y: 0.34904229924104124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725877546571891d, y: 0.2693766354447227d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35507387793526024d, y: 0.2987233767145968d), new NpgsqlTypes.NpgsqlPoint(x: 0.67382890118405d, y: 0.01297662858046078d), new NpgsqlTypes.NpgsqlPoint(x: 0.0821669844603895d, y: 0.5390458099413197d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6180794370246705d, y: 0.3291832363030336d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006938903166756d, y: 0.4374744327632266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598287023223462d, y: 0.0523231926258787d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1482437504562042d, y: 0.9752859882537578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6818542425810106d, y: 0.9981942000360424d), new NpgsqlTypes.NpgsqlPoint(x: 0.4214187979483256d, y: 0.1883435158458805d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047849028441635855d, y: 0.9267641731412695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217212745433409d, y: 0.8687364311745326d), new NpgsqlTypes.NpgsqlPoint(x: 0.3336729406156044d, y: 0.400438998691952d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4127893120796464d, y: 0.6131585877383213d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342828549274372d, y: 0.930527661785199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022399150075754d, y: 0.8835157501790787d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4310165646511491d, y: 0.877823267297954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8567037169397427d, y: 0.0510105144305496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8918799507986028d, y: 0.04614915594992908d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4698270144885348d, y: 0.6965932620902773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871074064020384d, y: 0.7313776499490173d), new NpgsqlTypes.NpgsqlPoint(x: 0.5123229628011189d, y: 0.6856332971548607d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2919958491994423d, y: 0.06109346573409835d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131527226370466d, y: 0.6161449903584771d), new NpgsqlTypes.NpgsqlPoint(x: 0.46733182597951173d, y: 0.06804883921970295d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4691039378086621d, y: 0.2816145715926309d), new NpgsqlTypes.NpgsqlPoint(x: 0.535909444884509d, y: 0.9828621602897348d), new NpgsqlTypes.NpgsqlPoint(x: 0.2591682702606164d, y: 0.023907915785195577d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34291793167736107d, y: 0.306266946363833d), new NpgsqlTypes.NpgsqlPoint(x: 0.942577797847795d, y: 0.5979384155066992d), new NpgsqlTypes.NpgsqlPoint(x: 0.4272663288762747d, y: 0.1659409236220949d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024025295536953983d, y: 0.20926841798524654d), new NpgsqlTypes.NpgsqlPoint(x: 0.03814627799616088d, y: 0.7767498755130715d), new NpgsqlTypes.NpgsqlPoint(x: 0.838166430185729d, y: 0.7424786065454436d)))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9576332401391544d, y: 0.45933792254324013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5669357941994934d, y: 0.8316377089895566d), new NpgsqlTypes.NpgsqlPoint(x: 0.24010972982507062d, y: 0.3785523657324379d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12817534682505582d, y: 0.2030970856906371d), new NpgsqlTypes.NpgsqlPoint(x: 0.9039359448400527d, y: 0.1633169140103896d), new NpgsqlTypes.NpgsqlPoint(x: 0.6013680519849313d, y: 0.9703658896348872d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41455066097019155d, y: 0.3239078417847501d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207543542182583d, y: 0.5825799671994152d), new NpgsqlTypes.NpgsqlPoint(x: 0.0696159651773347d, y: 0.9213219330001826d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41339520012401465d, y: 0.9314948630059997d), new NpgsqlTypes.NpgsqlPoint(x: 0.05431302410564254d, y: 0.37159105078100896d), new NpgsqlTypes.NpgsqlPoint(x: 0.2401032975744276d, y: 0.6447833852493334d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46554670392840536d, y: 0.6572102250967231d), new NpgsqlTypes.NpgsqlPoint(x: 0.060324195383359314d, y: 0.08922795308993536d), new NpgsqlTypes.NpgsqlPoint(x: 0.3339548916219509d, y: 0.9598620871498563d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8649639591530802d, y: 0.3447115768815129d), new NpgsqlTypes.NpgsqlPoint(x: 0.5005216051093212d, y: 0.5863297767445865d), new NpgsqlTypes.NpgsqlPoint(x: 0.14952387881888185d, y: 0.6325210607131629d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06231766747062406d, y: 0.4676650717252725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5101954358736812d, y: 0.18616856999556175d), new NpgsqlTypes.NpgsqlPoint(x: 0.08474439685792357d, y: 0.10033139875269292d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23974000144413765d, y: 0.0869508979519723d), new NpgsqlTypes.NpgsqlPoint(x: 0.563486398658351d, y: 0.5457473854702763d), new NpgsqlTypes.NpgsqlPoint(x: 0.07235758711617313d, y: 0.7201088431095325d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1316242258083291d, y: 0.023433697264384823d), new NpgsqlTypes.NpgsqlPoint(x: 0.6876138688735479d, y: 0.8357173192024563d), new NpgsqlTypes.NpgsqlPoint(x: 0.4301767540618672d, y: 0.9430756348646541d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3677704707095584d, y: 0.6574651504497302d), new NpgsqlTypes.NpgsqlPoint(x: 0.8500887804940094d, y: 0.6918559290980766d), new NpgsqlTypes.NpgsqlPoint(x: 0.18224497450493493d, y: 0.2683189924732716d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24257157752617475d, y: 0.8215802150488843d), new NpgsqlTypes.NpgsqlPoint(x: 0.8229383234066496d, y: 0.5954216703027906d), new NpgsqlTypes.NpgsqlPoint(x: 0.26565029419363817d, y: 0.07669302769539954d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354353651359225d, y: 0.8854103394748938d), new NpgsqlTypes.NpgsqlPoint(x: 0.819969453519607d, y: 0.7022812923696471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960579457055688d, y: 0.17210326279731458d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5521006217096874d, y: 0.13876334587300265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973205602615336d, y: 0.7937909211487328d), new NpgsqlTypes.NpgsqlPoint(x: 0.017517222537700605d, y: 0.1538133296845572d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.947314469746037d, y: 0.06007397787650026d), new NpgsqlTypes.NpgsqlPoint(x: 0.07026861376780802d, y: 0.8950388583226042d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217389562349547d, y: 0.7973302440415543d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6205177193239438d, y: 0.20994117784086286d), new NpgsqlTypes.NpgsqlPoint(x: 0.522972591423427d, y: 0.2416550207705308d), new NpgsqlTypes.NpgsqlPoint(x: 0.0791123464433231d, y: 0.2217676059432635d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10761291193897804d, y: 0.6187684733496859d), new NpgsqlTypes.NpgsqlPoint(x: 0.35180376289399473d, y: 0.5779251270649599d), new NpgsqlTypes.NpgsqlPoint(x: 0.39419596679725355d, y: 0.98468134665941d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21024477127272934d, y: 0.550597896722954d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274107196613242d, y: 0.9859771352033649d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612738971175555d, y: 0.02085838092590886d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35210455094627446d, y: 0.2668185967315283d), new NpgsqlTypes.NpgsqlPoint(x: 0.17286526469784746d, y: 0.7431287192441925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229772024425825d, y: 0.2324860852870918d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9022065408787371d, y: 0.5472991102200998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6426159137928417d, y: 0.5647336559153662d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756034820627494d, y: 0.4758419833525773d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5699498984523695d, y: 0.0914711729221992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6918453197609624d, y: 0.21420742930940984d), new NpgsqlTypes.NpgsqlPoint(x: 0.10987898838186083d, y: 0.9800856485260594d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4619052556522326d, y: 0.07934164830325274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163081908253618d, y: 0.4576592687921499d), new NpgsqlTypes.NpgsqlPoint(x: 0.649840136654796d, y: 0.8930361580619783d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04939404501959532d, y: 0.6874369660468862d), new NpgsqlTypes.NpgsqlPoint(x: 0.05439326279069312d, y: 0.5769137137387955d), new NpgsqlTypes.NpgsqlPoint(x: 0.11773396378647372d, y: 0.47020554138577164d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222809592562837d, y: 0.9738618803458092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491586423828622d, y: 0.22533177351224576d), new NpgsqlTypes.NpgsqlPoint(x: 0.31988227231952593d, y: 0.945272418311167d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4295506661069428d, y: 0.9036653251072669d), new NpgsqlTypes.NpgsqlPoint(x: 0.1692904983900404d, y: 0.8550543929533848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6287599048998377d, y: 0.6585342960356948d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.694034981486849d, y: 0.04430737019948938d), new NpgsqlTypes.NpgsqlPoint(x: 0.4056372509688374d, y: 0.5779892595510484d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396478855276732d, y: 0.31333431685066626d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5576897391122688d, y: 0.38353227793844225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7489326528665347d, y: 0.8552367973124373d), new NpgsqlTypes.NpgsqlPoint(x: 0.8085846594818833d, y: 0.008238872780806705d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3374057393139125d, y: 0.5486346922371237d), new NpgsqlTypes.NpgsqlPoint(x: 0.09576555871112025d, y: 0.7825180082476294d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843808669277987d, y: 0.9362464370755582d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9720693465440645d, y: 0.3096734806368232d), new NpgsqlTypes.NpgsqlPoint(x: 0.14576011157544488d, y: 0.03120260935552366d), new NpgsqlTypes.NpgsqlPoint(x: 0.739704470462192d, y: 0.6967629676152025d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5183420508505665d, y: 0.1388532113650367d), new NpgsqlTypes.NpgsqlPoint(x: 0.6263210605022433d, y: 0.8047571642346553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5399126006892919d, y: 0.03737085746016755d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8958341042196535d, y: 0.10279651935572165d), new NpgsqlTypes.NpgsqlPoint(x: 0.574219991103604d, y: 0.261990623804758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8706790794021695d, y: 0.1279408306319425d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5418835879300005d, y: 0.22600440709265845d), new NpgsqlTypes.NpgsqlPoint(x: 0.6263334935758723d, y: 0.8004685943673262d), new NpgsqlTypes.NpgsqlPoint(x: 0.5727468735198786d, y: 0.5139094969157693d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8124797694247746d, y: 0.9548516934780014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8116115177281236d, y: 0.2545642605368048d), new NpgsqlTypes.NpgsqlPoint(x: 0.498019517790544d, y: 0.02940323617940288d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795445700748453d, y: 0.2607357949204845d), new NpgsqlTypes.NpgsqlPoint(x: 0.38447584856096717d, y: 0.15967812959852168d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071305312799851d, y: 0.524500173758869d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7186711577886449d, y: 0.9359489938077897d), new NpgsqlTypes.NpgsqlPoint(x: 0.38881714783556265d, y: 0.5322584812434725d), new NpgsqlTypes.NpgsqlPoint(x: 0.847686911097251d, y: 0.7946429684981555d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1841874549641629d, y: 0.9434637134837148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126906977622609d, y: 0.6245756552838977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982821754929959d, y: 0.1870141423139957d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0819523614451313d, y: 0.3004451493034578d), new NpgsqlTypes.NpgsqlPoint(x: 0.39596056288849446d, y: 0.6147011781339276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662446547110525d, y: 0.3519876998978879d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8623866128314602d, y: 0.05634031427757735d), new NpgsqlTypes.NpgsqlPoint(x: 0.5891068849329306d, y: 0.6587545721974166d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751013432614151d, y: 0.21526893572754935d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06902651476308985d, y: 0.8409820686490553d), new NpgsqlTypes.NpgsqlPoint(x: 0.29126566126630304d, y: 0.08572379055472068d), new NpgsqlTypes.NpgsqlPoint(x: 0.4217330385932673d, y: 0.6511328182827587d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5229585355211653d, y: 0.959239951722031d), new NpgsqlTypes.NpgsqlPoint(x: 0.2928351653116944d, y: 0.7237609040262412d), new NpgsqlTypes.NpgsqlPoint(x: 0.0831010419233581d, y: 0.9011388438377497d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5988224351748479d, y: 0.25932213210371413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8961647037721452d, y: 0.929980108936219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8357710218478897d, y: 0.28390779114080134d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6347842474485562d, y: 0.7607499714469502d), new NpgsqlTypes.NpgsqlPoint(x: 0.7113406433075561d, y: 0.17572141650671036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9301328763726033d, y: 0.0691358343947196d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5511407819039968d, y: 0.7787917614597706d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273884879860537d, y: 0.23981728207183206d), new NpgsqlTypes.NpgsqlPoint(x: 0.4747456608079288d, y: 0.32221254124968435d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5173518906456204d, y: 0.9968297190731441d), new NpgsqlTypes.NpgsqlPoint(x: 0.17410753691081426d, y: 0.7292874962771108d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601494347474687d, y: 0.6148139549956915d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6146146888849903d, y: 0.7073506604419352d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018926643094706597d, y: 0.5021464513934448d), new NpgsqlTypes.NpgsqlPoint(x: 0.42079486035217617d, y: 0.902534502124119d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5403194525488011d, y: 0.9533691228964871d), new NpgsqlTypes.NpgsqlPoint(x: 0.017191704706036925d, y: 0.03974320062100045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315856205792646d, y: 0.39244988580009843d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3955965254301419d, y: 0.3752870331568158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371525288175237d, y: 0.5591289863571156d), new NpgsqlTypes.NpgsqlPoint(x: 0.17789367662307787d, y: 0.8289231355737624d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8262731055790727d, y: 0.16767765446592464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042855504473733d, y: 0.21872582744975655d), new NpgsqlTypes.NpgsqlPoint(x: 0.3169869361266602d, y: 0.39494171915533105d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07822768234778421d, y: 0.13771095274644463d), new NpgsqlTypes.NpgsqlPoint(x: 0.923948438616294d, y: 0.5467712184052453d), new NpgsqlTypes.NpgsqlPoint(x: 0.6532555252953447d, y: 0.6133663375493064d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.929963150461812d, y: 0.338469437669366d), new NpgsqlTypes.NpgsqlPoint(x: 0.49439683114449373d, y: 0.19446539541261265d), new NpgsqlTypes.NpgsqlPoint(x: 0.618833136997932d, y: 0.1519541485546012d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9967086587333408d, y: 0.7093923149507592d), new NpgsqlTypes.NpgsqlPoint(x: 0.6258176842356615d, y: 0.4601201666005158d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435307116523932d, y: 0.5876990935984988d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3756708266287435d, y: 0.5295407652471135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428941000431274d, y: 0.31337301932291217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7643189552296205d, y: 0.3483512298412649d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13804227112590617d, y: 0.4458709715692465d), new NpgsqlTypes.NpgsqlPoint(x: 0.2643701786114073d, y: 0.7503285116382882d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276793288758353d, y: 0.28959598786148666d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4742843142821741d, y: 0.324177863462361d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311696084871482d, y: 0.36115699605553164d), new NpgsqlTypes.NpgsqlPoint(x: 0.7566901261640911d, y: 0.09426813046258042d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3244293143272736d, y: 0.8731786374822194d), new NpgsqlTypes.NpgsqlPoint(x: 0.9305938335532001d, y: 0.06114908859423629d), new NpgsqlTypes.NpgsqlPoint(x: 0.33872194116289633d, y: 0.004669839167800838d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18108602558933717d, y: 0.9926539866618206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093257214320234d, y: 0.38269104734490855d), new NpgsqlTypes.NpgsqlPoint(x: 0.19223657998051047d, y: 0.3585589325846862d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41978014346704273d, y: 0.06555123878624314d), new NpgsqlTypes.NpgsqlPoint(x: 0.20947842282639095d, y: 0.47672115588239883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594584413117544d, y: 0.5641960699857139d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3501027966494873d, y: 0.33043488424471645d), new NpgsqlTypes.NpgsqlPoint(x: 0.678733469899695d, y: 0.2711072254483866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9218423551471759d, y: 0.6840439003812102d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9182166401319757d, y: 0.9162881047545324d), new NpgsqlTypes.NpgsqlPoint(x: 0.34840434028878375d, y: 0.0887096205791631d), new NpgsqlTypes.NpgsqlPoint(x: 0.9323250039880013d, y: 0.8989704645859633d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28621860154057854d, y: 0.9157556233269856d), new NpgsqlTypes.NpgsqlPoint(x: 0.9626100463583657d, y: 0.36673693866118307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4159119610351285d, y: 0.06837627964897008d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27040318368279204d, y: 0.8654584609755478d), new NpgsqlTypes.NpgsqlPoint(x: 0.7656509326255835d, y: 0.531739886542281d), new NpgsqlTypes.NpgsqlPoint(x: 0.6851405220578008d, y: 0.7113918964459949d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611478874095123d, y: 0.152028595026523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614379732455213d, y: 0.6487440057003333d), new NpgsqlTypes.NpgsqlPoint(x: 0.9794184804886265d, y: 0.05745259414089576d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5832118343154867d, y: 0.44233346332529266d), new NpgsqlTypes.NpgsqlPoint(x: 0.20370130329042002d, y: 0.07456128874653034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5862382153581306d, y: 0.904072999909252d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8689754745982123d, y: 0.04620129657728711d), new NpgsqlTypes.NpgsqlPoint(x: 0.6147757419711256d, y: 0.7366021685606154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7811435546515358d, y: 0.16420244452138022d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7340808424142611d, y: 0.7762024950120616d), new NpgsqlTypes.NpgsqlPoint(x: 0.03339435290324744d, y: 0.8052726723716244d), new NpgsqlTypes.NpgsqlPoint(x: 0.20042799440473735d, y: 0.569273200028685d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.944247213169102d, y: 0.5030685733913408d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468449309552925d, y: 0.2403747928451131d), new NpgsqlTypes.NpgsqlPoint(x: 0.9778425013646432d, y: 0.3622665355264729d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7099704717525804d, y: 0.36456774172560913d), new NpgsqlTypes.NpgsqlPoint(x: 0.4071527746829502d, y: 0.8839769950978815d), new NpgsqlTypes.NpgsqlPoint(x: 0.1113484103081045d, y: 0.5710763051376342d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3406287819690962d, y: 0.9321572207538695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5959350410541862d, y: 0.34904229924104124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725877546571891d, y: 0.2693766354447227d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35507387793526024d, y: 0.2987233767145968d), new NpgsqlTypes.NpgsqlPoint(x: 0.67382890118405d, y: 0.01297662858046078d), new NpgsqlTypes.NpgsqlPoint(x: 0.0821669844603895d, y: 0.5390458099413197d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6180794370246705d, y: 0.3291832363030336d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006938903166756d, y: 0.4374744327632266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598287023223462d, y: 0.0523231926258787d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1482437504562042d, y: 0.9752859882537578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6818542425810106d, y: 0.9981942000360424d), new NpgsqlTypes.NpgsqlPoint(x: 0.4214187979483256d, y: 0.1883435158458805d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047849028441635855d, y: 0.9267641731412695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217212745433409d, y: 0.8687364311745326d), new NpgsqlTypes.NpgsqlPoint(x: 0.3336729406156044d, y: 0.400438998691952d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4127893120796464d, y: 0.6131585877383213d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342828549274372d, y: 0.930527661785199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022399150075754d, y: 0.8835157501790787d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4310165646511491d, y: 0.877823267297954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8567037169397427d, y: 0.0510105144305496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8918799507986028d, y: 0.04614915594992908d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4698270144885348d, y: 0.6965932620902773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871074064020384d, y: 0.7313776499490173d), new NpgsqlTypes.NpgsqlPoint(x: 0.5123229628011189d, y: 0.6856332971548607d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2919958491994423d, y: 0.06109346573409835d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131527226370466d, y: 0.6161449903584771d), new NpgsqlTypes.NpgsqlPoint(x: 0.46733182597951173d, y: 0.06804883921970295d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4691039378086621d, y: 0.2816145715926309d), new NpgsqlTypes.NpgsqlPoint(x: 0.535909444884509d, y: 0.9828621602897348d), new NpgsqlTypes.NpgsqlPoint(x: 0.2591682702606164d, y: 0.023907915785195577d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34291793167736107d, y: 0.306266946363833d), new NpgsqlTypes.NpgsqlPoint(x: 0.942577797847795d, y: 0.5979384155066992d), new NpgsqlTypes.NpgsqlPoint(x: 0.4272663288762747d, y: 0.1659409236220949d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024025295536953983d, y: 0.20926841798524654d), new NpgsqlTypes.NpgsqlPoint(x: 0.03814627799616088d, y: 0.7767498755130715d), new NpgsqlTypes.NpgsqlPoint(x: 0.838166430185729d, y: 0.7424786065454436d)))));

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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI), typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
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
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

