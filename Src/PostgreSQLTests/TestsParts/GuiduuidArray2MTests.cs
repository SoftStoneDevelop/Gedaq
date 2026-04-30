

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dcc80040-6c3b-4f95-99c8-a88810e5240d"),

Guid.Parse("8a8a1d25-4c27-4a7b-a464-5506543265de"),

Guid.Parse("8c433fb6-4bbd-4610-8632-aece5b946e46"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8a745a42-8497-4564-8a3f-eccf2447fea3"),

Guid.Parse("caae3c4f-d64e-437e-8960-859a9f6a593a"),

Guid.Parse("aa2b7b00-6237-4198-8af7-127a6cbec98e"),

Guid.Parse("a0a1e565-54a1-4eee-9d39-b0f1b3772221"),

},
},
            new GuiduuidArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cca99fbc-821a-4276-9339-75336d19f1dd"),

Guid.Parse("1579ec80-f60b-48c2-b99f-f5edcd6d2e5b"),

Guid.Parse("32d3a443-a558-4a2a-bc70-6de40cc13c34"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0f0ced85-d94f-44a3-97f7-b5b0ad077d13"),

Guid.Parse("465192e9-1710-47c4-8dcd-92ad42be86c4"),

Guid.Parse("cb663f3d-52bc-4952-b982-52c8472523e5"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7049ac60-4ac8-43d6-9c24-cebbf4c072f0"),

Guid.Parse("8b7e1053-d2ea-4b69-9116-579deb806338"),

Guid.Parse("4e13bf80-9db4-4ce6-97e8-bdc86430b0a1"),

Guid.Parse("15a0b40d-9ab3-4806-94eb-c0df84ea5c80"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e651cc31-85c4-4130-8bb2-deef1feb559d"),

Guid.Parse("a738087e-7b28-4dd2-9e90-2b703704a345"),

Guid.Parse("18d81f26-a9b5-42a2-90e5-c45b14d8d4dd"),

Guid.Parse("e3f500ca-cd47-491b-bc85-60ab3a9910b8"),

},
},
            new GuiduuidArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e0550893-f832-4547-9037-8536223094f8"),

Guid.Parse("1a375237-de62-4422-8344-177a8b6ad4a6"),

Guid.Parse("ce609937-9e93-475d-af31-e46c3a47de7e"),

Guid.Parse("317bfb96-1146-445b-aa55-60accc5f8c22"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1d6ec71a-2309-4165-beaa-856a49608ebc"),

Guid.Parse("40fc97e3-77fc-44cd-b297-d929f8ca31c7"),

Guid.Parse("25dde97f-d5b9-4679-aa3e-1b18b069dc8e"),

Guid.Parse("cd67e74d-333b-4671-8aea-df6ee543557f"),

},
},
            new GuiduuidArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("79640fe7-99bb-4b08-89c6-4253e18bf49d"),

Guid.Parse("2eca5e80-fd87-4901-8b88-fdb932298f1f"),

Guid.Parse("fffba6df-738f-4c64-8f1b-e9efacdafe58"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6fd227c4-5f2f-4de9-a75d-6a196ff828f1"),

Guid.Parse("15ccc6af-78f1-45fa-a839-71fb5d30ba50"),

Guid.Parse("0d1b7273-847c-473e-bf79-83829fc8fe71"),

Guid.Parse("996cf845-bf3b-4197-b720-80354a4975ab"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c15067e8-8f40-43ef-84ab-ebaa886972d5"),

Guid.Parse("71b810b2-9444-4251-a2eb-7aa6385e378d"),

Guid.Parse("0d307cf6-1411-4320-a974-fd7fadee49c8"),

Guid.Parse("ed318160-efc6-483e-b654-27c080f2717c"),

},
},
            new GuiduuidArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8d0ab376-9812-4209-89b2-ab924565c107"),

Guid.Parse("19d17e24-11cf-45cc-ad92-56a770ca80b9"),

Guid.Parse("50341de2-de4d-465e-89a6-0719ed094bff"),

Guid.Parse("81eae80d-371b-4b82-b14f-6b950157a7f4"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("19aba5c3-45dc-492f-81ea-726cf26b04bd"),

Guid.Parse("c5d6f742-9961-42fa-a2fc-eebc2e1356c7"),

Guid.Parse("8b113e92-fff1-4493-80a6-883406b3b800"),

Guid.Parse("9f7fd067-981f-4397-b494-9405781f29ae"),

},
},
            new GuiduuidArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1e56e5d6-58dd-41f9-96c1-4c0c2328b66e"),

Guid.Parse("e0052f10-9e30-4325-85c7-c3aad30e1a4f"),

Guid.Parse("a6e69135-80a1-4b26-a25e-d98bc308844d"),

Guid.Parse("c5f23e75-d271-4d8c-ba41-2da7c1104335"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("19844b2b-6ae6-4e6a-b14c-ffb99070d25c"),

Guid.Parse("a5a46925-1c82-4597-b822-acfab74d9252"),

Guid.Parse("c4dd5946-af3d-4168-9536-06a7bc30a18c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a1c3f25f-7367-47f3-879c-8982500bf21e"),

Guid.Parse("da99307b-d50d-4eb2-b5f7-b2c1dd4e7d83"),

Guid.Parse("d0c1b31c-1ef3-4260-8b15-a0a66fbcead2"),

Guid.Parse("8c941d77-8b23-4f34-9e8a-86ae3a927f33"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("994a3e7c-d71a-44c3-a6e6-b464a251aa0a"),

Guid.Parse("55c2b9e4-a6bd-4645-90a7-0f4a328afcd2"),

Guid.Parse("ab0b3336-cdd8-4c79-8553-a4f77e279b4d"),

Guid.Parse("1b093126-719d-4194-926a-edebe10a8d5e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ee148a6f-8f81-4d3e-8cfc-26cfece9ec40"),

Guid.Parse("44960180-91c3-4022-8006-f3c4e3f13153"),

Guid.Parse("cbf056d1-1fd5-43b4-b104-88fc59c0f2d9"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e7aae58c-760a-44f1-8a75-3547d040870b"),

Guid.Parse("51b8d3cb-a5a5-4f9e-afba-c87718dde291"),

Guid.Parse("2bfa560f-13ed-4827-bbc0-0c7bd9e9c949"),

Guid.Parse("5e38a032-b847-4d0c-bfe1-4a3f64cc012d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64d6a752-ed27-4ef9-ba6d-b60606dadd9b"),

Guid.Parse("d6fa4c0d-fac9-4ea1-b648-d3aaabffd689"),

Guid.Parse("aa5d5001-f13d-4b80-b3da-a1f8df8541ea"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ac26c486-cafb-4c62-b40f-a963f513344a"),

Guid.Parse("f693ae29-9c68-49f4-bcd6-bd6acbb90739"),

Guid.Parse("cba0001c-5315-4e28-a190-f9da914e24d5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7fae11c6-c95f-46f8-85db-79e4b4c43193"),

Guid.Parse("b7beaa91-9268-4645-a288-7ff00182ef7d"),

Guid.Parse("a251135e-967f-44bc-9e26-95b53b701c33"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a6c6ccd-dbaf-490e-97c2-207d746ebbae"),

Guid.Parse("f8da34ae-6685-4478-ba6d-f6a5403d6c0d"),

Guid.Parse("c0341eff-0353-41ae-8602-810bf5ec7c50"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("73ee870d-e6f4-4c42-a615-fde8effaed8e"),

Guid.Parse("b148b6b9-05a5-4304-9324-2a3bc8f61f1b"),

Guid.Parse("e23b32e9-5593-419e-813a-3ee305ccaf4a"),

Guid.Parse("b81948ed-8b02-460c-bece-bd147c380e74"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0c16fec1-27ab-4f2d-892e-bc5c12dca89d"),

Guid.Parse("265ed1d8-2caf-4c25-8c94-3c60225999a4"),

Guid.Parse("3aa27405-3942-430a-9bc9-0eed0f658483"),

},
},
            new GuiduuidArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7e570587-8317-4253-84fc-065a5b2cb7aa"),

Guid.Parse("d14afbca-ef70-456a-bbae-efe08b5e436c"),

Guid.Parse("824a3218-9c12-4333-91ac-a6f73cc22c74"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ebd8566c-1770-493e-8b8e-3ab5d53e9158"),

Guid.Parse("b617c1f5-1afb-46cc-8156-d6bc41fd4209"),

Guid.Parse("ff83d68e-68b7-47ca-b084-27628925b241"),

Guid.Parse("a2c0506f-16c9-478a-9a0c-9db021f237c5"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8287ba92-4e7e-4b74-8c90-8d3e6a7ad76f"),

Guid.Parse("11a747e4-3a29-4824-95b2-a09ddd63e643"),

Guid.Parse("f2d376fc-d4e7-4a20-8a3a-e659807da3a2"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3dcc1837-59a7-4017-a637-b8d8a223323d"),

Guid.Parse("5ec18f41-9120-4259-b544-676007be4808"),

Guid.Parse("062ada17-00e3-4365-9f49-04cfe5f9e4ec"),

},
},
            new GuiduuidArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("078d2726-4956-4636-af29-57ba44877021"),

Guid.Parse("1d6054dc-df11-4cfd-b362-7e8a90b86c22"),

Guid.Parse("62452ffb-64aa-450f-a89d-11dc181a7e61"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("02046853-9d91-46bf-a134-ea91dc53cb39"),

Guid.Parse("a76a1823-b564-4c99-af60-cc3b4dc6ba87"),

Guid.Parse("a69dc417-6fa3-4376-a2ed-531c337eca88"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f11d17a2-c411-471e-b263-9d54cf8e4ff5"),

Guid.Parse("c98c5d9e-7bb2-4c75-a44b-62f707e28dac"),

Guid.Parse("9eb48569-d075-4a71-99f2-ff7a289c81a7"),

Guid.Parse("d1232ee7-27f9-4537-8520-0986b9e519de"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7b6d10d5-b81c-4318-9f0b-fd7b26e7edd1"),

Guid.Parse("893d9312-03f6-4216-a536-c6cfdebaa863"),

Guid.Parse("a9de5312-b160-4bfa-81be-dd6932282d18"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9a50ba7c-e765-4c38-9fc3-037efa637b64"),

Guid.Parse("2fb858cd-7845-4625-a5e0-afc8a7727ffb"),

Guid.Parse("769f90fa-bb3f-4b55-89b9-0ac499e06e20"),

Guid.Parse("23757532-3e97-4bfe-8c27-f665bd37bd78"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9b53034c-45ba-440c-9106-11d2a646b185"),

Guid.Parse("b46afe2f-4ca6-47e5-a1bd-513ccb2643c5"),

Guid.Parse("ff7a5f2e-4f25-4df7-a36a-49fca8defee1"),

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
Guid.Parse("9e0a5e09-e603-4f44-a38e-3bd600c477ed"),

Guid.Parse("b4e9958b-50fd-42e8-a14c-0579e02255c0"),

Guid.Parse("3e9ab46c-c0ba-4f02-a52f-faac4b181f43"),

Guid.Parse("3751d188-9caf-4d34-b10a-7eb4c13c7137"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c794c95e-3ff2-49d2-ba17-ff00adce2b77"),

Guid.Parse("4021f4d2-d48c-4c7b-871d-003b898722a0"),

Guid.Parse("0ffc0b40-5b7c-4056-859d-b5baca264492"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b198b4bf-e0eb-4408-9643-f6e76da36ed8"),

Guid.Parse("87a46461-5a2c-48ad-aa33-5273e66db1f3"),

Guid.Parse("47c8ba93-341a-4265-9ffe-1054a3253517"),

Guid.Parse("d4c73cea-04b3-4df0-9be1-82dfd8cb9e1e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("db97ded2-c1c6-4ccc-a6c1-138082e8871c"),

Guid.Parse("e8a56c0c-785e-415c-986f-04d5597a11da"),

Guid.Parse("f93ad5fc-7698-4cd0-8092-856cc8c18c28"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("02eebdac-1f24-41db-b1b1-6dce13cd5178"),

Guid.Parse("83902b62-d439-4b69-b499-38fcbb00e1d0"),

Guid.Parse("60d3ee44-a0a2-4929-82f7-1327991d8e2a"),

},
},
            new GuiduuidArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e7e1c716-eefc-458f-b22f-2eeb684184ac"),

Guid.Parse("1668d5e3-f5b9-493f-acf3-430f38e65cc4"),

Guid.Parse("215e7af3-9445-4517-b5a5-e0c5ec8087cf"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("702a6576-13f9-44ed-98dd-86584e5bc4cb"),

Guid.Parse("a07cb417-01a9-4553-b785-691cdc512c38"),

Guid.Parse("ed86c50c-8885-4edb-b277-daea0b257560"),

Guid.Parse("cdab69c9-a798-4bb9-b77e-f98462dd6d5a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d2251c63-254d-411a-ac12-97dfd503a2d2"),

Guid.Parse("829ee186-6c5f-452d-8139-6146a5e9878f"),

Guid.Parse("1b8e29ff-af94-407e-82f7-9d5239e95550"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("861a248f-f48c-481d-b954-7669dc530615"),

Guid.Parse("0d663241-f701-4029-b099-fcbcac4ac711"),

Guid.Parse("82b5549c-44cd-4591-8026-e65f641ed222"),

Guid.Parse("a674e4f3-21cd-4335-b2fc-6e96a54fb5e1"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c9f339dd-b83b-4905-ba26-ab9090b6f667"),

Guid.Parse("40eda7cf-a525-4cef-9c4c-7e785d114cb2"),

Guid.Parse("49e89da8-5c58-4c7f-824e-d763075eb76e"),

},
},
            new GuiduuidArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("85bece1a-1ca5-4f48-9290-80f0e9382ecb"),

Guid.Parse("e222414d-6cd6-4fe7-b0f6-94f8475b8931"),

Guid.Parse("a72c3713-0398-4349-b111-99381bc1bc5e"),

Guid.Parse("514d89b8-a3f9-44f3-9efa-5ebec367c2a9"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bed2b963-843a-4d08-90c2-8d5b1724062a"),

Guid.Parse("4d38f11c-e122-42cb-85c7-91fce5fafe34"),

Guid.Parse("ca70550e-9656-4b59-a428-7dd1f672636f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72c6f21f-4d92-4505-b8b7-96bd6cd77c9e"),

Guid.Parse("2c488167-c39a-48c8-bcb3-34403c068bfc"),

Guid.Parse("834d9532-536d-4055-a0d9-c95bd7abfa18"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("86be2183-dd0d-4e1f-b941-ab4b05ba9ce0"),

Guid.Parse("c62ebe69-801a-4d63-8b95-1701230f22dd"),

Guid.Parse("ab82155a-41f5-43c3-8e9c-0c7538c930f0"),

Guid.Parse("368e1157-54a5-43d1-801d-5d198fdc8afc"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7e7f47e9-1d39-4068-9d0a-65f89b5db88a"),

Guid.Parse("78e11c85-d111-4348-abee-bbd1e6610bcc"),

Guid.Parse("3e4e49bd-72c6-49ca-8723-44b5c637afca"),

Guid.Parse("ed49a74d-e08e-4d16-b0a0-1075a084ce4b"),

},
},
            new GuiduuidArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e941469c-54a3-4b36-82da-2fa483a8bb69"),

Guid.Parse("e69ed6ba-bea9-4be1-8c67-afd9937264fe"),

Guid.Parse("fbd3311a-9463-4d3d-aea6-d09d2caffb5a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("054f9379-160d-459e-bec7-db78627d7540"),

Guid.Parse("a4053213-9349-43ee-be16-50f2abeb9ef9"),

Guid.Parse("9e6eaee0-d171-475a-b0ac-1d6bb852f072"),

},
},
            new GuiduuidArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("268d4f48-7526-4d94-91dd-0a96e5eb9d8c"),

Guid.Parse("073c412b-9c82-486c-a002-eb17680ad2c8"),

Guid.Parse("d01a89d8-385a-4260-a0d0-9dec0a36ea1a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2833f0c3-6133-4308-a989-af7c2ceda5d3"),

Guid.Parse("b5c3f96c-5a0a-468c-a297-95aab8d0b5f2"),

Guid.Parse("fb67c51d-f17c-4f79-a077-4454f5cee9e2"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("74bc1e0c-9304-4e88-8aec-04ea154dfeb7"),

Guid.Parse("c7c5615c-394a-4130-b3cc-8f550b505179"),

Guid.Parse("2465595e-9581-4d72-8cd5-7840c6c1e5cc"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bd573b0d-fb25-44f9-9a63-36a93cdee083"),

Guid.Parse("b6d6609d-74a5-4422-b695-e796fdb01759"),

Guid.Parse("b6bc18dd-214f-4b2b-b4ae-c1384111ba76"),

Guid.Parse("9d69d3d6-6f66-4db8-8e92-9d21d184fbb7"),

},
},
            new GuiduuidArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e6556eae-a39a-44f6-905b-f22ccde5c25e"),

Guid.Parse("64715ae3-506d-4f8c-89ab-52b2ce9bb528"),

Guid.Parse("5516abd9-240c-40d1-a215-b1410566d833"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("790f01e4-430e-48c6-9ded-a05834845fc4"),

Guid.Parse("b9ef9261-8ee4-477a-90a0-f8bf94c34873"),

Guid.Parse("a5225f55-ec32-442c-a09f-2a3716817f41"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3be6bac6-2ecf-4740-90c2-c69f81e8a36d"),

Guid.Parse("0d3b2cb3-aa5b-43b9-985d-b6dc0bd9bdc6"),

Guid.Parse("3bd7d5a2-bf8d-49c4-bc32-61eca4bb6639"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8dad870d-cb5f-45d7-90be-1d2db649ce9c"),

Guid.Parse("1e9c019d-9103-40f4-942c-3b149eef1241"),

Guid.Parse("d96c8ad2-62e8-4299-8d59-5fe4ba940fb5"),

Guid.Parse("1c7e6fbe-4ddb-43c9-b4b6-37f24255c737"),

},
},
            new GuiduuidArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e39f7bae-a97a-4bc4-8996-caca9dd3e682"),

Guid.Parse("b89af119-55ec-49de-a23e-5d567d7dc6ab"),

Guid.Parse("2baa4608-ae5e-413a-af9b-b72cbcf3761c"),

Guid.Parse("f80f1f6e-7359-4424-a229-3e5e9606333b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("69c36a64-95a1-4c3d-b862-c19f18542a23"),

Guid.Parse("08cdf49f-da2d-45d9-9fd9-9e323de13696"),

Guid.Parse("5786af5c-6e41-45c8-8173-e1d23a89dcdc"),

},
},
            new GuiduuidArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8820e191-0286-43db-b4e7-b8d3eeabc2d7"),

Guid.Parse("17f0a048-b8b4-41b0-a1fd-d0341597d7d0"),

Guid.Parse("a859ac89-2a20-4270-b865-e961f196df05"),

Guid.Parse("019f507e-9c39-4cad-a6e2-8da9f3bc87d5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f3b9431e-cb25-472b-bffe-5b13af4bf090"),

Guid.Parse("da756e64-199f-4bf4-8ec1-3c56d73d304b"),

Guid.Parse("23275b7f-22e4-44a4-8fc3-2811e9a3d094"),

Guid.Parse("7fcebc15-ae20-4e82-97dd-5f91ab1cfba6"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bcfd4931-2f2c-4712-889a-c573b5387a3b"),

Guid.Parse("30cd2074-e694-4c10-bda9-14e2bf436131"),

Guid.Parse("b55f55f4-83e1-4317-bee5-6f4e32f8806f"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("74c408eb-49c2-4153-8ab0-8896bf3e8dae"),

Guid.Parse("4babe2d3-6a8e-45f6-8a4f-3271e43ef14b"),

Guid.Parse("ac134cdf-1fe9-4da0-877d-2e29ac2b90cc"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0b9a5504-f924-46c8-b3a4-9c0e087e30b3"),

Guid.Parse("f8d0ff4f-5db2-40d6-aa22-b3f38441d81a"),

Guid.Parse("b3302991-d1e5-4eae-aa1d-13715c9e8fc5"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e3dc908e-56d9-4e90-adfb-c5920d3814b4"),

Guid.Parse("4f8f780b-55e1-44ea-b578-ad37193aaefd"),

Guid.Parse("79c3c44b-cc38-49b6-9e20-c9a6b203a9a7"),

Guid.Parse("3464cda8-823c-441b-81ba-cd2a8914a9ee"),

},
},
    NullableValue = null,
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[29], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[29], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[29], false);
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
                parametr1.Value = 87;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[29], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidArray2M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidArray2M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 103, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 20, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[29], false);
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 145, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 97, query1, 169, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 169, query1, 141, query2))
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 142, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 103, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[29], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 169, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidArray2M.AssertModel(models[0],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 122, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        GuiduuidArray2M.AssertModel(models[0],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[29], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 145);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
GuiduuidArray2M.AssertModel(models[0],_testData[24], false);GuiduuidArray2M.AssertModel(models[1],_testData[25], false);GuiduuidArray2M.AssertModel(models[2],_testData[26], false);GuiduuidArray2M.AssertModel(models[3],_testData[27], false);GuiduuidArray2M.AssertModel(models[4],_testData[28], false);GuiduuidArray2M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
GuiduuidArray2M.AssertModel(models[0],_testData[14], false);GuiduuidArray2M.AssertModel(models[1],_testData[15], false);GuiduuidArray2M.AssertModel(models[2],_testData[16], false);GuiduuidArray2M.AssertModel(models[3],_testData[17], false);GuiduuidArray2M.AssertModel(models[4],_testData[18], false);GuiduuidArray2M.AssertModel(models[5],_testData[19], false);GuiduuidArray2M.AssertModel(models[6],_testData[20], false);GuiduuidArray2M.AssertModel(models[7],_testData[21], false);GuiduuidArray2M.AssertModel(models[8],_testData[22], false);GuiduuidArray2M.AssertModel(models[9],_testData[23], false);GuiduuidArray2M.AssertModel(models[10],_testData[24], false);GuiduuidArray2M.AssertModel(models[11],_testData[25], false);GuiduuidArray2M.AssertModel(models[12],_testData[26], false);GuiduuidArray2M.AssertModel(models[13],_testData[27], false);GuiduuidArray2M.AssertModel(models[14],_testData[28], false);GuiduuidArray2M.AssertModel(models[15],_testData[29], false);
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
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
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
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

