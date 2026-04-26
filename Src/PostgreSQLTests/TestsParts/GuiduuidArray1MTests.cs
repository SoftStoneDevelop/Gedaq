

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
    internal partial interface IGuidArrayuuidArray
    {
    }
    
    internal partial class GuidArrayuuidArray : IGuidArrayuuidArray
    {


#region TestData

        private readonly GuiduuidArray1M[] _testData = new GuiduuidArray1M[]
        {
            new GuiduuidArray1M
{
    Id = 2,
    Value = 
new System.Guid[4]
{
Guid.Parse("b3967eff-e44e-4bb6-9b01-9b56f22e0f23"),
Guid.Parse("6218e8f9-d22a-43f6-8138-68dbd2d15de3"),
Guid.Parse("ccd30726-b586-45ff-878c-7561aa0b4aa6"),
Guid.Parse("6adb59bb-228b-444f-a02f-c3bddb618b2c"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 3,
    Value = 
new System.Guid[4]
{
Guid.Parse("4175c33f-4fe6-4f35-92a1-2012da0a3f79"),
Guid.Parse("8ab774e5-464f-4508-9b7f-b4823e0888e2"),
Guid.Parse("4b99e216-4c1a-4227-a7ee-9978d1ad896c"),
Guid.Parse("f0ae70bd-9739-415d-a8dd-962b0b8cf726"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("8ad774e5-fabf-4646-a269-9e9e3780fa5a"),
Guid.Parse("29d26716-838d-4d03-8c27-746a9cd1a0ac"),
Guid.Parse("19a65650-fc1c-4c85-88c1-226531aed408"),
Guid.Parse("2ccd8ff5-acb0-4418-b1a8-e1e2d98a6670"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("de0ac384-daa9-49a6-9bc7-ca2d8c36a76e"),
Guid.Parse("4f4a61dc-71ce-4b2b-a95f-8cc3c6909892"),
Guid.Parse("a8feca29-88a8-4524-b7b8-c74afdc8e60d"),
Guid.Parse("938a5deb-a1ce-463b-91d8-3bb0110c4293"),
},
},
            new GuiduuidArray1M
{
    Id = 11,
    Value = 
new System.Guid[3]
{
Guid.Parse("dd5f383e-bae1-44e3-ac64-2ad3a9d16003"),
Guid.Parse("d74bc1e2-b853-465e-90e3-2580f68f2959"),
Guid.Parse("0684d223-b531-432d-a853-43921cd21975"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0cbf9b13-7b2a-4519-8f33-743a6b49284c"),
Guid.Parse("2a5303f4-6194-4853-8d0e-854874d0b8ce"),
Guid.Parse("d9f660f3-6023-4249-b573-e48461cd3329"),
},
},
            new GuiduuidArray1M
{
    Id = 17,
    Value = 
new System.Guid[4]
{
Guid.Parse("5de5dbb2-ff38-4b70-bb8f-d3e2da97f45b"),
Guid.Parse("2082a505-2d74-40c3-8ee4-f6a36baa70ec"),
Guid.Parse("d733be51-9e9e-4abb-81ed-7c9a004adb1c"),
Guid.Parse("737dd8a6-5fdb-40cb-af6b-2c9b27ef1761"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("4b910ec6-43f4-40be-a77a-8bef2e21d6a8"),
Guid.Parse("bb923fba-921b-4b18-9443-24a9a34256c4"),
Guid.Parse("16b6a2c0-76f9-4c12-ad3c-f0de84a077f9"),
Guid.Parse("7797f50f-5abb-4cd5-8fbb-d5c97fdc1237"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("81f26379-63a9-4d85-8a4c-9b7f1a22431c"),
Guid.Parse("9ee46873-cae1-44c3-b175-2f62027e6d89"),
Guid.Parse("c1c1062c-dd42-4ef8-9d9f-07b015ffdf6d"),
Guid.Parse("f469e0eb-c15d-4f0c-86ee-c3920ede7b0f"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 23,
    Value = 
new System.Guid[3]
{
Guid.Parse("96811163-4b6f-421e-9bdc-1f29b011ef48"),
Guid.Parse("f26b8054-bc0d-45dd-9f9a-227898b13696"),
Guid.Parse("e74e009f-2268-4981-b1bb-9950f097452e"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("bc6f9820-cec2-4e21-9dff-cf99d29a7137"),
Guid.Parse("73fa7ab4-a0cd-484d-bd07-d8c7064e3422"),
Guid.Parse("b6297a29-84f1-413d-871d-960e69311493"),
Guid.Parse("cb7521fa-0e6c-47b5-a6ab-60d47043a61d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 13,
    Value = 
new System.Guid[4]
{
Guid.Parse("abf899fb-4955-48c7-8f6c-9525a3b9e9e1"),
Guid.Parse("1f78cc6e-fd4b-43c3-ae82-9b85ba7600a8"),
Guid.Parse("25eab039-c943-44e8-a4c0-4104bd33d4d9"),
Guid.Parse("8ae6e061-2d0e-4b9c-b2fc-b6a16214f4ed"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 32,
    Value = 
new System.Guid[4]
{
Guid.Parse("83b4e580-cdf9-4558-ab0c-7349390a47fe"),
Guid.Parse("91641aa7-4874-47ec-bffc-93c42f078b8f"),
Guid.Parse("708b838e-b4da-4378-a5c0-f9e9026a069d"),
Guid.Parse("19b0b30c-d912-46dc-b67b-facea193a42c"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("6822ed78-683f-4b4a-b694-c71fc0c48d17"),
Guid.Parse("1154fd0c-3fa2-4e66-84af-c073c61ddfe1"),
Guid.Parse("9e4b1e61-12f1-47a8-9b14-33132b05678e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 22,
    Value = 
new System.Guid[3]
{
Guid.Parse("f61f4371-48b2-4dec-a10f-9f6ff52dc536"),
Guid.Parse("33c16ba9-b46e-4ba9-99fd-04d0630b6433"),
Guid.Parse("dd3c7546-d524-451e-a4df-5c71b2771536"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("32598708-c820-4f72-abfc-83ff69882bef"),
Guid.Parse("7ce3b85f-ac8c-42b6-a38c-2c302f89a2fe"),
Guid.Parse("34d5c4c9-2e87-4228-af13-7abc77fa3a50"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9d5b2a9d-83f9-44e8-a0b4-116f64d3dc2d"),
Guid.Parse("1f629dce-ebcc-4a49-a8e8-a790b24c03a0"),
Guid.Parse("81b399d9-ed33-42d1-88a0-10ed685f0c04"),
},
},
            new GuiduuidArray1M
{
    Id = 39,
    Value = 
new System.Guid[3]
{
Guid.Parse("eceb163e-d901-4031-8f64-548accd0ca27"),
Guid.Parse("2273ac7d-ba81-456e-ac0b-568330498742"),
Guid.Parse("56f9524c-6dbc-4873-9d79-faec282db912"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3f70f5da-ccf0-4ddc-bd1a-48eadb3b83f1"),
Guid.Parse("9b4905fe-4f9d-4d2a-9c2b-88eea528b5e6"),
Guid.Parse("060f5928-2c55-4a8a-9bc2-9991e9f7aae7"),
},
},
            new GuiduuidArray1M
{
    Id = 48,
    Value = 
new System.Guid[4]
{
Guid.Parse("7076784f-dbcf-4c90-ac6d-1ab5525cdcc6"),
Guid.Parse("3ac0a13e-ee7c-4383-a874-0feb82c0c7f7"),
Guid.Parse("28fd97ff-4c1f-492c-a68b-180d7c8cb47a"),
Guid.Parse("174c5c2d-9f06-488a-8400-a4efb47de408"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 26,
    Value = 
new System.Guid[3]
{
Guid.Parse("f0772ed6-7852-4592-88be-a9776498ff0c"),
Guid.Parse("dddd029a-2b2c-498a-8704-a59f3c84d6bd"),
Guid.Parse("469c56b4-445b-4ce6-9a6d-8da212ec9d40"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9e76c392-ccf5-4839-b7c9-a6531622f9fc"),
Guid.Parse("2984df94-f331-4ad1-8630-61f4c80a3a17"),
Guid.Parse("105079a2-43f3-4be3-a5e5-d2f3d399729f"),
Guid.Parse("f0ec0adc-fcb4-4b94-a32a-bc90ea7da958"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("4ff15232-bd40-4150-80e6-89461ac0e4df"),
Guid.Parse("efec0c9a-4f01-438a-8bbb-5c3143fb1dd4"),
Guid.Parse("92f2115b-0bd7-46de-bc7a-e178c03fd9ff"),
Guid.Parse("2114e84d-9a8d-4a8f-91a1-b51114a8cdf4"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c83e192c-7189-44e3-a8b3-783947e598fc"),
Guid.Parse("38404614-7bf4-4698-ae83-392de52c48a2"),
Guid.Parse("1f928f6d-abff-44b5-ab9d-e06b2102a38b"),
},
},
            new GuiduuidArray1M
{
    Id = 59,
    Value = 
new System.Guid[4]
{
Guid.Parse("87b37443-1039-41a1-932e-ccd73b6faaf7"),
Guid.Parse("36136311-0786-4137-bc44-e58b72c3caaa"),
Guid.Parse("921ac108-5e6b-4861-b029-ac137e7581e1"),
Guid.Parse("806622f2-41f7-4579-a004-aa628ada7525"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("75bfabc5-2d84-4d8f-8866-08f6b596985a"),
Guid.Parse("7fbd8097-8e6e-433b-ab26-6d1315800a71"),
Guid.Parse("e5ca28bf-4c20-48fd-8983-cb771ec70bde"),
Guid.Parse("85a9d294-b7de-4377-999d-e8b4fb63b07f"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("985aa299-07c6-4d05-a0d5-7c3d1dabb64a"),
Guid.Parse("d23f5ad3-1627-4a1f-bff0-ae3ae0287c48"),
Guid.Parse("74f1bfe7-02d0-4fc6-ade6-4b74ad8ac56f"),
Guid.Parse("2acbde9a-5e7b-4a0e-b90d-0b9f504c53b4"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ceb8fbcf-ccac-450c-a366-e981c1e1e60e"),
Guid.Parse("6a93b55c-730e-4ba1-aea3-ee614874f006"),
Guid.Parse("42739273-1f90-4e83-a1e1-aaf3e6e070b9"),
Guid.Parse("f87c7aeb-a2ac-4bda-82ad-b76e543bde02"),
},
},
            new GuiduuidArray1M
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("1ec9ed37-ba49-4be0-b560-9ab8c6fdd915"),
Guid.Parse("658aadf1-2b1a-4a96-ad30-b09e845c708b"),
Guid.Parse("b6b4e4a6-3ae9-48b4-b4cf-47cef5229050"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3cb93854-7ff8-4ab3-827a-c0bda9f94d57"),
Guid.Parse("e3d4af5d-30b5-4e8e-963f-56cd2b2c7661"),
Guid.Parse("35b5619b-d63c-447b-b05f-4cb0c6df9fb9"),
Guid.Parse("2f3c700f-127f-442e-82f1-bce4fc903f37"),
},
},
            new GuiduuidArray1M
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("ca787005-bad0-4788-be21-67fcdacd1c50"),
Guid.Parse("2485135d-7d33-4ac1-a71b-a1b7f14dd163"),
Guid.Parse("138fe50a-7d07-4a1e-950e-6ff3a13247c0"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 32,
    Value = 
new System.Guid[4]
{
Guid.Parse("71a361c7-98d0-46d4-814e-669ef391e0c9"),
Guid.Parse("250adc04-4f54-4ff9-a020-4729bf3c4400"),
Guid.Parse("f80820ef-99a5-4c8e-bf1c-4a7af65c05dc"),
Guid.Parse("e64935c5-eaf7-4587-8217-61a0a5c1a4da"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e0743358-098e-4a59-813f-575610ea79c2"),
Guid.Parse("08d3ed25-22ed-4aa6-b668-32d4369f04a3"),
Guid.Parse("eed39efc-c634-46a4-bad0-6c0e98064e67"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4f3cccc3-c2a0-4904-b77b-1609f9789510"),
Guid.Parse("7125cb25-7825-4c47-a91d-aae1ce25aebf"),
Guid.Parse("7d9453c0-bbb6-4d1b-9632-f1436ea42648"),
},
},
            new GuiduuidArray1M
{
    Id = 78,
    Value = 
new System.Guid[4]
{
Guid.Parse("83a64806-a700-4ef2-997d-664242526d29"),
Guid.Parse("6d0883ac-91e3-460a-9680-e5177f638df1"),
Guid.Parse("3c6b95d3-f9b7-41b4-8857-49aace319ec2"),
Guid.Parse("80a1ec9e-5b62-4ba1-b09d-18ef727cdd1a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b5f47b24-f5f4-4784-9f32-6a9e1b330a5e"),
Guid.Parse("732714e2-3a66-4b5c-a10f-baba18b43f8d"),
Guid.Parse("33555de9-1739-44a9-aea2-7cc60664147e"),
Guid.Parse("04ddf365-cf2d-458c-ae72-9f91619631db"),
},
},
            new GuiduuidArray1M
{
    Id = 81,
    Value = 
new System.Guid[3]
{
Guid.Parse("f99d1f95-ca87-4e09-a5bf-90b9432b94ee"),
Guid.Parse("56912237-e712-4a8c-b367-b9514cb5d820"),
Guid.Parse("2456c4bf-eae4-41b7-8c0e-c247e0cc2fba"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 33,
    Value = 
new System.Guid[3]
{
Guid.Parse("fd2d5cd0-e723-4865-8383-1683cd7e143a"),
Guid.Parse("a9777fa0-616e-46bc-a7df-7995505f1450"),
Guid.Parse("9833b4d3-3e12-4b9f-8704-2c7169f05d47"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6de42fd7-d201-4e3d-82b2-b28d7367c0fa"),
Guid.Parse("81087372-a537-4695-8362-a835eaa30317"),
Guid.Parse("695b726b-f6e5-4e1c-a035-7a16226850c1"),
Guid.Parse("da72450a-9adb-478f-bce0-336a41520c83"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 85,
    Value = 
new System.Guid[4]
{
Guid.Parse("f52aac09-2a0f-4853-a09d-3689dedea2f3"),
Guid.Parse("1814d857-76f9-46f5-967f-9f297027bfbf"),
Guid.Parse("61030208-ea0d-4bc3-b2fe-cc48eeca1aad"),
Guid.Parse("9c99ce36-0069-4528-95c9-87ad501ef153"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ed491775-2bcf-4161-93ee-8f1652b7309a"),
Guid.Parse("1d2838cc-de92-4830-8fab-e8950b339a26"),
Guid.Parse("93d049c2-deb2-483a-a2ef-3b68db72fa93"),
Guid.Parse("f8680df1-13bf-4b6e-994d-dd264292720a"),
},
},
            new GuiduuidArray1M
{
    Id = 93,
    Value = 
new System.Guid[3]
{
Guid.Parse("6a96ef30-efa0-4485-8d5c-8be3abb07027"),
Guid.Parse("17fbde9d-0723-4573-ad53-982cfc7c3659"),
Guid.Parse("8f211cb3-8990-4e0b-9261-5dbe59205af7"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 41,
    Value = 
new System.Guid[3]
{
Guid.Parse("2c246e30-e7d0-43d1-b2a9-44440daae1b2"),
Guid.Parse("9be9472d-8d37-4f60-958a-d455e8670350"),
Guid.Parse("0e9670f5-3267-4c11-a216-161fdca5d78b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e9c038c4-5de1-46c2-8dea-253edbd7730e"),
Guid.Parse("e987e081-c6ad-4431-a41c-ddb137b9b079"),
Guid.Parse("881fd4c3-ea72-48ba-b9ea-3d4534634882"),
Guid.Parse("bd7c26c5-9e82-4e5d-848b-374e83d67baf"),
},
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[3]
{
Guid.Parse("8c103e67-720b-45ca-ad56-5e2d70a70208"),
Guid.Parse("ac647295-7489-4690-a6df-c4fae84c2b92"),
Guid.Parse("b2f1d0dc-ec7f-4e4c-b733-dfc5dd04209f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("486ee5f1-fb13-406e-af72-1d9eb5d2889d"),
Guid.Parse("ca5029b4-bfb4-4c7e-a6f2-a97e20806ba5"),
Guid.Parse("49a8807c-9c4e-4b20-b4fe-ea57b76addc7"),
},
},
            new GuiduuidArray1M
{
    Id = 103,
    Value = 
new System.Guid[3]
{
Guid.Parse("74436b46-7013-4a75-aa99-f9ed50a0e579"),
Guid.Parse("92789136-6d9b-4d12-988d-46d0ea22a78f"),
Guid.Parse("fb71e92e-b957-499e-81f8-d8e2c3ee3da5"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 50,
    Value = 
new System.Guid[3]
{
Guid.Parse("a8687a94-616f-4432-a6ea-dd76634fb0a6"),
Guid.Parse("80583e63-9016-45b6-a477-12adf213677c"),
Guid.Parse("1ec1ac87-a2ee-460a-8606-5c849cbd5106"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f6fb3d3c-c7a0-4863-8d76-9e3d2c37d180"),
Guid.Parse("03643241-a25c-48be-b9e9-6ed33e88aab2"),
Guid.Parse("c7d2251f-4f98-42e1-a1fc-85072dc40f86"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 112,
    Value = 
new System.Guid[4]
{
Guid.Parse("f35fdecd-6526-43cd-a6ae-b3933584da7e"),
Guid.Parse("8b9bfd30-821e-49c9-9a7c-7f5f72b562c0"),
Guid.Parse("32e5dcb2-e24f-493f-838a-6164124d2684"),
Guid.Parse("2fe5fa05-e3d7-426f-bf1d-85e6826c5947"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bd2626a3-a291-473c-8c0d-ba5365ca6404"),
Guid.Parse("568244a3-69f3-46b5-a946-c9080fed176d"),
Guid.Parse("9e42557a-eeae-49bd-bbf2-a93f74efde5c"),
},
},
            new GuiduuidArray1M
{
    Id = 119,
    Value = 
new System.Guid[3]
{
Guid.Parse("9241abc0-f744-431e-a76d-e06932f5fbb6"),
Guid.Parse("93af3494-ce70-430a-8a1d-f4769dc57ca2"),
Guid.Parse("a219516d-427f-483d-843c-8caa3f6e2d49"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 56,
    Value = 
new System.Guid[4]
{
Guid.Parse("e9182afa-98ca-458f-9edc-ad82378c56f1"),
Guid.Parse("e9eb6702-783b-452b-9d51-d7eabfd34608"),
Guid.Parse("12819c7b-d2b5-4298-8e6e-fbe9aeb77e4d"),
Guid.Parse("23a446c9-4713-4e8c-86f9-3aaf1ed51320"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("273e0fd0-bc42-465a-af45-fe2cbec1ef38"),
Guid.Parse("8df38463-fccc-40ea-9b0e-aec50a0fa0a3"),
Guid.Parse("ec334615-04db-439f-8be2-deb8cab87a1c"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d5ee351b-700e-4810-861b-a554914de111"),
Guid.Parse("660f9ba1-f66f-45ce-92e3-e11ceb3c7ee1"),
Guid.Parse("d79ee5af-0559-4a46-9f97-16b52ba682ca"),
},
},
            new GuiduuidArray1M
{
    Id = 127,
    Value = 
new System.Guid[4]
{
Guid.Parse("abf46ebc-dfb1-4525-a7b3-2940cd8bd2d2"),
Guid.Parse("c482066c-f567-42b3-af96-b066daa0f8e5"),
Guid.Parse("75230804-03a5-4cbc-9a65-071d39bfd26f"),
Guid.Parse("76eea3de-7172-4e06-b7e9-feb17227ac69"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 136,
    Value = 
new System.Guid[3]
{
Guid.Parse("b3508103-a2b3-4b9a-939d-d55bb0029534"),
Guid.Parse("45c1e008-7ab5-4583-8bb1-9a82424991e5"),
Guid.Parse("284fecad-eb0d-4ec1-97f7-7f105acb3637"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 57,
    Value = 
new System.Guid[4]
{
Guid.Parse("805f7e04-a4f2-4fc2-9174-4f5bd9c7c89e"),
Guid.Parse("15ff7d6f-ba6c-44ae-806d-dc17387294ae"),
Guid.Parse("635e60cf-b271-48bd-9917-70905bb5d80a"),
Guid.Parse("739e5a48-f0af-4f8d-9edd-9f5ccb2423d2"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0654d4f0-cf1d-414b-b5e7-aee9145214c9"),
Guid.Parse("f771f3ad-a123-461e-ae2b-6f6d49fdc5f2"),
Guid.Parse("fe16a802-6111-4972-afca-09a4ddb50858"),
Guid.Parse("3d975e02-2727-4d75-a9ba-355f06cbeb7d"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 142,
    Value = 
new System.Guid[4]
{
Guid.Parse("83e390d6-44ca-4c87-9940-4ae47adf3082"),
Guid.Parse("ff76374e-1741-4126-9cd6-25ad7a7432e1"),
Guid.Parse("5cf21682-5a8f-4648-b970-caa72d7d31de"),
Guid.Parse("d2cb5879-036b-4135-beaa-96410d4b70c8"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0db3e325-3fb7-4917-90cd-1a61a2e94962"),
Guid.Parse("9510ace9-8b03-49ba-a7d4-e0dc015bfb73"),
Guid.Parse("7e869ebf-da86-4f7e-9e68-cdef36198d8a"),
},
},
            new GuiduuidArray1M
{
    Id = 148,
    Value = 
new System.Guid[3]
{
Guid.Parse("bd4a6ee6-6ec9-4863-be71-763b32d35f67"),
Guid.Parse("81f7c877-8766-4b8f-b67a-5f7c216c1208"),
Guid.Parse("aa630b1e-0a73-4100-b97d-bf3cd5add37e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("abbf1461-da20-4920-a7d0-694d52932008"),
Guid.Parse("ce5cce35-5395-46de-bec7-f8101c6a1308"),
Guid.Parse("26cf0306-a741-4e78-b79e-d5f9971bb133"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6c659b6d-ea2f-4961-b47a-f00c2d616137"),
Guid.Parse("0d806055-266d-4e33-a643-9102ea96ccae"),
Guid.Parse("cd63c5d9-27c5-4282-9376-95a87f923208"),
Guid.Parse("a7ecad6f-25fd-463b-8f2f-c1c5492e7891"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 155,
    Value = 
new System.Guid[4]
{
Guid.Parse("3bc5b0cd-cff5-41ee-a0e4-bb7f206921eb"),
Guid.Parse("97631089-b7fc-405f-8fc3-0217d863f68a"),
Guid.Parse("c960be6e-bf6d-4893-b5e9-40ae85b0bcd8"),
Guid.Parse("a72d7e44-3aaf-4594-986f-55f241db21d6"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("d42b9236-af28-48fb-a4c6-be32964d8a45"),
Guid.Parse("5113fbe4-c893-4a50-933c-8545d5bd2cc0"),
Guid.Parse("f52fb00a-29e7-4919-ae03-e1db1352635d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("847b0982-9f26-47a1-8679-6df01797beb9"),
Guid.Parse("18a4cc7d-6f2b-4da7-b213-28b448707fde"),
Guid.Parse("c586b52f-ab8e-41c3-a52a-f90f3b24b556"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 165,
    Value = 
new System.Guid[3]
{
Guid.Parse("578118a5-35e5-4738-80d6-947cbf94f630"),
Guid.Parse("067f3e0d-c52e-4085-8327-cbb36e66b839"),
Guid.Parse("87ddb06e-18a8-40ec-8d75-ecf25e186ad0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 166,
    Value = 
new System.Guid[4]
{
Guid.Parse("50b490c8-3a4a-4948-baac-f16668d0b252"),
Guid.Parse("b5ef7f68-4188-4177-a960-b8774379d6fb"),
Guid.Parse("08952273-a253-4ddf-a2f6-b225ceb55fd4"),
Guid.Parse("49d9ba5e-a7f0-4efc-9554-76094661af00"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 76,
    Value = 
new System.Guid[4]
{
Guid.Parse("5c9bf5d2-2ca3-4048-9502-2785e78a8d18"),
Guid.Parse("be2380ba-b63d-4fef-b3ac-d216814ff54a"),
Guid.Parse("1fef1c0b-83dc-41d5-8705-8da9636e00fa"),
Guid.Parse("4e0933f3-52c2-459d-938f-f469ad226d33"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c90730e6-7e27-4c96-853d-2523c4fdaef5"),
Guid.Parse("5e35674d-0efc-4eca-9e5d-bc2213fa25f5"),
Guid.Parse("789f30fb-84e1-43b0-8049-a629f7b39c75"),
Guid.Parse("ce60b23f-546b-4ab8-a907-c89d646173aa"),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1mi(
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
INSERT INTO public.guiduuidarray1mi(
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
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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

                changedRows =  ((IGuidArrayuuidArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidArrayuuidArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidArrayuuidArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidArrayuuidArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
            asPartInterface: typeof(IGuidArrayuuidArray)), 
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
                methodParametrName: "guiduuidarray1mi_id", 
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
                changedRows =  ((IGuidArrayuuidArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidArrayuuidArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidArrayuuidArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidArrayuuidArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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

                    nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("9d5b2a9d-83f9-44e8-a0b4-116f64d3dc2d"),
Guid.Parse("1f629dce-ebcc-4a49-a8e8-a790b24c03a0"),
Guid.Parse("81b399d9-ed33-42d1-88a0-10ed685f0c04"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                methodParametrName: "guiduuidarray1mi_id", 
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
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("3f70f5da-ccf0-4ddc-bd1a-48eadb3b83f1"),
Guid.Parse("9b4905fe-4f9d-4d2a-9c2b-88eea528b5e6"),
Guid.Parse("060f5928-2c55-4a8a-9bc2-9991e9f7aae7"),
}));
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("c83e192c-7189-44e3-a8b3-783947e598fc"),
Guid.Parse("38404614-7bf4-4698-ae83-392de52c48a2"),
Guid.Parse("1f928f6d-abff-44b5-ab9d-e06b2102a38b"),
}));
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("ceb8fbcf-ccac-450c-a366-e981c1e1e60e"),
Guid.Parse("6a93b55c-730e-4ba1-aea3-ee614874f006"),
Guid.Parse("42739273-1f90-4e83-a1e1-aaf3e6e070b9"),
Guid.Parse("f87c7aeb-a2ac-4bda-82ad-b76e543bde02"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray1M> models = null;

                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray1M> models = null;

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidArrayuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidArrayuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[2], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[3], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[26],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[29], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
GuiduuidArray1M.AssertModel(models[0],_testData[22], false);GuiduuidArray1M.AssertModel(models[1],_testData[23], false);GuiduuidArray1M.AssertModel(models[2],_testData[24], false);GuiduuidArray1M.AssertModel(models[3],_testData[25], false);GuiduuidArray1M.AssertModel(models[4],_testData[26], false);GuiduuidArray1M.AssertModel(models[5],_testData[27], false);GuiduuidArray1M.AssertModel(models[6],_testData[28], false);GuiduuidArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
GuiduuidArray1M.AssertModel(models[0],_testData[13], false);GuiduuidArray1M.AssertModel(models[1],_testData[14], false);GuiduuidArray1M.AssertModel(models[2],_testData[15], false);GuiduuidArray1M.AssertModel(models[3],_testData[16], false);GuiduuidArray1M.AssertModel(models[4],_testData[17], false);GuiduuidArray1M.AssertModel(models[5],_testData[18], false);GuiduuidArray1M.AssertModel(models[6],_testData[19], false);GuiduuidArray1M.AssertModel(models[7],_testData[20], false);GuiduuidArray1M.AssertModel(models[8],_testData[21], false);GuiduuidArray1M.AssertModel(models[9],_testData[22], false);GuiduuidArray1M.AssertModel(models[10],_testData[23], false);GuiduuidArray1M.AssertModel(models[11],_testData[24], false);GuiduuidArray1M.AssertModel(models[12],_testData[25], false);GuiduuidArray1M.AssertModel(models[13],_testData[26], false);GuiduuidArray1M.AssertModel(models[14],_testData[27], false);GuiduuidArray1M.AssertModel(models[15],_testData[28], false);GuiduuidArray1M.AssertModel(models[16],_testData[29], false);
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
                var models = ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
GuiduuidArray1M.AssertModel(models[0],_testData[14], false);GuiduuidArray1M.AssertModel(models[1],_testData[15], false);GuiduuidArray1M.AssertModel(models[2],_testData[16], false);GuiduuidArray1M.AssertModel(models[3],_testData[17], false);GuiduuidArray1M.AssertModel(models[4],_testData[18], false);GuiduuidArray1M.AssertModel(models[5],_testData[19], false);GuiduuidArray1M.AssertModel(models[6],_testData[20], false);GuiduuidArray1M.AssertModel(models[7],_testData[21], false);GuiduuidArray1M.AssertModel(models[8],_testData[22], false);GuiduuidArray1M.AssertModel(models[9],_testData[23], false);GuiduuidArray1M.AssertModel(models[10],_testData[24], false);GuiduuidArray1M.AssertModel(models[11],_testData[25], false);GuiduuidArray1M.AssertModel(models[12],_testData[26], false);GuiduuidArray1M.AssertModel(models[13],_testData[27], false);GuiduuidArray1M.AssertModel(models[14],_testData[28], false);GuiduuidArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
GuiduuidArray1M.AssertModel(models[0],_testData[14], false);GuiduuidArray1M.AssertModel(models[1],_testData[15], false);GuiduuidArray1M.AssertModel(models[2],_testData[16], false);GuiduuidArray1M.AssertModel(models[3],_testData[17], false);GuiduuidArray1M.AssertModel(models[4],_testData[18], false);GuiduuidArray1M.AssertModel(models[5],_testData[19], false);GuiduuidArray1M.AssertModel(models[6],_testData[20], false);GuiduuidArray1M.AssertModel(models[7],_testData[21], false);GuiduuidArray1M.AssertModel(models[8],_testData[22], false);GuiduuidArray1M.AssertModel(models[9],_testData[23], false);GuiduuidArray1M.AssertModel(models[10],_testData[24], false);GuiduuidArray1M.AssertModel(models[11],_testData[25], false);GuiduuidArray1M.AssertModel(models[12],_testData[26], false);GuiduuidArray1M.AssertModel(models[13],_testData[27], false);GuiduuidArray1M.AssertModel(models[14],_testData[28], false);GuiduuidArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 39, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[29], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 52, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await((IGuidArrayuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 127, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
GuiduuidArray1M.AssertModel(models[0],_testData[23], false);GuiduuidArray1M.AssertModel(models[1],_testData[24], false);GuiduuidArray1M.AssertModel(models[2],_testData[25], false);GuiduuidArray1M.AssertModel(models[3],_testData[26], false);GuiduuidArray1M.AssertModel(models[4],_testData[27], false);GuiduuidArray1M.AssertModel(models[5],_testData[28], false);GuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
GuiduuidArray1M.AssertModel(models[0],_testData[19], false);GuiduuidArray1M.AssertModel(models[1],_testData[20], false);GuiduuidArray1M.AssertModel(models[2],_testData[21], false);GuiduuidArray1M.AssertModel(models[3],_testData[22], false);GuiduuidArray1M.AssertModel(models[4],_testData[23], false);GuiduuidArray1M.AssertModel(models[5],_testData[24], false);GuiduuidArray1M.AssertModel(models[6],_testData[25], false);GuiduuidArray1M.AssertModel(models[7],_testData[26], false);GuiduuidArray1M.AssertModel(models[8],_testData[27], false);GuiduuidArray1M.AssertModel(models[9],_testData[28], false);GuiduuidArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = ((IGuidArrayuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatch(connection, 25, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
GuiduuidArray1M.AssertModel(models[0],_testData[6], false);GuiduuidArray1M.AssertModel(models[1],_testData[7], false);GuiduuidArray1M.AssertModel(models[2],_testData[8], false);GuiduuidArray1M.AssertModel(models[3],_testData[9], false);GuiduuidArray1M.AssertModel(models[4],_testData[10], false);GuiduuidArray1M.AssertModel(models[5],_testData[11], false);GuiduuidArray1M.AssertModel(models[6],_testData[12], false);GuiduuidArray1M.AssertModel(models[7],_testData[13], false);GuiduuidArray1M.AssertModel(models[8],_testData[14], false);GuiduuidArray1M.AssertModel(models[9],_testData[15], false);GuiduuidArray1M.AssertModel(models[10],_testData[16], false);GuiduuidArray1M.AssertModel(models[11],_testData[17], false);GuiduuidArray1M.AssertModel(models[12],_testData[18], false);GuiduuidArray1M.AssertModel(models[13],_testData[19], false);GuiduuidArray1M.AssertModel(models[14],_testData[20], false);GuiduuidArray1M.AssertModel(models[15],_testData[21], false);GuiduuidArray1M.AssertModel(models[16],_testData[22], false);GuiduuidArray1M.AssertModel(models[17],_testData[23], false);GuiduuidArray1M.AssertModel(models[18],_testData[24], false);GuiduuidArray1M.AssertModel(models[19],_testData[25], false);GuiduuidArray1M.AssertModel(models[20],_testData[26], false);GuiduuidArray1M.AssertModel(models[21],_testData[27], false);GuiduuidArray1M.AssertModel(models[22],_testData[28], false);GuiduuidArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
GuiduuidArray1M.AssertModel(models[0],_testData[22], false);GuiduuidArray1M.AssertModel(models[1],_testData[23], false);GuiduuidArray1M.AssertModel(models[2],_testData[24], false);GuiduuidArray1M.AssertModel(models[3],_testData[25], false);GuiduuidArray1M.AssertModel(models[4],_testData[26], false);GuiduuidArray1M.AssertModel(models[5],_testData[27], false);GuiduuidArray1M.AssertModel(models[6],_testData[28], false);GuiduuidArray1M.AssertModel(models[7],_testData[29], false);
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
                await using var cmd = await ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 155);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
GuiduuidArray1M.AssertModel(models[0],_testData[27], false);GuiduuidArray1M.AssertModel(models[1],_testData[28], false);GuiduuidArray1M.AssertModel(models[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
GuiduuidArray1M.AssertModel(models[0],_testData[5], false);GuiduuidArray1M.AssertModel(models[1],_testData[6], false);GuiduuidArray1M.AssertModel(models[2],_testData[7], false);GuiduuidArray1M.AssertModel(models[3],_testData[8], false);GuiduuidArray1M.AssertModel(models[4],_testData[9], false);GuiduuidArray1M.AssertModel(models[5],_testData[10], false);GuiduuidArray1M.AssertModel(models[6],_testData[11], false);GuiduuidArray1M.AssertModel(models[7],_testData[12], false);GuiduuidArray1M.AssertModel(models[8],_testData[13], false);GuiduuidArray1M.AssertModel(models[9],_testData[14], false);GuiduuidArray1M.AssertModel(models[10],_testData[15], false);GuiduuidArray1M.AssertModel(models[11],_testData[16], false);GuiduuidArray1M.AssertModel(models[12],_testData[17], false);GuiduuidArray1M.AssertModel(models[13],_testData[18], false);GuiduuidArray1M.AssertModel(models[14],_testData[19], false);GuiduuidArray1M.AssertModel(models[15],_testData[20], false);GuiduuidArray1M.AssertModel(models[16],_testData[21], false);GuiduuidArray1M.AssertModel(models[17],_testData[22], false);GuiduuidArray1M.AssertModel(models[18],_testData[23], false);GuiduuidArray1M.AssertModel(models[19],_testData[24], false);GuiduuidArray1M.AssertModel(models[20],_testData[25], false);GuiduuidArray1M.AssertModel(models[21],_testData[26], false);GuiduuidArray1M.AssertModel(models[22],_testData[27], false);GuiduuidArray1M.AssertModel(models[23],_testData[28], false);GuiduuidArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidArrayuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
                await ((IGuidArrayuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
FROM public.binary_guiduuidarray1m m
LEFT JOIN public.binary_guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray1M>(15);

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
                ((IGuidArrayuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                GuiduuidArray1M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IGuidArrayuuidArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidArrayuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                GuiduuidArray1M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[14], false);
                GuiduuidArray1M.AssertModel(models[15],_testData[15], false);
                GuiduuidArray1M.AssertModel(models[16],_testData[16], false);
                GuiduuidArray1M.AssertModel(models[17],_testData[17], false);
                GuiduuidArray1M.AssertModel(models[18],_testData[18], false);
                GuiduuidArray1M.AssertModel(models[19],_testData[19], false);
                GuiduuidArray1M.AssertModel(models[20],_testData[20], false);
                GuiduuidArray1M.AssertModel(models[21],_testData[21], false);
                GuiduuidArray1M.AssertModel(models[22],_testData[22], false);
                GuiduuidArray1M.AssertModel(models[23],_testData[23], false);
                GuiduuidArray1M.AssertModel(models[24],_testData[24], false);
                GuiduuidArray1M.AssertModel(models[25],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[26],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[27],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[28],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidArrayuuidArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidArrayuuidArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

