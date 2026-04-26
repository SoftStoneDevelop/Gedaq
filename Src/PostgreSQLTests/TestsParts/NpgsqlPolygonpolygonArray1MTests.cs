

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
    internal partial interface INpgsqlPolygonArraypolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonArraypolygonArray : INpgsqlPolygonArraypolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray1M[] _testData = new NpgsqlPolygonpolygonArray1M[]
        {
            new NpgsqlPolygonpolygonArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9547943085481895d, y: 0.018975224173584215d), new NpgsqlTypes.NpgsqlPoint(x: 0.19758419913981595d, y: 0.8043104754141898d), new NpgsqlTypes.NpgsqlPoint(x: 0.8709599083272984d, y: 0.6213256728566989d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9604980439500413d, y: 0.4564423112866801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9756024404644165d, y: 0.18082923982975463d), new NpgsqlTypes.NpgsqlPoint(x: 0.5452347251939306d, y: 0.40976785751868317d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7582476196713115d, y: 0.5695978891872774d), new NpgsqlTypes.NpgsqlPoint(x: 0.780956776384521d, y: 0.3769763946502802d), new NpgsqlTypes.NpgsqlPoint(x: 0.742416055979037d, y: 0.06733781838894681d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6630448854613062d, y: 0.9929074233402732d), new NpgsqlTypes.NpgsqlPoint(x: 0.23639920818457838d, y: 0.7500285801987413d), new NpgsqlTypes.NpgsqlPoint(x: 0.2036398463247484d, y: 0.9173525281397487d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48751079705774425d, y: 0.6043633058403677d), new NpgsqlTypes.NpgsqlPoint(x: 0.5710309072457603d, y: 0.8200216666172767d), new NpgsqlTypes.NpgsqlPoint(x: 0.863220341084584d, y: 0.4275842187574007d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.603699237238491d, y: 0.49047118229167164d), new NpgsqlTypes.NpgsqlPoint(x: 0.7068598300803093d, y: 0.9940087704432509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7636644092680908d, y: 0.578192117828511d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06666514910494614d, y: 0.44904774066308883d), new NpgsqlTypes.NpgsqlPoint(x: 0.1134044259397301d, y: 0.05196700738339266d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383506382014131d, y: 0.27821362586958953d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7963648406706959d, y: 0.8031500889078336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6540254520623578d, y: 0.5482066249678372d), new NpgsqlTypes.NpgsqlPoint(x: 0.42008894589654244d, y: 0.8810428505353264d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3871933012832448d, y: 0.9709034315692716d), new NpgsqlTypes.NpgsqlPoint(x: 0.44469393067857843d, y: 0.5478196811786702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061287969824793d, y: 0.09024807167289883d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6164663593225771d, y: 0.3549219000853022d), new NpgsqlTypes.NpgsqlPoint(x: 0.6450045298404514d, y: 0.25004564748806746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7118847333121147d, y: 0.2745783649344756d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7912460417288318d, y: 0.5082864085020165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9809391376017076d, y: 0.7551279515934377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4599438771104759d, y: 0.9021525454677758d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07025379649350749d, y: 0.23058869416267957d), new NpgsqlTypes.NpgsqlPoint(x: 0.34402534100942705d, y: 0.8092692509239774d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661401215153193d, y: 0.8960162976720211d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6815766875030854d, y: 0.13752961930494922d), new NpgsqlTypes.NpgsqlPoint(x: 0.329092452419516d, y: 0.17526958211596788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9026663494389711d, y: 0.6953384136136327d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7399797113860123d, y: 0.9825290264887548d), new NpgsqlTypes.NpgsqlPoint(x: 0.38014521084491615d, y: 0.20493400846715637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7202896108590611d, y: 0.3913365270764273d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3436160889438101d, y: 0.9535286982591991d), new NpgsqlTypes.NpgsqlPoint(x: 0.74294070141609d, y: 0.2648005941446574d), new NpgsqlTypes.NpgsqlPoint(x: 0.12316570917695813d, y: 0.559996746832624d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08280460779741772d, y: 0.8915886804643133d), new NpgsqlTypes.NpgsqlPoint(x: 0.14414578379445098d, y: 0.12098335587249809d), new NpgsqlTypes.NpgsqlPoint(x: 0.04104972677129326d, y: 0.1473187635760539d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7373130372187842d, y: 0.44856483705699235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322331227928335d, y: 0.052614065803924914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991834086605118d, y: 0.7647169333873736d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8107020438761409d, y: 0.1529028776539798d), new NpgsqlTypes.NpgsqlPoint(x: 0.24363630271659076d, y: 0.07741593210066267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4257390919260524d, y: 0.631476703869957d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45076154521177547d, y: 0.5383880337095773d), new NpgsqlTypes.NpgsqlPoint(x: 0.3677553070612706d, y: 0.8002577726546937d), new NpgsqlTypes.NpgsqlPoint(x: 0.08492302244634553d, y: 0.3704481731317816d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17898525986551994d, y: 0.6565332241572251d), new NpgsqlTypes.NpgsqlPoint(x: 0.56769778442024d, y: 0.01815838001622405d), new NpgsqlTypes.NpgsqlPoint(x: 0.856767686550705d, y: 0.03186087721418318d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9002905184615518d, y: 0.8064264733259008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6203234505474631d, y: 0.8177765999515577d), new NpgsqlTypes.NpgsqlPoint(x: 0.15972168776443774d, y: 0.665793088405331d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14910500563124862d, y: 0.18419068591837973d), new NpgsqlTypes.NpgsqlPoint(x: 0.8546381564625036d, y: 0.6281193978369707d), new NpgsqlTypes.NpgsqlPoint(x: 0.05213517848622673d, y: 0.051503463166487906d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4606149131857814d, y: 0.719550673520502d), new NpgsqlTypes.NpgsqlPoint(x: 0.4789748567479015d, y: 0.5004054614944208d), new NpgsqlTypes.NpgsqlPoint(x: 0.8979810926537413d, y: 0.23607058907207135d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016478833201047927d, y: 0.7231725410097395d), new NpgsqlTypes.NpgsqlPoint(x: 0.31682059733531986d, y: 0.25138763312930235d), new NpgsqlTypes.NpgsqlPoint(x: 0.11558468081116313d, y: 0.8399674818087897d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10862211433067359d, y: 0.9993605654725707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599076276052657d, y: 0.13492118609239767d), new NpgsqlTypes.NpgsqlPoint(x: 0.188663923389638d, y: 0.053653031767733284d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9993644735918207d, y: 0.2824664025790795d), new NpgsqlTypes.NpgsqlPoint(x: 0.4352261236347724d, y: 0.7533674749859048d), new NpgsqlTypes.NpgsqlPoint(x: 0.04760159617405535d, y: 0.9547754574340652d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2786919961284d, y: 0.13936952724938667d), new NpgsqlTypes.NpgsqlPoint(x: 0.733067472108491d, y: 0.9410250425780298d), new NpgsqlTypes.NpgsqlPoint(x: 0.4825542034540158d, y: 0.6690687947755272d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8328524215787877d, y: 0.0593299477974939d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861259791648165d, y: 0.8147386563854775d), new NpgsqlTypes.NpgsqlPoint(x: 0.07617658280090056d, y: 0.34537273311901373d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2855776004171373d, y: 0.6775859904264846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5729392371462214d, y: 0.2725092207574016d), new NpgsqlTypes.NpgsqlPoint(x: 0.6075402817716044d, y: 0.43937813367439804d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13084025196269722d, y: 0.3810535795771952d), new NpgsqlTypes.NpgsqlPoint(x: 0.5877124097286827d, y: 0.2970485365788941d), new NpgsqlTypes.NpgsqlPoint(x: 0.04448368112634016d, y: 0.8080084124530041d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.80602770868053d, y: 0.22481259860488823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9204154459114644d, y: 0.4578754225634286d), new NpgsqlTypes.NpgsqlPoint(x: 0.5321433871664836d, y: 0.9441000541263908d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17408626445734465d, y: 0.16440529529019932d), new NpgsqlTypes.NpgsqlPoint(x: 0.21116260183542246d, y: 0.4782950061107656d), new NpgsqlTypes.NpgsqlPoint(x: 0.7700319172146751d, y: 0.37397755647587994d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5776612636979368d, y: 0.2802711065266036d), new NpgsqlTypes.NpgsqlPoint(x: 0.03478761636904748d, y: 0.7109110943618677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370342632129667d, y: 0.9201284005742021d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4773971659499028d, y: 0.178223875818861d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276086143606228d, y: 0.8088276362303434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8702709366646808d, y: 0.12006925315420336d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9357421470231051d, y: 0.6500295723176889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972485839764863d, y: 0.2994455861672596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328286417816958d, y: 0.8050609112512299d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6209430533148975d, y: 0.20752863221966356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5760314566686412d, y: 0.3300892238514582d), new NpgsqlTypes.NpgsqlPoint(x: 0.10467586813157392d, y: 0.6387576571443032d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8649170483479894d, y: 0.41590089580679257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8559084518929682d, y: 0.29045277048398055d), new NpgsqlTypes.NpgsqlPoint(x: 0.22096669074019593d, y: 0.9106761750521084d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3890945034575255d, y: 0.6393179727128521d), new NpgsqlTypes.NpgsqlPoint(x: 0.30732909308329937d, y: 0.8010425435516826d), new NpgsqlTypes.NpgsqlPoint(x: 0.29711346031039176d, y: 0.2738191639135714d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5799214769803699d, y: 0.6016141615247134d), new NpgsqlTypes.NpgsqlPoint(x: 0.26148756819792596d, y: 0.3116874335288139d), new NpgsqlTypes.NpgsqlPoint(x: 0.43721152450220935d, y: 0.24869077555487595d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4673333801852403d, y: 0.4220359929309745d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139058162612065d, y: 0.31088662875975326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196805707069928d, y: 0.41093676001207247d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5240724443229825d, y: 0.4661378088092625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4348852113929603d, y: 0.836137754141738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196248282839384d, y: 0.25007295067788204d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6709458445105927d, y: 0.2548539908804818d), new NpgsqlTypes.NpgsqlPoint(x: 0.046484074626590766d, y: 0.8100040895531608d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253524193072804d, y: 0.48674071786043305d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9713269923597536d, y: 0.5261273270042247d), new NpgsqlTypes.NpgsqlPoint(x: 0.28871927766855776d, y: 0.6574383092024406d), new NpgsqlTypes.NpgsqlPoint(x: 0.970652060167743d, y: 0.9986121714565622d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.70074266196371d, y: 0.8241038385976178d), new NpgsqlTypes.NpgsqlPoint(x: 0.959174304971712d, y: 0.3135418443742112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8228236314718944d, y: 0.5809095085803769d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6198613511423896d, y: 0.7265335956853648d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729457809452899d, y: 0.8761049787718589d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606380921846768d, y: 0.39080553959665754d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1583751358786638d, y: 0.08706492295005186d), new NpgsqlTypes.NpgsqlPoint(x: 0.06432188587913157d, y: 0.734991204386721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7113932480802989d, y: 0.4165149349288797d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9624212307052784d, y: 0.6855785684397712d), new NpgsqlTypes.NpgsqlPoint(x: 0.45438062410388824d, y: 0.8660878142825981d), new NpgsqlTypes.NpgsqlPoint(x: 0.10359583251670512d, y: 0.38983061806271213d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2763347111164658d, y: 0.4205386199717098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837513413302474d, y: 0.3055354369984048d), new NpgsqlTypes.NpgsqlPoint(x: 0.18203754724151766d, y: 0.7198344382551006d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15956249145667856d, y: 0.8767439387467094d), new NpgsqlTypes.NpgsqlPoint(x: 0.4113047943592858d, y: 0.9339994145103603d), new NpgsqlTypes.NpgsqlPoint(x: 0.3206353883771096d, y: 0.7918531193371445d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07960284801695072d, y: 0.39673683529662374d), new NpgsqlTypes.NpgsqlPoint(x: 0.21997952520463837d, y: 0.12783155679755198d), new NpgsqlTypes.NpgsqlPoint(x: 0.02464775206126557d, y: 0.26486157756695095d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4166431126585015d, y: 0.6376540319089178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9935688712579087d, y: 0.7973838822780603d), new NpgsqlTypes.NpgsqlPoint(x: 0.9804977921413986d, y: 0.689416151894462d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.946439759519542d, y: 0.8616812075347243d), new NpgsqlTypes.NpgsqlPoint(x: 0.6910632975558106d, y: 0.8537926803792241d), new NpgsqlTypes.NpgsqlPoint(x: 0.7962730638372879d, y: 0.8354623257825209d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006940545035186929d, y: 0.8323768325310388d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277471659993423d, y: 0.9609021386278878d), new NpgsqlTypes.NpgsqlPoint(x: 0.28333815158433284d, y: 0.01319630886335088d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11372699907137418d, y: 0.6049587277864303d), new NpgsqlTypes.NpgsqlPoint(x: 0.43823839665234465d, y: 0.29159659549966876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8116430702966817d, y: 0.3460831010075446d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8022298356616366d, y: 0.6363818766414858d), new NpgsqlTypes.NpgsqlPoint(x: 0.44980919808683706d, y: 0.6235878638347676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468190193227043d, y: 0.7293566957787612d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0801947197306152d, y: 0.4335699121874763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5703066007534862d, y: 0.15156307668186775d), new NpgsqlTypes.NpgsqlPoint(x: 0.9898812991015051d, y: 0.8940144734493042d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39640609296705465d, y: 0.36850903994202655d), new NpgsqlTypes.NpgsqlPoint(x: 0.10790235286745387d, y: 0.04201229818541363d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430691944193503d, y: 0.5399025791117299d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3106220759516908d, y: 0.043779511374453906d), new NpgsqlTypes.NpgsqlPoint(x: 0.4752561486722522d, y: 0.9997902860704792d), new NpgsqlTypes.NpgsqlPoint(x: 0.4427417443455155d, y: 0.5143229348432486d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6621848228032501d, y: 0.17128577284643054d), new NpgsqlTypes.NpgsqlPoint(x: 0.41698098860848876d, y: 0.15942906390692668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302757402325514d, y: 0.0163529775441289d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6879407358888998d, y: 0.4981991855642085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7642848486966174d, y: 0.2550997723406755d), new NpgsqlTypes.NpgsqlPoint(x: 0.1860306486241271d, y: 0.33825136667059796d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5894316208134517d, y: 0.8885708489098725d), new NpgsqlTypes.NpgsqlPoint(x: 0.1087250347233778d, y: 0.25673145617456905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7343963675687375d, y: 0.5255579913897516d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.237864714899369d, y: 0.6484989876180697d), new NpgsqlTypes.NpgsqlPoint(x: 0.015616653413383585d, y: 0.747334130474267d), new NpgsqlTypes.NpgsqlPoint(x: 0.3634859677355644d, y: 0.23580724727573887d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3548092335007679d, y: 0.40646518030051226d), new NpgsqlTypes.NpgsqlPoint(x: 0.9324844002762567d, y: 0.5176752609436033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9227517651269151d, y: 0.6173192854176046d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6623058443531389d, y: 0.30385390614839747d), new NpgsqlTypes.NpgsqlPoint(x: 0.3999494950206922d, y: 0.06837210590776599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6237858474399728d, y: 0.4176452153878455d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35581285479011093d, y: 0.28356389952943173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8359058893607642d, y: 0.6257081628778242d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102892884276144d, y: 0.7335928590336351d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6696724752025695d, y: 0.06290166764328631d), new NpgsqlTypes.NpgsqlPoint(x: 0.7314870723128066d, y: 0.27153193062447567d), new NpgsqlTypes.NpgsqlPoint(x: 0.07293593727096337d, y: 0.8256158921968607d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8996277463630231d, y: 0.4747023831678815d), new NpgsqlTypes.NpgsqlPoint(x: 0.821739001477261d, y: 0.5708112784935937d), new NpgsqlTypes.NpgsqlPoint(x: 0.45446688532589696d, y: 0.006747003203216084d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5226778202741902d, y: 0.313748179478368d), new NpgsqlTypes.NpgsqlPoint(x: 0.3350902834160753d, y: 0.3329622706235744d), new NpgsqlTypes.NpgsqlPoint(x: 0.3322134584377705d, y: 0.5127044905305562d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8445692997118756d, y: 0.48987555323353105d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052899723727635d, y: 0.8767035730078381d), new NpgsqlTypes.NpgsqlPoint(x: 0.8823074393245309d, y: 0.7872091227437823d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.574865615282708d, y: 0.10510364068143985d), new NpgsqlTypes.NpgsqlPoint(x: 0.324235935498835d, y: 0.013366790606654244d), new NpgsqlTypes.NpgsqlPoint(x: 0.15618454919004365d, y: 0.670177149089593d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5953150094412165d, y: 0.5711669278869645d), new NpgsqlTypes.NpgsqlPoint(x: 0.283847173115537d, y: 0.1092370242495726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495272306655981d, y: 0.2780159628242219d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8436045523092981d, y: 0.9437443936017252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8171054006741838d, y: 0.8961190242907856d), new NpgsqlTypes.NpgsqlPoint(x: 0.002237005152984195d, y: 0.07886314234962777d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10998120566222813d, y: 0.2683478835008041d), new NpgsqlTypes.NpgsqlPoint(x: 0.1883531695026791d, y: 0.48106191467157333d), new NpgsqlTypes.NpgsqlPoint(x: 0.19530650610070532d, y: 0.3070151961528137d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5369089955853031d, y: 0.14856135244431168d), new NpgsqlTypes.NpgsqlPoint(x: 0.18544248491936643d, y: 0.9503571457123113d), new NpgsqlTypes.NpgsqlPoint(x: 0.026699208510782224d, y: 0.6800067448739707d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8198255513910577d, y: 0.027901180456290087d), new NpgsqlTypes.NpgsqlPoint(x: 0.8293433370754064d, y: 0.38308723290863556d), new NpgsqlTypes.NpgsqlPoint(x: 0.53195246065313d, y: 0.7746139213270579d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9359914484060242d, y: 0.463105585904523d), new NpgsqlTypes.NpgsqlPoint(x: 0.178207813043886d, y: 0.00273744807822085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8966715038012993d, y: 0.23134877398107234d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9501471710044619d, y: 0.6584418653253222d), new NpgsqlTypes.NpgsqlPoint(x: 0.546076961044318d, y: 0.31985093331841596d), new NpgsqlTypes.NpgsqlPoint(x: 0.009904186854017616d, y: 0.7034048415018427d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9601510263447931d, y: 0.5100540187108515d), new NpgsqlTypes.NpgsqlPoint(x: 0.274773390781051d, y: 0.2829354845132095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2991515388295759d, y: 0.6505754127515943d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8923448267839649d, y: 0.8630597081030272d), new NpgsqlTypes.NpgsqlPoint(x: 0.867243794726886d, y: 0.46012319205907726d), new NpgsqlTypes.NpgsqlPoint(x: 0.36809478335415946d, y: 0.8829622973374943d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8929196821560673d, y: 0.6405358956325492d), new NpgsqlTypes.NpgsqlPoint(x: 0.12889883289842885d, y: 0.480687228570311d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517872586228284d, y: 0.6140934077584207d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1168537410818673d, y: 0.09620234216678403d), new NpgsqlTypes.NpgsqlPoint(x: 0.836392689982587d, y: 0.29156607069828433d), new NpgsqlTypes.NpgsqlPoint(x: 0.422566289024341d, y: 0.4163188021632923d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.158981860518994d, y: 0.9311329700401295d), new NpgsqlTypes.NpgsqlPoint(x: 0.008582479795865683d, y: 0.2425988810157017d), new NpgsqlTypes.NpgsqlPoint(x: 0.20169421595579806d, y: 0.493964635025685d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6287163967123977d, y: 0.14569116229853962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7304224663851658d, y: 0.9381791107078604d), new NpgsqlTypes.NpgsqlPoint(x: 0.07296406067579053d, y: 0.5699863280920778d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07607336139833476d, y: 0.904017517049058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535337264407882d, y: 0.0839857179591249d), new NpgsqlTypes.NpgsqlPoint(x: 0.25098444406648746d, y: 0.35822102107977793d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5238308459080898d, y: 0.9554860050430188d), new NpgsqlTypes.NpgsqlPoint(x: 0.7786835683880562d, y: 0.4311470370798888d), new NpgsqlTypes.NpgsqlPoint(x: 0.5654357329539095d, y: 0.7124696652451826d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.854254965733301d, y: 0.01476488455588254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8196131836493789d, y: 0.9442113955737639d), new NpgsqlTypes.NpgsqlPoint(x: 0.6171382879347133d, y: 0.445025442225746d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7428941550490208d, y: 0.8399689629626791d), new NpgsqlTypes.NpgsqlPoint(x: 0.7919197053185902d, y: 0.8538102088593016d), new NpgsqlTypes.NpgsqlPoint(x: 0.5163829767144955d, y: 0.4421096226566352d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39936013030568274d, y: 0.5172838789472995d), new NpgsqlTypes.NpgsqlPoint(x: 0.3758554973836029d, y: 0.8548598800500113d), new NpgsqlTypes.NpgsqlPoint(x: 0.07679209425059641d, y: 0.40714353059465647d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13796255811725922d, y: 0.43135777007037335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6868461584797648d, y: 0.19084351138658062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5104679268015145d, y: 0.58781889479591d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9447254185309244d, y: 0.9966525624810594d), new NpgsqlTypes.NpgsqlPoint(x: 0.0413311266986357d, y: 0.2639674969143331d), new NpgsqlTypes.NpgsqlPoint(x: 0.07965760762411678d, y: 0.7664710118805351d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48303299473935646d, y: 0.8677568641510757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8986563534276041d, y: 0.7202807097075629d), new NpgsqlTypes.NpgsqlPoint(x: 0.6735609830929642d, y: 0.8130182497762852d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6027858073744334d, y: 0.13206432800170154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351551537768825d, y: 0.38222825398926186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5307244965624851d, y: 0.8085231972860165d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6492154884261315d, y: 0.48544729977779144d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301365996356514d, y: 0.922587709002565d), new NpgsqlTypes.NpgsqlPoint(x: 0.9883312929213952d, y: 0.04063004425654204d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20463232471609238d, y: 0.4417263430944658d), new NpgsqlTypes.NpgsqlPoint(x: 0.501058990689643d, y: 0.6975494129313274d), new NpgsqlTypes.NpgsqlPoint(x: 0.9401190588112532d, y: 0.9672023817717125d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7072612732943945d, y: 0.8162754370884681d), new NpgsqlTypes.NpgsqlPoint(x: 0.43059297865224244d, y: 0.4002918464039201d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848425590230718d, y: 0.25110757944478257d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11906618730833896d, y: 0.9409199480616965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8287328490964945d, y: 0.5792069002959782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5516157969789298d, y: 0.2528176598863091d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23332712098979402d, y: 0.6739258442552221d), new NpgsqlTypes.NpgsqlPoint(x: 0.373944090027574d, y: 0.12282810453442305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9796731842451274d, y: 0.6109528172898153d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7680433948748586d, y: 0.7444212726126682d), new NpgsqlTypes.NpgsqlPoint(x: 0.06990040063037084d, y: 0.9859444642367245d), new NpgsqlTypes.NpgsqlPoint(x: 0.8562443174944322d, y: 0.8806036008081453d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04006862346783291d, y: 0.22421548201811936d), new NpgsqlTypes.NpgsqlPoint(x: 0.31154943101782007d, y: 0.388780612907927d), new NpgsqlTypes.NpgsqlPoint(x: 0.37374207990843267d, y: 0.9401144876300227d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14929510703263282d, y: 0.9388468648738233d), new NpgsqlTypes.NpgsqlPoint(x: 0.30462334263754687d, y: 0.47250339633092386d), new NpgsqlTypes.NpgsqlPoint(x: 0.3976686525771498d, y: 0.097182388304617d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7780478520531485d, y: 0.4548913214430852d), new NpgsqlTypes.NpgsqlPoint(x: 0.683379232668349d, y: 0.35227854052667207d), new NpgsqlTypes.NpgsqlPoint(x: 0.09593325103907724d, y: 0.11542470981962605d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7055965613961103d, y: 0.6720260992863477d), new NpgsqlTypes.NpgsqlPoint(x: 0.3561541055229025d, y: 0.9281027619786164d), new NpgsqlTypes.NpgsqlPoint(x: 0.02685146153576834d, y: 0.6820267250290644d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9154975237457507d, y: 0.11000729760422334d), new NpgsqlTypes.NpgsqlPoint(x: 0.5505655045258013d, y: 0.7554615909068427d), new NpgsqlTypes.NpgsqlPoint(x: 0.7955493201475793d, y: 0.6122232273543474d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5290155175005895d, y: 0.6469453509622733d), new NpgsqlTypes.NpgsqlPoint(x: 0.1576807802060528d, y: 0.315565464111338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181631361776608d, y: 0.18716033887647854d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16966542981473431d, y: 0.019441347569115863d), new NpgsqlTypes.NpgsqlPoint(x: 0.5869369869518889d, y: 0.1927829286130739d), new NpgsqlTypes.NpgsqlPoint(x: 0.48537839409291506d, y: 0.48764635499047515d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6373668349877811d, y: 0.16842432675482255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4908600115975943d, y: 0.8257850684809264d), new NpgsqlTypes.NpgsqlPoint(x: 0.28245936060747023d, y: 0.8254277370799873d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45542201651498393d, y: 0.44568613586033323d), new NpgsqlTypes.NpgsqlPoint(x: 0.4985274220591107d, y: 0.6946815073217827d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383470904314611d, y: 0.5783632138282897d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6709217938039636d, y: 0.9987462323491529d), new NpgsqlTypes.NpgsqlPoint(x: 0.2707816345553985d, y: 0.9121588285644963d), new NpgsqlTypes.NpgsqlPoint(x: 0.8758122940747964d, y: 0.09220550195178467d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6143109223107985d, y: 0.48979599374204597d), new NpgsqlTypes.NpgsqlPoint(x: 0.13342245866851477d, y: 0.5391265390325378d), new NpgsqlTypes.NpgsqlPoint(x: 0.12900036030061113d, y: 0.043788027557535525d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4005717022671601d, y: 0.05477296525911646d), new NpgsqlTypes.NpgsqlPoint(x: 0.20517587253609337d, y: 0.940495595009687d), new NpgsqlTypes.NpgsqlPoint(x: 0.34431695245363636d, y: 0.9467945064577267d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5357867433251531d, y: 0.22838071014126826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7133541343025315d, y: 0.5477177346996276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8297623904478506d, y: 0.9100580301382722d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3660337471115701d, y: 0.04942574414752754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7731789554406441d, y: 0.03720058701041218d), new NpgsqlTypes.NpgsqlPoint(x: 0.25609233112171204d, y: 0.7895880498221974d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5516268605136643d, y: 0.39687476883655204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652762198818898d, y: 0.832165711938359d), new NpgsqlTypes.NpgsqlPoint(x: 0.38143552287917215d, y: 0.6620736145522209d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43840320641503017d, y: 0.3104610893645735d), new NpgsqlTypes.NpgsqlPoint(x: 0.45384107996983203d, y: 0.5846977647099076d), new NpgsqlTypes.NpgsqlPoint(x: 0.10023867524884189d, y: 0.5759455314510434d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5124223902644233d, y: 0.22470158954138897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7231592796469761d, y: 0.4926384412762993d), new NpgsqlTypes.NpgsqlPoint(x: 0.47879543405315383d, y: 0.09480178641016446d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7597357742527212d, y: 0.8878556640574725d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278744870166374d, y: 0.16583320718368566d), new NpgsqlTypes.NpgsqlPoint(x: 0.3800080110055023d, y: 0.6911651931562484d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6985055559075622d, y: 0.5169865230480782d), new NpgsqlTypes.NpgsqlPoint(x: 0.9908395518512438d, y: 0.990856386129013d), new NpgsqlTypes.NpgsqlPoint(x: 0.21685970904876983d, y: 0.07149089022816735d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7423305117708618d, y: 0.49619867599725576d), new NpgsqlTypes.NpgsqlPoint(x: 0.6953310547862878d, y: 0.4884377742348178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270077499004938d, y: 0.04685451099953575d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.805159176344222d, y: 0.279053835589713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050025488086344d, y: 0.049316230759546054d), new NpgsqlTypes.NpgsqlPoint(x: 0.699883181846158d, y: 0.5178690484698066d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24622426085630478d, y: 0.9691444579583055d), new NpgsqlTypes.NpgsqlPoint(x: 0.8766797071662371d, y: 0.12322505385351201d), new NpgsqlTypes.NpgsqlPoint(x: 0.065924285009341d, y: 0.20403113025137598d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8862389029338561d, y: 0.12307944613414734d), new NpgsqlTypes.NpgsqlPoint(x: 0.8035593213419483d, y: 0.7694554852726274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6197632022189487d, y: 0.6762154118188216d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9821920204474665d, y: 0.36250207014776537d), new NpgsqlTypes.NpgsqlPoint(x: 0.469656250678429d, y: 0.3206164185959802d), new NpgsqlTypes.NpgsqlPoint(x: 0.004206096823954786d, y: 0.5088874217950563d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18902055155810427d, y: 0.26995303041275953d), new NpgsqlTypes.NpgsqlPoint(x: 0.390624961760644d, y: 0.21766606751340578d), new NpgsqlTypes.NpgsqlPoint(x: 0.49421596434805726d, y: 0.38873694328267827d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6631061726209488d, y: 0.39862865630734856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6354405188587159d, y: 0.9953007945065072d), new NpgsqlTypes.NpgsqlPoint(x: 0.27963480843909105d, y: 0.7806410221661314d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5169265098404514d, y: 0.8300400361480623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5519049725107731d, y: 0.5769814981310067d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565573216667576d, y: 0.4050627778629591d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8932828622898135d, y: 0.057363061462078924d), new NpgsqlTypes.NpgsqlPoint(x: 0.4061224473497036d, y: 0.7799616555105536d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078585694101533d, y: 0.0579668504943055d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4057792613736031d, y: 0.9810700782948806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8165793535689488d, y: 0.6210171323195713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926322438799089d, y: 0.9272712125939516d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35906706815448697d, y: 0.7276974450700403d), new NpgsqlTypes.NpgsqlPoint(x: 0.18911948948298596d, y: 0.37075926937209025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7306543786125101d, y: 0.32980073678916033d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.77419956424622d, y: 0.06868593426663372d), new NpgsqlTypes.NpgsqlPoint(x: 0.03681753577305513d, y: 0.21723315143533994d), new NpgsqlTypes.NpgsqlPoint(x: 0.887913593169301d, y: 0.5734696019340735d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1433649458289502d, y: 0.40515039460043867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206840807433159d, y: 0.4757503953881633d), new NpgsqlTypes.NpgsqlPoint(x: 0.9367643597533264d, y: 0.641962214264461d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39307038170456443d, y: 0.8015145256931979d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464944138474837d, y: 0.4554523063443635d), new NpgsqlTypes.NpgsqlPoint(x: 0.5791008046212324d, y: 0.7071771858183789d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7987122495585871d, y: 0.967499724404274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5841462567164515d, y: 0.16505299832300968d), new NpgsqlTypes.NpgsqlPoint(x: 0.8362382489639136d, y: 0.5996236677636188d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3666593671787872d, y: 0.669106128949931d), new NpgsqlTypes.NpgsqlPoint(x: 0.6766713147904032d, y: 0.07445501482773909d), new NpgsqlTypes.NpgsqlPoint(x: 0.21439647502843273d, y: 0.2636961067126864d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15400525103160623d, y: 0.23071153057155624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936935493194766d, y: 0.23134830809063156d), new NpgsqlTypes.NpgsqlPoint(x: 0.1841576982116384d, y: 0.6404354357246936d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9002546473285521d, y: 0.031248316139487087d), new NpgsqlTypes.NpgsqlPoint(x: 0.03619109610767357d, y: 0.891011645959658d), new NpgsqlTypes.NpgsqlPoint(x: 0.8201668820217212d, y: 0.3559459368609601d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3210444747751229d, y: 0.353840877500218d), new NpgsqlTypes.NpgsqlPoint(x: 0.8297399795418366d, y: 0.7770866658538337d), new NpgsqlTypes.NpgsqlPoint(x: 0.5867639824013026d, y: 0.32269471750263234d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08186785811006891d, y: 0.13005889580041874d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387040533741587d, y: 0.055393826432089566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5876512189543457d, y: 0.08977648020669138d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21756610509034202d, y: 0.7175922741762316d), new NpgsqlTypes.NpgsqlPoint(x: 0.778996848650481d, y: 0.8119805588884359d), new NpgsqlTypes.NpgsqlPoint(x: 0.5030992610427366d, y: 0.07347812752323235d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5522056968607314d, y: 0.062436151336331513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4485289515117755d, y: 0.7028434834532956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5259828074611145d, y: 0.6768745999877155d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5566137185816984d, y: 0.7105581691100418d), new NpgsqlTypes.NpgsqlPoint(x: 0.40106249274765693d, y: 0.6511411824234156d), new NpgsqlTypes.NpgsqlPoint(x: 0.3532588945758993d, y: 0.14950566389851883d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12996719179084049d, y: 0.6696635678731314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6975260857500649d, y: 0.5667392895353661d), new NpgsqlTypes.NpgsqlPoint(x: 0.10249733138589678d, y: 0.1912197564225453d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1656636242791768d, y: 0.01871289913537766d), new NpgsqlTypes.NpgsqlPoint(x: 0.4474834585244052d, y: 0.44831718780792473d), new NpgsqlTypes.NpgsqlPoint(x: 0.09098069408818621d, y: 0.5866877430031279d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7420688289435039d, y: 0.831595162650602d), new NpgsqlTypes.NpgsqlPoint(x: 0.1632483422058355d, y: 0.1866554092260525d), new NpgsqlTypes.NpgsqlPoint(x: 0.7010372995739833d, y: 0.017201067106474732d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4775393420532098d, y: 0.3774911344353836d), new NpgsqlTypes.NpgsqlPoint(x: 0.4548682608416553d, y: 0.4987879974715872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8586235811442273d, y: 0.17530705286992265d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07727053388990202d, y: 0.7509068530780141d), new NpgsqlTypes.NpgsqlPoint(x: 0.5013957528811749d, y: 0.45639516161436466d), new NpgsqlTypes.NpgsqlPoint(x: 0.4810374916666257d, y: 0.9536969547833655d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10988433539321307d, y: 0.9237930977367687d), new NpgsqlTypes.NpgsqlPoint(x: 0.2911976809285002d, y: 0.4431978040801221d), new NpgsqlTypes.NpgsqlPoint(x: 0.046817097033500565d, y: 0.37302003326718347d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36584930435788654d, y: 0.5362185092516512d), new NpgsqlTypes.NpgsqlPoint(x: 0.5691932354098245d, y: 0.821302148485464d), new NpgsqlTypes.NpgsqlPoint(x: 0.06878105625677744d, y: 0.8354148594866446d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4266623744094299d, y: 0.717118276166095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987489711785694d, y: 0.3192265805908435d), new NpgsqlTypes.NpgsqlPoint(x: 0.939002552562273d, y: 0.3565697125090539d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5637998248735142d, y: 0.9968994599777983d), new NpgsqlTypes.NpgsqlPoint(x: 0.48686084661569695d, y: 0.1537066785165776d), new NpgsqlTypes.NpgsqlPoint(x: 0.17483712544122465d, y: 0.1624626042003311d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.997427551906406d, y: 0.653329305568423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5389747003737566d, y: 0.8133151438289473d), new NpgsqlTypes.NpgsqlPoint(x: 0.1738016630517698d, y: 0.7049622015908023d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8795034054498714d, y: 0.5138281694994836d), new NpgsqlTypes.NpgsqlPoint(x: 0.07171560716667191d, y: 0.5826462214787801d), new NpgsqlTypes.NpgsqlPoint(x: 0.50447236132173d, y: 0.1622294162770822d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21519785990994134d, y: 0.8519761559766367d), new NpgsqlTypes.NpgsqlPoint(x: 0.22316825802948903d, y: 0.6347166179338722d), new NpgsqlTypes.NpgsqlPoint(x: 0.21875534031329857d, y: 0.7287909622196622d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04224689302116069d, y: 0.0028426888799871763d), new NpgsqlTypes.NpgsqlPoint(x: 0.48387881586697723d, y: 0.08366511611198912d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536439366576859d, y: 0.6408432486959255d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8733785922987016d, y: 0.7974357203323875d), new NpgsqlTypes.NpgsqlPoint(x: 0.24041027782340962d, y: 0.4130270878998238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585886242539349d, y: 0.002683156393121d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5046188793309073d, y: 0.07356390659993206d), new NpgsqlTypes.NpgsqlPoint(x: 0.04551180691841816d, y: 0.5117767506986121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5172963668295946d, y: 0.8203837459416203d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9394967975098641d, y: 0.8561369536698875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9662236909804636d, y: 0.703161300487546d), new NpgsqlTypes.NpgsqlPoint(x: 0.22610102525641051d, y: 0.5699422162392127d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20680472277598427d, y: 0.2817878079265478d), new NpgsqlTypes.NpgsqlPoint(x: 0.46870467599974874d, y: 0.7625326706540825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406138682141654d, y: 0.75213352774802d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3482286246889589d, y: 0.7153785143127378d), new NpgsqlTypes.NpgsqlPoint(x: 0.8962020702735921d, y: 0.418212288481254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7664877425371761d, y: 0.9035438712566801d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7235600576369844d, y: 0.459945549438011d), new NpgsqlTypes.NpgsqlPoint(x: 0.38703249580943777d, y: 0.5542362140970034d), new NpgsqlTypes.NpgsqlPoint(x: 0.7826663823675258d, y: 0.9262240429658958d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5643407446492661d, y: 0.3717276655252174d), new NpgsqlTypes.NpgsqlPoint(x: 0.2404294606992381d, y: 0.7977610910539287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5316575217714536d, y: 0.9932858762484768d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12135076525213506d, y: 0.35125708287826574d), new NpgsqlTypes.NpgsqlPoint(x: 0.35525231701928484d, y: 0.33953277667637016d), new NpgsqlTypes.NpgsqlPoint(x: 0.7593483977339343d, y: 0.47812210026242175d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36211155348114377d, y: 0.14641643542826444d), new NpgsqlTypes.NpgsqlPoint(x: 0.20631443881921052d, y: 0.0709655381443991d), new NpgsqlTypes.NpgsqlPoint(x: 0.031420431216118594d, y: 0.13757306609506892d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08777506020097858d, y: 0.8077733436293311d), new NpgsqlTypes.NpgsqlPoint(x: 0.8017928177995814d, y: 0.7549389924700325d), new NpgsqlTypes.NpgsqlPoint(x: 0.7291363751119591d, y: 0.7394466792531742d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2706852143945989d, y: 0.6938051527419705d), new NpgsqlTypes.NpgsqlPoint(x: 0.05929076369879316d, y: 0.8391684527434483d), new NpgsqlTypes.NpgsqlPoint(x: 0.8538460643056723d, y: 0.8212331544720418d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20193284974492665d, y: 0.8495733767802423d), new NpgsqlTypes.NpgsqlPoint(x: 0.18416805732813446d, y: 0.8763137315317454d), new NpgsqlTypes.NpgsqlPoint(x: 0.08881139837881369d, y: 0.9496123394732108d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8533243227146734d, y: 0.9111656881903756d), new NpgsqlTypes.NpgsqlPoint(x: 0.13744052622077485d, y: 0.6820092383574806d), new NpgsqlTypes.NpgsqlPoint(x: 0.2024853220792011d, y: 0.12757265103849302d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8909870026112617d, y: 0.8283139882765634d), new NpgsqlTypes.NpgsqlPoint(x: 0.044581373737821006d, y: 0.9531771551075519d), new NpgsqlTypes.NpgsqlPoint(x: 0.35350789101156466d, y: 0.524886012052583d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4741997256775753d, y: 0.23843664467687053d), new NpgsqlTypes.NpgsqlPoint(x: 0.6749141501606907d, y: 0.8360182681417345d), new NpgsqlTypes.NpgsqlPoint(x: 0.398429649198231d, y: 0.974546512546717d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25873490587725123d, y: 0.45312619278488675d), new NpgsqlTypes.NpgsqlPoint(x: 0.736335425343259d, y: 0.9194991920064709d), new NpgsqlTypes.NpgsqlPoint(x: 0.7352138658789134d, y: 0.00926661701079623d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16996421858292377d, y: 0.29760309338418167d), new NpgsqlTypes.NpgsqlPoint(x: 0.16845144085152697d, y: 0.32409260438472676d), new NpgsqlTypes.NpgsqlPoint(x: 0.1944515536267748d, y: 0.2976128814181992d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17546126270578366d, y: 0.8445415728826087d), new NpgsqlTypes.NpgsqlPoint(x: 0.586926420606131d, y: 0.2358204327390695d), new NpgsqlTypes.NpgsqlPoint(x: 0.53181844245019d, y: 0.9359715183070967d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.717573493488959d, y: 0.23086974477227318d), new NpgsqlTypes.NpgsqlPoint(x: 0.08422645400472828d, y: 0.5499775258427761d), new NpgsqlTypes.NpgsqlPoint(x: 0.15247156840386322d, y: 0.4905771971599646d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7505670366342039d, y: 0.4515968105716438d), new NpgsqlTypes.NpgsqlPoint(x: 0.2122210985131331d, y: 0.2754047486630119d), new NpgsqlTypes.NpgsqlPoint(x: 0.33362770986709767d, y: 0.8847339712457025d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9723083944646328d, y: 0.33017336224702265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7698556930397505d, y: 0.061345792318876824d), new NpgsqlTypes.NpgsqlPoint(x: 0.6556094358621809d, y: 0.7760986549269355d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2459536372725587d, y: 0.34973757518902904d), new NpgsqlTypes.NpgsqlPoint(x: 0.31527856289256273d, y: 0.7044907382575671d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363091108271178d, y: 0.12136898903208526d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6972334903903229d, y: 0.2405637404288843d), new NpgsqlTypes.NpgsqlPoint(x: 0.502925107580609d, y: 0.6444958257072126d), new NpgsqlTypes.NpgsqlPoint(x: 0.7515817976287117d, y: 0.06658755663959881d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8578055537100971d, y: 0.49182805406468844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122646798689731d, y: 0.6655853414419729d), new NpgsqlTypes.NpgsqlPoint(x: 0.3079541265429846d, y: 0.47764434490842955d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7774845022957162d, y: 0.22123515991001497d), new NpgsqlTypes.NpgsqlPoint(x: 0.4139224797699115d, y: 0.7842551575381602d), new NpgsqlTypes.NpgsqlPoint(x: 0.9231404597214878d, y: 0.0339216872691136d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3749843650147642d, y: 0.4599469992150522d), new NpgsqlTypes.NpgsqlPoint(x: 0.6340005949039565d, y: 0.39570284803626354d), new NpgsqlTypes.NpgsqlPoint(x: 0.34446764108657846d, y: 0.262966543128371d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08312762152405873d, y: 0.46042346989154226d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063476477940918d, y: 0.40612933250824446d), new NpgsqlTypes.NpgsqlPoint(x: 0.06329356328043179d, y: 0.13291806054103084d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6505197705863328d, y: 0.24536115838480566d), new NpgsqlTypes.NpgsqlPoint(x: 0.2958369656832217d, y: 0.8119832862172417d), new NpgsqlTypes.NpgsqlPoint(x: 0.599317900394795d, y: 0.4268843397670645d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8538838379648714d, y: 0.721071353832318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5541239044031291d, y: 0.6579624923408535d), new NpgsqlTypes.NpgsqlPoint(x: 0.35959154374083613d, y: 0.8800600431657511d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3990711228862994d, y: 0.8391946091637822d), new NpgsqlTypes.NpgsqlPoint(x: 0.8277216589229446d, y: 0.5545704222516095d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746722640956094d, y: 0.44720318868135767d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9563370748141982d, y: 0.8257672023312098d), new NpgsqlTypes.NpgsqlPoint(x: 0.2291806837892274d, y: 0.16937345752261723d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429017653906007d, y: 0.4633914290027559d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.570622559481349d, y: 0.0726587066738259d), new NpgsqlTypes.NpgsqlPoint(x: 0.29495967832640757d, y: 0.7236487700170469d), new NpgsqlTypes.NpgsqlPoint(x: 0.14855954038264851d, y: 0.9208354561913789d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5932625441970596d, y: 0.7320096754095978d), new NpgsqlTypes.NpgsqlPoint(x: 0.4607439666397497d, y: 0.6264843244582077d), new NpgsqlTypes.NpgsqlPoint(x: 0.7383578064067876d, y: 0.9853968282526484d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4342976717817164d, y: 0.8835783163774094d), new NpgsqlTypes.NpgsqlPoint(x: 0.06991032893002402d, y: 0.43511505570995845d), new NpgsqlTypes.NpgsqlPoint(x: 0.39191364562760556d, y: 0.4249456184496554d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9218130503966697d, y: 0.6763346946806539d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875003578248796d, y: 0.9231385693483521d), new NpgsqlTypes.NpgsqlPoint(x: 0.7629367952164747d, y: 0.3650893328769127d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34529530135343267d, y: 0.6089822680090681d), new NpgsqlTypes.NpgsqlPoint(x: 0.08190752813852342d, y: 0.45411638119856557d), new NpgsqlTypes.NpgsqlPoint(x: 0.031937780625831746d, y: 0.6694618117633765d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9811729272098624d, y: 0.9230539762138169d), new NpgsqlTypes.NpgsqlPoint(x: 0.7811623303135747d, y: 0.10804078984377075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514052850628624d, y: 0.9938021898364355d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024565530191282825d, y: 0.5817921750067574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5217119043823474d, y: 0.006753954063139056d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805069588423584d, y: 0.2232360895670824d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9940277478758842d, y: 0.11158608128065628d), new NpgsqlTypes.NpgsqlPoint(x: 0.9014684210059677d, y: 0.43024642476356345d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191544362177522d, y: 0.11022602243481927d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7685964876401631d, y: 0.5165310174629092d), new NpgsqlTypes.NpgsqlPoint(x: 0.3854433959605642d, y: 0.41893432010575526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8970171381206582d, y: 0.31441563052683175d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6039624812900436d, y: 0.8707671052928971d), new NpgsqlTypes.NpgsqlPoint(x: 0.838303077544205d, y: 0.8551200978924575d), new NpgsqlTypes.NpgsqlPoint(x: 0.031354085807956955d, y: 0.1458582439038032d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6838408740556348d, y: 0.9066147809863284d), new NpgsqlTypes.NpgsqlPoint(x: 0.858950754653374d, y: 0.6560325286156461d), new NpgsqlTypes.NpgsqlPoint(x: 0.4814793700597545d, y: 0.5056685818236825d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8994369765828092d, y: 0.5053815262261446d), new NpgsqlTypes.NpgsqlPoint(x: 0.21562174391403388d, y: 0.9350980452355313d), new NpgsqlTypes.NpgsqlPoint(x: 0.609810435409426d, y: 0.4231311990767327d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09978132970881226d, y: 0.10449778758710415d), new NpgsqlTypes.NpgsqlPoint(x: 0.08489809727667363d, y: 0.8442125277601932d), new NpgsqlTypes.NpgsqlPoint(x: 0.092184812515399d, y: 0.054261971652541874d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41044576334705785d, y: 0.3172615793168263d), new NpgsqlTypes.NpgsqlPoint(x: 0.48864276736022594d, y: 0.9025125860528115d), new NpgsqlTypes.NpgsqlPoint(x: 0.32993870941962067d, y: 0.5688046963285986d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3597733409736027d, y: 0.6407024993506064d), new NpgsqlTypes.NpgsqlPoint(x: 0.4691746242343112d, y: 0.7110000791558635d), new NpgsqlTypes.NpgsqlPoint(x: 0.3775071803004917d, y: 0.5619389874248558d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9788461302773201d, y: 0.8267698814341589d), new NpgsqlTypes.NpgsqlPoint(x: 0.7899243088814687d, y: 0.434103963158732d), new NpgsqlTypes.NpgsqlPoint(x: 0.37208031439151135d, y: 0.9687482622936442d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8201053760001085d, y: 0.7248560121106573d), new NpgsqlTypes.NpgsqlPoint(x: 0.37233550057912046d, y: 0.789253895249858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517999795339208d, y: 0.9496923017361953d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26766540603019306d, y: 0.16018388593939537d), new NpgsqlTypes.NpgsqlPoint(x: 0.2792347351383071d, y: 0.8813452900648902d), new NpgsqlTypes.NpgsqlPoint(x: 0.3575720888914675d, y: 0.5920502432389214d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6824470303269704d, y: 0.5853523085933521d), new NpgsqlTypes.NpgsqlPoint(x: 0.11988587171417187d, y: 0.6751670119038199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8716413891942093d, y: 0.03868185522241141d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8131113411316805d, y: 0.6079552712973875d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846943685316766d, y: 0.3261476034766666d), new NpgsqlTypes.NpgsqlPoint(x: 0.12993755298751097d, y: 0.45764410158171187d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27080349645494217d, y: 0.8059022066197854d), new NpgsqlTypes.NpgsqlPoint(x: 0.2847084054733997d, y: 0.6753426825940361d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479375821784282d, y: 0.927143972469093d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8017167693118856d, y: 0.10401448900158472d), new NpgsqlTypes.NpgsqlPoint(x: 0.9777555585542919d, y: 0.331965771897503d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628357258865626d, y: 0.37208195441124414d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05361644592321402d, y: 0.4220995970903003d), new NpgsqlTypes.NpgsqlPoint(x: 0.7909764198823858d, y: 0.7882050009498239d), new NpgsqlTypes.NpgsqlPoint(x: 0.5348730400149339d, y: 0.3008929207646771d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9407098437203472d, y: 0.977648005721932d), new NpgsqlTypes.NpgsqlPoint(x: 0.2502219110395364d, y: 0.7440915366171035d), new NpgsqlTypes.NpgsqlPoint(x: 0.7163071379847902d, y: 0.5427807816301187d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22135476904568807d, y: 0.1336612649205955d), new NpgsqlTypes.NpgsqlPoint(x: 0.39895953498775816d, y: 0.6589832870611377d), new NpgsqlTypes.NpgsqlPoint(x: 0.46057413219357224d, y: 0.5342290160056056d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3734927075039671d, y: 0.8544305572257798d), new NpgsqlTypes.NpgsqlPoint(x: 0.9022426284152142d, y: 0.8411387867070191d), new NpgsqlTypes.NpgsqlPoint(x: 0.9053704751219108d, y: 0.7790119911138756d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20344931126088905d, y: 0.8507334478538362d), new NpgsqlTypes.NpgsqlPoint(x: 0.8877200658509544d, y: 0.2613786255924341d), new NpgsqlTypes.NpgsqlPoint(x: 0.794239679938422d, y: 0.9463650328008282d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14761489506820313d, y: 0.9110681625405452d), new NpgsqlTypes.NpgsqlPoint(x: 0.40607285470322985d, y: 0.8584404041460636d), new NpgsqlTypes.NpgsqlPoint(x: 0.32563820935986965d, y: 0.4238751769439546d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6259631444872474d, y: 0.0034739110302803855d), new NpgsqlTypes.NpgsqlPoint(x: 0.9309165335094429d, y: 0.04583646930412344d), new NpgsqlTypes.NpgsqlPoint(x: 0.25060148809571303d, y: 0.08337572720604336d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4866496802479996d, y: 0.8184994267805165d), new NpgsqlTypes.NpgsqlPoint(x: 0.033556642166031936d, y: 0.2193797109808452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6058885874519064d, y: 0.624869738152022d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07062262276828613d, y: 0.3355617214933613d), new NpgsqlTypes.NpgsqlPoint(x: 0.12290617402262882d, y: 0.8439033500345829d), new NpgsqlTypes.NpgsqlPoint(x: 0.10180873566258752d, y: 0.47754125813520243d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9429401380507195d, y: 0.783164462298183d), new NpgsqlTypes.NpgsqlPoint(x: 0.42457897327344574d, y: 0.15984635561426086d), new NpgsqlTypes.NpgsqlPoint(x: 0.715030791205202d, y: 0.09518478292629762d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9196216685526836d, y: 0.5864400461182347d), new NpgsqlTypes.NpgsqlPoint(x: 0.20247030596025095d, y: 0.4134399095113448d), new NpgsqlTypes.NpgsqlPoint(x: 0.07098237839218957d, y: 0.9343696735526881d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4320070758569984d, y: 0.7528490293694204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7301240757564122d, y: 0.12323738142781238d), new NpgsqlTypes.NpgsqlPoint(x: 0.14181926165870817d, y: 0.9587666022413229d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8940269674165876d, y: 0.5054995669912307d), new NpgsqlTypes.NpgsqlPoint(x: 0.13136356821301542d, y: 0.6961524250552135d), new NpgsqlTypes.NpgsqlPoint(x: 0.2540593365893553d, y: 0.21235217809063622d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29331132250082836d, y: 0.16145042084935146d), new NpgsqlTypes.NpgsqlPoint(x: 0.7528853736666428d, y: 0.14768177692823525d), new NpgsqlTypes.NpgsqlPoint(x: 0.19336917012085575d, y: 0.06804816817853965d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6693776203488777d, y: 0.4179807230920197d), new NpgsqlTypes.NpgsqlPoint(x: 0.6572184977947695d, y: 0.516563621985291d), new NpgsqlTypes.NpgsqlPoint(x: 0.44836860124624445d, y: 0.7829138032926011d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6958546790823228d, y: 0.21511099594239835d), new NpgsqlTypes.NpgsqlPoint(x: 0.06541055527036954d, y: 0.21392932895961203d), new NpgsqlTypes.NpgsqlPoint(x: 0.02643700126979187d, y: 0.5883007261561947d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.660797688835635d, y: 0.9907999294197846d), new NpgsqlTypes.NpgsqlPoint(x: 0.8965343796677491d, y: 0.06054855914659196d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418978717551023d, y: 0.682028049245474d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.989172099852279d, y: 0.13037874907792935d), new NpgsqlTypes.NpgsqlPoint(x: 0.8523680442504782d, y: 0.17898197950140315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8776414232859524d, y: 0.9455678279617963d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8394812234632427d, y: 0.364635003722972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8105992161134806d, y: 0.09751092180163701d), new NpgsqlTypes.NpgsqlPoint(x: 0.26292262967456026d, y: 0.24414647046630378d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22087729346473672d, y: 0.3199638198836302d), new NpgsqlTypes.NpgsqlPoint(x: 0.2521827105995297d, y: 0.9589271743786494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9272574417073998d, y: 0.8216459371556081d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8244018098113947d, y: 0.8484442607436541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9492039178794416d, y: 0.7952440064842498d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625440669329383d, y: 0.1849092911774849d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8563271839436586d, y: 0.39432379917349936d), new NpgsqlTypes.NpgsqlPoint(x: 0.005400710490040206d, y: 0.07017313660887625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4793869178804018d, y: 0.457474887615526d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42040088159592814d, y: 0.043715951352929605d), new NpgsqlTypes.NpgsqlPoint(x: 0.38335484297977696d, y: 0.5251060150288206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8327477089807022d, y: 0.9295801886972309d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09599827683461015d, y: 0.22958444207339113d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470336479749988d, y: 0.8005423540055607d), new NpgsqlTypes.NpgsqlPoint(x: 0.9153018936639536d, y: 0.7463119670338897d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3494222132632676d, y: 0.02201769613964899d), new NpgsqlTypes.NpgsqlPoint(x: 0.1693633518188128d, y: 0.3145891795993505d), new NpgsqlTypes.NpgsqlPoint(x: 0.4514689750184171d, y: 0.8350238598464403d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5077882131362926d, y: 0.06489121304355872d), new NpgsqlTypes.NpgsqlPoint(x: 0.18934098135181165d, y: 0.06953750869953612d), new NpgsqlTypes.NpgsqlPoint(x: 0.14624117246290558d, y: 0.7222810587361499d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8459958379216255d, y: 0.0521737768414815d), new NpgsqlTypes.NpgsqlPoint(x: 0.009963124200904172d, y: 0.4360167726616382d), new NpgsqlTypes.NpgsqlPoint(x: 0.900585154798693d, y: 0.7258938851703378d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5939416826831334d, y: 0.5900622270548027d), new NpgsqlTypes.NpgsqlPoint(x: 0.05278945010005265d, y: 0.9209562475294917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5577058139476998d, y: 0.5136832544140225d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28424360964272266d, y: 0.2617797630097546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7370173972798394d, y: 0.04792217455768366d), new NpgsqlTypes.NpgsqlPoint(x: 0.9131309977034331d, y: 0.5089705725910789d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
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

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3106220759516908d, y: 0.043779511374453906d), new NpgsqlTypes.NpgsqlPoint(x: 0.4752561486722522d, y: 0.9997902860704792d), new NpgsqlTypes.NpgsqlPoint(x: 0.4427417443455155d, y: 0.5143229348432486d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6621848228032501d, y: 0.17128577284643054d), new NpgsqlTypes.NpgsqlPoint(x: 0.41698098860848876d, y: 0.15942906390692668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302757402325514d, y: 0.0163529775441289d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6879407358888998d, y: 0.4981991855642085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7642848486966174d, y: 0.2550997723406755d), new NpgsqlTypes.NpgsqlPoint(x: 0.1860306486241271d, y: 0.33825136667059796d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5894316208134517d, y: 0.8885708489098725d), new NpgsqlTypes.NpgsqlPoint(x: 0.1087250347233778d, y: 0.25673145617456905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7343963675687375d, y: 0.5255579913897516d)),
}));
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

                var models = await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[29], false);
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

                var models =  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 91, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 134, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelBatchAsync(connection, 91, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[29], false);
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
                var models =  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelBatch(connection, 89, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[4], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[5], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[1], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[2], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[3], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[4], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[5], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonArraypolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1M>(15);

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
                ((INpgsqlPolygonArraypolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

