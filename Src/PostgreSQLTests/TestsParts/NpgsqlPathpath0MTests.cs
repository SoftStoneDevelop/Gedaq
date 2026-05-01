

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
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43790729306972853d, y: 0.6214484702654599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308179066435217d, y: 0.036554268392423706d), new NpgsqlTypes.NpgsqlPoint(x: 0.12708217252822374d, y: 0.34086706225629704d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37807938561769106d, y: 0.9674330259019799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7570719410939917d, y: 0.18659830760815754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7065787562844357d, y: 0.13485596142784806d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2537949166471184d, y: 0.7298560649217349d), new NpgsqlTypes.NpgsqlPoint(x: 0.28181374623874234d, y: 0.13938883107080802d), new NpgsqlTypes.NpgsqlPoint(x: 0.8465163298234504d, y: 0.7234734261422837d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9598706778019734d, y: 0.26076728983216657d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239571974815269d, y: 0.26340415661766337d), new NpgsqlTypes.NpgsqlPoint(x: 0.277238225011159d, y: 0.3411347418116044d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8588633730170594d, y: 0.5332486203732779d), new NpgsqlTypes.NpgsqlPoint(x: 0.43505332332893587d, y: 0.7637740584767897d), new NpgsqlTypes.NpgsqlPoint(x: 0.30775376256218434d, y: 0.24635979189124657d)),
},
            new NpgsqlPathpath0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47583051717819425d, y: 0.4895677612120324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766892456800107d, y: 0.9876846379791514d), new NpgsqlTypes.NpgsqlPoint(x: 0.49486049732967585d, y: 0.691980768379251d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29157721083726085d, y: 0.6653374075431715d), new NpgsqlTypes.NpgsqlPoint(x: 0.002078333965740753d, y: 0.25451724090287486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583349044342593d, y: 0.759459371920596d)),
},
            new NpgsqlPathpath0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6898911973679384d, y: 0.07561236073404787d), new NpgsqlTypes.NpgsqlPoint(x: 0.24854756100839703d, y: 0.6499227070686664d), new NpgsqlTypes.NpgsqlPoint(x: 0.5025166031204804d, y: 0.048339084868457616d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4530514483334467d, y: 0.3604392132330204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8414452818048335d, y: 0.5364470778155659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7862469880151169d, y: 0.23335877465223842d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.282492619591039d, y: 0.4798185891560004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9393889139011935d, y: 0.23073167289295526d), new NpgsqlTypes.NpgsqlPoint(x: 0.27577447342550654d, y: 0.4094226565082645d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4571369469928992d, y: 0.9412620655746192d), new NpgsqlTypes.NpgsqlPoint(x: 0.03955635805851743d, y: 0.7718946164327927d), new NpgsqlTypes.NpgsqlPoint(x: 0.40083299201647427d, y: 0.32996146305504315d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19254494699988d, y: 0.7810996880338752d), new NpgsqlTypes.NpgsqlPoint(x: 0.49511570556789364d, y: 0.6499657267771569d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769877892147461d, y: 0.29470887094803344d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069454461554177d, y: 0.5495309475939147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4707207754487226d, y: 0.8993431124713616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606531806615769d, y: 0.6421477459495707d)),
},
            new NpgsqlPathpath0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5586491921515595d, y: 0.7729632746974718d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381797651744599d, y: 0.26145577307256584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7166470076581376d, y: 0.14363621618712774d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12325760237547934d, y: 0.4227006183159494d), new NpgsqlTypes.NpgsqlPoint(x: 0.06770055331172309d, y: 0.9486678956216673d), new NpgsqlTypes.NpgsqlPoint(x: 0.39369296273760246d, y: 0.5041858651901291d)),
},
            new NpgsqlPathpath0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32842449135578244d, y: 0.6542211047389276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163604716227065d, y: 0.46836070361338067d), new NpgsqlTypes.NpgsqlPoint(x: 0.11678971448146946d, y: 0.3291190177910268d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.583088660783242d, y: 0.5575422699349951d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723532875187085d, y: 0.021455435816641333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7198243259129202d, y: 0.3565544619146864d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.599173439999589d, y: 0.9879513596542615d), new NpgsqlTypes.NpgsqlPoint(x: 0.24441930982851534d, y: 0.7034338870652629d), new NpgsqlTypes.NpgsqlPoint(x: 0.004171367795127612d, y: 0.6216592643729181d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5659421231155419d, y: 0.09059483914768596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5580224279009272d, y: 0.9164970300408647d), new NpgsqlTypes.NpgsqlPoint(x: 0.715400757964718d, y: 0.45785222483399457d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22304892559953649d, y: 0.7773816838039863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9874352671638681d, y: 0.6677893534518551d), new NpgsqlTypes.NpgsqlPoint(x: 0.02752751616160798d, y: 0.40853458036327595d)),
},
            new NpgsqlPathpath0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9139761208238144d, y: 0.2575233988586896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8627093784399971d, y: 0.7821202085183189d), new NpgsqlTypes.NpgsqlPoint(x: 0.7975048712869736d, y: 0.5675097877338994d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8661227768441784d, y: 0.4467600713568024d), new NpgsqlTypes.NpgsqlPoint(x: 0.01988796604942611d, y: 0.0872964079743982d), new NpgsqlTypes.NpgsqlPoint(x: 0.43931851650224585d, y: 0.6533908736126787d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5016009630161942d, y: 0.5944008870415256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8814666562160759d, y: 0.7943983988186841d), new NpgsqlTypes.NpgsqlPoint(x: 0.33976277178616077d, y: 0.24271559666238895d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12470917108033819d, y: 0.32042551135999775d), new NpgsqlTypes.NpgsqlPoint(x: 0.44154029634493874d, y: 0.17783320106505818d), new NpgsqlTypes.NpgsqlPoint(x: 0.8450087149007806d, y: 0.13287716701345365d)),
},
            new NpgsqlPathpath0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6687450678135194d, y: 0.16165003495849606d), new NpgsqlTypes.NpgsqlPoint(x: 0.2726827674371879d, y: 0.39314026874054964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036918513615521d, y: 0.42524731190702536d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37746482284312766d, y: 0.45439374297321367d), new NpgsqlTypes.NpgsqlPoint(x: 0.3296363391164262d, y: 0.6408104260778252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8093549654037617d, y: 0.06408144588884679d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4212277415727955d, y: 0.7357482814453481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293221560265306d, y: 0.36217077501335604d), new NpgsqlTypes.NpgsqlPoint(x: 0.4139730245862223d, y: 0.9885857262611706d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7501054721922943d, y: 0.8375411986506774d), new NpgsqlTypes.NpgsqlPoint(x: 0.11894222136187982d, y: 0.7035033675667455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672709702740561d, y: 0.9966649576060918d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5954658283182486d, y: 0.9587775473268841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8291267418561911d, y: 0.21818586614413604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7100251834321003d, y: 0.8541975184215623d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5090349684179565d, y: 0.45576257954527843d), new NpgsqlTypes.NpgsqlPoint(x: 0.4818205019501429d, y: 0.0846132344000663d), new NpgsqlTypes.NpgsqlPoint(x: 0.17494529506077294d, y: 0.6729149749858456d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6195159117854105d, y: 0.738427609727085d), new NpgsqlTypes.NpgsqlPoint(x: 0.24744392168969176d, y: 0.13922687389637267d), new NpgsqlTypes.NpgsqlPoint(x: 0.11543402161693905d, y: 0.5090105982402684d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7312222766264723d, y: 0.04984378647857346d), new NpgsqlTypes.NpgsqlPoint(x: 0.05346152781594038d, y: 0.9698193361475286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9600404475823205d, y: 0.5166605426102052d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9742908961188724d, y: 0.14885296126194092d), new NpgsqlTypes.NpgsqlPoint(x: 0.409100201704258d, y: 0.7807750143782552d), new NpgsqlTypes.NpgsqlPoint(x: 0.9461563869557698d, y: 0.4875175633221551d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9236918392240421d, y: 0.10205484348386762d), new NpgsqlTypes.NpgsqlPoint(x: 0.09619233340253175d, y: 0.5777323080136576d), new NpgsqlTypes.NpgsqlPoint(x: 0.2741051729860361d, y: 0.42674033013335677d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5183274869739493d, y: 0.427115965627624d), new NpgsqlTypes.NpgsqlPoint(x: 0.32564649313940763d, y: 0.6208567138490512d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252508153456994d, y: 0.4106573715712736d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0208154491996122d, y: 0.4575787252167053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5357826457155677d, y: 0.995831634618353d), new NpgsqlTypes.NpgsqlPoint(x: 0.22326905680039755d, y: 0.7861728019122366d)),
},
            new NpgsqlPathpath0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9167470122147336d, y: 0.3438303378757458d), new NpgsqlTypes.NpgsqlPoint(x: 0.24331916909438744d, y: 0.5667627993406834d), new NpgsqlTypes.NpgsqlPoint(x: 0.41963604712486113d, y: 0.4447211279432264d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8135736676106259d, y: 0.32682947292500153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455087875265662d, y: 0.2400348646213486d), new NpgsqlTypes.NpgsqlPoint(x: 0.02116488310275555d, y: 0.3947550846416398d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3710191614597791d, y: 0.883643392958184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3657569092268964d, y: 0.24452987276827365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567614035391283d, y: 0.33197472373470016d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6531562106979296d, y: 0.8207885552038151d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093961761151989d, y: 0.4019127648969074d), new NpgsqlTypes.NpgsqlPoint(x: 0.37154193984695083d, y: 0.04314346444231387d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40159036184000296d, y: 0.22852353046422824d), new NpgsqlTypes.NpgsqlPoint(x: 0.7633116856612583d, y: 0.05360331282536568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433900222816777d, y: 0.8144808520352143d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6153420968116541d, y: 0.9972641014433721d), new NpgsqlTypes.NpgsqlPoint(x: 0.0960575068499645d, y: 0.8665117836720893d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348542644488099d, y: 0.19028872792710627d)),
},
            new NpgsqlPathpath0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9844237474446607d, y: 0.061934690628360545d), new NpgsqlTypes.NpgsqlPoint(x: 0.0818140826353938d, y: 0.5717702194079182d), new NpgsqlTypes.NpgsqlPoint(x: 0.19538756866715912d, y: 0.7050467469325891d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28727609086113426d, y: 0.787411969221508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618002140728112d, y: 0.40297605839050843d), new NpgsqlTypes.NpgsqlPoint(x: 0.2032485120510118d, y: 0.7929260881256662d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9805506613774115d, y: 0.7808079706056708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6184998879857374d, y: 0.5534434513025757d), new NpgsqlTypes.NpgsqlPoint(x: 0.1832470247064495d, y: 0.2655811901544478d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6955251762397474d, y: 0.9053164406762348d), new NpgsqlTypes.NpgsqlPoint(x: 0.6825940259743916d, y: 0.018209095042432843d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218525775911613d, y: 0.2587806523336388d)),
},
            new NpgsqlPathpath0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.78391980848628d, y: 0.5639454196918585d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434404449968944d, y: 0.8455074765534156d), new NpgsqlTypes.NpgsqlPoint(x: 0.538214922611127d, y: 0.32697166355044716d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2031300565721622d, y: 0.442138505563202d), new NpgsqlTypes.NpgsqlPoint(x: 0.04174729061449989d, y: 0.6518567178484861d), new NpgsqlTypes.NpgsqlPoint(x: 0.3501371873674076d, y: 0.08711824759700948d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8976625158649106d, y: 0.8220851105922493d), new NpgsqlTypes.NpgsqlPoint(x: 0.21745623080523413d, y: 0.9682393749771229d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693576260261043d, y: 0.808724338280061d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8169022764545131d, y: 0.5449294998470344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247260977616384d, y: 0.7137786832740869d), new NpgsqlTypes.NpgsqlPoint(x: 0.1523726801917651d, y: 0.6775215839275591d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14568836584913714d, y: 0.6650197698672475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5033993985951805d, y: 0.42547784486260043d), new NpgsqlTypes.NpgsqlPoint(x: 0.7354922808413177d, y: 0.628359066890898d)),
},
            new NpgsqlPathpath0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4231380553091617d, y: 0.7509658073838609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9956770820470374d, y: 0.4102063692218352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5659280201909085d, y: 0.4653000920050623d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17035037653067298d, y: 0.8973789373067101d), new NpgsqlTypes.NpgsqlPoint(x: 0.1415486630749675d, y: 0.44996749751948384d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358530319296898d, y: 0.9093079156361832d)),
},
            new NpgsqlPathpath0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3022281408963339d, y: 0.9791271125046762d), new NpgsqlTypes.NpgsqlPoint(x: 0.7024873359606352d, y: 0.496429284814802d), new NpgsqlTypes.NpgsqlPoint(x: 0.02066093834423255d, y: 0.966319991404019d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2727545772539949d, y: 0.5978334083049541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9001255644682863d, y: 0.3202257426101207d), new NpgsqlTypes.NpgsqlPoint(x: 0.3724988357419683d, y: 0.5619533882380935d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8121063871091538d, y: 0.2657981637652952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9884158781985715d, y: 0.6399282711096219d), new NpgsqlTypes.NpgsqlPoint(x: 0.10522884101854402d, y: 0.11359444077103398d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9860153438747862d, y: 0.9090172345400359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8176357743250137d, y: 0.8265132805862213d), new NpgsqlTypes.NpgsqlPoint(x: 0.287184424363239d, y: 0.6977861416820732d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1145305159027552d, y: 0.8750395556099508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5409569267573935d, y: 0.5186673931742294d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973068437950062d, y: 0.2675191075580834d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9155691255574243d, y: 0.2573837687778565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8815154621965954d, y: 0.11521922892651337d), new NpgsqlTypes.NpgsqlPoint(x: 0.2872614718254729d, y: 0.5786641184719707d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08196703373747816d, y: 0.2990417781043464d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661793738515591d, y: 0.7093598840545853d), new NpgsqlTypes.NpgsqlPoint(x: 0.2055855776148675d, y: 0.15758829777952632d)),
},
            new NpgsqlPathpath0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22002732047980444d, y: 0.9476072004489351d), new NpgsqlTypes.NpgsqlPoint(x: 0.8907140174374324d, y: 0.7955061011904552d), new NpgsqlTypes.NpgsqlPoint(x: 0.039355553130572596d, y: 0.2109210936251632d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7799054296483565d, y: 0.4916450959250228d), new NpgsqlTypes.NpgsqlPoint(x: 0.6259412907320818d, y: 0.47902413236984653d), new NpgsqlTypes.NpgsqlPoint(x: 0.04055010212299992d, y: 0.9465954357755779d)),
},
            new NpgsqlPathpath0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007191879639958376d, y: 0.3925733361035605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5921357305681056d, y: 0.4432225420334748d), new NpgsqlTypes.NpgsqlPoint(x: 0.7352610819960579d, y: 0.4669966854346158d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8365871886400197d, y: 0.1072527675898658d), new NpgsqlTypes.NpgsqlPoint(x: 0.3489116202695284d, y: 0.841361382080918d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732054468242643d, y: 0.08682479150717415d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8558217914091135d, y: 0.23557901076571008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7282537870224132d, y: 0.9500846318642425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882783014388342d, y: 0.15304748572572313d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8301751076990777d, y: 0.5276558172223839d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902315631758377d, y: 0.4359849277348864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6994972917741041d, y: 0.07699895992478767d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04080216435134454d, y: 0.41034084903876866d), new NpgsqlTypes.NpgsqlPoint(x: 0.2569157496646187d, y: 0.10597580089298098d), new NpgsqlTypes.NpgsqlPoint(x: 0.3511165741716008d, y: 0.5064468160932508d)),
},
            new NpgsqlPathpath0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12093253190358377d, y: 0.046664336814645324d), new NpgsqlTypes.NpgsqlPoint(x: 0.959922579429417d, y: 0.7351304899089715d), new NpgsqlTypes.NpgsqlPoint(x: 0.1203386218325101d, y: 0.873284692530528d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8833220330251179d, y: 0.8163618656299212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6208448298126767d, y: 0.40658889933560094d), new NpgsqlTypes.NpgsqlPoint(x: 0.3896105988650229d, y: 0.7424940536437078d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2745709677308127d, y: 0.053514651545063185d), new NpgsqlTypes.NpgsqlPoint(x: 0.07759778468138101d, y: 0.9653335359373811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980433291153111d, y: 0.8137766902526063d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16357766884062008d, y: 0.8857850457028974d), new NpgsqlTypes.NpgsqlPoint(x: 0.24339647788904917d, y: 0.9493718689348222d), new NpgsqlTypes.NpgsqlPoint(x: 0.36115058199536865d, y: 0.43071305091312206d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11616794572539235d, y: 0.27765019865026175d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549425944545161d, y: 0.40878948226578515d), new NpgsqlTypes.NpgsqlPoint(x: 0.38630290534783707d, y: 0.7661845120001277d)),
},
            new NpgsqlPathpath0M
{
    Id = 164,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0736987379502364d, y: 0.19741479202483125d), new NpgsqlTypes.NpgsqlPoint(x: 0.101536521286127d, y: 0.12387065931781516d), new NpgsqlTypes.NpgsqlPoint(x: 0.09957584171328515d, y: 0.4433885321805817d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05079170941162603d, y: 0.4887059957569322d), new NpgsqlTypes.NpgsqlPoint(x: 0.25723514568739103d, y: 0.7259959191860175d), new NpgsqlTypes.NpgsqlPoint(x: 0.41726415373093073d, y: 0.9344899291655868d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 169,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33382264500903847d, y: 0.93284228295358d), new NpgsqlTypes.NpgsqlPoint(x: 0.2811886172356305d, y: 0.8077342667417262d), new NpgsqlTypes.NpgsqlPoint(x: 0.35623507524863207d, y: 0.8832230376257029d)),
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069454461554177d, y: 0.5495309475939147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4707207754487226d, y: 0.8993431124713616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606531806615769d, y: 0.6421477459495707d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12325760237547934d, y: 0.4227006183159494d), new NpgsqlTypes.NpgsqlPoint(x: 0.06770055331172309d, y: 0.9486678956216673d), new NpgsqlTypes.NpgsqlPoint(x: 0.39369296273760246d, y: 0.5041858651901291d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22304892559953649d, y: 0.7773816838039863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9874352671638681d, y: 0.6677893534518551d), new NpgsqlTypes.NpgsqlPoint(x: 0.02752751616160798d, y: 0.40853458036327595d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12470917108033819d, y: 0.32042551135999775d), new NpgsqlTypes.NpgsqlPoint(x: 0.44154029634493874d, y: 0.17783320106505818d), new NpgsqlTypes.NpgsqlPoint(x: 0.8450087149007806d, y: 0.13287716701345365d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[31],_testData[34], false);
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
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr2.Value = 20;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[33],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[29],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 77, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[34], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 37, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 124, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 96, query1, 83, query2))
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[34], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 28, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 83, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 158, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[33],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 47, 83))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[34], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[30], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[31], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[32], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[33], false);NpgsqlPathpath0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 60);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[30], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[31], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[32], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[33], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43790729306972853d, y: 0.6214484702654599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308179066435217d, y: 0.036554268392423706d), new NpgsqlTypes.NpgsqlPoint(x: 0.12708217252822374d, y: 0.34086706225629704d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37807938561769106d, y: 0.9674330259019799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7570719410939917d, y: 0.18659830760815754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7065787562844357d, y: 0.13485596142784806d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2537949166471184d, y: 0.7298560649217349d), new NpgsqlTypes.NpgsqlPoint(x: 0.28181374623874234d, y: 0.13938883107080802d), new NpgsqlTypes.NpgsqlPoint(x: 0.8465163298234504d, y: 0.7234734261422837d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9598706778019734d, y: 0.26076728983216657d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239571974815269d, y: 0.26340415661766337d), new NpgsqlTypes.NpgsqlPoint(x: 0.277238225011159d, y: 0.3411347418116044d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8588633730170594d, y: 0.5332486203732779d), new NpgsqlTypes.NpgsqlPoint(x: 0.43505332332893587d, y: 0.7637740584767897d), new NpgsqlTypes.NpgsqlPoint(x: 0.30775376256218434d, y: 0.24635979189124657d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47583051717819425d, y: 0.4895677612120324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766892456800107d, y: 0.9876846379791514d), new NpgsqlTypes.NpgsqlPoint(x: 0.49486049732967585d, y: 0.691980768379251d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29157721083726085d, y: 0.6653374075431715d), new NpgsqlTypes.NpgsqlPoint(x: 0.002078333965740753d, y: 0.25451724090287486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583349044342593d, y: 0.759459371920596d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6898911973679384d, y: 0.07561236073404787d), new NpgsqlTypes.NpgsqlPoint(x: 0.24854756100839703d, y: 0.6499227070686664d), new NpgsqlTypes.NpgsqlPoint(x: 0.5025166031204804d, y: 0.048339084868457616d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4530514483334467d, y: 0.3604392132330204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8414452818048335d, y: 0.5364470778155659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7862469880151169d, y: 0.23335877465223842d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.282492619591039d, y: 0.4798185891560004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9393889139011935d, y: 0.23073167289295526d), new NpgsqlTypes.NpgsqlPoint(x: 0.27577447342550654d, y: 0.4094226565082645d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4571369469928992d, y: 0.9412620655746192d), new NpgsqlTypes.NpgsqlPoint(x: 0.03955635805851743d, y: 0.7718946164327927d), new NpgsqlTypes.NpgsqlPoint(x: 0.40083299201647427d, y: 0.32996146305504315d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19254494699988d, y: 0.7810996880338752d), new NpgsqlTypes.NpgsqlPoint(x: 0.49511570556789364d, y: 0.6499657267771569d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769877892147461d, y: 0.29470887094803344d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069454461554177d, y: 0.5495309475939147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4707207754487226d, y: 0.8993431124713616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606531806615769d, y: 0.6421477459495707d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5586491921515595d, y: 0.7729632746974718d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381797651744599d, y: 0.26145577307256584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7166470076581376d, y: 0.14363621618712774d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12325760237547934d, y: 0.4227006183159494d), new NpgsqlTypes.NpgsqlPoint(x: 0.06770055331172309d, y: 0.9486678956216673d), new NpgsqlTypes.NpgsqlPoint(x: 0.39369296273760246d, y: 0.5041858651901291d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32842449135578244d, y: 0.6542211047389276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163604716227065d, y: 0.46836070361338067d), new NpgsqlTypes.NpgsqlPoint(x: 0.11678971448146946d, y: 0.3291190177910268d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.583088660783242d, y: 0.5575422699349951d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723532875187085d, y: 0.021455435816641333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7198243259129202d, y: 0.3565544619146864d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.599173439999589d, y: 0.9879513596542615d), new NpgsqlTypes.NpgsqlPoint(x: 0.24441930982851534d, y: 0.7034338870652629d), new NpgsqlTypes.NpgsqlPoint(x: 0.004171367795127612d, y: 0.6216592643729181d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5659421231155419d, y: 0.09059483914768596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5580224279009272d, y: 0.9164970300408647d), new NpgsqlTypes.NpgsqlPoint(x: 0.715400757964718d, y: 0.45785222483399457d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22304892559953649d, y: 0.7773816838039863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9874352671638681d, y: 0.6677893534518551d), new NpgsqlTypes.NpgsqlPoint(x: 0.02752751616160798d, y: 0.40853458036327595d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9139761208238144d, y: 0.2575233988586896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8627093784399971d, y: 0.7821202085183189d), new NpgsqlTypes.NpgsqlPoint(x: 0.7975048712869736d, y: 0.5675097877338994d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8661227768441784d, y: 0.4467600713568024d), new NpgsqlTypes.NpgsqlPoint(x: 0.01988796604942611d, y: 0.0872964079743982d), new NpgsqlTypes.NpgsqlPoint(x: 0.43931851650224585d, y: 0.6533908736126787d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5016009630161942d, y: 0.5944008870415256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8814666562160759d, y: 0.7943983988186841d), new NpgsqlTypes.NpgsqlPoint(x: 0.33976277178616077d, y: 0.24271559666238895d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12470917108033819d, y: 0.32042551135999775d), new NpgsqlTypes.NpgsqlPoint(x: 0.44154029634493874d, y: 0.17783320106505818d), new NpgsqlTypes.NpgsqlPoint(x: 0.8450087149007806d, y: 0.13287716701345365d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6687450678135194d, y: 0.16165003495849606d), new NpgsqlTypes.NpgsqlPoint(x: 0.2726827674371879d, y: 0.39314026874054964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036918513615521d, y: 0.42524731190702536d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37746482284312766d, y: 0.45439374297321367d), new NpgsqlTypes.NpgsqlPoint(x: 0.3296363391164262d, y: 0.6408104260778252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8093549654037617d, y: 0.06408144588884679d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4212277415727955d, y: 0.7357482814453481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293221560265306d, y: 0.36217077501335604d), new NpgsqlTypes.NpgsqlPoint(x: 0.4139730245862223d, y: 0.9885857262611706d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7501054721922943d, y: 0.8375411986506774d), new NpgsqlTypes.NpgsqlPoint(x: 0.11894222136187982d, y: 0.7035033675667455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672709702740561d, y: 0.9966649576060918d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5954658283182486d, y: 0.9587775473268841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8291267418561911d, y: 0.21818586614413604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7100251834321003d, y: 0.8541975184215623d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5090349684179565d, y: 0.45576257954527843d), new NpgsqlTypes.NpgsqlPoint(x: 0.4818205019501429d, y: 0.0846132344000663d), new NpgsqlTypes.NpgsqlPoint(x: 0.17494529506077294d, y: 0.6729149749858456d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6195159117854105d, y: 0.738427609727085d), new NpgsqlTypes.NpgsqlPoint(x: 0.24744392168969176d, y: 0.13922687389637267d), new NpgsqlTypes.NpgsqlPoint(x: 0.11543402161693905d, y: 0.5090105982402684d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7312222766264723d, y: 0.04984378647857346d), new NpgsqlTypes.NpgsqlPoint(x: 0.05346152781594038d, y: 0.9698193361475286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9600404475823205d, y: 0.5166605426102052d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9742908961188724d, y: 0.14885296126194092d), new NpgsqlTypes.NpgsqlPoint(x: 0.409100201704258d, y: 0.7807750143782552d), new NpgsqlTypes.NpgsqlPoint(x: 0.9461563869557698d, y: 0.4875175633221551d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9236918392240421d, y: 0.10205484348386762d), new NpgsqlTypes.NpgsqlPoint(x: 0.09619233340253175d, y: 0.5777323080136576d), new NpgsqlTypes.NpgsqlPoint(x: 0.2741051729860361d, y: 0.42674033013335677d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5183274869739493d, y: 0.427115965627624d), new NpgsqlTypes.NpgsqlPoint(x: 0.32564649313940763d, y: 0.6208567138490512d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252508153456994d, y: 0.4106573715712736d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0208154491996122d, y: 0.4575787252167053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5357826457155677d, y: 0.995831634618353d), new NpgsqlTypes.NpgsqlPoint(x: 0.22326905680039755d, y: 0.7861728019122366d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9167470122147336d, y: 0.3438303378757458d), new NpgsqlTypes.NpgsqlPoint(x: 0.24331916909438744d, y: 0.5667627993406834d), new NpgsqlTypes.NpgsqlPoint(x: 0.41963604712486113d, y: 0.4447211279432264d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8135736676106259d, y: 0.32682947292500153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455087875265662d, y: 0.2400348646213486d), new NpgsqlTypes.NpgsqlPoint(x: 0.02116488310275555d, y: 0.3947550846416398d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3710191614597791d, y: 0.883643392958184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3657569092268964d, y: 0.24452987276827365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567614035391283d, y: 0.33197472373470016d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6531562106979296d, y: 0.8207885552038151d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093961761151989d, y: 0.4019127648969074d), new NpgsqlTypes.NpgsqlPoint(x: 0.37154193984695083d, y: 0.04314346444231387d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40159036184000296d, y: 0.22852353046422824d), new NpgsqlTypes.NpgsqlPoint(x: 0.7633116856612583d, y: 0.05360331282536568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433900222816777d, y: 0.8144808520352143d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6153420968116541d, y: 0.9972641014433721d), new NpgsqlTypes.NpgsqlPoint(x: 0.0960575068499645d, y: 0.8665117836720893d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348542644488099d, y: 0.19028872792710627d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9844237474446607d, y: 0.061934690628360545d), new NpgsqlTypes.NpgsqlPoint(x: 0.0818140826353938d, y: 0.5717702194079182d), new NpgsqlTypes.NpgsqlPoint(x: 0.19538756866715912d, y: 0.7050467469325891d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28727609086113426d, y: 0.787411969221508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618002140728112d, y: 0.40297605839050843d), new NpgsqlTypes.NpgsqlPoint(x: 0.2032485120510118d, y: 0.7929260881256662d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9805506613774115d, y: 0.7808079706056708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6184998879857374d, y: 0.5534434513025757d), new NpgsqlTypes.NpgsqlPoint(x: 0.1832470247064495d, y: 0.2655811901544478d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6955251762397474d, y: 0.9053164406762348d), new NpgsqlTypes.NpgsqlPoint(x: 0.6825940259743916d, y: 0.018209095042432843d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218525775911613d, y: 0.2587806523336388d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.78391980848628d, y: 0.5639454196918585d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434404449968944d, y: 0.8455074765534156d), new NpgsqlTypes.NpgsqlPoint(x: 0.538214922611127d, y: 0.32697166355044716d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2031300565721622d, y: 0.442138505563202d), new NpgsqlTypes.NpgsqlPoint(x: 0.04174729061449989d, y: 0.6518567178484861d), new NpgsqlTypes.NpgsqlPoint(x: 0.3501371873674076d, y: 0.08711824759700948d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8976625158649106d, y: 0.8220851105922493d), new NpgsqlTypes.NpgsqlPoint(x: 0.21745623080523413d, y: 0.9682393749771229d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693576260261043d, y: 0.808724338280061d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8169022764545131d, y: 0.5449294998470344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247260977616384d, y: 0.7137786832740869d), new NpgsqlTypes.NpgsqlPoint(x: 0.1523726801917651d, y: 0.6775215839275591d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14568836584913714d, y: 0.6650197698672475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5033993985951805d, y: 0.42547784486260043d), new NpgsqlTypes.NpgsqlPoint(x: 0.7354922808413177d, y: 0.628359066890898d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4231380553091617d, y: 0.7509658073838609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9956770820470374d, y: 0.4102063692218352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5659280201909085d, y: 0.4653000920050623d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17035037653067298d, y: 0.8973789373067101d), new NpgsqlTypes.NpgsqlPoint(x: 0.1415486630749675d, y: 0.44996749751948384d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358530319296898d, y: 0.9093079156361832d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3022281408963339d, y: 0.9791271125046762d), new NpgsqlTypes.NpgsqlPoint(x: 0.7024873359606352d, y: 0.496429284814802d), new NpgsqlTypes.NpgsqlPoint(x: 0.02066093834423255d, y: 0.966319991404019d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2727545772539949d, y: 0.5978334083049541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9001255644682863d, y: 0.3202257426101207d), new NpgsqlTypes.NpgsqlPoint(x: 0.3724988357419683d, y: 0.5619533882380935d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8121063871091538d, y: 0.2657981637652952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9884158781985715d, y: 0.6399282711096219d), new NpgsqlTypes.NpgsqlPoint(x: 0.10522884101854402d, y: 0.11359444077103398d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9860153438747862d, y: 0.9090172345400359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8176357743250137d, y: 0.8265132805862213d), new NpgsqlTypes.NpgsqlPoint(x: 0.287184424363239d, y: 0.6977861416820732d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1145305159027552d, y: 0.8750395556099508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5409569267573935d, y: 0.5186673931742294d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973068437950062d, y: 0.2675191075580834d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9155691255574243d, y: 0.2573837687778565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8815154621965954d, y: 0.11521922892651337d), new NpgsqlTypes.NpgsqlPoint(x: 0.2872614718254729d, y: 0.5786641184719707d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08196703373747816d, y: 0.2990417781043464d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661793738515591d, y: 0.7093598840545853d), new NpgsqlTypes.NpgsqlPoint(x: 0.2055855776148675d, y: 0.15758829777952632d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22002732047980444d, y: 0.9476072004489351d), new NpgsqlTypes.NpgsqlPoint(x: 0.8907140174374324d, y: 0.7955061011904552d), new NpgsqlTypes.NpgsqlPoint(x: 0.039355553130572596d, y: 0.2109210936251632d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7799054296483565d, y: 0.4916450959250228d), new NpgsqlTypes.NpgsqlPoint(x: 0.6259412907320818d, y: 0.47902413236984653d), new NpgsqlTypes.NpgsqlPoint(x: 0.04055010212299992d, y: 0.9465954357755779d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007191879639958376d, y: 0.3925733361035605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5921357305681056d, y: 0.4432225420334748d), new NpgsqlTypes.NpgsqlPoint(x: 0.7352610819960579d, y: 0.4669966854346158d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8365871886400197d, y: 0.1072527675898658d), new NpgsqlTypes.NpgsqlPoint(x: 0.3489116202695284d, y: 0.841361382080918d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732054468242643d, y: 0.08682479150717415d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8558217914091135d, y: 0.23557901076571008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7282537870224132d, y: 0.9500846318642425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882783014388342d, y: 0.15304748572572313d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8301751076990777d, y: 0.5276558172223839d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902315631758377d, y: 0.4359849277348864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6994972917741041d, y: 0.07699895992478767d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04080216435134454d, y: 0.41034084903876866d), new NpgsqlTypes.NpgsqlPoint(x: 0.2569157496646187d, y: 0.10597580089298098d), new NpgsqlTypes.NpgsqlPoint(x: 0.3511165741716008d, y: 0.5064468160932508d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12093253190358377d, y: 0.046664336814645324d), new NpgsqlTypes.NpgsqlPoint(x: 0.959922579429417d, y: 0.7351304899089715d), new NpgsqlTypes.NpgsqlPoint(x: 0.1203386218325101d, y: 0.873284692530528d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8833220330251179d, y: 0.8163618656299212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6208448298126767d, y: 0.40658889933560094d), new NpgsqlTypes.NpgsqlPoint(x: 0.3896105988650229d, y: 0.7424940536437078d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2745709677308127d, y: 0.053514651545063185d), new NpgsqlTypes.NpgsqlPoint(x: 0.07759778468138101d, y: 0.9653335359373811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980433291153111d, y: 0.8137766902526063d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16357766884062008d, y: 0.8857850457028974d), new NpgsqlTypes.NpgsqlPoint(x: 0.24339647788904917d, y: 0.9493718689348222d), new NpgsqlTypes.NpgsqlPoint(x: 0.36115058199536865d, y: 0.43071305091312206d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11616794572539235d, y: 0.27765019865026175d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549425944545161d, y: 0.40878948226578515d), new NpgsqlTypes.NpgsqlPoint(x: 0.38630290534783707d, y: 0.7661845120001277d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0736987379502364d, y: 0.19741479202483125d), new NpgsqlTypes.NpgsqlPoint(x: 0.101536521286127d, y: 0.12387065931781516d), new NpgsqlTypes.NpgsqlPoint(x: 0.09957584171328515d, y: 0.4433885321805817d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05079170941162603d, y: 0.4887059957569322d), new NpgsqlTypes.NpgsqlPoint(x: 0.25723514568739103d, y: 0.7259959191860175d), new NpgsqlTypes.NpgsqlPoint(x: 0.41726415373093073d, y: 0.9344899291655868d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33382264500903847d, y: 0.93284228295358d), new NpgsqlTypes.NpgsqlPoint(x: 0.2811886172356305d, y: 0.8077342667417262d), new NpgsqlTypes.NpgsqlPoint(x: 0.35623507524863207d, y: 0.8832230376257029d)))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43790729306972853d, y: 0.6214484702654599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308179066435217d, y: 0.036554268392423706d), new NpgsqlTypes.NpgsqlPoint(x: 0.12708217252822374d, y: 0.34086706225629704d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37807938561769106d, y: 0.9674330259019799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7570719410939917d, y: 0.18659830760815754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7065787562844357d, y: 0.13485596142784806d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2537949166471184d, y: 0.7298560649217349d), new NpgsqlTypes.NpgsqlPoint(x: 0.28181374623874234d, y: 0.13938883107080802d), new NpgsqlTypes.NpgsqlPoint(x: 0.8465163298234504d, y: 0.7234734261422837d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9598706778019734d, y: 0.26076728983216657d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239571974815269d, y: 0.26340415661766337d), new NpgsqlTypes.NpgsqlPoint(x: 0.277238225011159d, y: 0.3411347418116044d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8588633730170594d, y: 0.5332486203732779d), new NpgsqlTypes.NpgsqlPoint(x: 0.43505332332893587d, y: 0.7637740584767897d), new NpgsqlTypes.NpgsqlPoint(x: 0.30775376256218434d, y: 0.24635979189124657d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47583051717819425d, y: 0.4895677612120324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766892456800107d, y: 0.9876846379791514d), new NpgsqlTypes.NpgsqlPoint(x: 0.49486049732967585d, y: 0.691980768379251d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29157721083726085d, y: 0.6653374075431715d), new NpgsqlTypes.NpgsqlPoint(x: 0.002078333965740753d, y: 0.25451724090287486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583349044342593d, y: 0.759459371920596d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6898911973679384d, y: 0.07561236073404787d), new NpgsqlTypes.NpgsqlPoint(x: 0.24854756100839703d, y: 0.6499227070686664d), new NpgsqlTypes.NpgsqlPoint(x: 0.5025166031204804d, y: 0.048339084868457616d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4530514483334467d, y: 0.3604392132330204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8414452818048335d, y: 0.5364470778155659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7862469880151169d, y: 0.23335877465223842d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.282492619591039d, y: 0.4798185891560004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9393889139011935d, y: 0.23073167289295526d), new NpgsqlTypes.NpgsqlPoint(x: 0.27577447342550654d, y: 0.4094226565082645d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4571369469928992d, y: 0.9412620655746192d), new NpgsqlTypes.NpgsqlPoint(x: 0.03955635805851743d, y: 0.7718946164327927d), new NpgsqlTypes.NpgsqlPoint(x: 0.40083299201647427d, y: 0.32996146305504315d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19254494699988d, y: 0.7810996880338752d), new NpgsqlTypes.NpgsqlPoint(x: 0.49511570556789364d, y: 0.6499657267771569d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769877892147461d, y: 0.29470887094803344d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069454461554177d, y: 0.5495309475939147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4707207754487226d, y: 0.8993431124713616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606531806615769d, y: 0.6421477459495707d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5586491921515595d, y: 0.7729632746974718d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381797651744599d, y: 0.26145577307256584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7166470076581376d, y: 0.14363621618712774d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12325760237547934d, y: 0.4227006183159494d), new NpgsqlTypes.NpgsqlPoint(x: 0.06770055331172309d, y: 0.9486678956216673d), new NpgsqlTypes.NpgsqlPoint(x: 0.39369296273760246d, y: 0.5041858651901291d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32842449135578244d, y: 0.6542211047389276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163604716227065d, y: 0.46836070361338067d), new NpgsqlTypes.NpgsqlPoint(x: 0.11678971448146946d, y: 0.3291190177910268d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.583088660783242d, y: 0.5575422699349951d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723532875187085d, y: 0.021455435816641333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7198243259129202d, y: 0.3565544619146864d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.599173439999589d, y: 0.9879513596542615d), new NpgsqlTypes.NpgsqlPoint(x: 0.24441930982851534d, y: 0.7034338870652629d), new NpgsqlTypes.NpgsqlPoint(x: 0.004171367795127612d, y: 0.6216592643729181d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5659421231155419d, y: 0.09059483914768596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5580224279009272d, y: 0.9164970300408647d), new NpgsqlTypes.NpgsqlPoint(x: 0.715400757964718d, y: 0.45785222483399457d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22304892559953649d, y: 0.7773816838039863d), new NpgsqlTypes.NpgsqlPoint(x: 0.9874352671638681d, y: 0.6677893534518551d), new NpgsqlTypes.NpgsqlPoint(x: 0.02752751616160798d, y: 0.40853458036327595d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9139761208238144d, y: 0.2575233988586896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8627093784399971d, y: 0.7821202085183189d), new NpgsqlTypes.NpgsqlPoint(x: 0.7975048712869736d, y: 0.5675097877338994d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8661227768441784d, y: 0.4467600713568024d), new NpgsqlTypes.NpgsqlPoint(x: 0.01988796604942611d, y: 0.0872964079743982d), new NpgsqlTypes.NpgsqlPoint(x: 0.43931851650224585d, y: 0.6533908736126787d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5016009630161942d, y: 0.5944008870415256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8814666562160759d, y: 0.7943983988186841d), new NpgsqlTypes.NpgsqlPoint(x: 0.33976277178616077d, y: 0.24271559666238895d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12470917108033819d, y: 0.32042551135999775d), new NpgsqlTypes.NpgsqlPoint(x: 0.44154029634493874d, y: 0.17783320106505818d), new NpgsqlTypes.NpgsqlPoint(x: 0.8450087149007806d, y: 0.13287716701345365d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6687450678135194d, y: 0.16165003495849606d), new NpgsqlTypes.NpgsqlPoint(x: 0.2726827674371879d, y: 0.39314026874054964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036918513615521d, y: 0.42524731190702536d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37746482284312766d, y: 0.45439374297321367d), new NpgsqlTypes.NpgsqlPoint(x: 0.3296363391164262d, y: 0.6408104260778252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8093549654037617d, y: 0.06408144588884679d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4212277415727955d, y: 0.7357482814453481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293221560265306d, y: 0.36217077501335604d), new NpgsqlTypes.NpgsqlPoint(x: 0.4139730245862223d, y: 0.9885857262611706d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7501054721922943d, y: 0.8375411986506774d), new NpgsqlTypes.NpgsqlPoint(x: 0.11894222136187982d, y: 0.7035033675667455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672709702740561d, y: 0.9966649576060918d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5954658283182486d, y: 0.9587775473268841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8291267418561911d, y: 0.21818586614413604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7100251834321003d, y: 0.8541975184215623d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5090349684179565d, y: 0.45576257954527843d), new NpgsqlTypes.NpgsqlPoint(x: 0.4818205019501429d, y: 0.0846132344000663d), new NpgsqlTypes.NpgsqlPoint(x: 0.17494529506077294d, y: 0.6729149749858456d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6195159117854105d, y: 0.738427609727085d), new NpgsqlTypes.NpgsqlPoint(x: 0.24744392168969176d, y: 0.13922687389637267d), new NpgsqlTypes.NpgsqlPoint(x: 0.11543402161693905d, y: 0.5090105982402684d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7312222766264723d, y: 0.04984378647857346d), new NpgsqlTypes.NpgsqlPoint(x: 0.05346152781594038d, y: 0.9698193361475286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9600404475823205d, y: 0.5166605426102052d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9742908961188724d, y: 0.14885296126194092d), new NpgsqlTypes.NpgsqlPoint(x: 0.409100201704258d, y: 0.7807750143782552d), new NpgsqlTypes.NpgsqlPoint(x: 0.9461563869557698d, y: 0.4875175633221551d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9236918392240421d, y: 0.10205484348386762d), new NpgsqlTypes.NpgsqlPoint(x: 0.09619233340253175d, y: 0.5777323080136576d), new NpgsqlTypes.NpgsqlPoint(x: 0.2741051729860361d, y: 0.42674033013335677d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5183274869739493d, y: 0.427115965627624d), new NpgsqlTypes.NpgsqlPoint(x: 0.32564649313940763d, y: 0.6208567138490512d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252508153456994d, y: 0.4106573715712736d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0208154491996122d, y: 0.4575787252167053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5357826457155677d, y: 0.995831634618353d), new NpgsqlTypes.NpgsqlPoint(x: 0.22326905680039755d, y: 0.7861728019122366d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9167470122147336d, y: 0.3438303378757458d), new NpgsqlTypes.NpgsqlPoint(x: 0.24331916909438744d, y: 0.5667627993406834d), new NpgsqlTypes.NpgsqlPoint(x: 0.41963604712486113d, y: 0.4447211279432264d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8135736676106259d, y: 0.32682947292500153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455087875265662d, y: 0.2400348646213486d), new NpgsqlTypes.NpgsqlPoint(x: 0.02116488310275555d, y: 0.3947550846416398d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3710191614597791d, y: 0.883643392958184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3657569092268964d, y: 0.24452987276827365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567614035391283d, y: 0.33197472373470016d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6531562106979296d, y: 0.8207885552038151d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093961761151989d, y: 0.4019127648969074d), new NpgsqlTypes.NpgsqlPoint(x: 0.37154193984695083d, y: 0.04314346444231387d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40159036184000296d, y: 0.22852353046422824d), new NpgsqlTypes.NpgsqlPoint(x: 0.7633116856612583d, y: 0.05360331282536568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433900222816777d, y: 0.8144808520352143d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6153420968116541d, y: 0.9972641014433721d), new NpgsqlTypes.NpgsqlPoint(x: 0.0960575068499645d, y: 0.8665117836720893d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348542644488099d, y: 0.19028872792710627d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9844237474446607d, y: 0.061934690628360545d), new NpgsqlTypes.NpgsqlPoint(x: 0.0818140826353938d, y: 0.5717702194079182d), new NpgsqlTypes.NpgsqlPoint(x: 0.19538756866715912d, y: 0.7050467469325891d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28727609086113426d, y: 0.787411969221508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618002140728112d, y: 0.40297605839050843d), new NpgsqlTypes.NpgsqlPoint(x: 0.2032485120510118d, y: 0.7929260881256662d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9805506613774115d, y: 0.7808079706056708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6184998879857374d, y: 0.5534434513025757d), new NpgsqlTypes.NpgsqlPoint(x: 0.1832470247064495d, y: 0.2655811901544478d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6955251762397474d, y: 0.9053164406762348d), new NpgsqlTypes.NpgsqlPoint(x: 0.6825940259743916d, y: 0.018209095042432843d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218525775911613d, y: 0.2587806523336388d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.78391980848628d, y: 0.5639454196918585d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434404449968944d, y: 0.8455074765534156d), new NpgsqlTypes.NpgsqlPoint(x: 0.538214922611127d, y: 0.32697166355044716d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2031300565721622d, y: 0.442138505563202d), new NpgsqlTypes.NpgsqlPoint(x: 0.04174729061449989d, y: 0.6518567178484861d), new NpgsqlTypes.NpgsqlPoint(x: 0.3501371873674076d, y: 0.08711824759700948d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8976625158649106d, y: 0.8220851105922493d), new NpgsqlTypes.NpgsqlPoint(x: 0.21745623080523413d, y: 0.9682393749771229d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693576260261043d, y: 0.808724338280061d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8169022764545131d, y: 0.5449294998470344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247260977616384d, y: 0.7137786832740869d), new NpgsqlTypes.NpgsqlPoint(x: 0.1523726801917651d, y: 0.6775215839275591d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14568836584913714d, y: 0.6650197698672475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5033993985951805d, y: 0.42547784486260043d), new NpgsqlTypes.NpgsqlPoint(x: 0.7354922808413177d, y: 0.628359066890898d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4231380553091617d, y: 0.7509658073838609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9956770820470374d, y: 0.4102063692218352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5659280201909085d, y: 0.4653000920050623d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17035037653067298d, y: 0.8973789373067101d), new NpgsqlTypes.NpgsqlPoint(x: 0.1415486630749675d, y: 0.44996749751948384d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358530319296898d, y: 0.9093079156361832d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3022281408963339d, y: 0.9791271125046762d), new NpgsqlTypes.NpgsqlPoint(x: 0.7024873359606352d, y: 0.496429284814802d), new NpgsqlTypes.NpgsqlPoint(x: 0.02066093834423255d, y: 0.966319991404019d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2727545772539949d, y: 0.5978334083049541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9001255644682863d, y: 0.3202257426101207d), new NpgsqlTypes.NpgsqlPoint(x: 0.3724988357419683d, y: 0.5619533882380935d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8121063871091538d, y: 0.2657981637652952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9884158781985715d, y: 0.6399282711096219d), new NpgsqlTypes.NpgsqlPoint(x: 0.10522884101854402d, y: 0.11359444077103398d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9860153438747862d, y: 0.9090172345400359d), new NpgsqlTypes.NpgsqlPoint(x: 0.8176357743250137d, y: 0.8265132805862213d), new NpgsqlTypes.NpgsqlPoint(x: 0.287184424363239d, y: 0.6977861416820732d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1145305159027552d, y: 0.8750395556099508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5409569267573935d, y: 0.5186673931742294d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973068437950062d, y: 0.2675191075580834d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9155691255574243d, y: 0.2573837687778565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8815154621965954d, y: 0.11521922892651337d), new NpgsqlTypes.NpgsqlPoint(x: 0.2872614718254729d, y: 0.5786641184719707d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08196703373747816d, y: 0.2990417781043464d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661793738515591d, y: 0.7093598840545853d), new NpgsqlTypes.NpgsqlPoint(x: 0.2055855776148675d, y: 0.15758829777952632d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22002732047980444d, y: 0.9476072004489351d), new NpgsqlTypes.NpgsqlPoint(x: 0.8907140174374324d, y: 0.7955061011904552d), new NpgsqlTypes.NpgsqlPoint(x: 0.039355553130572596d, y: 0.2109210936251632d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7799054296483565d, y: 0.4916450959250228d), new NpgsqlTypes.NpgsqlPoint(x: 0.6259412907320818d, y: 0.47902413236984653d), new NpgsqlTypes.NpgsqlPoint(x: 0.04055010212299992d, y: 0.9465954357755779d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007191879639958376d, y: 0.3925733361035605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5921357305681056d, y: 0.4432225420334748d), new NpgsqlTypes.NpgsqlPoint(x: 0.7352610819960579d, y: 0.4669966854346158d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8365871886400197d, y: 0.1072527675898658d), new NpgsqlTypes.NpgsqlPoint(x: 0.3489116202695284d, y: 0.841361382080918d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732054468242643d, y: 0.08682479150717415d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8558217914091135d, y: 0.23557901076571008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7282537870224132d, y: 0.9500846318642425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882783014388342d, y: 0.15304748572572313d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8301751076990777d, y: 0.5276558172223839d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902315631758377d, y: 0.4359849277348864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6994972917741041d, y: 0.07699895992478767d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04080216435134454d, y: 0.41034084903876866d), new NpgsqlTypes.NpgsqlPoint(x: 0.2569157496646187d, y: 0.10597580089298098d), new NpgsqlTypes.NpgsqlPoint(x: 0.3511165741716008d, y: 0.5064468160932508d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12093253190358377d, y: 0.046664336814645324d), new NpgsqlTypes.NpgsqlPoint(x: 0.959922579429417d, y: 0.7351304899089715d), new NpgsqlTypes.NpgsqlPoint(x: 0.1203386218325101d, y: 0.873284692530528d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8833220330251179d, y: 0.8163618656299212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6208448298126767d, y: 0.40658889933560094d), new NpgsqlTypes.NpgsqlPoint(x: 0.3896105988650229d, y: 0.7424940536437078d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2745709677308127d, y: 0.053514651545063185d), new NpgsqlTypes.NpgsqlPoint(x: 0.07759778468138101d, y: 0.9653335359373811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980433291153111d, y: 0.8137766902526063d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16357766884062008d, y: 0.8857850457028974d), new NpgsqlTypes.NpgsqlPoint(x: 0.24339647788904917d, y: 0.9493718689348222d), new NpgsqlTypes.NpgsqlPoint(x: 0.36115058199536865d, y: 0.43071305091312206d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11616794572539235d, y: 0.27765019865026175d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549425944545161d, y: 0.40878948226578515d), new NpgsqlTypes.NpgsqlPoint(x: 0.38630290534783707d, y: 0.7661845120001277d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0736987379502364d, y: 0.19741479202483125d), new NpgsqlTypes.NpgsqlPoint(x: 0.101536521286127d, y: 0.12387065931781516d), new NpgsqlTypes.NpgsqlPoint(x: 0.09957584171328515d, y: 0.4433885321805817d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05079170941162603d, y: 0.4887059957569322d), new NpgsqlTypes.NpgsqlPoint(x: 0.25723514568739103d, y: 0.7259959191860175d), new NpgsqlTypes.NpgsqlPoint(x: 0.41726415373093073d, y: 0.9344899291655868d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33382264500903847d, y: 0.93284228295358d), new NpgsqlTypes.NpgsqlPoint(x: 0.2811886172356305d, y: 0.8077342667417262d), new NpgsqlTypes.NpgsqlPoint(x: 0.35623507524863207d, y: 0.8832230376257029d)))));//Value

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

