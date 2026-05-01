

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
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6992543835656909d, y: 0.5733198395613633d), new NpgsqlTypes.NpgsqlPoint(x: 0.7999890097126204d, y: 0.7105055522057921d), new NpgsqlTypes.NpgsqlPoint(x: 0.43131334624021955d, y: 0.05562731322253023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5013268257397718d, y: 0.374494490889678d), new NpgsqlTypes.NpgsqlPoint(x: 0.4491119719464719d, y: 0.5122672927675707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7204794789106393d, y: 0.14768327113599433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36888537036296865d, y: 0.8908866884098733d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379227377299988d, y: 0.47853367713592676d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337620568096285d, y: 0.8957543848015426d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3909429816939354d, y: 0.01105177508689581d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054817180885655d, y: 0.5096826420348449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6214221430022424d, y: 0.3627851100764554d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033117163179903764d, y: 0.9585796532116078d), new NpgsqlTypes.NpgsqlPoint(x: 0.4934547624969797d, y: 0.06551578021920323d), new NpgsqlTypes.NpgsqlPoint(x: 0.10541838155344685d, y: 0.8883740722420937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32755022184287974d, y: 0.313096030672096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3160056820581352d, y: 0.8389575969414739d), new NpgsqlTypes.NpgsqlPoint(x: 0.3836597027499695d, y: 0.5154458569609047d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.324237557649367d, y: 0.7079127628589491d), new NpgsqlTypes.NpgsqlPoint(x: 0.8011483595091774d, y: 0.24207329290697788d), new NpgsqlTypes.NpgsqlPoint(x: 0.456917070522606d, y: 0.827240412672772d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5239405550489455d, y: 0.7648023023873898d), new NpgsqlTypes.NpgsqlPoint(x: 0.024170522319641785d, y: 0.47498479786752223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3415628467659766d, y: 0.39199163772562406d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1579365279714997d, y: 0.678490632185751d), new NpgsqlTypes.NpgsqlPoint(x: 0.360204310308203d, y: 0.2749082747767171d), new NpgsqlTypes.NpgsqlPoint(x: 0.23928466374306157d, y: 0.8745656001647223d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5521618402194511d, y: 0.23492632172239436d), new NpgsqlTypes.NpgsqlPoint(x: 0.21671067370828934d, y: 0.5132784208350707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8341455990407175d, y: 0.22266227629568314d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1876009530929681d, y: 0.9600983860491977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726549325814518d, y: 0.2586845422282217d), new NpgsqlTypes.NpgsqlPoint(x: 0.015956072978348113d, y: 0.5842571322772828d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6891925573993737d, y: 0.46229536432069285d), new NpgsqlTypes.NpgsqlPoint(x: 0.610430293171011d, y: 0.5672932182136124d), new NpgsqlTypes.NpgsqlPoint(x: 0.46338741130228644d, y: 0.7384340855185131d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16919766786527246d, y: 0.5395217366601556d), new NpgsqlTypes.NpgsqlPoint(x: 0.76403865523037d, y: 0.9469215082806851d), new NpgsqlTypes.NpgsqlPoint(x: 0.494051121854884d, y: 0.34484457911033506d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9876898785722531d, y: 0.9302666317647539d), new NpgsqlTypes.NpgsqlPoint(x: 0.09457116590082626d, y: 0.12270754753243762d), new NpgsqlTypes.NpgsqlPoint(x: 0.713074777172675d, y: 0.27301801280995164d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8986364318886262d, y: 0.8769371015194518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8645869590109219d, y: 0.2774989308819924d), new NpgsqlTypes.NpgsqlPoint(x: 0.36977177113592186d, y: 0.5257934178962937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12077640474225015d, y: 0.4146152148402522d), new NpgsqlTypes.NpgsqlPoint(x: 0.12808198260829018d, y: 0.43515514948450285d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600307675667657d, y: 0.952636048113427d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6044177724780472d, y: 0.8860141442555565d), new NpgsqlTypes.NpgsqlPoint(x: 0.09524863059707123d, y: 0.6711638765380308d), new NpgsqlTypes.NpgsqlPoint(x: 0.4029302353879355d, y: 0.03448936598711483d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45973742816378993d, y: 0.32155348623822666d), new NpgsqlTypes.NpgsqlPoint(x: 0.58287491986256d, y: 0.48556923162725685d), new NpgsqlTypes.NpgsqlPoint(x: 0.17307102139246d, y: 0.08030557517579795d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3598354861743016d, y: 0.6987150304411069d), new NpgsqlTypes.NpgsqlPoint(x: 0.7232936530719001d, y: 0.2533881241391073d), new NpgsqlTypes.NpgsqlPoint(x: 0.20079417887564766d, y: 0.1712811315759455d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8287210321914463d, y: 0.08409296610204875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201345110297771d, y: 0.1731913186387718d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807134948788943d, y: 0.07325487619012361d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37999999947863206d, y: 0.22252628269717367d), new NpgsqlTypes.NpgsqlPoint(x: 0.2420829384994675d, y: 0.9371823179345397d), new NpgsqlTypes.NpgsqlPoint(x: 0.841353882716096d, y: 0.23090471913969057d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17497390046276906d, y: 0.7199225248141782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7356276124649375d, y: 0.9779258504438351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5112128678333916d, y: 0.42582026716121824d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6446272802703301d, y: 0.4880757447840707d), new NpgsqlTypes.NpgsqlPoint(x: 0.730552976441362d, y: 0.489043073850035d), new NpgsqlTypes.NpgsqlPoint(x: 0.792765490306693d, y: 0.398514587662825d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7907921575991701d, y: 0.1302979606113036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342273673720493d, y: 0.4476057459884325d), new NpgsqlTypes.NpgsqlPoint(x: 0.585689805082136d, y: 0.4066113360715605d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7240074829466001d, y: 0.521379734104754d), new NpgsqlTypes.NpgsqlPoint(x: 0.07273804500103731d, y: 0.977576087412554d), new NpgsqlTypes.NpgsqlPoint(x: 0.44813227649565146d, y: 0.5714645925347347d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24568532938463694d, y: 0.6906001629585774d), new NpgsqlTypes.NpgsqlPoint(x: 0.9019915134678785d, y: 0.46403166096156556d), new NpgsqlTypes.NpgsqlPoint(x: 0.1852142673214533d, y: 0.8598009224969415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5688219326664439d, y: 0.8197837113623787d), new NpgsqlTypes.NpgsqlPoint(x: 0.8431632250704258d, y: 0.3628301951092645d), new NpgsqlTypes.NpgsqlPoint(x: 0.2505334656379088d, y: 0.7376024543379814d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9707812746723952d, y: 0.7835452183860939d), new NpgsqlTypes.NpgsqlPoint(x: 0.9671466119615783d, y: 0.13538854921200616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8458393922641021d, y: 0.12556059414469267d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6531608046546732d, y: 0.9711391843158028d), new NpgsqlTypes.NpgsqlPoint(x: 0.08557783029242905d, y: 0.039921577907301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8207061378537075d, y: 0.20548769048331506d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3122885001576945d, y: 0.0572580798424992d), new NpgsqlTypes.NpgsqlPoint(x: 0.710783076750834d, y: 0.5446002525132851d), new NpgsqlTypes.NpgsqlPoint(x: 0.05294452596687482d, y: 0.6497284231210044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09711309120727474d, y: 0.40561701549858875d), new NpgsqlTypes.NpgsqlPoint(x: 0.14678116854522505d, y: 0.7659524499861176d), new NpgsqlTypes.NpgsqlPoint(x: 0.10337814716942473d, y: 0.5229784093587361d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33506585902538855d, y: 0.32450599723052986d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635585722512181d, y: 0.26426555309361854d), new NpgsqlTypes.NpgsqlPoint(x: 0.599214694888218d, y: 0.7368052981399911d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48658991528184015d, y: 0.12527908074381433d), new NpgsqlTypes.NpgsqlPoint(x: 0.8353902414325958d, y: 0.5171104919619885d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699839649852147d, y: 0.5312695712771246d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08151993812629454d, y: 0.3051577791645964d), new NpgsqlTypes.NpgsqlPoint(x: 0.9302665558899637d, y: 0.8476229726474792d), new NpgsqlTypes.NpgsqlPoint(x: 0.17664437469024064d, y: 0.27490945729664207d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28339389178285224d, y: 0.250428627159509d), new NpgsqlTypes.NpgsqlPoint(x: 0.029504017346245193d, y: 0.31364635659473195d), new NpgsqlTypes.NpgsqlPoint(x: 0.31538231931643634d, y: 0.8962666130072774d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7003973789660738d, y: 0.7705370412554624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5793873364904887d, y: 0.6943758377759942d), new NpgsqlTypes.NpgsqlPoint(x: 0.017149119647889233d, y: 0.37075305531504155d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4864942569461833d, y: 0.6858394986809575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191863751685285d, y: 0.2691312032392569d), new NpgsqlTypes.NpgsqlPoint(x: 0.36555419778352605d, y: 0.295270377567006d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6145339461583618d, y: 0.9763890977992958d), new NpgsqlTypes.NpgsqlPoint(x: 0.8516967066588719d, y: 0.24930751322854294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6571814458804882d, y: 0.6233323790450207d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.665678579298722d, y: 0.5128243064739506d), new NpgsqlTypes.NpgsqlPoint(x: 0.3383748569932308d, y: 0.19669324501275143d), new NpgsqlTypes.NpgsqlPoint(x: 0.10423684228289865d, y: 0.38921031202833667d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3923546149102356d, y: 0.06996572415767777d), new NpgsqlTypes.NpgsqlPoint(x: 0.2792339371907677d, y: 0.5870854500709076d), new NpgsqlTypes.NpgsqlPoint(x: 0.4742605863812299d, y: 0.4974905598381548d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8184871650518636d, y: 0.23261741920741874d), new NpgsqlTypes.NpgsqlPoint(x: 0.33340456600108404d, y: 0.5263624440123217d), new NpgsqlTypes.NpgsqlPoint(x: 0.1177443408146176d, y: 0.25541601703047645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14878004536767664d, y: 0.3807595815953997d), new NpgsqlTypes.NpgsqlPoint(x: 0.30301861803842634d, y: 0.1577809561854493d), new NpgsqlTypes.NpgsqlPoint(x: 0.1623292346473798d, y: 0.015324313215729246d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5885123810189145d, y: 0.9174414611687027d), new NpgsqlTypes.NpgsqlPoint(x: 0.31109797798248795d, y: 0.4220496006169582d), new NpgsqlTypes.NpgsqlPoint(x: 0.831670578936717d, y: 0.5835518987855303d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2968027421263454d, y: 0.4241697759212165d), new NpgsqlTypes.NpgsqlPoint(x: 0.21913961702059204d, y: 0.6695018494886645d), new NpgsqlTypes.NpgsqlPoint(x: 0.6056116758105322d, y: 0.2359153746081274d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34175256483015215d, y: 0.35258006411133125d), new NpgsqlTypes.NpgsqlPoint(x: 0.4810586998001697d, y: 0.04052898567887797d), new NpgsqlTypes.NpgsqlPoint(x: 0.5556720273904033d, y: 0.36327982678607085d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12800921234158136d, y: 0.593377336971687d), new NpgsqlTypes.NpgsqlPoint(x: 0.7651261275850457d, y: 0.7312272724291984d), new NpgsqlTypes.NpgsqlPoint(x: 0.6500260592776604d, y: 0.3289072646417206d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5345316946846763d, y: 0.35628568457277787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842624285394409d, y: 0.29867832341864986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6573766704759748d, y: 0.222955669436265d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6563529822996563d, y: 0.17831319140912794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5057998654037915d, y: 0.35545559611369004d), new NpgsqlTypes.NpgsqlPoint(x: 0.3167381050467728d, y: 0.28046218300254755d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3749037674729415d, y: 0.6480210985198396d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824538839140026d, y: 0.13083925839761856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6676168834802986d, y: 0.8505056276163203d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06787454893498113d, y: 0.433115449175415d), new NpgsqlTypes.NpgsqlPoint(x: 0.16034311127466128d, y: 0.5279415093299954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8053493909820809d, y: 0.03129255786994545d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.485436235714919d, y: 0.7271829753322191d), new NpgsqlTypes.NpgsqlPoint(x: 0.21558691260435914d, y: 0.8426567373084186d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739347364302619d, y: 0.9107661161511772d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9887037681953075d, y: 0.013887986608216663d), new NpgsqlTypes.NpgsqlPoint(x: 0.18364060431473805d, y: 0.3727384823340646d), new NpgsqlTypes.NpgsqlPoint(x: 0.20960564358676492d, y: 0.7020272396273256d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5689502687856307d, y: 0.9664488505892741d), new NpgsqlTypes.NpgsqlPoint(x: 0.41515137044826633d, y: 0.9881252483134759d), new NpgsqlTypes.NpgsqlPoint(x: 0.2543122954785205d, y: 0.9448142662997032d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44952853774197565d, y: 0.2954016425629683d), new NpgsqlTypes.NpgsqlPoint(x: 0.8446374266932997d, y: 0.4257303255636883d), new NpgsqlTypes.NpgsqlPoint(x: 0.1339192213814273d, y: 0.888743820284243d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12424565169883084d, y: 0.9011386230786596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693655602959009d, y: 0.026827621712885663d), new NpgsqlTypes.NpgsqlPoint(x: 0.31380466162711884d, y: 0.2730291339867834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5641083038578928d, y: 0.3991522879478673d), new NpgsqlTypes.NpgsqlPoint(x: 0.481903792975353d, y: 0.4373478719199049d), new NpgsqlTypes.NpgsqlPoint(x: 0.6323543300798403d, y: 0.09846763117471857d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9407082839152782d, y: 0.907937853897034d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345392478672211d, y: 0.6344634841638194d), new NpgsqlTypes.NpgsqlPoint(x: 0.46033421500778104d, y: 0.6334227175103255d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46854505072010544d, y: 0.6418791091002066d), new NpgsqlTypes.NpgsqlPoint(x: 0.10893207857154985d, y: 0.6202307580530556d), new NpgsqlTypes.NpgsqlPoint(x: 0.4214404553075759d, y: 0.6001135438078383d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.98489580871123d, y: 0.3462607151999856d), new NpgsqlTypes.NpgsqlPoint(x: 0.21370409124409173d, y: 0.545023841801816d), new NpgsqlTypes.NpgsqlPoint(x: 0.006362724355937099d, y: 0.42351976323459584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22841534307808242d, y: 0.07415583131398196d), new NpgsqlTypes.NpgsqlPoint(x: 0.626400483773496d, y: 0.09548854747669533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005209874885781d, y: 0.7345444085427167d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9395414521865969d, y: 0.6418446520830374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341060585362021d, y: 0.9713217647733952d), new NpgsqlTypes.NpgsqlPoint(x: 0.0483514569925918d, y: 0.22254082345239656d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25224961210656294d, y: 0.3384544179810366d), new NpgsqlTypes.NpgsqlPoint(x: 0.14988191787363037d, y: 0.6888301801623898d), new NpgsqlTypes.NpgsqlPoint(x: 0.039878481023372436d, y: 0.22107189705372143d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17374441626454695d, y: 0.2887892802272787d), new NpgsqlTypes.NpgsqlPoint(x: 0.2499184418451741d, y: 0.854492299908294d), new NpgsqlTypes.NpgsqlPoint(x: 0.0786602732224958d, y: 0.44024213267763346d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06879606450664166d, y: 0.9102847469988065d), new NpgsqlTypes.NpgsqlPoint(x: 0.018277655553389893d, y: 0.17257599442308524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632032933380117d, y: 0.32197993623631227d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13018818029713208d, y: 0.9402968700996069d), new NpgsqlTypes.NpgsqlPoint(x: 0.1929533456151391d, y: 0.3792926609461974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252273228554103d, y: 0.48858023576487775d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6029741920667042d, y: 0.3403324445717504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041342340218468d, y: 0.24210406495002768d), new NpgsqlTypes.NpgsqlPoint(x: 0.809915686128688d, y: 0.4775282116884596d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4948584141663759d, y: 0.14766644317866318d), new NpgsqlTypes.NpgsqlPoint(x: 0.588379800296645d, y: 0.9898556538795247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8748188427580281d, y: 0.8676267598181847d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45499188772043253d, y: 0.11597425077705259d), new NpgsqlTypes.NpgsqlPoint(x: 0.9479743090847166d, y: 0.9965424995899047d), new NpgsqlTypes.NpgsqlPoint(x: 0.22246988638521237d, y: 0.6507040390282104d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.499623896202109d, y: 0.9159104693476717d), new NpgsqlTypes.NpgsqlPoint(x: 0.8496950069248926d, y: 0.38316733188336927d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239799209793244d, y: 0.2532507236048629d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8046030461657053d, y: 0.7893487821955752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7101877357866146d, y: 0.6110414645708616d), new NpgsqlTypes.NpgsqlPoint(x: 0.1283611819364604d, y: 0.030151185217278775d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30125189817101816d, y: 0.6734451455959296d), new NpgsqlTypes.NpgsqlPoint(x: 0.058265967546038855d, y: 0.7086003679630557d), new NpgsqlTypes.NpgsqlPoint(x: 0.4494856126364174d, y: 0.21662164023795716d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5298219991295873d, y: 0.6052430585778336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092251452318148d, y: 0.049445076152491385d), new NpgsqlTypes.NpgsqlPoint(x: 0.06452563372204045d, y: 0.2979358694087476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.026869225313392975d, y: 0.9136885504787365d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337729806201145d, y: 0.04863234743155087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288825742212878d, y: 0.3357219909202869d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7438683095200554d, y: 0.48058040087233744d), new NpgsqlTypes.NpgsqlPoint(x: 0.9098525596635737d, y: 0.7981700150778621d), new NpgsqlTypes.NpgsqlPoint(x: 0.26755838699521295d, y: 0.49851684374569005d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2603345790768158d, y: 0.20286180109212903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8051335381858618d, y: 0.8639582443706437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6655289270897129d, y: 0.7901437436500622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9446111044661304d, y: 0.789282604853859d), new NpgsqlTypes.NpgsqlPoint(x: 0.9817325744449545d, y: 0.15666158232741545d), new NpgsqlTypes.NpgsqlPoint(x: 0.849991743608277d, y: 0.26120906639565644d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5404598254351421d, y: 0.43426040250646303d), new NpgsqlTypes.NpgsqlPoint(x: 0.5776478755131246d, y: 0.03850489522748657d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005685744225983d, y: 0.08300936153448257d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13129402431304737d, y: 0.4140602485734841d), new NpgsqlTypes.NpgsqlPoint(x: 0.6861197162647767d, y: 0.4332877189986404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4580165271086518d, y: 0.5599304090922168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2800626754485577d, y: 0.701356863393091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459293846146544d, y: 0.562579297264794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7392714545769357d, y: 0.0968674651611049d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8016717559349523d, y: 0.8584442017978645d), new NpgsqlTypes.NpgsqlPoint(x: 0.5139164356176871d, y: 0.5475486006174755d), new NpgsqlTypes.NpgsqlPoint(x: 0.457151143485232d, y: 0.9111581101868027d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07296770920282303d, y: 0.6749150650059254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455310942456157d, y: 0.13319902618590584d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206534038990865d, y: 0.1540174307658011d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33191682891007646d, y: 0.6771044348566885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672007057878835d, y: 0.26232999677497404d), new NpgsqlTypes.NpgsqlPoint(x: 0.20717019596681718d, y: 0.15146805076251357d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9874572747804985d, y: 0.6058614808143986d), new NpgsqlTypes.NpgsqlPoint(x: 0.09378548536687725d, y: 0.44591067344469426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7501693855410764d, y: 0.9311987946086127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8440404701793636d, y: 0.946493203630428d), new NpgsqlTypes.NpgsqlPoint(x: 0.09513405156203925d, y: 0.45863328353515875d), new NpgsqlTypes.NpgsqlPoint(x: 0.004540462563359382d, y: 0.5944263905433147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8360576341064999d, y: 0.07155899459765425d), new NpgsqlTypes.NpgsqlPoint(x: 0.4657742838604044d, y: 0.5447316460995847d), new NpgsqlTypes.NpgsqlPoint(x: 0.049400142080596066d, y: 0.19135010139655284d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5039506212714534d, y: 0.9263594783610676d), new NpgsqlTypes.NpgsqlPoint(x: 0.26595803965887943d, y: 0.5212242056642062d), new NpgsqlTypes.NpgsqlPoint(x: 0.9126294006048814d, y: 0.6333078607338845d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9086395724717671d, y: 0.6756052504302134d), new NpgsqlTypes.NpgsqlPoint(x: 0.1244645070920779d, y: 0.3467849726033294d), new NpgsqlTypes.NpgsqlPoint(x: 0.7797805105628248d, y: 0.8820661307694555d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36410589070562227d, y: 0.3528433302567451d), new NpgsqlTypes.NpgsqlPoint(x: 0.5569426635868051d, y: 0.1521292697236315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7340665204478286d, y: 0.2723366498223536d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47141677618586153d, y: 0.7608943033924385d), new NpgsqlTypes.NpgsqlPoint(x: 0.2296425589538874d, y: 0.2257350179220785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7261797746506373d, y: 0.000138009534471073d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26262834487678954d, y: 0.5629044294255061d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499208765683051d, y: 0.5392592823515348d), new NpgsqlTypes.NpgsqlPoint(x: 0.33148700924719576d, y: 0.2423695569865436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7426282457442811d, y: 0.8978729119670876d), new NpgsqlTypes.NpgsqlPoint(x: 0.7953491379731499d, y: 0.21067178469008163d), new NpgsqlTypes.NpgsqlPoint(x: 0.880952025440202d, y: 0.13983475738558548d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7116067376131692d, y: 0.997032752725225d), new NpgsqlTypes.NpgsqlPoint(x: 0.17586607826296707d, y: 0.8650337425797974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654908278753216d, y: 0.9627981060744819d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6986906378103451d, y: 0.6307016443320378d), new NpgsqlTypes.NpgsqlPoint(x: 0.45611215526502646d, y: 0.7661210924769609d), new NpgsqlTypes.NpgsqlPoint(x: 0.7691082843849637d, y: 0.8541416668634892d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9508476883728191d, y: 0.7758928087768143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7648174089495955d, y: 0.8270336563062288d), new NpgsqlTypes.NpgsqlPoint(x: 0.5325139362338254d, y: 0.5312620896632458d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9577972234082871d, y: 0.3293135097590565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8186916540491114d, y: 0.7971859168798672d), new NpgsqlTypes.NpgsqlPoint(x: 0.17518100597357d, y: 0.6651454669272786d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31151358146072194d, y: 0.607833846222187d), new NpgsqlTypes.NpgsqlPoint(x: 0.4754074719775211d, y: 0.03302627443495032d), new NpgsqlTypes.NpgsqlPoint(x: 0.937165412910545d, y: 0.20680163856698042d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1468420512755736d, y: 0.3810429530672851d), new NpgsqlTypes.NpgsqlPoint(x: 0.5017585665053956d, y: 0.6815845796083186d), new NpgsqlTypes.NpgsqlPoint(x: 0.004739779444052794d, y: 0.3475739206002869d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1439861103467911d, y: 0.3394821287759916d), new NpgsqlTypes.NpgsqlPoint(x: 0.28505914400589305d, y: 0.32744810368974575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9016751431702439d, y: 0.41667669520769046d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6182043525207344d, y: 0.7473553889292547d), new NpgsqlTypes.NpgsqlPoint(x: 0.4745454399962027d, y: 0.14992503695941262d), new NpgsqlTypes.NpgsqlPoint(x: 0.9689342358705635d, y: 0.6643281660277263d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28492091179866896d, y: 0.7652463914586379d), new NpgsqlTypes.NpgsqlPoint(x: 0.772148500745287d, y: 0.05408578716554391d), new NpgsqlTypes.NpgsqlPoint(x: 0.5568202417140616d, y: 0.20012627072593503d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4956384023395013d, y: 0.6327203617116378d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792293570676246d, y: 0.14787198282866343d), new NpgsqlTypes.NpgsqlPoint(x: 0.0962782234409909d, y: 0.4902792493694935d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19772615688696527d, y: 0.7269232348255427d), new NpgsqlTypes.NpgsqlPoint(x: 0.9067025640464662d, y: 0.5316269865241664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039474103335297d, y: 0.34060705178854456d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2093963967887873d, y: 0.9649922361409156d), new NpgsqlTypes.NpgsqlPoint(x: 0.27220280902121907d, y: 0.57396252315087d), new NpgsqlTypes.NpgsqlPoint(x: 0.24089918200359983d, y: 0.21820368000180723d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46879043002375576d, y: 0.2868424811455629d), new NpgsqlTypes.NpgsqlPoint(x: 0.24789782890750556d, y: 0.6779916346274448d), new NpgsqlTypes.NpgsqlPoint(x: 0.05355507055456066d, y: 0.3980221496239198d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35500476629677524d, y: 0.3087661360547437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6728706913169191d, y: 0.8622557353881868d), new NpgsqlTypes.NpgsqlPoint(x: 0.6240591871278683d, y: 0.23096919802274296d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013081851982602033d, y: 0.7894148230324897d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864454604943794d, y: 0.715388880545794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628431806091441d, y: 0.33533225312059334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09627941642490778d, y: 0.021857713253824795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424694764405089d, y: 0.3575598600035187d), new NpgsqlTypes.NpgsqlPoint(x: 0.43972519464339077d, y: 0.10681101660911907d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9558347092611784d, y: 0.15071264587875244d), new NpgsqlTypes.NpgsqlPoint(x: 0.31491499082199037d, y: 0.09473979588041359d), new NpgsqlTypes.NpgsqlPoint(x: 0.9219442496034215d, y: 0.960809230948528d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8142589749967988d, y: 0.16256788701170344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7951283002547344d, y: 0.08995905546898297d), new NpgsqlTypes.NpgsqlPoint(x: 0.5466077462605141d, y: 0.7950839394893378d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5799672611670615d, y: 0.5772713457964868d), new NpgsqlTypes.NpgsqlPoint(x: 0.8939101892072892d, y: 0.49752405323832605d), new NpgsqlTypes.NpgsqlPoint(x: 0.7791443500639726d, y: 0.36644196270243046d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6444896564204273d, y: 0.9409593395637758d), new NpgsqlTypes.NpgsqlPoint(x: 0.4100237238965362d, y: 0.2534630894725489d), new NpgsqlTypes.NpgsqlPoint(x: 0.3893032545234729d, y: 0.30321779461124165d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2956916796508827d, y: 0.618306579313837d), new NpgsqlTypes.NpgsqlPoint(x: 0.4487431196318009d, y: 0.703066736993415d), new NpgsqlTypes.NpgsqlPoint(x: 0.7057388702078802d, y: 0.26775916696445023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7684809336980218d, y: 0.262748202115651d), new NpgsqlTypes.NpgsqlPoint(x: 0.89732699771368d, y: 0.673605640472326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6657687161468852d, y: 0.8600010016309694d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8143444412111847d, y: 0.11267675844127034d), new NpgsqlTypes.NpgsqlPoint(x: 0.10148468550175105d, y: 0.011550527107097808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5928251293168452d, y: 0.6721678262878559d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23984450759374287d, y: 0.6789274059200959d), new NpgsqlTypes.NpgsqlPoint(x: 0.08676616225896683d, y: 0.6649515272338031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593498006459901d, y: 0.6944817460258368d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8567475651990737d, y: 0.6749517351695067d), new NpgsqlTypes.NpgsqlPoint(x: 0.05252327942510093d, y: 0.9647359632689505d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671279193448326d, y: 0.9546954906175199d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9287667773308145d, y: 0.13938107058655036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079506100360502d, y: 0.8476987822032646d), new NpgsqlTypes.NpgsqlPoint(x: 0.142746911682063d, y: 0.18164057109085308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.149992931852984d, y: 0.08102274128081166d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768152846381727d, y: 0.9833267580003222d), new NpgsqlTypes.NpgsqlPoint(x: 0.754456803014069d, y: 0.5882449308215214d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0032681979988082865d, y: 0.6479513246846033d), new NpgsqlTypes.NpgsqlPoint(x: 0.001672638304925811d, y: 0.7296857879891008d), new NpgsqlTypes.NpgsqlPoint(x: 0.4071905424726946d, y: 0.39308906961961165d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5443853581106964d, y: 0.5212903603366346d), new NpgsqlTypes.NpgsqlPoint(x: 0.7736250909255841d, y: 0.46084728378302364d), new NpgsqlTypes.NpgsqlPoint(x: 0.3213932136664813d, y: 0.0670584448971665d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20988265984024423d, y: 0.8861965973412764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6620023176543915d, y: 0.7623758591035226d), new NpgsqlTypes.NpgsqlPoint(x: 0.25521182189261804d, y: 0.2986102957657253d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8101546130446668d, y: 0.813181809453248d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288504323002059d, y: 0.3726608023604775d), new NpgsqlTypes.NpgsqlPoint(x: 0.23862248111218132d, y: 0.23802572092960972d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.458785717120867d, y: 0.08207158846146823d), new NpgsqlTypes.NpgsqlPoint(x: 0.058602629708095044d, y: 0.13318969415767123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8933695575503124d, y: 0.2836508744696925d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2953913766955625d, y: 0.07969617910120497d), new NpgsqlTypes.NpgsqlPoint(x: 0.9992014954696363d, y: 0.7509407250273803d), new NpgsqlTypes.NpgsqlPoint(x: 0.20237671672478597d, y: 0.21944145538984428d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3036916848467962d, y: 0.4410401595781255d), new NpgsqlTypes.NpgsqlPoint(x: 0.24294923246607847d, y: 0.5091850644225936d), new NpgsqlTypes.NpgsqlPoint(x: 0.39756201235737154d, y: 0.30029094102580767d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44595426868615495d, y: 0.4781369706914108d), new NpgsqlTypes.NpgsqlPoint(x: 0.7847230152497738d, y: 0.8961680049255978d), new NpgsqlTypes.NpgsqlPoint(x: 0.36062215009153564d, y: 0.592151506930503d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6776505143926199d, y: 0.7365452712827621d), new NpgsqlTypes.NpgsqlPoint(x: 0.8297270569954635d, y: 0.9831024273988328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7609060786198011d, y: 0.7055274667362849d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.904135060814d, y: 0.8397433016824373d), new NpgsqlTypes.NpgsqlPoint(x: 0.16227400100635003d, y: 0.2186251622353269d), new NpgsqlTypes.NpgsqlPoint(x: 0.6542429062088295d, y: 0.11592806597180971d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5406088292375183d, y: 0.07037995454184676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3688767515413881d, y: 0.6560474174457146d), new NpgsqlTypes.NpgsqlPoint(x: 0.32723178504234207d, y: 0.28420127029949305d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.056972683344324815d, y: 0.0001208673453055864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5139562989502746d, y: 0.7857329561052555d), new NpgsqlTypes.NpgsqlPoint(x: 0.008613763382831152d, y: 0.2727079934102673d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.502062511782577d, y: 0.9473513186507287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8611850440806248d, y: 0.5164166779591688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626717554488788d, y: 0.2275320544674444d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8530716463686714d, y: 0.14626476950993328d), new NpgsqlTypes.NpgsqlPoint(x: 0.948794633263726d, y: 0.13356129722078025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5856272287837209d, y: 0.195657191484636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07497570565208822d, y: 0.7201626837521576d), new NpgsqlTypes.NpgsqlPoint(x: 0.7434846196713345d, y: 0.14329854005506293d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652710968226378d, y: 0.03820724697777578d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6082537207628199d, y: 0.5419183397603067d), new NpgsqlTypes.NpgsqlPoint(x: 0.13586045153446513d, y: 0.28446457047213725d), new NpgsqlTypes.NpgsqlPoint(x: 0.254368160652804d, y: 0.04796766732383739d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6915052847291789d, y: 0.5771503324180632d), new NpgsqlTypes.NpgsqlPoint(x: 0.8281999043808485d, y: 0.9323313832547524d), new NpgsqlTypes.NpgsqlPoint(x: 0.451204840744298d, y: 0.6873962018998443d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6186534045927433d, y: 0.022568430411196272d), new NpgsqlTypes.NpgsqlPoint(x: 0.45066476182843795d, y: 0.1558883870992388d), new NpgsqlTypes.NpgsqlPoint(x: 0.8165289942219369d, y: 0.09202031761342722d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7363677598840984d, y: 0.3125394657105228d), new NpgsqlTypes.NpgsqlPoint(x: 0.5781152428382366d, y: 0.13399110395103486d), new NpgsqlTypes.NpgsqlPoint(x: 0.2419883991799202d, y: 0.28984753695544485d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7827234169892163d, y: 0.21869905165832326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8059762201884534d, y: 0.4460878998030269d), new NpgsqlTypes.NpgsqlPoint(x: 0.11961085360922252d, y: 0.7128854420077183d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6196087399668823d, y: 0.7707752711390139d), new NpgsqlTypes.NpgsqlPoint(x: 0.12698255234138156d, y: 0.5110276779253039d), new NpgsqlTypes.NpgsqlPoint(x: 0.30806607861895396d, y: 0.06576498014352405d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7274420729960314d, y: 0.7618580682228208d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072962487012632d, y: 0.07815887767750351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5910767746357325d, y: 0.22008822253375016d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5362971300715901d, y: 0.14012243658594847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6478130610515316d, y: 0.6171944066215802d), new NpgsqlTypes.NpgsqlPoint(x: 0.2817664665885693d, y: 0.5694734392821095d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8584408190326901d, y: 0.9987593491709631d), new NpgsqlTypes.NpgsqlPoint(x: 0.06192366277197969d, y: 0.3169494382262804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728697511156943d, y: 0.7571882580434953d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46794260911370733d, y: 0.4655976269979193d), new NpgsqlTypes.NpgsqlPoint(x: 0.06993184230566518d, y: 0.32726720858696023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6180700056797883d, y: 0.7881191660956751d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18089174190658486d, y: 0.6025948925077458d), new NpgsqlTypes.NpgsqlPoint(x: 0.5552640257071991d, y: 0.37620701464242734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6070574418007609d, y: 0.8109801119887671d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08096058158807118d, y: 0.9616310343557907d), new NpgsqlTypes.NpgsqlPoint(x: 0.08640497619414833d, y: 0.21212060504643504d), new NpgsqlTypes.NpgsqlPoint(x: 0.7354658654925826d, y: 0.9026491816326622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6644816358266624d, y: 0.9881325872238175d), new NpgsqlTypes.NpgsqlPoint(x: 0.4533267341286764d, y: 0.5191243133566712d), new NpgsqlTypes.NpgsqlPoint(x: 0.02234033848716588d, y: 0.7360288844391786d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4940449772102731d, y: 0.7124644734269097d), new NpgsqlTypes.NpgsqlPoint(x: 0.2396386488036184d, y: 0.8268656120169843d), new NpgsqlTypes.NpgsqlPoint(x: 0.42260805078457153d, y: 0.0649743465930297d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2794912311147082d, y: 0.3644407812639924d), new NpgsqlTypes.NpgsqlPoint(x: 0.1648858691260645d, y: 0.1782109619299439d), new NpgsqlTypes.NpgsqlPoint(x: 0.9660104087578089d, y: 0.28444144533424975d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011140522163836208d, y: 0.7872797351070862d), new NpgsqlTypes.NpgsqlPoint(x: 0.3031023999833833d, y: 0.10087829964162132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5862660748288203d, y: 0.2327743216130166d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2953158005109434d, y: 0.6721085391223385d), new NpgsqlTypes.NpgsqlPoint(x: 0.4788989689481493d, y: 0.9079191249503219d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738384523670768d, y: 0.19621450909316795d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04903590451671691d, y: 0.5715004820796946d), new NpgsqlTypes.NpgsqlPoint(x: 0.049619150361065345d, y: 0.008415564870824954d), new NpgsqlTypes.NpgsqlPoint(x: 0.08560599451072382d, y: 0.35942058301990265d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9406052302186466d, y: 0.5994118550932207d), new NpgsqlTypes.NpgsqlPoint(x: 0.3190612923549466d, y: 0.10750068765079601d), new NpgsqlTypes.NpgsqlPoint(x: 0.9325203553165893d, y: 0.7656984534973653d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8024855383575605d, y: 0.023190319521178004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152297667464578d, y: 0.7573938369194516d), new NpgsqlTypes.NpgsqlPoint(x: 0.2344345685422724d, y: 0.15586023751423594d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7562137341409635d, y: 0.24713882938107223d), new NpgsqlTypes.NpgsqlPoint(x: 0.34178625474034474d, y: 0.762236878078897d), new NpgsqlTypes.NpgsqlPoint(x: 0.27651532085852903d, y: 0.6760103949789477d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23783960799046333d, y: 0.18283645733233822d), new NpgsqlTypes.NpgsqlPoint(x: 0.22088317063191865d, y: 0.5765726008005253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5074180222623302d, y: 0.6399411928719279d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27733343208429206d, y: 0.6415322142516626d), new NpgsqlTypes.NpgsqlPoint(x: 0.97035824728178d, y: 0.3257124731898057d), new NpgsqlTypes.NpgsqlPoint(x: 0.028760795228360836d, y: 0.2105461723033324d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6946856401702758d, y: 0.7335040379750482d), new NpgsqlTypes.NpgsqlPoint(x: 0.8759554101685715d, y: 0.29338174685706664d), new NpgsqlTypes.NpgsqlPoint(x: 0.46345710014299535d, y: 0.8389856917219582d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8014947781866637d, y: 0.35382905483843574d), new NpgsqlTypes.NpgsqlPoint(x: 0.11723365371966499d, y: 0.45089384563717283d), new NpgsqlTypes.NpgsqlPoint(x: 0.2832271814738282d, y: 0.5467244327120163d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7708433249648441d, y: 0.17824302359643174d), new NpgsqlTypes.NpgsqlPoint(x: 0.8202818305185489d, y: 0.3350407598578101d), new NpgsqlTypes.NpgsqlPoint(x: 0.98423778699384d, y: 0.6594180961981693d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.815635042901424d, y: 0.5989857317833662d), new NpgsqlTypes.NpgsqlPoint(x: 0.16534597862627887d, y: 0.9697256654652716d), new NpgsqlTypes.NpgsqlPoint(x: 0.4139574372845658d, y: 0.011864802921014106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9051460019433623d, y: 0.22192472413316677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7862028534688106d, y: 0.459064037075d), new NpgsqlTypes.NpgsqlPoint(x: 0.19435281375734126d, y: 0.7466846571522484d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.989685512335069d, y: 0.9510150702085703d), new NpgsqlTypes.NpgsqlPoint(x: 0.37606382168592045d, y: 0.37184381268236466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867203247125661d, y: 0.8440437615956097d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5514020336824509d, y: 0.19327291081028042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809399342914741d, y: 0.006749088723020602d), new NpgsqlTypes.NpgsqlPoint(x: 0.8469075511547355d, y: 0.5832525016574436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9562448040144241d, y: 0.6324532195751582d), new NpgsqlTypes.NpgsqlPoint(x: 0.512423422007076d, y: 0.01659780579714143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4211452094757011d, y: 0.7184347917726964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31644924927562057d, y: 0.38725081976568776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8536567506101107d, y: 0.023258206791866853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9786015954078379d, y: 0.22139799813880123d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31302801095209454d, y: 0.20118240661948927d), new NpgsqlTypes.NpgsqlPoint(x: 0.8144023672019152d, y: 0.6737823613715787d), new NpgsqlTypes.NpgsqlPoint(x: 0.1954875910098226d, y: 0.26226931481822835d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06401123292561872d, y: 0.8408908745103049d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837723850856518d, y: 0.16293585215001094d), new NpgsqlTypes.NpgsqlPoint(x: 0.15971166427243122d, y: 0.9146030722190893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5324898359289784d, y: 0.8708971583025169d), new NpgsqlTypes.NpgsqlPoint(x: 0.24665837444373262d, y: 0.533915133760697d), new NpgsqlTypes.NpgsqlPoint(x: 0.14512654082940568d, y: 0.046385545934919614d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9305236249217659d, y: 0.6860903189901753d), new NpgsqlTypes.NpgsqlPoint(x: 0.6752709596999181d, y: 0.4602323753382338d), new NpgsqlTypes.NpgsqlPoint(x: 0.9503234749731886d, y: 0.001966461913917583d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2800148564262229d, y: 0.41986672466741193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5565412012355824d, y: 0.3295961537053621d), new NpgsqlTypes.NpgsqlPoint(x: 0.9201729108510869d, y: 0.7730427481080324d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1425651776286625d, y: 0.8536613133922004d), new NpgsqlTypes.NpgsqlPoint(x: 0.27691129098587797d, y: 0.00034071132520419045d), new NpgsqlTypes.NpgsqlPoint(x: 0.4179489583183926d, y: 0.3487605947446364d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.525635422835045d, y: 0.30627130355073917d), new NpgsqlTypes.NpgsqlPoint(x: 0.6281579454650764d, y: 0.619949119666833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5973742996671079d, y: 0.3302649618377478d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6114480356848652d, y: 0.8958730500507687d), new NpgsqlTypes.NpgsqlPoint(x: 0.030633222129764603d, y: 0.6523504950989029d), new NpgsqlTypes.NpgsqlPoint(x: 0.37107292582429896d, y: 0.8827972890436648d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6063884586305203d, y: 0.6391177892928385d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802153178193526d, y: 0.985467470672159d), new NpgsqlTypes.NpgsqlPoint(x: 0.07725602536931397d, y: 0.7855324596883809d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0430904668004074d, y: 0.5658036997496123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7866268653382844d, y: 0.7962157216831628d), new NpgsqlTypes.NpgsqlPoint(x: 0.207203095725374d, y: 0.42243935760220275d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5534722847459104d, y: 0.7136260800097906d), new NpgsqlTypes.NpgsqlPoint(x: 0.41808249802385244d, y: 0.1187541624384506d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245450707544828d, y: 0.7184845997406151d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1523973997078678d, y: 0.3115755724849655d), new NpgsqlTypes.NpgsqlPoint(x: 0.07300803982245818d, y: 0.5841891462212605d), new NpgsqlTypes.NpgsqlPoint(x: 0.6561239091334227d, y: 0.5473173510745604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49768185996549386d, y: 0.14749241054930917d), new NpgsqlTypes.NpgsqlPoint(x: 0.037112484202289076d, y: 0.06827752878727278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7250947028336232d, y: 0.9492576833853381d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7010651834398304d, y: 0.1536766233023653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6498911148181745d, y: 0.46116605807820465d), new NpgsqlTypes.NpgsqlPoint(x: 0.7546774205881588d, y: 0.6333264349046493d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8778094960552449d, y: 0.843008872244806d), new NpgsqlTypes.NpgsqlPoint(x: 0.7687854933173613d, y: 0.849896839948548d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738656753590755d, y: 0.10937380633443117d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6490231596606505d, y: 0.1357736318806867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497898786166102d, y: 0.5276517779766908d), new NpgsqlTypes.NpgsqlPoint(x: 0.6091417487291634d, y: 0.9656080166454277d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06595800221467729d, y: 0.3681000083528967d), new NpgsqlTypes.NpgsqlPoint(x: 0.725104018323814d, y: 0.6616315906966287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923595320665899d, y: 0.6749345680493374d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6515509357233543d, y: 0.9760522276376679d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875813890196362d, y: 0.7023735466352807d), new NpgsqlTypes.NpgsqlPoint(x: 0.3969898877038117d, y: 0.41767060716523596d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8257211350139902d, y: 0.13162082713518464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7646389852209912d, y: 0.8431288614421125d), new NpgsqlTypes.NpgsqlPoint(x: 0.046457958368716246d, y: 0.9343619123609429d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45890832126621095d, y: 0.5904363321107363d), new NpgsqlTypes.NpgsqlPoint(x: 0.2386388625579372d, y: 0.7288610802106951d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991971414142832d, y: 0.6874691000393013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08238123798332875d, y: 0.5066058939199375d), new NpgsqlTypes.NpgsqlPoint(x: 0.40642024587542547d, y: 0.030216964638341892d), new NpgsqlTypes.NpgsqlPoint(x: 0.3668810996037547d, y: 0.2082355311074825d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3035252656556787d, y: 0.5684704004422821d), new NpgsqlTypes.NpgsqlPoint(x: 0.49799723678957597d, y: 0.4494214205575855d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194520774145902d, y: 0.6877418975430832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11060890433665527d, y: 0.19759458570412158d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338503992562794d, y: 0.35275053112957544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7587517779532821d, y: 0.008757547887210837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7818431061823461d, y: 0.38261712799667724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601404953794418d, y: 0.22850921258231338d), new NpgsqlTypes.NpgsqlPoint(x: 0.2237457679482141d, y: 0.2055972753729901d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7088305198113526d, y: 0.8862048202419844d), new NpgsqlTypes.NpgsqlPoint(x: 0.8060155647926048d, y: 0.3433365248568464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7957272436377617d, y: 0.8196855495203133d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9597214009544601d, y: 0.4854687594960305d), new NpgsqlTypes.NpgsqlPoint(x: 0.3219312262961538d, y: 0.1052451723935438d), new NpgsqlTypes.NpgsqlPoint(x: 0.5627203932018757d, y: 0.12366591256117221d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9768123402592308d, y: 0.0017682173721326189d), new NpgsqlTypes.NpgsqlPoint(x: 0.6561763933970428d, y: 0.9638502653390325d), new NpgsqlTypes.NpgsqlPoint(x: 0.1753562500057585d, y: 0.14435448248162375d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06630877752835751d, y: 0.7964902774568849d), new NpgsqlTypes.NpgsqlPoint(x: 0.32621905937826257d, y: 0.05074114336255231d), new NpgsqlTypes.NpgsqlPoint(x: 0.8796445511161468d, y: 0.2352273302869694d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.920032218496235d, y: 0.2759016859895814d), new NpgsqlTypes.NpgsqlPoint(x: 0.4331525216743112d, y: 0.6149449330200083d), new NpgsqlTypes.NpgsqlPoint(x: 0.44653498391029d, y: 0.315393643673331d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6128973911505881d, y: 0.7702818524056767d), new NpgsqlTypes.NpgsqlPoint(x: 0.421529257814681d, y: 0.8949739692314684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5922383975521146d, y: 0.3939063972961946d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8225668468630377d, y: 0.7916329174768965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8040687525630453d, y: 0.6291156463259248d), new NpgsqlTypes.NpgsqlPoint(x: 0.4111732083373886d, y: 0.42921512187548994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8157830138007973d, y: 0.100475497993609d), new NpgsqlTypes.NpgsqlPoint(x: 0.28726525366217026d, y: 0.055232448735310635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7298130737042122d, y: 0.7889938978107177d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9751595372787085d, y: 0.8197564454030246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8159210799047146d, y: 0.7635895843660413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046741626282734d, y: 0.6727356110332704d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2801761364923895d, y: 0.6802188405045558d), new NpgsqlTypes.NpgsqlPoint(x: 0.3170365368843706d, y: 0.2167191479172944d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381567774670616d, y: 0.15250198368763712d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6582153924949188d, y: 0.0867947207904668d), new NpgsqlTypes.NpgsqlPoint(x: 0.4853386672846004d, y: 0.23480891818490468d), new NpgsqlTypes.NpgsqlPoint(x: 0.6189111893827453d, y: 0.5887761961328486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8182941933151558d, y: 0.46510905726743934d), new NpgsqlTypes.NpgsqlPoint(x: 0.3179849222021719d, y: 0.24702977662608738d), new NpgsqlTypes.NpgsqlPoint(x: 0.24890748378805094d, y: 0.7965570310340021d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6375475345902966d, y: 0.19542081284030333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358251961629505d, y: 0.17022678370075772d), new NpgsqlTypes.NpgsqlPoint(x: 0.6614381528184025d, y: 0.817377248893103d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17682744503610648d, y: 0.09543569892867243d), new NpgsqlTypes.NpgsqlPoint(x: 0.017414193223439733d, y: 0.48042676306756815d), new NpgsqlTypes.NpgsqlPoint(x: 0.48179188715784027d, y: 0.8807065919925929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.715466442268246d, y: 0.7717249692689633d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550752643357572d, y: 0.07739853144138586d), new NpgsqlTypes.NpgsqlPoint(x: 0.0880472357215164d, y: 0.42222208790334703d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6348384555155036d, y: 0.7088504746724444d), new NpgsqlTypes.NpgsqlPoint(x: 0.4605068735129503d, y: 0.29239231669420895d), new NpgsqlTypes.NpgsqlPoint(x: 0.07415104167206343d, y: 0.47203454420681223d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03620928658727962d, y: 0.2567344900725108d), new NpgsqlTypes.NpgsqlPoint(x: 0.5739162783106776d, y: 0.0872197069467402d), new NpgsqlTypes.NpgsqlPoint(x: 0.34972958936425d, y: 0.6097780182986406d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3151669861792774d, y: 0.4466017435248172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5182146325157013d, y: 0.3743601499174254d), new NpgsqlTypes.NpgsqlPoint(x: 0.37470708502050154d, y: 0.3713097990954054d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3423641799076942d, y: 0.5557046446692663d), new NpgsqlTypes.NpgsqlPoint(x: 0.7727332228416246d, y: 0.8811209972760797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6950459360313611d, y: 0.5796239208422116d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5424575212260967d, y: 0.025529889067499756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636726374138412d, y: 0.10789920480833737d), new NpgsqlTypes.NpgsqlPoint(x: 0.030157112930740637d, y: 0.8229268486630831d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7904077579160736d, y: 0.7333993487185654d), new NpgsqlTypes.NpgsqlPoint(x: 0.4106780861945194d, y: 0.822991820967284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7402917527677876d, y: 0.7252171852926522d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06488339564388268d, y: 0.2996744348855497d), new NpgsqlTypes.NpgsqlPoint(x: 0.11350059414060343d, y: 0.5019606091700383d), new NpgsqlTypes.NpgsqlPoint(x: 0.0651993199693458d, y: 0.004314096548084123d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018487065219517262d, y: 0.49101811178918864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160685581594171d, y: 0.8864580249954469d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769260870060425d, y: 0.6392580904379102d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.478869050584549d, y: 0.968779627824848d), new NpgsqlTypes.NpgsqlPoint(x: 0.4700785667481975d, y: 0.9313370084727544d), new NpgsqlTypes.NpgsqlPoint(x: 0.4311287147481201d, y: 0.725247444285729d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3886015148836691d, y: 0.39713238370331094d), new NpgsqlTypes.NpgsqlPoint(x: 0.04006438386705535d, y: 0.5938396446045977d), new NpgsqlTypes.NpgsqlPoint(x: 0.21317543242880943d, y: 0.42251714287489783d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43788949200280813d, y: 0.4877954631196959d), new NpgsqlTypes.NpgsqlPoint(x: 0.7761888206640586d, y: 0.1611504681547027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6842715810266845d, y: 0.07629024021165631d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.036836944769542024d, y: 0.2674411223416241d), new NpgsqlTypes.NpgsqlPoint(x: 0.517070069936964d, y: 0.4627109291755751d), new NpgsqlTypes.NpgsqlPoint(x: 0.6742977920370608d, y: 0.09030663091238933d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17394678973504651d, y: 0.8625830582878303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8502718974499147d, y: 0.8791303687435683d), new NpgsqlTypes.NpgsqlPoint(x: 0.0034840303284416896d, y: 0.062031943555038604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42923934876050807d, y: 0.09672244030721233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5448740424816144d, y: 0.6460214619265983d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801096774234487d, y: 0.7066933027115211d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5865421772316849d, y: 0.7280799511285809d), new NpgsqlTypes.NpgsqlPoint(x: 0.8664720470193036d, y: 0.729539765676224d), new NpgsqlTypes.NpgsqlPoint(x: 0.18915174331811713d, y: 0.7711698859686169d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8878847509023566d, y: 0.7205282539137637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7655985908990955d, y: 0.3740097101235096d), new NpgsqlTypes.NpgsqlPoint(x: 0.623475755200129d, y: 0.3447416144992814d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5884444789039956d, y: 0.003656009790325987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810425252930489d, y: 0.909696571837394d), new NpgsqlTypes.NpgsqlPoint(x: 0.4546266805696373d, y: 0.46328379110364015d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5536205372934271d, y: 0.24199031318675213d), new NpgsqlTypes.NpgsqlPoint(x: 0.934747435621981d, y: 0.34419984482913135d), new NpgsqlTypes.NpgsqlPoint(x: 0.030039765454379586d, y: 0.5062472148800227d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2480127383950551d, y: 0.2288256076809656d), new NpgsqlTypes.NpgsqlPoint(x: 0.43820065641155626d, y: 0.5376187106866709d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741522857737577d, y: 0.7755941773164361d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22834961392965392d, y: 0.32457926092901723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7362257123382822d, y: 0.17360798009054235d), new NpgsqlTypes.NpgsqlPoint(x: 0.7382217751956283d, y: 0.7345926576070552d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7279968848423202d, y: 0.20597379976719377d), new NpgsqlTypes.NpgsqlPoint(x: 0.6535522498469036d, y: 0.48544155474624484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719369491954663d, y: 0.24174515728570622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6365257747205191d, y: 0.414642344791879d), new NpgsqlTypes.NpgsqlPoint(x: 0.8476046518366839d, y: 0.19741097587265266d), new NpgsqlTypes.NpgsqlPoint(x: 0.22337796942490817d, y: 0.8014207689561298d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7376464513376445d, y: 0.24987448778512755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7387502667492204d, y: 0.04020711701841384d), new NpgsqlTypes.NpgsqlPoint(x: 0.05636800768706296d, y: 0.8496161587327353d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6704688749874101d, y: 0.3271368002887244d), new NpgsqlTypes.NpgsqlPoint(x: 0.1684881920250444d, y: 0.08461072130332914d), new NpgsqlTypes.NpgsqlPoint(x: 0.6121967538952249d, y: 0.4975117480618837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21963285473266758d, y: 0.5039649096017995d), new NpgsqlTypes.NpgsqlPoint(x: 0.47338041268870223d, y: 0.4108362250902373d), new NpgsqlTypes.NpgsqlPoint(x: 0.7981991835499556d, y: 0.09454734576554313d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8044875458898636d, y: 0.11709567488165229d), new NpgsqlTypes.NpgsqlPoint(x: 0.8159867346948471d, y: 0.33452094827146095d), new NpgsqlTypes.NpgsqlPoint(x: 0.4289386732844034d, y: 0.30582822198562d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.625485958233672d, y: 0.6877202123543452d), new NpgsqlTypes.NpgsqlPoint(x: 0.49827905922294613d, y: 0.8329564701642909d), new NpgsqlTypes.NpgsqlPoint(x: 0.7215877551109574d, y: 0.5786469335763607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14710642792420447d, y: 0.5670721116997892d), new NpgsqlTypes.NpgsqlPoint(x: 0.26933023159819813d, y: 0.48859946625227557d), new NpgsqlTypes.NpgsqlPoint(x: 0.9870277272558222d, y: 0.012992991395824993d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.96607498033756d, y: 0.9434782526605261d), new NpgsqlTypes.NpgsqlPoint(x: 0.18996758854450824d, y: 0.7608781943916145d), new NpgsqlTypes.NpgsqlPoint(x: 0.12045679348852267d, y: 0.4979441008141757d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41808153050118535d, y: 0.062212959328558526d), new NpgsqlTypes.NpgsqlPoint(x: 0.820975697093684d, y: 0.3966803484467063d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477931660309407d, y: 0.17408398329431085d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6597802583910285d, y: 0.6247308732259255d), new NpgsqlTypes.NpgsqlPoint(x: 0.3640430664588431d, y: 0.5690230786009254d), new NpgsqlTypes.NpgsqlPoint(x: 0.584835975211518d, y: 0.37918199783683726d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1873438425231876d, y: 0.7491233068962565d), new NpgsqlTypes.NpgsqlPoint(x: 0.12523655046849513d, y: 0.9388373609075331d), new NpgsqlTypes.NpgsqlPoint(x: 0.6306302220913852d, y: 0.11197418749449994d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7509382134578505d, y: 0.12022681532997093d), new NpgsqlTypes.NpgsqlPoint(x: 0.3690523645169479d, y: 0.9224347491823761d), new NpgsqlTypes.NpgsqlPoint(x: 0.2657017609840231d, y: 0.6497319509819537d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20448376618787556d, y: 0.012204861561827318d), new NpgsqlTypes.NpgsqlPoint(x: 0.9002271640454405d, y: 0.13784211861098183d), new NpgsqlTypes.NpgsqlPoint(x: 0.1420654316992519d, y: 0.1158718184672588d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7716955815943762d, y: 0.1282151813532002d), new NpgsqlTypes.NpgsqlPoint(x: 0.5821368877559613d, y: 0.03484627075314961d), new NpgsqlTypes.NpgsqlPoint(x: 0.9734792293803886d, y: 0.06876031898354906d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9769832398424493d, y: 0.7797220664502631d), new NpgsqlTypes.NpgsqlPoint(x: 0.12674350522326405d, y: 0.7661216608235217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922968177473565d, y: 0.02287424192693488d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9295164202317828d, y: 0.5027182709064956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9590396500506968d, y: 0.8192298333991922d), new NpgsqlTypes.NpgsqlPoint(x: 0.12137556177183595d, y: 0.32980408122048466d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5201876449387116d, y: 0.8867291611887576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677568913680484d, y: 0.18625772712555577d), new NpgsqlTypes.NpgsqlPoint(x: 0.5646599018623119d, y: 0.7824319324508624d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2709353048351686d, y: 0.7001626029913691d), new NpgsqlTypes.NpgsqlPoint(x: 0.43322824110949265d, y: 0.447197977360107d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025450832511581d, y: 0.12942028233564906d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9755704802312849d, y: 0.13225616340455715d), new NpgsqlTypes.NpgsqlPoint(x: 0.22688093148664923d, y: 0.9714695207953393d), new NpgsqlTypes.NpgsqlPoint(x: 0.5601666923057859d, y: 0.61825332931275d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21919790093076774d, y: 0.13230758224855077d), new NpgsqlTypes.NpgsqlPoint(x: 0.43206319536119064d, y: 0.6020613057946967d), new NpgsqlTypes.NpgsqlPoint(x: 0.34380028583716493d, y: 0.2881722659673507d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7431335967277288d, y: 0.8995930453246633d), new NpgsqlTypes.NpgsqlPoint(x: 0.828412165638767d, y: 0.2927838977310564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7058686541837078d, y: 0.5617897364782892d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.859360726786026d, y: 0.30881093871026544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082519005303618d, y: 0.47595338208927784d), new NpgsqlTypes.NpgsqlPoint(x: 0.28279750369544643d, y: 0.28646151643439377d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8978782166767462d, y: 0.22144311524863036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5117081953946032d, y: 0.7618535742187108d), new NpgsqlTypes.NpgsqlPoint(x: 0.3217848870936102d, y: 0.015396062699801982d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8005087402601685d, y: 0.05172355288898578d), new NpgsqlTypes.NpgsqlPoint(x: 0.7624375319304044d, y: 0.7121696060041627d), new NpgsqlTypes.NpgsqlPoint(x: 0.2401802867100481d, y: 0.6835976893711939d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6121436272380376d, y: 0.4742272854717894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5597005852438027d, y: 0.7433739766857532d), new NpgsqlTypes.NpgsqlPoint(x: 0.23852866186834554d, y: 0.406157887246106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7244409061493288d, y: 0.11597588225568711d), new NpgsqlTypes.NpgsqlPoint(x: 0.10553383665550531d, y: 0.7405953516704458d), new NpgsqlTypes.NpgsqlPoint(x: 0.670980620565445d, y: 0.08664434961478107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30174952967710034d, y: 0.8848458206055092d), new NpgsqlTypes.NpgsqlPoint(x: 0.7170482933156191d, y: 0.43041099113758774d), new NpgsqlTypes.NpgsqlPoint(x: 0.17523117472829386d, y: 0.966121292063556d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5043625546708654d, y: 0.7114978499822566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746249719900246d, y: 0.593475385621252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6683359473341622d, y: 0.4788402898666553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43447872819886135d, y: 0.04234273337032446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087409567947542d, y: 0.08460675357577951d), new NpgsqlTypes.NpgsqlPoint(x: 0.41340411556700385d, y: 0.7571576367415468d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.982691451598245d, y: 0.41237709146897017d), new NpgsqlTypes.NpgsqlPoint(x: 0.20984329749435715d, y: 0.3297591458483089d), new NpgsqlTypes.NpgsqlPoint(x: 0.2532596450459882d, y: 0.3776862011625125d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8085396314259998d, y: 0.7595332990307526d), new NpgsqlTypes.NpgsqlPoint(x: 0.1343083212232965d, y: 0.7066984494511678d), new NpgsqlTypes.NpgsqlPoint(x: 0.7967987031754489d, y: 0.8298006475287425d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4300920726115951d, y: 0.1685991054378725d), new NpgsqlTypes.NpgsqlPoint(x: 0.685801085707231d, y: 0.30330278102486097d), new NpgsqlTypes.NpgsqlPoint(x: 0.446757443207461d, y: 0.7655877911111905d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.801728056947991d, y: 0.8058700992645806d), new NpgsqlTypes.NpgsqlPoint(x: 0.2977355759427306d, y: 0.43301119538561994d), new NpgsqlTypes.NpgsqlPoint(x: 0.1827453337000351d, y: 0.5210879514454775d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6571340855268852d, y: 0.04747124458694041d), new NpgsqlTypes.NpgsqlPoint(x: 0.39277855011005336d, y: 0.17443520906611398d), new NpgsqlTypes.NpgsqlPoint(x: 0.7242329023161287d, y: 0.11382782906637623d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46312595198876716d, y: 0.06749524781024563d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131963165025231d, y: 0.2961249676017794d), new NpgsqlTypes.NpgsqlPoint(x: 0.40970715259241797d, y: 0.4295207273570034d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31757536480520576d, y: 0.9267141063192019d), new NpgsqlTypes.NpgsqlPoint(x: 0.10230975310633861d, y: 0.46246283232566876d), new NpgsqlTypes.NpgsqlPoint(x: 0.32462623928221246d, y: 0.9534552774854396d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7846293104684402d, y: 0.23518807740180636d), new NpgsqlTypes.NpgsqlPoint(x: 0.2684467160523747d, y: 0.5876328245634634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5695906915757194d, y: 0.9904421062665036d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6563529822996563d, y: 0.17831319140912794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5057998654037915d, y: 0.35545559611369004d), new NpgsqlTypes.NpgsqlPoint(x: 0.3167381050467728d, y: 0.28046218300254755d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3749037674729415d, y: 0.6480210985198396d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824538839140026d, y: 0.13083925839761856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6676168834802986d, y: 0.8505056276163203d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06787454893498113d, y: 0.433115449175415d), new NpgsqlTypes.NpgsqlPoint(x: 0.16034311127466128d, y: 0.5279415093299954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8053493909820809d, y: 0.03129255786994545d)),
}));
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44952853774197565d, y: 0.2954016425629683d), new NpgsqlTypes.NpgsqlPoint(x: 0.8446374266932997d, y: 0.4257303255636883d), new NpgsqlTypes.NpgsqlPoint(x: 0.1339192213814273d, y: 0.888743820284243d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12424565169883084d, y: 0.9011386230786596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693655602959009d, y: 0.026827621712885663d), new NpgsqlTypes.NpgsqlPoint(x: 0.31380466162711884d, y: 0.2730291339867834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5641083038578928d, y: 0.3991522879478673d), new NpgsqlTypes.NpgsqlPoint(x: 0.481903792975353d, y: 0.4373478719199049d), new NpgsqlTypes.NpgsqlPoint(x: 0.6323543300798403d, y: 0.09846763117471857d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9407082839152782d, y: 0.907937853897034d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345392478672211d, y: 0.6344634841638194d), new NpgsqlTypes.NpgsqlPoint(x: 0.46033421500778104d, y: 0.6334227175103255d)),
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13018818029713208d, y: 0.9402968700996069d), new NpgsqlTypes.NpgsqlPoint(x: 0.1929533456151391d, y: 0.3792926609461974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252273228554103d, y: 0.48858023576487775d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6029741920667042d, y: 0.3403324445717504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041342340218468d, y: 0.24210406495002768d), new NpgsqlTypes.NpgsqlPoint(x: 0.809915686128688d, y: 0.4775282116884596d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4948584141663759d, y: 0.14766644317866318d), new NpgsqlTypes.NpgsqlPoint(x: 0.588379800296645d, y: 0.9898556538795247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8748188427580281d, y: 0.8676267598181847d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30125189817101816d, y: 0.6734451455959296d), new NpgsqlTypes.NpgsqlPoint(x: 0.058265967546038855d, y: 0.7086003679630557d), new NpgsqlTypes.NpgsqlPoint(x: 0.4494856126364174d, y: 0.21662164023795716d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5298219991295873d, y: 0.6052430585778336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092251452318148d, y: 0.049445076152491385d), new NpgsqlTypes.NpgsqlPoint(x: 0.06452563372204045d, y: 0.2979358694087476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.026869225313392975d, y: 0.9136885504787365d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337729806201145d, y: 0.04863234743155087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288825742212878d, y: 0.3357219909202869d)),
}));
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
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47141677618586153d, y: 0.7608943033924385d), new NpgsqlTypes.NpgsqlPoint(x: 0.2296425589538874d, y: 0.2257350179220785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7261797746506373d, y: 0.000138009534471073d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26262834487678954d, y: 0.5629044294255061d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499208765683051d, y: 0.5392592823515348d), new NpgsqlTypes.NpgsqlPoint(x: 0.33148700924719576d, y: 0.2423695569865436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7426282457442811d, y: 0.8978729119670876d), new NpgsqlTypes.NpgsqlPoint(x: 0.7953491379731499d, y: 0.21067178469008163d), new NpgsqlTypes.NpgsqlPoint(x: 0.880952025440202d, y: 0.13983475738558548d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7116067376131692d, y: 0.997032752725225d), new NpgsqlTypes.NpgsqlPoint(x: 0.17586607826296707d, y: 0.8650337425797974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654908278753216d, y: 0.9627981060744819d)),
}));
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[34], false);
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
                parametr1.Value = 87;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 91, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 31, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 126, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[34], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 108, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 157, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[34], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 40, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 45, 153))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[34], false);
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
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[34], false);
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

