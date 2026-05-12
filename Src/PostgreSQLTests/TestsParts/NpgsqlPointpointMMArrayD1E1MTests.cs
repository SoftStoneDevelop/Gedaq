

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
    internal partial interface INpgsqlPointMArraypointMMArrayD1
    {
    }
    
    internal partial class NpgsqlPointMArraypointMMArrayD1 : INpgsqlPointMArraypointMMArrayD1
    {


#region TestData

        private readonly NpgsqlPointpointMMArrayD1E1M[] _testData = new NpgsqlPointpointMMArrayD1E1M[]
        {
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31412015437635366d, y: 0.1531402859191363d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3517940699634239d, y: 0.46305658444412445d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5097649464073477d, y: 0.947223078425698d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9350372804299504d, y: 0.6975046493488561d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8271627666720537d, y: 0.663930309090025d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9883986357895894d, y: 0.2697337744746887d),
new NpgsqlTypes.NpgsqlPoint(x: 0.950409518252372d, y: 0.5921336391236677d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5925249689064713d, y: 0.01734234819006064d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0925735678693731d, y: 0.8696572496786811d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2379320249345147d, y: 0.5621905751030063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10454386489668233d, y: 0.9524951267085817d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.546694845041107d, y: 0.46454916401896207d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9075063495479481d, y: 0.5587325295101143d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2868617103662934d, y: 0.5711872956205813d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06983203604358679d, y: 0.2716315962418554d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2859593316740118d, y: 0.9955407862573279d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7831446948508789d, y: 0.5024099675759937d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04324244982291925d, y: 0.41947541215298545d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04248632140986952d, y: 0.2525479122612886d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30288688098120453d, y: 0.3687643080189208d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16909368322808038d, y: 0.6489252521194583d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38724240556216405d, y: 0.4035626804514132d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07283236374360991d, y: 0.8983393253622586d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4371232788369369d, y: 0.8063645530714613d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6507943031149405d, y: 0.6662930038317436d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03327495715319084d, y: 0.6568674082966363d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25013298641636417d, y: 0.1627283001656349d),
new NpgsqlTypes.NpgsqlPoint(x: 0.477201835586872d, y: 0.8919358384131267d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4907657676170136d, y: 0.6946142069213704d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26824953288933717d, y: 0.6548539745433488d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2863919707810456d, y: 0.591328727243443d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3239005617738331d, y: 0.22086047137110842d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7191949293518158d, y: 0.6086664525127913d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6448121250271273d, y: 0.9996089735415935d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9511066997096567d, y: 0.15697043443359548d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6932320341983587d, y: 0.3476118895236707d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8204353600742089d, y: 0.1709006186906451d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6416723329391949d, y: 0.8570316964976934d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0035513725346326686d, y: 0.9779950687771752d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9742019453283165d, y: 0.8594871057165485d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1435204491253418d, y: 0.12124999646588208d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7815219645768154d, y: 0.9777706718762228d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6623610541175955d, y: 0.26219530376868194d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7817145632435093d, y: 0.42047954118425024d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2888234125846263d, y: 0.7226946568735957d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6997830394584841d, y: 0.7090937081936632d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8515869425624583d, y: 0.6859336588000197d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2910959532748084d, y: 0.3674806815564604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12455752123275199d, y: 0.8478556789259077d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0559741105253716d, y: 0.9147820447485815d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19235625706000936d, y: 0.676042454661905d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1991616305337225d, y: 0.5561483304815775d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5430732549060995d, y: 0.9328728880051225d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1116861685277627d, y: 0.27816918522942446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9009483534312299d, y: 0.16972233281538684d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35832615666933765d, y: 0.4870630355615809d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6961904128730595d, y: 0.7157623735100612d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5168369003825304d, y: 0.45712953025716174d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8576277127700325d, y: 0.10382428811991407d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3829664790379055d, y: 0.2311710276229011d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6306362251453798d, y: 0.730852725302905d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9857254555071125d, y: 0.7787213608718413d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8322185810001469d, y: 0.9165927718737612d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7970229616307505d, y: 0.7404591312019541d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05624982290547709d, y: 0.32000534508112644d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41867830770453385d, y: 0.3908992799281322d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9553461199847273d, y: 0.1166844327156985d),
new NpgsqlTypes.NpgsqlPoint(x: 0.343413772605341d, y: 0.4465646563088338d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16449886744309228d, y: 0.9110374693685975d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31571048050809847d, y: 0.608760352470868d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20138405743391585d, y: 0.5970775273098602d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8518854203958987d, y: 0.810229383340511d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8614372976566609d, y: 0.6798763162483503d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8985551360431302d, y: 0.2840436582687952d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5371608197804091d, y: 0.07320194301746341d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9180566042975903d, y: 0.3689496541896128d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5969653011947372d, y: 0.2333207324631399d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3189815682086764d, y: 0.9433617179162598d),
new NpgsqlTypes.NpgsqlPoint(x: 0.411738805422595d, y: 0.14577093001902597d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8645362476776152d, y: 0.6218307634325703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8742255319371096d, y: 0.2311810967396425d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6774408450030394d, y: 0.041400952375599265d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23946512923242413d, y: 0.09577134629479045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.552966195356761d, y: 0.7481364050125691d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07965492974504873d, y: 0.16856036095933402d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2354449333499683d, y: 0.4400045546776845d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6807622276170504d, y: 0.18490886623067115d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7871498887933068d, y: 0.006532423740296611d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5187044281100366d, y: 0.9231537031948777d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42060022109970496d, y: 0.9432011849200566d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5731380204929539d, y: 0.9922813980388228d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16321118925453715d, y: 0.802637549974502d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5264922091786992d, y: 0.9161747561968796d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9669232480387213d, y: 0.8846929299903323d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7787099439873572d, y: 0.9889315420588085d),
new NpgsqlTypes.NpgsqlPoint(x: 0.059557791470879695d, y: 0.08671576298203065d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8813093373104931d, y: 0.7487382957416051d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8624036750531119d, y: 0.09614709948477185d),
new NpgsqlTypes.NpgsqlPoint(x: 0.837526497501108d, y: 0.26348694539289164d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7338248622118585d, y: 0.4354492374715472d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9061740126841029d, y: 0.29852160177839093d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47820873722721435d, y: 0.8717843876738051d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45033764729898906d, y: 0.7880587439615854d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6500972125692107d, y: 0.488227562862788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6756857114973418d, y: 0.34191596970018767d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25732655988542896d, y: 0.6557921372701221d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34042154579480977d, y: 0.17689466779198693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42340100337483133d, y: 0.6195422738292788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5803486842034178d, y: 0.13563318184409656d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8529746764012854d, y: 0.8931414744276849d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8185858237385153d, y: 0.4561101946757795d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9660788882087644d, y: 0.47817155083671725d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03431504855142531d, y: 0.7199196330174132d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7700344160211128d, y: 0.6182657763924801d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4376758414944081d, y: 0.04818650495120491d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25191537884489323d, y: 0.8307167543543881d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16908493887426046d, y: 0.27612795195918627d),
new NpgsqlTypes.NpgsqlPoint(x: 0.735253985204998d, y: 0.7820430490385327d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5237495084152901d, y: 0.15513155508155463d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2778906301179098d, y: 0.4862071333778101d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4321279393704647d, y: 0.5399242871580432d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32691805214535963d, y: 0.5157377128581989d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22045473328055898d, y: 0.6554099600651454d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6236351230360231d, y: 0.8867473985670768d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06218020378869671d, y: 0.25844794003892835d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1551912689405407d, y: 0.6414336922852045d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22325722097372647d, y: 0.7893857276566354d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9137671737858876d, y: 0.972818467175031d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5256817102099832d, y: 0.5592198195684654d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21075236934701047d, y: 0.2521309849525245d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37634883318678836d, y: 0.1880308956388521d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4518206348996193d, y: 0.7347812251292672d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5929214061658676d, y: 0.8184171304177574d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02813562571061412d, y: 0.1507792452758857d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6943480950918752d, y: 0.2634029698769076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5178357716005668d, y: 0.6352418572277625d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8893520219325421d, y: 0.6620155031720428d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6233386701726769d, y: 0.2887777935877305d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05277513656940647d, y: 0.020903238687814185d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5492028283350663d, y: 0.9133174812671627d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.800022148062656d, y: 0.3546531313443956d),
new NpgsqlTypes.NpgsqlPoint(x: 0.79020467096956d, y: 0.12444986302351202d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3849707159267899d, y: 0.3227731432501665d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17967753455804814d, y: 0.7016374075124832d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4575005839519213d, y: 0.22819722681114218d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5873567874207172d, y: 0.2939713522035493d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4825159949613115d, y: 0.3751790697258708d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2403272179868623d, y: 0.5067064684054009d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04119343269686615d, y: 0.31882112543856433d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7633625662906143d, y: 0.05602893114408314d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14262779509154755d, y: 0.9010672588571236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43716949456518006d, y: 0.02902279263089036d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9336537161197098d, y: 0.5730636245649304d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5901375848041128d, y: 0.12997007975364128d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8144832129507928d, y: 0.4451754574941468d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26692626387820184d, y: 0.5956843376085681d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8755586531494689d, y: 0.07204468494631022d),
new NpgsqlTypes.NpgsqlPoint(x: 0.035971687732352264d, y: 0.5940701161373828d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09500562004009705d, y: 0.4726787230063598d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28956008515415543d, y: 0.6274646025090376d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6945924136777452d, y: 0.8617144543497105d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09102827056975493d, y: 0.36128860525088835d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9562743250636071d, y: 0.17180485708058268d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0854080023070255d, y: 0.7013744840052972d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6071835580383681d, y: 0.1474614738941481d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7433455827694526d, y: 0.7932695239341223d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5204717390131167d, y: 0.011591702799502501d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03923253862955778d, y: 0.06488258777325828d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14811543394046578d, y: 0.4417364968547923d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6531497244573083d, y: 0.3707495937248665d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9469127605947161d, y: 0.1124465019735863d),
new NpgsqlTypes.NpgsqlPoint(x: 0.024199887253004704d, y: 0.22327118124986822d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.620094168367627d, y: 0.6241597958337447d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23701682601223006d, y: 0.624819250582914d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6780238023719115d, y: 0.22430565915818534d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5308229837139381d, y: 0.13994327623647196d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47213382809414306d, y: 0.10178664381179836d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8112361302337385d, y: 0.3738209221087563d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5025804047252888d, y: 0.523094651784436d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5181710532459853d, y: 0.00103868218533254d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17248955009144484d, y: 0.4796264577513131d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2600301132637457d, y: 0.1971088920924836d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8902587989820622d, y: 0.6293126840368464d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4452816190749245d, y: 0.5026821503634439d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02348232371280634d, y: 0.06223254927732269d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9944671042103669d, y: 0.09527130367393277d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2880808064762289d, y: 0.0557311451937782d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8739802534526648d, y: 0.8533692424963417d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7708157189968396d, y: 0.6986088500429073d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.266481698670891d, y: 0.8342902319003386d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7266434529620632d, y: 0.6027012043927241d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13895346704651024d, y: 0.9954071083672068d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36005849386899147d, y: 0.7595519053626613d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5445910835251738d, y: 0.1570957357100612d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39542364664139673d, y: 0.9864047298575146d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2192289067722477d, y: 0.4086125318260906d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8711522297125655d, y: 0.5009414831914837d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3483823766808518d, y: 0.8960667432762276d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5345709245152983d, y: 0.6705173263693742d),
new NpgsqlTypes.NpgsqlPoint(x: 0.820702006908764d, y: 0.3989130080258999d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3244175760993886d, y: 0.6237901815428414d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8657168568407709d, y: 0.08799029587624607d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49056393944101806d, y: 0.4140418711306364d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12595860801787329d, y: 0.31330082093555334d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22988470210148637d, y: 0.7154738481940657d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7770078699999295d, y: 0.0022788928373135287d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30628099425530464d, y: 0.09264778352433423d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7644172314965918d, y: 0.2912280848458705d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06900656501231517d, y: 0.0995044131759657d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1919735437952783d, y: 0.29099143944902695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4491366649740428d, y: 0.7100676419954776d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30339125095203157d, y: 0.20808436646670492d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7751177039932984d, y: 0.6361195760474737d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40159425113393177d, y: 0.9554551209668216d),
new NpgsqlTypes.NpgsqlPoint(x: 0.899799834580615d, y: 0.7093719033875304d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6549639733064735d, y: 0.9754547674725399d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7919729614762454d, y: 0.17631555153114986d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.426543521685118d, y: 0.9506360761036244d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4876303660509148d, y: 0.4009893080400987d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8629080015071925d, y: 0.3963180614969922d),
new NpgsqlTypes.NpgsqlPoint(x: 0.01738825486119444d, y: 0.10203121867940601d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6466288775976521d, y: 0.8483743268356841d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9615616751066234d, y: 0.6848523992589122d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9788535454533486d, y: 0.5191499308499122d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5484268396377885d, y: 0.45768093252743824d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2607788871637948d, y: 0.4519372776025502d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8469476544204944d, y: 0.16361149076401615d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9610633142221955d, y: 0.2647351531122244d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2200138382033343d, y: 0.4973213038667331d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0452018590382538d, y: 0.0146671133450198d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9022363750869598d, y: 0.5353490465056987d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6498791911145988d, y: 0.1899593745465833d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9169574920872499d, y: 0.8578163495310255d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8164400245563402d, y: 0.19010635063471792d),
new NpgsqlTypes.NpgsqlPoint(x: 0.784228403944484d, y: 0.15625164270662972d),
new NpgsqlTypes.NpgsqlPoint(x: 0.969254715357084d, y: 0.010617881035230536d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5434262312667253d, y: 0.8586232021264356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4632949715100094d, y: 0.552639192071424d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5774772915160237d, y: 0.6937311157980606d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48549658163386866d, y: 0.9554512603885249d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5488087586537987d, y: 0.49948045543203d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9077863974300576d, y: 0.403180583673056d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21278979917227003d, y: 0.7726720864644976d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8275497579330726d, y: 0.5092571395027787d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8309593657201185d, y: 0.767057242692288d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8180904850334382d, y: 0.6504538017802115d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9080342539010261d, y: 0.38009445042341494d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8089821336107537d, y: 0.17571882514463633d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6324572928304499d, y: 0.004925311079183259d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2563139345698475d, y: 0.9058483982449218d),
new NpgsqlTypes.NpgsqlPoint(x: 0.384606764021993d, y: 0.1307308016213221d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8343642977922985d, y: 0.9549209007937992d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5314476381435023d, y: 0.5507225105734469d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49000490120468887d, y: 0.5576240628262801d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9729920562869212d, y: 0.462509280768049d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39479397003110017d, y: 0.14713768252935977d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07319293334684773d, y: 0.608861669845344d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9976820384508983d, y: 0.4317566974804733d),
new NpgsqlTypes.NpgsqlPoint(x: 0.594665804174794d, y: 0.22694386057016847d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7915673327626751d, y: 0.7933231401358164d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34851703288629754d, y: 0.8009477901598572d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9921510975045629d, y: 0.24685409371623201d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7838502105777531d, y: 0.27881510557481726d),
new NpgsqlTypes.NpgsqlPoint(x: 0.027519886601426347d, y: 0.30687148772529704d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3307417945160118d, y: 0.06459756096419411d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6558996867277264d, y: 0.5811490975892063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2657489488916214d, y: 0.7269438309401185d),
new NpgsqlTypes.NpgsqlPoint(x: 0.775188838562752d, y: 0.8481182601393561d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9992379546815192d, y: 0.5271419591893004d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6450076198470371d, y: 0.15016759919252975d),
new NpgsqlTypes.NpgsqlPoint(x: 0.045694592681853274d, y: 0.23474602191159832d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8685798395335352d, y: 0.6003894798267471d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5279757349425741d, y: 0.4928833798255047d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4553515525371855d, y: 0.790014613492309d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12887690575862953d, y: 0.6811828567769546d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11383873599885719d, y: 0.926590336865569d),
new NpgsqlTypes.NpgsqlPoint(x: 0.903540076160669d, y: 0.8482084727538343d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6229724367017079d, y: 0.3115227323669969d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 178,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1897650429718386d, y: 0.24622690401804115d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4305280168948875d, y: 0.5834885107415158d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4008144215585082d, y: 0.19783063968226167d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8565465776099277d, y: 0.8006064384568048d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06562025491870194d, y: 0.39686912334172764d),
new NpgsqlTypes.NpgsqlPoint(x: 0.529864753368161d, y: 0.5458006556594047d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4905213650339565d, y: 0.45796279986805366d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1361281984463979d, y: 0.41192040603908764d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd1e1mi_id
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
    npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6961904128730595d, y: 0.7157623735100612d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5168369003825304d, y: 0.45712953025716174d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8576277127700325d, y: 0.10382428811991407d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd1e1mi_id
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
    npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8985551360431302d, y: 0.2840436582687952d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5371608197804091d, y: 0.07320194301746341d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9180566042975903d, y: 0.3689496541896128d),
}));
                nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23946512923242413d, y: 0.09577134629479045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.552966195356761d, y: 0.7481364050125691d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07965492974504873d, y: 0.16856036095933402d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42060022109970496d, y: 0.9432011849200566d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5731380204929539d, y: 0.9922813980388228d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16321118925453715d, y: 0.802637549974502d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5264922091786992d, y: 0.9161747561968796d),
}));
                nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45033764729898906d, y: 0.7880587439615854d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6500972125692107d, y: 0.488227562862788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6756857114973418d, y: 0.34191596970018767d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25732655988542896d, y: 0.6557921372701221d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD1E1M> models = null;

                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD1E1M> models = null;

                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 82;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 136;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 145, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 136, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 77, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 136, query1, 159, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 84, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 68, query1, 14, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 23, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 8, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 160, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointMArraypointMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointMArraypointMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 168);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointMArraypointMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointMArraypointMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models =  ((INpgsqlPointMArraypointMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
FROM public.binary_npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointMArraypointMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA), typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA), typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI), typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA), typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

