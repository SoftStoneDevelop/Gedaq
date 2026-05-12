

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
    internal partial interface IDoubleMArraydouble_precisionMMArrayD2
    {
    }
    
    internal partial class DoubleMArraydouble_precisionMMArrayD2 : IDoubleMArraydouble_precisionMMArrayD2
    {


#region TestData

        private readonly Doubledouble_precisionMMArrayD2E1M[] _testData = new Doubledouble_precisionMMArrayD2E1M[]
        {
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 6,
    Value = 
new System.Double[,] { { 0.02845695255395453d, 0.4974737850389249d, }, { 0.09337481359348421d, 0.8213636107214255d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 7,
    Value = 
new System.Double[,] { { 0.36027516587649766d, 0.799208581515224d, }, { 0.7734280674854916d, 0.0631981203430021d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Double[,] { { 0.3825212277843463d, 0.5810658591412645d, }, { 0.7658877904347378d, 0.03631847173423153d, }, },
    NullableValue = 
new System.Double[,] { { 0.6113351750672159d, 0.32246266348042263d, }, { 0.7340713529543362d, 0.004946271366827459d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.46061129009511703d, 0.007931018278139246d, }, { 0.13031066253393286d, 0.25710599302526693d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Double[,] { { 0.9372625393559868d, 0.200511575799162d, }, { 0.2682839715097648d, 0.3451279664613476d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.1587490861235188d, 0.058349650744180415d, }, { 0.027538390433188287d, 0.7301198068834641d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 18,
    Value = 
new System.Double[,] { { 0.9713941998704667d, 0.08731306779674397d, }, { 0.19956767901951733d, 0.5037130435014661d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Double[,] { { 0.744765605271939d, 0.9620145204685435d, }, { 0.5040337496186906d, 0.008228741001904072d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Double[,] { { 0.6466157042625227d, 0.775190135875142d, }, { 0.7711304093682122d, 0.27579578657251713d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.9728654473006879d, 0.08879557033004548d, }, { 0.7615226694781885d, 0.7298730195555981d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Double[,] { { 0.7482407561487251d, 0.3115373081992725d, }, { 0.8308756914146443d, 0.3542606351064863d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Double[,] { { 0.11520869786692833d, 0.759432802495943d, }, { 0.5262981202723458d, 0.743760679614356d, }, },
    NullableValue = 
new System.Double[,] { { 0.49671829961928193d, 0.550867152434365d, }, { 0.6454205775548786d, 0.988525653935721d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Double[,] { { 0.8927324352093633d, 0.654552394536605d, }, { 0.2708802004224571d, 0.43177299534215496d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Double[,] { { 0.341863278853637d, 0.48342299746835093d, }, { 0.1790181794857183d, 0.46106298611300567d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Double[,] { { 0.21421988515889478d, 0.6971199141291393d, }, { 0.9373102073778168d, 0.6106900875603578d, }, },
    NullableValue = 
new System.Double[,] { { 0.4161892913137526d, 0.9354112671818676d, }, { 0.031802565804986194d, 0.3335439916634326d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.5494889134576902d, 0.6653186335927301d, }, { 0.8344869424246618d, 0.2902108323762249d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 48,
    Value = 
new System.Double[,] { { 0.23119209897166026d, 0.1612664060851452d, }, { 0.6136938011856501d, 0.09976162172372993d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Double[,] { { 0.6342292652755293d, 0.458959236935078d, }, { 0.020535500746126756d, 0.12458957758081957d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Double[,] { { 0.3531672388385868d, 0.1198263241349421d, }, { 0.5690555390262485d, 0.7328732015047884d, }, },
    NullableValue = 
new System.Double[,] { { 0.8053445020786277d, 0.14189211345649033d, }, { 0.5851899252704487d, 0.8096483463066981d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.26703626169680805d, 0.1820132130954235d, }, { 0.15195631388385977d, 0.3626306039655046d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 62,
    Value = 
new System.Double[,] { { 0.36638382055333907d, 0.94658822229068d, }, { 0.6623162495436936d, 0.7778639790673143d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Double[,] { { 0.7309959577077043d, 0.9525178784274368d, }, { 0.6057210200046471d, 0.22929979646343523d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Double[,] { { 0.7418213059677822d, 0.7414923275692051d, }, { 0.8786566094282822d, 0.9714830707457797d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.7434854286606651d, 0.42464386815744015d, }, { 0.24019669554043355d, 0.33472535931719904d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Double[,] { { 0.74494948511669d, 0.4663338290801199d, }, { 0.45954862928681184d, 0.9228353942808222d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.6783611389627084d, 0.30514841028251893d, }, { 0.30610758252720494d, 0.3086023844012873d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Double[,] { { 0.0775771822930379d, 0.6864466435653646d, }, { 0.39313800459450976d, 0.3130197887711832d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Double[,] { { 0.651230608475758d, 0.21328811417125015d, }, { 0.06897496442302775d, 0.9504478012905648d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.5150343307699469d, 0.6648876969948312d, }, { 0.6174805869775639d, 0.927248033057511d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Double[,] { { 0.03237426571841995d, 0.6910301481375968d, }, { 0.995611082633213d, 0.15778536935193577d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.3946689686172914d, 0.8675891030537877d, }, { 0.3731632107951145d, 0.953426681069592d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Double[,] { { 0.37481428030791764d, 0.5545825756544045d, }, { 0.2665950395308613d, 0.15194380580401112d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Double[,] { { 0.8401945376958295d, 0.8201940612118314d, }, { 0.21169601226515777d, 0.3764004437562777d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Double[,] { { 0.14275524538644413d, 0.21599668293146346d, }, { 0.46332867104313336d, 0.6860216670602503d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Double[,] { { 0.4284403956680062d, 0.4364660538518159d, }, { 0.19593515426285213d, 0.6216045193708711d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Double[,] { { 0.44297474959029415d, 0.7142246721051467d, }, { 0.058209855815511524d, 0.8059707304247723d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.351731828892769d, 0.40056015381676435d, }, { 0.10266240370695612d, 0.31124414894532115d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Double[,] { { 0.9455631080175125d, 0.025184193816507383d, }, { 0.11425659784102893d, 0.061259927265539194d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Double[,] { { 0.861373668430567d, 0.3386979736209006d, }, { 0.27120307266313937d, 0.5563094579622795d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Double[,] { { 0.34489780397490266d, 0.5419756922513946d, }, { 0.6420609819980173d, 0.684327299540187d, }, },
    NullableValue = 
new System.Double[,] { { 0.9122783077700645d, 0.9824435532109143d, }, { 0.9674626115358417d, 0.9959010280378133d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Double[,] { { 0.6370151139713123d, 0.44632998115403966d, }, { 0.5946282582113545d, 0.28285523906970644d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.2972527614675352d, 0.9045055392195154d, }, { 0.5141804059902073d, 0.9246864307152773d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 108,
    Value = 
new System.Double[,] { { 0.7457216066703785d, 0.17157911018657157d, }, { 0.36775118643158144d, 0.3834717648665513d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Double[,] { { 0.8209612334263503d, 0.5749007713704163d, }, { 0.2958444909045982d, 0.11683607741052449d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.6391717731350886d, 0.12718651284716087d, }, { 0.7007206797299973d, 0.8295565638836403d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Double[,] { { 0.788378282983547d, 0.6384742331818459d, }, { 0.03338330480281271d, 0.26609212008910477d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Double[,] { { 0.42375737066253616d, 0.33797310984102735d, }, { 0.095423267885419d, 0.9552884799421605d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Double[,] { { 0.32037566297119313d, 0.02290973889471748d, }, { 0.056929997088429496d, 0.8317763454470691d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Double[,] { { 0.6341464784023627d, 0.5134329831953064d, }, { 0.3485572503112113d, 0.08317621263767894d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Double[,] { { 0.47760072108392837d, 0.5771697474934121d, }, { 0.474662275551472d, 0.007759119087837774d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Double[,] { { 0.6049910883644832d, 0.8164336028457391d, }, { 0.4862035732885961d, 0.974409773598386d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.02018685920437646d, 0.6845932557723623d, }, { 0.9339473089306672d, 0.6710837419888442d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Double[,] { { 0.303018430237611d, 0.6406153574445286d, }, { 0.1638717283138763d, 0.8310246516024608d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Double[,] { { 0.7718003770943495d, 0.10751971259510007d, }, { 0.6305432846470815d, 0.2856072124520298d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Double[,] { { 0.9241505835603369d, 0.7374898522900822d, }, { 0.4382802961953277d, 0.7212311795858801d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.34599690523994275d, 0.4075793362814918d, }, { 0.408955543933042d, 0.4702308019598096d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Double[,] { { 0.7790670306204791d, 0.22415418711535828d, }, { 0.20891618418878966d, 0.4628234716443722d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.14329154390243137d, 0.12042552802586926d, }, { 0.3216339262859529d, 0.9674597885081664d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 163,
    Value = 
new System.Double[,] { { 0.3836739926375595d, 0.6344238770360517d, }, { 0.12462577422898835d, 0.10128861994033334d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Double[,] { { 0.8829776877987712d, 0.7316903694379626d, }, { 0.8583556626444768d, 0.9540656887858809d, }, },
    NullableValue = 
new System.Double[,] { { 0.6666050224358415d, 0.4086889913710212d, }, { 0.1195792857181226d, 0.5455055112178645d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 171,
    Value = 
new System.Double[,] { { 0.13483707117531019d, 0.45990073235502327d, }, { 0.4753074998856449d, 0.4861416844727785d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.8977159385965942d, 0.923691249935871d, }, { 0.8052887824503064d, 0.5499294493435386d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 172,
    Value = 
new System.Double[,] { { 0.49054679170737725d, 0.24118086355445645d, }, { 0.5900062871164732d, 0.7941335783801208d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Double[,] { { 0.10573330604662123d, 0.3554122826705889d, }, { 0.4222714677492758d, 0.10895098700830907d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.527239628395652d, 0.3750670169511733d, }, { 0.7953611625620587d, 0.49940323804013864d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Double[,] { { 0.5333007458388787d, 0.44753389427332213d, }, { 0.9808254918897129d, 0.5511826833259602d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 174,
    Value = 
new System.Double[,] { { 0.6325327249896205d, 0.7010601546941662d, }, { 0.7645311730732303d, 0.6649383398948325d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Double[,] { { 0.28425943015878663d, 0.45879030820045963d, }, { 0.49996789076018944d, 0.8528561902187511d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.5406640285114858d, 0.651041824552556d, }, { 0.289406418545597d, 0.05391761067383227d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 183,
    Value = 
new System.Double[,] { { 0.6905877471288947d, 0.3298004080100474d, }, { 0.6744320809950906d, 0.466716323709783d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.7804139555471495d, 0.8727741140743974d, }, { 0.27603506199797534d, 0.7561611013844569d, }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1mi(
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
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

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd2e1mi_id", 
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
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                System.Double[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.9728654473006879d, 0.08879557033004548d, }, { 0.7615226694781885d, 0.7298730195555981d, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Double[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.5494889134576902d, 0.6653186335927301d, }, { 0.8344869424246618d, 0.2902108323762249d, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd2e1mi_id", 
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
                System.Double[,] nullable = null;
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.26703626169680805d, 0.1820132130954235d, }, { 0.15195631388385977d, 0.3626306039655046d, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[,] nullable = null;
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.7434854286606651d, 0.42464386815744015d, }, { 0.24019669554043355d, 0.33472535931719904d, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD2E1M> models = null;

                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD2E1M> models = null;

                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 172;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 18, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 127, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 171, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 93, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 7, query1, 163, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 6, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 77, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 7, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((IDoubleMArraydouble_precisionMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleMArraydouble_precisionMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 171);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
FROM public.binary_doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.binary_doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI), typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

