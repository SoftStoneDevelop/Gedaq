

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6739237705909422d, y: 0.5146566341955114d), new NpgsqlTypes.NpgsqlPoint(x: 0.06981788659285848d, y: 0.05325631001273301d), new NpgsqlTypes.NpgsqlPoint(x: 0.4240744188463078d, y: 0.7308131733221782d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.63007914202594d, y: 0.07142118644403572d), new NpgsqlTypes.NpgsqlPoint(x: 0.06637526585736508d, y: 0.03441758592712918d), new NpgsqlTypes.NpgsqlPoint(x: 0.4382726679077382d, y: 0.13787580123744936d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8368765450335831d, y: 0.5418180749486609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9070236906245729d, y: 0.8765311458908086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7422585858069042d, y: 0.4896746114171773d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9885568531088874d, y: 0.35600703275079415d), new NpgsqlTypes.NpgsqlPoint(x: 0.12472177453188449d, y: 0.15714340908539537d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439863434625527d, y: 0.7930418962902936d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8730896333846443d, y: 0.22637060427023736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034380348696499d, y: 0.2707073631618374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5948831574803934d, y: 0.6018849060653386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3429430149471465d, y: 0.04708331020287526d), new NpgsqlTypes.NpgsqlPoint(x: 0.5459546973966533d, y: 0.7030444809547377d), new NpgsqlTypes.NpgsqlPoint(x: 0.39009864071793476d, y: 0.6878320919310812d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38755886410910134d, y: 0.6744699670553111d), new NpgsqlTypes.NpgsqlPoint(x: 0.34948301463336173d, y: 0.3280521191070417d), new NpgsqlTypes.NpgsqlPoint(x: 0.04210763883859525d, y: 0.46129871884877316d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4121303047416528d, y: 0.5964376681597394d), new NpgsqlTypes.NpgsqlPoint(x: 0.5604382398136342d, y: 0.27704317241849774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8281367676098492d, y: 0.6475220607712785d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48386666801497014d, y: 0.41135578643283177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572340591811329d, y: 0.6995556699340542d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514831024189297d, y: 0.42620126858698115d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9224796419910096d, y: 0.3688103492021708d), new NpgsqlTypes.NpgsqlPoint(x: 0.4439154652613486d, y: 0.40246768256260435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5899118879986947d, y: 0.5179227632634035d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5690450645059266d, y: 0.28965440608685655d), new NpgsqlTypes.NpgsqlPoint(x: 0.35188395088746605d, y: 0.75307931298297d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412362363628762d, y: 0.07123367932013502d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6638504347823739d, y: 0.8898261826434688d), new NpgsqlTypes.NpgsqlPoint(x: 0.47709955676871263d, y: 0.20041026635195192d), new NpgsqlTypes.NpgsqlPoint(x: 0.05872628459428164d, y: 0.1780708550031208d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8407412530302546d, y: 0.49694827056112223d), new NpgsqlTypes.NpgsqlPoint(x: 0.138241115253238d, y: 0.5434488407081488d), new NpgsqlTypes.NpgsqlPoint(x: 0.9611888914649448d, y: 0.5320979913104267d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3174573646974319d, y: 0.18236114211122068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338615457038883d, y: 0.011390467091127343d), new NpgsqlTypes.NpgsqlPoint(x: 0.36484566564244714d, y: 0.310804528912484d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44203242248090735d, y: 0.8564045568787394d), new NpgsqlTypes.NpgsqlPoint(x: 0.32682405195256103d, y: 0.972476843837937d), new NpgsqlTypes.NpgsqlPoint(x: 0.3276039615822043d, y: 0.9710144645971784d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7847510163755621d, y: 0.9199173613703653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9215886597088845d, y: 0.16498793228281605d), new NpgsqlTypes.NpgsqlPoint(x: 0.09380707114419318d, y: 0.4763919496576633d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5005193056071117d, y: 0.0802436675283621d), new NpgsqlTypes.NpgsqlPoint(x: 0.9872848323799871d, y: 0.5994202731702264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5338709764765297d, y: 0.617767809710459d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40218498480097487d, y: 0.9967685157861148d), new NpgsqlTypes.NpgsqlPoint(x: 0.31354173448363964d, y: 0.5812757251972892d), new NpgsqlTypes.NpgsqlPoint(x: 0.0658638852429313d, y: 0.6039458891042213d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19124217409116928d, y: 0.04988958890439987d), new NpgsqlTypes.NpgsqlPoint(x: 0.8838753211748085d, y: 0.5362441346083077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6320381552455953d, y: 0.6573777393334232d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7912708198833149d, y: 0.2133098089499561d), new NpgsqlTypes.NpgsqlPoint(x: 0.0986270690877481d, y: 0.6478365868776917d), new NpgsqlTypes.NpgsqlPoint(x: 0.2141822121928738d, y: 0.1972735097577113d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07077073049680105d, y: 0.4543405925597044d), new NpgsqlTypes.NpgsqlPoint(x: 0.7613279796108717d, y: 0.7318595698466757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7685236485496153d, y: 0.9031172110202311d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9473579582954094d, y: 0.7882393005648678d), new NpgsqlTypes.NpgsqlPoint(x: 0.06654359394348253d, y: 0.5989391014162901d), new NpgsqlTypes.NpgsqlPoint(x: 0.6124525084279794d, y: 0.3293973914360907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2782636292995555d, y: 0.7286474301504114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9354762947242886d, y: 0.02598674945766788d), new NpgsqlTypes.NpgsqlPoint(x: 0.5228012735170058d, y: 0.9230494893631158d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.816081944772828d, y: 0.3496078244201958d), new NpgsqlTypes.NpgsqlPoint(x: 0.9126927630163253d, y: 0.19841010651749358d), new NpgsqlTypes.NpgsqlPoint(x: 0.9297333072192923d, y: 0.015422627177066217d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15904644447477567d, y: 0.3548039862253104d), new NpgsqlTypes.NpgsqlPoint(x: 0.9080397556996669d, y: 0.13435830769814583d), new NpgsqlTypes.NpgsqlPoint(x: 0.03690142739120428d, y: 0.7696707675801457d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.511504671975821d, y: 0.434110354463802d), new NpgsqlTypes.NpgsqlPoint(x: 0.7840803131251619d, y: 0.16621213330729856d), new NpgsqlTypes.NpgsqlPoint(x: 0.28710391027203785d, y: 0.10808804788106241d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40465842748235625d, y: 0.3159411398992956d), new NpgsqlTypes.NpgsqlPoint(x: 0.1850207407410348d, y: 0.7670574830461373d), new NpgsqlTypes.NpgsqlPoint(x: 0.1840244615805926d, y: 0.817966534596024d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17952884943297454d, y: 0.49984341861857784d), new NpgsqlTypes.NpgsqlPoint(x: 0.954701544435257d, y: 0.7994451895088912d), new NpgsqlTypes.NpgsqlPoint(x: 0.4782510192227075d, y: 0.7484797203350484d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13123478442469738d, y: 0.16478143478388885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994093227233052d, y: 0.12775309043571348d), new NpgsqlTypes.NpgsqlPoint(x: 0.18836134160888007d, y: 0.5003932637881348d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4795650723466687d, y: 0.7266649913001316d), new NpgsqlTypes.NpgsqlPoint(x: 0.9299503635154797d, y: 0.24898292766246022d), new NpgsqlTypes.NpgsqlPoint(x: 0.7276087406595645d, y: 0.11961244257401704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39037491662254253d, y: 0.5137267294876277d), new NpgsqlTypes.NpgsqlPoint(x: 0.11780055000066936d, y: 0.78484134096551d), new NpgsqlTypes.NpgsqlPoint(x: 0.22513902459488966d, y: 0.16368413778981872d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.253739976489633d, y: 0.036578424767226725d), new NpgsqlTypes.NpgsqlPoint(x: 0.32355870434027145d, y: 0.9713055178212044d), new NpgsqlTypes.NpgsqlPoint(x: 0.4286387049632441d, y: 0.03326348720148109d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8385821321707074d, y: 0.6147200536093889d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670894094138115d, y: 0.22065826893324214d), new NpgsqlTypes.NpgsqlPoint(x: 0.2651899431805277d, y: 0.48259478620221086d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7442998635783633d, y: 0.06596882876350563d), new NpgsqlTypes.NpgsqlPoint(x: 0.06544607611624953d, y: 0.9362783982308588d), new NpgsqlTypes.NpgsqlPoint(x: 0.07430701781309967d, y: 0.6519761643167632d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5878385464278694d, y: 0.3765342518485968d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607589977168291d, y: 0.3933799290643015d), new NpgsqlTypes.NpgsqlPoint(x: 0.20105383953422895d, y: 0.2576807239658061d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9938250056963374d, y: 0.44529852741335363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7049126167885442d, y: 0.2075199015603526d), new NpgsqlTypes.NpgsqlPoint(x: 0.5065253656333133d, y: 0.8428948552358135d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6666750116014097d, y: 0.9195594282351681d), new NpgsqlTypes.NpgsqlPoint(x: 0.5509427532424526d, y: 0.2694405254880978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168954179502072d, y: 0.30780778517774154d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5304609857591095d, y: 0.007844635802484068d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514198714834707d, y: 0.47778060110497356d), new NpgsqlTypes.NpgsqlPoint(x: 0.3880444844421226d, y: 0.6783855779988857d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5732243514604408d, y: 0.4081408163340936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5069969385683405d, y: 0.599311681602872d), new NpgsqlTypes.NpgsqlPoint(x: 0.7458290059686887d, y: 0.8540852264504145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5801141631771194d, y: 0.055892146841662105d), new NpgsqlTypes.NpgsqlPoint(x: 0.6366347180824747d, y: 0.025710232744557193d), new NpgsqlTypes.NpgsqlPoint(x: 0.6936919786935518d, y: 0.354726953894953d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9483262742076963d, y: 0.63920397927471d), new NpgsqlTypes.NpgsqlPoint(x: 0.0717758288885324d, y: 0.4205839158155361d), new NpgsqlTypes.NpgsqlPoint(x: 0.12474998230585d, y: 0.14631259895727378d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3545449252158661d, y: 0.9125941674636228d), new NpgsqlTypes.NpgsqlPoint(x: 0.00284512335071585d, y: 0.8319475435946191d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938928878591161d, y: 0.29415752490333447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7172024819275696d, y: 0.8782792297213272d), new NpgsqlTypes.NpgsqlPoint(x: 0.06985946514181895d, y: 0.7512674932898942d), new NpgsqlTypes.NpgsqlPoint(x: 0.7310412593493933d, y: 0.9557472136487261d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7475066815888979d, y: 0.7172364945332289d), new NpgsqlTypes.NpgsqlPoint(x: 0.1207711763137217d, y: 0.9653739369597256d), new NpgsqlTypes.NpgsqlPoint(x: 0.6418804829869991d, y: 0.5432181476692685d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.574307375184281d, y: 0.18619343604978333d), new NpgsqlTypes.NpgsqlPoint(x: 0.35684791553441453d, y: 0.09637363470863303d), new NpgsqlTypes.NpgsqlPoint(x: 0.4567225629376197d, y: 0.039534227765440466d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.940739269529722d, y: 0.5875053408082672d), new NpgsqlTypes.NpgsqlPoint(x: 0.1572322691378727d, y: 0.5689443825321512d), new NpgsqlTypes.NpgsqlPoint(x: 0.6955268610430566d, y: 0.2012406043702606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5736274393472655d, y: 0.6550902362978055d), new NpgsqlTypes.NpgsqlPoint(x: 0.41132531584765586d, y: 0.9333325282185606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6837804627287384d, y: 0.47354709503117975d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4368288631723144d, y: 0.8844523833914278d), new NpgsqlTypes.NpgsqlPoint(x: 0.37970160551890975d, y: 0.2676004569900766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8078698633801744d, y: 0.7059442098416205d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2165734299052422d, y: 0.030779623081802376d), new NpgsqlTypes.NpgsqlPoint(x: 0.8058530937676325d, y: 0.4169503901306323d), new NpgsqlTypes.NpgsqlPoint(x: 0.20582811830599812d, y: 0.1151029334884277d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39581415235387973d, y: 0.11840058233237072d), new NpgsqlTypes.NpgsqlPoint(x: 0.8720279115291936d, y: 0.46977269096810714d), new NpgsqlTypes.NpgsqlPoint(x: 0.47469147141724166d, y: 0.3623911754349458d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4988083164108039d, y: 0.6122589418300154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9391531801330129d, y: 0.672576130847616d), new NpgsqlTypes.NpgsqlPoint(x: 0.5828399611450278d, y: 0.2878619857577831d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4031854142606299d, y: 0.42453003997189953d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945634023897939d, y: 0.5268478650947334d), new NpgsqlTypes.NpgsqlPoint(x: 0.8991672074867618d, y: 0.36461089801245694d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2533737941206119d, y: 0.5605977437603415d), new NpgsqlTypes.NpgsqlPoint(x: 0.06763159250422524d, y: 0.2635395468808953d), new NpgsqlTypes.NpgsqlPoint(x: 0.22536020297846893d, y: 0.5368194165370677d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7366406883072528d, y: 0.04046550581094599d), new NpgsqlTypes.NpgsqlPoint(x: 0.42432536107757d, y: 0.10780325484229514d), new NpgsqlTypes.NpgsqlPoint(x: 0.11863880012668393d, y: 0.14171007576258432d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2335688743658645d, y: 0.8604519341201523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835239529861924d, y: 0.6583390543475097d), new NpgsqlTypes.NpgsqlPoint(x: 0.6506556777361748d, y: 0.013964259948910374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32290471740491344d, y: 0.7278019425279698d), new NpgsqlTypes.NpgsqlPoint(x: 0.7178529282226666d, y: 0.064954952585072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054746648967608d, y: 0.17482412591413388d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6604446246126624d, y: 0.18466223665702108d), new NpgsqlTypes.NpgsqlPoint(x: 0.08156478780127896d, y: 0.7848352542014149d), new NpgsqlTypes.NpgsqlPoint(x: 0.7560440986129637d, y: 0.26149527714531584d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.381415792350296d, y: 0.8140556516170347d), new NpgsqlTypes.NpgsqlPoint(x: 0.05969017536166976d, y: 0.007605623416697682d), new NpgsqlTypes.NpgsqlPoint(x: 0.6128117480004326d, y: 0.4175800744547654d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9615851093086748d, y: 0.8263908788500306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8028659060319068d, y: 0.5389924290064679d), new NpgsqlTypes.NpgsqlPoint(x: 0.08045038452217712d, y: 0.77888362009635d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6290850758951165d, y: 0.4398980240999183d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434391786602349d, y: 0.09555761856152367d), new NpgsqlTypes.NpgsqlPoint(x: 0.73745004672955d, y: 0.5616907958751723d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.742426368054237d, y: 0.37647759313174756d), new NpgsqlTypes.NpgsqlPoint(x: 0.500636256838773d, y: 0.8221603748645644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7514252458952763d, y: 0.05045821803442008d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22302382679663657d, y: 0.9595994937907828d), new NpgsqlTypes.NpgsqlPoint(x: 0.2836060824485981d, y: 0.37719717151858123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311941482605034d, y: 0.23788282242070946d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27334653382649843d, y: 0.278596115052154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529376693273664d, y: 0.5330807327449427d), new NpgsqlTypes.NpgsqlPoint(x: 0.15178429432804563d, y: 0.5004425806318522d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6901060130699813d, y: 0.5365014643487366d), new NpgsqlTypes.NpgsqlPoint(x: 0.29465882869458426d, y: 0.7813462675741283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739441164736122d, y: 0.33629681763069585d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6211843478355744d, y: 0.46872906209933396d), new NpgsqlTypes.NpgsqlPoint(x: 0.6371509528541967d, y: 0.6948406014737512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7719963082431196d, y: 0.8543007786884649d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12570651573123015d, y: 0.8287706944556809d), new NpgsqlTypes.NpgsqlPoint(x: 0.5427504806091378d, y: 0.18729334266401998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800746801377506d, y: 0.8249091887545135d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7196103781253638d, y: 0.6626941827174412d), new NpgsqlTypes.NpgsqlPoint(x: 0.679130677655286d, y: 0.19777589723705413d), new NpgsqlTypes.NpgsqlPoint(x: 0.6681919782528581d, y: 0.38813184392269207d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6648879554261709d, y: 0.023808552623605372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7600819354403677d, y: 0.6817861996652897d), new NpgsqlTypes.NpgsqlPoint(x: 0.4065300626774213d, y: 0.009850804178432537d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9805421109705128d, y: 0.19751382226333714d), new NpgsqlTypes.NpgsqlPoint(x: 0.07274498894081183d, y: 0.9327112823180869d), new NpgsqlTypes.NpgsqlPoint(x: 0.41234726675587174d, y: 0.18115268175056687d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3814378625671355d, y: 0.9905856030432484d), new NpgsqlTypes.NpgsqlPoint(x: 0.2869790145852309d, y: 0.31310493285592944d), new NpgsqlTypes.NpgsqlPoint(x: 0.5094268709926979d, y: 0.3166041283391223d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3944417599412231d, y: 0.6738614452914801d), new NpgsqlTypes.NpgsqlPoint(x: 0.6109641423161045d, y: 0.14553079442410266d), new NpgsqlTypes.NpgsqlPoint(x: 0.3013659922996368d, y: 0.17766856370387096d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49539338217138174d, y: 0.07893601001506212d), new NpgsqlTypes.NpgsqlPoint(x: 0.17879603430660318d, y: 0.2019887838355d), new NpgsqlTypes.NpgsqlPoint(x: 0.9904034543506207d, y: 0.03414403545588063d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8900852492172683d, y: 0.4465450438241604d), new NpgsqlTypes.NpgsqlPoint(x: 0.05428562025417838d, y: 0.5353226591256668d), new NpgsqlTypes.NpgsqlPoint(x: 0.9014405470893054d, y: 0.0795524315419256d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3948579043653707d, y: 0.5935687796176875d), new NpgsqlTypes.NpgsqlPoint(x: 0.48706448250459944d, y: 0.7114620495467703d), new NpgsqlTypes.NpgsqlPoint(x: 0.15432709981303616d, y: 0.2084955211817946d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08978807713659454d, y: 0.935770774881152d), new NpgsqlTypes.NpgsqlPoint(x: 0.44320918070578286d, y: 0.6834529606654535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9719188507497913d, y: 0.7285245618239837d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8562355994750558d, y: 0.5363918155061445d), new NpgsqlTypes.NpgsqlPoint(x: 0.04732244094108562d, y: 0.9798474310286563d), new NpgsqlTypes.NpgsqlPoint(x: 0.7800536588557428d, y: 0.4965984765328224d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7437336983338056d, y: 0.7832078697254493d), new NpgsqlTypes.NpgsqlPoint(x: 0.7817140377150099d, y: 0.044370699061326735d), new NpgsqlTypes.NpgsqlPoint(x: 0.38864690341563746d, y: 0.836615705815618d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7974471770774523d, y: 0.46186687714551244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7265566475930435d, y: 0.8303723960926466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9904314347800898d, y: 0.350766990336012d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8502588569501415d, y: 0.5192591254353817d), new NpgsqlTypes.NpgsqlPoint(x: 0.013109190249186886d, y: 0.3399099292878923d), new NpgsqlTypes.NpgsqlPoint(x: 0.8834475698356767d, y: 0.4877409441771414d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6403249717854286d, y: 0.6456758109974922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5974922895490836d, y: 0.7743435401285983d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875465879408466d, y: 0.6820076352498015d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7267496422488608d, y: 0.44504542643707856d), new NpgsqlTypes.NpgsqlPoint(x: 0.47784896567152346d, y: 0.9946600427969143d), new NpgsqlTypes.NpgsqlPoint(x: 0.853745125081195d, y: 0.9826961527618492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.031805813654083415d, y: 0.32670313954153074d), new NpgsqlTypes.NpgsqlPoint(x: 0.3776227913113013d, y: 0.5581210200997156d), new NpgsqlTypes.NpgsqlPoint(x: 0.7303604128528529d, y: 0.17705068579340277d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47169784818561267d, y: 0.4809075203602753d), new NpgsqlTypes.NpgsqlPoint(x: 0.9599885403769273d, y: 0.20563408731228494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991072746951706d, y: 0.9472637528939665d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22820049399910647d, y: 0.5615012667464551d), new NpgsqlTypes.NpgsqlPoint(x: 0.2272273116247281d, y: 0.048079555234028404d), new NpgsqlTypes.NpgsqlPoint(x: 0.05823851192540119d, y: 0.9574029660083251d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6771275589104774d, y: 0.8159803228770235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4654883087477386d, y: 0.0017999990134726085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750703319016868d, y: 0.3569837813816319d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.578516196615242d, y: 0.01727797723138491d), new NpgsqlTypes.NpgsqlPoint(x: 0.0972844766857407d, y: 0.2328621192180319d), new NpgsqlTypes.NpgsqlPoint(x: 0.05304387956538115d, y: 0.8385464049430575d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9572361503521468d, y: 0.3578692738934225d), new NpgsqlTypes.NpgsqlPoint(x: 0.2257128959666752d, y: 0.8283902463307228d), new NpgsqlTypes.NpgsqlPoint(x: 0.10255894173564906d, y: 0.16904269247526904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7049884517526765d, y: 0.7153238236654462d), new NpgsqlTypes.NpgsqlPoint(x: 0.7322029093432942d, y: 0.7283128561403563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6306501624413007d, y: 0.9197817661192582d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8353935027904357d, y: 0.23427637685106983d), new NpgsqlTypes.NpgsqlPoint(x: 0.6475926510936337d, y: 0.3391435792156826d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429038931474338d, y: 0.5557271085201562d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9225300818102872d, y: 0.09427491698812684d), new NpgsqlTypes.NpgsqlPoint(x: 0.934607810424094d, y: 0.7196469737714615d), new NpgsqlTypes.NpgsqlPoint(x: 0.540112709824678d, y: 0.6126483259163444d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3907506736203237d, y: 0.1429850361848215d), new NpgsqlTypes.NpgsqlPoint(x: 0.9150789992377907d, y: 0.9979790228945449d), new NpgsqlTypes.NpgsqlPoint(x: 0.4275770644701208d, y: 0.4280773400857575d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39848271538622326d, y: 0.17596200162716025d), new NpgsqlTypes.NpgsqlPoint(x: 0.10713896454400162d, y: 0.4634879021970598d), new NpgsqlTypes.NpgsqlPoint(x: 0.9903797394224156d, y: 0.9821057447815082d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.111012272963668d, y: 0.1799683574360994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7011381186737973d, y: 0.6955361953154694d), new NpgsqlTypes.NpgsqlPoint(x: 0.568859814537317d, y: 0.05588312304684029d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3373874069419158d, y: 0.9991760318985832d), new NpgsqlTypes.NpgsqlPoint(x: 0.027066612821327052d, y: 0.6709738520313766d), new NpgsqlTypes.NpgsqlPoint(x: 0.950398136014978d, y: 0.6916637709347733d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1882779683871132d, y: 0.00531659768581727d), new NpgsqlTypes.NpgsqlPoint(x: 0.9881107904339316d, y: 0.7942150458486458d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809449868744977d, y: 0.08458618105717064d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15116278881536516d, y: 0.4686447433665265d), new NpgsqlTypes.NpgsqlPoint(x: 0.272450465576883d, y: 0.17955261347787332d), new NpgsqlTypes.NpgsqlPoint(x: 0.07857657414898156d, y: 0.7900973344257681d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6502389368958853d, y: 0.3060526626367509d), new NpgsqlTypes.NpgsqlPoint(x: 0.18950585775350248d, y: 0.8341111398156673d), new NpgsqlTypes.NpgsqlPoint(x: 0.9900992963955185d, y: 0.22986753526711157d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7182642019197177d, y: 0.9547254517926155d), new NpgsqlTypes.NpgsqlPoint(x: 0.20285874577255536d, y: 0.990727211274454d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179818086384178d, y: 0.7277166181364835d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5290975027847501d, y: 0.9810722665941586d), new NpgsqlTypes.NpgsqlPoint(x: 0.43562131691182304d, y: 0.8031060590543627d), new NpgsqlTypes.NpgsqlPoint(x: 0.10168814989177777d, y: 0.7189633715934802d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38901238314708586d, y: 0.8014308610772678d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442028633105975d, y: 0.061175388439428935d), new NpgsqlTypes.NpgsqlPoint(x: 0.06690524786085683d, y: 0.7401680501428628d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008847464742581579d, y: 0.31990487310539506d), new NpgsqlTypes.NpgsqlPoint(x: 0.013699901916570112d, y: 0.9571733363211719d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174558642797533d, y: 0.8535325528158754d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.387024475982395d, y: 0.39892801051527726d), new NpgsqlTypes.NpgsqlPoint(x: 0.29482431141602505d, y: 0.9019829213144888d), new NpgsqlTypes.NpgsqlPoint(x: 0.4050006945522979d, y: 0.8986223145700596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3266188722431993d, y: 0.467108049890089d), new NpgsqlTypes.NpgsqlPoint(x: 0.5541980263667153d, y: 0.7209096590961512d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621470787743988d, y: 0.3121420988483492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003412707092909084d, y: 0.7275171085792473d), new NpgsqlTypes.NpgsqlPoint(x: 0.5480781891864717d, y: 0.5106149068342852d), new NpgsqlTypes.NpgsqlPoint(x: 0.0014005643089743947d, y: 0.1462659523917098d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6898711320179937d, y: 0.1268823249601938d), new NpgsqlTypes.NpgsqlPoint(x: 0.914146849286056d, y: 0.3995761708754574d), new NpgsqlTypes.NpgsqlPoint(x: 0.31572779663391537d, y: 0.3573492654536904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29098465984668165d, y: 0.8013485380682245d), new NpgsqlTypes.NpgsqlPoint(x: 0.141684456997473d, y: 0.0950100704586081d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953400200225185d, y: 0.6959244451989104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.342077798551062d, y: 0.09250787301513985d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775200189310873d, y: 0.6940456448571684d), new NpgsqlTypes.NpgsqlPoint(x: 0.48243073246204404d, y: 0.9115093520551228d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5000305296760141d, y: 0.3793952316198935d), new NpgsqlTypes.NpgsqlPoint(x: 0.08495534643045777d, y: 0.14074053698502242d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434152845027904d, y: 0.9224891242929543d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7245218430589373d, y: 0.41759509889796476d), new NpgsqlTypes.NpgsqlPoint(x: 0.28268229949266466d, y: 0.5026079340099513d), new NpgsqlTypes.NpgsqlPoint(x: 0.989732466599368d, y: 0.02472869893008922d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6546819792024781d, y: 0.8359772720839659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7014456945437558d, y: 0.16382284784104817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8200350779131823d, y: 0.5748172161349592d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016351781241253582d, y: 0.21048408296697996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9379307631246588d, y: 0.3995541757843447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9999317299345345d, y: 0.9543580622423639d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2836181195047589d, y: 0.4618932014294521d), new NpgsqlTypes.NpgsqlPoint(x: 0.1572714042133302d, y: 0.3687700513947232d), new NpgsqlTypes.NpgsqlPoint(x: 0.727276158015535d, y: 0.18322104495712377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.445059406195197d, y: 0.8134546420846119d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905515415988835d, y: 0.0882558583978239d), new NpgsqlTypes.NpgsqlPoint(x: 0.44144102726975165d, y: 0.3542057429104093d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5449854928355292d, y: 0.6173931824603022d), new NpgsqlTypes.NpgsqlPoint(x: 0.3733065067081761d, y: 0.8518833918955561d), new NpgsqlTypes.NpgsqlPoint(x: 0.01028105666251855d, y: 0.26160852996116546d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9843301703104628d, y: 0.8427193093394411d), new NpgsqlTypes.NpgsqlPoint(x: 0.5478312470507885d, y: 0.680964823802144d), new NpgsqlTypes.NpgsqlPoint(x: 0.41814141622367884d, y: 0.40896329346960436d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7960038969390391d, y: 0.15105550033998028d), new NpgsqlTypes.NpgsqlPoint(x: 0.39811493770152107d, y: 0.44278038981943846d), new NpgsqlTypes.NpgsqlPoint(x: 0.06611167756589986d, y: 0.5917869305617709d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7912850186263153d, y: 0.6340804687246206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6971156689143784d, y: 0.621837600137189d), new NpgsqlTypes.NpgsqlPoint(x: 0.08456497198578783d, y: 0.7335759673361386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12457508733590494d, y: 0.03710035625601482d), new NpgsqlTypes.NpgsqlPoint(x: 0.906730393504838d, y: 0.029078680752083974d), new NpgsqlTypes.NpgsqlPoint(x: 0.2881276838588217d, y: 0.7897455633821899d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8428643525454659d, y: 0.8559448199770676d), new NpgsqlTypes.NpgsqlPoint(x: 0.47682311895763485d, y: 0.5041966425352975d), new NpgsqlTypes.NpgsqlPoint(x: 0.3131409602897759d, y: 0.23988113571444936d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7348942615251155d, y: 0.18092405030193037d), new NpgsqlTypes.NpgsqlPoint(x: 0.30353872630483725d, y: 0.04836418912422491d), new NpgsqlTypes.NpgsqlPoint(x: 0.6551129813816945d, y: 0.014692077209681687d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7956460891747144d, y: 0.7700748953047525d), new NpgsqlTypes.NpgsqlPoint(x: 0.5328939439297797d, y: 0.5804068672952928d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036330389523839d, y: 0.9070715224744716d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.050057098528916155d, y: 0.31535550453416206d), new NpgsqlTypes.NpgsqlPoint(x: 0.1663084519963196d, y: 0.7344955279233226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6466066204543207d, y: 0.8550137526217372d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6922697492586828d, y: 0.18865742876027602d), new NpgsqlTypes.NpgsqlPoint(x: 0.1275924410242224d, y: 0.15757643981026515d), new NpgsqlTypes.NpgsqlPoint(x: 0.024777184282980258d, y: 0.19817038978772228d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.953969156290287d, y: 0.41683836938740615d), new NpgsqlTypes.NpgsqlPoint(x: 0.578680762280744d, y: 0.5316136910506305d), new NpgsqlTypes.NpgsqlPoint(x: 0.1709631757638782d, y: 0.276923155774499d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6490311784973527d, y: 0.30955634703743173d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859227407991726d, y: 0.39516822755046743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9359944315615324d, y: 0.469407985572462d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9478507333442673d, y: 0.8039950830735992d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590885157615713d, y: 0.7746057441110545d), new NpgsqlTypes.NpgsqlPoint(x: 0.3419300041847463d, y: 0.4101186326326861d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6936502405076509d, y: 0.6310005468139921d), new NpgsqlTypes.NpgsqlPoint(x: 0.78779192275117d, y: 0.8208528804466193d), new NpgsqlTypes.NpgsqlPoint(x: 0.3581888908374685d, y: 0.3335819315502022d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9802029748321126d, y: 0.7790121483087019d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708117965197629d, y: 0.6962219900206527d), new NpgsqlTypes.NpgsqlPoint(x: 0.145116426567237d, y: 0.5543720984809539d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6352109791531447d, y: 0.9248896228002234d), new NpgsqlTypes.NpgsqlPoint(x: 0.31599464011707357d, y: 0.6058319780108029d), new NpgsqlTypes.NpgsqlPoint(x: 0.20574852696645873d, y: 0.2802747636083299d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.474226405534221d, y: 0.4697228504969949d), new NpgsqlTypes.NpgsqlPoint(x: 0.783016932929538d, y: 0.33253505798268657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5997659341167223d, y: 0.5284454471705854d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.759440139231297d, y: 0.11809950791712354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5289558590480101d, y: 0.4272257518174746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6949074607368629d, y: 0.12321301867357715d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40558296385088277d, y: 0.883733979359614d), new NpgsqlTypes.NpgsqlPoint(x: 0.47737928736411006d, y: 0.679334680000496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5979115697753384d, y: 0.6029068363875113d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24520654214884818d, y: 0.8864264151948338d), new NpgsqlTypes.NpgsqlPoint(x: 0.8550732464745694d, y: 0.5934281903883413d), new NpgsqlTypes.NpgsqlPoint(x: 0.6284444470292516d, y: 0.055515541346898845d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8131737000403503d, y: 0.3567860114113991d), new NpgsqlTypes.NpgsqlPoint(x: 0.5606965357920072d, y: 0.8097084509656313d), new NpgsqlTypes.NpgsqlPoint(x: 0.4957390932071891d, y: 0.9736097225564031d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3925390989136329d, y: 0.587735471041599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6184524615756065d, y: 0.06699666342067534d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766606866589643d, y: 0.8576690940346814d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3247178771477165d, y: 0.9330040726143657d), new NpgsqlTypes.NpgsqlPoint(x: 0.9390024214062782d, y: 0.9145367657969135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8325573833378194d, y: 0.11395776753289877d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45024121878106527d, y: 0.36899438279937236d), new NpgsqlTypes.NpgsqlPoint(x: 0.14885863864938254d, y: 0.5857034508674536d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825778996654467d, y: 0.5811302314406345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9170444264530888d, y: 0.4996549386901247d), new NpgsqlTypes.NpgsqlPoint(x: 0.2524612729239851d, y: 0.33920120803378684d), new NpgsqlTypes.NpgsqlPoint(x: 0.4236843491440494d, y: 0.8287514729833518d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2395971664978115d, y: 0.5648527659466812d), new NpgsqlTypes.NpgsqlPoint(x: 0.6634027376217337d, y: 0.5338140042180048d), new NpgsqlTypes.NpgsqlPoint(x: 0.46822284539616155d, y: 0.5781808513845655d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6671350575300814d, y: 0.370479025791279d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637144003609421d, y: 0.4947794624410399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9104044915583903d, y: 0.08133914456123836d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8212508397037286d, y: 0.31934148794517414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5107988816454032d, y: 0.29297173515923947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249525756852778d, y: 0.05843774812282165d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9931969702748821d, y: 0.20188372981667868d), new NpgsqlTypes.NpgsqlPoint(x: 0.011606891355216864d, y: 0.10964059681515026d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945043499535797d, y: 0.9826718961136852d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9149193245395096d, y: 0.43568377434915606d), new NpgsqlTypes.NpgsqlPoint(x: 0.3092478023172728d, y: 0.4766437160875642d), new NpgsqlTypes.NpgsqlPoint(x: 0.17132341246790295d, y: 0.13116330627142314d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19332061818904223d, y: 0.5742289853520866d), new NpgsqlTypes.NpgsqlPoint(x: 0.3644611771140053d, y: 0.4604770449240154d), new NpgsqlTypes.NpgsqlPoint(x: 0.4309166813228308d, y: 0.6460175373453508d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1609837676351734d, y: 0.3243822399208045d), new NpgsqlTypes.NpgsqlPoint(x: 0.696657845392105d, y: 0.12456606491807298d), new NpgsqlTypes.NpgsqlPoint(x: 0.11628030457250649d, y: 0.8708018477840751d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7807802972119603d, y: 0.6629750185836761d), new NpgsqlTypes.NpgsqlPoint(x: 0.7133871235193298d, y: 0.5068155826262621d), new NpgsqlTypes.NpgsqlPoint(x: 0.31667596805877296d, y: 0.6988718190775749d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.870712379409194d, y: 0.9895603092844955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9859105892510707d, y: 0.9619262929396204d), new NpgsqlTypes.NpgsqlPoint(x: 0.20603096461997783d, y: 0.7553487494241976d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03790621615562573d, y: 0.43825729487946863d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549355549107184d, y: 0.3897075991101653d), new NpgsqlTypes.NpgsqlPoint(x: 0.7740649334937224d, y: 0.614286552107113d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6574878299795285d, y: 0.019075074766712108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6057532566377967d, y: 0.6155494674485584d), new NpgsqlTypes.NpgsqlPoint(x: 0.11553980627132254d, y: 0.45915734353768556d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16288705025261463d, y: 0.30168687428682384d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393417744321009d, y: 0.5140268629697905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3642719694541763d, y: 0.6924097825324289d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8426113241082791d, y: 0.33999407152142436d), new NpgsqlTypes.NpgsqlPoint(x: 0.4405761259978328d, y: 0.15659618454549273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8956513637133623d, y: 0.7069590591300288d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9420486718341042d, y: 0.1549529608860497d), new NpgsqlTypes.NpgsqlPoint(x: 0.8011951056191261d, y: 0.5321294297135587d), new NpgsqlTypes.NpgsqlPoint(x: 0.6228230694442887d, y: 0.027622360511344812d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8234843362646409d, y: 0.29115653111651196d), new NpgsqlTypes.NpgsqlPoint(x: 0.05098215065115985d, y: 0.8810510764247089d), new NpgsqlTypes.NpgsqlPoint(x: 0.046560096674851725d, y: 0.13882559234365877d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20564290535839325d, y: 0.18017862459297773d), new NpgsqlTypes.NpgsqlPoint(x: 0.36473742975489154d, y: 0.27810481015099975d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991990049548085d, y: 0.543337070277068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8856331370671306d, y: 0.41377582788996214d), new NpgsqlTypes.NpgsqlPoint(x: 0.9188650394259398d, y: 0.4246896197175557d), new NpgsqlTypes.NpgsqlPoint(x: 0.294810106479206d, y: 0.8059204920391319d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018920988540425565d, y: 0.8118284610355391d), new NpgsqlTypes.NpgsqlPoint(x: 0.11960854385348729d, y: 0.8440820647532923d), new NpgsqlTypes.NpgsqlPoint(x: 0.47090849150419134d, y: 0.016993183086609798d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9495228721119716d, y: 0.17598183542629597d), new NpgsqlTypes.NpgsqlPoint(x: 0.26234576477085303d, y: 0.6017946850866808d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116837557623034d, y: 0.7847793519585625d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9587305092333281d, y: 0.9664640165280274d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317434828378628d, y: 0.03136190857684029d), new NpgsqlTypes.NpgsqlPoint(x: 0.04110807072480549d, y: 0.6495204110184285d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7149206256463685d, y: 0.4124226210640286d), new NpgsqlTypes.NpgsqlPoint(x: 0.17579578807610607d, y: 0.4544987732556204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6204290902051467d, y: 0.452291704835333d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.120571585194724d, y: 0.6546106407001507d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408793099832869d, y: 0.42955859151753484d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113330471078698d, y: 0.20164625750135068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6592122391804641d, y: 0.9896261831439044d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137894843455658d, y: 0.6427578471501695d), new NpgsqlTypes.NpgsqlPoint(x: 0.47824968133252055d, y: 0.3249206686313364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29950804699381484d, y: 0.17932529871778213d), new NpgsqlTypes.NpgsqlPoint(x: 0.35507394854673946d, y: 0.196628113946969d), new NpgsqlTypes.NpgsqlPoint(x: 0.991339750423964d, y: 0.16471298431555692d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3797212222848927d, y: 0.8411967319986201d), new NpgsqlTypes.NpgsqlPoint(x: 0.3504975196776372d, y: 0.4630332915166725d), new NpgsqlTypes.NpgsqlPoint(x: 0.1644583450845044d, y: 0.8307804499688063d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9190380683171655d, y: 0.09356743091825526d), new NpgsqlTypes.NpgsqlPoint(x: 0.9680817400092654d, y: 0.4944738297114357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5948326006371822d, y: 0.14966989295075805d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9681850964199845d, y: 0.07401674736725106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5818437224369208d, y: 0.2880333905667124d), new NpgsqlTypes.NpgsqlPoint(x: 0.571696734688432d, y: 0.6129065375460439d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5591207615115579d, y: 0.8541050579224487d), new NpgsqlTypes.NpgsqlPoint(x: 0.21211377288338362d, y: 0.23370235633914715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8916459175488199d, y: 0.7525944506863893d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39228301196982474d, y: 0.2088564690278909d), new NpgsqlTypes.NpgsqlPoint(x: 0.8521631640727415d, y: 0.2711312891067177d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565582777348332d, y: 0.8411017645399482d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35988901244900773d, y: 0.13644525397205343d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023459224149647d, y: 0.7089884405127801d), new NpgsqlTypes.NpgsqlPoint(x: 0.3659988743583996d, y: 0.4263837590812789d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28432021879177616d, y: 0.9327568417962095d), new NpgsqlTypes.NpgsqlPoint(x: 0.3899846655774091d, y: 0.27282763588968184d), new NpgsqlTypes.NpgsqlPoint(x: 0.521913731029042d, y: 0.7360963818802594d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7933379673535026d, y: 0.015049143602465231d), new NpgsqlTypes.NpgsqlPoint(x: 0.0897988799590902d, y: 0.7064909132400304d), new NpgsqlTypes.NpgsqlPoint(x: 0.2470127841382136d, y: 0.7279642498389474d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12168248389440983d, y: 0.732351331397375d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579327956523229d, y: 0.7971290804507055d), new NpgsqlTypes.NpgsqlPoint(x: 0.12267945423928839d, y: 0.44389843456687694d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6690224412161774d, y: 0.7355346990426527d), new NpgsqlTypes.NpgsqlPoint(x: 0.44531881810601903d, y: 0.97778158705089d), new NpgsqlTypes.NpgsqlPoint(x: 0.8400919546885761d, y: 0.9273477215334398d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.661523608237447d, y: 0.970250939878685d), new NpgsqlTypes.NpgsqlPoint(x: 0.012849643724659798d, y: 0.26075094691195444d), new NpgsqlTypes.NpgsqlPoint(x: 0.04447522415826599d, y: 0.2866865863477498d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2394356882705494d, y: 0.7344925300321882d), new NpgsqlTypes.NpgsqlPoint(x: 0.24520209531788673d, y: 0.5095959330074725d), new NpgsqlTypes.NpgsqlPoint(x: 0.6200587203152005d, y: 0.04303124020311022d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08277337467526769d, y: 0.44893410615719076d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826001583049307d, y: 0.45805293880689524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7219981068615272d, y: 0.9202927263417127d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5348315261896055d, y: 0.2411996532870403d), new NpgsqlTypes.NpgsqlPoint(x: 0.09459202412590506d, y: 0.20495733451195808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5425811997855232d, y: 0.4884970363807044d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5360227566391532d, y: 0.3549376271988198d), new NpgsqlTypes.NpgsqlPoint(x: 0.4567794163627199d, y: 0.3441114987288255d), new NpgsqlTypes.NpgsqlPoint(x: 0.15349481978707025d, y: 0.43616747051422855d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006042250703600871d, y: 0.8984647160002204d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810138127446245d, y: 0.7299494597010304d), new NpgsqlTypes.NpgsqlPoint(x: 0.17032587897227214d, y: 0.6412858107608497d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16929168318120202d, y: 0.4402541137923599d), new NpgsqlTypes.NpgsqlPoint(x: 0.794098767107394d, y: 0.4355287194832992d), new NpgsqlTypes.NpgsqlPoint(x: 0.4024734611652514d, y: 0.046922476713021966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25430336903443473d, y: 0.21575793600882331d), new NpgsqlTypes.NpgsqlPoint(x: 0.0554141514503812d, y: 0.25092796180976396d), new NpgsqlTypes.NpgsqlPoint(x: 0.15455127264989765d, y: 0.7385054918937243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9692172507659076d, y: 0.1789615150397489d), new NpgsqlTypes.NpgsqlPoint(x: 0.8234335617930438d, y: 0.8961099991628201d), new NpgsqlTypes.NpgsqlPoint(x: 0.1883510013078582d, y: 0.6666678136165238d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3764712181408345d, y: 0.15838493816916788d), new NpgsqlTypes.NpgsqlPoint(x: 0.71421711886175d, y: 0.7298722980332336d), new NpgsqlTypes.NpgsqlPoint(x: 0.39029225250643107d, y: 0.6427163202047671d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6113301830501927d, y: 0.37895397820420074d), new NpgsqlTypes.NpgsqlPoint(x: 0.4536663733534174d, y: 0.4419602457292834d), new NpgsqlTypes.NpgsqlPoint(x: 0.21443529002133244d, y: 0.2162101145054589d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3902359647496858d, y: 0.605402184564701d), new NpgsqlTypes.NpgsqlPoint(x: 0.3432405210140995d, y: 0.43436962358354414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983353885872174d, y: 0.7767977560734755d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4814931357287874d, y: 0.9581107381981302d), new NpgsqlTypes.NpgsqlPoint(x: 0.22816587814353162d, y: 0.15552746927840755d), new NpgsqlTypes.NpgsqlPoint(x: 0.982953594942959d, y: 0.8304833308516586d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5449495113903805d, y: 0.42149469792227734d), new NpgsqlTypes.NpgsqlPoint(x: 0.18291913686580774d, y: 0.7685867810811196d), new NpgsqlTypes.NpgsqlPoint(x: 0.2740513819961562d, y: 0.9864108887827013d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7223998766907865d, y: 0.9813267968990281d), new NpgsqlTypes.NpgsqlPoint(x: 0.4607988250978483d, y: 0.1602257884924866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5344637100143373d, y: 0.4090217190136993d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19796046714339344d, y: 0.8266060150070582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570020671193009d, y: 0.5013375686018174d), new NpgsqlTypes.NpgsqlPoint(x: 0.12800959961333003d, y: 0.5805293001433033d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02786106419002987d, y: 0.030217772258636866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874609167476683d, y: 0.22059883114834145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6987543642712303d, y: 0.9902595370327801d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7774493741996088d, y: 0.4184031622704776d), new NpgsqlTypes.NpgsqlPoint(x: 0.415878854161321d, y: 0.8060306404046684d), new NpgsqlTypes.NpgsqlPoint(x: 0.1171286695304492d, y: 0.8171637584670189d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003054246985264464d, y: 0.7465664149336536d), new NpgsqlTypes.NpgsqlPoint(x: 0.1630210834943312d, y: 0.9299106180259906d), new NpgsqlTypes.NpgsqlPoint(x: 0.23170564534745175d, y: 0.3932004689128822d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2535011756247946d, y: 0.6026477118874352d), new NpgsqlTypes.NpgsqlPoint(x: 0.7623214268744876d, y: 0.22319245129934018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8159731783430529d, y: 0.2792283377398941d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3621229368677197d, y: 0.5872544383653137d), new NpgsqlTypes.NpgsqlPoint(x: 0.9775722211301962d, y: 0.20978745423376832d), new NpgsqlTypes.NpgsqlPoint(x: 0.486162580383106d, y: 0.4586746604184042d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45989086299734716d, y: 0.2291050868178679d), new NpgsqlTypes.NpgsqlPoint(x: 0.1983217693616558d, y: 0.8096544889012656d), new NpgsqlTypes.NpgsqlPoint(x: 0.42889046789398244d, y: 0.24038958414473144d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7503777612261516d, y: 0.9821604156388108d), new NpgsqlTypes.NpgsqlPoint(x: 0.3009973693764608d, y: 0.6683365207296896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9586778554040402d, y: 0.08549637443133018d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025744160354720713d, y: 0.7375995128293173d), new NpgsqlTypes.NpgsqlPoint(x: 0.29190135041114873d, y: 0.952181743290769d), new NpgsqlTypes.NpgsqlPoint(x: 0.10866219219116979d, y: 0.9753132030021298d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.183607688447196d, y: 0.02966365142499372d), new NpgsqlTypes.NpgsqlPoint(x: 0.3996147691304297d, y: 0.2896289156623696d), new NpgsqlTypes.NpgsqlPoint(x: 0.15827329765187004d, y: 0.14267496038928684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4390734158007882d, y: 0.666729607226852d), new NpgsqlTypes.NpgsqlPoint(x: 0.8338763744066725d, y: 0.5678756484055473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9242234961487229d, y: 0.5634136745271314d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4180965236359866d, y: 0.8637451661438231d), new NpgsqlTypes.NpgsqlPoint(x: 0.2663095842358333d, y: 0.3777282149159351d), new NpgsqlTypes.NpgsqlPoint(x: 0.9695722105358625d, y: 0.5323259142899704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1796831523995388d, y: 0.8542732141713538d), new NpgsqlTypes.NpgsqlPoint(x: 0.24733906583941023d, y: 0.09024023166801887d), new NpgsqlTypes.NpgsqlPoint(x: 0.24984426657654568d, y: 0.20841464828979572d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11658482057607322d, y: 0.48749237674736257d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131417621251511d, y: 0.7504895314778173d), new NpgsqlTypes.NpgsqlPoint(x: 0.43634318686424245d, y: 0.404643552376167d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39234077883331675d, y: 0.6048066001794954d), new NpgsqlTypes.NpgsqlPoint(x: 0.5600274172704904d, y: 0.8150483662642339d), new NpgsqlTypes.NpgsqlPoint(x: 0.17647577891404598d, y: 0.5250272258703096d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.83352952580479d, y: 0.48050405410397423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158688620188624d, y: 0.5843439595364014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080267815311861d, y: 0.008152053283419836d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19562441758823546d, y: 0.5549141937122146d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833459022157294d, y: 0.906379223722366d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263476501623695d, y: 0.3301921425899571d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44430174405226563d, y: 0.25172269580579965d), new NpgsqlTypes.NpgsqlPoint(x: 0.2998974393970538d, y: 0.3358765130893231d), new NpgsqlTypes.NpgsqlPoint(x: 0.8672220335866168d, y: 0.334758775578365d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017576150272941127d, y: 0.8204974519228309d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608543762586687d, y: 0.776249362488737d), new NpgsqlTypes.NpgsqlPoint(x: 0.4346656445038791d, y: 0.18396259100609136d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13849848787993246d, y: 0.9631110113050902d), new NpgsqlTypes.NpgsqlPoint(x: 0.2681802268315622d, y: 0.971375956952941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291249600658372d, y: 0.21090186527087396d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.693637336083852d, y: 0.4886725104800126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5117053375997996d, y: 0.2870495424074364d), new NpgsqlTypes.NpgsqlPoint(x: 0.07389522386903091d, y: 0.6698420940277782d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37590550458997896d, y: 0.5798967100930329d), new NpgsqlTypes.NpgsqlPoint(x: 0.003400319740111679d, y: 0.9531468352847776d), new NpgsqlTypes.NpgsqlPoint(x: 0.4988121090403701d, y: 0.3205142595330387d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21031944862978458d, y: 0.23241858874522148d), new NpgsqlTypes.NpgsqlPoint(x: 0.09386825824817124d, y: 0.9772577493197071d), new NpgsqlTypes.NpgsqlPoint(x: 0.7334984321649424d, y: 0.6108424836693607d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5053747667545675d, y: 0.3909846970648283d), new NpgsqlTypes.NpgsqlPoint(x: 0.17072874496829038d, y: 0.9858427551210133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9069683592015404d, y: 0.7733720463073266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8558760660338753d, y: 0.22001866901283107d), new NpgsqlTypes.NpgsqlPoint(x: 0.855921614515291d, y: 0.8923086084745452d), new NpgsqlTypes.NpgsqlPoint(x: 0.2925298594702648d, y: 0.5392612683440121d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3138475235781235d, y: 0.9499128464938098d), new NpgsqlTypes.NpgsqlPoint(x: 0.15294544948541766d, y: 0.40775798799726026d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005366374707933d, y: 0.7655571504507603d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4986202754465173d, y: 0.6691323541569402d), new NpgsqlTypes.NpgsqlPoint(x: 0.8957561310277591d, y: 0.4852999169927146d), new NpgsqlTypes.NpgsqlPoint(x: 0.9058415879076298d, y: 0.10784306907279939d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3504469906240658d, y: 0.10955841898450558d), new NpgsqlTypes.NpgsqlPoint(x: 0.825019008670446d, y: 0.6668061490571654d), new NpgsqlTypes.NpgsqlPoint(x: 0.09471870462605436d, y: 0.7760049596646887d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6526128838206146d, y: 0.5590825097887399d), new NpgsqlTypes.NpgsqlPoint(x: 0.6943442087083174d, y: 0.8176640827514449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926636339473845d, y: 0.7563456962458087d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18464758522609903d, y: 0.17136300256928072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202418277701786d, y: 0.44931099022171084d), new NpgsqlTypes.NpgsqlPoint(x: 0.4758355307020299d, y: 0.3175370264895713d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5489885044304269d, y: 0.18223697508650727d), new NpgsqlTypes.NpgsqlPoint(x: 0.48808762978249054d, y: 0.6866227650670608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5026935095593786d, y: 0.7525612681375723d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8235312022951398d, y: 0.4650676616128432d), new NpgsqlTypes.NpgsqlPoint(x: 0.12150253890114293d, y: 0.6156993640809796d), new NpgsqlTypes.NpgsqlPoint(x: 0.9600271850220954d, y: 0.5282814097388278d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6729900021499547d, y: 0.1393217850118854d), new NpgsqlTypes.NpgsqlPoint(x: 0.34586241264714335d, y: 0.40489766193833243d), new NpgsqlTypes.NpgsqlPoint(x: 0.11315397821565343d, y: 0.8507538794601199d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8509336430412798d, y: 0.9503325411981987d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942130427277609d, y: 0.43330404798463096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3045145253230118d, y: 0.022558263199834894d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04364511997927645d, y: 0.5046032838426892d), new NpgsqlTypes.NpgsqlPoint(x: 0.524927792346734d, y: 0.5493384705878667d), new NpgsqlTypes.NpgsqlPoint(x: 0.6622867136978061d, y: 0.6305709062511328d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9551597215385986d, y: 0.8820959382123673d), new NpgsqlTypes.NpgsqlPoint(x: 0.5948212267699208d, y: 0.5162131510733708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566540485667524d, y: 0.39595895720602226d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0036094634419507887d, y: 0.9144280349194351d), new NpgsqlTypes.NpgsqlPoint(x: 0.9197682069183254d, y: 0.6293083243991247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8339658949005685d, y: 0.06444251695899739d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43667534437483113d, y: 0.35798534178083974d), new NpgsqlTypes.NpgsqlPoint(x: 0.4547105800897284d, y: 0.5911645208847774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8359671085148696d, y: 0.47977255803231145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5651468028122433d, y: 0.2196933616920863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9523632804788942d, y: 0.9859015464262572d), new NpgsqlTypes.NpgsqlPoint(x: 0.9716748950565866d, y: 0.8648248723890565d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18262364887751914d, y: 0.7241762324956003d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967960640271654d, y: 0.147523492505661d), new NpgsqlTypes.NpgsqlPoint(x: 0.41925022579677196d, y: 0.061864818601695015d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3792763224463943d, y: 0.4147385628688469d), new NpgsqlTypes.NpgsqlPoint(x: 0.649806513131745d, y: 0.532112070278825d), new NpgsqlTypes.NpgsqlPoint(x: 0.8851727246547412d, y: 0.11716067047001144d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6822610856358221d, y: 0.552781729757339d), new NpgsqlTypes.NpgsqlPoint(x: 0.9061351556325178d, y: 0.9247749296760349d), new NpgsqlTypes.NpgsqlPoint(x: 0.4033845698396019d, y: 0.31701806813819255d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14955143827377393d, y: 0.18433993482246458d), new NpgsqlTypes.NpgsqlPoint(x: 0.7920505603587377d, y: 0.8508918265421253d), new NpgsqlTypes.NpgsqlPoint(x: 0.004416342659099404d, y: 0.8395404404648035d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32958141244399974d, y: 0.3196356701515872d), new NpgsqlTypes.NpgsqlPoint(x: 0.598586141002848d, y: 0.3494072593847056d), new NpgsqlTypes.NpgsqlPoint(x: 0.010306596999706596d, y: 0.16349149593451529d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5133571726010553d, y: 0.3380384623876206d), new NpgsqlTypes.NpgsqlPoint(x: 0.3847156625546434d, y: 0.5024866734504745d), new NpgsqlTypes.NpgsqlPoint(x: 0.8177931894129572d, y: 0.3871631009308518d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13937469430049754d, y: 0.8217736604268971d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480223308816366d, y: 0.7448464257029362d), new NpgsqlTypes.NpgsqlPoint(x: 0.10336283578323224d, y: 0.016594626743826724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7486816668327274d, y: 0.7086246763049325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6820799468950093d, y: 0.2003524341431655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5555401424118923d, y: 0.22031744854035074d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7667358404988736d, y: 0.3347402132517474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8263278666014524d, y: 0.40692199903350645d), new NpgsqlTypes.NpgsqlPoint(x: 0.1609677765581432d, y: 0.5179083951907126d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20895909900595389d, y: 0.5236333670853263d), new NpgsqlTypes.NpgsqlPoint(x: 0.2873690089547921d, y: 0.3790272169662189d), new NpgsqlTypes.NpgsqlPoint(x: 0.48772324654402033d, y: 0.672816561525633d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40570958429197934d, y: 0.8631467363310162d), new NpgsqlTypes.NpgsqlPoint(x: 0.2364657282199566d, y: 0.9335065999685759d), new NpgsqlTypes.NpgsqlPoint(x: 0.0917115965154156d, y: 0.08212587792548487d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046468353343476876d, y: 0.07510519307384622d), new NpgsqlTypes.NpgsqlPoint(x: 0.8270450359468781d, y: 0.4941506191624562d), new NpgsqlTypes.NpgsqlPoint(x: 0.13674612300754818d, y: 0.12134352049249542d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2668560981215147d, y: 0.6659966925431865d), new NpgsqlTypes.NpgsqlPoint(x: 0.39352795331746415d, y: 0.27788951131303974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5283330640303708d, y: 0.5182815840067682d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24544847514383916d, y: 0.8833578444671668d), new NpgsqlTypes.NpgsqlPoint(x: 0.13603814884717602d, y: 0.7181104450879974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8247265233536806d, y: 0.6454347265977216d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7604223138396041d, y: 0.4174042189400867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7712377829908299d, y: 0.3927654332432906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8088361492346261d, y: 0.8525668653543887d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11937320045231581d, y: 0.020105869715377866d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211600573925576d, y: 0.7475310592864078d), new NpgsqlTypes.NpgsqlPoint(x: 0.016898147509522232d, y: 0.6665484501893357d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8247731293718835d, y: 0.753022294832451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7384191441961705d, y: 0.022257665415677752d), new NpgsqlTypes.NpgsqlPoint(x: 0.6112711175118891d, y: 0.9247092293990127d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39782163963190786d, y: 0.29159839932830833d), new NpgsqlTypes.NpgsqlPoint(x: 0.31945951201667155d, y: 0.4246347358728615d), new NpgsqlTypes.NpgsqlPoint(x: 0.1593850965739495d, y: 0.9340024659218317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7407958508289121d, y: 0.05706714876034391d), new NpgsqlTypes.NpgsqlPoint(x: 0.22229619488490115d, y: 0.6982807368017964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4903089204265062d, y: 0.31942646296207244d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3616757599610342d, y: 0.16548108020818186d), new NpgsqlTypes.NpgsqlPoint(x: 0.004940636108412444d, y: 0.5859043655536159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9420584869333601d, y: 0.6627552184336672d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21947894487117503d, y: 0.949495147710264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6344576131708581d, y: 0.39156496601559354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9490664505546501d, y: 0.40634049400531547d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07950781547056363d, y: 0.08413626589226797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7597875121971079d, y: 0.980600116221672d), new NpgsqlTypes.NpgsqlPoint(x: 0.992475651200973d, y: 0.3489807346233651d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5201553674701728d, y: 0.35890682194040224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8078097027966686d, y: 0.8039278077091874d), new NpgsqlTypes.NpgsqlPoint(x: 0.5330514726289982d, y: 0.6786741636992045d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38603330664157554d, y: 0.4025655281459699d), new NpgsqlTypes.NpgsqlPoint(x: 0.84295399955085d, y: 0.037282429417766494d), new NpgsqlTypes.NpgsqlPoint(x: 0.14328081024050743d, y: 0.7004946657411137d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14056920729321165d, y: 0.8771700755221213d), new NpgsqlTypes.NpgsqlPoint(x: 0.6416433709901945d, y: 0.16693369603892338d), new NpgsqlTypes.NpgsqlPoint(x: 0.10056667670054398d, y: 0.6309313989225186d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29286224491914337d, y: 0.04985070014406956d), new NpgsqlTypes.NpgsqlPoint(x: 0.05255255850452023d, y: 0.9978030910779732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501774491261037d, y: 0.05051158837338332d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37062491448639434d, y: 0.6980084602867183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5462023822245916d, y: 0.22073528655235386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6448591669597381d, y: 0.36776863242124946d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29425874920671824d, y: 0.1517224766485008d), new NpgsqlTypes.NpgsqlPoint(x: 0.23052652672555785d, y: 0.47767946823419016d), new NpgsqlTypes.NpgsqlPoint(x: 0.040781552434022705d, y: 0.04351340882160415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5003605615108142d, y: 0.35518281621961534d), new NpgsqlTypes.NpgsqlPoint(x: 0.020051481202013055d, y: 0.5086642397252844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734609937799242d, y: 0.7791556908849944d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33114295941791627d, y: 0.4400624357455456d), new NpgsqlTypes.NpgsqlPoint(x: 0.4686865985863211d, y: 0.0690622171870765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5004264810676945d, y: 0.45045769681882175d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03548906172354538d, y: 0.05075504722773516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8731196658741625d, y: 0.6039897545377382d), new NpgsqlTypes.NpgsqlPoint(x: 0.014859008097202753d, y: 0.2860935402374899d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6495389963456888d, y: 0.34813757298004344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869739523382311d, y: 0.6802739064183843d), new NpgsqlTypes.NpgsqlPoint(x: 0.05209096883846276d, y: 0.7845700224531604d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10297717908380599d, y: 0.4037258697641354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9332369469173275d, y: 0.36065702380533815d), new NpgsqlTypes.NpgsqlPoint(x: 0.7823132365065095d, y: 0.8827169626749208d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3141321422865212d, y: 0.7353445137407905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3154366658815738d, y: 0.9946880022135773d), new NpgsqlTypes.NpgsqlPoint(x: 0.26764156900435043d, y: 0.12388094485552581d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18759741379404682d, y: 0.21450362174161952d), new NpgsqlTypes.NpgsqlPoint(x: 0.590948478496606d, y: 0.7431102306374167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177321639166526d, y: 0.4388818566785643d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13705149003541572d, y: 0.0334207577068798d), new NpgsqlTypes.NpgsqlPoint(x: 0.6601252524167882d, y: 0.41739749649106417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8964351631890864d, y: 0.4188997444845586d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.836779982057693d, y: 0.9574511056209337d), new NpgsqlTypes.NpgsqlPoint(x: 0.026678420579674178d, y: 0.5822172854583073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971314044970468d, y: 0.7134661083299783d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42040111670244784d, y: 0.5860867331651061d), new NpgsqlTypes.NpgsqlPoint(x: 0.28128473699841905d, y: 0.8271738193254117d), new NpgsqlTypes.NpgsqlPoint(x: 0.04238879610653268d, y: 0.7923285562605716d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4317752402047429d, y: 0.8801028077742059d), new NpgsqlTypes.NpgsqlPoint(x: 0.48075266141454764d, y: 0.1863096527236794d), new NpgsqlTypes.NpgsqlPoint(x: 0.6007808642114081d, y: 0.9701919026905884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6515325976149211d, y: 0.2436388543492679d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567150335242511d, y: 0.014853904655606875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9003968672728688d, y: 0.8678696832365166d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6517628007636136d, y: 0.1898939791245694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636987422952345d, y: 0.9862658258292104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6697790922504374d, y: 0.8753027097428598d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6236486818302258d, y: 0.20835250817920103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7377272024418592d, y: 0.24485632762384946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8496080745384628d, y: 0.9051129375494577d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4311199395080094d, y: 0.11205327159897827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7037190673425234d, y: 0.4311909819794639d), new NpgsqlTypes.NpgsqlPoint(x: 0.2818856080750868d, y: 0.5489557723989773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01884713110665559d, y: 0.08461235102287235d), new NpgsqlTypes.NpgsqlPoint(x: 0.828566321463007d, y: 0.11494605146820946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8783011704890267d, y: 0.5628868768162637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05771315602809668d, y: 0.8411724195744726d), new NpgsqlTypes.NpgsqlPoint(x: 0.49466512889541514d, y: 0.0326530921436774d), new NpgsqlTypes.NpgsqlPoint(x: 0.07688339842746361d, y: 0.3013806381514834d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6691041198830147d, y: 0.999581303433514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331369205768526d, y: 0.5329994606705359d), new NpgsqlTypes.NpgsqlPoint(x: 0.48228306538800947d, y: 0.8633111996181306d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8889859646369395d, y: 0.8007901414074129d), new NpgsqlTypes.NpgsqlPoint(x: 0.08024512865285682d, y: 0.7889212815368772d), new NpgsqlTypes.NpgsqlPoint(x: 0.21067701346010892d, y: 0.16636644073183648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8429535129342607d, y: 0.528699273238761d), new NpgsqlTypes.NpgsqlPoint(x: 0.9872022718437198d, y: 0.5370936619875756d), new NpgsqlTypes.NpgsqlPoint(x: 0.06800155607938563d, y: 0.747467885876531d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24990202732892774d, y: 0.38036082838527063d), new NpgsqlTypes.NpgsqlPoint(x: 0.031246683000860975d, y: 0.8043862154116377d), new NpgsqlTypes.NpgsqlPoint(x: 0.429473710959866d, y: 0.547938836511469d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4192631526370493d, y: 0.665668056476865d), new NpgsqlTypes.NpgsqlPoint(x: 0.4434588381103538d, y: 0.9108649316481092d), new NpgsqlTypes.NpgsqlPoint(x: 0.4073267648429253d, y: 0.1044711980901416d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49131705928006797d, y: 0.29934196397382684d), new NpgsqlTypes.NpgsqlPoint(x: 0.4719059478509806d, y: 0.5475765996528358d), new NpgsqlTypes.NpgsqlPoint(x: 0.25921853474988255d, y: 0.4209366999119579d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5107756567401283d, y: 0.6746338104906231d), new NpgsqlTypes.NpgsqlPoint(x: 0.19687834083134348d, y: 0.884026879247852d), new NpgsqlTypes.NpgsqlPoint(x: 0.326082840656698d, y: 0.4631325167315906d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19099752299415773d, y: 0.6361718436818948d), new NpgsqlTypes.NpgsqlPoint(x: 0.20149672079655068d, y: 0.16626245415799568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420219376012919d, y: 0.6565529100766433d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37408775185604215d, y: 0.8995470922625064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8685806288254826d, y: 0.6397883658098839d), new NpgsqlTypes.NpgsqlPoint(x: 0.12616199147082796d, y: 0.7703635969070588d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4174831609673352d, y: 0.25864994885145376d), new NpgsqlTypes.NpgsqlPoint(x: 0.04819298927826754d, y: 0.8583829780319097d), new NpgsqlTypes.NpgsqlPoint(x: 0.09359024437513641d, y: 0.8461702557142164d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5079819368249691d, y: 0.7262957307849666d), new NpgsqlTypes.NpgsqlPoint(x: 0.2041895929932176d, y: 0.9975791739100287d), new NpgsqlTypes.NpgsqlPoint(x: 0.04065941430069997d, y: 0.02296856894971333d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6051062702381802d, y: 0.43416372176548446d), new NpgsqlTypes.NpgsqlPoint(x: 0.2660814907152256d, y: 0.8847426281117102d), new NpgsqlTypes.NpgsqlPoint(x: 0.5947905540288725d, y: 0.7638620260243355d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2884421573517433d, y: 0.2822059885447946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006872310928218d, y: 0.06256829166766786d), new NpgsqlTypes.NpgsqlPoint(x: 0.422282268129509d, y: 0.5782487843126585d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24107594622422202d, y: 0.6092537392666424d), new NpgsqlTypes.NpgsqlPoint(x: 0.3524659171949265d, y: 0.7301080801382143d), new NpgsqlTypes.NpgsqlPoint(x: 0.09339747348257277d, y: 0.5140527378671754d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21346069677357837d, y: 0.3264862534474391d), new NpgsqlTypes.NpgsqlPoint(x: 0.11088219440030933d, y: 0.25572073707360954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9513690885093308d, y: 0.48972428699845116d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5814136600546839d, y: 0.2424028184976561d), new NpgsqlTypes.NpgsqlPoint(x: 0.618471924249298d, y: 0.19019898259628598d), new NpgsqlTypes.NpgsqlPoint(x: 0.32576135946059326d, y: 0.15923552559793208d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5777805543822706d, y: 0.7954339044616785d), new NpgsqlTypes.NpgsqlPoint(x: 0.27010349874205497d, y: 0.6848099054353465d), new NpgsqlTypes.NpgsqlPoint(x: 0.726900942052269d, y: 0.5790228832554706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6716360409488272d, y: 0.7572101760628648d), new NpgsqlTypes.NpgsqlPoint(x: 0.13372704904933275d, y: 0.7674023449240304d), new NpgsqlTypes.NpgsqlPoint(x: 0.1742794105695934d, y: 0.18618435896470586d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0075073866759699515d, y: 0.21734941781451977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8579211457971732d, y: 0.47382867962301367d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821500136441116d, y: 0.09833641425579986d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1808064643184245d, y: 0.3020985511092067d), new NpgsqlTypes.NpgsqlPoint(x: 0.5316872837773796d, y: 0.20572624949384755d), new NpgsqlTypes.NpgsqlPoint(x: 0.5718613763528214d, y: 0.18095548496417957d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3222745067859679d, y: 0.42528342631189775d), new NpgsqlTypes.NpgsqlPoint(x: 0.720325910051549d, y: 0.8097487994391992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6314257146606455d, y: 0.342924116750415d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7298436883119381d, y: 0.9808281167662172d), new NpgsqlTypes.NpgsqlPoint(x: 0.237301473901105d, y: 0.4908523406612374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6713567391719784d, y: 0.68239532545788d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.042222271230361486d, y: 0.5710973162286048d), new NpgsqlTypes.NpgsqlPoint(x: 0.935999247689507d, y: 0.7719715812008486d), new NpgsqlTypes.NpgsqlPoint(x: 0.1976242285516372d, y: 0.08593028170588646d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8886405754468819d, y: 0.01401195591982951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752836992874797d, y: 0.9420529164304249d), new NpgsqlTypes.NpgsqlPoint(x: 0.016959674430945815d, y: 0.5478694739374446d)),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 187;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 187;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 187;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 187;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 17, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 58, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 70, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 36, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 119, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 187, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 181, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 36, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 42, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI), typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                await ((INpgsqlPathListpathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                ((INpgsqlPathListpathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

