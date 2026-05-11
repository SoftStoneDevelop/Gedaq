

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
    internal partial interface IGuidMArrayuuidMMArrayD1
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD1 : IGuidMArrayuuidMMArrayD1
    {


#region TestData

        private readonly GuiduuidMMArrayD1E1M[] _testData = new GuiduuidMMArrayD1E1M[]
        {
            new GuiduuidMMArrayD1E1M
{
    Id = 2,
    Value = 
new System.Guid[3]
{
Guid.Parse("21ad48a5-d28c-4fee-afdd-5c0f6dd7276c"),
Guid.Parse("30c738ac-67f7-4eb5-a642-5ae12633736a"),
Guid.Parse("471f9977-80bf-43a3-a651-e1277e8cf8cf"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Guid[4]
{
Guid.Parse("48740305-e3bb-4609-af3a-002b62f805dd"),
Guid.Parse("0e84c90d-1270-4601-9798-1f93631d1a8d"),
Guid.Parse("bd7e1464-2537-41a1-94c7-329736e8a4f4"),
Guid.Parse("dc76cbe0-ecd8-4967-a16d-8077a266b806"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("5ee4ad9b-347c-4ec5-ad97-3e84405f0a4c"),
Guid.Parse("5a13ff53-dcba-4b97-b8cb-4ae24e36c8e5"),
Guid.Parse("cc906226-c799-4a4f-b18a-165cb5819e98"),
Guid.Parse("2eedaa6c-2455-44ec-aa38-44e71730d775"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Guid[4]
{
Guid.Parse("46410be7-1ba4-4617-8938-d24d44df20da"),
Guid.Parse("ade9da11-043b-4a62-b581-e697cb3d5b84"),
Guid.Parse("a6d099f6-0f8b-43c3-ad49-d572b88d21da"),
Guid.Parse("ff2eb39f-cc3f-4ab8-a337-6991b721d43a"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Guid[3]
{
Guid.Parse("b2bdef30-52af-4574-b846-f56b40c513a9"),
Guid.Parse("6b5b4f50-e475-40d6-a507-7c79c8834e9a"),
Guid.Parse("72c60bd6-6d13-4e6c-84d0-302768b5fe5a"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("1b68856d-53ed-4d31-b3ea-9aa254e38c62"),
Guid.Parse("86406583-876a-4447-ae47-14bccc3200d8"),
Guid.Parse("2bca17e3-2447-429a-82da-7809b7a2ea86"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("cfd70fac-5fef-4e91-b36b-956bd34bc1e4"),
Guid.Parse("dc9863c6-6b18-411b-acf9-56aad13e10fb"),
Guid.Parse("f5d7cf6b-dec6-4b12-904b-75e61a03e3ae"),
Guid.Parse("968d5591-8155-4b31-94ba-7254303526c2"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("26cbb0fa-9fe3-49da-95ab-c5d1d01d37db"),
Guid.Parse("a14c2fc2-3122-4691-a0c2-c402476fb0bc"),
Guid.Parse("3b67cd2f-dba7-4075-b022-2155464bffd4"),
Guid.Parse("e8a16648-55fd-44d5-99f5-8a2b705ba854"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9f499026-b871-49b3-94bf-acdd74388237"),
Guid.Parse("504bb38f-d672-4758-bd5c-4fd6ed29d243"),
Guid.Parse("e5fa4f88-bf83-4674-baa9-fcbdc3de541c"),
Guid.Parse("ae7fae89-d46d-4302-9104-0ae702ecca70"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("fd2a23e3-f463-4da7-a6f8-369ec3f90123"),
Guid.Parse("d181fcce-53a4-4e57-b78f-7b937621f6b8"),
Guid.Parse("a64b7b15-9d2a-4101-9cea-a2970723394a"),
Guid.Parse("3597e065-7bc9-467f-b7a2-b2b0cfe8b593"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Guid[4]
{
Guid.Parse("2e0c6de0-120a-4d11-ba75-58165465bb53"),
Guid.Parse("6670cf99-027e-4e17-83d5-633d12706e8a"),
Guid.Parse("94a19aa1-9eda-47c5-be52-6a59636aab2a"),
Guid.Parse("70a7423d-eed6-4479-aded-c2f97d66529d"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("24f59736-4313-4906-8ecc-78d6317aa471"),
Guid.Parse("5c1fb61d-abcd-41c0-b4a2-d8f9c821fb2e"),
Guid.Parse("defcd21d-2266-4a77-b899-f989a5ea45d8"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("3cf5c301-5d52-4af9-8d7f-158b04f22c07"),
Guid.Parse("00773c65-cd99-40ef-a097-44ff3db643be"),
Guid.Parse("7e875fb6-6d9b-4c63-bb28-6fd5cdee1d14"),
Guid.Parse("ecadd7c6-e925-453d-8fe5-c7319373faf4"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("558804e4-3fea-4979-a97c-6f8052d2b76f"),
Guid.Parse("7ef5a574-fd71-424e-8e42-c8995ab55ab7"),
Guid.Parse("931b033d-bb6d-45c9-af0e-9c696bb4eade"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("1005421d-b403-40f3-8303-4cdb80840761"),
Guid.Parse("77912651-5a22-499b-9dcf-7a83149db7f9"),
Guid.Parse("67069215-0fbe-4edd-a82c-68bc96e02cd8"),
Guid.Parse("1806ae7d-c935-46f3-891a-3668e17a2b0b"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Guid[3]
{
Guid.Parse("2f95cf7c-2fbf-4c3c-b824-1ba967516d25"),
Guid.Parse("a2ffef42-2a4d-4f9f-9f33-2bb39993c8a1"),
Guid.Parse("c9188376-dc79-4713-85bb-b2b3c0ba412b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4fff44d1-d1c4-4735-a94a-b87531789b3c"),
Guid.Parse("25793262-68e7-4514-addb-4b24e6b4b38b"),
Guid.Parse("1111c6d8-97c4-40ad-bc78-c3486720d44e"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("99116925-22d6-4f35-ace8-0306248e4bee"),
Guid.Parse("05bd582e-44d3-469a-9025-6a32c213f3ab"),
Guid.Parse("9361140a-e3e3-42ab-8d43-2219f1124bfd"),
Guid.Parse("6ecd28b6-9a9a-42cc-aed4-cc4e81ee6e86"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Guid[4]
{
Guid.Parse("ba6f75d3-21d1-4a8b-bdf1-0a9991d7d580"),
Guid.Parse("2979bcdb-22ba-4859-a7e8-a89ad994159d"),
Guid.Parse("cce083b9-b899-4cea-8937-99b5cda2fde1"),
Guid.Parse("131e3f10-ece9-44cc-adad-5ffe7c94a597"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("6830b3f2-a499-4bee-9c82-6bd32baf7ea2"),
Guid.Parse("bad6a663-84d3-4a29-982a-7bc9869aa909"),
Guid.Parse("c49e0cee-bc0f-4ad5-8076-b11840787801"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("869cc6a0-7232-4208-9226-1eb059422b8e"),
Guid.Parse("64fac8f4-ead1-41d8-bcdb-d6ca58aa4c3c"),
Guid.Parse("efcf79a6-e1b6-44c6-8d67-791bbd3b8e6d"),
Guid.Parse("5ba055d0-2e19-4f57-9b4e-c555bc453fcc"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1dcbc53c-e251-4afc-aa93-cffa72baad56"),
Guid.Parse("45f5efef-4523-4947-a213-1ff900f741ed"),
Guid.Parse("abd4e267-9f90-49c1-8118-cf53a30903cc"),
Guid.Parse("d0ade919-bb70-4e33-adb7-7219f64edafa"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Guid[3]
{
Guid.Parse("fa89c811-3d2e-4356-85d5-5b6469e7f8d5"),
Guid.Parse("82617889-956d-4b84-af30-7da40352e392"),
Guid.Parse("12176214-593c-488e-9dfb-4add4c94d6e5"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("527f82c4-66a2-4358-a272-fa4b044c3741"),
Guid.Parse("23458ebb-b769-49d9-b4cd-508514af89a4"),
Guid.Parse("9d27e126-723a-4fd6-8a23-5c489c38b6a4"),
Guid.Parse("af9717eb-d16d-4edc-81d4-c4c6ef0a51c1"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Guid[4]
{
Guid.Parse("d4bdb4bd-7eac-45fa-ba49-6432e271654c"),
Guid.Parse("26474a73-73ed-4edd-80a7-b8a4dc75e4ec"),
Guid.Parse("1964d2bc-32a5-4393-98d7-52ab6a8989a1"),
Guid.Parse("994e7f24-50d0-45d5-877d-b80dd5133463"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Guid[4]
{
Guid.Parse("33522ae0-2452-48bd-8e38-59140c6d0759"),
Guid.Parse("ecc30c9b-b1f9-4f10-b6b8-5ca9b6e14034"),
Guid.Parse("18a80219-0d53-430e-abe9-a4a42fc68968"),
Guid.Parse("6ddf225c-92af-445f-9d32-be5fc5f34fa5"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Guid[3]
{
Guid.Parse("e65a8fe9-5c64-4aa9-84ca-884501ad2e3b"),
Guid.Parse("ab94b345-6c9d-416a-9e41-044609af98e2"),
Guid.Parse("a9d09350-e5fc-4cb5-a69a-42b6f574e5fd"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Guid[3]
{
Guid.Parse("a167aec4-64fb-458e-8993-ae8ba1d17c5b"),
Guid.Parse("24a55142-f4d3-4902-953c-a98b696d1ae0"),
Guid.Parse("64f4e095-4e1e-477c-8998-2170e35e6e31"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Guid[4]
{
Guid.Parse("dc042138-4873-413b-bd79-1bfca346e8f3"),
Guid.Parse("62710f14-163e-492b-a697-569799ea367a"),
Guid.Parse("7e3ef968-9f93-4348-9724-e7e0b2ebc6e8"),
Guid.Parse("9fd8d8db-2b7c-459e-8047-bf12e122e1e9"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2491cd93-a32b-4550-b449-369b2e032a48"),
Guid.Parse("e82c20ae-963b-44fb-82f5-bf81a1873623"),
Guid.Parse("4678f41c-ffaf-4d49-9b20-3401ac95a835"),
Guid.Parse("afde8bee-befb-4394-9564-551feeff0a1b"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d9e6043a-8ccb-4761-9617-f315066c7a8f"),
Guid.Parse("36766331-57f2-4549-be42-7f42a01df69f"),
Guid.Parse("fc803de4-3369-4e4a-98d2-e8d36a4f240f"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Guid[4]
{
Guid.Parse("0aaaa9e4-5ae3-4f56-a33b-5cfd4db03d8e"),
Guid.Parse("1a17a483-f8e3-46b8-bb0c-1f45cc2dfcc8"),
Guid.Parse("409f05e6-9c04-47c7-8d42-85817596585c"),
Guid.Parse("1760c53f-e7d0-4e4c-ade5-bc945d810c81"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("dbd3bf4d-f27c-4d98-a213-cd3d093f624d"),
Guid.Parse("afcf62d7-e179-4195-ac56-31f9171fd3aa"),
Guid.Parse("de666240-16b2-4a21-a89d-5d3ad19a17e8"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Guid[4]
{
Guid.Parse("648f5703-7065-4842-bd5c-075c44abf7d9"),
Guid.Parse("e4d5647c-72f3-4751-8229-a382967f9a41"),
Guid.Parse("bb5dfdb9-a279-49b0-b6bd-83dd48fb4eee"),
Guid.Parse("178b2066-f4c1-4b07-aba8-6b693ce7296e"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("00f7ebdd-4f29-458f-9358-c8b76a727710"),
Guid.Parse("7b8ff44d-b652-4e09-b39d-dbe5efdd75bd"),
Guid.Parse("55efb353-c7c8-44ea-8d5c-568c86f65787"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("833c1c4e-0674-4a0f-a883-b7c1de42c048"),
Guid.Parse("dad68f20-44b3-48ef-a358-c3bb96bfcb3a"),
Guid.Parse("3df6baf1-55ad-4186-99e9-c62d1e49ef89"),
Guid.Parse("0fdeac47-195b-4488-af8c-31bb00e6791c"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("41dd961c-9ffa-46f2-9cbe-dd22c4781b1c"),
Guid.Parse("00d9e6fb-367c-41d0-89d4-62c8e8aec3ee"),
Guid.Parse("39747193-3176-414e-ae34-4581621bf11d"),
Guid.Parse("eb35784e-67cc-44a7-af02-65619cefab02"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e39fb015-6dd3-414a-9192-75725650e35e"),
Guid.Parse("9467b2f5-86c7-4038-9e15-9e86a4e9da27"),
Guid.Parse("281c211d-50e6-46ed-a4d7-4249ab2a2304"),
Guid.Parse("5e762cbc-b0b0-4ba8-bc72-e7fe7b9e54bb"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("7dd76a6c-4c5d-4559-8e97-a5183b27fff4"),
Guid.Parse("3dc2a265-f185-4a56-acf1-15edd9ee6c38"),
Guid.Parse("120970f0-8fef-4890-96f2-f81292ceb460"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("d232bbbd-7897-40dd-a9ed-e17afbe55faf"),
Guid.Parse("fb570919-d9ea-46b1-aeb4-613043382c53"),
Guid.Parse("c8b778c6-ff42-45d6-9f8b-47b45e7fc7f6"),
Guid.Parse("2f805bb3-4a66-45a5-9a28-30030308a490"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9f285f02-2277-4713-a695-2367cbe8d0e9"),
Guid.Parse("563e150b-0e4a-4251-8542-b3196dc34c99"),
Guid.Parse("ce5a2a9e-36ac-4b70-bfc4-ca0a928ed9ce"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("af009653-66f9-4719-a135-841c64ecb3b4"),
Guid.Parse("472e4a3e-43ae-4d90-8393-193b370df8c1"),
Guid.Parse("cadd9574-e090-4135-81e9-442723aec2e5"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Guid[4]
{
Guid.Parse("5196345a-bfc2-4f8c-a098-a74a2ec76869"),
Guid.Parse("5ec56d41-daf6-4a95-80cc-06e4888bc973"),
Guid.Parse("73e929c2-fc17-4e2f-bda4-22d1cbf5392f"),
Guid.Parse("25bd512d-a68f-43fb-a4d3-ff06ea1c32c3"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Guid[3]
{
Guid.Parse("e7930602-3b77-4636-a5b6-dcef38f59f19"),
Guid.Parse("2f0af25e-8706-47e1-b9f4-98361ee1abfe"),
Guid.Parse("8807bc6d-9035-45aa-96fe-f4f4fa358b99"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Guid[3]
{
Guid.Parse("70ea2dcf-951b-4d9c-bfe6-4f336b19c503"),
Guid.Parse("3c9c3cc2-bb5e-47ee-831e-52b7acaf4f1c"),
Guid.Parse("1d91bd3d-16c4-4f70-b59c-0d04485f6e2d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5fdc4e56-f535-4ce4-b3ee-eaecb68d2864"),
Guid.Parse("23d77f02-f222-4f24-9b48-5074814e7a61"),
Guid.Parse("c8329a3e-b6ea-45b2-90b2-43408cb47dbb"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("df76ff79-d88b-49d7-9bba-1be3b109f754"),
Guid.Parse("82b7ef86-e232-440e-9eaa-89fd143ce84e"),
Guid.Parse("6bf27b5e-bf30-4add-b742-8f5ffb2397d7"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Guid[3]
{
Guid.Parse("5220b6c3-a6a5-4e7c-8f8c-cf8bbd96d629"),
Guid.Parse("1ffb1bf0-0aa4-45b7-8142-0bb18e22d8ae"),
Guid.Parse("9ecf4a0d-63c7-4d15-b4e7-1d89d9b4ad49"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("41def310-b073-44b0-82c3-ad202dec9829"),
Guid.Parse("21c8df70-184f-4c25-a92f-20f0a9d8ed34"),
Guid.Parse("96f5bf10-c7f3-4d2b-963f-80324a04e05c"),
Guid.Parse("f3d76674-5186-492e-9b77-f87ae507cd37"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Guid[4]
{
Guid.Parse("9f447b7a-599b-4161-ba54-a1b3baf2aa6f"),
Guid.Parse("f31cf956-0bef-4ce5-9e0d-745c4e3ffcef"),
Guid.Parse("57abb624-9291-4113-953d-29a0ffbe40ed"),
Guid.Parse("4c216bf5-6ba5-414b-9f2e-b92686902928"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("b9525b6c-3242-4870-992d-732ba3b66639"),
Guid.Parse("dcf2a401-a1ab-45b2-b914-a1ddfd4b822a"),
Guid.Parse("e72822f3-b926-49e1-a513-45f175342d76"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3665b1b2-e6cb-4c04-9aa4-f271e337ee24"),
Guid.Parse("3be6b166-91fa-4527-8d78-010caab7e330"),
Guid.Parse("22587ae5-07ff-4789-aa64-9704cb44d8da"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Guid[4]
{
Guid.Parse("4a788396-353d-44b6-aedc-8d52a8448f0e"),
Guid.Parse("7a28e385-ec14-4679-9ab2-b4065e77ed6b"),
Guid.Parse("2a18a3af-44fc-43e2-9711-550d442a24f0"),
Guid.Parse("a7bdf89d-e46f-42c2-a959-ca05365f95b0"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("abd66b12-ebee-4f7f-bb88-385f0acbca97"),
Guid.Parse("e9d9a7cd-f973-4961-8f56-d130473fb559"),
Guid.Parse("e6e0c59a-cd61-45f9-bc33-0cc3e9a9b860"),
Guid.Parse("e0ddff8f-4428-4459-8631-b4a429a40689"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("db37d9ec-cf52-4745-8eb7-10294f9459cb"),
Guid.Parse("5718c0b7-d13b-4810-bd1f-c475ea7ebaaa"),
Guid.Parse("3868b436-796d-4d46-89de-8ea5ba35a78f"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("a7d4e570-e394-43f4-8941-c40a26fb1bcc"),
Guid.Parse("33a2ab79-57f9-40cd-ad26-ce45471651eb"),
Guid.Parse("040e868d-6c3e-4b9f-b5eb-ac071673fe4a"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ae745d81-ed6c-4e19-a79a-0fffd8462606"),
Guid.Parse("d1d216a0-fe1e-4eb8-ba2f-9ef15e063e09"),
Guid.Parse("f8b947d1-85b1-47f0-86c4-9f8fdad28f68"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("498c07fd-55d4-492a-9f42-4606f8668355"),
Guid.Parse("6f463697-73a6-4632-9728-be5cb49f1ddd"),
Guid.Parse("9c58f1f3-26c6-48e3-92c5-1a65a3fe27e2"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Guid[4]
{
Guid.Parse("a3ce167c-3833-425d-af97-2e36ddf99277"),
Guid.Parse("5cf4bad7-cc7c-4188-b984-c0cdc322815b"),
Guid.Parse("05f7accb-bf11-476e-87bc-e5dabe5b0daf"),
Guid.Parse("3ba973cf-f1c0-4677-a051-1c1604193d62"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8446c7f9-9c5d-4f15-a351-8cd9e3df88b3"),
Guid.Parse("faf13bb3-cfbc-4436-9473-b1f313fa48bf"),
Guid.Parse("eedda2bb-ceac-49a3-9d75-789f01931e98"),
Guid.Parse("8379bce0-d733-49ca-b6ad-9a634c69037b"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Guid[4]
{
Guid.Parse("170edc45-355d-40f5-8928-8d4cdd435cb2"),
Guid.Parse("4ea443c1-b74d-4a00-997d-64a2abea99cc"),
Guid.Parse("a3697d67-e94d-4bfd-a3b4-5202df73d246"),
Guid.Parse("6ec27d04-349b-4474-a8eb-8b677fc49454"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Guid[4]
{
Guid.Parse("da8dd10b-95fe-407a-8887-b53ce5e1d75d"),
Guid.Parse("d318db64-5674-4b1b-b571-0ec25e8534dd"),
Guid.Parse("051fe194-8613-40cd-a092-5ce764af5410"),
Guid.Parse("cd14d982-059c-438d-bea4-6f1629de0e83"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("49fc92dc-3fea-4030-ab9a-244dfb30fb4d"),
Guid.Parse("1d223aa0-120f-42c4-9599-7e701e07ff9a"),
Guid.Parse("95445eb0-3cf1-4824-a492-9454b49c670b"),
Guid.Parse("dfdae682-9928-444c-9e42-506d1b55e8ca"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Guid[3]
{
Guid.Parse("e7665f6b-99fb-4a50-a77b-d33c641e4fa4"),
Guid.Parse("c236f5c1-210a-4970-b8e4-89930bda96cb"),
Guid.Parse("611faa66-5f88-4ff1-a482-5c605eba262e"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Guid[3]
{
Guid.Parse("0c513ea3-fed9-443b-8d4b-17fbfebe998e"),
Guid.Parse("798e8adc-4573-44e4-98ec-88b7a8d599b2"),
Guid.Parse("658897e9-640e-4d55-920a-ae37dd9841c1"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("adb02660-7905-4244-9b79-6099ff1716ee"),
Guid.Parse("f1754f95-d666-4fa3-a6b1-9d9e1cda0047"),
Guid.Parse("2319c5c1-2b61-4a64-aa31-179b99debde6"),
Guid.Parse("22fae087-fa08-4b0b-a61e-60017146fb5f"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("574468cf-8add-4b92-8a90-517cae8367e4"),
Guid.Parse("7723284e-a7ee-4865-acf2-a87d66ed79a5"),
Guid.Parse("5e45e31f-d55b-4a5f-92c9-81087ff99055"),
Guid.Parse("6af887b6-56c3-4e80-b0c5-b245fd4e2536"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Guid[4]
{
Guid.Parse("97932ded-3b09-494f-a852-5b6788b99f97"),
Guid.Parse("cf68d7b5-d551-4155-9efe-1de5a81d7188"),
Guid.Parse("a962cafe-2817-46da-ab6a-70f37ef5e0f3"),
Guid.Parse("0b726f73-1d5b-453e-8bb7-19503d590a18"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Guid[4]
{
Guid.Parse("beb5e533-5336-4d64-99af-85764a42c877"),
Guid.Parse("6f944938-332f-413c-8347-e965c2493907"),
Guid.Parse("359365a6-e2b0-45f0-8d38-ce8c6eaa7ae7"),
Guid.Parse("f3eaac28-0462-41e4-80ae-9d446d8c8792"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Guid[3]
{
Guid.Parse("86d963c9-4f53-4228-b3ba-50c9298880c7"),
Guid.Parse("7f5862f0-d3c9-4d2c-84ab-9f2ae0505440"),
Guid.Parse("6333ce05-b0ec-4d1f-804d-499187f6b805"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("dfc7f247-6085-4dfb-91d3-4b6b2b7139e0"),
Guid.Parse("2d88d4d1-95a5-47f5-b2e5-7f5081642278"),
Guid.Parse("858c499b-7223-42b8-aed8-693a6e359584"),
Guid.Parse("f77c835d-405e-4264-869b-67730dd98d40"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2af95fd9-67b5-4921-91e7-f0f3e2c18761"),
Guid.Parse("44adf652-15f5-464e-87eb-657df82f88a5"),
Guid.Parse("a30d5f25-13ac-4420-8c52-6c01f5d58fdf"),
Guid.Parse("b4e45447-8799-426a-ad98-1987fb905b3f"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Guid[3]
{
Guid.Parse("fcfb6b85-d5af-4273-a2ab-db1920d008fd"),
Guid.Parse("07ce44bc-0ba9-4f16-a449-8e543a0a225d"),
Guid.Parse("1714db47-bf7b-4ade-94da-10cef19b2244"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Guid[3]
{
Guid.Parse("7f2ade86-60e1-4e9a-aabd-9b420df19b18"),
Guid.Parse("9eca2682-3e6b-4661-9e2b-53ad2ac3e28a"),
Guid.Parse("4517f440-801b-41a9-bff9-ce08be8039ce"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.Guid[3]
{
Guid.Parse("f6750203-54a5-45ad-9772-cd9b5f14e454"),
Guid.Parse("74d2f996-f182-4345-85d4-802d780bdc5b"),
Guid.Parse("6de18bc9-4864-404d-8538-73e00e0ff7dc"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Guid[4]
{
Guid.Parse("eba5e79a-5e5e-48ad-bd1c-836da337a246"),
Guid.Parse("c5c56734-eda2-4da1-9a0e-b9f1148c2109"),
Guid.Parse("261cd291-ee30-4101-a5e0-05c6b1608550"),
Guid.Parse("69837eea-ce0d-4799-8dc8-8cfc9929791f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Guid[3]
{
Guid.Parse("5e4e85ea-2944-4301-ae5f-a37c83d0901c"),
Guid.Parse("7c3f341e-ebbe-49dc-9bf4-a0f9382e38e3"),
Guid.Parse("309bb004-b7fb-4769-95ec-5f956811cb58"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 101,
    Value = 
new System.Guid[4]
{
Guid.Parse("480579e4-f342-49a4-b0c1-b3e451a8a467"),
Guid.Parse("b7d8a296-bafe-4ba4-95b4-529de4106144"),
Guid.Parse("c53a9063-ba80-46ff-8082-1957fc9f0ec7"),
Guid.Parse("993add9e-cc33-4e98-9762-d451d25e12f4"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("e9a03d08-67db-4440-99ec-d6a2af74b9ab"),
Guid.Parse("9846494b-3d52-4259-8d50-48c30446d4aa"),
Guid.Parse("047c96cd-c433-4d45-bfbb-41c10f6c303f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("506f6d31-a8e0-49b7-be0b-13c546a469b5"),
Guid.Parse("373dc9e9-54fb-4ec7-b796-99b8eb10db53"),
Guid.Parse("c1c286aa-9eb7-49b7-924b-9984c1df4f40"),
Guid.Parse("1174c9ea-6c8f-4a7f-bc04-edf7be6250a9"),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
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

                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd1e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                System.Guid[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("9f499026-b871-49b3-94bf-acdd74388237"),
Guid.Parse("504bb38f-d672-4758-bd5c-4fd6ed29d243"),
Guid.Parse("e5fa4f88-bf83-4674-baa9-fcbdc3de541c"),
Guid.Parse("ae7fae89-d46d-4302-9104-0ae702ecca70"),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("24f59736-4313-4906-8ecc-78d6317aa471"),
Guid.Parse("5c1fb61d-abcd-41c0-b4a2-d8f9c821fb2e"),
Guid.Parse("defcd21d-2266-4a77-b899-f989a5ea45d8"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("558804e4-3fea-4979-a97c-6f8052d2b76f"),
Guid.Parse("7ef5a574-fd71-424e-8e42-c8995ab55ab7"),
Guid.Parse("931b033d-bb6d-45c9-af0e-9c696bb4eade"),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[]>();
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("99116925-22d6-4f35-ace8-0306248e4bee"),
Guid.Parse("05bd582e-44d3-469a-9025-6a32c213f3ab"),
Guid.Parse("9361140a-e3e3-42ab-8d43-2219f1124bfd"),
Guid.Parse("6ecd28b6-9a9a-42cc-aed4-cc4e81ee6e86"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd1e1mi_id", 
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
                System.Guid[] nullable = null;
                nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("527f82c4-66a2-4358-a272-fa4b044c3741"),
Guid.Parse("23458ebb-b769-49d9-b4cd-508514af89a4"),
Guid.Parse("9d27e126-723a-4fd6-8a23-5c489c38b6a4"),
Guid.Parse("af9717eb-d16d-4edc-81d4-c4c6ef0a51c1"),
}));
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD1E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD1E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 72, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 64, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 42, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 81, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 150, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 22, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 141, 131))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
FROM public.binary_guiduuidmmarrayd1e1m m
LEFT JOIN public.binary_guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI), typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models1 = new List<GuiduuidMMArrayD1E1MI>();
                var models2 = new List<GuiduuidMMArrayD1E1MI>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MI>();
                var models2 = new List<GuiduuidMMArrayD1E1MI>();
                ((IGuidMArrayuuidMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

