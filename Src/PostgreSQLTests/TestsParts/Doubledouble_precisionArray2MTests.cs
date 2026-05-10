

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
    internal partial interface IDoubleListdouble_precisionArray
    {
    }
    
    internal partial class DoubleListdouble_precisionArray : IDoubleListdouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray2M[] _testData = new Doubledouble_precisionArray2M[]
        {
            new Doubledouble_precisionArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8273858842160223d,

0.8057087823433279d,

0.901243596327272d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9366652205906416d,

0.24461312372680144d,

0.7053417612455042d,

0.3476303251342888d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.15313960952251693d,

0.2837677109444826d,

0.10387796336444932d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7171143332181396d,

0.801733423320358d,

0.984544889564621d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5533148441130642d,

0.35464465781538534d,

0.7524283044326919d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4813176571518789d,

0.5370047355475409d,

0.19791899068682173d,

0.7768999671888025d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.011192889420288843d,

0.9340622012149495d,

0.7521613597271564d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.17914455928675066d,

0.033394469179319985d,

0.9188584493930892d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5942680876204117d,

0.7958983109938214d,

0.457538314892073d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9119175937798042d,

0.2565121983290488d,

0.8917132746679564d,

0.983882210111039d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6475464936754267d,

0.3765499201482634d,

0.05458672301267853d,

0.002200107317019806d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2829995895708899d,

0.011697502828871276d,

0.6468746754837207d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47047551020262124d,

0.711995264684832d,

0.20033741086984913d,

0.4134126513528026d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.27058894001110056d,

0.5406080135559114d,

0.016992184927310472d,

0.5107209471657883d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.06334211630017239d,

0.5711363885981244d,

0.498746588984433d,

0.9722738134991994d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.608322040440839d,

0.13151763711679698d,

0.22580437879691617d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.14721561172131026d,

0.10596285261847416d,

0.7767419236103552d,

0.8550110414864327d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9143591175550655d,

0.52347351824073d,

0.3466410727757482d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4477477871123847d,

0.35803005647983654d,

0.7998997191002145d,

0.8838150661047837d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3321901549004086d,

0.10598049650670793d,

0.021238440502721945d,

0.6042771929441093d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9293438891509321d,

0.5668046239203463d,

0.9457746667939174d,

0.8525649045206193d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.513210212225732d,

0.34769581384932546d,

0.26467186158073164d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.465353802731318d,

0.006700834493717722d,

0.9494633857559871d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.09096883800536881d,

0.8268516114434257d,

0.018055525641269887d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7022127343779133d,

0.038611288099393515d,

0.4489739008453948d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5810149237807557d,

0.13699742459391728d,

0.810950047241451d,

0.004613802255449384d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5064733651254975d,

0.40849840860384556d,

0.37660298170735507d,

0.9873171988067214d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8913995610071208d,

0.7976686651325099d,

0.9480363529351601d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8918235865637201d,

0.40271061689315246d,

0.6304909629043254d,

0.9495813132145987d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31149777341996565d,

0.09626608020368999d,

0.5637098393746618d,

0.5246061788306426d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6738141541891195d,

0.30076053956945037d,

0.5796530996840172d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6597544234655036d,

0.6391065723365612d,

0.786859689879825d,

0.6102775660348669d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9037790885440303d,

0.7857074505440755d,

0.702454964468344d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7967911773166372d,

0.7747977078582229d,

0.5685738945215382d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.39019686130319753d,

0.2646214799078216d,

0.52916983785448d,

0.4122182752336895d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5339560928158956d,

0.0468377504333668d,

0.8516353809492216d,

0.7013950704695672d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8245092876886135d,

0.9331841085639422d,

0.8718192425483301d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8111973353691755d,

0.41841675589375216d,

0.9942207418117722d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9582848741963819d,

0.5733846213000808d,

0.00433594349592914d,

0.32606961797670264d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19057276643739907d,

0.6180992928552711d,

0.7327789971366873d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.792400760274778d,

0.8378508141776155d,

0.48735429484022474d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07394214330415938d,

0.7973386769668782d,

0.5990138891540085d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.009990004807130526d,

0.8708851318143499d,

0.29818970161789093d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6323228667389907d,

0.3160935621551175d,

0.5532717446758093d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6700667751992841d,

0.9376676913689201d,

0.559290231178153d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08449418059209335d,

0.9528184873286394d,

0.34174391602143195d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6222931777988163d,

0.4686443867492741d,

0.6945639075044696d,

0.4021373037224206d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13678102669695746d,

0.12051586840007544d,

0.6034339035987059d,

0.9831690621747827d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8091506666525344d,

0.14754146781822264d,

0.49173403731699583d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18716718319109416d,

0.39677571209619467d,

0.5196334419778669d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07870752785055024d,

0.3230002747506471d,

0.48620787024167766d,

0.7357843759445184d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.03069372281943028d,

0.36178320958589216d,

0.7589651811275426d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.14465009305266907d,

0.27758023372775076d,

0.8803731310799046d,

0.068559425494914d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.52152080337595d,

0.7014870273944394d,

0.7824474203936735d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.37069535396240527d,

0.477453007173262d,

0.07241326222351008d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2999417175563467d,

0.6213125685865504d,

0.3736166775121187d,

0.20208943594333895d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5793079657206721d,

0.7958587926769132d,

0.7729167391926981d,

0.3250941765839632d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.03462915456496807d,

0.1270084652893989d,

0.14079396733775107d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29152043864542054d,

0.6934118743520893d,

0.9471337812090558d,

0.9741022516053401d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6851315979629345d,

0.2544343403563747d,

0.45259936417684443d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8412979078117042d,

0.8230123499145033d,

0.04796224900337864d,

0.8992486887787114d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.41488107547701547d,

0.2173980353753574d,

0.7027274556608667d,

0.4622574874225922d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9031357755705d,

0.49400064877018535d,

0.18071591652905306d,

0.25410782221013883d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5907410467280216d,

0.29240976749610126d,

0.47431753501770346d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2708233354638242d,

0.8485619127388456d,

0.8547131777328104d,

0.05686701823603857d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.09424406265519691d,

0.22429786726280587d,

0.5798793857907937d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.26406297785440047d,

0.5882439696433973d,

0.3710591180499324d,

0.49110981498580986d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6654192414117621d,

0.5923143869026705d,

0.12142719842112759d,

0.9387379601348841d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.250976290138775d,

0.5734698158224603d,

0.39674317163210393d,

0.7098923889552528d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8257129517405494d,

0.3506680156267461d,

0.9908579332628024d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19651916257732716d,

0.6371892334354295d,

0.29084789608947104d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31645960204375423d,

0.9093142424994081d,

0.976322508479334d,

0.6815646142779591d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.06611786650547335d,

0.665174226969719d,

0.9321257780818794d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.579417733628689d,

0.0024952226731036475d,

0.35377289942692036d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.024818974477793132d,

0.5992835961677615d,

0.00029434534674055435d,

0.12254437426150888d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6805090372331138d,

0.6965069376094303d,

0.8608025760945691d,

0.06854305870962074d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6011610666722543d,

0.4557568597757743d,

0.07442540093802041d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.24070618165134083d,

0.9440742011441666d,

0.16952022891794072d,

0.9346197010333168d,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                List<Doubledouble_precisionArray2M> models = null;

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 164;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 93, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 88, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 65, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 83, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 94, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 31, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 97, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[34], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[16], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[17], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[18], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[29], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[30], false);
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[31], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[32], false);
                Doubledouble_precisionArray2M.AssertModel(models[18],_testData[33], false);
                Doubledouble_precisionArray2M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[30], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[31], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[32], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[33], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MI),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionArray2M),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2m m
LEFT JOIN public.binary_doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI), typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models1 = new List<Doubledouble_precisionArray2MI>();
                var models2 = new List<Doubledouble_precisionArray2MI>();
                await ((IDoubleListdouble_precisionArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MI>();
                var models2 = new List<Doubledouble_precisionArray2MI>();
                ((IDoubleListdouble_precisionArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

