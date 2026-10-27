

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

        private readonly NpgsqlPathpathE0M[] _testData = new NpgsqlPathpathE0M[]
        {
            new NpgsqlPathpathE0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10595486666365672d, y: 0.596797538336435d), new NpgsqlTypes.NpgsqlPoint(x: 0.11957578057079798d, y: 0.348707283476577d), new NpgsqlTypes.NpgsqlPoint(x: 0.37645346047569783d, y: 0.14393603021847523d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.767857247596653d, y: 0.2730554475677822d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837494900110853d, y: 0.5896524444140866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677348692761505d, y: 0.4882000083741693d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5022681970205043d, y: 0.05300250314863586d), new NpgsqlTypes.NpgsqlPoint(x: 0.17601638306942147d, y: 0.6726674199211428d), new NpgsqlTypes.NpgsqlPoint(x: 0.2413962814751408d, y: 0.10679038498941784d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6821266557621579d, y: 0.6291618476585025d), new NpgsqlTypes.NpgsqlPoint(x: 0.00987819656066835d, y: 0.340405070473049d), new NpgsqlTypes.NpgsqlPoint(x: 0.9135389324846254d, y: 0.23777369184539165d)),
},
            new NpgsqlPathpathE0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20212626805838307d, y: 0.8183803897869469d), new NpgsqlTypes.NpgsqlPoint(x: 0.8296501472744447d, y: 0.6850215708403095d), new NpgsqlTypes.NpgsqlPoint(x: 0.06656934746245557d, y: 0.46297637064917885d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9938208581723625d, y: 0.0995567508293379d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086460477478254d, y: 0.5048533858935227d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719223805263479d, y: 0.5398628498549601d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7763206681522459d, y: 0.3167534265651294d), new NpgsqlTypes.NpgsqlPoint(x: 0.15604254454235966d, y: 0.9852671463372591d), new NpgsqlTypes.NpgsqlPoint(x: 0.9994126279393222d, y: 0.38761066814253453d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29625707582453686d, y: 0.6816702036015013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350202867003886d, y: 0.778960437485659d), new NpgsqlTypes.NpgsqlPoint(x: 0.354827386703902d, y: 0.16809060333287507d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20982146233916465d, y: 0.9664397456216006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550297481575536d, y: 0.4859300999827777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7215338261749726d, y: 0.637883738303157d)),
},
            new NpgsqlPathpathE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11802109686491369d, y: 0.39646449087557656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670522011893776d, y: 0.23024020506846077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428863630202885d, y: 0.471332900556666d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8048977230787804d, y: 0.34532902416424505d), new NpgsqlTypes.NpgsqlPoint(x: 0.31868704726886576d, y: 0.012176329408673192d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315291398508351d, y: 0.5945366786642188d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7708827366081586d, y: 0.5636312982527927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335397509917873d, y: 0.2874894158466057d), new NpgsqlTypes.NpgsqlPoint(x: 0.02745335384317682d, y: 0.13462554222813905d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222587364029452d, y: 0.7564851492645875d), new NpgsqlTypes.NpgsqlPoint(x: 0.3538666512494699d, y: 0.7402993863052184d), new NpgsqlTypes.NpgsqlPoint(x: 0.18080490862510645d, y: 0.635408271756414d)),
},
            new NpgsqlPathpathE0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02697274222621804d, y: 0.16846911726709757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599820478140835d, y: 0.10685728550910445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9494640411540229d, y: 0.2014914521094905d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40308224797330605d, y: 0.19428227615664007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303181261677661d, y: 0.7822016487575476d), new NpgsqlTypes.NpgsqlPoint(x: 0.42101111812364544d, y: 0.38267167282595016d)),
},
            new NpgsqlPathpathE0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4063325737132373d, y: 0.5297134353637029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455373057801755d, y: 0.87094168723406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874941406894292d, y: 0.35661045522987d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32380601021409205d, y: 0.09877804824593339d), new NpgsqlTypes.NpgsqlPoint(x: 0.15228303832227985d, y: 0.0575422185942398d), new NpgsqlTypes.NpgsqlPoint(x: 0.77535358736732d, y: 0.5342062096195725d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.704492360818477d, y: 0.9425032794906453d), new NpgsqlTypes.NpgsqlPoint(x: 0.0712045804956668d, y: 0.5135460544383212d), new NpgsqlTypes.NpgsqlPoint(x: 0.43139564457571034d, y: 0.3630191472331854d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15062246909000088d, y: 0.7213296246646148d), new NpgsqlTypes.NpgsqlPoint(x: 0.7958459567040859d, y: 0.9026257420894527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7977318664538633d, y: 0.4575303393386806d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07457373753584229d, y: 0.9705532469464726d), new NpgsqlTypes.NpgsqlPoint(x: 0.45530119440187455d, y: 0.76848593142605d), new NpgsqlTypes.NpgsqlPoint(x: 0.304236701135438d, y: 0.5030657752378984d)),
},
            new NpgsqlPathpathE0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35330356511225347d, y: 0.09578417947640461d), new NpgsqlTypes.NpgsqlPoint(x: 0.5035689323731442d, y: 0.9501112175759097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835326170841601d, y: 0.08463328434347295d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9009514251852095d, y: 0.7947085290512259d), new NpgsqlTypes.NpgsqlPoint(x: 0.42100668181654277d, y: 0.48215360391644857d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005863829636604256d, y: 0.09359461000499891d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8183928954648634d, y: 0.6612903008761182d), new NpgsqlTypes.NpgsqlPoint(x: 0.06098499813822611d, y: 0.36611725339289136d), new NpgsqlTypes.NpgsqlPoint(x: 0.44887065135435056d, y: 0.47366794317084504d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9357660224710183d, y: 0.023691222788592925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398198388818198d, y: 0.4263666408848271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8969918263339864d, y: 0.668824269371486d)),
},
            new NpgsqlPathpathE0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2655147930752626d, y: 0.27887161519910253d), new NpgsqlTypes.NpgsqlPoint(x: 0.39598668709350626d, y: 0.8266448045843601d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209889364503502d, y: 0.10896204503056117d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8271682231486178d, y: 0.37595361647793224d), new NpgsqlTypes.NpgsqlPoint(x: 0.7229635846405297d, y: 0.2312819785266278d), new NpgsqlTypes.NpgsqlPoint(x: 0.293710778341821d, y: 0.20821329675920341d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23360496246216733d, y: 0.849783437008871d), new NpgsqlTypes.NpgsqlPoint(x: 0.23678139734181103d, y: 0.3461112680277286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6089088663006196d, y: 0.8742243805538412d)),
},
            new NpgsqlPathpathE0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27845522644710186d, y: 0.2946096222646579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7113188724387108d, y: 0.21630639794006923d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468094981191738d, y: 0.389153263109691d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9626427489087844d, y: 0.1646903627714955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536925518027759d, y: 0.44975766737149625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4924674807909247d, y: 0.39181618545977126d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17923013185911518d, y: 0.0419399441902073d), new NpgsqlTypes.NpgsqlPoint(x: 0.21225306330111093d, y: 0.5783879084728293d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021097316811701d, y: 0.04161414052910739d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41525579673759183d, y: 0.7084697973634788d), new NpgsqlTypes.NpgsqlPoint(x: 0.48019604301520247d, y: 0.017526415688696173d), new NpgsqlTypes.NpgsqlPoint(x: 0.1344593844620886d, y: 0.4198957754648036d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24983193553967875d, y: 0.2881718438489348d), new NpgsqlTypes.NpgsqlPoint(x: 0.3721988239118149d, y: 0.1348366679445303d), new NpgsqlTypes.NpgsqlPoint(x: 0.45154836559086886d, y: 0.929118702932151d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7261292625148327d, y: 0.27359231254414995d), new NpgsqlTypes.NpgsqlPoint(x: 0.23925653657588097d, y: 0.4933387455204884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023839992048215d, y: 0.23285726204842094d)),
},
            new NpgsqlPathpathE0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7344170383196018d, y: 0.3929514505618732d), new NpgsqlTypes.NpgsqlPoint(x: 0.024775642015430477d, y: 0.14149274456452987d), new NpgsqlTypes.NpgsqlPoint(x: 0.2540227529345709d, y: 0.7632370945029822d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13783672994795193d, y: 0.686299249411211d), new NpgsqlTypes.NpgsqlPoint(x: 0.719153829091788d, y: 0.9339658324675625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217939018820076d, y: 0.5945068294668363d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7565544603454871d, y: 0.13277497705118468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827913632027755d, y: 0.6243420404703454d), new NpgsqlTypes.NpgsqlPoint(x: 0.2786346694470685d, y: 0.4344586973514196d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014947797167446208d, y: 0.7993768381633135d), new NpgsqlTypes.NpgsqlPoint(x: 0.732464702062584d, y: 0.3053049451807066d), new NpgsqlTypes.NpgsqlPoint(x: 0.49743251988242243d, y: 0.9912853170762063d)),
},
            new NpgsqlPathpathE0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34375055576202296d, y: 0.5108247961879602d), new NpgsqlTypes.NpgsqlPoint(x: 0.19144097605028942d, y: 0.6418589070286375d), new NpgsqlTypes.NpgsqlPoint(x: 0.06901685427564352d, y: 0.10105256850682143d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08735326605607141d, y: 0.2813119474483976d), new NpgsqlTypes.NpgsqlPoint(x: 0.18465863171520547d, y: 0.9475316137390413d), new NpgsqlTypes.NpgsqlPoint(x: 0.11732049389291488d, y: 0.4850246006593756d)),
},
            new NpgsqlPathpathE0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29438474176451246d, y: 0.10744209795479298d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993377602159073d, y: 0.4633064334623672d), new NpgsqlTypes.NpgsqlPoint(x: 0.026499403940449473d, y: 0.6443904841245022d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6340907779801086d, y: 0.9529921047308437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6551735715456983d, y: 0.9128051064629022d), new NpgsqlTypes.NpgsqlPoint(x: 0.10225140455484971d, y: 0.8822075857612761d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4277820957585816d, y: 0.3114938810495822d), new NpgsqlTypes.NpgsqlPoint(x: 0.27210028980993606d, y: 0.9828602812285421d), new NpgsqlTypes.NpgsqlPoint(x: 0.18562735602955382d, y: 0.5556075315401433d)),
},
            new NpgsqlPathpathE0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2384438254369029d, y: 0.6641913892735914d), new NpgsqlTypes.NpgsqlPoint(x: 0.7703324055157237d, y: 0.03065067336230476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6371784464102381d, y: 0.24472479150780058d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3475060045143188d, y: 0.03182165357624023d), new NpgsqlTypes.NpgsqlPoint(x: 0.48140171948016486d, y: 0.23687443493167404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6058137056001313d, y: 0.3977342244563776d)),
},
            new NpgsqlPathpathE0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8401116274186536d, y: 0.08160211874348844d), new NpgsqlTypes.NpgsqlPoint(x: 0.33519209789239623d, y: 0.20888053577360577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9670054701980431d, y: 0.6325505693102403d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9505277566384494d, y: 0.4696004066285221d), new NpgsqlTypes.NpgsqlPoint(x: 0.06907487691585534d, y: 0.34483444576055033d), new NpgsqlTypes.NpgsqlPoint(x: 0.025910042881916007d, y: 0.9683407153081085d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8833233041464623d, y: 0.1299092545014392d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562238874788721d, y: 0.8506230584996934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455415595778164d, y: 0.12327425642219947d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9769736836366814d, y: 0.7305841618640869d), new NpgsqlTypes.NpgsqlPoint(x: 0.3039578200007754d, y: 0.10623679683494269d), new NpgsqlTypes.NpgsqlPoint(x: 0.3533585055768642d, y: 0.9302715100837831d)),
},
            new NpgsqlPathpathE0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9385647127422821d, y: 0.6046318125147365d), new NpgsqlTypes.NpgsqlPoint(x: 0.676294914834733d, y: 0.7778837182744226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6046535149910536d, y: 0.7520610722098091d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4899700879286012d, y: 0.7149162179464678d), new NpgsqlTypes.NpgsqlPoint(x: 0.3428148524732588d, y: 0.38286064565362743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5599467323737582d, y: 0.45461569764772947d)),
},
            new NpgsqlPathpathE0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16837916388814633d, y: 0.7846817819190377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9541699784760358d, y: 0.5278264890197071d), new NpgsqlTypes.NpgsqlPoint(x: 0.2231956674635479d, y: 0.6798970956621094d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7858159306933046d, y: 0.40422575450576914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5426116646190782d, y: 0.02826213501735242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6090697914372619d, y: 0.03732432493469606d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3547802301159747d, y: 0.6310392116235707d), new NpgsqlTypes.NpgsqlPoint(x: 0.0969234892664983d, y: 0.32810798325551804d), new NpgsqlTypes.NpgsqlPoint(x: 0.15558513124467543d, y: 0.3257158014089986d)),
},
            new NpgsqlPathpathE0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20152256033344318d, y: 0.5513957176014237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205520080447809d, y: 0.5325937884428659d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371773108496862d, y: 0.7152015386666729d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.67078583538834d, y: 0.8848784113698376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211336005742534d, y: 0.5303593312612032d), new NpgsqlTypes.NpgsqlPoint(x: 0.4913372554689386d, y: 0.2590035684492381d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5435429529722138d, y: 0.19711454808347106d), new NpgsqlTypes.NpgsqlPoint(x: 0.46355389664124924d, y: 0.10732350234798149d), new NpgsqlTypes.NpgsqlPoint(x: 0.4628200803810161d, y: 0.49338313822839d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22083372500729948d, y: 0.8382567301402946d), new NpgsqlTypes.NpgsqlPoint(x: 0.7431205359719117d, y: 0.6809305733522508d), new NpgsqlTypes.NpgsqlPoint(x: 0.652863529015637d, y: 0.993977544088488d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8313765011203846d, y: 0.8968254263447062d), new NpgsqlTypes.NpgsqlPoint(x: 0.3733543206140456d, y: 0.19346942595015792d), new NpgsqlTypes.NpgsqlPoint(x: 0.79688327201112d, y: 0.9557214426978401d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06005250507261706d, y: 0.05963903709943419d), new NpgsqlTypes.NpgsqlPoint(x: 0.09274144657730055d, y: 0.41882216880811374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3673741818037167d, y: 0.8819503920405174d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2731427207644962d, y: 0.7439541848175277d), new NpgsqlTypes.NpgsqlPoint(x: 0.6409028873510069d, y: 0.2165521277384479d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739937558746239d, y: 0.1331752394465705d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07154047429101362d, y: 0.5693948388774379d), new NpgsqlTypes.NpgsqlPoint(x: 0.13226447642257277d, y: 0.8507355723663822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789344739447765d, y: 0.5824383593969834d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04930292424457472d, y: 0.4919499718341842d), new NpgsqlTypes.NpgsqlPoint(x: 0.554878280575539d, y: 0.5090996748125017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7877041583746434d, y: 0.18619102692970702d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40129249135156797d, y: 0.6757746219519373d), new NpgsqlTypes.NpgsqlPoint(x: 0.3206132576410615d, y: 0.21323052460794134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106131755183139d, y: 0.2821711710995951d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8700481445234793d, y: 0.2787297384508207d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025174560899665d, y: 0.82713592749682d), new NpgsqlTypes.NpgsqlPoint(x: 0.029738066789994577d, y: 0.19370123240679216d)),
},
            new NpgsqlPathpathE0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08584951113424633d, y: 0.42319916855234896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9080822456597112d, y: 0.48834573764889044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470922286574696d, y: 0.41839149503428996d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8468494270268578d, y: 0.6057507737282641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785720797974099d, y: 0.6514950537059245d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606527481120125d, y: 0.8538122653334093d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7585581799614934d, y: 0.8435116573036845d), new NpgsqlTypes.NpgsqlPoint(x: 0.21262002329269447d, y: 0.46018257772958315d), new NpgsqlTypes.NpgsqlPoint(x: 0.973448341923882d, y: 0.34158658673799613d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6004052113558499d, y: 0.295835987420381d), new NpgsqlTypes.NpgsqlPoint(x: 0.4854932965519193d, y: 0.2711560465956727d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867291466521255d, y: 0.386484294138302d)),
},
            new NpgsqlPathpathE0M
{
    Id = 172,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17120043567793997d, y: 0.33643585790207353d), new NpgsqlTypes.NpgsqlPoint(x: 0.4695511433329379d, y: 0.18214968709676627d), new NpgsqlTypes.NpgsqlPoint(x: 0.2325474686471921d, y: 0.1898951676661429d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8510303560579988d, y: 0.49677996799482127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5272303773359842d, y: 0.7212686731423967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481590615637173d, y: 0.7430111078622508d)),
},
            new NpgsqlPathpathE0M
{
    Id = 181,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8879940467700497d, y: 0.4713576079069858d), new NpgsqlTypes.NpgsqlPoint(x: 0.38627890642438945d, y: 0.1852766779336794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8030858252119752d, y: 0.7784934866196586d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4523197728691174d, y: 0.8696904725038642d), new NpgsqlTypes.NpgsqlPoint(x: 0.866935463734927d, y: 0.45276787146699204d), new NpgsqlTypes.NpgsqlPoint(x: 0.4947737101289851d, y: 0.9390912785948794d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4982683851002324d, y: 0.8173581024139784d), new NpgsqlTypes.NpgsqlPoint(x: 0.29262879827344956d, y: 0.27843977756136906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495970533209879d, y: 0.3928429540531141d)),
},
            new NpgsqlPathpathE0M
{
    Id = 188,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45206028198566006d, y: 0.07364366924120869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430011544298028d, y: 0.22746275775024372d), new NpgsqlTypes.NpgsqlPoint(x: 0.22315985464091126d, y: 0.21292894943735752d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 194,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0314680812103979d, y: 0.581507059446667d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434919120555305d, y: 0.12567696678557527d), new NpgsqlTypes.NpgsqlPoint(x: 0.6467423027947323d, y: 0.3330267031082518d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6346351611720742d, y: 0.18647058379839943d), new NpgsqlTypes.NpgsqlPoint(x: 0.06768454377801214d, y: 0.831296143043969d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766411863220747d, y: 0.21900504125058662d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.524427603779791d, y: 0.697280623375441d), new NpgsqlTypes.NpgsqlPoint(x: 0.3246817053607668d, y: 0.9851304739057399d), new NpgsqlTypes.NpgsqlPoint(x: 0.2409397092950537d, y: 0.3046736228138457d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5048673685175229d, y: 0.4548064655397497d), new NpgsqlTypes.NpgsqlPoint(x: 0.0477056016756775d, y: 0.2003441132151046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160346053886983d, y: 0.28980059622537924d)),
},
            new NpgsqlPathpathE0M
{
    Id = 196,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36460609958913737d, y: 0.02101472274299676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3534435489086505d, y: 0.00031808644667075114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926502502460288d, y: 0.36435286887109597d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
INSERT INTO public.npgsqlpathpathe0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
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
INSERT INTO public.npgsqlpathpathe0mi(
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
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222587364029452d, y: 0.7564851492645875d), new NpgsqlTypes.NpgsqlPoint(x: 0.3538666512494699d, y: 0.7402993863052184d), new NpgsqlTypes.NpgsqlPoint(x: 0.18080490862510645d, y: 0.635408271756414d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40308224797330605d, y: 0.19428227615664007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303181261677661d, y: 0.7822016487575476d), new NpgsqlTypes.NpgsqlPoint(x: 0.42101111812364544d, y: 0.38267167282595016d))));
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
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07457373753584229d, y: 0.9705532469464726d), new NpgsqlTypes.NpgsqlPoint(x: 0.45530119440187455d, y: 0.76848593142605d), new NpgsqlTypes.NpgsqlPoint(x: 0.304236701135438d, y: 0.5030657752378984d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9357660224710183d, y: 0.023691222788592925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398198388818198d, y: 0.4263666408848271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8969918263339864d, y: 0.668824269371486d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23360496246216733d, y: 0.849783437008871d), new NpgsqlTypes.NpgsqlPoint(x: 0.23678139734181103d, y: 0.3461112680277286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6089088663006196d, y: 0.8742243805538412d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpathe0mi_id
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
                parametrName: "npgsqlpathpathe0mi_id", 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
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
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 181;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 188;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
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
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 188;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[34], false);
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 188;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 172, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 53, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 8, query1, 181, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 159, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 70, query1, 154, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 118, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 30, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 181, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[31],_testData[34], false);
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 16, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[34], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 126);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
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
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10595486666365672d, y: 0.596797538336435d), new NpgsqlTypes.NpgsqlPoint(x: 0.11957578057079798d, y: 0.348707283476577d), new NpgsqlTypes.NpgsqlPoint(x: 0.37645346047569783d, y: 0.14393603021847523d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.767857247596653d, y: 0.2730554475677822d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837494900110853d, y: 0.5896524444140866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677348692761505d, y: 0.4882000083741693d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5022681970205043d, y: 0.05300250314863586d), new NpgsqlTypes.NpgsqlPoint(x: 0.17601638306942147d, y: 0.6726674199211428d), new NpgsqlTypes.NpgsqlPoint(x: 0.2413962814751408d, y: 0.10679038498941784d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6821266557621579d, y: 0.6291618476585025d), new NpgsqlTypes.NpgsqlPoint(x: 0.00987819656066835d, y: 0.340405070473049d), new NpgsqlTypes.NpgsqlPoint(x: 0.9135389324846254d, y: 0.23777369184539165d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20212626805838307d, y: 0.8183803897869469d), new NpgsqlTypes.NpgsqlPoint(x: 0.8296501472744447d, y: 0.6850215708403095d), new NpgsqlTypes.NpgsqlPoint(x: 0.06656934746245557d, y: 0.46297637064917885d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9938208581723625d, y: 0.0995567508293379d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086460477478254d, y: 0.5048533858935227d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719223805263479d, y: 0.5398628498549601d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7763206681522459d, y: 0.3167534265651294d), new NpgsqlTypes.NpgsqlPoint(x: 0.15604254454235966d, y: 0.9852671463372591d), new NpgsqlTypes.NpgsqlPoint(x: 0.9994126279393222d, y: 0.38761066814253453d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29625707582453686d, y: 0.6816702036015013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350202867003886d, y: 0.778960437485659d), new NpgsqlTypes.NpgsqlPoint(x: 0.354827386703902d, y: 0.16809060333287507d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20982146233916465d, y: 0.9664397456216006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550297481575536d, y: 0.4859300999827777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7215338261749726d, y: 0.637883738303157d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11802109686491369d, y: 0.39646449087557656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670522011893776d, y: 0.23024020506846077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428863630202885d, y: 0.471332900556666d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8048977230787804d, y: 0.34532902416424505d), new NpgsqlTypes.NpgsqlPoint(x: 0.31868704726886576d, y: 0.012176329408673192d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315291398508351d, y: 0.5945366786642188d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7708827366081586d, y: 0.5636312982527927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335397509917873d, y: 0.2874894158466057d), new NpgsqlTypes.NpgsqlPoint(x: 0.02745335384317682d, y: 0.13462554222813905d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222587364029452d, y: 0.7564851492645875d), new NpgsqlTypes.NpgsqlPoint(x: 0.3538666512494699d, y: 0.7402993863052184d), new NpgsqlTypes.NpgsqlPoint(x: 0.18080490862510645d, y: 0.635408271756414d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02697274222621804d, y: 0.16846911726709757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599820478140835d, y: 0.10685728550910445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9494640411540229d, y: 0.2014914521094905d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40308224797330605d, y: 0.19428227615664007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303181261677661d, y: 0.7822016487575476d), new NpgsqlTypes.NpgsqlPoint(x: 0.42101111812364544d, y: 0.38267167282595016d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4063325737132373d, y: 0.5297134353637029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455373057801755d, y: 0.87094168723406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874941406894292d, y: 0.35661045522987d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32380601021409205d, y: 0.09877804824593339d), new NpgsqlTypes.NpgsqlPoint(x: 0.15228303832227985d, y: 0.0575422185942398d), new NpgsqlTypes.NpgsqlPoint(x: 0.77535358736732d, y: 0.5342062096195725d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.704492360818477d, y: 0.9425032794906453d), new NpgsqlTypes.NpgsqlPoint(x: 0.0712045804956668d, y: 0.5135460544383212d), new NpgsqlTypes.NpgsqlPoint(x: 0.43139564457571034d, y: 0.3630191472331854d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15062246909000088d, y: 0.7213296246646148d), new NpgsqlTypes.NpgsqlPoint(x: 0.7958459567040859d, y: 0.9026257420894527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7977318664538633d, y: 0.4575303393386806d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07457373753584229d, y: 0.9705532469464726d), new NpgsqlTypes.NpgsqlPoint(x: 0.45530119440187455d, y: 0.76848593142605d), new NpgsqlTypes.NpgsqlPoint(x: 0.304236701135438d, y: 0.5030657752378984d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35330356511225347d, y: 0.09578417947640461d), new NpgsqlTypes.NpgsqlPoint(x: 0.5035689323731442d, y: 0.9501112175759097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835326170841601d, y: 0.08463328434347295d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9009514251852095d, y: 0.7947085290512259d), new NpgsqlTypes.NpgsqlPoint(x: 0.42100668181654277d, y: 0.48215360391644857d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005863829636604256d, y: 0.09359461000499891d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8183928954648634d, y: 0.6612903008761182d), new NpgsqlTypes.NpgsqlPoint(x: 0.06098499813822611d, y: 0.36611725339289136d), new NpgsqlTypes.NpgsqlPoint(x: 0.44887065135435056d, y: 0.47366794317084504d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9357660224710183d, y: 0.023691222788592925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398198388818198d, y: 0.4263666408848271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8969918263339864d, y: 0.668824269371486d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2655147930752626d, y: 0.27887161519910253d), new NpgsqlTypes.NpgsqlPoint(x: 0.39598668709350626d, y: 0.8266448045843601d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209889364503502d, y: 0.10896204503056117d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8271682231486178d, y: 0.37595361647793224d), new NpgsqlTypes.NpgsqlPoint(x: 0.7229635846405297d, y: 0.2312819785266278d), new NpgsqlTypes.NpgsqlPoint(x: 0.293710778341821d, y: 0.20821329675920341d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23360496246216733d, y: 0.849783437008871d), new NpgsqlTypes.NpgsqlPoint(x: 0.23678139734181103d, y: 0.3461112680277286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6089088663006196d, y: 0.8742243805538412d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27845522644710186d, y: 0.2946096222646579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7113188724387108d, y: 0.21630639794006923d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468094981191738d, y: 0.389153263109691d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9626427489087844d, y: 0.1646903627714955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536925518027759d, y: 0.44975766737149625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4924674807909247d, y: 0.39181618545977126d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17923013185911518d, y: 0.0419399441902073d), new NpgsqlTypes.NpgsqlPoint(x: 0.21225306330111093d, y: 0.5783879084728293d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021097316811701d, y: 0.04161414052910739d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41525579673759183d, y: 0.7084697973634788d), new NpgsqlTypes.NpgsqlPoint(x: 0.48019604301520247d, y: 0.017526415688696173d), new NpgsqlTypes.NpgsqlPoint(x: 0.1344593844620886d, y: 0.4198957754648036d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24983193553967875d, y: 0.2881718438489348d), new NpgsqlTypes.NpgsqlPoint(x: 0.3721988239118149d, y: 0.1348366679445303d), new NpgsqlTypes.NpgsqlPoint(x: 0.45154836559086886d, y: 0.929118702932151d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7261292625148327d, y: 0.27359231254414995d), new NpgsqlTypes.NpgsqlPoint(x: 0.23925653657588097d, y: 0.4933387455204884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023839992048215d, y: 0.23285726204842094d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7344170383196018d, y: 0.3929514505618732d), new NpgsqlTypes.NpgsqlPoint(x: 0.024775642015430477d, y: 0.14149274456452987d), new NpgsqlTypes.NpgsqlPoint(x: 0.2540227529345709d, y: 0.7632370945029822d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13783672994795193d, y: 0.686299249411211d), new NpgsqlTypes.NpgsqlPoint(x: 0.719153829091788d, y: 0.9339658324675625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217939018820076d, y: 0.5945068294668363d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7565544603454871d, y: 0.13277497705118468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827913632027755d, y: 0.6243420404703454d), new NpgsqlTypes.NpgsqlPoint(x: 0.2786346694470685d, y: 0.4344586973514196d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014947797167446208d, y: 0.7993768381633135d), new NpgsqlTypes.NpgsqlPoint(x: 0.732464702062584d, y: 0.3053049451807066d), new NpgsqlTypes.NpgsqlPoint(x: 0.49743251988242243d, y: 0.9912853170762063d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34375055576202296d, y: 0.5108247961879602d), new NpgsqlTypes.NpgsqlPoint(x: 0.19144097605028942d, y: 0.6418589070286375d), new NpgsqlTypes.NpgsqlPoint(x: 0.06901685427564352d, y: 0.10105256850682143d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08735326605607141d, y: 0.2813119474483976d), new NpgsqlTypes.NpgsqlPoint(x: 0.18465863171520547d, y: 0.9475316137390413d), new NpgsqlTypes.NpgsqlPoint(x: 0.11732049389291488d, y: 0.4850246006593756d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29438474176451246d, y: 0.10744209795479298d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993377602159073d, y: 0.4633064334623672d), new NpgsqlTypes.NpgsqlPoint(x: 0.026499403940449473d, y: 0.6443904841245022d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6340907779801086d, y: 0.9529921047308437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6551735715456983d, y: 0.9128051064629022d), new NpgsqlTypes.NpgsqlPoint(x: 0.10225140455484971d, y: 0.8822075857612761d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4277820957585816d, y: 0.3114938810495822d), new NpgsqlTypes.NpgsqlPoint(x: 0.27210028980993606d, y: 0.9828602812285421d), new NpgsqlTypes.NpgsqlPoint(x: 0.18562735602955382d, y: 0.5556075315401433d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2384438254369029d, y: 0.6641913892735914d), new NpgsqlTypes.NpgsqlPoint(x: 0.7703324055157237d, y: 0.03065067336230476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6371784464102381d, y: 0.24472479150780058d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3475060045143188d, y: 0.03182165357624023d), new NpgsqlTypes.NpgsqlPoint(x: 0.48140171948016486d, y: 0.23687443493167404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6058137056001313d, y: 0.3977342244563776d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8401116274186536d, y: 0.08160211874348844d), new NpgsqlTypes.NpgsqlPoint(x: 0.33519209789239623d, y: 0.20888053577360577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9670054701980431d, y: 0.6325505693102403d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9505277566384494d, y: 0.4696004066285221d), new NpgsqlTypes.NpgsqlPoint(x: 0.06907487691585534d, y: 0.34483444576055033d), new NpgsqlTypes.NpgsqlPoint(x: 0.025910042881916007d, y: 0.9683407153081085d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8833233041464623d, y: 0.1299092545014392d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562238874788721d, y: 0.8506230584996934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455415595778164d, y: 0.12327425642219947d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9769736836366814d, y: 0.7305841618640869d), new NpgsqlTypes.NpgsqlPoint(x: 0.3039578200007754d, y: 0.10623679683494269d), new NpgsqlTypes.NpgsqlPoint(x: 0.3533585055768642d, y: 0.9302715100837831d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9385647127422821d, y: 0.6046318125147365d), new NpgsqlTypes.NpgsqlPoint(x: 0.676294914834733d, y: 0.7778837182744226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6046535149910536d, y: 0.7520610722098091d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4899700879286012d, y: 0.7149162179464678d), new NpgsqlTypes.NpgsqlPoint(x: 0.3428148524732588d, y: 0.38286064565362743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5599467323737582d, y: 0.45461569764772947d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16837916388814633d, y: 0.7846817819190377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9541699784760358d, y: 0.5278264890197071d), new NpgsqlTypes.NpgsqlPoint(x: 0.2231956674635479d, y: 0.6798970956621094d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7858159306933046d, y: 0.40422575450576914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5426116646190782d, y: 0.02826213501735242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6090697914372619d, y: 0.03732432493469606d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3547802301159747d, y: 0.6310392116235707d), new NpgsqlTypes.NpgsqlPoint(x: 0.0969234892664983d, y: 0.32810798325551804d), new NpgsqlTypes.NpgsqlPoint(x: 0.15558513124467543d, y: 0.3257158014089986d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20152256033344318d, y: 0.5513957176014237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205520080447809d, y: 0.5325937884428659d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371773108496862d, y: 0.7152015386666729d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.67078583538834d, y: 0.8848784113698376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211336005742534d, y: 0.5303593312612032d), new NpgsqlTypes.NpgsqlPoint(x: 0.4913372554689386d, y: 0.2590035684492381d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5435429529722138d, y: 0.19711454808347106d), new NpgsqlTypes.NpgsqlPoint(x: 0.46355389664124924d, y: 0.10732350234798149d), new NpgsqlTypes.NpgsqlPoint(x: 0.4628200803810161d, y: 0.49338313822839d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22083372500729948d, y: 0.8382567301402946d), new NpgsqlTypes.NpgsqlPoint(x: 0.7431205359719117d, y: 0.6809305733522508d), new NpgsqlTypes.NpgsqlPoint(x: 0.652863529015637d, y: 0.993977544088488d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8313765011203846d, y: 0.8968254263447062d), new NpgsqlTypes.NpgsqlPoint(x: 0.3733543206140456d, y: 0.19346942595015792d), new NpgsqlTypes.NpgsqlPoint(x: 0.79688327201112d, y: 0.9557214426978401d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06005250507261706d, y: 0.05963903709943419d), new NpgsqlTypes.NpgsqlPoint(x: 0.09274144657730055d, y: 0.41882216880811374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3673741818037167d, y: 0.8819503920405174d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2731427207644962d, y: 0.7439541848175277d), new NpgsqlTypes.NpgsqlPoint(x: 0.6409028873510069d, y: 0.2165521277384479d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739937558746239d, y: 0.1331752394465705d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07154047429101362d, y: 0.5693948388774379d), new NpgsqlTypes.NpgsqlPoint(x: 0.13226447642257277d, y: 0.8507355723663822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789344739447765d, y: 0.5824383593969834d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04930292424457472d, y: 0.4919499718341842d), new NpgsqlTypes.NpgsqlPoint(x: 0.554878280575539d, y: 0.5090996748125017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7877041583746434d, y: 0.18619102692970702d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40129249135156797d, y: 0.6757746219519373d), new NpgsqlTypes.NpgsqlPoint(x: 0.3206132576410615d, y: 0.21323052460794134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106131755183139d, y: 0.2821711710995951d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8700481445234793d, y: 0.2787297384508207d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025174560899665d, y: 0.82713592749682d), new NpgsqlTypes.NpgsqlPoint(x: 0.029738066789994577d, y: 0.19370123240679216d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08584951113424633d, y: 0.42319916855234896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9080822456597112d, y: 0.48834573764889044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470922286574696d, y: 0.41839149503428996d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8468494270268578d, y: 0.6057507737282641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785720797974099d, y: 0.6514950537059245d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606527481120125d, y: 0.8538122653334093d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7585581799614934d, y: 0.8435116573036845d), new NpgsqlTypes.NpgsqlPoint(x: 0.21262002329269447d, y: 0.46018257772958315d), new NpgsqlTypes.NpgsqlPoint(x: 0.973448341923882d, y: 0.34158658673799613d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6004052113558499d, y: 0.295835987420381d), new NpgsqlTypes.NpgsqlPoint(x: 0.4854932965519193d, y: 0.2711560465956727d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867291466521255d, y: 0.386484294138302d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17120043567793997d, y: 0.33643585790207353d), new NpgsqlTypes.NpgsqlPoint(x: 0.4695511433329379d, y: 0.18214968709676627d), new NpgsqlTypes.NpgsqlPoint(x: 0.2325474686471921d, y: 0.1898951676661429d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8510303560579988d, y: 0.49677996799482127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5272303773359842d, y: 0.7212686731423967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481590615637173d, y: 0.7430111078622508d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8879940467700497d, y: 0.4713576079069858d), new NpgsqlTypes.NpgsqlPoint(x: 0.38627890642438945d, y: 0.1852766779336794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8030858252119752d, y: 0.7784934866196586d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4523197728691174d, y: 0.8696904725038642d), new NpgsqlTypes.NpgsqlPoint(x: 0.866935463734927d, y: 0.45276787146699204d), new NpgsqlTypes.NpgsqlPoint(x: 0.4947737101289851d, y: 0.9390912785948794d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4982683851002324d, y: 0.8173581024139784d), new NpgsqlTypes.NpgsqlPoint(x: 0.29262879827344956d, y: 0.27843977756136906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495970533209879d, y: 0.3928429540531141d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45206028198566006d, y: 0.07364366924120869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430011544298028d, y: 0.22746275775024372d), new NpgsqlTypes.NpgsqlPoint(x: 0.22315985464091126d, y: 0.21292894943735752d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0314680812103979d, y: 0.581507059446667d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434919120555305d, y: 0.12567696678557527d), new NpgsqlTypes.NpgsqlPoint(x: 0.6467423027947323d, y: 0.3330267031082518d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6346351611720742d, y: 0.18647058379839943d), new NpgsqlTypes.NpgsqlPoint(x: 0.06768454377801214d, y: 0.831296143043969d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766411863220747d, y: 0.21900504125058662d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.524427603779791d, y: 0.697280623375441d), new NpgsqlTypes.NpgsqlPoint(x: 0.3246817053607668d, y: 0.9851304739057399d), new NpgsqlTypes.NpgsqlPoint(x: 0.2409397092950537d, y: 0.3046736228138457d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5048673685175229d, y: 0.4548064655397497d), new NpgsqlTypes.NpgsqlPoint(x: 0.0477056016756775d, y: 0.2003441132151046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160346053886983d, y: 0.28980059622537924d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((196)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36460609958913737d, y: 0.02101472274299676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3534435489086505d, y: 0.00031808644667075114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926502502460288d, y: 0.36435286887109597d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10595486666365672d, y: 0.596797538336435d), new NpgsqlTypes.NpgsqlPoint(x: 0.11957578057079798d, y: 0.348707283476577d), new NpgsqlTypes.NpgsqlPoint(x: 0.37645346047569783d, y: 0.14393603021847523d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.767857247596653d, y: 0.2730554475677822d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837494900110853d, y: 0.5896524444140866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677348692761505d, y: 0.4882000083741693d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5022681970205043d, y: 0.05300250314863586d), new NpgsqlTypes.NpgsqlPoint(x: 0.17601638306942147d, y: 0.6726674199211428d), new NpgsqlTypes.NpgsqlPoint(x: 0.2413962814751408d, y: 0.10679038498941784d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6821266557621579d, y: 0.6291618476585025d), new NpgsqlTypes.NpgsqlPoint(x: 0.00987819656066835d, y: 0.340405070473049d), new NpgsqlTypes.NpgsqlPoint(x: 0.9135389324846254d, y: 0.23777369184539165d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20212626805838307d, y: 0.8183803897869469d), new NpgsqlTypes.NpgsqlPoint(x: 0.8296501472744447d, y: 0.6850215708403095d), new NpgsqlTypes.NpgsqlPoint(x: 0.06656934746245557d, y: 0.46297637064917885d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9938208581723625d, y: 0.0995567508293379d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086460477478254d, y: 0.5048533858935227d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719223805263479d, y: 0.5398628498549601d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7763206681522459d, y: 0.3167534265651294d), new NpgsqlTypes.NpgsqlPoint(x: 0.15604254454235966d, y: 0.9852671463372591d), new NpgsqlTypes.NpgsqlPoint(x: 0.9994126279393222d, y: 0.38761066814253453d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29625707582453686d, y: 0.6816702036015013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350202867003886d, y: 0.778960437485659d), new NpgsqlTypes.NpgsqlPoint(x: 0.354827386703902d, y: 0.16809060333287507d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20982146233916465d, y: 0.9664397456216006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550297481575536d, y: 0.4859300999827777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7215338261749726d, y: 0.637883738303157d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11802109686491369d, y: 0.39646449087557656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670522011893776d, y: 0.23024020506846077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428863630202885d, y: 0.471332900556666d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8048977230787804d, y: 0.34532902416424505d), new NpgsqlTypes.NpgsqlPoint(x: 0.31868704726886576d, y: 0.012176329408673192d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315291398508351d, y: 0.5945366786642188d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7708827366081586d, y: 0.5636312982527927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335397509917873d, y: 0.2874894158466057d), new NpgsqlTypes.NpgsqlPoint(x: 0.02745335384317682d, y: 0.13462554222813905d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5222587364029452d, y: 0.7564851492645875d), new NpgsqlTypes.NpgsqlPoint(x: 0.3538666512494699d, y: 0.7402993863052184d), new NpgsqlTypes.NpgsqlPoint(x: 0.18080490862510645d, y: 0.635408271756414d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02697274222621804d, y: 0.16846911726709757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599820478140835d, y: 0.10685728550910445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9494640411540229d, y: 0.2014914521094905d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40308224797330605d, y: 0.19428227615664007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303181261677661d, y: 0.7822016487575476d), new NpgsqlTypes.NpgsqlPoint(x: 0.42101111812364544d, y: 0.38267167282595016d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4063325737132373d, y: 0.5297134353637029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455373057801755d, y: 0.87094168723406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874941406894292d, y: 0.35661045522987d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32380601021409205d, y: 0.09877804824593339d), new NpgsqlTypes.NpgsqlPoint(x: 0.15228303832227985d, y: 0.0575422185942398d), new NpgsqlTypes.NpgsqlPoint(x: 0.77535358736732d, y: 0.5342062096195725d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.704492360818477d, y: 0.9425032794906453d), new NpgsqlTypes.NpgsqlPoint(x: 0.0712045804956668d, y: 0.5135460544383212d), new NpgsqlTypes.NpgsqlPoint(x: 0.43139564457571034d, y: 0.3630191472331854d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15062246909000088d, y: 0.7213296246646148d), new NpgsqlTypes.NpgsqlPoint(x: 0.7958459567040859d, y: 0.9026257420894527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7977318664538633d, y: 0.4575303393386806d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07457373753584229d, y: 0.9705532469464726d), new NpgsqlTypes.NpgsqlPoint(x: 0.45530119440187455d, y: 0.76848593142605d), new NpgsqlTypes.NpgsqlPoint(x: 0.304236701135438d, y: 0.5030657752378984d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35330356511225347d, y: 0.09578417947640461d), new NpgsqlTypes.NpgsqlPoint(x: 0.5035689323731442d, y: 0.9501112175759097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835326170841601d, y: 0.08463328434347295d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9009514251852095d, y: 0.7947085290512259d), new NpgsqlTypes.NpgsqlPoint(x: 0.42100668181654277d, y: 0.48215360391644857d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005863829636604256d, y: 0.09359461000499891d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8183928954648634d, y: 0.6612903008761182d), new NpgsqlTypes.NpgsqlPoint(x: 0.06098499813822611d, y: 0.36611725339289136d), new NpgsqlTypes.NpgsqlPoint(x: 0.44887065135435056d, y: 0.47366794317084504d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9357660224710183d, y: 0.023691222788592925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398198388818198d, y: 0.4263666408848271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8969918263339864d, y: 0.668824269371486d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2655147930752626d, y: 0.27887161519910253d), new NpgsqlTypes.NpgsqlPoint(x: 0.39598668709350626d, y: 0.8266448045843601d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209889364503502d, y: 0.10896204503056117d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8271682231486178d, y: 0.37595361647793224d), new NpgsqlTypes.NpgsqlPoint(x: 0.7229635846405297d, y: 0.2312819785266278d), new NpgsqlTypes.NpgsqlPoint(x: 0.293710778341821d, y: 0.20821329675920341d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23360496246216733d, y: 0.849783437008871d), new NpgsqlTypes.NpgsqlPoint(x: 0.23678139734181103d, y: 0.3461112680277286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6089088663006196d, y: 0.8742243805538412d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27845522644710186d, y: 0.2946096222646579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7113188724387108d, y: 0.21630639794006923d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468094981191738d, y: 0.389153263109691d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9626427489087844d, y: 0.1646903627714955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536925518027759d, y: 0.44975766737149625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4924674807909247d, y: 0.39181618545977126d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17923013185911518d, y: 0.0419399441902073d), new NpgsqlTypes.NpgsqlPoint(x: 0.21225306330111093d, y: 0.5783879084728293d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021097316811701d, y: 0.04161414052910739d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41525579673759183d, y: 0.7084697973634788d), new NpgsqlTypes.NpgsqlPoint(x: 0.48019604301520247d, y: 0.017526415688696173d), new NpgsqlTypes.NpgsqlPoint(x: 0.1344593844620886d, y: 0.4198957754648036d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24983193553967875d, y: 0.2881718438489348d), new NpgsqlTypes.NpgsqlPoint(x: 0.3721988239118149d, y: 0.1348366679445303d), new NpgsqlTypes.NpgsqlPoint(x: 0.45154836559086886d, y: 0.929118702932151d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7261292625148327d, y: 0.27359231254414995d), new NpgsqlTypes.NpgsqlPoint(x: 0.23925653657588097d, y: 0.4933387455204884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023839992048215d, y: 0.23285726204842094d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7344170383196018d, y: 0.3929514505618732d), new NpgsqlTypes.NpgsqlPoint(x: 0.024775642015430477d, y: 0.14149274456452987d), new NpgsqlTypes.NpgsqlPoint(x: 0.2540227529345709d, y: 0.7632370945029822d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13783672994795193d, y: 0.686299249411211d), new NpgsqlTypes.NpgsqlPoint(x: 0.719153829091788d, y: 0.9339658324675625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217939018820076d, y: 0.5945068294668363d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7565544603454871d, y: 0.13277497705118468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827913632027755d, y: 0.6243420404703454d), new NpgsqlTypes.NpgsqlPoint(x: 0.2786346694470685d, y: 0.4344586973514196d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014947797167446208d, y: 0.7993768381633135d), new NpgsqlTypes.NpgsqlPoint(x: 0.732464702062584d, y: 0.3053049451807066d), new NpgsqlTypes.NpgsqlPoint(x: 0.49743251988242243d, y: 0.9912853170762063d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34375055576202296d, y: 0.5108247961879602d), new NpgsqlTypes.NpgsqlPoint(x: 0.19144097605028942d, y: 0.6418589070286375d), new NpgsqlTypes.NpgsqlPoint(x: 0.06901685427564352d, y: 0.10105256850682143d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08735326605607141d, y: 0.2813119474483976d), new NpgsqlTypes.NpgsqlPoint(x: 0.18465863171520547d, y: 0.9475316137390413d), new NpgsqlTypes.NpgsqlPoint(x: 0.11732049389291488d, y: 0.4850246006593756d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29438474176451246d, y: 0.10744209795479298d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993377602159073d, y: 0.4633064334623672d), new NpgsqlTypes.NpgsqlPoint(x: 0.026499403940449473d, y: 0.6443904841245022d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6340907779801086d, y: 0.9529921047308437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6551735715456983d, y: 0.9128051064629022d), new NpgsqlTypes.NpgsqlPoint(x: 0.10225140455484971d, y: 0.8822075857612761d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4277820957585816d, y: 0.3114938810495822d), new NpgsqlTypes.NpgsqlPoint(x: 0.27210028980993606d, y: 0.9828602812285421d), new NpgsqlTypes.NpgsqlPoint(x: 0.18562735602955382d, y: 0.5556075315401433d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2384438254369029d, y: 0.6641913892735914d), new NpgsqlTypes.NpgsqlPoint(x: 0.7703324055157237d, y: 0.03065067336230476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6371784464102381d, y: 0.24472479150780058d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3475060045143188d, y: 0.03182165357624023d), new NpgsqlTypes.NpgsqlPoint(x: 0.48140171948016486d, y: 0.23687443493167404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6058137056001313d, y: 0.3977342244563776d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8401116274186536d, y: 0.08160211874348844d), new NpgsqlTypes.NpgsqlPoint(x: 0.33519209789239623d, y: 0.20888053577360577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9670054701980431d, y: 0.6325505693102403d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9505277566384494d, y: 0.4696004066285221d), new NpgsqlTypes.NpgsqlPoint(x: 0.06907487691585534d, y: 0.34483444576055033d), new NpgsqlTypes.NpgsqlPoint(x: 0.025910042881916007d, y: 0.9683407153081085d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8833233041464623d, y: 0.1299092545014392d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562238874788721d, y: 0.8506230584996934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455415595778164d, y: 0.12327425642219947d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9769736836366814d, y: 0.7305841618640869d), new NpgsqlTypes.NpgsqlPoint(x: 0.3039578200007754d, y: 0.10623679683494269d), new NpgsqlTypes.NpgsqlPoint(x: 0.3533585055768642d, y: 0.9302715100837831d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9385647127422821d, y: 0.6046318125147365d), new NpgsqlTypes.NpgsqlPoint(x: 0.676294914834733d, y: 0.7778837182744226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6046535149910536d, y: 0.7520610722098091d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4899700879286012d, y: 0.7149162179464678d), new NpgsqlTypes.NpgsqlPoint(x: 0.3428148524732588d, y: 0.38286064565362743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5599467323737582d, y: 0.45461569764772947d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16837916388814633d, y: 0.7846817819190377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9541699784760358d, y: 0.5278264890197071d), new NpgsqlTypes.NpgsqlPoint(x: 0.2231956674635479d, y: 0.6798970956621094d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7858159306933046d, y: 0.40422575450576914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5426116646190782d, y: 0.02826213501735242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6090697914372619d, y: 0.03732432493469606d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3547802301159747d, y: 0.6310392116235707d), new NpgsqlTypes.NpgsqlPoint(x: 0.0969234892664983d, y: 0.32810798325551804d), new NpgsqlTypes.NpgsqlPoint(x: 0.15558513124467543d, y: 0.3257158014089986d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20152256033344318d, y: 0.5513957176014237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205520080447809d, y: 0.5325937884428659d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371773108496862d, y: 0.7152015386666729d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.67078583538834d, y: 0.8848784113698376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211336005742534d, y: 0.5303593312612032d), new NpgsqlTypes.NpgsqlPoint(x: 0.4913372554689386d, y: 0.2590035684492381d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5435429529722138d, y: 0.19711454808347106d), new NpgsqlTypes.NpgsqlPoint(x: 0.46355389664124924d, y: 0.10732350234798149d), new NpgsqlTypes.NpgsqlPoint(x: 0.4628200803810161d, y: 0.49338313822839d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22083372500729948d, y: 0.8382567301402946d), new NpgsqlTypes.NpgsqlPoint(x: 0.7431205359719117d, y: 0.6809305733522508d), new NpgsqlTypes.NpgsqlPoint(x: 0.652863529015637d, y: 0.993977544088488d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8313765011203846d, y: 0.8968254263447062d), new NpgsqlTypes.NpgsqlPoint(x: 0.3733543206140456d, y: 0.19346942595015792d), new NpgsqlTypes.NpgsqlPoint(x: 0.79688327201112d, y: 0.9557214426978401d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06005250507261706d, y: 0.05963903709943419d), new NpgsqlTypes.NpgsqlPoint(x: 0.09274144657730055d, y: 0.41882216880811374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3673741818037167d, y: 0.8819503920405174d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2731427207644962d, y: 0.7439541848175277d), new NpgsqlTypes.NpgsqlPoint(x: 0.6409028873510069d, y: 0.2165521277384479d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739937558746239d, y: 0.1331752394465705d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07154047429101362d, y: 0.5693948388774379d), new NpgsqlTypes.NpgsqlPoint(x: 0.13226447642257277d, y: 0.8507355723663822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789344739447765d, y: 0.5824383593969834d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04930292424457472d, y: 0.4919499718341842d), new NpgsqlTypes.NpgsqlPoint(x: 0.554878280575539d, y: 0.5090996748125017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7877041583746434d, y: 0.18619102692970702d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40129249135156797d, y: 0.6757746219519373d), new NpgsqlTypes.NpgsqlPoint(x: 0.3206132576410615d, y: 0.21323052460794134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106131755183139d, y: 0.2821711710995951d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8700481445234793d, y: 0.2787297384508207d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025174560899665d, y: 0.82713592749682d), new NpgsqlTypes.NpgsqlPoint(x: 0.029738066789994577d, y: 0.19370123240679216d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08584951113424633d, y: 0.42319916855234896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9080822456597112d, y: 0.48834573764889044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470922286574696d, y: 0.41839149503428996d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8468494270268578d, y: 0.6057507737282641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785720797974099d, y: 0.6514950537059245d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606527481120125d, y: 0.8538122653334093d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7585581799614934d, y: 0.8435116573036845d), new NpgsqlTypes.NpgsqlPoint(x: 0.21262002329269447d, y: 0.46018257772958315d), new NpgsqlTypes.NpgsqlPoint(x: 0.973448341923882d, y: 0.34158658673799613d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6004052113558499d, y: 0.295835987420381d), new NpgsqlTypes.NpgsqlPoint(x: 0.4854932965519193d, y: 0.2711560465956727d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867291466521255d, y: 0.386484294138302d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17120043567793997d, y: 0.33643585790207353d), new NpgsqlTypes.NpgsqlPoint(x: 0.4695511433329379d, y: 0.18214968709676627d), new NpgsqlTypes.NpgsqlPoint(x: 0.2325474686471921d, y: 0.1898951676661429d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8510303560579988d, y: 0.49677996799482127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5272303773359842d, y: 0.7212686731423967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481590615637173d, y: 0.7430111078622508d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8879940467700497d, y: 0.4713576079069858d), new NpgsqlTypes.NpgsqlPoint(x: 0.38627890642438945d, y: 0.1852766779336794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8030858252119752d, y: 0.7784934866196586d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4523197728691174d, y: 0.8696904725038642d), new NpgsqlTypes.NpgsqlPoint(x: 0.866935463734927d, y: 0.45276787146699204d), new NpgsqlTypes.NpgsqlPoint(x: 0.4947737101289851d, y: 0.9390912785948794d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4982683851002324d, y: 0.8173581024139784d), new NpgsqlTypes.NpgsqlPoint(x: 0.29262879827344956d, y: 0.27843977756136906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495970533209879d, y: 0.3928429540531141d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45206028198566006d, y: 0.07364366924120869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430011544298028d, y: 0.22746275775024372d), new NpgsqlTypes.NpgsqlPoint(x: 0.22315985464091126d, y: 0.21292894943735752d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0314680812103979d, y: 0.581507059446667d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434919120555305d, y: 0.12567696678557527d), new NpgsqlTypes.NpgsqlPoint(x: 0.6467423027947323d, y: 0.3330267031082518d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6346351611720742d, y: 0.18647058379839943d), new NpgsqlTypes.NpgsqlPoint(x: 0.06768454377801214d, y: 0.831296143043969d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766411863220747d, y: 0.21900504125058662d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.524427603779791d, y: 0.697280623375441d), new NpgsqlTypes.NpgsqlPoint(x: 0.3246817053607668d, y: 0.9851304739057399d), new NpgsqlTypes.NpgsqlPoint(x: 0.2409397092950537d, y: 0.3046736228138457d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5048673685175229d, y: 0.4548064655397497d), new NpgsqlTypes.NpgsqlPoint(x: 0.0477056016756775d, y: 0.2003441132151046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160346053886983d, y: 0.28980059622537924d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((196)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36460609958913737d, y: 0.02101472274299676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3534435489086505d, y: 0.00031808644667075114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926502502460288d, y: 0.36435286887109597d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
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
COPY public.binary_npgsqlpathpathe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MI),
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
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
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
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
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
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathE0M),
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
FROM public.binary_npgsqlpathpathe0m m
LEFT JOIN public.binary_npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                var importCollection = new List<NpgsqlPathpathE0M>();
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
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0M>();
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
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI), typeof(NpgsqlPathpathE0MI)],
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
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
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

