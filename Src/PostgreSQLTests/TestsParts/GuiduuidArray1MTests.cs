

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
new System.Guid[3]
{
Guid.Parse("04e2c668-40d2-4d5d-bb81-d15061f29cd6"),
Guid.Parse("273aed7e-34f0-462e-9e51-245fa92695ba"),
Guid.Parse("6c5e22bc-019e-4fe3-82f9-c4b5e748e3ec"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 7,
    Value = 
new System.Guid[4]
{
Guid.Parse("605448c0-4567-4b60-9311-54ff7fb156a5"),
Guid.Parse("02ac2b43-4900-401e-8074-ad7b65f26e3c"),
Guid.Parse("ea9ca781-eb54-46ea-84fa-9ea1fa3a0e15"),
Guid.Parse("0955fb04-9929-43b6-9f6b-dc4dfbd3e23d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 6,
    Value = 
new System.Guid[3]
{
Guid.Parse("a40fbd33-ce70-4019-8720-cfa38c59f0e5"),
Guid.Parse("b5544b23-0d60-462c-90da-b4ea6a798d9a"),
Guid.Parse("bc7fe849-428f-4c6d-9f28-6f9197470aed"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("929b0cdd-916a-4b5a-966d-f88c9fd4de1e"),
Guid.Parse("f73014c2-9867-4c5f-84b2-67671ac4ce4a"),
Guid.Parse("cfa7c461-28fc-4ed9-a8e1-ade860d910b9"),
Guid.Parse("95623fab-49e8-4c13-a4bd-ad25b239e8da"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 8,
    Value = 
new System.Guid[4]
{
Guid.Parse("c1290c64-93cd-4bdc-8cc4-b75fb570ed0a"),
Guid.Parse("32b4a02e-dda0-48f6-b7fd-76908a96867f"),
Guid.Parse("fccda7be-7d31-47d6-9bc6-af4b30c77059"),
Guid.Parse("7d38c6c7-365a-4da4-b0d4-28e4a26aa0f0"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("41ce9939-b116-4dca-91d8-1f2a926486fc"),
Guid.Parse("3cb215d8-745e-40d5-b2fb-de6b14eafc95"),
Guid.Parse("e35116de-2594-4fa5-9af9-e8794e02eaf4"),
Guid.Parse("4b691bb3-7f7c-4fd3-ae02-ace62090100f"),
},
},
            new GuiduuidArray1M
{
    Id = 17,
    Value = 
new System.Guid[4]
{
Guid.Parse("0ae84def-e203-43a7-a7f4-ce6cfcb3ea63"),
Guid.Parse("742a2bed-bba3-4049-8671-09973e64e1b9"),
Guid.Parse("80f741d1-35b0-4e55-999e-13f4fe286f19"),
Guid.Parse("d1b8690f-3dab-4a86-b248-7c1e6e67a9db"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 7,
    Value = 
new System.Guid[3]
{
Guid.Parse("90fad73d-16f7-49c6-8903-51201b092f0a"),
Guid.Parse("3c7189f6-69d8-4450-b7b4-938ee6246149"),
Guid.Parse("9a2853c6-7548-469e-8517-a28d76ff7253"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9939fc38-0c9f-4ec0-b541-f87e30d71432"),
Guid.Parse("a5f35753-ee0c-430a-b1e2-9b17b0a43d90"),
Guid.Parse("0c217f9f-fcd9-49a8-8025-33268f417417"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e3e6518a-7c55-4bc6-82be-26335b4d221f"),
Guid.Parse("8fd73572-ce37-417b-ab3d-68562d4bfc79"),
Guid.Parse("03ac7726-8d27-42d0-b32f-02c49a11a468"),
},
},
            new GuiduuidArray1M
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("62a9cb62-5c8d-49e5-a60c-81fcbe40640f"),
Guid.Parse("5e4aaed1-3896-448c-b17c-77e30bc10f26"),
Guid.Parse("2ae2be20-9253-4cd0-9341-3dc77a557ff2"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 27,
    Value = 
new System.Guid[3]
{
Guid.Parse("3239d120-a3f8-41f8-b3f4-3032bffe39a4"),
Guid.Parse("0fbdbc80-93ec-41a8-b268-4d92c055cb5e"),
Guid.Parse("cf7da40e-34d8-476a-b324-be09c3a34413"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("588c0129-a631-46e5-bae8-07c395841d17"),
Guid.Parse("1d8d3653-1631-4f89-a832-c3c639a9944d"),
Guid.Parse("9d933419-d33e-4a00-9a5b-571d73c8a2d2"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("edf269fa-6241-472b-8c0b-acf5c8fe1ef6"),
Guid.Parse("d3189af4-c0dc-4cd0-b7b2-fa66c7340b87"),
Guid.Parse("94889e73-dd41-4097-84fa-7d1f9b17ceb6"),
Guid.Parse("72dd3840-9446-4959-9e8d-d5dd5aea08dd"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("da6c2dfc-ec3f-49c4-b275-3dc1b13b0ca9"),
Guid.Parse("125fc331-d2b0-488a-be7d-c2b572abbc6b"),
Guid.Parse("a4f0d3c4-527d-43a8-88e1-46c13ad46981"),
Guid.Parse("32791095-dcda-429c-b2cb-7c6c9ffba8d7"),
},
},
            new GuiduuidArray1M
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("031a5044-ab44-436f-9b58-7a7132014249"),
Guid.Parse("88d7fb67-22ec-47cf-b836-4209352c7b89"),
Guid.Parse("1edcbacd-5eb1-492b-9bf0-dbc42474aec8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("360f9039-f16c-428c-811a-b9866c6d8d27"),
Guid.Parse("f1a35462-fda7-4771-83df-482d4b562be1"),
Guid.Parse("807fd6aa-6837-47cd-a44c-e269bcdb5e2f"),
Guid.Parse("e360c537-0f51-43ad-8982-d4a9a25771f8"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("33cd3702-463e-446c-8e79-319240d80e01"),
Guid.Parse("c678321b-288f-4217-a57e-d8b34a936da7"),
Guid.Parse("7bec7f1d-b39b-40c6-82a9-76d9d134b4c3"),
},
},
            new GuiduuidArray1M
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("ceb62b41-339c-4fbf-ad5e-49b1ddcb5de9"),
Guid.Parse("54d42b90-b543-4240-bfe1-607de25a1949"),
Guid.Parse("0a265e8b-2bbb-495a-9eb7-909f51fe59e1"),
Guid.Parse("d61ee1cd-1af0-41b5-98e7-67fe50ea38e2"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("48f0c50a-31e9-4d8b-8daf-f04da2a2f271"),
Guid.Parse("807978c3-1b02-4559-8601-1f6024c29c71"),
Guid.Parse("5b16ece8-2076-4883-97ba-514331174265"),
Guid.Parse("26327b02-921e-407a-adb8-b950b53532b4"),
},
},
            new GuiduuidArray1M
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("d470d837-7a23-439d-9337-19711de604d2"),
Guid.Parse("120bf46c-030c-433b-8f3a-c76113a16061"),
Guid.Parse("d04c6793-9be8-4731-a466-01cdc9b9dd15"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 28,
    Value = 
new System.Guid[3]
{
Guid.Parse("5820f967-b75e-4a91-ad4e-7f1db304a6e7"),
Guid.Parse("f1f5a80f-5388-4ad1-b347-6c9a4f3d42c6"),
Guid.Parse("872fcaf8-c537-4bd6-97f9-3cd285eaef30"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 44,
    Value = 
new System.Guid[4]
{
Guid.Parse("607471fa-4d44-4506-8b1f-31345d388455"),
Guid.Parse("fe5724c4-df8c-434c-9edf-af2afb2c6409"),
Guid.Parse("fb565b02-6b61-49bb-9c44-823a85ee9612"),
Guid.Parse("cadc109e-5ac5-4834-8ff2-1b008316faee"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 51,
    Value = 
new System.Guid[4]
{
Guid.Parse("ccbb5e82-1ed0-427e-ad2c-9a947f9dec6f"),
Guid.Parse("26f9357b-6243-41d2-8ec3-beec8ed9b7a3"),
Guid.Parse("370ab356-af87-4d61-a09e-4a3697d6aa94"),
Guid.Parse("bc366f64-e30e-4722-bed2-219cf5b62b0b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 30,
    Value = 
new System.Guid[4]
{
Guid.Parse("91d5cf50-c9fb-462c-bf2d-e4dafe840f13"),
Guid.Parse("cf9529b0-fe48-42dc-add0-8a518f483412"),
Guid.Parse("1d083471-79ec-4f24-8461-2626872ca30f"),
Guid.Parse("2b3e7052-bca3-44a4-913f-d2f1656ce8fe"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f30df7f2-f1eb-459c-b9d0-051869fd24f5"),
Guid.Parse("dff6a36a-8b36-4394-a07e-dc3ccea44316"),
Guid.Parse("e7dd462c-a6f3-4564-bf09-00fc39f455f1"),
Guid.Parse("76097de8-bae0-42e6-b792-721abc1589ce"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b834c766-d370-4f8d-b49f-357479ada51b"),
Guid.Parse("20c0765a-d91f-4b8b-862d-c887eee8b0c8"),
Guid.Parse("0f6b79d7-ce86-4f32-bee4-0298a00267e2"),
},
},
            new GuiduuidArray1M
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("ffd3144c-5402-48ed-a2cb-979ad35964d6"),
Guid.Parse("367374c6-b13c-4fa4-8bca-599c49b6326b"),
Guid.Parse("a95b5cb0-4ef7-4107-8e66-9da8704fb7ea"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("51e103df-5882-47fa-94a8-2340d5a0bf9e"),
Guid.Parse("7552ebde-2b67-4ac3-8802-f944d17390ab"),
Guid.Parse("e46ec74f-8828-4b64-9243-9c68cde45331"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("51150301-51df-47c4-b59f-41e4698873bb"),
Guid.Parse("231e2262-18af-4e92-9df8-8c7d182a01e5"),
Guid.Parse("0f4bf402-4eaf-470c-85b1-002172d7972a"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8c488485-f86f-4b4a-8d8a-0385e99f448e"),
Guid.Parse("8feb496d-f6fd-4c99-89d9-a7db552938ab"),
Guid.Parse("e0068564-3778-48f0-86d9-b3edafc2e22a"),
Guid.Parse("0a119a09-c36e-45bf-acaa-c8c44957ff09"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1a19c856-0e9e-4a57-8f97-3c154d396f70"),
Guid.Parse("2cbdbb80-deb7-480c-b72a-b4a1a973153e"),
Guid.Parse("171e7fb9-c0fb-42f1-838b-88043b299692"),
},
},
            new GuiduuidArray1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("a9a44e5d-6d4e-4ac9-880e-43af4538922b"),
Guid.Parse("0b4036ae-30c7-4d1c-8b2d-b0cac1b5f41c"),
Guid.Parse("cce51041-3cb1-4f8d-9289-a655f2bee238"),
Guid.Parse("af2f689d-8c64-4c10-b05c-571125252da3"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 81,
    Value = 
new System.Guid[3]
{
Guid.Parse("6ed0cb71-54e8-4b33-bab8-b71044dfef5d"),
Guid.Parse("1679e915-e61d-42e1-b822-5408d65a085e"),
Guid.Parse("b0aa9179-d679-472f-88ea-7813d2efdb2d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 46,
    Value = 
new System.Guid[4]
{
Guid.Parse("7d3d7403-5ec9-40e7-a42f-bb45d509d902"),
Guid.Parse("a8aa4c42-7063-4fb5-9085-c805afaeaa63"),
Guid.Parse("6bf4cc20-d099-44cf-a6f3-c4a5397cd021"),
Guid.Parse("eca395a5-1b59-4889-bf56-885aa497fc39"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3dd5ce0e-65d3-4554-a596-0627596cd01b"),
Guid.Parse("ad7aeb62-72db-497f-88b1-a3046e6b853d"),
Guid.Parse("9b15525f-12ed-4a36-9e52-906babe97322"),
Guid.Parse("ff28c8e4-02aa-4abe-8e93-711f6f40371e"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fbb82fc9-400d-4fd7-9a2c-1f84c2c6595b"),
Guid.Parse("b773ad87-831b-438d-9ca2-507bae5df87c"),
Guid.Parse("7f864c7f-5744-4a77-8ef0-23f6b414e962"),
},
},
            new GuiduuidArray1M
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("803e8ebe-6da4-4b1e-99c2-b28f980f7a16"),
Guid.Parse("194def27-21f3-45a3-b7ec-04d4a658f88c"),
Guid.Parse("9908ad28-d369-4950-ad79-1a3b58d6b18a"),
Guid.Parse("e62317b4-3057-4e67-8f96-258bd64033fb"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 95,
    Value = 
new System.Guid[4]
{
Guid.Parse("c9c08387-cf8f-4430-b36c-06288500a974"),
Guid.Parse("51fe61b7-9e83-44c3-a940-598da5ff09dc"),
Guid.Parse("67f78638-d7ab-455a-b3c9-203055097235"),
Guid.Parse("d701ae16-77f3-40cc-84a7-9c9e0beb5e38"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 52,
    Value = 
new System.Guid[3]
{
Guid.Parse("e30ddfe4-20c9-40c5-b1f0-1d36dcaa1527"),
Guid.Parse("33affdec-16f7-4df7-a296-1a94b4b437cc"),
Guid.Parse("f4a4e146-9e61-42b5-9c41-dae343470877"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 102,
    Value = 
new System.Guid[4]
{
Guid.Parse("02a0661c-f98d-40db-9ee3-873a3feb6c75"),
Guid.Parse("c80a8055-8566-4f20-a2a5-ab2fee0860b8"),
Guid.Parse("d6706005-2575-45b5-987c-3879934ea73e"),
Guid.Parse("0ea52cb9-b873-490a-955a-c997d2614429"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e2f62226-e01b-4f2f-8dea-0dbc5d6d58f2"),
Guid.Parse("906105f8-6e4d-4dff-a569-3f219ef1cea9"),
Guid.Parse("5d036df1-3510-4a8a-8855-102271620bee"),
Guid.Parse("3942ed62-92ca-4104-b684-eeca42808307"),
},
},
            new GuiduuidArray1M
{
    Id = 110,
    Value = 
new System.Guid[4]
{
Guid.Parse("27f7b76b-6827-4866-b87c-91772580abce"),
Guid.Parse("e28195db-e618-4955-b03f-318d352d78dd"),
Guid.Parse("38216edb-aba2-448a-9e83-12da6b7c46b4"),
Guid.Parse("c1aa8279-6d6a-4b33-8493-69e51d71daea"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("687c305e-312e-41a5-8054-1c49450aca7d"),
Guid.Parse("7e019e45-17f7-4595-85f8-3d430d77e787"),
Guid.Parse("c6b1c15e-b33c-49e2-bb13-ed70c983adbe"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fa7fb591-c400-4808-94df-095d1b70e2c5"),
Guid.Parse("9a2cb0df-1e0f-4169-9c94-2c00554dfb02"),
Guid.Parse("a1a17396-0c5b-4cf8-9541-6d7eb49d32e3"),
Guid.Parse("4a2256c7-59d8-43b5-a93f-d42c35ee2a6b"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 113,
    Value = 
new System.Guid[3]
{
Guid.Parse("b8b23361-a554-43bc-8cb5-6749d9c7f720"),
Guid.Parse("00be3462-cc8d-40f4-a016-f0fbae4216f1"),
Guid.Parse("5046e080-659e-4a24-994f-efdaa49055d4"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 115,
    Value = 
new System.Guid[4]
{
Guid.Parse("14bd4466-bc08-4db3-8daf-129314cfa0ed"),
Guid.Parse("d45806a0-834e-4c22-a2b5-4199932f74ac"),
Guid.Parse("c8e4924b-c44b-416e-a7b4-2ee93c29d822"),
Guid.Parse("a00af015-7914-4859-92b0-712f6117e03a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 61,
    Value = 
new System.Guid[3]
{
Guid.Parse("5f0a787a-1e87-4619-9013-2feb9b9485cb"),
Guid.Parse("6ffe56f1-755c-4906-8e99-9905f42afab3"),
Guid.Parse("6894bfda-7a55-43fa-8ae2-78fb637ec53a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0bdd600d-130c-454a-afd4-8f8d5ebdf13c"),
Guid.Parse("c3e86603-e7c7-4509-b35e-270d4e9a1546"),
Guid.Parse("a239c86b-a45d-4016-99cf-5799df3e6d94"),
},
},
            new GuiduuidArray1M
{
    Id = 123,
    Value = 
new System.Guid[4]
{
Guid.Parse("a53fea8c-8025-466a-b406-774a245c34b5"),
Guid.Parse("cf4ff266-4028-45f1-9972-f09aa1fba096"),
Guid.Parse("221c092d-b2a6-40b5-93f0-e00d8594039b"),
Guid.Parse("1fa0d702-79ea-449d-9d32-a073bc3e0a4e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("56d9a0a0-095f-4c5e-a806-22a071362da8"),
Guid.Parse("6365ac5f-df62-4411-a036-650e8679b94b"),
Guid.Parse("adae8202-d814-4dfd-8e01-ba4fb6aa777e"),
},
},
            new GuiduuidArray1M
{
    Id = 127,
    Value = 
new System.Guid[4]
{
Guid.Parse("a133926b-6465-4147-aefc-d958b4414839"),
Guid.Parse("39b3fee2-1002-4458-9f66-f52a1dd0da30"),
Guid.Parse("d0193876-39e5-45bb-b699-0fe7f89fe1cf"),
Guid.Parse("b780bbd4-23ae-4c58-abe4-fae52ed516c2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("992dcf17-4ef5-4e5c-b0c0-478ae43b1b95"),
Guid.Parse("7c482965-8a0d-4ad5-a84b-99f5f0381ee7"),
Guid.Parse("680f70a0-2dc9-4e38-b7c4-6d5ab085a268"),
Guid.Parse("2ebdf477-139d-4025-bce8-b82e693976c5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e190e7de-02a3-4a94-bbaf-e4b0d21eebfe"),
Guid.Parse("ce2a831e-383c-4909-aa3c-99d0c91f49d5"),
Guid.Parse("ebe0d1a8-9175-4774-a4d4-fdc905d70be1"),
Guid.Parse("2ed515f8-afee-42e1-9295-2a80541885ae"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("537db1dc-643c-43bc-ae62-17d6ef694b53"),
Guid.Parse("5dc58bef-7590-4ad5-8a22-373a2134a6e7"),
Guid.Parse("a061496c-687f-4bf0-b334-bb5f885f40d2"),
Guid.Parse("4008c0e0-478a-4bd1-9c64-157e6ab9794d"),
},
},
            new GuiduuidArray1M
{
    Id = 134,
    Value = 
new System.Guid[4]
{
Guid.Parse("b9ae3b72-59e7-430f-9ea9-c3a0a3c8119e"),
Guid.Parse("0ae967b6-2523-4e33-9d79-c3741281e527"),
Guid.Parse("42dd19f9-fa2f-460f-8b67-c823ee1af779"),
Guid.Parse("7826f2c4-9984-46e3-b87e-9da1f2f25d91"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("411efae6-27cf-4f88-b916-49921c963693"),
Guid.Parse("755ebcc1-6e39-4e57-ba96-70447cb14dcb"),
Guid.Parse("6599e267-3494-4b5d-a682-2781071de69c"),
Guid.Parse("b7f6f99e-ef00-486e-bbdb-ddfc055f71fa"),
},
},
            new GuiduuidArray1M
{
    Id = 141,
    Value = 
new System.Guid[3]
{
Guid.Parse("e16f52a1-abcc-4517-90d1-9601ab2613c7"),
Guid.Parse("aef422c0-adbe-414d-a9d6-5b1bba7b7336"),
Guid.Parse("768abd82-a625-413f-a9cc-dd555ab06afe"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("59b14efe-c0ca-4122-8133-8a3ef621979f"),
Guid.Parse("8b9dda7b-434e-43dc-b16a-c9b57d204e2d"),
Guid.Parse("f53c4377-ee98-410f-bc45-1661c71e7409"),
Guid.Parse("74bcb4d8-091e-4eb5-9917-4879faa7644d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ec3b84ab-d1da-48fe-9e67-2e8d42daf004"),
Guid.Parse("95c67956-f902-449f-bb13-23b980a9e4e5"),
Guid.Parse("6b21b49f-2bb1-458b-8059-24debdd0b9bc"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 145,
    Value = 
new System.Guid[4]
{
Guid.Parse("a3a3352e-51b2-46d8-8a1a-628705b39ffd"),
Guid.Parse("e6ccbe11-0d03-4b0a-8f15-42dc20f57e1f"),
Guid.Parse("8d710434-bcec-448a-b3b4-4354e7c20d04"),
Guid.Parse("72470e81-9ca3-4ba9-86ae-2360aa8cc2ba"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("456fed1e-5e92-4628-be06-fb63abce79ea"),
Guid.Parse("3939b9fb-c7ca-407d-9991-1349a15a4971"),
Guid.Parse("2f7d4ef4-164f-47f5-9689-63b1ac0cced9"),
Guid.Parse("5f25cb90-7c9a-47a4-9a88-3997a06b3ed3"),
},
},
            new GuiduuidArray1M
{
    Id = 148,
    Value = 
new System.Guid[3]
{
Guid.Parse("efe667cb-302f-4340-af70-0c028460312d"),
Guid.Parse("db1c055f-c174-4505-a86b-7629835bd6df"),
Guid.Parse("1e4bf768-0033-4351-ae6d-73084bb05c88"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 67,
    Value = 
new System.Guid[4]
{
Guid.Parse("dcec1694-f80e-48d5-819f-f5dff4135575"),
Guid.Parse("4feae8ac-53ca-444a-bfce-dcb58126d4e5"),
Guid.Parse("a9964a9c-975b-41c8-a042-2307a4e4c196"),
Guid.Parse("4cfbfa38-a7d3-4428-9b4a-c2b82c2de038"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("117fe5ae-03b9-40c9-b8f2-9863b1f79eec"),
Guid.Parse("42827ae4-8fb0-492b-b7f8-1a92bd9d8309"),
Guid.Parse("3cdd4143-e62a-4427-bdf5-599337695cfa"),
},
},
            new GuiduuidArray1M
{
    Id = 152,
    Value = 
new System.Guid[4]
{
Guid.Parse("eeb37d10-004d-495a-b3ba-17c208c81a32"),
Guid.Parse("700a5e46-e59e-4c25-9446-a59fafb1aba0"),
Guid.Parse("cfabb8d7-f7e2-442b-99e1-e1ffdb9e413e"),
Guid.Parse("10cd989f-291e-42a2-928f-bf914fe60166"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0575d33c-5fb0-48bc-a072-1b67b70a5dbf"),
Guid.Parse("9fee246a-dc2f-48cb-913c-6033b5b14bd0"),
Guid.Parse("5f829f8f-ae4f-44b6-a1c6-e13e8baba014"),
Guid.Parse("32eca92c-1512-48e5-974c-4eb79b1b1f06"),
},
},
            new GuiduuidArray1M
{
    Id = 158,
    Value = 
new System.Guid[3]
{
Guid.Parse("24095463-24d4-4449-b459-9843fba8e362"),
Guid.Parse("b5a05370-1436-411d-a157-5176a278f20f"),
Guid.Parse("9faf0425-fa9c-463f-919f-4c73af47e069"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 69,
    Value = 
new System.Guid[3]
{
Guid.Parse("2a6e7247-5bfe-4092-a87a-952b03518387"),
Guid.Parse("52e931e5-8799-47e1-8445-bb1d85ba4401"),
Guid.Parse("c9e10e44-bb86-490b-8fda-40c376c03cbe"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e9b26721-332d-47a5-bde9-3ede16a1066a"),
Guid.Parse("8d69bc2e-ee96-45bc-809e-1431c7c34888"),
Guid.Parse("d5750c86-5f5d-4dbe-a2db-c24f42515629"),
Guid.Parse("21122766-4d48-4b3c-b1ea-17dabf151163"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("30904e74-7f91-478f-8ea5-a9609bdd68f0"),
Guid.Parse("5651381a-a15e-4d72-9f5d-b5342c178b12"),
Guid.Parse("7cc3aa12-c847-4b5d-b348-49b4d25db647"),
Guid.Parse("830f2747-d534-4ae8-a0b5-7bbb2edc0d42"),
},
},
            new GuiduuidArray1M
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("8ad87d06-ee68-4c62-b8f5-6bfdf17c43eb"),
Guid.Parse("0c9db625-b398-4bfb-9c9e-a70028985dc8"),
Guid.Parse("5b77ef64-8f1a-48e0-83d5-a145277ad1ee"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 165,
    Value = 
new System.Guid[4]
{
Guid.Parse("280721fd-55a7-48a2-be6d-ad6a21269e2c"),
Guid.Parse("84eaa5c3-ad5a-42b0-85de-9602ed978236"),
Guid.Parse("f0ec237b-9115-4cb6-9a2d-7b3add3bb653"),
Guid.Parse("58f07891-7bf5-46f1-9970-d5faec7c5a7e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 77,
    Value = 
new System.Guid[3]
{
Guid.Parse("920d93cc-7de9-43ac-b3cf-6f3722ca6a9b"),
Guid.Parse("57a286b4-a8b5-4883-adef-819e6eba09c1"),
Guid.Parse("9645283d-c0cd-4928-a27a-48cc9d8e88ef"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("087a0ba3-2e29-4dca-a07e-16b1d300ad54"),
Guid.Parse("0c44aaf5-d341-4845-8be6-fdd7f551aa51"),
Guid.Parse("313b682e-58b9-4e1b-9b4d-9cff4f74bda1"),
Guid.Parse("4fee2390-b1ca-4ea6-bc0b-4a669c32da65"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 170,
    Value = 
new System.Guid[3]
{
Guid.Parse("0099e03d-cf5c-4876-aee7-e4d2ca69ad1a"),
Guid.Parse("eab00620-2cfd-468a-8d1c-412a152374f0"),
Guid.Parse("d5b4a139-bc25-480e-8ae3-fe06a375368e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9d12040e-36ba-4433-a76a-28abee9ed874"),
Guid.Parse("2a43049e-b4fb-4b31-b43f-b76cfdd2bfa9"),
Guid.Parse("aaf2bf26-a169-4726-8575-099622896c39"),
},
},
            new GuiduuidArray1M
{
    Id = 171,
    Value = 
new System.Guid[4]
{
Guid.Parse("05001695-a4df-4c37-b4e0-b19d6717d436"),
Guid.Parse("b1908b5f-c2b2-4fdb-a832-8f040399bb3b"),
Guid.Parse("351ce0a2-6d39-458f-b946-822228b74d47"),
Guid.Parse("ae607f5b-b2dc-4b3e-bfb5-597521c2868b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("a699bbdb-3144-42a8-b012-35df8954225b"),
Guid.Parse("81d22164-0fa5-457f-aa05-fc0b7ccd4500"),
Guid.Parse("8717d48a-3486-436d-8837-cbdc48628f11"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 178,
    Value = 
new System.Guid[3]
{
Guid.Parse("59433958-fb23-4117-b136-9c3d07a39638"),
Guid.Parse("2e8e189c-9de2-4b5e-9ade-e77d50dc1eed"),
Guid.Parse("1c4e4268-2902-4294-a8d4-260e961c0469"),
},
    ModelInner = null,
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

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("da6c2dfc-ec3f-49c4-b275-3dc1b13b0ca9"),
Guid.Parse("125fc331-d2b0-488a-be7d-c2b572abbc6b"),
Guid.Parse("a4f0d3c4-527d-43a8-88e1-46c13ad46981"),
Guid.Parse("32791095-dcda-429c-b2cb-7c6c9ffba8d7"),
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

                    nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("33cd3702-463e-446c-8e79-319240d80e01"),
Guid.Parse("c678321b-288f-4217-a57e-d8b34a936da7"),
Guid.Parse("7bec7f1d-b39b-40c6-82a9-76d9d134b4c3"),
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
new System.Guid[4]
{
Guid.Parse("48f0c50a-31e9-4d8b-8daf-f04da2a2f271"),
Guid.Parse("807978c3-1b02-4559-8601-1f6024c29c71"),
Guid.Parse("5b16ece8-2076-4883-97ba-514331174265"),
Guid.Parse("26327b02-921e-407a-adb8-b950b53532b4"),
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("b834c766-d370-4f8d-b49f-357479ada51b"),
Guid.Parse("20c0765a-d91f-4b8b-862d-c887eee8b0c8"),
Guid.Parse("0f6b79d7-ce86-4f32-bee4-0298a00267e2"),
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
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 162;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidArray1M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidArray1M.AssertModel(models[0],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidArray1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidArray1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[32],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 67, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 170, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 32, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 134, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 170, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 17, query1, 148, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 74, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidArray1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 170, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidArray1M.AssertModel(models[0],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        GuiduuidArray1M.AssertModel(models[29],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[32],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[33],_testData[34], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
GuiduuidArray1M.AssertModel(models[0],_testData[9], false);GuiduuidArray1M.AssertModel(models[1],_testData[10], false);GuiduuidArray1M.AssertModel(models[2],_testData[11], false);GuiduuidArray1M.AssertModel(models[3],_testData[12], false);GuiduuidArray1M.AssertModel(models[4],_testData[13], false);GuiduuidArray1M.AssertModel(models[5],_testData[14], false);GuiduuidArray1M.AssertModel(models[6],_testData[15], false);GuiduuidArray1M.AssertModel(models[7],_testData[16], false);GuiduuidArray1M.AssertModel(models[8],_testData[17], false);GuiduuidArray1M.AssertModel(models[9],_testData[18], false);GuiduuidArray1M.AssertModel(models[10],_testData[19], false);GuiduuidArray1M.AssertModel(models[11],_testData[20], false);GuiduuidArray1M.AssertModel(models[12],_testData[21], false);GuiduuidArray1M.AssertModel(models[13],_testData[22], false);GuiduuidArray1M.AssertModel(models[14],_testData[23], false);GuiduuidArray1M.AssertModel(models[15],_testData[24], false);GuiduuidArray1M.AssertModel(models[16],_testData[25], false);GuiduuidArray1M.AssertModel(models[17],_testData[26], false);GuiduuidArray1M.AssertModel(models[18],_testData[27], false);GuiduuidArray1M.AssertModel(models[19],_testData[28], false);GuiduuidArray1M.AssertModel(models[20],_testData[29], false);GuiduuidArray1M.AssertModel(models[21],_testData[30], false);GuiduuidArray1M.AssertModel(models[22],_testData[31], false);GuiduuidArray1M.AssertModel(models[23],_testData[32], false);GuiduuidArray1M.AssertModel(models[24],_testData[33], false);GuiduuidArray1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));
GuiduuidArray1M.AssertModel(models[0],_testData[1], false);GuiduuidArray1M.AssertModel(models[1],_testData[2], false);GuiduuidArray1M.AssertModel(models[2],_testData[3], false);GuiduuidArray1M.AssertModel(models[3],_testData[4], false);GuiduuidArray1M.AssertModel(models[4],_testData[5], false);GuiduuidArray1M.AssertModel(models[5],_testData[6], false);GuiduuidArray1M.AssertModel(models[6],_testData[7], false);GuiduuidArray1M.AssertModel(models[7],_testData[8], false);GuiduuidArray1M.AssertModel(models[8],_testData[9], false);GuiduuidArray1M.AssertModel(models[9],_testData[10], false);GuiduuidArray1M.AssertModel(models[10],_testData[11], false);GuiduuidArray1M.AssertModel(models[11],_testData[12], false);GuiduuidArray1M.AssertModel(models[12],_testData[13], false);GuiduuidArray1M.AssertModel(models[13],_testData[14], false);GuiduuidArray1M.AssertModel(models[14],_testData[15], false);GuiduuidArray1M.AssertModel(models[15],_testData[16], false);GuiduuidArray1M.AssertModel(models[16],_testData[17], false);GuiduuidArray1M.AssertModel(models[17],_testData[18], false);GuiduuidArray1M.AssertModel(models[18],_testData[19], false);GuiduuidArray1M.AssertModel(models[19],_testData[20], false);GuiduuidArray1M.AssertModel(models[20],_testData[21], false);GuiduuidArray1M.AssertModel(models[21],_testData[22], false);GuiduuidArray1M.AssertModel(models[22],_testData[23], false);GuiduuidArray1M.AssertModel(models[23],_testData[24], false);GuiduuidArray1M.AssertModel(models[24],_testData[25], false);GuiduuidArray1M.AssertModel(models[25],_testData[26], false);GuiduuidArray1M.AssertModel(models[26],_testData[27], false);GuiduuidArray1M.AssertModel(models[27],_testData[28], false);GuiduuidArray1M.AssertModel(models[28],_testData[29], false);GuiduuidArray1M.AssertModel(models[29],_testData[30], false);GuiduuidArray1M.AssertModel(models[30],_testData[31], false);GuiduuidArray1M.AssertModel(models[31],_testData[32], false);GuiduuidArray1M.AssertModel(models[32],_testData[33], false);GuiduuidArray1M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidArrayuuidArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(GuiduuidArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models = await ((IGuidArrayuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI), typeof(GuiduuidArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models1 = new List<GuiduuidArray1MI>();
                var models2 = new List<GuiduuidArray1MI>();
                await ((IGuidArrayuuidArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MI>();
                var models2 = new List<GuiduuidArray1MI>();
                ((IGuidArrayuuidArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models = await ((IGuidArrayuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

