

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
    internal partial interface INpgsqlPolygonListpolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonArray : INpgsqlPolygonListpolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray2M[] _testData = new NpgsqlPolygonpolygonArray2M[]
        {
            new NpgsqlPolygonpolygonArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42310307735440944d, y: 0.6034278513380967d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894753585403976d, y: 0.12242480147617874d), new NpgsqlTypes.NpgsqlPoint(x: 0.1252211617493465d, y: 0.46867800841318064d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.041514249108666856d, y: 0.47507579372303066d), new NpgsqlTypes.NpgsqlPoint(x: 0.3493721449594007d, y: 0.5166204698920451d), new NpgsqlTypes.NpgsqlPoint(x: 0.4744582139599107d, y: 0.04083310174261956d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6042275978279041d, y: 0.6168478600597211d), new NpgsqlTypes.NpgsqlPoint(x: 0.9638537732031884d, y: 0.23475118185335675d), new NpgsqlTypes.NpgsqlPoint(x: 0.02805301939423055d, y: 0.4930680405938349d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7135977111094607d, y: 0.3592477284442134d), new NpgsqlTypes.NpgsqlPoint(x: 0.11826089800365314d, y: 0.7050309614538828d), new NpgsqlTypes.NpgsqlPoint(x: 0.8134332143621161d, y: 0.06204312470625539d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07098379923131404d, y: 0.09765272660570457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984366506885301d, y: 0.9393326475308158d), new NpgsqlTypes.NpgsqlPoint(x: 0.39145884969622247d, y: 0.9032972132546411d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8070452205784436d, y: 0.00703102005687839d), new NpgsqlTypes.NpgsqlPoint(x: 0.3033887855147641d, y: 0.6284404453816987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211276357819491d, y: 0.5868559094706334d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29399063474272435d, y: 0.1414784783184705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5728229841544199d, y: 0.5131262880423328d), new NpgsqlTypes.NpgsqlPoint(x: 0.5509218269090479d, y: 0.1768302703603114d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4952903311760004d, y: 0.2492371641138117d), new NpgsqlTypes.NpgsqlPoint(x: 0.9738102894578187d, y: 0.6219708413211692d), new NpgsqlTypes.NpgsqlPoint(x: 0.5772979028410286d, y: 0.8361685740713981d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.755823172888331d, y: 0.29538874662967574d), new NpgsqlTypes.NpgsqlPoint(x: 0.03006054983565354d, y: 0.8386882290665487d), new NpgsqlTypes.NpgsqlPoint(x: 0.0860224345929469d, y: 0.1255801775244565d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.021985884431021452d, y: 0.8600287035064249d), new NpgsqlTypes.NpgsqlPoint(x: 0.6916714283136969d, y: 0.7891499998668933d), new NpgsqlTypes.NpgsqlPoint(x: 0.7302331783220617d, y: 0.31892303152090495d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22945742928479707d, y: 0.059294000636190614d), new NpgsqlTypes.NpgsqlPoint(x: 0.32669885832824697d, y: 0.556058439204518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561765363656739d, y: 0.7751252105080507d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7934097727348169d, y: 0.847622531395015d), new NpgsqlTypes.NpgsqlPoint(x: 0.857616007014131d, y: 0.6039744362125856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459103532584496d, y: 0.8328116105827611d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06476183397733537d, y: 0.5566924721590487d), new NpgsqlTypes.NpgsqlPoint(x: 0.15925757970212173d, y: 0.14309171822118738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7602883853168947d, y: 0.8954674517765012d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4604984813706179d, y: 0.6740547966766579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7229949405456634d, y: 0.9888362181337866d), new NpgsqlTypes.NpgsqlPoint(x: 0.6466874703446025d, y: 0.49280915162138694d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1154669513498261d, y: 0.2998388686470308d), new NpgsqlTypes.NpgsqlPoint(x: 0.14768360000717384d, y: 0.007781168574607866d), new NpgsqlTypes.NpgsqlPoint(x: 0.41526339701356285d, y: 0.06960081495941717d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.526318886754751d, y: 0.7465239289927068d), new NpgsqlTypes.NpgsqlPoint(x: 0.15996582994611686d, y: 0.614086812891228d), new NpgsqlTypes.NpgsqlPoint(x: 0.25033742939415216d, y: 0.3114849589764841d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.600899461748877d, y: 0.35286071911070493d), new NpgsqlTypes.NpgsqlPoint(x: 0.3698718837157158d, y: 0.7026152579624076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7230810635979867d, y: 0.021204013145387335d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9524889460196657d, y: 0.6419154649886638d), new NpgsqlTypes.NpgsqlPoint(x: 0.33615225630810086d, y: 0.6162365405281881d), new NpgsqlTypes.NpgsqlPoint(x: 0.6958980844294753d, y: 0.9979175133160404d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16008778800424828d, y: 0.09059036432787926d), new NpgsqlTypes.NpgsqlPoint(x: 0.08909405652329505d, y: 0.4558026351551152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517565744077736d, y: 0.8336623304365512d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6848291201770713d, y: 0.5510814510892044d), new NpgsqlTypes.NpgsqlPoint(x: 0.2245334350828836d, y: 0.3574303130253572d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972222353006653d, y: 0.5018781772190234d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8444624063038533d, y: 0.07453071812627998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6518073524306541d, y: 0.06401422689827885d), new NpgsqlTypes.NpgsqlPoint(x: 0.3681302278351578d, y: 0.7005603876981346d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4237232359668336d, y: 0.8960882448210884d), new NpgsqlTypes.NpgsqlPoint(x: 0.13130677559754467d, y: 0.07501900671833706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7565448148450882d, y: 0.38481015533983665d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3287192555065598d, y: 0.8354918984138682d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421490051624825d, y: 0.24550868390325897d), new NpgsqlTypes.NpgsqlPoint(x: 0.44947368529312404d, y: 0.18859495296252515d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28227138529502893d, y: 0.6381585953083749d), new NpgsqlTypes.NpgsqlPoint(x: 0.09739392799836044d, y: 0.8016692730323504d), new NpgsqlTypes.NpgsqlPoint(x: 0.2293245630559324d, y: 0.4246743777857678d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4117582334187383d, y: 0.5177329256478055d), new NpgsqlTypes.NpgsqlPoint(x: 0.8918483735672202d, y: 0.673159611728893d), new NpgsqlTypes.NpgsqlPoint(x: 0.16969827058204323d, y: 0.22708708774245978d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7696268573701501d, y: 0.2102893403658218d), new NpgsqlTypes.NpgsqlPoint(x: 0.03548043529168232d, y: 0.4457310212191258d), new NpgsqlTypes.NpgsqlPoint(x: 0.40539405092424097d, y: 0.2906749327240681d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8448962187620949d, y: 0.9442393426919968d), new NpgsqlTypes.NpgsqlPoint(x: 0.9486929024245193d, y: 0.35494935265384064d), new NpgsqlTypes.NpgsqlPoint(x: 0.10475273253076856d, y: 0.6610566955458202d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8604762291800528d, y: 0.24995813245913778d), new NpgsqlTypes.NpgsqlPoint(x: 0.8310550940569595d, y: 0.9642101785169912d), new NpgsqlTypes.NpgsqlPoint(x: 0.2539211655114969d, y: 0.8697537536164408d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8775214033121825d, y: 0.8089678825193856d), new NpgsqlTypes.NpgsqlPoint(x: 0.3790108100681814d, y: 0.1351997065161572d), new NpgsqlTypes.NpgsqlPoint(x: 0.21210965528995018d, y: 0.09101168336440846d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12322720913618979d, y: 0.2885179164588244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7909332430670756d, y: 0.8109079312209484d), new NpgsqlTypes.NpgsqlPoint(x: 0.6922193336051955d, y: 0.5923310885544252d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01018744678683925d, y: 0.9564730836000883d), new NpgsqlTypes.NpgsqlPoint(x: 0.5756553772408066d, y: 0.35971557461565273d), new NpgsqlTypes.NpgsqlPoint(x: 0.9656015604138702d, y: 0.5558394054679332d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8504444698263459d, y: 0.2304073532516291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8875583290177188d, y: 0.594278561046658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9699165364132158d, y: 0.6251103142931476d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7976005509102201d, y: 0.9033420151634721d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945904099834446d, y: 0.2846102664352167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9333162466073731d, y: 0.30582469560310477d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39209698440394014d, y: 0.7019009119244431d), new NpgsqlTypes.NpgsqlPoint(x: 0.16636243950165375d, y: 0.7042323367801695d), new NpgsqlTypes.NpgsqlPoint(x: 0.11246549926371852d, y: 0.23244561488537185d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7123563006870368d, y: 0.8183802263004804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942539352153087d, y: 0.6888993287476364d), new NpgsqlTypes.NpgsqlPoint(x: 0.718677747361958d, y: 0.5256359586083548d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6397778208046294d, y: 0.6511462153424801d), new NpgsqlTypes.NpgsqlPoint(x: 0.2013579904814271d, y: 0.9678459454456915d), new NpgsqlTypes.NpgsqlPoint(x: 0.4101199334883686d, y: 0.6473150422432058d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8659016614415586d, y: 0.8443468872333924d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524335080089848d, y: 0.9252984463599008d), new NpgsqlTypes.NpgsqlPoint(x: 0.10682705615447774d, y: 0.9892183314353868d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1760780181892596d, y: 0.20213044264905322d), new NpgsqlTypes.NpgsqlPoint(x: 0.22602528599415606d, y: 0.6043497772089477d), new NpgsqlTypes.NpgsqlPoint(x: 0.621605219564323d, y: 0.44784510820255063d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7392793230270998d, y: 0.8619494599297698d), new NpgsqlTypes.NpgsqlPoint(x: 0.782584381390033d, y: 0.3591403850755521d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433417498253644d, y: 0.6211328078698428d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24948439232683983d, y: 0.7540282413828427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6696983379665388d, y: 0.3705271443192112d), new NpgsqlTypes.NpgsqlPoint(x: 0.39852263090322104d, y: 0.4867105935642557d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.045424837439266286d, y: 0.5636631393337964d), new NpgsqlTypes.NpgsqlPoint(x: 0.2945513871498564d, y: 0.3440874959501924d), new NpgsqlTypes.NpgsqlPoint(x: 0.9148800102029778d, y: 0.32517499057852206d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8664098812036445d, y: 0.11171219483191419d), new NpgsqlTypes.NpgsqlPoint(x: 0.039809351770561774d, y: 0.504505039290297d), new NpgsqlTypes.NpgsqlPoint(x: 0.3761667044648186d, y: 0.010111635409615793d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.902489104513649d, y: 0.4282436214636999d), new NpgsqlTypes.NpgsqlPoint(x: 0.9748389222748793d, y: 0.9277739694643525d), new NpgsqlTypes.NpgsqlPoint(x: 0.43405240891986685d, y: 0.481714326662942d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9561479022512989d, y: 0.06462974787050446d), new NpgsqlTypes.NpgsqlPoint(x: 0.4710482925108693d, y: 0.38412849440029195d), new NpgsqlTypes.NpgsqlPoint(x: 0.49611524130608886d, y: 0.5564266981409041d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5644100075334956d, y: 0.3244483123514674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8240638901696125d, y: 0.08421691446837065d), new NpgsqlTypes.NpgsqlPoint(x: 0.2763046916304883d, y: 0.5587761150767385d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15173894565850998d, y: 0.9200215628831415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5894406831782929d, y: 0.7028886129204969d), new NpgsqlTypes.NpgsqlPoint(x: 0.647689862152613d, y: 0.6492543843197652d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.853045644267824d, y: 0.922992848995268d), new NpgsqlTypes.NpgsqlPoint(x: 0.06406900270061344d, y: 0.44335799892514194d), new NpgsqlTypes.NpgsqlPoint(x: 0.6176362343578861d, y: 0.8382315096227755d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5341859958230863d, y: 0.3655606699672619d), new NpgsqlTypes.NpgsqlPoint(x: 0.4574847319338694d, y: 0.17825666965664544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7692043840421169d, y: 0.700953831539143d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5907536666551877d, y: 0.05332642420777778d), new NpgsqlTypes.NpgsqlPoint(x: 0.6749188400220344d, y: 0.7532728007085436d), new NpgsqlTypes.NpgsqlPoint(x: 0.48679535631608406d, y: 0.02048801307714776d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.018214355353581624d, y: 0.47423455068687403d), new NpgsqlTypes.NpgsqlPoint(x: 0.906615159658617d, y: 0.9337009638115594d), new NpgsqlTypes.NpgsqlPoint(x: 0.6271177349362526d, y: 0.20049055297017127d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5097682195616033d, y: 0.9939258001191129d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752455709204886d, y: 0.6950770681365468d), new NpgsqlTypes.NpgsqlPoint(x: 0.1853096680622116d, y: 0.4076622768280569d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9291976487338072d, y: 0.8497630526148041d), new NpgsqlTypes.NpgsqlPoint(x: 0.5110677986867328d, y: 0.8378332441950879d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820287424533319d, y: 0.5614096773218772d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19396680746998596d, y: 0.26718486306250677d), new NpgsqlTypes.NpgsqlPoint(x: 0.3228308608395728d, y: 0.6482821221517232d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769627573078235d, y: 0.7597459742922686d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.059769073945982854d, y: 0.28723856679205617d), new NpgsqlTypes.NpgsqlPoint(x: 0.1860534975724819d, y: 0.9287315623682605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5343848416245391d, y: 0.09899216434314762d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7601671829794425d, y: 0.4870287778991915d), new NpgsqlTypes.NpgsqlPoint(x: 0.462666751059971d, y: 0.6044865895456306d), new NpgsqlTypes.NpgsqlPoint(x: 0.2543682609211376d, y: 0.3034909990822251d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24574925211734766d, y: 0.39133068647882885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8387300387604391d, y: 0.856351655695881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7532906320344077d, y: 0.0039983699566995545d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2437752349108785d, y: 0.8031399527203619d), new NpgsqlTypes.NpgsqlPoint(x: 0.45493733467397646d, y: 0.053458391453956366d), new NpgsqlTypes.NpgsqlPoint(x: 0.6113741165648436d, y: 0.6356068267555943d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21392917529186772d, y: 0.9577788298327156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8956307236289346d, y: 0.8540583365738712d), new NpgsqlTypes.NpgsqlPoint(x: 0.023278900522501034d, y: 0.22222363492495567d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3508782455681171d, y: 0.9775453433017829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4981342587328047d, y: 0.03791765746249176d), new NpgsqlTypes.NpgsqlPoint(x: 0.30517955835796806d, y: 0.8726879594800753d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.878966537070533d, y: 0.1573734938583412d), new NpgsqlTypes.NpgsqlPoint(x: 0.6573025257714379d, y: 0.7332833291949614d), new NpgsqlTypes.NpgsqlPoint(x: 0.2502779954990122d, y: 0.7655311274357497d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49830412267768454d, y: 0.22054957965735478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6419886408039194d, y: 0.5542575857121198d), new NpgsqlTypes.NpgsqlPoint(x: 0.446531818819516d, y: 0.9171412319118558d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8784012346104557d, y: 0.652545448140761d), new NpgsqlTypes.NpgsqlPoint(x: 0.859942739812229d, y: 0.5935085149885968d), new NpgsqlTypes.NpgsqlPoint(x: 0.4293089155150498d, y: 0.8574925886752085d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7759678359542987d, y: 0.8714444873955445d), new NpgsqlTypes.NpgsqlPoint(x: 0.8854859658497009d, y: 0.7186838875416792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6234694880692067d, y: 0.12139967198469048d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3677676762827987d, y: 0.047300775410953344d), new NpgsqlTypes.NpgsqlPoint(x: 0.9686908843481356d, y: 0.38827153353151467d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566165132180757d, y: 0.3169530824350293d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8912458838928569d, y: 0.12231043988310153d), new NpgsqlTypes.NpgsqlPoint(x: 0.8356609439312696d, y: 0.15529500712943267d), new NpgsqlTypes.NpgsqlPoint(x: 0.14948568514390426d, y: 0.7761370069830296d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20659917722136d, y: 0.7365092038581724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5186436881489584d, y: 0.21082897991632032d), new NpgsqlTypes.NpgsqlPoint(x: 0.4618562799771465d, y: 0.4626949408811991d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7259882819148601d, y: 0.6427239481938679d), new NpgsqlTypes.NpgsqlPoint(x: 0.8203106102393077d, y: 0.6428099345991538d), new NpgsqlTypes.NpgsqlPoint(x: 0.06781906818831973d, y: 0.9860494229227017d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07973709128000428d, y: 0.5179306540495259d), new NpgsqlTypes.NpgsqlPoint(x: 0.9247071479857694d, y: 0.0416128287138251d), new NpgsqlTypes.NpgsqlPoint(x: 0.6019794311956497d, y: 0.560128018803182d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21908909564845291d, y: 0.3413856392229342d), new NpgsqlTypes.NpgsqlPoint(x: 0.9800562571783208d, y: 0.21607933333569163d), new NpgsqlTypes.NpgsqlPoint(x: 0.06252878703809706d, y: 0.8520045174105313d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36468565581322465d, y: 0.8607134937332271d), new NpgsqlTypes.NpgsqlPoint(x: 0.2379508412134811d, y: 0.01422169870168255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8412599543455834d, y: 0.44692425233693d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4447101108366316d, y: 0.9534864587995389d), new NpgsqlTypes.NpgsqlPoint(x: 0.38505120617617794d, y: 0.5636351693072829d), new NpgsqlTypes.NpgsqlPoint(x: 0.14632184076939625d, y: 0.9312558912936238d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9886047396002671d, y: 0.9805480836011019d), new NpgsqlTypes.NpgsqlPoint(x: 0.1448580192508676d, y: 0.4912215424210128d), new NpgsqlTypes.NpgsqlPoint(x: 0.34236514728433876d, y: 0.40093090869033254d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38027400581949644d, y: 0.03552415389784347d), new NpgsqlTypes.NpgsqlPoint(x: 0.2428253348091104d, y: 0.3087238192860673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8120626195896818d, y: 0.9220774167296704d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8354226547839735d, y: 0.8648034793461322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8383700441341703d, y: 0.3860386121275097d), new NpgsqlTypes.NpgsqlPoint(x: 0.8631759209678053d, y: 0.7855489184127693d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47454517869191437d, y: 0.028546301643138428d), new NpgsqlTypes.NpgsqlPoint(x: 0.38689444111328386d, y: 0.14300996323899406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789559660001063d, y: 0.2588156167514174d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2920094383527001d, y: 0.2862894559344161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9946190160383842d, y: 0.7335708979412165d), new NpgsqlTypes.NpgsqlPoint(x: 0.0699005388334566d, y: 0.12000377835813392d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.054353068884968936d, y: 0.08869679530647223d), new NpgsqlTypes.NpgsqlPoint(x: 0.37062282234587074d, y: 0.7573301028899583d), new NpgsqlTypes.NpgsqlPoint(x: 0.15546750987073443d, y: 0.673343209001926d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4838963270176404d, y: 0.08907258432593823d), new NpgsqlTypes.NpgsqlPoint(x: 0.7651310307332398d, y: 0.1128261537356281d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054830813769946d, y: 0.22192615838804253d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47218560685221755d, y: 0.7779993220301528d), new NpgsqlTypes.NpgsqlPoint(x: 0.31334588392906215d, y: 0.3624827851036353d), new NpgsqlTypes.NpgsqlPoint(x: 0.8626462842692151d, y: 0.011249944800944767d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5604240141135529d, y: 0.1304367292280395d), new NpgsqlTypes.NpgsqlPoint(x: 0.14475652606304812d, y: 0.46280130676475173d), new NpgsqlTypes.NpgsqlPoint(x: 0.2762477144590222d, y: 0.5827974927349704d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5794689439485057d, y: 0.7586224474171434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492217267065198d, y: 0.020509922611478326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5264910508242143d, y: 0.5751352139721427d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9977133674146d, y: 0.9801701685612003d), new NpgsqlTypes.NpgsqlPoint(x: 0.12900157638064724d, y: 0.2768830912958091d), new NpgsqlTypes.NpgsqlPoint(x: 0.4867385584947822d, y: 0.2024708466779147d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06621040176910098d, y: 0.3085668091891157d), new NpgsqlTypes.NpgsqlPoint(x: 0.199740849695354d, y: 0.9090460505431377d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888344107967528d, y: 0.6378716666131987d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8817188369130653d, y: 0.03999397762683188d), new NpgsqlTypes.NpgsqlPoint(x: 0.4319953611554046d, y: 0.5979922511047701d), new NpgsqlTypes.NpgsqlPoint(x: 0.015231967555561554d, y: 0.5244893257174155d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.284865089044367d, y: 0.6765963377347939d), new NpgsqlTypes.NpgsqlPoint(x: 0.08013275607019577d, y: 0.09209846863413251d), new NpgsqlTypes.NpgsqlPoint(x: 0.7108827123140812d, y: 0.9878077992446094d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5533872320508229d, y: 0.44713193004138174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7659187367504966d, y: 0.3826138203021323d), new NpgsqlTypes.NpgsqlPoint(x: 0.5909396174121812d, y: 0.134812654094983d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07387179225379203d, y: 0.33741744643925864d), new NpgsqlTypes.NpgsqlPoint(x: 0.2430487690794506d, y: 0.6706267113347532d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850175134557853d, y: 0.6946532036070096d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21453238345872905d, y: 0.9919485049030627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4271047077934367d, y: 0.6240012925449613d), new NpgsqlTypes.NpgsqlPoint(x: 0.2504651399686556d, y: 0.44892291793814143d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4986005249112715d, y: 0.9486718981221552d), new NpgsqlTypes.NpgsqlPoint(x: 0.29084432563848717d, y: 0.5238462610537029d), new NpgsqlTypes.NpgsqlPoint(x: 0.8375605562596595d, y: 0.3676590746795184d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5828246925862616d, y: 0.4574965238919887d), new NpgsqlTypes.NpgsqlPoint(x: 0.3373354144112757d, y: 0.48703394349687257d), new NpgsqlTypes.NpgsqlPoint(x: 0.38969738386449915d, y: 0.9719864971632797d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7687049550921409d, y: 0.3714423529308921d), new NpgsqlTypes.NpgsqlPoint(x: 0.31094109212289545d, y: 0.3252680589634631d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853142753844356d, y: 0.21309134860870682d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6138435041354232d, y: 0.5377344657495996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7094279998804525d, y: 0.8873010722361854d), new NpgsqlTypes.NpgsqlPoint(x: 0.4227476979510921d, y: 0.779477477431331d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31244196700910976d, y: 0.8183491055607928d), new NpgsqlTypes.NpgsqlPoint(x: 0.2233409404560952d, y: 0.9694926831595515d), new NpgsqlTypes.NpgsqlPoint(x: 0.2865678198824292d, y: 0.7223695673711885d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9253949143687223d, y: 0.7344383892467662d), new NpgsqlTypes.NpgsqlPoint(x: 0.16403368376037364d, y: 0.1466565979522474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4796687551808452d, y: 0.15851399548907175d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1963726634143449d, y: 0.9805133211358741d), new NpgsqlTypes.NpgsqlPoint(x: 0.4833728778047628d, y: 0.7867699181046018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9479932553847563d, y: 0.15654237262084125d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2447193273996614d, y: 0.49424632357069276d), new NpgsqlTypes.NpgsqlPoint(x: 0.12343667940456649d, y: 0.5430548582456606d), new NpgsqlTypes.NpgsqlPoint(x: 0.641856936543037d, y: 0.6799750657373584d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6350147887490009d, y: 0.6264352395012247d), new NpgsqlTypes.NpgsqlPoint(x: 0.6935058328962533d, y: 0.5887567081390948d), new NpgsqlTypes.NpgsqlPoint(x: 0.4833194754793845d, y: 0.2820371911032249d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23488615665647883d, y: 0.15776250869442432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8129051363800914d, y: 0.4455337595745156d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737542290627306d, y: 0.7800062686733235d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18700368025617709d, y: 0.23151318695210377d), new NpgsqlTypes.NpgsqlPoint(x: 0.6660157146535856d, y: 0.6084656406200281d), new NpgsqlTypes.NpgsqlPoint(x: 0.837650903989085d, y: 0.6251752467576455d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8397428171836672d, y: 0.19009022806929643d), new NpgsqlTypes.NpgsqlPoint(x: 0.7876163640903135d, y: 0.6937490033073103d), new NpgsqlTypes.NpgsqlPoint(x: 0.48238540079043546d, y: 0.661300795543036d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3754354591833041d, y: 0.3763643567581997d), new NpgsqlTypes.NpgsqlPoint(x: 0.025020745937729516d, y: 0.5380246378959644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845435439503044d, y: 0.6202154455033668d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.892198637544654d, y: 0.331414764915269d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096768837176511d, y: 0.9597057152478456d), new NpgsqlTypes.NpgsqlPoint(x: 0.5113045825740471d, y: 0.47386958556854586d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6709100685958648d, y: 0.49717505427081543d), new NpgsqlTypes.NpgsqlPoint(x: 0.1416918340846669d, y: 0.8245852244744862d), new NpgsqlTypes.NpgsqlPoint(x: 0.5664096080215044d, y: 0.8241672943207311d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4424580940828824d, y: 0.18426012033559713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7039059837412972d, y: 0.5186003798148894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702820512124218d, y: 0.9071307693702088d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.77318582412819d, y: 0.34465876577424526d), new NpgsqlTypes.NpgsqlPoint(x: 0.10863410223656256d, y: 0.5045748064268201d), new NpgsqlTypes.NpgsqlPoint(x: 0.004816767827743651d, y: 0.41520029009581916d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34112876134656456d, y: 0.13542149061409214d), new NpgsqlTypes.NpgsqlPoint(x: 0.06747994514096556d, y: 0.8012154947512679d), new NpgsqlTypes.NpgsqlPoint(x: 0.47907555039127614d, y: 0.1657873148348077d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6880245053052534d, y: 0.5708845951623095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5922443550040197d, y: 0.23153159645247423d), new NpgsqlTypes.NpgsqlPoint(x: 0.05259463151301935d, y: 0.7128923144105116d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4410661028100771d, y: 0.27138175777384677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7121731453311886d, y: 0.7150770504024472d), new NpgsqlTypes.NpgsqlPoint(x: 0.11181591309567585d, y: 0.9486543161308953d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12483613060869558d, y: 0.654704653611611d), new NpgsqlTypes.NpgsqlPoint(x: 0.786971142207345d, y: 0.9939151474626162d), new NpgsqlTypes.NpgsqlPoint(x: 0.26400904927543467d, y: 0.5799341806525368d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006795018702534739d, y: 0.18819800070454595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898040789073447d, y: 0.3653230217960869d), new NpgsqlTypes.NpgsqlPoint(x: 0.236287812316757d, y: 0.6733186416700006d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13794655022111657d, y: 0.6430443492219073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593139436303324d, y: 0.34357033692253036d), new NpgsqlTypes.NpgsqlPoint(x: 0.36292932992748406d, y: 0.17110747567729812d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9181496837313394d, y: 0.46785356917731913d), new NpgsqlTypes.NpgsqlPoint(x: 0.4967246272772313d, y: 0.9266218063289987d), new NpgsqlTypes.NpgsqlPoint(x: 0.2562907051388478d, y: 0.9644227833737697d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13025329811215536d, y: 0.31907559536209085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7247797627318988d, y: 0.7273034359276173d), new NpgsqlTypes.NpgsqlPoint(x: 0.7863630576618982d, y: 0.913929286088633d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9082230634586274d, y: 0.07047009389681014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8745318584231676d, y: 0.3946429889764064d), new NpgsqlTypes.NpgsqlPoint(x: 0.4053473050179771d, y: 0.4484535356447863d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.829523190589923d, y: 0.7770245919590749d), new NpgsqlTypes.NpgsqlPoint(x: 0.10686558677814961d, y: 0.1221312008687443d), new NpgsqlTypes.NpgsqlPoint(x: 0.33411499185524707d, y: 0.4992554629275848d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14986858029768524d, y: 0.28562783009714887d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136454350894281d, y: 0.4708448708902061d), new NpgsqlTypes.NpgsqlPoint(x: 0.030538930361897032d, y: 0.3420154565786021d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17793841964819557d, y: 0.15794519207380964d), new NpgsqlTypes.NpgsqlPoint(x: 0.3445143664072764d, y: 0.06126212694015076d), new NpgsqlTypes.NpgsqlPoint(x: 0.19136066985612832d, y: 0.7414428298742751d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7891836346323059d, y: 0.7949186180579022d), new NpgsqlTypes.NpgsqlPoint(x: 0.442404521413152d, y: 0.8230103946324986d), new NpgsqlTypes.NpgsqlPoint(x: 0.45711857814690926d, y: 0.428849866782689d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4824209557595108d, y: 0.5477888233827389d), new NpgsqlTypes.NpgsqlPoint(x: 0.2861323533332121d, y: 0.6171957268447783d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639211671493958d, y: 0.09508424042634311d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8139378900997166d, y: 0.13566037870615755d), new NpgsqlTypes.NpgsqlPoint(x: 0.23943055658016132d, y: 0.1311647343423965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8233889660082216d, y: 0.930600957703655d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4826932353517137d, y: 0.32910607871124176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6330805864061788d, y: 0.9815647768788447d), new NpgsqlTypes.NpgsqlPoint(x: 0.4090421259424444d, y: 0.7806855186602275d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7239041578518741d, y: 0.5867845158190531d), new NpgsqlTypes.NpgsqlPoint(x: 0.3945846529083167d, y: 0.7394773277393012d), new NpgsqlTypes.NpgsqlPoint(x: 0.4018487996593435d, y: 0.6135268297288585d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3912374825693137d, y: 0.6701333092337687d), new NpgsqlTypes.NpgsqlPoint(x: 0.3026897801899382d, y: 0.8260631887815482d), new NpgsqlTypes.NpgsqlPoint(x: 0.3139739189463725d, y: 0.7105362539639294d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3961085441419032d, y: 0.5263393182141844d), new NpgsqlTypes.NpgsqlPoint(x: 0.5604976059558263d, y: 0.6121623333334172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765457946249312d, y: 0.9047855111942767d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7334226460585209d, y: 0.694577902084332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136302791012021d, y: 0.6554876798938194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255084635794822d, y: 0.3926849677177533d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006158256328701817d, y: 0.4763596809319781d), new NpgsqlTypes.NpgsqlPoint(x: 0.17110108345118302d, y: 0.17987419743022948d), new NpgsqlTypes.NpgsqlPoint(x: 0.08246556538172367d, y: 0.8346302025533424d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9103980205879457d, y: 0.55107031430148d), new NpgsqlTypes.NpgsqlPoint(x: 0.746884200303089d, y: 0.8024596409927823d), new NpgsqlTypes.NpgsqlPoint(x: 0.14851788658321474d, y: 0.10662613925687336d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41608965075186066d, y: 0.42528571770364754d), new NpgsqlTypes.NpgsqlPoint(x: 0.11523441935296697d, y: 0.4806543872766993d), new NpgsqlTypes.NpgsqlPoint(x: 0.032777683218860876d, y: 0.5573025716989319d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8976701110010931d, y: 0.9869596977417776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6673370416459671d, y: 0.1267986971405327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9925785736190961d, y: 0.969761274880336d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017182839497821734d, y: 0.43787345521366106d), new NpgsqlTypes.NpgsqlPoint(x: 0.7477831708305326d, y: 0.04151782645673463d), new NpgsqlTypes.NpgsqlPoint(x: 0.5379318078236672d, y: 0.8515091194815629d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9642765527220146d, y: 0.5945273030477707d), new NpgsqlTypes.NpgsqlPoint(x: 0.4552397685792918d, y: 0.8386915864445436d), new NpgsqlTypes.NpgsqlPoint(x: 0.4450976713903668d, y: 0.9812173416086488d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21421452114897088d, y: 0.908488275468389d), new NpgsqlTypes.NpgsqlPoint(x: 0.4216700728938432d, y: 0.7781268123736467d), new NpgsqlTypes.NpgsqlPoint(x: 0.6913280246380995d, y: 0.10787370694667264d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2181415271212962d, y: 0.7660593045314067d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831084903927667d, y: 0.42705431117050596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5911472098311658d, y: 0.019915128631243117d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5595753213470337d, y: 0.46218952139953107d), new NpgsqlTypes.NpgsqlPoint(x: 0.3670725992745977d, y: 0.6594715856097647d), new NpgsqlTypes.NpgsqlPoint(x: 0.868377999587057d, y: 0.9974278235417666d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6685429010062076d, y: 0.9236933318834535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9449488089614975d, y: 0.45864916803172573d), new NpgsqlTypes.NpgsqlPoint(x: 0.4232396850463521d, y: 0.5308079485737387d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5916281945148463d, y: 0.15686231712195764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570265940893489d, y: 0.3391271774544923d), new NpgsqlTypes.NpgsqlPoint(x: 0.31449555266122775d, y: 0.8287753817531566d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3339269340378237d, y: 0.15214801093365327d), new NpgsqlTypes.NpgsqlPoint(x: 0.778814268371281d, y: 0.11180430272762576d), new NpgsqlTypes.NpgsqlPoint(x: 0.9139795287948675d, y: 0.8471428837080067d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.415172986101369d, y: 0.010993981989797064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9685578342893117d, y: 0.3416176402488249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760698141711081d, y: 0.6733359402921464d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46141720875430003d, y: 0.5195890699554353d), new NpgsqlTypes.NpgsqlPoint(x: 0.8139992534402977d, y: 0.2601844192306976d), new NpgsqlTypes.NpgsqlPoint(x: 0.7763743820531893d, y: 0.021525370316428982d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8079474541825874d, y: 0.18086707893283505d), new NpgsqlTypes.NpgsqlPoint(x: 0.866205051397414d, y: 0.6487575119054759d), new NpgsqlTypes.NpgsqlPoint(x: 0.96858567716387d, y: 0.41935511405110226d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9549992476837874d, y: 0.6616711014427291d), new NpgsqlTypes.NpgsqlPoint(x: 0.10136374715574392d, y: 0.5831773654890572d), new NpgsqlTypes.NpgsqlPoint(x: 0.4198626575439133d, y: 0.007910915496732174d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25678059593243974d, y: 0.9384887797845567d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552420331838918d, y: 0.8689694406209705d), new NpgsqlTypes.NpgsqlPoint(x: 0.46682612140612056d, y: 0.8454187746239892d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7046956929209693d, y: 0.2507633617761885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5664094131852917d, y: 0.4147234281827822d), new NpgsqlTypes.NpgsqlPoint(x: 0.627339483897748d, y: 0.40515451297111116d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09079900471711921d, y: 0.3824353229633818d), new NpgsqlTypes.NpgsqlPoint(x: 0.9513297129582792d, y: 0.9783833353457146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100038842113184d, y: 0.2914297813090858d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2902233970149717d, y: 0.7779885293230098d), new NpgsqlTypes.NpgsqlPoint(x: 0.23039112951567342d, y: 0.47062019991942794d), new NpgsqlTypes.NpgsqlPoint(x: 0.47909670138901195d, y: 0.8928855128250417d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07605107532011102d, y: 0.6861905382804576d), new NpgsqlTypes.NpgsqlPoint(x: 0.994716102546858d, y: 0.12400329209319638d), new NpgsqlTypes.NpgsqlPoint(x: 0.3795445790287446d, y: 0.3485346485457024d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5488620423662387d, y: 0.09782277163532438d), new NpgsqlTypes.NpgsqlPoint(x: 0.8609888694267691d, y: 0.7590376989512835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8602858747015854d, y: 0.2723260854046591d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9214929827691498d, y: 0.11419764174106906d), new NpgsqlTypes.NpgsqlPoint(x: 0.911568920619228d, y: 0.6644864495702695d), new NpgsqlTypes.NpgsqlPoint(x: 0.16145127700484674d, y: 0.7303215072880763d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11429572488908035d, y: 0.684364225202713d), new NpgsqlTypes.NpgsqlPoint(x: 0.8299551060205356d, y: 0.178473094862873d), new NpgsqlTypes.NpgsqlPoint(x: 0.08249447237246144d, y: 0.45945997301901575d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16282139364080617d, y: 0.4354077382212128d), new NpgsqlTypes.NpgsqlPoint(x: 0.7314316528916186d, y: 0.3825497049852936d), new NpgsqlTypes.NpgsqlPoint(x: 0.524011555924891d, y: 0.5505445774778062d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3122510399300371d, y: 0.6604804602650904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6591035364255999d, y: 0.19777055069985272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8075705080523955d, y: 0.3206187851839152d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3638839815354422d, y: 0.5760334789125231d), new NpgsqlTypes.NpgsqlPoint(x: 0.4004007114976613d, y: 0.05480742314926268d), new NpgsqlTypes.NpgsqlPoint(x: 0.22705654498247363d, y: 0.8599124625639415d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6864581517577374d, y: 0.8230010750253468d), new NpgsqlTypes.NpgsqlPoint(x: 0.7061230923789742d, y: 0.43264981504010247d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979997302345718d, y: 0.5631252459604553d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9987808531518122d, y: 0.3080839438203218d), new NpgsqlTypes.NpgsqlPoint(x: 0.6939728442836947d, y: 0.1987595177450565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5561824672327688d, y: 0.20526278175870794d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5618838231901798d, y: 0.1849592146977479d), new NpgsqlTypes.NpgsqlPoint(x: 0.727744893430374d, y: 0.13834496107765393d), new NpgsqlTypes.NpgsqlPoint(x: 0.39275750214155847d, y: 0.31384397024699895d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.298840627429228d, y: 0.37265713098926023d), new NpgsqlTypes.NpgsqlPoint(x: 0.027176617929986047d, y: 0.34883826155247866d), new NpgsqlTypes.NpgsqlPoint(x: 0.12248977670560246d, y: 0.21323624199901858d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9609655363229386d, y: 0.3729801577480911d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973100982668599d, y: 0.2658461422335725d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136965277855963d, y: 0.16735166734734497d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7602303518106612d, y: 0.7954328608998984d), new NpgsqlTypes.NpgsqlPoint(x: 0.9890982365229002d, y: 0.6642396530966073d), new NpgsqlTypes.NpgsqlPoint(x: 0.023177925569860314d, y: 0.15940239975170156d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3580235818246893d, y: 0.7671651878721509d), new NpgsqlTypes.NpgsqlPoint(x: 0.5287379425235368d, y: 0.6359838918990491d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880856187229556d, y: 0.369227325628424d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8128293904051193d, y: 0.9131147808448067d), new NpgsqlTypes.NpgsqlPoint(x: 0.4323695661051279d, y: 0.06371831984521159d), new NpgsqlTypes.NpgsqlPoint(x: 0.21575197257748824d, y: 0.9592475417190237d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6421932429821972d, y: 0.196227035802776d), new NpgsqlTypes.NpgsqlPoint(x: 0.3100007624426906d, y: 0.30359820372762825d), new NpgsqlTypes.NpgsqlPoint(x: 0.9869267018217154d, y: 0.9326260037781559d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5087889949363982d, y: 0.4360656110498411d), new NpgsqlTypes.NpgsqlPoint(x: 0.49314451981686547d, y: 0.9218792780784592d), new NpgsqlTypes.NpgsqlPoint(x: 0.6764334384836062d, y: 0.799301337733792d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3842425426107755d, y: 0.40673913573896436d), new NpgsqlTypes.NpgsqlPoint(x: 0.3394381117660552d, y: 0.894527065337616d), new NpgsqlTypes.NpgsqlPoint(x: 0.4451067634762398d, y: 0.7212810095523942d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4004374775955051d, y: 0.6820853200481305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802447349763378d, y: 0.7966771633387941d), new NpgsqlTypes.NpgsqlPoint(x: 0.6615415554281686d, y: 0.49948267501263854d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6779704139474368d, y: 0.8805536665822506d), new NpgsqlTypes.NpgsqlPoint(x: 0.11817715578142751d, y: 0.4036955347052832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8235374072702321d, y: 0.608156022113821d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44534391647242266d, y: 0.7630544820236158d), new NpgsqlTypes.NpgsqlPoint(x: 0.11834416299861417d, y: 0.5279626831874011d), new NpgsqlTypes.NpgsqlPoint(x: 0.021750186789381787d, y: 0.9091722588296222d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.906618790029835d, y: 0.3244757138209635d), new NpgsqlTypes.NpgsqlPoint(x: 0.10445208718994659d, y: 0.3406857705459413d), new NpgsqlTypes.NpgsqlPoint(x: 0.6673188589368623d, y: 0.7019596595326212d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1614212016368688d, y: 0.9749345080475896d), new NpgsqlTypes.NpgsqlPoint(x: 0.29626030166080575d, y: 0.09159248753498461d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752702481182211d, y: 0.5388013592156994d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4344763471820172d, y: 0.41788457253404443d), new NpgsqlTypes.NpgsqlPoint(x: 0.09442453807880391d, y: 0.016526189988221307d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725138898735671d, y: 0.24605439816434793d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.026991834748715804d, y: 0.7640452624358899d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243338139337578d, y: 0.1741662179557365d), new NpgsqlTypes.NpgsqlPoint(x: 0.8052604358789793d, y: 0.004737630075837385d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15143220459309392d, y: 0.5545227734028703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8836115603076738d, y: 0.9545365815090475d), new NpgsqlTypes.NpgsqlPoint(x: 0.31819080851381d, y: 0.011469754075341565d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3229923931351856d, y: 0.022596363956842613d), new NpgsqlTypes.NpgsqlPoint(x: 0.7005454635558666d, y: 0.003452469241608136d), new NpgsqlTypes.NpgsqlPoint(x: 0.4550020835741102d, y: 0.3426928662298636d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3836118968972355d, y: 0.6226500518376082d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134549817639432d, y: 0.49259672485630324d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381300566567743d, y: 0.7515984064094017d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5753793423096557d, y: 0.4065909185416968d), new NpgsqlTypes.NpgsqlPoint(x: 0.09451866539224563d, y: 0.11897790821566023d), new NpgsqlTypes.NpgsqlPoint(x: 0.34181836917214115d, y: 0.4906625995910373d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6611910177765921d, y: 0.4735658521432867d), new NpgsqlTypes.NpgsqlPoint(x: 0.643705519021953d, y: 0.7948769892095866d), new NpgsqlTypes.NpgsqlPoint(x: 0.2532366533199407d, y: 0.46009518027504803d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25529549507304494d, y: 0.9582550574868105d), new NpgsqlTypes.NpgsqlPoint(x: 0.2508829157087846d, y: 0.8578053518913076d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489656224370227d, y: 0.6742064994307411d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8614852300353452d, y: 0.7470906669783615d), new NpgsqlTypes.NpgsqlPoint(x: 0.4277429183573358d, y: 0.11086215756521112d), new NpgsqlTypes.NpgsqlPoint(x: 0.33068402012478604d, y: 0.9721770887986133d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41696645262336274d, y: 0.6695933387919472d), new NpgsqlTypes.NpgsqlPoint(x: 0.2923761248884903d, y: 0.8424419186763971d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046881395274524d, y: 0.015461767944910387d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7023602399075567d, y: 0.12657575919838837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8659450092674373d, y: 0.8215532193457974d), new NpgsqlTypes.NpgsqlPoint(x: 0.3153543849621261d, y: 0.7879353002891418d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8131908969459165d, y: 0.21300381390531353d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294689469595317d, y: 0.5140429444727793d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317024718333026d, y: 0.629774600193719d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.027981773683644184d, y: 0.959649646893557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7613653110251267d, y: 0.43743318714392854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5904436033709001d, y: 0.7807734871943082d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21578898856997974d, y: 0.12102824958355618d), new NpgsqlTypes.NpgsqlPoint(x: 0.853365823400819d, y: 0.049535875080785274d), new NpgsqlTypes.NpgsqlPoint(x: 0.25628105924576206d, y: 0.6318804996038329d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01906063578886774d, y: 0.9479091258085811d), new NpgsqlTypes.NpgsqlPoint(x: 0.8323216483475512d, y: 0.8225402294241082d), new NpgsqlTypes.NpgsqlPoint(x: 0.1366185314498528d, y: 0.4177880558177378d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.044256183486576006d, y: 0.4550032875255312d), new NpgsqlTypes.NpgsqlPoint(x: 0.19737973408294507d, y: 0.855658848254574d), new NpgsqlTypes.NpgsqlPoint(x: 0.3325761413915337d, y: 0.488504109879512d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8368952222061362d, y: 0.805458767296307d), new NpgsqlTypes.NpgsqlPoint(x: 0.40088422488347153d, y: 0.11977501081305697d), new NpgsqlTypes.NpgsqlPoint(x: 0.19216591384850346d, y: 0.7692139188180045d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45718833176418616d, y: 0.38937553176682804d), new NpgsqlTypes.NpgsqlPoint(x: 0.7948269657280325d, y: 0.22247806990690056d), new NpgsqlTypes.NpgsqlPoint(x: 0.47173327874494553d, y: 0.5062178646689016d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.87153735370617d, y: 0.05898801514481433d), new NpgsqlTypes.NpgsqlPoint(x: 0.2579265923433911d, y: 0.32251456824616365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5877265963210854d, y: 0.7006728855529355d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5027651683609957d, y: 0.6173023500865819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8319857758501416d, y: 0.6617506954174122d), new NpgsqlTypes.NpgsqlPoint(x: 0.9462205174773443d, y: 0.9883438936124964d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9380730976673527d, y: 0.49658202401716334d), new NpgsqlTypes.NpgsqlPoint(x: 0.0436243323878418d, y: 0.3049913613345522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9095270130708252d, y: 0.4257709872377323d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8871633961938444d, y: 0.3799842317563292d), new NpgsqlTypes.NpgsqlPoint(x: 0.8161961264807366d, y: 0.8187285547235725d), new NpgsqlTypes.NpgsqlPoint(x: 0.07709707201023241d, y: 0.4658761523142868d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8135507588755261d, y: 0.5221128274194676d), new NpgsqlTypes.NpgsqlPoint(x: 0.23821084744075294d, y: 0.06816271508931493d), new NpgsqlTypes.NpgsqlPoint(x: 0.2652628752236942d, y: 0.6572608226115472d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49580399542529385d, y: 0.19264819814558654d), new NpgsqlTypes.NpgsqlPoint(x: 0.1783345236108893d, y: 0.58329842662222d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099528810598227d, y: 0.38904851313570754d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19794715655773243d, y: 0.4895503604570737d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443559627048322d, y: 0.02994306911586897d), new NpgsqlTypes.NpgsqlPoint(x: 0.22116733024800195d, y: 0.1989489004800724d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7279295642897234d, y: 0.9333500939662706d), new NpgsqlTypes.NpgsqlPoint(x: 0.29595038015589037d, y: 0.03089863806666493d), new NpgsqlTypes.NpgsqlPoint(x: 0.013942801496349744d, y: 0.15457896987117925d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23386193490080964d, y: 0.717196861401935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358538423334066d, y: 0.7276762127913218d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464144004402711d, y: 0.20713137394021675d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8961243747045995d, y: 0.206522306661162d), new NpgsqlTypes.NpgsqlPoint(x: 0.9584863525386834d, y: 0.21263809372524745d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687475193461494d, y: 0.8072928313052126d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4545022138191682d, y: 0.7851726966743875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7471762908056404d, y: 0.6387855210732654d), new NpgsqlTypes.NpgsqlPoint(x: 0.1014805926788559d, y: 0.9470103296775016d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7051810774448172d, y: 0.9834473679234658d), new NpgsqlTypes.NpgsqlPoint(x: 0.3253804272005868d, y: 0.21259529296089996d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311594758710988d, y: 0.6790843625208581d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2534444695892857d, y: 0.7801958513040879d), new NpgsqlTypes.NpgsqlPoint(x: 0.4003969872600377d, y: 0.5174797332087078d), new NpgsqlTypes.NpgsqlPoint(x: 0.22552116258979316d, y: 0.7925540295664656d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13702953297389908d, y: 0.14996987060030165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485213015329689d, y: 0.9377526200283404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579548782747244d, y: 0.11771859008986851d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9229790106160615d, y: 0.9486966852376891d), new NpgsqlTypes.NpgsqlPoint(x: 0.6109955916854026d, y: 0.5101355098575088d), new NpgsqlTypes.NpgsqlPoint(x: 0.024011424958548466d, y: 0.2895103921286515d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11508936433025263d, y: 0.04436803202157347d), new NpgsqlTypes.NpgsqlPoint(x: 0.36551026046721136d, y: 0.22870788579121337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6660588620082355d, y: 0.5254267468317205d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7542790420734368d, y: 0.1638671689306922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5511057081583663d, y: 0.5187128257368054d), new NpgsqlTypes.NpgsqlPoint(x: 0.008471092911028433d, y: 0.06791216562502389d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18495626766177897d, y: 0.1563257399856054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869192818793182d, y: 0.5622369346524567d), new NpgsqlTypes.NpgsqlPoint(x: 0.13612625592241945d, y: 0.44430765833452956d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1944792315906141d, y: 0.3906201067547822d), new NpgsqlTypes.NpgsqlPoint(x: 0.7155812931200238d, y: 0.5832198240201356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6449793276303386d, y: 0.5236464961920213d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13451536175933254d, y: 0.22331062253416922d), new NpgsqlTypes.NpgsqlPoint(x: 0.647898236672526d, y: 0.35561866841621514d), new NpgsqlTypes.NpgsqlPoint(x: 0.7111188791985338d, y: 0.279604237789721d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9972713194798346d, y: 0.23533391313797458d), new NpgsqlTypes.NpgsqlPoint(x: 0.23466338451741464d, y: 0.009070180679232376d), new NpgsqlTypes.NpgsqlPoint(x: 0.588638067218882d, y: 0.7684492564794102d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49029838334595477d, y: 0.7576342365589468d), new NpgsqlTypes.NpgsqlPoint(x: 0.766316912731231d, y: 0.7730754239696134d), new NpgsqlTypes.NpgsqlPoint(x: 0.21467046073645746d, y: 0.1570566947496176d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6406112014985637d, y: 0.8160798969474814d), new NpgsqlTypes.NpgsqlPoint(x: 0.9565190486834151d, y: 0.5893028384098067d), new NpgsqlTypes.NpgsqlPoint(x: 0.9725866421943659d, y: 0.5240215396638449d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6161615777806408d, y: 0.41350788451782583d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940583149803972d, y: 0.9711531454013952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9237667288741507d, y: 0.3711308606403887d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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

                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPolygonListpolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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

                var models = await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[29], false);
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

                var models =  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 138, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 44, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelBatchAsync(connection, 46, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[29], false);
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
                var models =  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelBatch(connection, 14, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[2], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[3], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[2], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[3], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonListpolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2M>(15);

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
                ((INpgsqlPolygonListpolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

