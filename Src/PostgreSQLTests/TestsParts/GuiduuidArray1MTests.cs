

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
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("9188c68e-4290-40d5-a69c-34de0ccd43b9"),
Guid.Parse("f0a34284-1a68-4a60-84af-2922184624f6"),
Guid.Parse("0fc1a365-da26-49cf-b300-e0fb3ede3b08"),
Guid.Parse("d4add6e9-3857-4249-99cb-a67a63677476"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b730dcbd-f943-4877-98e9-d245b598c792"),
Guid.Parse("e276cb03-ec14-44a1-9abc-46ad6a702764"),
Guid.Parse("91d901f6-8534-4476-b613-558e84b07ad9"),
Guid.Parse("2fb33c50-41b4-42ae-9f2a-88015e0debdf"),
},
},
            new GuiduuidArray1M
{
    Id = 12,
    Value = 
new System.Guid[3]
{
Guid.Parse("2d43c355-1adb-4b20-a9f9-2a0a9c57ae80"),
Guid.Parse("b2cc9d0e-08ba-483a-b408-1ebc2a7baac3"),
Guid.Parse("9aa4c2fc-c37a-4d16-8503-0802ca087fff"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("48a0709e-0384-4263-babb-191bdb796a13"),
Guid.Parse("2b71e0d4-446b-444c-ae74-afe6431bcb27"),
Guid.Parse("854e6dda-b15b-4bb6-b522-3003ecc85faf"),
Guid.Parse("4a35391e-355e-4825-9422-fda2decb58e9"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("577c09cd-4e55-41df-a506-5403275f2669"),
Guid.Parse("c68ee311-331b-4eb8-bd9b-d3660bbb93ec"),
Guid.Parse("fd792387-5fce-42f0-be61-13fd8f10a94b"),
},
},
            new GuiduuidArray1M
{
    Id = 14,
    Value = 
new System.Guid[4]
{
Guid.Parse("11f1d050-155b-4170-8297-4075c03cfc25"),
Guid.Parse("de249d6b-132b-4efa-afbd-57a2307b3500"),
Guid.Parse("e731aa4b-1560-4862-890d-2a60eda64d58"),
Guid.Parse("f4876730-a5cd-4eea-875f-7c8ccf4bf1b8"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 16,
    Value = 
new System.Guid[4]
{
Guid.Parse("34c45acb-a28c-4209-9d19-2dc80f740bf1"),
Guid.Parse("c75c0f48-7e56-48a1-8276-627f6119abbc"),
Guid.Parse("f650a98f-fa19-4cfb-a26d-6788a62b2482"),
Guid.Parse("c1f8c8f0-ff4f-480a-9e95-40c081e1b3fc"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("5f350e7d-7732-4126-8f98-e75902f7d9fd"),
Guid.Parse("e36a1829-06b7-4608-af20-d39134253efa"),
Guid.Parse("97b243b0-fe5a-4364-9249-6c528aceb760"),
Guid.Parse("e3216992-b71e-44dd-90c7-61c44ac65474"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6f0aecf9-310e-453b-97de-cc22ee66dab8"),
Guid.Parse("e870098f-017d-443f-b3d8-ea75e581565a"),
Guid.Parse("0b1f1d0e-a07e-4691-99bf-9b0a53e7e4cb"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 24,
    Value = 
new System.Guid[4]
{
Guid.Parse("ad648c10-68a7-49d9-940c-de42be96d694"),
Guid.Parse("6abaca67-fc48-4f4e-82ee-cca20b63c07f"),
Guid.Parse("cc7baa97-a97d-43d0-94ed-7e504d11d2ea"),
Guid.Parse("59831717-1bae-4d0f-aa4f-6713b3fae4cf"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ce544f02-8cbc-445c-b035-8694a62551fa"),
Guid.Parse("825bd842-39a6-4b3f-ae90-d288e45dc6e7"),
Guid.Parse("524eda16-fb09-4c75-8db1-8e02dbcdbe0b"),
},
},
            new GuiduuidArray1M
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("45cd05ca-da6a-4b38-8a5e-6acb8a19a50c"),
Guid.Parse("1cbe708b-1b27-48ac-a17f-0ba8ed0dfd2f"),
Guid.Parse("b9b0aa1d-5664-4ced-9232-c8ea8a803f3b"),
Guid.Parse("68842a4d-ec25-448d-a1b0-d6fae17aac2d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 23,
    Value = 
new System.Guid[3]
{
Guid.Parse("59cca3db-2d7d-4efa-b169-0418fad739ca"),
Guid.Parse("9646cb1d-a965-4ffc-ba8d-3c99e52f21e5"),
Guid.Parse("0985468f-c225-4f52-a114-f28a6866eb6c"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ae9da2e2-340d-48d4-94e6-e84ed329d1ee"),
Guid.Parse("c021f9b8-8875-4745-8aa9-e1e1ecd42aa8"),
Guid.Parse("92edbc61-bbc7-42d4-ae0d-9348a0585c1a"),
Guid.Parse("f4bbd7b1-28f3-4e9d-a419-8093b1fe7237"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 34,
    Value = 
new System.Guid[3]
{
Guid.Parse("82772266-5837-4f77-a75a-2311878d154d"),
Guid.Parse("5d9329d0-fd7b-413d-a8c0-340ce6e82360"),
Guid.Parse("9d675813-4ff9-49ff-8e06-4a0e9612a13f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("f6a7263d-ea91-46ed-874a-055be2a4ced5"),
Guid.Parse("9ac00db5-12b9-48e2-bd64-6faf683015b6"),
Guid.Parse("4e28fff1-2177-4a81-959e-083a5deb6488"),
Guid.Parse("1309c9e9-512b-464f-9804-c78758156c0a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("385cd906-02dc-4748-b0ad-330948ada129"),
Guid.Parse("e50861a6-87f5-4cf8-915d-f2e1efdf37c7"),
Guid.Parse("4860db48-664e-43fe-8717-e238dfd591ee"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b0565f91-be08-4a7c-8d28-0d14ef1b280d"),
Guid.Parse("1ff16369-8ff1-4d24-9902-a4435286a3d6"),
Guid.Parse("afc5ef90-f95e-4564-8d00-d94958d63c2e"),
},
},
            new GuiduuidArray1M
{
    Id = 50,
    Value = 
new System.Guid[4]
{
Guid.Parse("db1b6d2c-405e-47d0-97fa-c56307d95915"),
Guid.Parse("f0b077ba-7b55-4195-90cb-fc6d1810bd1e"),
Guid.Parse("edbd7079-32af-4baa-bb04-ea1bd2dd91b4"),
Guid.Parse("bdb0e157-261a-4ea7-822e-d1e6aec3f0e4"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b658ef41-2284-4ad8-9665-f16065d0604a"),
Guid.Parse("abeeed2f-d826-4f80-a586-6c187f00e71f"),
Guid.Parse("9d13757b-e445-431a-8383-e99850a25b84"),
},
},
            new GuiduuidArray1M
{
    Id = 59,
    Value = 
new System.Guid[4]
{
Guid.Parse("24de8853-b16b-417b-84bc-b9a06d27243d"),
Guid.Parse("ae571a9b-010a-45a5-9495-c7006f93b2ae"),
Guid.Parse("1ca293c6-945b-49be-8071-0a067c8febb3"),
Guid.Parse("e66e6a27-97cf-4c21-b102-2665d0593ec2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("703367dd-bcb3-4316-98e5-ae4e7d0512f4"),
Guid.Parse("cf0ad687-4405-43f1-8739-5f80df94d685"),
Guid.Parse("b98afe6b-ecf1-46fa-bf0f-50f867ba601d"),
Guid.Parse("95fe9761-13db-4a56-b513-acf68703a9fc"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ff162624-acce-4433-8c83-201cd5e5d258"),
Guid.Parse("680bfab0-6b4d-40e5-b0d0-237c342f1a4c"),
Guid.Parse("2b4ddf2b-dfbd-41a6-bc24-779492a39a41"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("79a9cb4b-3586-4dc5-a124-32d870272958"),
Guid.Parse("b51c9372-b571-47e7-8f2f-ae4a01ce973c"),
Guid.Parse("976efe14-06b2-43ec-aa3c-e123d65ad478"),
},
},
            new GuiduuidArray1M
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("94b68f0f-b1ef-45aa-ad7a-7606606e04bb"),
Guid.Parse("82232c1f-301b-4eb7-9905-11b79ff3e2de"),
Guid.Parse("30d47078-6896-498d-a9b1-a059df6e4b50"),
Guid.Parse("38118646-d85c-4891-a15f-eaa5611741f6"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 71,
    Value = 
new System.Guid[4]
{
Guid.Parse("064c41e5-f9f8-410e-9292-daf8b92a4411"),
Guid.Parse("08053e76-6da4-470f-926d-5740b6c75793"),
Guid.Parse("89062a74-5fa4-462a-8e65-27de8bdfc5af"),
Guid.Parse("84579a11-e08c-40fb-be02-e5dad90f99c9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 42,
    Value = 
new System.Guid[3]
{
Guid.Parse("1893947e-9619-49fa-9478-a053e0faf9ff"),
Guid.Parse("39e83a10-209a-48b6-a728-1c119b733702"),
Guid.Parse("73054e6c-f6b9-4e37-b78c-478bf3386ae6"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("cbab929a-b4d5-4ae7-ac1a-9d0d2ab7c274"),
Guid.Parse("4523425e-d4de-4df2-9528-d8c3f41222d9"),
Guid.Parse("67fb4732-afe5-413d-8316-72e8be81c60d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("74d81c42-af8b-4357-aa24-21344004c0c7"),
Guid.Parse("ad179701-63b9-4ea1-9286-a8b85be6d024"),
Guid.Parse("111482c5-32c2-4905-a10e-2a532bc788f7"),
Guid.Parse("30d5d9dc-67a9-4d53-af19-8356c0af8903"),
},
},
            new GuiduuidArray1M
{
    Id = 84,
    Value = 
new System.Guid[3]
{
Guid.Parse("b7e90b21-2c7f-4e03-a00e-65ef29072950"),
Guid.Parse("dd345a33-2dd9-4ca7-8577-da99f89d38e7"),
Guid.Parse("06110947-639a-4adb-9f87-10700dfc4e47"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 50,
    Value = 
new System.Guid[3]
{
Guid.Parse("6e5aa5f6-694e-4a64-b9a0-8925c2bca282"),
Guid.Parse("77c58a98-c2ba-4241-98f9-1211de8b21fe"),
Guid.Parse("9fbd9265-8407-4c71-a8e0-bf1ff1f3d4ea"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9bf33d7d-a702-4395-9f65-2af26fa8b875"),
Guid.Parse("6bad139c-32f0-4aa9-852e-a79c5f07c12c"),
Guid.Parse("237d02e1-76af-47ec-99f7-dacb2c0c4356"),
Guid.Parse("db426038-d39a-4c81-9f5e-e7f9acefb768"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 92,
    Value = 
new System.Guid[3]
{
Guid.Parse("a561bf9b-ca74-4383-a841-a24954db9268"),
Guid.Parse("b96ecc8c-910c-40a3-b41e-5a4df8ccd033"),
Guid.Parse("e9c71f39-bc28-4298-bdaf-421fd1c56e07"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("81b8347b-9f4b-4372-a653-ae20f0acfc96"),
Guid.Parse("a29d9161-6c9b-44fb-8405-b42d3b3c7471"),
Guid.Parse("b71896bc-7acd-43f2-b5dc-bf332f6cf0bb"),
Guid.Parse("6f929623-ac0b-4190-b7e0-7b2aa4f55e6a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 56,
    Value = 
new System.Guid[4]
{
Guid.Parse("c422be3e-34d8-4987-ad41-3050c93e054c"),
Guid.Parse("3a52f619-b7b2-4029-a754-2d2ec95402ab"),
Guid.Parse("ec611fcd-318a-49da-bdc5-21eaa3ea1102"),
Guid.Parse("4c53b07a-7177-4f1e-b967-385b0b7ec769"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8189b98a-a7f2-4558-97b0-4837c831b1de"),
Guid.Parse("01c6ab6b-4361-401d-916d-492a039b2d4a"),
Guid.Parse("85fd12ea-e4fa-461c-b209-b9108d75ed37"),
Guid.Parse("5e72a350-ace3-4214-98ef-0c96eb113ebb"),
},
},
            new GuiduuidArray1M
{
    Id = 102,
    Value = 
new System.Guid[4]
{
Guid.Parse("4097c8e0-fe19-4174-9c0b-4a4e7138f666"),
Guid.Parse("6ac3ddda-ca12-4e7b-962d-f1ceadcd3f7b"),
Guid.Parse("a521d761-145d-4ce7-a19c-2693effabe28"),
Guid.Parse("0bf6bd15-ed00-4616-8109-c36a87d1246b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bffe4bf0-362d-4895-b851-4317fa9dca6e"),
Guid.Parse("5f757db3-6211-4c6b-8f47-aa7ab143a909"),
Guid.Parse("77828a1e-c2ff-479b-a2b1-7255bd779ffb"),
},
},
            new GuiduuidArray1M
{
    Id = 107,
    Value = 
new System.Guid[4]
{
Guid.Parse("b82e21fa-fe92-48f8-a22a-2e5ac6f4d6c5"),
Guid.Parse("b3bd7d3a-e8e6-4cb0-8bee-b8176986e90b"),
Guid.Parse("2d6e1b33-f1de-4025-abf1-07cbf8871eec"),
Guid.Parse("6f75c4cd-a670-4b94-aa43-1bdd1f513684"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 57,
    Value = 
new System.Guid[3]
{
Guid.Parse("b0153497-cf1e-430b-b093-f1bb5fc6be89"),
Guid.Parse("cc2c857a-6b2a-4fc4-b89f-353374cf62bf"),
Guid.Parse("7aa5e156-75cd-4c3b-b6b4-8b850022dd94"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("48d3062c-f81e-4d5a-b744-7895014db94b"),
Guid.Parse("15007152-e2a6-4543-be08-65e5a0c4e6c5"),
Guid.Parse("e1489f4b-3a86-4faa-bc7a-86b3dcd16e4f"),
},
},
            new GuiduuidArray1M
{
    Id = 112,
    Value = 
new System.Guid[4]
{
Guid.Parse("216fc870-3cd4-4e79-a4e0-e011033bce33"),
Guid.Parse("a59d687b-5fc9-41ce-ba48-0466add36794"),
Guid.Parse("4db35569-58c6-426e-a76f-7a2b7b556013"),
Guid.Parse("4d63f66e-ba70-4c4b-a529-b121f524d745"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 113,
    Value = 
new System.Guid[4]
{
Guid.Parse("49c6dd5b-a9d5-42d0-b66a-ad0c2d7dda7d"),
Guid.Parse("8f6d914c-b646-4c33-8f4f-59035dc96982"),
Guid.Parse("3855593a-e729-43f1-abdd-cc994105319e"),
Guid.Parse("2dbc650b-0062-4a5e-9254-8367371a6894"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 64,
    Value = 
new System.Guid[3]
{
Guid.Parse("ae6c96fc-76fd-435d-ad68-69340527a842"),
Guid.Parse("85090f5f-162f-4877-8c8b-37ca6a02b8e4"),
Guid.Parse("f7087bec-0f29-4074-be0a-f45a34424395"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4671a2e0-a818-4ef4-99bc-0339e8aa9113"),
Guid.Parse("cfd99035-9259-4f66-8092-39d0c64110c7"),
Guid.Parse("2fcc5865-1bbc-461c-a4ba-3b8111232186"),
Guid.Parse("7eeedb3f-9b0d-4179-a7f3-da923163a412"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6cd50fe7-4cdd-4279-a819-5f2a8ec788f3"),
Guid.Parse("dfed4350-d6f2-4ce8-9e10-722c800b0364"),
Guid.Parse("95ec8c5a-c336-42d6-8027-2929520a208f"),
},
},
            new GuiduuidArray1M
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("e54f64c6-cb09-4c1a-9f94-3b2695159a45"),
Guid.Parse("0a9b7d18-a621-488a-b3e8-055303b4cf00"),
Guid.Parse("66aac683-b883-46cb-8ebd-8fe10bc1c80d"),
Guid.Parse("acfd1711-994a-4692-9b9c-23b7bfe274ee"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b89b02ba-a659-4f3d-840c-e5e3ecd07352"),
Guid.Parse("def0efa2-bd86-454c-9a38-831b7d1f5af0"),
Guid.Parse("b1a0e145-0021-40f8-b54e-e8b56fe5b752"),
Guid.Parse("2fea1fb9-de86-4e2e-b3f4-1b8634abd18f"),
},
},
            new GuiduuidArray1M
{
    Id = 116,
    Value = 
new System.Guid[4]
{
Guid.Parse("8f05bc48-0b6a-4cb0-95cc-e392aa06fb55"),
Guid.Parse("5845448d-92c4-479b-ba81-27abfa28d399"),
Guid.Parse("3bb40968-40d9-4586-b3af-18ad38c95746"),
Guid.Parse("04ff837c-1c9a-4239-98f5-1527b87734e0"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 70,
    Value = 
new System.Guid[4]
{
Guid.Parse("7d96f5ad-4e23-4c51-94de-2af483fe17d4"),
Guid.Parse("10501ed6-faff-4696-b82e-88c58304d21e"),
Guid.Parse("b9c4f6fb-3920-46cf-be19-f51980bf5558"),
Guid.Parse("05786108-ac76-4e3a-b75f-8c7dbf96ce7c"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("50ae850b-dcc7-4725-bca7-0e94aeabc85c"),
Guid.Parse("70f7ee62-3f46-423a-badd-1fb0273cc924"),
Guid.Parse("7f0e8edd-d59b-467a-af95-bf47e7ae9295"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 118,
    Value = 
new System.Guid[4]
{
Guid.Parse("9bb685a1-6e3b-4697-9aad-9385a5ac17e4"),
Guid.Parse("82d816bc-6989-49c3-9dd6-4dddb77cd412"),
Guid.Parse("66efa2fc-9763-4f06-8892-8f59eb39ef4f"),
Guid.Parse("2d7ca250-0e17-4989-905c-c13a9b43f186"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 123,
    Value = 
new System.Guid[4]
{
Guid.Parse("ead84998-ab21-4343-8d13-ec357335bf31"),
Guid.Parse("8e90e3a1-1a3f-4c06-977a-c9aba5b104de"),
Guid.Parse("659c7785-d153-4cdb-883e-ebe12bad5afb"),
Guid.Parse("5a01fc57-a0cc-4bd6-9f9c-a742a4f1ae0d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 76,
    Value = 
new System.Guid[3]
{
Guid.Parse("6f9d0a75-6f42-421e-97fa-302456310204"),
Guid.Parse("cd742624-c2a1-4267-86d6-63cd44130b06"),
Guid.Parse("f4ca021a-a4e6-4171-847b-609187637ea8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c66ef060-5733-4a22-a53b-5ea5c63b8d4f"),
Guid.Parse("07881dac-4c0c-4d93-b141-31cc3da737fc"),
Guid.Parse("4765ed2b-842a-4f50-8fb0-f28ec4f25518"),
Guid.Parse("e6e72ee7-d3cc-4f15-8158-e57b6731bd11"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 132,
    Value = 
new System.Guid[3]
{
Guid.Parse("c3121861-b32c-4596-838a-16773dbff0f4"),
Guid.Parse("e82121eb-7612-411d-adc1-3770c4af0e6d"),
Guid.Parse("bedd8b2b-08fe-4f7c-9e9e-c8a7e7ec5991"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6579fac5-7e55-47c7-9bb2-84f95f0cabec"),
Guid.Parse("51ed9743-b1a2-4528-a09a-cc643d26f9d5"),
Guid.Parse("fe2edf6a-cb5d-4c4e-93ea-649a929e2716"),
},
},
            new GuiduuidArray1M
{
    Id = 136,
    Value = 
new System.Guid[3]
{
Guid.Parse("fa6150a2-91f4-4316-a2a9-90b355a28e6e"),
Guid.Parse("568a00b3-51b7-4fb3-8942-4ff50284ffce"),
Guid.Parse("84572659-3a69-4063-b7c8-b30a162f7121"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("69f0ecf4-8af8-4f73-ac5f-439edc7ed60c"),
Guid.Parse("73953e64-911e-44ea-aa48-5d2ec54872d2"),
Guid.Parse("6328f388-35ce-4d2a-a6dc-a96fa04ddc31"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("19a49786-4437-4640-b751-73c954efdb46"),
Guid.Parse("321a4f65-24b0-49c8-9f68-ececb7b0e198"),
Guid.Parse("4a46b744-be2d-4fa4-b80b-b6400f291039"),
Guid.Parse("c03bb05c-150f-4cbb-97ae-fcc2dd530098"),
},
},
            new GuiduuidArray1M
{
    Id = 141,
    Value = 
new System.Guid[4]
{
Guid.Parse("1bc2e0f8-19e2-417f-aa99-2d4ec16dfe56"),
Guid.Parse("02026f46-fa6d-4fb5-9775-ac018e471aba"),
Guid.Parse("c7ca82c4-9dec-4f8e-86c6-60f4a92f03c1"),
Guid.Parse("715dd666-3509-4d93-9ac8-b6d131c58939"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3a76096d-4d11-48d5-9b75-21fe2064efe7"),
Guid.Parse("1455ebf2-6912-4034-9008-6732cc7cec3b"),
Guid.Parse("94531320-9571-48b5-8aaa-5f189f7613ce"),
},
},
            new GuiduuidArray1M
{
    Id = 149,
    Value = 
new System.Guid[4]
{
Guid.Parse("7e826358-91e4-4c1c-a98d-75d5ba6ac5a3"),
Guid.Parse("c6be5621-ba0b-4e87-8170-b0d924e5a572"),
Guid.Parse("d09edd44-3b46-487e-8e28-5b9789eaf577"),
Guid.Parse("3a0cb344-e8e4-4a48-b43e-c38877148e7c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 85,
    Value = 
new System.Guid[3]
{
Guid.Parse("e45b1409-dd21-4cc3-b4b3-8210af204009"),
Guid.Parse("7852f373-2870-4395-a1b1-b9de0692ed8b"),
Guid.Parse("49363d08-fa59-4903-b461-7556f77e72bb"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("750604cb-1e2d-4207-9e07-5951ff494db6"),
Guid.Parse("166c24a3-14aa-42ce-a381-87a432128dc9"),
Guid.Parse("9e7ef2cf-289d-426c-af67-1293c06b9398"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 151,
    Value = 
new System.Guid[4]
{
Guid.Parse("d667a1cf-9f84-4433-95ce-082b5cb34bfc"),
Guid.Parse("793070f4-62f7-4a7c-8070-ffe7468d2a90"),
Guid.Parse("65ecfd5f-2d51-4a1d-b8b4-38e35e0bb4f2"),
Guid.Parse("d56712b7-541e-4128-ad7a-d449e3fd2990"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("18f78b05-fc20-4397-b082-e9a1a3631954"),
Guid.Parse("1a826297-885a-4d14-a033-04abeb7f48cd"),
Guid.Parse("919b0769-e8ca-474b-b151-9acdd17b643c"),
},
},
            new GuiduuidArray1M
{
    Id = 160,
    Value = 
new System.Guid[3]
{
Guid.Parse("a9e32063-22b9-40f3-903b-9584aa6868c0"),
Guid.Parse("b823e4f8-f104-4502-ad69-2bed4c58fd9d"),
Guid.Parse("1a6a51c3-5ea1-41d9-a5e8-77dcc07d761d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 89,
    Value = 
new System.Guid[3]
{
Guid.Parse("db3afcb2-9a2b-4a6c-9db8-16077d2453ea"),
Guid.Parse("4c42d3df-4e66-42b0-9e5b-1531f4965894"),
Guid.Parse("81a1ee65-d9c1-4cea-aaa3-1f3d7276af87"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("50dc44d4-31d2-4083-806d-fd263ef801e6"),
Guid.Parse("c73ffba2-d7e4-419b-903e-09c12764a5ac"),
Guid.Parse("460bf31a-72de-4411-9dc0-61c6f26fe7a4"),
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("ce544f02-8cbc-445c-b035-8694a62551fa"),
Guid.Parse("825bd842-39a6-4b3f-ae90-d288e45dc6e7"),
Guid.Parse("524eda16-fb09-4c75-8db1-8e02dbcdbe0b"),
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
Guid.Parse("b0565f91-be08-4a7c-8d28-0d14ef1b280d"),
Guid.Parse("1ff16369-8ff1-4d24-9902-a4435286a3d6"),
Guid.Parse("afc5ef90-f95e-4564-8d00-d94958d63c2e"),
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
Guid.Parse("b658ef41-2284-4ad8-9665-f16065d0604a"),
Guid.Parse("abeeed2f-d826-4f80-a586-6c187f00e71f"),
Guid.Parse("9d13757b-e445-431a-8383-e99850a25b84"),
}));
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("79a9cb4b-3586-4dc5-a124-32d870272958"),
Guid.Parse("b51c9372-b571-47e7-8f2f-ae4a01ce973c"),
Guid.Parse("976efe14-06b2-43ec-aa3c-e123d65ad478"),
}));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
            overrideAliasPrefixs: ["item1", "item2"],
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: ["item1", "item2"],
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[30], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[30], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        GuiduuidArray1M.AssertModel(models[0],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidArray1M.AssertModel(models[0],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidArray1M.AssertModel(models[0],_testData[1], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[2], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidArray1M.AssertModel(models[0],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[29], false);
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
            overrideAliasPrefixs: ["item1", "item2"],
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 136, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 24, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 50, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 79, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 107, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[29], false);
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
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 34, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[30], false);
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
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 132, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[29], false);
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
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 84, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[30], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 50, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 132, 149))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidArray1M.AssertModel(models[0],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[29], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
GuiduuidArray1M.AssertModel(models[0],_testData[16], false);GuiduuidArray1M.AssertModel(models[1],_testData[17], false);GuiduuidArray1M.AssertModel(models[2],_testData[18], false);GuiduuidArray1M.AssertModel(models[3],_testData[19], false);GuiduuidArray1M.AssertModel(models[4],_testData[20], false);GuiduuidArray1M.AssertModel(models[5],_testData[21], false);GuiduuidArray1M.AssertModel(models[6],_testData[22], false);GuiduuidArray1M.AssertModel(models[7],_testData[23], false);GuiduuidArray1M.AssertModel(models[8],_testData[24], false);GuiduuidArray1M.AssertModel(models[9],_testData[25], false);GuiduuidArray1M.AssertModel(models[10],_testData[26], false);GuiduuidArray1M.AssertModel(models[11],_testData[27], false);GuiduuidArray1M.AssertModel(models[12],_testData[28], false);GuiduuidArray1M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
GuiduuidArray1M.AssertModel(models[0],_testData[19], false);GuiduuidArray1M.AssertModel(models[1],_testData[20], false);GuiduuidArray1M.AssertModel(models[2],_testData[21], false);GuiduuidArray1M.AssertModel(models[3],_testData[22], false);GuiduuidArray1M.AssertModel(models[4],_testData[23], false);GuiduuidArray1M.AssertModel(models[5],_testData[24], false);GuiduuidArray1M.AssertModel(models[6],_testData[25], false);GuiduuidArray1M.AssertModel(models[7],_testData[26], false);GuiduuidArray1M.AssertModel(models[8],_testData[27], false);GuiduuidArray1M.AssertModel(models[9],_testData[28], false);GuiduuidArray1M.AssertModel(models[10],_testData[29], false);
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

