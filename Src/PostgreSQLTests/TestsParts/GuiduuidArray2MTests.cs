

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
    internal partial interface IGuidListuuidArray
    {
    }
    
    internal partial class GuidListuuidArray : IGuidListuuidArray
    {


#region TestData

        private readonly GuiduuidArray2M[] _testData = new GuiduuidArray2M[]
        {
            new GuiduuidArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("213790b3-73fe-4a14-8e5d-0823ee9edb6d"),

Guid.Parse("b81c7047-83ab-42ec-963b-62f401a805fe"),

Guid.Parse("7f5383b4-c6a0-463e-aed4-e0ea106acb86"),

Guid.Parse("4c401f3e-dee5-4742-9a5e-9b6226a7af62"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("499385f6-fbe2-4bcc-a17d-e758464df879"),

Guid.Parse("3020fe17-edee-4b01-a276-ca10b0801415"),

Guid.Parse("586579bb-813a-4a18-86fc-077cbf5a31f8"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("613dabdb-3e3c-46e6-a883-40f801cac1e8"),

Guid.Parse("00d81202-e528-48dd-93ae-b980fca4e798"),

Guid.Parse("0265bc60-fda3-4121-993f-cd99f1876195"),

Guid.Parse("c815be25-0ea1-481b-8f5b-71334badcb4f"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3092a186-4038-4b83-bbf4-7ba7420e4374"),

Guid.Parse("5de9016c-08d7-4a22-a97c-3447b6b924ca"),

Guid.Parse("a5d41130-c530-4e85-964f-0a17e52dc629"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d22edbcc-5d4a-4464-a3dd-91b2e23b1d44"),

Guid.Parse("656a6320-f567-4b52-a413-8bac3ed63136"),

Guid.Parse("4e74bb6e-01cd-4a81-afdf-677c45644cc0"),

Guid.Parse("d54ad32b-4a8e-486a-8daf-b69b79175ee2"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c248aefe-d523-4b40-8649-0ba2b79545dc"),

Guid.Parse("29e1c248-9124-4d30-a4cb-1aeffe3e9adc"),

Guid.Parse("7c7ba8c9-853c-444a-b9cb-b26dd0bd3b98"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c1f96084-00f3-437d-bc58-d27132910f58"),

Guid.Parse("0e95303e-4a55-457b-a2bb-d1f1f18abfef"),

Guid.Parse("958a5a26-7923-413e-8afd-83f57e375be2"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8c77775a-b4dd-4c49-9166-22a5e344de92"),

Guid.Parse("f85028d5-3730-45ec-8248-01f6bb13fe29"),

Guid.Parse("a3ad2f3e-6f58-4e4e-9e66-f66295abc369"),

Guid.Parse("d79a0611-c460-4356-8a26-c93f57d1150f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("67e035a4-766b-4f7b-82c9-308f0123fdfe"),

Guid.Parse("479f672a-db24-407a-8047-b0b078251c76"),

Guid.Parse("22bf684b-821b-4c30-8a76-c046198731a9"),

},
},
            new GuiduuidArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3c371a1e-ef91-4440-9249-6f9748e3f32e"),

Guid.Parse("e000fc64-d51b-4d90-a4a7-7114a8c9ebcd"),

Guid.Parse("659a4572-3e71-4526-9cc0-ad2791b2d6fa"),

Guid.Parse("50069026-4dfd-4f8a-9b7f-5fd6bb0cfa58"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("83495587-9404-4480-a968-5615972a3212"),

Guid.Parse("49cfb205-5c66-493a-822f-625d486e921c"),

Guid.Parse("0fa225a4-e747-4c61-91b0-af082f8eb18f"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0e79c37e-2bcd-419d-9ab0-7b53baf42d55"),

Guid.Parse("d509357e-2d9f-4b2a-85d0-424b83a44ebe"),

Guid.Parse("8a10ba7a-8cea-4650-9f19-827baf6196c4"),

Guid.Parse("bd47bfc0-8542-4825-abb8-0ea22ae8452a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c1cbd54f-516e-458c-be5d-cfa1443ff9df"),

Guid.Parse("690f0413-09b6-4534-9ad9-b41b7c74ee44"),

Guid.Parse("872057d1-3134-46f8-a921-8ac7c9206aa5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b8a8d81d-e0ca-491c-b619-26ecc1847e1c"),

Guid.Parse("7a8b73b0-73cf-4df6-b880-8bd16b97a6ed"),

Guid.Parse("d9dca7ff-8dbc-4ce9-af13-0c1c588a5f86"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("875f2928-b41e-4abe-addc-28172ca89bb0"),

Guid.Parse("cfef8a0c-99f9-4197-a3c9-406f792979ba"),

Guid.Parse("86672c4b-6efc-4790-a8fb-7a9ed8330108"),

},
},
            new GuiduuidArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9cd52d75-fd21-4ce5-802e-19ae4634807f"),

Guid.Parse("e42b2ff7-e9e4-4692-87e4-5c1b18e82e6c"),

Guid.Parse("bd0f502a-5ad0-4bdb-85c2-27a6eb123a19"),

Guid.Parse("b6bb6b57-659f-4346-9f7f-f55cbb416c8a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("360e9fc9-c4dc-4065-9ecb-0753a242d621"),

Guid.Parse("42083aaf-532e-4828-be9a-32a3ef20260b"),

Guid.Parse("cf665a05-6dc8-4483-a0a4-0fa40579a575"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c63e4ed5-9169-4a7d-808a-d0a7b930c60c"),

Guid.Parse("db76b24b-7e0a-45b5-90d3-f386c9f85002"),

Guid.Parse("e4f77764-18ae-4d24-bd7e-a91582830d58"),

Guid.Parse("4ffbf318-5fbe-4016-bc40-29a913da806b"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6066beff-d0cb-4202-a890-38f97fece099"),

Guid.Parse("7a1bf8e1-bbef-4010-a306-72cd75dfe526"),

Guid.Parse("bd0845a5-9756-4c66-b27c-3d0625971d7d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("78c12e47-3262-4567-af4f-1f6960992b75"),

Guid.Parse("f76d0e35-86d5-41d4-a1fd-b7bbe62ca8cf"),

Guid.Parse("fc0e526f-745d-4608-b7b7-a0b1635ece01"),

Guid.Parse("51028214-8616-4426-91c2-c082fd5bfe50"),

},
},
            new GuiduuidArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5fd164a3-1365-46dc-acdf-b33d4d83d82f"),

Guid.Parse("2b79b407-9d00-4641-b730-c6e5fffc58ef"),

Guid.Parse("d20fddee-2837-433a-bfc3-c2756dc186cf"),

Guid.Parse("730efd6f-01ad-4d4f-b26c-f421df7a7827"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9f083841-1e02-492b-9cac-e59c61d16f21"),

Guid.Parse("51d2c51d-3549-4586-8ac9-6282e8eb995f"),

Guid.Parse("82f914eb-d9d2-477e-b636-06e155f45c95"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("79315b53-852d-4aad-a3e4-718093b3cc2b"),

Guid.Parse("8791e215-8a67-44f1-9b34-e6cb9ac7a73f"),

Guid.Parse("ec673b5a-7065-4da7-848e-bcfb0b00c98d"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b566f159-497f-442e-aeba-3767f6bced0b"),

Guid.Parse("a1a8c7ed-1cd9-4bd2-8d11-0dea529e97f6"),

Guid.Parse("cb0f8cf0-affc-48cd-a354-100ae0bd624d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c271befc-5905-47fa-aefa-f2d24e726d5d"),

Guid.Parse("b87a221e-08fb-46d7-bc49-9d3fd7fa922c"),

Guid.Parse("49b8d703-6277-4f31-8a94-b03f8f9444a2"),

},
},
            new GuiduuidArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3cec69a1-848f-4c27-9d95-4f8815a6dd98"),

Guid.Parse("1d2a7f7c-e193-4a3a-9088-494b487215f9"),

Guid.Parse("3b25a780-a97d-4317-8d2d-600be0e5b7b9"),

Guid.Parse("1759b839-5428-43d7-9f99-4544c9a4081a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a9a2988f-95e6-4814-848b-53fb52010690"),

Guid.Parse("aa5e5d91-8c3d-4160-b6d8-74797cdf7e22"),

Guid.Parse("ced8e231-232b-4715-9849-2ab8127c8c24"),

Guid.Parse("209a70a9-7450-4fe1-beba-b7c4567a5b5b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("de3e815c-578f-4ef5-ace0-6542b8044b34"),

Guid.Parse("d79e2c2d-fd1c-4733-a8c5-f8f47152833a"),

Guid.Parse("7715174d-f17b-4ffd-8cca-b120fdf00be7"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("71f0b615-74a5-48dd-975c-955ff68c4f9d"),

Guid.Parse("b8ca0db6-8ce9-459d-a191-c3127bffbf58"),

Guid.Parse("815d24b8-2d0c-4167-9d23-8521828cb9de"),

Guid.Parse("a0ff2bb4-61ae-4f5c-8a9d-874af23371d4"),

},
},
            new GuiduuidArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4a79972d-c419-4780-a88a-861cc6426582"),

Guid.Parse("daa48ce4-2d58-4878-beab-d99621ef06a4"),

Guid.Parse("e19eca6e-1a63-41fe-9996-aa968276e15a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7f79a98d-5410-4884-82e2-48b38c03eea1"),

Guid.Parse("7840c622-17bd-4cc4-a0b0-94c70417412f"),

Guid.Parse("ad1e6043-45bf-4c5b-a607-6ce3f04f453c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("515b83ab-6495-4de9-b399-e8744e3746d1"),

Guid.Parse("3d9f1de6-518b-42e1-8b79-1adff5802cac"),

Guid.Parse("fb07d4e0-9988-4131-ac12-1594752b9f6b"),

Guid.Parse("573ec49a-d153-4817-be77-e9e855e662b3"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("496dd045-1282-417b-9c97-ddc1bb94449e"),

Guid.Parse("50e5228e-4b66-4ab6-b8c2-4f7fdd638553"),

Guid.Parse("2e559081-4f3e-43b1-b109-1533f2b0755e"),

Guid.Parse("b2fd0810-7b98-4ee3-8723-a5a65fd9be4d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("70ad9ba4-fd6f-40e9-bbac-30e21f4806af"),

Guid.Parse("1943956d-2742-4fa2-ab9e-8c737c301943"),

Guid.Parse("6d73b73b-5704-4b6d-9cdb-d443a0aa8f90"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("131c58cf-0579-49e1-89ab-a926e62f7277"),

Guid.Parse("bd5f9e84-d18f-40ad-b70f-edfd268bd2b1"),

Guid.Parse("aac91f8d-6905-4952-85fe-f77a914cd9a0"),

Guid.Parse("358d0e1c-17f1-4042-9cf3-3998b7598f15"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d0c96246-91c6-4366-bfc2-a4cfcdabc33b"),

Guid.Parse("03168043-acbc-4adc-881b-04ae2ff5cece"),

Guid.Parse("f0551c69-2760-427c-af51-9447ecd083e2"),

Guid.Parse("6c31e4b9-02aa-4eab-82f9-140059b9ac3c"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("78215d37-08cc-460c-9220-1916ea255ce7"),

Guid.Parse("cec111ef-9cb6-453f-81bd-a42eefd09b62"),

Guid.Parse("4b67794a-3eb4-4f16-98ce-9c5fbae9a584"),

Guid.Parse("7324bc87-cdff-4e9a-b19e-dc5f878e1b74"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4e23dff6-fa17-4ccf-a59d-c35a3628340d"),

Guid.Parse("21ac3f7d-ecb2-4203-81c7-11002e167849"),

Guid.Parse("94a0beae-b15d-401c-8ba4-93ef8b86a586"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("baef5675-15fa-4f7d-8a34-e515ffd772b1"),

Guid.Parse("042465f9-af76-4c56-9bb8-fedae6e95d95"),

Guid.Parse("c6d48b17-958b-4611-91fc-44ac5a65feae"),

},
},
            new GuiduuidArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0e07ece7-7c8e-4081-8989-59b7bc05b528"),

Guid.Parse("cd0eb146-0e23-47e1-a6d6-3b34214e0fc9"),

Guid.Parse("768b50d1-0c66-4292-8ef7-7efa312fbbf0"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("89a5620c-7e7f-47f3-a118-bc75affdfd5d"),

Guid.Parse("108bf28c-95ad-4dd2-a994-cbf50e04bf4d"),

Guid.Parse("c6793eb6-f4e6-4f64-b84f-47b82ea855eb"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8675c53e-f801-4fdd-8603-9596d8b43462"),

Guid.Parse("f13bf408-4673-41ab-85bf-00518328c9b7"),

Guid.Parse("9a6a2e09-ec10-464d-97b7-7f300634cf0e"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("34579924-fd24-4f72-92b5-ed11cd9c8e16"),

Guid.Parse("fae1d151-7a64-4276-ae88-4e2f32545067"),

Guid.Parse("76c865f3-e941-48f1-aff5-d49f67e974ce"),

Guid.Parse("fa0f741c-c68a-4cda-9668-34efb10cc038"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("32b13376-7c3c-4ca6-a384-2ad398bef02a"),

Guid.Parse("0d839b8c-efe4-45c8-ba9f-d84dfb25dcbf"),

Guid.Parse("f8ce1037-0fef-4ed5-b4f7-625f3e2964b8"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5a2dc49a-e025-4cf3-815c-39ed40d0052d"),

Guid.Parse("c4c32fcd-2b89-4720-8ce8-6f150ab3068e"),

Guid.Parse("97c493ff-59a0-483f-8e30-dd50cbaf61af"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("79ee2793-c7df-4b30-95ff-5bfca9e4cfdf"),

Guid.Parse("a5234996-8a8f-43b2-b23b-77764b8ace48"),

Guid.Parse("6a124151-319b-4606-a518-49811303edf2"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("af6bec82-e20a-4332-9419-eeea68c8add0"),

Guid.Parse("85c68229-0346-4db4-90fb-eddda7c8dee4"),

Guid.Parse("f6baf2e7-057a-42bb-87a9-cd58c9d05c44"),

Guid.Parse("0d933ad0-8f56-4173-b607-340fe1f0fc59"),

},
},
            new GuiduuidArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("603529ef-e2cb-43b3-8596-198e2bfa11c8"),

Guid.Parse("fda4978a-f276-4c7b-880f-6bc10805c569"),

Guid.Parse("dba6be6a-37a0-49c1-8bb3-d4ade97294f3"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2442071a-d80d-4a83-9294-660df6f3be62"),

Guid.Parse("b483c2d4-d8e6-4b9f-b08d-a4afaacd035f"),

Guid.Parse("95569a58-3f34-4065-93cc-35e9c43e7de3"),

Guid.Parse("5e66f70f-a707-4ff2-8a32-46694244319e"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fd3a0d29-03f0-47c3-b661-0d7b91b02951"),

Guid.Parse("8704a2ef-13d4-4d70-b704-333f46a17506"),

Guid.Parse("e41230ef-10e9-4008-ab75-b62ec64a7f0b"),

Guid.Parse("6bb339b1-8be5-4c30-9810-f2cf989cefff"),

},
},
            new GuiduuidArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e3459dd9-c5c0-4d6b-aed0-0e8f7d7e35a2"),

Guid.Parse("e7396311-0a3c-41af-b73c-fbbd398fed2f"),

Guid.Parse("c2db4822-d909-4f60-a3bd-e2c73ef0a0bb"),

Guid.Parse("1fed06a8-aaad-4c79-acfb-410c19933ad2"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9dddd51f-6e80-4105-be14-80fe65507bac"),

Guid.Parse("d1a1ed6e-651a-4703-8c48-2199caaa1974"),

Guid.Parse("f3686f89-0771-4b85-bc94-c08bc6586bb3"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("041b85c8-ad22-4ab3-bddf-0d5eee80a1c7"),

Guid.Parse("bdee5bc8-c214-4e5f-aa41-309b87992ca5"),

Guid.Parse("80925c7a-d464-475f-ab1b-624eeed9755d"),

Guid.Parse("a2638f7e-96e3-4874-ad9a-a08ff944a775"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b82d48f5-7c34-4eb8-9c82-8f1c2709b4f3"),

Guid.Parse("e9c9cce5-d8b5-4a92-865d-4e1f43b9eeed"),

Guid.Parse("c573e74d-2360-4c21-88c0-a1e01f3b31e8"),

},
},
            new GuiduuidArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d61d64b4-52b9-441d-bafb-a108ddfa73a3"),

Guid.Parse("18208aac-0b1b-487a-9c86-7a405bad5e58"),

Guid.Parse("7eefc626-76df-4be7-87a2-7d3e2c41b877"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("22c4d0c3-cee6-4bf8-b12c-479e35323cbe"),

Guid.Parse("1ae92793-1fab-4ba5-b299-f6a0fa7319c8"),

Guid.Parse("ca04ad98-a509-4bfe-9bdb-31d9c5e8fc8a"),

Guid.Parse("c35be6c3-0fc7-4fe3-9036-28283bd690de"),

},
},
            new GuiduuidArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0ce9fa40-32f3-481d-9aed-f95db8ac18d9"),

Guid.Parse("97bd7bdc-eafd-43da-845a-79063af9b39f"),

Guid.Parse("a814c8c2-25d4-4e93-be71-fd8dc61c87db"),

Guid.Parse("25146509-3c83-43be-9880-e04269487ae5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aa1d461-0f19-4393-8988-1839ecd72041"),

Guid.Parse("692cf400-9900-4280-b0de-a479f7152fa2"),

Guid.Parse("67a39eb3-e551-4572-9bb7-d5dfc44d8cf1"),

Guid.Parse("be6a90fe-6e01-4d12-8f14-4f6dc7156eb2"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4c188a92-4217-44fd-83ef-f69cf2dede37"),

Guid.Parse("4e4f68cd-4de2-461e-a179-c9995478536c"),

Guid.Parse("2fcaeeb3-6ea1-4769-9f88-0e69839b292e"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ffb44990-a7e9-456f-81c5-525d2d144148"),

Guid.Parse("aec6d295-8efa-42f1-ae10-cfaae16476f5"),

Guid.Parse("1898cbd4-fb6b-4621-9562-0e7902bd77da"),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2mi(
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
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2mi(
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
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
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

                changedRows =  ((IGuidListuuidArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidListuuidArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidListuuidArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidListuuidArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidListuuidArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidListuuidArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
            asPartInterface: typeof(IGuidListuuidArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidarray2mi_id", 
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
                changedRows =  ((IGuidListuuidArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidListuuidArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidListuuidArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidListuuidArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidarray2mi_id", 
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
                List<GuiduuidArray2M> models = null;

                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray2M> models = null;

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidListuuidArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidListuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidListuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidListuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidArray2M.AssertModel(models[0],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidArray2M.AssertModel(models[0],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[29], false);
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
                var models = ((IGuidListuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidArray2M.AssertModel(models[0],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidArray2M.AssertModel(models[0],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 38, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 143, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[29], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 97, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 10, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[29], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 102, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 143, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[29], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 44, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 111, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidArray2M.AssertModel(models[0],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidArray2M.AssertModel(models[0],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[29], false);
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
                var models = ((IGuidListuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 68, 44))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidArray2M.AssertModel(models[0],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidArray2M.AssertModel(models[0],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[29], false);
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
                await using var cmd = await ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
GuiduuidArray2M.AssertModel(models[0],_testData[23], false);GuiduuidArray2M.AssertModel(models[1],_testData[24], false);GuiduuidArray2M.AssertModel(models[2],_testData[25], false);GuiduuidArray2M.AssertModel(models[3],_testData[26], false);GuiduuidArray2M.AssertModel(models[4],_testData[27], false);GuiduuidArray2M.AssertModel(models[5],_testData[28], false);GuiduuidArray2M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
GuiduuidArray2M.AssertModel(models[0],_testData[17], false);GuiduuidArray2M.AssertModel(models[1],_testData[18], false);GuiduuidArray2M.AssertModel(models[2],_testData[19], false);GuiduuidArray2M.AssertModel(models[3],_testData[20], false);GuiduuidArray2M.AssertModel(models[4],_testData[21], false);GuiduuidArray2M.AssertModel(models[5],_testData[22], false);GuiduuidArray2M.AssertModel(models[6],_testData[23], false);GuiduuidArray2M.AssertModel(models[7],_testData[24], false);GuiduuidArray2M.AssertModel(models[8],_testData[25], false);GuiduuidArray2M.AssertModel(models[9],_testData[26], false);GuiduuidArray2M.AssertModel(models[10],_testData[27], false);GuiduuidArray2M.AssertModel(models[11],_testData[28], false);GuiduuidArray2M.AssertModel(models[12],_testData[29], false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidArray2MI),
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidListuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
                await ((IGuidListuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray2MI),
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidArray2M),
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
            asPartInterface: typeof(IGuidListuuidArray))]
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
FROM public.binary_guiduuidarray2m m
LEFT JOIN public.binary_guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray2M>(15);

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
                ((IGuidListuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                GuiduuidArray2M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IGuidListuuidArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidListuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                GuiduuidArray2M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[14], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[20],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[21],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[22],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[23],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[24],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[25],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[26],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[27],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[28],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidListuuidArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidListuuidArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

