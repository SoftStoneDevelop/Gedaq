

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
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0536410111250768d, y: 0.33659721306243906d), new NpgsqlTypes.NpgsqlPoint(x: 0.32152677825882225d, y: 0.47414516561581377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4638045413926446d, y: 0.6179586531145372d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7443350405594508d, y: 0.32858686034802187d), new NpgsqlTypes.NpgsqlPoint(x: 0.08217038486357786d, y: 0.27538460314289814d), new NpgsqlTypes.NpgsqlPoint(x: 0.01130789582981695d, y: 0.5219927005846425d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8441703319161898d, y: 0.4685553968037419d), new NpgsqlTypes.NpgsqlPoint(x: 0.05007907756093066d, y: 0.22848130531183752d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077952518563703d, y: 0.6153944177517816d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.717243813964802d, y: 0.06629059534764825d), new NpgsqlTypes.NpgsqlPoint(x: 0.5392518602565026d, y: 0.2922687322819155d), new NpgsqlTypes.NpgsqlPoint(x: 0.715543595640661d, y: 0.3575726846828794d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6900971134692095d, y: 0.7709110518314701d), new NpgsqlTypes.NpgsqlPoint(x: 0.4729200826910127d, y: 0.3849682896730925d), new NpgsqlTypes.NpgsqlPoint(x: 0.6422031218380242d, y: 0.24807247281141653d)),
},
            new NpgsqlPathpath0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3015582372597141d, y: 0.1485400853379102d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735503416511455d, y: 0.3101594446435393d), new NpgsqlTypes.NpgsqlPoint(x: 0.37524136577842326d, y: 0.25386970676325615d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42679746136906593d, y: 0.6531013347938509d), new NpgsqlTypes.NpgsqlPoint(x: 0.48432409410863086d, y: 0.29077416518614707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7329473525084316d, y: 0.474062230701347d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5736805179632568d, y: 0.6718464953833362d), new NpgsqlTypes.NpgsqlPoint(x: 0.45814546508068277d, y: 0.5202911885828373d), new NpgsqlTypes.NpgsqlPoint(x: 0.1500652812180916d, y: 0.04907489120651565d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4790909297973166d, y: 0.7956444534384394d), new NpgsqlTypes.NpgsqlPoint(x: 0.36914181196109697d, y: 0.6084010075368012d), new NpgsqlTypes.NpgsqlPoint(x: 0.027890042958798933d, y: 0.06647535478181121d)),
},
            new NpgsqlPathpath0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10057475712570385d, y: 0.6249350254115459d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908376523591869d, y: 0.6282717934219862d), new NpgsqlTypes.NpgsqlPoint(x: 0.735986590208515d, y: 0.8599849602953809d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512936371121094d, y: 0.14423034903816967d), new NpgsqlTypes.NpgsqlPoint(x: 0.11225657837563474d, y: 0.5099471035063402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9811755969821204d, y: 0.9391955749658212d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9534828655548118d, y: 0.9050466408640995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9212569308521883d, y: 0.08535217779769788d), new NpgsqlTypes.NpgsqlPoint(x: 0.57420186350226d, y: 0.08329777324527843d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6402747562799025d, y: 0.21060036440977248d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003530683605579d, y: 0.7082175879016686d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175050186287245d, y: 0.6241840577409891d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6330368071687338d, y: 0.024269160093082554d), new NpgsqlTypes.NpgsqlPoint(x: 0.14061204302880392d, y: 0.022807765742632213d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867144705694763d, y: 0.7789457205465579d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7435974942510737d, y: 0.9597983999668412d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661256568458177d, y: 0.17431542948556855d), new NpgsqlTypes.NpgsqlPoint(x: 0.07302223544126785d, y: 0.7840457274964145d)),
},
            new NpgsqlPathpath0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9622516982564201d, y: 0.04305683153972162d), new NpgsqlTypes.NpgsqlPoint(x: 0.10334917680552858d, y: 0.9915709532227435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023023625898537d, y: 0.5274842283865923d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1737008214929744d, y: 0.63673608681085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331054936237582d, y: 0.7006862059290754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412611055809646d, y: 0.6591791478833547d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6629278368030823d, y: 0.4628684428078018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436701099840892d, y: 0.42086046739841343d), new NpgsqlTypes.NpgsqlPoint(x: 0.15061559744075959d, y: 0.3885567128182028d)),
},
            new NpgsqlPathpath0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8534417199444202d, y: 0.26084002011322627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141783536723483d, y: 0.8234301840504252d), new NpgsqlTypes.NpgsqlPoint(x: 0.36803304348712507d, y: 0.26446156408205956d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27841114389437904d, y: 0.5815423278141978d), new NpgsqlTypes.NpgsqlPoint(x: 0.97333351790376d, y: 0.7854824762940916d), new NpgsqlTypes.NpgsqlPoint(x: 0.48328336399103067d, y: 0.11397155312683915d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4778553482912794d, y: 0.1125192830843984d), new NpgsqlTypes.NpgsqlPoint(x: 0.323305377681511d, y: 0.05670475011226872d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299455612376591d, y: 0.9258271459051252d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6004532217364614d, y: 0.5334348386287041d), new NpgsqlTypes.NpgsqlPoint(x: 0.14278349036625482d, y: 0.151231746060698d), new NpgsqlTypes.NpgsqlPoint(x: 0.13930918115900337d, y: 0.03215101901502393d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6570032366326274d, y: 0.9771928785589941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253297363823162d, y: 0.020897612541827648d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632705080695649d, y: 0.22478856096268907d)),
},
            new NpgsqlPathpath0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4438556928180809d, y: 0.0832502260350646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8529219107709491d, y: 0.7444084069655857d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649526326120329d, y: 0.08303736105089832d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18197966671246835d, y: 0.479043682182695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7899886759242409d, y: 0.3720668483387788d), new NpgsqlTypes.NpgsqlPoint(x: 0.2912812223452368d, y: 0.03497308904357277d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4861234080544269d, y: 0.46289359795521756d), new NpgsqlTypes.NpgsqlPoint(x: 0.832592577297058d, y: 0.0648023869681491d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825221995138901d, y: 0.976993102114295d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6049934452905482d, y: 0.5601856769662622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6877749139675509d, y: 0.17539056057746638d), new NpgsqlTypes.NpgsqlPoint(x: 0.38893535012450475d, y: 0.08769115862424848d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1631786292877755d, y: 0.6875056395317607d), new NpgsqlTypes.NpgsqlPoint(x: 0.46175242961173646d, y: 0.9319945287512756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5607763033406549d, y: 0.9534350001406103d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8653826962281793d, y: 0.5648820621355007d), new NpgsqlTypes.NpgsqlPoint(x: 0.64657001779597d, y: 0.3601335967454984d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406944592011163d, y: 0.23586133787201402d)),
},
            new NpgsqlPathpath0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6829426739129077d, y: 0.1509856203299219d), new NpgsqlTypes.NpgsqlPoint(x: 0.9490911021460292d, y: 0.6962146151196394d), new NpgsqlTypes.NpgsqlPoint(x: 0.14020755946333074d, y: 0.16758087702643243d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1375320801262856d, y: 0.0175674629306789d), new NpgsqlTypes.NpgsqlPoint(x: 0.6575275231296668d, y: 0.9401211497315769d), new NpgsqlTypes.NpgsqlPoint(x: 0.19818623511852007d, y: 0.40387042754507796d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30925291966459434d, y: 0.8993794526756954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823052496986004d, y: 0.7794468093406605d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964536884969744d, y: 0.6410208702437855d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3247558341143444d, y: 0.9783405353130606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5650778617109878d, y: 0.7611356632433691d), new NpgsqlTypes.NpgsqlPoint(x: 0.5435553043018588d, y: 0.9495354552451507d)),
},
            new NpgsqlPathpath0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5665918403180079d, y: 0.6184363765318199d), new NpgsqlTypes.NpgsqlPoint(x: 0.835694657402456d, y: 0.32747151151936693d), new NpgsqlTypes.NpgsqlPoint(x: 0.550035624064553d, y: 0.9119027910524964d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016291964252645008d, y: 0.8998487330256921d), new NpgsqlTypes.NpgsqlPoint(x: 0.059392322992037117d, y: 0.2910723876873148d), new NpgsqlTypes.NpgsqlPoint(x: 0.3054254950953347d, y: 0.8573501706506915d)),
},
            new NpgsqlPathpath0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9856220936318519d, y: 0.9783168734416785d), new NpgsqlTypes.NpgsqlPoint(x: 0.0794009197753508d, y: 0.8427570080526561d), new NpgsqlTypes.NpgsqlPoint(x: 0.30499412220404654d, y: 0.12907571314961874d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05218673862054146d, y: 0.14601156599592324d), new NpgsqlTypes.NpgsqlPoint(x: 0.0780024517553598d, y: 0.20366904614104253d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564701051109257d, y: 0.6160241543600933d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5976668896043359d, y: 0.9763585385831784d), new NpgsqlTypes.NpgsqlPoint(x: 0.10852894518184031d, y: 0.49402734525435943d), new NpgsqlTypes.NpgsqlPoint(x: 0.7372807851584602d, y: 0.13691649047126675d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8011221443978016d, y: 0.34699573333802414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463698377629532d, y: 0.4508119738598263d), new NpgsqlTypes.NpgsqlPoint(x: 0.3314735276590359d, y: 0.7013768889840303d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.970444090918271d, y: 0.014422766442373058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9176258638934733d, y: 0.5145591892995123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8527789509734326d, y: 0.20997630364996656d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27652153488844367d, y: 0.07911842392019253d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558398951049765d, y: 0.8679278343321507d), new NpgsqlTypes.NpgsqlPoint(x: 0.10911516257592879d, y: 0.4841759197553356d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7850731194711944d, y: 0.17806920933414316d), new NpgsqlTypes.NpgsqlPoint(x: 0.46817432812706494d, y: 0.37309376224541757d), new NpgsqlTypes.NpgsqlPoint(x: 0.16694477880899072d, y: 0.7171395593002957d)),
},
            new NpgsqlPathpath0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6673407665042937d, y: 0.3059450588105088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3778716466919615d, y: 0.5068309374743882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6320559137681321d, y: 0.04984807192533791d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4113229201427747d, y: 0.5193181234689336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5151765615642636d, y: 0.10181965507280999d), new NpgsqlTypes.NpgsqlPoint(x: 0.4085530137967982d, y: 0.7334052338326886d)),
},
            new NpgsqlPathpath0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2649369769602504d, y: 0.8695897565239286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6011009044962085d, y: 0.9759653285720163d), new NpgsqlTypes.NpgsqlPoint(x: 0.8164146743912728d, y: 0.4068621662668652d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8114910281010658d, y: 0.39184959662918295d), new NpgsqlTypes.NpgsqlPoint(x: 0.4833687693046974d, y: 0.6849998585514889d), new NpgsqlTypes.NpgsqlPoint(x: 0.3609290987862923d, y: 0.12790984634069757d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6124789832049804d, y: 0.9742769465964086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255168685839937d, y: 0.12926416923332607d), new NpgsqlTypes.NpgsqlPoint(x: 0.3859629232824804d, y: 0.7234217903965351d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6342444715089558d, y: 0.38875018146916795d), new NpgsqlTypes.NpgsqlPoint(x: 0.409177638798933d, y: 0.7806218258617071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9309325661231429d, y: 0.4277059296788456d)),
},
            new NpgsqlPathpath0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9323763746086392d, y: 0.041062957705461534d), new NpgsqlTypes.NpgsqlPoint(x: 0.07828582453386668d, y: 0.7450974356851024d), new NpgsqlTypes.NpgsqlPoint(x: 0.4921440194101959d, y: 0.5321107456467814d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6680081945634583d, y: 0.79040665849804d), new NpgsqlTypes.NpgsqlPoint(x: 0.47880913864678565d, y: 0.5949731644595395d), new NpgsqlTypes.NpgsqlPoint(x: 0.44936821331764465d, y: 0.6455495426582687d)),
},
            new NpgsqlPathpath0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.845766586399397d, y: 0.5911996352360109d), new NpgsqlTypes.NpgsqlPoint(x: 0.3738495460788418d, y: 0.30962218116897333d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317600766352343d, y: 0.5855625175654933d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3970404753928908d, y: 0.570728796321791d), new NpgsqlTypes.NpgsqlPoint(x: 0.003419435025363571d, y: 0.29594961489128924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7178309800704431d, y: 0.18539426832927197d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09449638384287784d, y: 0.312463355729078d), new NpgsqlTypes.NpgsqlPoint(x: 0.011852532196509946d, y: 0.1982738436520035d), new NpgsqlTypes.NpgsqlPoint(x: 0.10480018541562686d, y: 0.32964137316973574d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4081341719642959d, y: 0.5034653723161157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9311499481904311d, y: 0.44184389790717205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6221640609894836d, y: 0.36976977334562855d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3140386392236525d, y: 0.06234281565568922d), new NpgsqlTypes.NpgsqlPoint(x: 0.9576024473045848d, y: 0.12616315514289766d), new NpgsqlTypes.NpgsqlPoint(x: 0.021431955026389837d, y: 0.2383643390052469d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7291473007182534d, y: 0.7491597655115305d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569495828418215d, y: 0.5685849497781326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231094983051664d, y: 0.06531331117102546d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7313981319920629d, y: 0.36128398766045244d), new NpgsqlTypes.NpgsqlPoint(x: 0.13849985282407773d, y: 0.7155954566175304d), new NpgsqlTypes.NpgsqlPoint(x: 0.37453716620636235d, y: 0.7782212247951396d)),
},
            new NpgsqlPathpath0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0810265345591702d, y: 0.18883081856010164d), new NpgsqlTypes.NpgsqlPoint(x: 0.987692333751498d, y: 0.01519780707991547d), new NpgsqlTypes.NpgsqlPoint(x: 0.22157074817697542d, y: 0.32726437606401193d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25550408920868206d, y: 0.33488055601413436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9330125758655741d, y: 0.5197123468528981d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016151687295318d, y: 0.4745142616316099d)),
},
            new NpgsqlPathpath0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28205663594083363d, y: 0.7974515485676891d), new NpgsqlTypes.NpgsqlPoint(x: 0.36375216917644204d, y: 0.0454523247958557d), new NpgsqlTypes.NpgsqlPoint(x: 0.249038306250142d, y: 0.4590862410677421d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6165656747303817d, y: 0.20047635786832552d), new NpgsqlTypes.NpgsqlPoint(x: 0.356867514518752d, y: 0.6003572337392774d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708751688657239d, y: 0.5949736927945695d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.254843108229295d, y: 0.7451569363220352d), new NpgsqlTypes.NpgsqlPoint(x: 0.295060679503269d, y: 0.5551102674776658d), new NpgsqlTypes.NpgsqlPoint(x: 0.8924384322135929d, y: 0.170774751275661d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013122866378641351d, y: 0.16686149285660112d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719537030424132d, y: 0.305038113303691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6475533497706263d, y: 0.6593893002087863d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7888917373504654d, y: 0.24601820311715372d), new NpgsqlTypes.NpgsqlPoint(x: 0.3979991638732663d, y: 0.13319953377042026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904848794305964d, y: 0.09750200412142451d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2002127682726813d, y: 0.6823383670221806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384765097012212d, y: 0.8311696246493435d), new NpgsqlTypes.NpgsqlPoint(x: 0.32546192322287726d, y: 0.3987833327435554d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9617189130547622d, y: 0.5664892394911261d), new NpgsqlTypes.NpgsqlPoint(x: 0.10325823987480798d, y: 0.10640091702572474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682966059573218d, y: 0.29252824906776986d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23845753673281445d, y: 0.7212597603225753d), new NpgsqlTypes.NpgsqlPoint(x: 0.3655099141931448d, y: 0.4829887310452906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7812074342294565d, y: 0.24563533083438038d)),
},
            new NpgsqlPathpath0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46919279937820824d, y: 0.7248747899469596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531893936429926d, y: 0.9694891336017788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9998845289968223d, y: 0.8619512033469859d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045589419852488544d, y: 0.15948063185704553d), new NpgsqlTypes.NpgsqlPoint(x: 0.729123701931216d, y: 0.6515178921089574d), new NpgsqlTypes.NpgsqlPoint(x: 0.44746694644159624d, y: 0.8952996855585237d)),
},
            new NpgsqlPathpath0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07287772708167628d, y: 0.33144383940334377d), new NpgsqlTypes.NpgsqlPoint(x: 0.40105768459102564d, y: 0.8396412470483131d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459238534913979d, y: 0.694773617761436d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3377533914972696d, y: 0.04577790104559598d), new NpgsqlTypes.NpgsqlPoint(x: 0.09992803476589884d, y: 0.3157621744679283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8828485911610581d, y: 0.18344024306992335d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36636922879648925d, y: 0.33975863074291734d), new NpgsqlTypes.NpgsqlPoint(x: 0.986750005824347d, y: 0.18341013064899647d), new NpgsqlTypes.NpgsqlPoint(x: 0.915408153682088d, y: 0.6122237441766614d)),
},
            new NpgsqlPathpath0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8636415033379976d, y: 0.3743262798852197d), new NpgsqlTypes.NpgsqlPoint(x: 0.613212431421638d, y: 0.9403952817936877d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805585564065261d, y: 0.21644454013268766d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3453373534049723d, y: 0.6683698376174788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256944422297205d, y: 0.9304916046963493d), new NpgsqlTypes.NpgsqlPoint(x: 0.1997660641788207d, y: 0.49512906716362415d)),
},
            new NpgsqlPathpath0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7519694323277532d, y: 0.5210039445710786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606275018352977d, y: 0.31021987271553664d), new NpgsqlTypes.NpgsqlPoint(x: 0.440203214528161d, y: 0.090763523668143d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39337036543057935d, y: 0.2317001819265675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702249118331502d, y: 0.08174781184775448d), new NpgsqlTypes.NpgsqlPoint(x: 0.7905246382604104d, y: 0.7337953930878741d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7842349706110364d, y: 0.33299149217488866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9661580113830232d, y: 0.40972642673059934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9335502749814721d, y: 0.5545143564577499d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29837332723368015d, y: 0.3411610987773429d), new NpgsqlTypes.NpgsqlPoint(x: 0.2944211394837203d, y: 0.3655976142148306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859466417713306d, y: 0.9264228748271616d)),
},
            new NpgsqlPathpath0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06326984142715053d, y: 0.21368846152697674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9686445116423702d, y: 0.5484995842025009d), new NpgsqlTypes.NpgsqlPoint(x: 0.7047555834163154d, y: 0.7885669975965932d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942396498244674d, y: 0.8150718423878869d), new NpgsqlTypes.NpgsqlPoint(x: 0.47427503686532935d, y: 0.9149819650713045d), new NpgsqlTypes.NpgsqlPoint(x: 0.3662976784392513d, y: 0.6700910735024449d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3755879801959233d, y: 0.3367548977104202d), new NpgsqlTypes.NpgsqlPoint(x: 0.808097736084648d, y: 0.4050366897897121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859057269919795d, y: 0.9616239065162041d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24931820815983474d, y: 0.9524675766701819d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337040669382557d, y: 0.9428109303508855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217235135298344d, y: 0.7829594122807697d)),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7435974942510737d, y: 0.9597983999668412d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661256568458177d, y: 0.17431542948556855d), new NpgsqlTypes.NpgsqlPoint(x: 0.07302223544126785d, y: 0.7840457274964145d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6629278368030823d, y: 0.4628684428078018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436701099840892d, y: 0.42086046739841343d), new NpgsqlTypes.NpgsqlPoint(x: 0.15061559744075959d, y: 0.3885567128182028d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6570032366326274d, y: 0.9771928785589941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253297363823162d, y: 0.020897612541827648d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632705080695649d, y: 0.22478856096268907d))));
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[34], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 122, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[34], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 22, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 54, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 120, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 5, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[34], false);
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
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 31, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 93, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[34], false);
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
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 64, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 100))
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 122, 40))
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[34], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[29], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[30], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[31], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0536410111250768d, y: 0.33659721306243906d), new NpgsqlTypes.NpgsqlPoint(x: 0.32152677825882225d, y: 0.47414516561581377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4638045413926446d, y: 0.6179586531145372d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7443350405594508d, y: 0.32858686034802187d), new NpgsqlTypes.NpgsqlPoint(x: 0.08217038486357786d, y: 0.27538460314289814d), new NpgsqlTypes.NpgsqlPoint(x: 0.01130789582981695d, y: 0.5219927005846425d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8441703319161898d, y: 0.4685553968037419d), new NpgsqlTypes.NpgsqlPoint(x: 0.05007907756093066d, y: 0.22848130531183752d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077952518563703d, y: 0.6153944177517816d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.717243813964802d, y: 0.06629059534764825d), new NpgsqlTypes.NpgsqlPoint(x: 0.5392518602565026d, y: 0.2922687322819155d), new NpgsqlTypes.NpgsqlPoint(x: 0.715543595640661d, y: 0.3575726846828794d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6900971134692095d, y: 0.7709110518314701d), new NpgsqlTypes.NpgsqlPoint(x: 0.4729200826910127d, y: 0.3849682896730925d), new NpgsqlTypes.NpgsqlPoint(x: 0.6422031218380242d, y: 0.24807247281141653d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3015582372597141d, y: 0.1485400853379102d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735503416511455d, y: 0.3101594446435393d), new NpgsqlTypes.NpgsqlPoint(x: 0.37524136577842326d, y: 0.25386970676325615d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42679746136906593d, y: 0.6531013347938509d), new NpgsqlTypes.NpgsqlPoint(x: 0.48432409410863086d, y: 0.29077416518614707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7329473525084316d, y: 0.474062230701347d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5736805179632568d, y: 0.6718464953833362d), new NpgsqlTypes.NpgsqlPoint(x: 0.45814546508068277d, y: 0.5202911885828373d), new NpgsqlTypes.NpgsqlPoint(x: 0.1500652812180916d, y: 0.04907489120651565d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4790909297973166d, y: 0.7956444534384394d), new NpgsqlTypes.NpgsqlPoint(x: 0.36914181196109697d, y: 0.6084010075368012d), new NpgsqlTypes.NpgsqlPoint(x: 0.027890042958798933d, y: 0.06647535478181121d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10057475712570385d, y: 0.6249350254115459d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908376523591869d, y: 0.6282717934219862d), new NpgsqlTypes.NpgsqlPoint(x: 0.735986590208515d, y: 0.8599849602953809d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512936371121094d, y: 0.14423034903816967d), new NpgsqlTypes.NpgsqlPoint(x: 0.11225657837563474d, y: 0.5099471035063402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9811755969821204d, y: 0.9391955749658212d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9534828655548118d, y: 0.9050466408640995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9212569308521883d, y: 0.08535217779769788d), new NpgsqlTypes.NpgsqlPoint(x: 0.57420186350226d, y: 0.08329777324527843d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6402747562799025d, y: 0.21060036440977248d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003530683605579d, y: 0.7082175879016686d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175050186287245d, y: 0.6241840577409891d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6330368071687338d, y: 0.024269160093082554d), new NpgsqlTypes.NpgsqlPoint(x: 0.14061204302880392d, y: 0.022807765742632213d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867144705694763d, y: 0.7789457205465579d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7435974942510737d, y: 0.9597983999668412d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661256568458177d, y: 0.17431542948556855d), new NpgsqlTypes.NpgsqlPoint(x: 0.07302223544126785d, y: 0.7840457274964145d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9622516982564201d, y: 0.04305683153972162d), new NpgsqlTypes.NpgsqlPoint(x: 0.10334917680552858d, y: 0.9915709532227435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023023625898537d, y: 0.5274842283865923d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1737008214929744d, y: 0.63673608681085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331054936237582d, y: 0.7006862059290754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412611055809646d, y: 0.6591791478833547d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6629278368030823d, y: 0.4628684428078018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436701099840892d, y: 0.42086046739841343d), new NpgsqlTypes.NpgsqlPoint(x: 0.15061559744075959d, y: 0.3885567128182028d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8534417199444202d, y: 0.26084002011322627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141783536723483d, y: 0.8234301840504252d), new NpgsqlTypes.NpgsqlPoint(x: 0.36803304348712507d, y: 0.26446156408205956d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27841114389437904d, y: 0.5815423278141978d), new NpgsqlTypes.NpgsqlPoint(x: 0.97333351790376d, y: 0.7854824762940916d), new NpgsqlTypes.NpgsqlPoint(x: 0.48328336399103067d, y: 0.11397155312683915d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4778553482912794d, y: 0.1125192830843984d), new NpgsqlTypes.NpgsqlPoint(x: 0.323305377681511d, y: 0.05670475011226872d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299455612376591d, y: 0.9258271459051252d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6004532217364614d, y: 0.5334348386287041d), new NpgsqlTypes.NpgsqlPoint(x: 0.14278349036625482d, y: 0.151231746060698d), new NpgsqlTypes.NpgsqlPoint(x: 0.13930918115900337d, y: 0.03215101901502393d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6570032366326274d, y: 0.9771928785589941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253297363823162d, y: 0.020897612541827648d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632705080695649d, y: 0.22478856096268907d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4438556928180809d, y: 0.0832502260350646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8529219107709491d, y: 0.7444084069655857d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649526326120329d, y: 0.08303736105089832d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18197966671246835d, y: 0.479043682182695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7899886759242409d, y: 0.3720668483387788d), new NpgsqlTypes.NpgsqlPoint(x: 0.2912812223452368d, y: 0.03497308904357277d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4861234080544269d, y: 0.46289359795521756d), new NpgsqlTypes.NpgsqlPoint(x: 0.832592577297058d, y: 0.0648023869681491d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825221995138901d, y: 0.976993102114295d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6049934452905482d, y: 0.5601856769662622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6877749139675509d, y: 0.17539056057746638d), new NpgsqlTypes.NpgsqlPoint(x: 0.38893535012450475d, y: 0.08769115862424848d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1631786292877755d, y: 0.6875056395317607d), new NpgsqlTypes.NpgsqlPoint(x: 0.46175242961173646d, y: 0.9319945287512756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5607763033406549d, y: 0.9534350001406103d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8653826962281793d, y: 0.5648820621355007d), new NpgsqlTypes.NpgsqlPoint(x: 0.64657001779597d, y: 0.3601335967454984d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406944592011163d, y: 0.23586133787201402d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6829426739129077d, y: 0.1509856203299219d), new NpgsqlTypes.NpgsqlPoint(x: 0.9490911021460292d, y: 0.6962146151196394d), new NpgsqlTypes.NpgsqlPoint(x: 0.14020755946333074d, y: 0.16758087702643243d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1375320801262856d, y: 0.0175674629306789d), new NpgsqlTypes.NpgsqlPoint(x: 0.6575275231296668d, y: 0.9401211497315769d), new NpgsqlTypes.NpgsqlPoint(x: 0.19818623511852007d, y: 0.40387042754507796d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30925291966459434d, y: 0.8993794526756954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823052496986004d, y: 0.7794468093406605d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964536884969744d, y: 0.6410208702437855d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3247558341143444d, y: 0.9783405353130606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5650778617109878d, y: 0.7611356632433691d), new NpgsqlTypes.NpgsqlPoint(x: 0.5435553043018588d, y: 0.9495354552451507d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5665918403180079d, y: 0.6184363765318199d), new NpgsqlTypes.NpgsqlPoint(x: 0.835694657402456d, y: 0.32747151151936693d), new NpgsqlTypes.NpgsqlPoint(x: 0.550035624064553d, y: 0.9119027910524964d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016291964252645008d, y: 0.8998487330256921d), new NpgsqlTypes.NpgsqlPoint(x: 0.059392322992037117d, y: 0.2910723876873148d), new NpgsqlTypes.NpgsqlPoint(x: 0.3054254950953347d, y: 0.8573501706506915d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9856220936318519d, y: 0.9783168734416785d), new NpgsqlTypes.NpgsqlPoint(x: 0.0794009197753508d, y: 0.8427570080526561d), new NpgsqlTypes.NpgsqlPoint(x: 0.30499412220404654d, y: 0.12907571314961874d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05218673862054146d, y: 0.14601156599592324d), new NpgsqlTypes.NpgsqlPoint(x: 0.0780024517553598d, y: 0.20366904614104253d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564701051109257d, y: 0.6160241543600933d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5976668896043359d, y: 0.9763585385831784d), new NpgsqlTypes.NpgsqlPoint(x: 0.10852894518184031d, y: 0.49402734525435943d), new NpgsqlTypes.NpgsqlPoint(x: 0.7372807851584602d, y: 0.13691649047126675d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8011221443978016d, y: 0.34699573333802414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463698377629532d, y: 0.4508119738598263d), new NpgsqlTypes.NpgsqlPoint(x: 0.3314735276590359d, y: 0.7013768889840303d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.970444090918271d, y: 0.014422766442373058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9176258638934733d, y: 0.5145591892995123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8527789509734326d, y: 0.20997630364996656d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27652153488844367d, y: 0.07911842392019253d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558398951049765d, y: 0.8679278343321507d), new NpgsqlTypes.NpgsqlPoint(x: 0.10911516257592879d, y: 0.4841759197553356d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7850731194711944d, y: 0.17806920933414316d), new NpgsqlTypes.NpgsqlPoint(x: 0.46817432812706494d, y: 0.37309376224541757d), new NpgsqlTypes.NpgsqlPoint(x: 0.16694477880899072d, y: 0.7171395593002957d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6673407665042937d, y: 0.3059450588105088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3778716466919615d, y: 0.5068309374743882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6320559137681321d, y: 0.04984807192533791d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4113229201427747d, y: 0.5193181234689336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5151765615642636d, y: 0.10181965507280999d), new NpgsqlTypes.NpgsqlPoint(x: 0.4085530137967982d, y: 0.7334052338326886d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2649369769602504d, y: 0.8695897565239286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6011009044962085d, y: 0.9759653285720163d), new NpgsqlTypes.NpgsqlPoint(x: 0.8164146743912728d, y: 0.4068621662668652d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8114910281010658d, y: 0.39184959662918295d), new NpgsqlTypes.NpgsqlPoint(x: 0.4833687693046974d, y: 0.6849998585514889d), new NpgsqlTypes.NpgsqlPoint(x: 0.3609290987862923d, y: 0.12790984634069757d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6124789832049804d, y: 0.9742769465964086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255168685839937d, y: 0.12926416923332607d), new NpgsqlTypes.NpgsqlPoint(x: 0.3859629232824804d, y: 0.7234217903965351d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6342444715089558d, y: 0.38875018146916795d), new NpgsqlTypes.NpgsqlPoint(x: 0.409177638798933d, y: 0.7806218258617071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9309325661231429d, y: 0.4277059296788456d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9323763746086392d, y: 0.041062957705461534d), new NpgsqlTypes.NpgsqlPoint(x: 0.07828582453386668d, y: 0.7450974356851024d), new NpgsqlTypes.NpgsqlPoint(x: 0.4921440194101959d, y: 0.5321107456467814d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6680081945634583d, y: 0.79040665849804d), new NpgsqlTypes.NpgsqlPoint(x: 0.47880913864678565d, y: 0.5949731644595395d), new NpgsqlTypes.NpgsqlPoint(x: 0.44936821331764465d, y: 0.6455495426582687d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.845766586399397d, y: 0.5911996352360109d), new NpgsqlTypes.NpgsqlPoint(x: 0.3738495460788418d, y: 0.30962218116897333d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317600766352343d, y: 0.5855625175654933d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3970404753928908d, y: 0.570728796321791d), new NpgsqlTypes.NpgsqlPoint(x: 0.003419435025363571d, y: 0.29594961489128924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7178309800704431d, y: 0.18539426832927197d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09449638384287784d, y: 0.312463355729078d), new NpgsqlTypes.NpgsqlPoint(x: 0.011852532196509946d, y: 0.1982738436520035d), new NpgsqlTypes.NpgsqlPoint(x: 0.10480018541562686d, y: 0.32964137316973574d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4081341719642959d, y: 0.5034653723161157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9311499481904311d, y: 0.44184389790717205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6221640609894836d, y: 0.36976977334562855d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3140386392236525d, y: 0.06234281565568922d), new NpgsqlTypes.NpgsqlPoint(x: 0.9576024473045848d, y: 0.12616315514289766d), new NpgsqlTypes.NpgsqlPoint(x: 0.021431955026389837d, y: 0.2383643390052469d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7291473007182534d, y: 0.7491597655115305d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569495828418215d, y: 0.5685849497781326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231094983051664d, y: 0.06531331117102546d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7313981319920629d, y: 0.36128398766045244d), new NpgsqlTypes.NpgsqlPoint(x: 0.13849985282407773d, y: 0.7155954566175304d), new NpgsqlTypes.NpgsqlPoint(x: 0.37453716620636235d, y: 0.7782212247951396d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0810265345591702d, y: 0.18883081856010164d), new NpgsqlTypes.NpgsqlPoint(x: 0.987692333751498d, y: 0.01519780707991547d), new NpgsqlTypes.NpgsqlPoint(x: 0.22157074817697542d, y: 0.32726437606401193d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25550408920868206d, y: 0.33488055601413436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9330125758655741d, y: 0.5197123468528981d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016151687295318d, y: 0.4745142616316099d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28205663594083363d, y: 0.7974515485676891d), new NpgsqlTypes.NpgsqlPoint(x: 0.36375216917644204d, y: 0.0454523247958557d), new NpgsqlTypes.NpgsqlPoint(x: 0.249038306250142d, y: 0.4590862410677421d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6165656747303817d, y: 0.20047635786832552d), new NpgsqlTypes.NpgsqlPoint(x: 0.356867514518752d, y: 0.6003572337392774d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708751688657239d, y: 0.5949736927945695d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.254843108229295d, y: 0.7451569363220352d), new NpgsqlTypes.NpgsqlPoint(x: 0.295060679503269d, y: 0.5551102674776658d), new NpgsqlTypes.NpgsqlPoint(x: 0.8924384322135929d, y: 0.170774751275661d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013122866378641351d, y: 0.16686149285660112d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719537030424132d, y: 0.305038113303691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6475533497706263d, y: 0.6593893002087863d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7888917373504654d, y: 0.24601820311715372d), new NpgsqlTypes.NpgsqlPoint(x: 0.3979991638732663d, y: 0.13319953377042026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904848794305964d, y: 0.09750200412142451d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2002127682726813d, y: 0.6823383670221806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384765097012212d, y: 0.8311696246493435d), new NpgsqlTypes.NpgsqlPoint(x: 0.32546192322287726d, y: 0.3987833327435554d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9617189130547622d, y: 0.5664892394911261d), new NpgsqlTypes.NpgsqlPoint(x: 0.10325823987480798d, y: 0.10640091702572474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682966059573218d, y: 0.29252824906776986d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23845753673281445d, y: 0.7212597603225753d), new NpgsqlTypes.NpgsqlPoint(x: 0.3655099141931448d, y: 0.4829887310452906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7812074342294565d, y: 0.24563533083438038d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46919279937820824d, y: 0.7248747899469596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531893936429926d, y: 0.9694891336017788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9998845289968223d, y: 0.8619512033469859d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045589419852488544d, y: 0.15948063185704553d), new NpgsqlTypes.NpgsqlPoint(x: 0.729123701931216d, y: 0.6515178921089574d), new NpgsqlTypes.NpgsqlPoint(x: 0.44746694644159624d, y: 0.8952996855585237d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07287772708167628d, y: 0.33144383940334377d), new NpgsqlTypes.NpgsqlPoint(x: 0.40105768459102564d, y: 0.8396412470483131d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459238534913979d, y: 0.694773617761436d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3377533914972696d, y: 0.04577790104559598d), new NpgsqlTypes.NpgsqlPoint(x: 0.09992803476589884d, y: 0.3157621744679283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8828485911610581d, y: 0.18344024306992335d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36636922879648925d, y: 0.33975863074291734d), new NpgsqlTypes.NpgsqlPoint(x: 0.986750005824347d, y: 0.18341013064899647d), new NpgsqlTypes.NpgsqlPoint(x: 0.915408153682088d, y: 0.6122237441766614d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8636415033379976d, y: 0.3743262798852197d), new NpgsqlTypes.NpgsqlPoint(x: 0.613212431421638d, y: 0.9403952817936877d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805585564065261d, y: 0.21644454013268766d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3453373534049723d, y: 0.6683698376174788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256944422297205d, y: 0.9304916046963493d), new NpgsqlTypes.NpgsqlPoint(x: 0.1997660641788207d, y: 0.49512906716362415d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7519694323277532d, y: 0.5210039445710786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606275018352977d, y: 0.31021987271553664d), new NpgsqlTypes.NpgsqlPoint(x: 0.440203214528161d, y: 0.090763523668143d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39337036543057935d, y: 0.2317001819265675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702249118331502d, y: 0.08174781184775448d), new NpgsqlTypes.NpgsqlPoint(x: 0.7905246382604104d, y: 0.7337953930878741d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7842349706110364d, y: 0.33299149217488866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9661580113830232d, y: 0.40972642673059934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9335502749814721d, y: 0.5545143564577499d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29837332723368015d, y: 0.3411610987773429d), new NpgsqlTypes.NpgsqlPoint(x: 0.2944211394837203d, y: 0.3655976142148306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859466417713306d, y: 0.9264228748271616d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06326984142715053d, y: 0.21368846152697674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9686445116423702d, y: 0.5484995842025009d), new NpgsqlTypes.NpgsqlPoint(x: 0.7047555834163154d, y: 0.7885669975965932d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942396498244674d, y: 0.8150718423878869d), new NpgsqlTypes.NpgsqlPoint(x: 0.47427503686532935d, y: 0.9149819650713045d), new NpgsqlTypes.NpgsqlPoint(x: 0.3662976784392513d, y: 0.6700910735024449d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3755879801959233d, y: 0.3367548977104202d), new NpgsqlTypes.NpgsqlPoint(x: 0.808097736084648d, y: 0.4050366897897121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859057269919795d, y: 0.9616239065162041d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24931820815983474d, y: 0.9524675766701819d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337040669382557d, y: 0.9428109303508855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217235135298344d, y: 0.7829594122807697d)))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0536410111250768d, y: 0.33659721306243906d), new NpgsqlTypes.NpgsqlPoint(x: 0.32152677825882225d, y: 0.47414516561581377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4638045413926446d, y: 0.6179586531145372d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7443350405594508d, y: 0.32858686034802187d), new NpgsqlTypes.NpgsqlPoint(x: 0.08217038486357786d, y: 0.27538460314289814d), new NpgsqlTypes.NpgsqlPoint(x: 0.01130789582981695d, y: 0.5219927005846425d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8441703319161898d, y: 0.4685553968037419d), new NpgsqlTypes.NpgsqlPoint(x: 0.05007907756093066d, y: 0.22848130531183752d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077952518563703d, y: 0.6153944177517816d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.717243813964802d, y: 0.06629059534764825d), new NpgsqlTypes.NpgsqlPoint(x: 0.5392518602565026d, y: 0.2922687322819155d), new NpgsqlTypes.NpgsqlPoint(x: 0.715543595640661d, y: 0.3575726846828794d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6900971134692095d, y: 0.7709110518314701d), new NpgsqlTypes.NpgsqlPoint(x: 0.4729200826910127d, y: 0.3849682896730925d), new NpgsqlTypes.NpgsqlPoint(x: 0.6422031218380242d, y: 0.24807247281141653d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3015582372597141d, y: 0.1485400853379102d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735503416511455d, y: 0.3101594446435393d), new NpgsqlTypes.NpgsqlPoint(x: 0.37524136577842326d, y: 0.25386970676325615d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42679746136906593d, y: 0.6531013347938509d), new NpgsqlTypes.NpgsqlPoint(x: 0.48432409410863086d, y: 0.29077416518614707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7329473525084316d, y: 0.474062230701347d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5736805179632568d, y: 0.6718464953833362d), new NpgsqlTypes.NpgsqlPoint(x: 0.45814546508068277d, y: 0.5202911885828373d), new NpgsqlTypes.NpgsqlPoint(x: 0.1500652812180916d, y: 0.04907489120651565d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4790909297973166d, y: 0.7956444534384394d), new NpgsqlTypes.NpgsqlPoint(x: 0.36914181196109697d, y: 0.6084010075368012d), new NpgsqlTypes.NpgsqlPoint(x: 0.027890042958798933d, y: 0.06647535478181121d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10057475712570385d, y: 0.6249350254115459d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908376523591869d, y: 0.6282717934219862d), new NpgsqlTypes.NpgsqlPoint(x: 0.735986590208515d, y: 0.8599849602953809d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512936371121094d, y: 0.14423034903816967d), new NpgsqlTypes.NpgsqlPoint(x: 0.11225657837563474d, y: 0.5099471035063402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9811755969821204d, y: 0.9391955749658212d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9534828655548118d, y: 0.9050466408640995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9212569308521883d, y: 0.08535217779769788d), new NpgsqlTypes.NpgsqlPoint(x: 0.57420186350226d, y: 0.08329777324527843d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6402747562799025d, y: 0.21060036440977248d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003530683605579d, y: 0.7082175879016686d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175050186287245d, y: 0.6241840577409891d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6330368071687338d, y: 0.024269160093082554d), new NpgsqlTypes.NpgsqlPoint(x: 0.14061204302880392d, y: 0.022807765742632213d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867144705694763d, y: 0.7789457205465579d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7435974942510737d, y: 0.9597983999668412d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661256568458177d, y: 0.17431542948556855d), new NpgsqlTypes.NpgsqlPoint(x: 0.07302223544126785d, y: 0.7840457274964145d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9622516982564201d, y: 0.04305683153972162d), new NpgsqlTypes.NpgsqlPoint(x: 0.10334917680552858d, y: 0.9915709532227435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023023625898537d, y: 0.5274842283865923d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1737008214929744d, y: 0.63673608681085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331054936237582d, y: 0.7006862059290754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412611055809646d, y: 0.6591791478833547d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6629278368030823d, y: 0.4628684428078018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436701099840892d, y: 0.42086046739841343d), new NpgsqlTypes.NpgsqlPoint(x: 0.15061559744075959d, y: 0.3885567128182028d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8534417199444202d, y: 0.26084002011322627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141783536723483d, y: 0.8234301840504252d), new NpgsqlTypes.NpgsqlPoint(x: 0.36803304348712507d, y: 0.26446156408205956d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27841114389437904d, y: 0.5815423278141978d), new NpgsqlTypes.NpgsqlPoint(x: 0.97333351790376d, y: 0.7854824762940916d), new NpgsqlTypes.NpgsqlPoint(x: 0.48328336399103067d, y: 0.11397155312683915d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4778553482912794d, y: 0.1125192830843984d), new NpgsqlTypes.NpgsqlPoint(x: 0.323305377681511d, y: 0.05670475011226872d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299455612376591d, y: 0.9258271459051252d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6004532217364614d, y: 0.5334348386287041d), new NpgsqlTypes.NpgsqlPoint(x: 0.14278349036625482d, y: 0.151231746060698d), new NpgsqlTypes.NpgsqlPoint(x: 0.13930918115900337d, y: 0.03215101901502393d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6570032366326274d, y: 0.9771928785589941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253297363823162d, y: 0.020897612541827648d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632705080695649d, y: 0.22478856096268907d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4438556928180809d, y: 0.0832502260350646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8529219107709491d, y: 0.7444084069655857d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649526326120329d, y: 0.08303736105089832d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18197966671246835d, y: 0.479043682182695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7899886759242409d, y: 0.3720668483387788d), new NpgsqlTypes.NpgsqlPoint(x: 0.2912812223452368d, y: 0.03497308904357277d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4861234080544269d, y: 0.46289359795521756d), new NpgsqlTypes.NpgsqlPoint(x: 0.832592577297058d, y: 0.0648023869681491d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825221995138901d, y: 0.976993102114295d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6049934452905482d, y: 0.5601856769662622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6877749139675509d, y: 0.17539056057746638d), new NpgsqlTypes.NpgsqlPoint(x: 0.38893535012450475d, y: 0.08769115862424848d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1631786292877755d, y: 0.6875056395317607d), new NpgsqlTypes.NpgsqlPoint(x: 0.46175242961173646d, y: 0.9319945287512756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5607763033406549d, y: 0.9534350001406103d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8653826962281793d, y: 0.5648820621355007d), new NpgsqlTypes.NpgsqlPoint(x: 0.64657001779597d, y: 0.3601335967454984d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406944592011163d, y: 0.23586133787201402d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6829426739129077d, y: 0.1509856203299219d), new NpgsqlTypes.NpgsqlPoint(x: 0.9490911021460292d, y: 0.6962146151196394d), new NpgsqlTypes.NpgsqlPoint(x: 0.14020755946333074d, y: 0.16758087702643243d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1375320801262856d, y: 0.0175674629306789d), new NpgsqlTypes.NpgsqlPoint(x: 0.6575275231296668d, y: 0.9401211497315769d), new NpgsqlTypes.NpgsqlPoint(x: 0.19818623511852007d, y: 0.40387042754507796d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30925291966459434d, y: 0.8993794526756954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823052496986004d, y: 0.7794468093406605d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964536884969744d, y: 0.6410208702437855d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3247558341143444d, y: 0.9783405353130606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5650778617109878d, y: 0.7611356632433691d), new NpgsqlTypes.NpgsqlPoint(x: 0.5435553043018588d, y: 0.9495354552451507d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5665918403180079d, y: 0.6184363765318199d), new NpgsqlTypes.NpgsqlPoint(x: 0.835694657402456d, y: 0.32747151151936693d), new NpgsqlTypes.NpgsqlPoint(x: 0.550035624064553d, y: 0.9119027910524964d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016291964252645008d, y: 0.8998487330256921d), new NpgsqlTypes.NpgsqlPoint(x: 0.059392322992037117d, y: 0.2910723876873148d), new NpgsqlTypes.NpgsqlPoint(x: 0.3054254950953347d, y: 0.8573501706506915d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9856220936318519d, y: 0.9783168734416785d), new NpgsqlTypes.NpgsqlPoint(x: 0.0794009197753508d, y: 0.8427570080526561d), new NpgsqlTypes.NpgsqlPoint(x: 0.30499412220404654d, y: 0.12907571314961874d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05218673862054146d, y: 0.14601156599592324d), new NpgsqlTypes.NpgsqlPoint(x: 0.0780024517553598d, y: 0.20366904614104253d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564701051109257d, y: 0.6160241543600933d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5976668896043359d, y: 0.9763585385831784d), new NpgsqlTypes.NpgsqlPoint(x: 0.10852894518184031d, y: 0.49402734525435943d), new NpgsqlTypes.NpgsqlPoint(x: 0.7372807851584602d, y: 0.13691649047126675d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8011221443978016d, y: 0.34699573333802414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463698377629532d, y: 0.4508119738598263d), new NpgsqlTypes.NpgsqlPoint(x: 0.3314735276590359d, y: 0.7013768889840303d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.970444090918271d, y: 0.014422766442373058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9176258638934733d, y: 0.5145591892995123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8527789509734326d, y: 0.20997630364996656d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27652153488844367d, y: 0.07911842392019253d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558398951049765d, y: 0.8679278343321507d), new NpgsqlTypes.NpgsqlPoint(x: 0.10911516257592879d, y: 0.4841759197553356d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7850731194711944d, y: 0.17806920933414316d), new NpgsqlTypes.NpgsqlPoint(x: 0.46817432812706494d, y: 0.37309376224541757d), new NpgsqlTypes.NpgsqlPoint(x: 0.16694477880899072d, y: 0.7171395593002957d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6673407665042937d, y: 0.3059450588105088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3778716466919615d, y: 0.5068309374743882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6320559137681321d, y: 0.04984807192533791d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4113229201427747d, y: 0.5193181234689336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5151765615642636d, y: 0.10181965507280999d), new NpgsqlTypes.NpgsqlPoint(x: 0.4085530137967982d, y: 0.7334052338326886d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2649369769602504d, y: 0.8695897565239286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6011009044962085d, y: 0.9759653285720163d), new NpgsqlTypes.NpgsqlPoint(x: 0.8164146743912728d, y: 0.4068621662668652d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8114910281010658d, y: 0.39184959662918295d), new NpgsqlTypes.NpgsqlPoint(x: 0.4833687693046974d, y: 0.6849998585514889d), new NpgsqlTypes.NpgsqlPoint(x: 0.3609290987862923d, y: 0.12790984634069757d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6124789832049804d, y: 0.9742769465964086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255168685839937d, y: 0.12926416923332607d), new NpgsqlTypes.NpgsqlPoint(x: 0.3859629232824804d, y: 0.7234217903965351d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6342444715089558d, y: 0.38875018146916795d), new NpgsqlTypes.NpgsqlPoint(x: 0.409177638798933d, y: 0.7806218258617071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9309325661231429d, y: 0.4277059296788456d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9323763746086392d, y: 0.041062957705461534d), new NpgsqlTypes.NpgsqlPoint(x: 0.07828582453386668d, y: 0.7450974356851024d), new NpgsqlTypes.NpgsqlPoint(x: 0.4921440194101959d, y: 0.5321107456467814d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6680081945634583d, y: 0.79040665849804d), new NpgsqlTypes.NpgsqlPoint(x: 0.47880913864678565d, y: 0.5949731644595395d), new NpgsqlTypes.NpgsqlPoint(x: 0.44936821331764465d, y: 0.6455495426582687d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.845766586399397d, y: 0.5911996352360109d), new NpgsqlTypes.NpgsqlPoint(x: 0.3738495460788418d, y: 0.30962218116897333d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317600766352343d, y: 0.5855625175654933d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3970404753928908d, y: 0.570728796321791d), new NpgsqlTypes.NpgsqlPoint(x: 0.003419435025363571d, y: 0.29594961489128924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7178309800704431d, y: 0.18539426832927197d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09449638384287784d, y: 0.312463355729078d), new NpgsqlTypes.NpgsqlPoint(x: 0.011852532196509946d, y: 0.1982738436520035d), new NpgsqlTypes.NpgsqlPoint(x: 0.10480018541562686d, y: 0.32964137316973574d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4081341719642959d, y: 0.5034653723161157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9311499481904311d, y: 0.44184389790717205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6221640609894836d, y: 0.36976977334562855d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3140386392236525d, y: 0.06234281565568922d), new NpgsqlTypes.NpgsqlPoint(x: 0.9576024473045848d, y: 0.12616315514289766d), new NpgsqlTypes.NpgsqlPoint(x: 0.021431955026389837d, y: 0.2383643390052469d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7291473007182534d, y: 0.7491597655115305d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569495828418215d, y: 0.5685849497781326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231094983051664d, y: 0.06531331117102546d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7313981319920629d, y: 0.36128398766045244d), new NpgsqlTypes.NpgsqlPoint(x: 0.13849985282407773d, y: 0.7155954566175304d), new NpgsqlTypes.NpgsqlPoint(x: 0.37453716620636235d, y: 0.7782212247951396d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0810265345591702d, y: 0.18883081856010164d), new NpgsqlTypes.NpgsqlPoint(x: 0.987692333751498d, y: 0.01519780707991547d), new NpgsqlTypes.NpgsqlPoint(x: 0.22157074817697542d, y: 0.32726437606401193d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25550408920868206d, y: 0.33488055601413436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9330125758655741d, y: 0.5197123468528981d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016151687295318d, y: 0.4745142616316099d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28205663594083363d, y: 0.7974515485676891d), new NpgsqlTypes.NpgsqlPoint(x: 0.36375216917644204d, y: 0.0454523247958557d), new NpgsqlTypes.NpgsqlPoint(x: 0.249038306250142d, y: 0.4590862410677421d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6165656747303817d, y: 0.20047635786832552d), new NpgsqlTypes.NpgsqlPoint(x: 0.356867514518752d, y: 0.6003572337392774d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708751688657239d, y: 0.5949736927945695d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.254843108229295d, y: 0.7451569363220352d), new NpgsqlTypes.NpgsqlPoint(x: 0.295060679503269d, y: 0.5551102674776658d), new NpgsqlTypes.NpgsqlPoint(x: 0.8924384322135929d, y: 0.170774751275661d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013122866378641351d, y: 0.16686149285660112d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719537030424132d, y: 0.305038113303691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6475533497706263d, y: 0.6593893002087863d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7888917373504654d, y: 0.24601820311715372d), new NpgsqlTypes.NpgsqlPoint(x: 0.3979991638732663d, y: 0.13319953377042026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904848794305964d, y: 0.09750200412142451d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2002127682726813d, y: 0.6823383670221806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384765097012212d, y: 0.8311696246493435d), new NpgsqlTypes.NpgsqlPoint(x: 0.32546192322287726d, y: 0.3987833327435554d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9617189130547622d, y: 0.5664892394911261d), new NpgsqlTypes.NpgsqlPoint(x: 0.10325823987480798d, y: 0.10640091702572474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682966059573218d, y: 0.29252824906776986d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23845753673281445d, y: 0.7212597603225753d), new NpgsqlTypes.NpgsqlPoint(x: 0.3655099141931448d, y: 0.4829887310452906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7812074342294565d, y: 0.24563533083438038d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46919279937820824d, y: 0.7248747899469596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531893936429926d, y: 0.9694891336017788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9998845289968223d, y: 0.8619512033469859d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045589419852488544d, y: 0.15948063185704553d), new NpgsqlTypes.NpgsqlPoint(x: 0.729123701931216d, y: 0.6515178921089574d), new NpgsqlTypes.NpgsqlPoint(x: 0.44746694644159624d, y: 0.8952996855585237d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07287772708167628d, y: 0.33144383940334377d), new NpgsqlTypes.NpgsqlPoint(x: 0.40105768459102564d, y: 0.8396412470483131d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459238534913979d, y: 0.694773617761436d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3377533914972696d, y: 0.04577790104559598d), new NpgsqlTypes.NpgsqlPoint(x: 0.09992803476589884d, y: 0.3157621744679283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8828485911610581d, y: 0.18344024306992335d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36636922879648925d, y: 0.33975863074291734d), new NpgsqlTypes.NpgsqlPoint(x: 0.986750005824347d, y: 0.18341013064899647d), new NpgsqlTypes.NpgsqlPoint(x: 0.915408153682088d, y: 0.6122237441766614d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8636415033379976d, y: 0.3743262798852197d), new NpgsqlTypes.NpgsqlPoint(x: 0.613212431421638d, y: 0.9403952817936877d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805585564065261d, y: 0.21644454013268766d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3453373534049723d, y: 0.6683698376174788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256944422297205d, y: 0.9304916046963493d), new NpgsqlTypes.NpgsqlPoint(x: 0.1997660641788207d, y: 0.49512906716362415d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7519694323277532d, y: 0.5210039445710786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606275018352977d, y: 0.31021987271553664d), new NpgsqlTypes.NpgsqlPoint(x: 0.440203214528161d, y: 0.090763523668143d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39337036543057935d, y: 0.2317001819265675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702249118331502d, y: 0.08174781184775448d), new NpgsqlTypes.NpgsqlPoint(x: 0.7905246382604104d, y: 0.7337953930878741d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7842349706110364d, y: 0.33299149217488866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9661580113830232d, y: 0.40972642673059934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9335502749814721d, y: 0.5545143564577499d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29837332723368015d, y: 0.3411610987773429d), new NpgsqlTypes.NpgsqlPoint(x: 0.2944211394837203d, y: 0.3655976142148306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859466417713306d, y: 0.9264228748271616d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06326984142715053d, y: 0.21368846152697674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9686445116423702d, y: 0.5484995842025009d), new NpgsqlTypes.NpgsqlPoint(x: 0.7047555834163154d, y: 0.7885669975965932d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942396498244674d, y: 0.8150718423878869d), new NpgsqlTypes.NpgsqlPoint(x: 0.47427503686532935d, y: 0.9149819650713045d), new NpgsqlTypes.NpgsqlPoint(x: 0.3662976784392513d, y: 0.6700910735024449d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3755879801959233d, y: 0.3367548977104202d), new NpgsqlTypes.NpgsqlPoint(x: 0.808097736084648d, y: 0.4050366897897121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859057269919795d, y: 0.9616239065162041d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24931820815983474d, y: 0.9524675766701819d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337040669382557d, y: 0.9428109303508855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217235135298344d, y: 0.7829594122807697d)))));

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

