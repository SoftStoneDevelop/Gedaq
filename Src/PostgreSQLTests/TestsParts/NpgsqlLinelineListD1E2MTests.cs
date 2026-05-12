

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
    internal partial interface INpgsqlLineListlineListD1
    {
    }
    
    internal partial class NpgsqlLineListlineListD1 : INpgsqlLineListlineListD1
    {


#region TestData

        private readonly NpgsqlLinelineListD1E2M[] _testData = new NpgsqlLinelineListD1E2M[]
        {
            new NpgsqlLinelineListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17641612722012734d, b: 0.9788255954079602d, c: 0.8101467792414456d),

new NpgsqlTypes.NpgsqlLine(a: 0.04550633730990128d, b: 0.016140065228152256d, c: 0.6855903517915479d),

new NpgsqlTypes.NpgsqlLine(a: 0.8498966335780692d, b: 0.9506921754826139d, c: 0.3343745533137219d),

new NpgsqlTypes.NpgsqlLine(a: 0.6534998769065795d, b: 0.9599982170318646d, c: 0.5749047848652769d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11372158044548941d, b: 0.6633990714090265d, c: 0.3695178126611123d),

new NpgsqlTypes.NpgsqlLine(a: 0.8821597967554136d, b: 0.5106981315069813d, c: 0.5112678780395905d),

new NpgsqlTypes.NpgsqlLine(a: 0.21862775109044108d, b: 0.29833616309868005d, c: 0.6476058501334304d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08538434630675684d, b: 0.15664312832781158d, c: 0.8275548022846372d),

new NpgsqlTypes.NpgsqlLine(a: 0.8040408731990943d, b: 0.4147088517990506d, c: 0.4798686085066345d),

new NpgsqlTypes.NpgsqlLine(a: 0.4323120529982136d, b: 0.8503625991198531d, c: 0.17040287293943246d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9481463109791962d, b: 0.25195935344293774d, c: 0.10679534041801297d),

new NpgsqlTypes.NpgsqlLine(a: 0.6150107043358258d, b: 0.6434934732073796d, c: 0.7291041397083554d),

new NpgsqlTypes.NpgsqlLine(a: 0.9025364552501539d, b: 0.9345112661924031d, c: 0.47800269005709417d),

new NpgsqlTypes.NpgsqlLine(a: 0.056064488607905916d, b: 0.8062940886440689d, c: 0.9670599708860017d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2795961300861951d, b: 0.10081036265013266d, c: 0.22491997462797486d),

new NpgsqlTypes.NpgsqlLine(a: 0.35828384050551176d, b: 0.9849640433283766d, c: 0.9122024679639948d),

new NpgsqlTypes.NpgsqlLine(a: 0.9195687234170331d, b: 0.6913395509412539d, c: 0.05984702438480616d),

new NpgsqlTypes.NpgsqlLine(a: 0.7628566714098002d, b: 0.740699978657709d, c: 0.3711949605346161d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08651397059626986d, b: 0.6512406042524206d, c: 0.659870427324295d),

new NpgsqlTypes.NpgsqlLine(a: 0.9214843518436346d, b: 0.39032808626621973d, c: 0.23177508756398335d),

new NpgsqlTypes.NpgsqlLine(a: 0.5459616452821576d, b: 0.26186509087887566d, c: 0.06363176859873254d),

new NpgsqlTypes.NpgsqlLine(a: 0.08869825443741752d, b: 0.8790315038055516d, c: 0.3790401505197053d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6976162819635803d, b: 0.5978362004856994d, c: 0.7189393318954496d),

new NpgsqlTypes.NpgsqlLine(a: 0.10376031057275081d, b: 0.3548083167081132d, c: 0.44740060274340465d),

new NpgsqlTypes.NpgsqlLine(a: 0.11141619588136498d, b: 0.6857611099118858d, c: 0.2605133675646063d),

new NpgsqlTypes.NpgsqlLine(a: 0.6541015739261645d, b: 0.6667630393976905d, c: 0.3995692128218864d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9471532398053611d, b: 0.15780781970774493d, c: 0.719263055409393d),

new NpgsqlTypes.NpgsqlLine(a: 0.8735084362059425d, b: 0.3855615176419904d, c: 0.7812662791500767d),

new NpgsqlTypes.NpgsqlLine(a: 0.6556825770297052d, b: 0.721451027283901d, c: 0.994273434884808d),

new NpgsqlTypes.NpgsqlLine(a: 0.17811069240294664d, b: 0.04441378459335599d, c: 0.6047164314658056d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10587732856293686d, b: 0.7787557024982484d, c: 0.26944782089658537d),

new NpgsqlTypes.NpgsqlLine(a: 0.5807612147275037d, b: 0.7960623423531679d, c: 0.4726276161272298d),

new NpgsqlTypes.NpgsqlLine(a: 0.5354991842762878d, b: 0.7963405290152556d, c: 0.3669358717211373d),

new NpgsqlTypes.NpgsqlLine(a: 0.33876018301213895d, b: 0.9003662546766027d, c: 0.846964162701221d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8589366542516557d, b: 0.800867583810626d, c: 0.16175558345159835d),

new NpgsqlTypes.NpgsqlLine(a: 0.2671944333452313d, b: 0.23165168500671285d, c: 0.23149843343468235d),

new NpgsqlTypes.NpgsqlLine(a: 0.6782637323179537d, b: 0.889240104895274d, c: 0.7222076983205404d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.111704102814977d, b: 0.6794289589951177d, c: 0.36080474686899744d),

new NpgsqlTypes.NpgsqlLine(a: 0.13915573551530014d, b: 0.4151386986006276d, c: 0.05022988716280907d),

new NpgsqlTypes.NpgsqlLine(a: 0.7322033372945937d, b: 0.28267548343900173d, c: 0.32647093723234855d),

new NpgsqlTypes.NpgsqlLine(a: 0.7832263694526964d, b: 0.3747045895424518d, c: 0.7361837743774484d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06645688481042455d, b: 0.7540761407894004d, c: 0.03266260578330504d),

new NpgsqlTypes.NpgsqlLine(a: 0.44790109724957017d, b: 0.556564667930417d, c: 0.6330167985470956d),

new NpgsqlTypes.NpgsqlLine(a: 0.5881138498368084d, b: 0.2495957420108207d, c: 0.8771677765475162d),

new NpgsqlTypes.NpgsqlLine(a: 0.7120017759198779d, b: 0.7519485688699887d, c: 0.6810255631400035d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2622573072736675d, b: 0.9307171723153629d, c: 0.5405406998581911d),

new NpgsqlTypes.NpgsqlLine(a: 0.8397868623105851d, b: 0.614756380445815d, c: 0.5279684397704063d),

new NpgsqlTypes.NpgsqlLine(a: 0.0844479367592138d, b: 0.4044571075080997d, c: 0.10892672923900315d),

new NpgsqlTypes.NpgsqlLine(a: 0.901342681077307d, b: 0.9375719685351396d, c: 0.5426642112422928d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08308835378930524d, b: 0.645080481991395d, c: 0.011633529468105142d),

new NpgsqlTypes.NpgsqlLine(a: 0.5562485636290971d, b: 0.44376174918915845d, c: 0.790296443068642d),

new NpgsqlTypes.NpgsqlLine(a: 0.824612242999554d, b: 0.22929639388843404d, c: 0.5736490680524542d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7202919736300838d, b: 0.7879180335940323d, c: 0.22152266344718352d),

new NpgsqlTypes.NpgsqlLine(a: 0.7906105458090377d, b: 0.019542512223075792d, c: 0.42670422044791656d),

new NpgsqlTypes.NpgsqlLine(a: 0.9683395359792962d, b: 0.7464030202603232d, c: 0.9521509736740025d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10126727425193394d, b: 0.2527003626909796d, c: 0.7531149617149602d),

new NpgsqlTypes.NpgsqlLine(a: 0.8984644134265716d, b: 0.012924768360869976d, c: 0.6577575819141143d),

new NpgsqlTypes.NpgsqlLine(a: 0.14440277628134157d, b: 0.3550622409388191d, c: 0.3643131300297835d),

new NpgsqlTypes.NpgsqlLine(a: 0.5887833623497243d, b: 0.8249414591126123d, c: 0.1322544478296258d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39979775227399805d, b: 0.6401247203876883d, c: 0.04965903977875841d),

new NpgsqlTypes.NpgsqlLine(a: 0.6334199679576107d, b: 0.035604934337701954d, c: 0.3662804258066633d),

new NpgsqlTypes.NpgsqlLine(a: 0.4642182291877113d, b: 0.30835506692050085d, c: 0.5612388287212479d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09544860588859438d, b: 0.23685964065374188d, c: 0.609407740801826d),

new NpgsqlTypes.NpgsqlLine(a: 0.3416879985086224d, b: 0.7525603110380439d, c: 0.6161090218061386d),

new NpgsqlTypes.NpgsqlLine(a: 0.5871645304896587d, b: 0.04836578937058611d, c: 0.830205627457751d),

new NpgsqlTypes.NpgsqlLine(a: 0.6268432253262971d, b: 0.2437856089211552d, c: 0.9351437589028847d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26512606646828496d, b: 0.8182517350245857d, c: 0.45064507727519154d),

new NpgsqlTypes.NpgsqlLine(a: 0.730294439155789d, b: 0.031518058810201977d, c: 0.2259952423286654d),

new NpgsqlTypes.NpgsqlLine(a: 0.3633522614347482d, b: 0.8276752689424208d, c: 0.045037122701119925d),

new NpgsqlTypes.NpgsqlLine(a: 0.6890103529198583d, b: 0.2878900329716165d, c: 0.9694200746254877d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5321318454695595d, b: 0.9208779998139831d, c: 0.617405804977717d),

new NpgsqlTypes.NpgsqlLine(a: 0.3007743520773458d, b: 0.9525194945895119d, c: 0.6653297497003026d),

new NpgsqlTypes.NpgsqlLine(a: 0.7155172842107687d, b: 0.9057263715231276d, c: 0.3313113699039142d),

new NpgsqlTypes.NpgsqlLine(a: 0.628313658244736d, b: 0.3817923952296609d, c: 0.968753894497465d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10412786750707381d, b: 0.6058718065084124d, c: 0.6206512781656137d),

new NpgsqlTypes.NpgsqlLine(a: 0.436167583501633d, b: 0.2574156920377957d, c: 0.8050651086512176d),

new NpgsqlTypes.NpgsqlLine(a: 0.5441220103559838d, b: 0.1358795622225003d, c: 0.7904862371641459d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31766569769263864d, b: 0.7052391005732968d, c: 0.9403622085836694d),

new NpgsqlTypes.NpgsqlLine(a: 0.6824673416302849d, b: 0.9164496367316757d, c: 0.04478298804547287d),

new NpgsqlTypes.NpgsqlLine(a: 0.3871270239888812d, b: 0.8432483462213375d, c: 0.9410200766878913d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20051653840485795d, b: 0.047168504230028385d, c: 0.6958343460240808d),

new NpgsqlTypes.NpgsqlLine(a: 0.9779282149400705d, b: 0.9043541212503718d, c: 0.422962900710389d),

new NpgsqlTypes.NpgsqlLine(a: 0.42615258629606334d, b: 0.5746168013142178d, c: 0.8591222877142652d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47052230840766784d, b: 0.28878952482398046d, c: 0.5067517272717087d),

new NpgsqlTypes.NpgsqlLine(a: 0.8012261970149693d, b: 0.04218403474563981d, c: 0.74864707623213d),

new NpgsqlTypes.NpgsqlLine(a: 0.5718983976051752d, b: 0.8031028883704967d, c: 0.7436650670791599d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5062153926212748d, b: 0.16557294305774073d, c: 0.906369563626621d),

new NpgsqlTypes.NpgsqlLine(a: 0.6707946849731046d, b: 0.08439399224260935d, c: 0.7710303983410851d),

new NpgsqlTypes.NpgsqlLine(a: 0.07333897684728896d, b: 0.7891593248397425d, c: 0.3502053134437759d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4983246562457908d, b: 0.14895062741464116d, c: 0.043095687663733284d),

new NpgsqlTypes.NpgsqlLine(a: 0.3317045157139745d, b: 0.24382555059269362d, c: 0.7547291557088749d),

new NpgsqlTypes.NpgsqlLine(a: 0.5706853370845612d, b: 0.9417546680101087d, c: 0.8087702039882306d),

new NpgsqlTypes.NpgsqlLine(a: 0.14386418631665654d, b: 0.34802026940366615d, c: 0.5339587054634821d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23136390496530945d, b: 0.23091934101298361d, c: 0.13331303819837959d),

new NpgsqlTypes.NpgsqlLine(a: 0.2206695023583981d, b: 0.5436892345324007d, c: 0.6895276840633621d),

new NpgsqlTypes.NpgsqlLine(a: 0.07401982400118712d, b: 0.7979293613105407d, c: 0.4291751469926177d),

new NpgsqlTypes.NpgsqlLine(a: 0.782771820867637d, b: 0.7582324194474572d, c: 0.9848333340141974d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36866264603733123d, b: 0.2723181591178422d, c: 0.23502989720469258d),

new NpgsqlTypes.NpgsqlLine(a: 0.3882116158396307d, b: 0.18237947315319913d, c: 0.37417579080186014d),

new NpgsqlTypes.NpgsqlLine(a: 0.8004734482840588d, b: 0.10233699253868545d, c: 0.19916284863081068d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7880472589975539d, b: 0.8759165955344272d, c: 0.39717364955916135d),

new NpgsqlTypes.NpgsqlLine(a: 0.9022948286239822d, b: 0.8989885176464038d, c: 0.7914429323885614d),

new NpgsqlTypes.NpgsqlLine(a: 0.03934056992015256d, b: 0.6054582666254135d, c: 0.027954742047452297d),

new NpgsqlTypes.NpgsqlLine(a: 0.35829001930691895d, b: 0.5669464403955736d, c: 0.8870533035518959d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9519914524125822d, b: 0.9983564842091317d, c: 0.17440563448280733d),

new NpgsqlTypes.NpgsqlLine(a: 0.08881265619391898d, b: 0.8376519967633157d, c: 0.488849327259398d),

new NpgsqlTypes.NpgsqlLine(a: 0.6612538683644691d, b: 0.7021535387465812d, c: 0.8217542210509505d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7236418436096409d, b: 0.27010162996151366d, c: 0.27705411467336094d),

new NpgsqlTypes.NpgsqlLine(a: 0.46541589023758023d, b: 0.7824704356919483d, c: 0.056782773967298805d),

new NpgsqlTypes.NpgsqlLine(a: 0.056709219671146616d, b: 0.31698876259736575d, c: 0.9709948745148321d),

new NpgsqlTypes.NpgsqlLine(a: 0.04754264708920075d, b: 0.6844570474256819d, c: 0.7238018803894257d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.633492942203993d, b: 0.6112744270462511d, c: 0.534975970840203d),

new NpgsqlTypes.NpgsqlLine(a: 0.40174450167853915d, b: 0.9613184861781657d, c: 0.4846960896354874d),

new NpgsqlTypes.NpgsqlLine(a: 0.34595378342247984d, b: 0.7777943199968061d, c: 0.4854486896275334d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5193608037867691d, b: 0.4799150538316074d, c: 0.9059068849802234d),

new NpgsqlTypes.NpgsqlLine(a: 0.4056839759090637d, b: 0.8195915440983417d, c: 0.7857365482998506d),

new NpgsqlTypes.NpgsqlLine(a: 0.36406030213093665d, b: 0.21051550085018644d, c: 0.11993222537678627d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7280223064277777d, b: 0.3566242346467561d, c: 0.7768862270490193d),

new NpgsqlTypes.NpgsqlLine(a: 0.06726690900711685d, b: 0.3981952796300512d, c: 0.47417448783142735d),

new NpgsqlTypes.NpgsqlLine(a: 0.7499271875289923d, b: 0.2091997949105815d, c: 0.6927312637045058d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8271617460940652d, b: 0.8376865512536169d, c: 0.8036889850987843d),

new NpgsqlTypes.NpgsqlLine(a: 0.6738569808783157d, b: 0.9168481636885628d, c: 0.730923607626651d),

new NpgsqlTypes.NpgsqlLine(a: 0.19653848270760543d, b: 0.1682187942778106d, c: 0.18067129482083077d),

new NpgsqlTypes.NpgsqlLine(a: 0.35656782892318317d, b: 0.7135599476388451d, c: 0.1901761488825353d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8376472437217533d, b: 0.4192482751111144d, c: 0.14636072393748756d),

new NpgsqlTypes.NpgsqlLine(a: 0.7518217382723312d, b: 0.37916439313857253d, c: 0.8252575705714263d),

new NpgsqlTypes.NpgsqlLine(a: 0.059936401770685044d, b: 0.7973461784199559d, c: 0.5228272141866279d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4739802249645223d, b: 0.5405786348121258d, c: 0.7957572075744458d),

new NpgsqlTypes.NpgsqlLine(a: 0.40449666108032023d, b: 0.27659704491135495d, c: 0.9283979136950408d),

new NpgsqlTypes.NpgsqlLine(a: 0.13550548950258123d, b: 0.5673032898346535d, c: 0.30399900218614984d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8303503196507975d, b: 0.7777520166379899d, c: 0.799755622064351d),

new NpgsqlTypes.NpgsqlLine(a: 0.8351637138901583d, b: 0.8630701968278823d, c: 0.6820160843349219d),

new NpgsqlTypes.NpgsqlLine(a: 0.47205561699359666d, b: 0.2893512983606331d, c: 0.5108828049584726d),

new NpgsqlTypes.NpgsqlLine(a: 0.7314508021344485d, b: 0.7742081293592379d, c: 0.15540215287914272d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27459875554924373d, b: 0.33048388743843204d, c: 0.37136995591430755d),

new NpgsqlTypes.NpgsqlLine(a: 0.7835414374069201d, b: 0.26130191208464393d, c: 0.42192833360973303d),

new NpgsqlTypes.NpgsqlLine(a: 0.047088888394277606d, b: 0.02795340202085339d, c: 0.18627074164327595d),

new NpgsqlTypes.NpgsqlLine(a: 0.028978105795442466d, b: 0.9480319473539517d, c: 0.504321244985214d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6783017838940156d, b: 0.9367163285798563d, c: 0.4171556252168249d),

new NpgsqlTypes.NpgsqlLine(a: 0.4107021906124273d, b: 0.12682947845319115d, c: 0.17202128691860308d),

new NpgsqlTypes.NpgsqlLine(a: 0.6409389592504479d, b: 0.006789959868890416d, c: 0.11492094980880552d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21183024694039898d, b: 0.7316782078511942d, c: 0.7888900017693219d),

new NpgsqlTypes.NpgsqlLine(a: 0.8656542165029132d, b: 0.4435871902772255d, c: 0.02082206530688968d),

new NpgsqlTypes.NpgsqlLine(a: 0.041064766632728955d, b: 0.5536456456051103d, c: 0.014408320470337355d),

new NpgsqlTypes.NpgsqlLine(a: 0.4358414019487925d, b: 0.3691345689160801d, c: 0.33488755916422686d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.59486356718952d, b: 0.19884989936340425d, c: 0.012218318921352611d),

new NpgsqlTypes.NpgsqlLine(a: 0.8222214847400792d, b: 0.06402219127030828d, c: 0.12198757531213478d),

new NpgsqlTypes.NpgsqlLine(a: 0.24979133454502156d, b: 0.9610634121172508d, c: 0.31391478975033205d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9036925509439182d, b: 0.6911070859372711d, c: 0.524888887377975d),

new NpgsqlTypes.NpgsqlLine(a: 0.0775383901129344d, b: 0.4834994314381279d, c: 0.20657406044610271d),

new NpgsqlTypes.NpgsqlLine(a: 0.24181404172513887d, b: 0.1740325309202324d, c: 0.5175942655007679d),

new NpgsqlTypes.NpgsqlLine(a: 0.7961506766267327d, b: 0.7970309145721307d, c: 0.6100727397668643d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4691562368526184d, b: 0.8244819230738079d, c: 0.2330274574660255d),

new NpgsqlTypes.NpgsqlLine(a: 0.45693391592581467d, b: 0.40283535301766993d, c: 0.010620851541953136d),

new NpgsqlTypes.NpgsqlLine(a: 0.7659116665631165d, b: 0.5008166982472971d, c: 0.6048608257021282d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7107638633679613d, b: 0.5516217846436182d, c: 0.1860696134562413d),

new NpgsqlTypes.NpgsqlLine(a: 0.4849286845366626d, b: 0.5028344263907651d, c: 0.725682520296238d),

new NpgsqlTypes.NpgsqlLine(a: 0.9521557893156605d, b: 0.13096307661748674d, c: 0.7468349241416767d),

new NpgsqlTypes.NpgsqlLine(a: 0.06216668800121028d, b: 0.6015575087099103d, c: 0.28450681713047643d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9358520597538432d, b: 0.08999373964306856d, c: 0.46390711012152963d),

new NpgsqlTypes.NpgsqlLine(a: 0.5058895275410769d, b: 0.8957641633742706d, c: 0.3353807479940377d),

new NpgsqlTypes.NpgsqlLine(a: 0.41782180830596183d, b: 0.1443118238207537d, c: 0.8020711265827335d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8179461193023746d, b: 0.539672209506655d, c: 0.7840525787075376d),

new NpgsqlTypes.NpgsqlLine(a: 0.5136226899391426d, b: 0.7863825252313638d, c: 0.4831904261817578d),

new NpgsqlTypes.NpgsqlLine(a: 0.3877970063782413d, b: 0.5410614282475278d, c: 0.38167859437751084d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5271875466127667d, b: 0.5811822996669259d, c: 0.45483100886359995d),

new NpgsqlTypes.NpgsqlLine(a: 0.7523486391256506d, b: 0.3373951416228833d, c: 0.04787014479004559d),

new NpgsqlTypes.NpgsqlLine(a: 0.9812737133078568d, b: 0.4220734833135016d, c: 0.6789152271603358d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21401016650841065d, b: 0.33197489685991377d, c: 0.4292971653329831d),

new NpgsqlTypes.NpgsqlLine(a: 0.09674468658814728d, b: 0.22360865693137377d, c: 0.8342928916261418d),

new NpgsqlTypes.NpgsqlLine(a: 0.4154443156087504d, b: 0.35582157187287455d, c: 0.7438481970053806d),

new NpgsqlTypes.NpgsqlLine(a: 0.3581797603596655d, b: 0.5750699877824254d, c: 0.26549947151244924d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.027799004678982997d, b: 0.5821604720381466d, c: 0.35166322500271885d),

new NpgsqlTypes.NpgsqlLine(a: 0.7101816366501547d, b: 0.4520634369556559d, c: 0.9649343138111492d),

new NpgsqlTypes.NpgsqlLine(a: 0.4496166249003032d, b: 0.8018033028805515d, c: 0.7895967472041724d),

new NpgsqlTypes.NpgsqlLine(a: 0.369402428241306d, b: 0.7361370689063707d, c: 0.07051476072201823d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3969349384377071d, b: 0.36552197418958143d, c: 0.45000539066941936d),

new NpgsqlTypes.NpgsqlLine(a: 0.8878168858512969d, b: 0.9918085833252308d, c: 0.1394980167881702d),

new NpgsqlTypes.NpgsqlLine(a: 0.8931592393783353d, b: 0.4594431212335002d, c: 0.1131760982610075d),

new NpgsqlTypes.NpgsqlLine(a: 0.1249149623320398d, b: 0.15990228065736234d, c: 0.983608203230106d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13782903292718307d, b: 0.4794079490401374d, c: 0.12551003806600292d),

new NpgsqlTypes.NpgsqlLine(a: 0.6506286321035839d, b: 0.4072502292777844d, c: 0.32438797265944397d),

new NpgsqlTypes.NpgsqlLine(a: 0.6506594912387592d, b: 0.4694975604010554d, c: 0.34561980956772353d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4134904071908032d, b: 0.401185714436302d, c: 0.0667407274783397d),

new NpgsqlTypes.NpgsqlLine(a: 0.909804910086343d, b: 0.041911644684368254d, c: 0.985047300270741d),

new NpgsqlTypes.NpgsqlLine(a: 0.2806040830858896d, b: 0.7869571582953615d, c: 0.4758910988091891d),

new NpgsqlTypes.NpgsqlLine(a: 0.34872031738268006d, b: 0.16196431570057368d, c: 0.8824002604324207d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8404958754762211d, b: 0.09268769199482374d, c: 0.5776186117841124d),

new NpgsqlTypes.NpgsqlLine(a: 0.13232154909572358d, b: 0.06962610225109334d, c: 0.02147279204791419d),

new NpgsqlTypes.NpgsqlLine(a: 0.7153601687562201d, b: 0.7469925709277602d, c: 0.0292533504379191d),

new NpgsqlTypes.NpgsqlLine(a: 0.5433009796834743d, b: 0.21853906538651868d, c: 0.7897060868241869d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.046543351022260926d, b: 0.6559397829405971d, c: 0.38508037567925324d),

new NpgsqlTypes.NpgsqlLine(a: 0.5027258788477623d, b: 0.6704152597993147d, c: 0.21275727285644297d),

new NpgsqlTypes.NpgsqlLine(a: 0.5361580008999488d, b: 0.4592669781123796d, c: 0.035306243058274456d),

new NpgsqlTypes.NpgsqlLine(a: 0.9993582191233998d, b: 0.43573023590880067d, c: 0.4549020341395572d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.49569119825548236d, b: 0.8181447156691866d, c: 0.4477553700672312d),

new NpgsqlTypes.NpgsqlLine(a: 0.2781058464087163d, b: 0.22545784406962033d, c: 0.6117571612553911d),

new NpgsqlTypes.NpgsqlLine(a: 0.8771277465464734d, b: 0.19403139688939108d, c: 0.8186053779307464d),

new NpgsqlTypes.NpgsqlLine(a: 0.6997485042327375d, b: 0.16947990548760739d, c: 0.5069998294103665d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.632534079641634d, b: 0.5607214575716715d, c: 0.9897847744745121d),

new NpgsqlTypes.NpgsqlLine(a: 0.1956616805612812d, b: 0.9386203696184878d, c: 0.9905885560604943d),

new NpgsqlTypes.NpgsqlLine(a: 0.23920986219313223d, b: 0.9537001481516821d, c: 0.14299811554275055d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0812259899377773d, b: 0.9252593018611588d, c: 0.711586825828378d),

new NpgsqlTypes.NpgsqlLine(a: 0.4521905145231495d, b: 0.0022943163364275154d, c: 0.11660464562685513d),

new NpgsqlTypes.NpgsqlLine(a: 0.39267437599254573d, b: 0.7258108160456189d, c: 0.40016840145333243d),

new NpgsqlTypes.NpgsqlLine(a: 0.6823656838675058d, b: 0.4030552753421184d, c: 0.356977107529594d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7674702084667105d, b: 0.3281562627319583d, c: 0.6740955516666047d),

new NpgsqlTypes.NpgsqlLine(a: 0.34829671768616566d, b: 0.856019367386406d, c: 0.5186333284680039d),

new NpgsqlTypes.NpgsqlLine(a: 0.7690452243426737d, b: 0.35997507414707575d, c: 0.8847424070761567d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3081292309233812d, b: 0.3977517046729597d, c: 0.6202497653616682d),

new NpgsqlTypes.NpgsqlLine(a: 0.9494794922612653d, b: 0.625083004779145d, c: 0.24377388595917082d),

new NpgsqlTypes.NpgsqlLine(a: 0.955106655231874d, b: 0.595378370966351d, c: 0.25520811452990333d),

new NpgsqlTypes.NpgsqlLine(a: 0.3209027014855712d, b: 0.18868607942772087d, c: 0.9474547735651005d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6214851268675508d, b: 0.6898056734707102d, c: 0.8755029473797794d),

new NpgsqlTypes.NpgsqlLine(a: 0.40494857396209005d, b: 0.36792174726464466d, c: 0.07785515063761927d),

new NpgsqlTypes.NpgsqlLine(a: 0.6189744040111085d, b: 0.43209739175558126d, c: 0.5609168075219838d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8972770942326334d, b: 0.7292045143094821d, c: 0.3533602118865321d),

new NpgsqlTypes.NpgsqlLine(a: 0.2671205510824376d, b: 0.5233551116965709d, c: 0.24229234666276234d),

new NpgsqlTypes.NpgsqlLine(a: 0.7435387583242191d, b: 0.41301969044242515d, c: 0.548830780334542d),

new NpgsqlTypes.NpgsqlLine(a: 0.537074464079064d, b: 0.2102697789203395d, c: 0.9494950707030729d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6642439014634355d, b: 0.27775642172707926d, c: 0.8671179418356532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5465700262337513d, b: 0.07158170344401671d, c: 0.04218802225783336d),

new NpgsqlTypes.NpgsqlLine(a: 0.040983368769156536d, b: 0.26808318002004616d, c: 0.2025342363335031d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9205282637553703d, b: 0.0883028262484763d, c: 0.17920231853934498d),

new NpgsqlTypes.NpgsqlLine(a: 0.9017083870577822d, b: 0.3649627115812888d, c: 0.6818278897253385d),

new NpgsqlTypes.NpgsqlLine(a: 0.5080772523465088d, b: 0.20579659606953682d, c: 0.4601692942566946d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08501346092998585d, b: 0.2833145008328469d, c: 0.046381710272226595d),

new NpgsqlTypes.NpgsqlLine(a: 0.5124146866848825d, b: 0.23010151200071638d, c: 0.4977313104344294d),

new NpgsqlTypes.NpgsqlLine(a: 0.6909194557373279d, b: 0.9662190086919235d, c: 0.6226233744630331d),

new NpgsqlTypes.NpgsqlLine(a: 0.5363317819179427d, b: 0.42195472926773137d, c: 0.2995971408529593d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44379752521373417d, b: 0.054878627282903936d, c: 0.4630609042257632d),

new NpgsqlTypes.NpgsqlLine(a: 0.6864950143232437d, b: 0.5709728874154165d, c: 0.5965613415030665d),

new NpgsqlTypes.NpgsqlLine(a: 0.8884274891740455d, b: 0.002313078355517195d, c: 0.2822971428909823d),

new NpgsqlTypes.NpgsqlLine(a: 0.8105081122774855d, b: 0.9515053604729821d, c: 0.7204052789182467d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20245654904676558d, b: 0.6536747631695594d, c: 0.07903225353975418d),

new NpgsqlTypes.NpgsqlLine(a: 0.008499727117000644d, b: 0.1095591213256889d, c: 0.7856742699888084d),

new NpgsqlTypes.NpgsqlLine(a: 0.07825830845293003d, b: 0.3165869690254052d, c: 0.8699640356240518d),

new NpgsqlTypes.NpgsqlLine(a: 0.5211666445985352d, b: 0.07427819411882564d, c: 0.7143205448779552d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.040854763144094974d, b: 0.46052554786920585d, c: 0.5127982790632469d),

new NpgsqlTypes.NpgsqlLine(a: 0.7267633963045967d, b: 0.9149763007698618d, c: 0.3706057299909883d),

new NpgsqlTypes.NpgsqlLine(a: 0.19476637352959092d, b: 0.40270188152403885d, c: 0.9333472874184446d),

new NpgsqlTypes.NpgsqlLine(a: 0.3223514966609172d, b: 0.08072599100188937d, c: 0.9435683809788189d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9048043096663524d, b: 0.31635450160858525d, c: 0.9294006806872163d),

new NpgsqlTypes.NpgsqlLine(a: 0.6621364567786245d, b: 0.22250460417967577d, c: 0.7979230807257746d),

new NpgsqlTypes.NpgsqlLine(a: 0.8948232843001227d, b: 0.7653535876021534d, c: 0.4465473786918571d),

new NpgsqlTypes.NpgsqlLine(a: 0.22923149017448574d, b: 0.6299791936075613d, c: 0.2798156405135558d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.890214655742932d, b: 0.24662747550310637d, c: 0.36806638162006866d),

new NpgsqlTypes.NpgsqlLine(a: 0.9875809512570994d, b: 0.24482581719325403d, c: 0.4944105552096595d),

new NpgsqlTypes.NpgsqlLine(a: 0.9332325753799837d, b: 0.6265822658918694d, c: 0.19490377222655952d),

new NpgsqlTypes.NpgsqlLine(a: 0.39506622680143477d, b: 0.7830918298954864d, c: 0.008487825649766023d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08432184721906377d, b: 0.1069339869806748d, c: 0.13357172845293863d),

new NpgsqlTypes.NpgsqlLine(a: 0.01441360210561049d, b: 0.41196007887716746d, c: 0.8831017925281422d),

new NpgsqlTypes.NpgsqlLine(a: 0.5326992576579415d, b: 0.4094185678303288d, c: 0.04009699587224069d),

new NpgsqlTypes.NpgsqlLine(a: 0.7912976609875835d, b: 0.6516022752060466d, c: 0.8010472752062281d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9973607671051452d, b: 0.8084649774104283d, c: 0.041735169534224514d),

new NpgsqlTypes.NpgsqlLine(a: 0.14158061045149695d, b: 0.5509387348511465d, c: 0.7261387314934086d),

new NpgsqlTypes.NpgsqlLine(a: 0.5349909307652292d, b: 0.9050626716374484d, c: 0.6611048441460866d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9302692850958976d, b: 0.4214862860623596d, c: 0.6547065753315753d),

new NpgsqlTypes.NpgsqlLine(a: 0.8364823618371091d, b: 0.34910384748514744d, c: 0.4409156958917948d),

new NpgsqlTypes.NpgsqlLine(a: 0.47794531770091064d, b: 0.5519045941698484d, c: 0.675440711732259d),

new NpgsqlTypes.NpgsqlLine(a: 0.18793356032953012d, b: 0.9696576539542197d, c: 0.43664344417314316d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27529142814107643d, b: 0.6448543575907086d, c: 0.7951635148745848d),

new NpgsqlTypes.NpgsqlLine(a: 0.28250312230507413d, b: 0.7704014546580334d, c: 0.49899044192198005d),

new NpgsqlTypes.NpgsqlLine(a: 0.2911619738980735d, b: 0.5996369081974107d, c: 0.022591673037858806d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07045055863963734d, b: 0.7267514334276052d, c: 0.22351847871212271d),

new NpgsqlTypes.NpgsqlLine(a: 0.3773334793678531d, b: 0.1092001430319105d, c: 0.6058438166033455d),

new NpgsqlTypes.NpgsqlLine(a: 0.3236581680064068d, b: 0.8684980009807363d, c: 0.13847468533613205d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08940409648456848d, b: 0.0772954896542346d, c: 0.9936976483103921d),

new NpgsqlTypes.NpgsqlLine(a: 0.42003804409382184d, b: 0.20924845299477235d, c: 0.6258683816714369d),

new NpgsqlTypes.NpgsqlLine(a: 0.05047577928092295d, b: 0.31087974673816143d, c: 0.04615964678913165d),

new NpgsqlTypes.NpgsqlLine(a: 0.5682986060778376d, b: 0.5875634769192529d, c: 0.7531320254642364d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8442496180511347d, b: 0.7471608892663082d, c: 0.07006459263331666d),

new NpgsqlTypes.NpgsqlLine(a: 0.09111597607696953d, b: 0.06508868238789967d, c: 0.03902813858178655d),

new NpgsqlTypes.NpgsqlLine(a: 0.1457321419588361d, b: 0.7614089188767552d, c: 0.20495439459501175d),

new NpgsqlTypes.NpgsqlLine(a: 0.9766528111669911d, b: 0.8075063980273404d, c: 0.684781270649968d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8361415599486075d, b: 0.6760538492283835d, c: 0.026413575228888986d),

new NpgsqlTypes.NpgsqlLine(a: 0.8797176396090897d, b: 0.6166509067275587d, c: 0.3531713756346063d),

new NpgsqlTypes.NpgsqlLine(a: 0.43282302381356075d, b: 0.1883556034423891d, c: 0.24075784940494405d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8798131006447829d, b: 0.885185804207547d, c: 0.2166947230381121d),

new NpgsqlTypes.NpgsqlLine(a: 0.3811401854117332d, b: 0.7097173918123615d, c: 0.019090144258385067d),

new NpgsqlTypes.NpgsqlLine(a: 0.7415121991540223d, b: 0.9215712211032835d, c: 0.42962815060928716d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20061205997065246d, b: 0.3854808279640243d, c: 0.4752670687379892d),

new NpgsqlTypes.NpgsqlLine(a: 0.6839726848759644d, b: 0.18104805314781258d, c: 0.7898662640602263d),

new NpgsqlTypes.NpgsqlLine(a: 0.7456690158499113d, b: 0.5300356679573645d, c: 0.2763312092453537d),

new NpgsqlTypes.NpgsqlLine(a: 0.4662165858953511d, b: 0.2631604984904131d, c: 0.42004128540696495d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9665260539017099d, b: 0.2791026966194391d, c: 0.05948467806485014d),

new NpgsqlTypes.NpgsqlLine(a: 0.7055739731452685d, b: 0.5700815763231516d, c: 0.19515867968486933d),

new NpgsqlTypes.NpgsqlLine(a: 0.06501670641972312d, b: 0.9186744008222459d, c: 0.641420277359823d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4541734044590352d, b: 0.14149525665373242d, c: 0.5343040833710094d),

new NpgsqlTypes.NpgsqlLine(a: 0.6670964000445027d, b: 0.07857737213706073d, c: 0.5054381470144659d),

new NpgsqlTypes.NpgsqlLine(a: 0.2687462077724381d, b: 0.9545502259984531d, c: 0.7488771648074434d),

new NpgsqlTypes.NpgsqlLine(a: 0.6392076365829309d, b: 0.21609056417044026d, c: 0.10464362306308106d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)), 
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
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                List<NpgsqlLinelineListD1E2M> models = null;

                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineListD1E2M> models = null;

                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 147;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
                parametr2.Value = 164;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 86, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 42, query1, 171, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 78, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 116, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 176, query1, 30, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 6, query1, 95, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 101, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 21, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatch(connection, 67, 78))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models = await ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 176);
                var models =  ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[34], false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MI),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineListD1E2M),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
FROM public.binary_npgsqllinelinelistd1e2m m
LEFT JOIN public.binary_npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models =  ((INpgsqlLineListlineListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI), typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                await ((INpgsqlLineListlineListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                ((INpgsqlLineListlineListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

