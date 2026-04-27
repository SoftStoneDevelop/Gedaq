

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
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("755a500c-a82b-40ef-9285-1d36af0e7bfd"),
Guid.Parse("bdff62a8-5859-4c37-a34c-d757364c858b"),
Guid.Parse("2290cff4-d044-4f52-9234-fdfde1c93244"),
Guid.Parse("58bdd164-6b14-4ca2-85b0-d0c2ee80aeb9"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e2a0b273-4cc5-4ec0-a0e5-52c2edb3d000"),
Guid.Parse("0dab7378-a4e1-41fa-9a2d-1953b0753482"),
Guid.Parse("bbf81d3c-f738-4111-aefc-492172b3a6ef"),
Guid.Parse("b3190a2c-d08a-428b-be54-aeb85e26e709"),
},
},
            new GuiduuidArray1M
{
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("d1f88001-88a3-4820-aaef-e506e0583a79"),
Guid.Parse("a1f6cd30-5e29-4921-8a21-acdaf77d9b98"),
Guid.Parse("70d107b5-41c8-4864-b924-96de96e78c72"),
Guid.Parse("2d39de58-3ee5-4790-aa58-21f73dec0ecf"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("01747132-5c7b-4c4e-a781-fc265f9f46e7"),
Guid.Parse("562e0a5e-da86-464e-827e-acea50ec7473"),
Guid.Parse("df23bd86-8f61-4459-be0b-bd5bb39f217e"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("74201c6d-52d6-46fc-b802-84d43a53d39b"),
Guid.Parse("cec307e9-5322-4d63-8209-bb6e056d8ccc"),
Guid.Parse("6c5a2a66-67b8-4fdf-b6f3-cd5feeb4a174"),
Guid.Parse("30f3805a-efcd-4c72-b838-6866d8a28bdc"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 11,
    Value = 
new System.Guid[3]
{
Guid.Parse("c09e1f6b-c371-453c-b0a4-dffc5c212890"),
Guid.Parse("bb32bdc7-9b81-44a3-bdc5-2fdc1790f5bc"),
Guid.Parse("453e07f1-a3a6-4edd-b899-b7c47a6ee988"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e131c6e0-1cdd-4c97-9f2f-9cf935f40038"),
Guid.Parse("e8e35687-cd1f-4cd1-be12-1c18e8d9cb1d"),
Guid.Parse("d3214996-5fd2-47ca-a564-49701033e9ba"),
},
},
            new GuiduuidArray1M
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("a1287a1c-0232-4bbf-99eb-c9ac10ed6dcc"),
Guid.Parse("c11c70d2-6f38-49d1-9b2e-f613f1a0e4f5"),
Guid.Parse("06c5f2a1-6cc6-42b1-af83-126035fb1b13"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 15,
    Value = 
new System.Guid[4]
{
Guid.Parse("381c8ca7-01b7-4333-b6e5-372aab6ba5f7"),
Guid.Parse("dc9fbe11-c5da-4de5-8a66-466d5c462a8e"),
Guid.Parse("ae956051-76cd-466e-8bfb-72c11f54d101"),
Guid.Parse("ae3697cd-440c-481d-8269-501eccbebb2d"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0e68aa77-1a35-4fd4-8330-8efb9638b56c"),
Guid.Parse("f500d670-8c67-489b-8750-b12ffaa7dd55"),
Guid.Parse("7e0e5d8f-38c5-45aa-b80b-678e98660a9a"),
Guid.Parse("a4c0a287-2e60-4c98-906b-e3f7b2bb4c3a"),
},
},
            new GuiduuidArray1M
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("d400f956-a138-492d-9421-11f2cfe5f421"),
Guid.Parse("05b82e54-8092-491a-94f2-640e2b606c42"),
Guid.Parse("6c8e1602-28ca-4581-8452-1e43e391c0b2"),
Guid.Parse("83710885-978d-4940-b0d1-1e077c83a09c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ec267ba5-5f53-4663-9a3b-89d9b2ab53d4"),
Guid.Parse("916fbd0e-fdec-4f02-852b-b21f8d6622c4"),
Guid.Parse("0a3d203f-54cf-4dbf-9c3a-d2e87aa710e1"),
Guid.Parse("2fdd13aa-3f9d-40b2-8e4e-1369f32e8765"),
},
},
            new GuiduuidArray1M
{
    Id = 23,
    Value = 
new System.Guid[3]
{
Guid.Parse("03345075-c0d5-4ff0-a48e-6fae26ae1a88"),
Guid.Parse("f8576291-3bf7-4a49-a280-74eb6a12ca53"),
Guid.Parse("8061033b-c4a1-4086-b7e1-63c0a6ab0b83"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("8379f3f6-a38a-49e7-842c-6e7952787115"),
Guid.Parse("a396b27d-e383-45b3-8a7d-aee406cca102"),
Guid.Parse("a22d0b2c-627f-4427-a9c7-2f858462ff15"),
Guid.Parse("2c201ffe-e05a-4a95-99be-e5b84c0333ac"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 26,
    Value = 
new System.Guid[4]
{
Guid.Parse("a7381b84-025d-4097-b68a-71100f1fe308"),
Guid.Parse("8319a9ae-fee2-44a1-9cc9-8e24593e4b5a"),
Guid.Parse("b01ccadb-44ca-4cbb-b1ad-a7ea66627b25"),
Guid.Parse("7ea710bd-d631-4dcd-a9af-dc3b0e6dfd64"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("50b4c876-3d92-4a89-adf5-0dd2a0c5281c"),
Guid.Parse("607c2052-f5cf-409e-a2b3-d0305077e1b5"),
Guid.Parse("231a5d47-be0e-400d-9f1b-ed8998ccfcaf"),
Guid.Parse("11df06f7-1ab6-4081-87bc-ac9b9f328ea4"),
},
},
            new GuiduuidArray1M
{
    Id = 28,
    Value = 
new System.Guid[3]
{
Guid.Parse("9bd13c1d-7d88-48b0-a4a1-508f07dd7e08"),
Guid.Parse("1a046887-043b-43e1-8798-93c7f219cdce"),
Guid.Parse("5f7aa9b2-62f3-4fc1-8794-e03dae85c6cb"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("b323f3bb-44fd-46b1-8672-563fa07bffe5"),
Guid.Parse("fde447a5-72d0-4eaf-a79d-58fec87b800d"),
Guid.Parse("7d25de57-786f-4b8f-84f8-704a38073cb6"),
Guid.Parse("44756081-4d53-4e6b-a093-d2543fa19b64"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("cb4dbfd4-97a5-4639-bc04-51edfa8b0cc5"),
Guid.Parse("7e35c2e9-30db-44ee-8f1c-723242327d57"),
Guid.Parse("c7678a47-f724-4704-bb24-cf513285e222"),
},
},
            new GuiduuidArray1M
{
    Id = 31,
    Value = 
new System.Guid[3]
{
Guid.Parse("d25629ad-f719-4281-ac3b-49078c3beeb7"),
Guid.Parse("89b2751e-d696-4477-ab08-bcc6fa6d9204"),
Guid.Parse("194c0279-bd17-44dc-881e-eb4202d53ab3"),
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
Guid.Parse("51448cbd-8e15-4f64-ae4b-120367616ef8"),
Guid.Parse("ba8883a4-b089-43a7-9ef3-414623d3d2bf"),
Guid.Parse("243f846b-acb5-4ebb-b108-b1272c8ca70d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 34,
    Value = 
new System.Guid[3]
{
Guid.Parse("b234ef14-6a6b-4405-94cf-a94b0b50f7bb"),
Guid.Parse("49905cda-8bac-49dc-be27-94487e0ed02c"),
Guid.Parse("03f0ee7f-b7ce-47e0-9b98-33f35a0c56a2"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("320c6148-05f5-4636-bc6f-28f4e90bb93f"),
Guid.Parse("2895b2b5-a06c-4875-a38e-d5ed89254580"),
Guid.Parse("6c302be4-acd2-4860-9cce-04108949d265"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f2e70f80-8555-4d91-9e5d-4f38850a57c0"),
Guid.Parse("180b3c8a-76cc-4782-86cc-49059d46f7b5"),
Guid.Parse("c7d68e24-e5c3-438d-89a8-266304608993"),
},
},
            new GuiduuidArray1M
{
    Id = 41,
    Value = 
new System.Guid[3]
{
Guid.Parse("6b9e1963-b29a-4e1c-8eb3-1d16f97fc00e"),
Guid.Parse("674390f0-a3d2-430c-bb0d-aa35685b0d24"),
Guid.Parse("cd15feb7-030a-4b2a-baf7-5e0577885900"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("ef79e636-f625-402c-b7c6-50b1da3aa81e"),
Guid.Parse("72f168e8-f4da-43f1-85cf-5ea61b04229f"),
Guid.Parse("b65aab1c-db41-423f-97a1-51a54906dde2"),
Guid.Parse("4f57518f-ee28-489a-bc7d-3b76de32a819"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3120d7d0-4c09-44fa-824f-6724564baa6c"),
Guid.Parse("62747964-cf00-48d7-b7ba-412645f7a17c"),
Guid.Parse("b2f988a3-5494-43cb-86d3-5ba290ede37b"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 47,
    Value = 
new System.Guid[4]
{
Guid.Parse("53043e41-e674-423e-873b-a3464f746c48"),
Guid.Parse("f62386bc-4622-4825-abc7-f2ddf4ab80c5"),
Guid.Parse("3f78ad69-6e0c-4903-a4cb-7384e8e91707"),
Guid.Parse("3134b88f-6398-460b-8a67-c0c6e26dae3b"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("0007c16f-17e4-4e3b-971d-ad167134bf6e"),
Guid.Parse("d5de7ae6-f8b1-419f-acf1-2f61d2b09ee3"),
Guid.Parse("474dc0d8-50e1-49a1-82af-fd06b9e6be99"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 37,
    Value = 
new System.Guid[4]
{
Guid.Parse("fc55debb-1cf7-4776-8a2b-d2e19ded4a64"),
Guid.Parse("85e6a2ba-7339-457d-88f0-b9d67afe6437"),
Guid.Parse("bb42d3a4-4c90-4a39-9fea-df4faa2812b7"),
Guid.Parse("0adfa723-837c-4ffb-b48c-cb874465d4d2"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("eef59df4-25da-4cea-8491-e927e0587143"),
Guid.Parse("ce48b61d-e213-4e10-a0c1-7578ad3fb852"),
Guid.Parse("b2ec4c12-b60a-4691-acfc-8eca2c88a6a8"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("682401d9-eb7a-443a-9e98-51deed4c6a46"),
Guid.Parse("88fef743-9b55-4d00-a071-6b022dbb3028"),
Guid.Parse("5c842af4-57dd-4406-bcb0-caec62ab466b"),
Guid.Parse("aaf716a2-639f-4f3e-ab8c-410aa7f4b17b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c9a817af-84ce-487c-a483-c9f66c38ecd5"),
Guid.Parse("b5faaf6f-891a-4f5c-98a0-585b66cdc173"),
Guid.Parse("6ae364cf-8cdf-4364-b636-43360b45e547"),
},
},
            new GuiduuidArray1M
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("26cae913-3d37-4ce1-8209-4d1c6d935f79"),
Guid.Parse("0e733259-4900-4fae-9b3e-29e185aa87b6"),
Guid.Parse("448d8251-a345-40ad-93d0-6b7dfde0400b"),
Guid.Parse("ab5dcf5b-5795-487b-b1f7-544611b58cbf"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 44,
    Value = 
new System.Guid[3]
{
Guid.Parse("ddb9b769-ba47-4614-8337-87c175d02a75"),
Guid.Parse("09ff7eba-0aa2-4547-beec-60ab9794216b"),
Guid.Parse("17f03090-f970-4ddd-9d0b-2b3c270288fe"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4f556945-cb0f-4446-aff2-f988363f8169"),
Guid.Parse("29fe93ee-f6fc-4312-beab-04dd2e0d40ec"),
Guid.Parse("d5d12132-2184-44e8-a386-9729fef01c32"),
Guid.Parse("50b9ee7c-d58c-4f22-9bac-7635ace54aa3"),
},
},
            new GuiduuidArray1M
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("aa689331-c495-4c4f-a02c-c1953457d7bd"),
Guid.Parse("b2ec1e46-4eca-44b1-8976-f7e171f1a5fa"),
Guid.Parse("9e3324a5-2605-4dbe-b002-c787a7281a4b"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 69,
    Value = 
new System.Guid[3]
{
Guid.Parse("fea562d9-f172-4c95-862d-45776bad54a6"),
Guid.Parse("69205387-8a85-4412-9aca-193f6e5c63c0"),
Guid.Parse("a84bdce6-d6b6-4657-9391-b827a8b2d529"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 51,
    Value = 
new System.Guid[3]
{
Guid.Parse("4580839e-f9af-4f6a-84cf-d92f9564109f"),
Guid.Parse("ebfbb7fa-5744-41cf-8949-42a084e2b6b5"),
Guid.Parse("756ee2f5-da79-4d54-a5da-63f67a6910ae"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2128f84a-6e2f-4efe-847d-7818db7eda8d"),
Guid.Parse("38deffa7-6dae-4c70-82c8-755fdc7a7450"),
Guid.Parse("a10c39cb-90d8-4190-b7a7-72cc6e927155"),
Guid.Parse("502c455c-6fd7-430d-bbcf-11fe962f9e4d"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fd5c953b-a6e8-45c1-8612-b67e57358adc"),
Guid.Parse("77635d70-d856-4648-8f16-8c5a191fc805"),
Guid.Parse("b6eb0e64-bb86-45a8-aebc-3b9f91f607d1"),
},
},
            new GuiduuidArray1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("ac66b495-c312-432f-9c91-2fd16059ef7d"),
Guid.Parse("6c39e33f-05de-45c1-9475-d8fa32547a19"),
Guid.Parse("9054f7af-e75f-436b-8a65-126cee81dccb"),
Guid.Parse("f31fe8a6-e0eb-4bc1-ab1b-f024da4da8e0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 75,
    Value = 
new System.Guid[3]
{
Guid.Parse("a906fd46-d82e-4d19-8df3-aa25cf0aad67"),
Guid.Parse("efd9f89e-9e58-4cd1-8aa7-bc365c9f61cc"),
Guid.Parse("5ea05e4a-8a32-4797-a3a2-4c7da1993d6b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 57,
    Value = 
new System.Guid[4]
{
Guid.Parse("3cde5ed1-a61a-4fdd-8ca8-f4ceeece4ced"),
Guid.Parse("ceb8f237-415b-4bf3-bb64-c30fd13ca9d7"),
Guid.Parse("d32a2487-d546-40f5-9a53-87f1c26e4fc0"),
Guid.Parse("835b7eab-bdcf-4811-9742-71752bacb446"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fcb79690-6308-4de5-9f43-593341dd0372"),
Guid.Parse("6d0f673f-f2db-4f60-9aa7-a77bc74aca56"),
Guid.Parse("696b4346-ae2b-4070-b463-eef3c20bfeb3"),
Guid.Parse("15112d77-423b-4366-8de9-a4f495a6b418"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e5483d07-db7b-4069-a01d-858a1f4879c1"),
Guid.Parse("63d86d07-e87f-436c-8512-8ef7e5a80e1a"),
Guid.Parse("7bdff5fc-3257-43d5-81d4-dd1123274ce5"),
},
},
            new GuiduuidArray1M
{
    Id = 77,
    Value = 
new System.Guid[3]
{
Guid.Parse("77a51a20-19b8-48e4-aca2-5e77af93b4a9"),
Guid.Parse("10ad572a-d05e-4e7a-8b0e-75903bdf1512"),
Guid.Parse("6997019d-a877-4435-9f0a-f1dcd6a5a3aa"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 86,
    Value = 
new System.Guid[3]
{
Guid.Parse("df86e93e-f5e4-4fdb-9e13-0926e9eef018"),
Guid.Parse("82421798-e136-439e-8db5-c525dae55997"),
Guid.Parse("9f3d962d-3663-41f5-ae93-94da1199aff2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("ba85108c-a335-4498-9e59-1b61167686aa"),
Guid.Parse("bb4b8fd1-d0a0-4c7b-842f-33f899354f02"),
Guid.Parse("25e6856d-35d0-4276-906b-7ce93e718e7f"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("631ad673-2f75-4db6-9075-6bcf5d54454f"),
Guid.Parse("a0961e0a-ae8a-416b-b188-23dec1afa5c2"),
Guid.Parse("b61d98fd-a081-42e5-bb5b-df6e5852ea6f"),
Guid.Parse("ef338ba3-3ec2-4ce8-a378-955d98cb73ed"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 90,
    Value = 
new System.Guid[4]
{
Guid.Parse("0c45f780-dc04-4ed7-bcbe-b5811064dfa0"),
Guid.Parse("af006cf6-b3bd-4903-acda-22a5a3423f2c"),
Guid.Parse("eadb3d85-1bf9-4440-aa5a-9538f93b2f05"),
Guid.Parse("f4b8566b-b4cb-405b-bc78-f920ea52096c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2489096b-7ef1-4aa3-bc7a-79dc5879e7a2"),
Guid.Parse("81639f4e-f0b5-40d4-b006-900983254634"),
Guid.Parse("55ab7ca0-38c7-455b-af00-9b20b9f73e3b"),
},
},
            new GuiduuidArray1M
{
    Id = 91,
    Value = 
new System.Guid[3]
{
Guid.Parse("44b208b4-33e0-474a-8ebb-01d061a2defc"),
Guid.Parse("c4def86d-6642-4820-b1b8-865418f04025"),
Guid.Parse("76036da5-e913-4488-9854-ba9a19f5e4aa"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 69,
    Value = 
new System.Guid[3]
{
Guid.Parse("f69a8aaf-e0cb-4e9f-a1d4-4706cc1c0bd3"),
Guid.Parse("5cbaeab5-364e-4e68-b1c6-fc1db0a32256"),
Guid.Parse("208cfb45-98cd-4fc2-9c8c-889c45a81bd6"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ad7464c8-19d4-4b9b-9ab1-b7858573450e"),
Guid.Parse("a13ea129-72e6-48c1-b8b4-b3c9942dad26"),
Guid.Parse("f86eabe7-e6db-4e60-bd48-94765b05e768"),
Guid.Parse("8c62ef6b-6631-40cf-9771-c1260ed00d38"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2d0c14ec-2dcf-46d3-b601-22fe0176ea80"),
Guid.Parse("01c08030-8019-4e54-a0ee-85ccd80f7e5d"),
Guid.Parse("0ad277b5-f4be-4e1f-9ab6-eba3db2587b5"),
Guid.Parse("b095aef3-0452-4f63-8f38-6abd932b443d"),
},
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[3]
{
Guid.Parse("3e9af138-4e09-4a2d-bca9-ee96513cd239"),
Guid.Parse("ed23fce4-ea22-42cb-93af-35fdcefde4aa"),
Guid.Parse("31482a1e-4bbf-43b3-bf26-23193724620e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2164dbfb-c7a0-42f3-b09f-a6828e31fb36"),
Guid.Parse("83988d57-e6a5-40ce-8340-b7aa604ffe52"),
Guid.Parse("86c41b5d-b0ed-4bee-b5d1-db5f3b91c620"),
},
},
            new GuiduuidArray1M
{
    Id = 105,
    Value = 
new System.Guid[4]
{
Guid.Parse("59e42022-0124-4e36-8ff7-419d5ae83573"),
Guid.Parse("634ee839-690d-406e-9c5e-643183ff7359"),
Guid.Parse("507482c7-98a0-4482-a88f-1fc0eed44f45"),
Guid.Parse("d55f34e2-5d7d-4b01-8fd2-72ca2e3e379e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 77,
    Value = 
new System.Guid[3]
{
Guid.Parse("28c5a1f8-ff4f-47e3-b5b4-7322864cd8a7"),
Guid.Parse("bb5fe5cf-26f7-4288-9d2f-812e7669418e"),
Guid.Parse("81367779-56ff-4d94-af9e-2d104850d029"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 108,
    Value = 
new System.Guid[4]
{
Guid.Parse("2e1621a6-2435-4710-81c1-424c7238b54f"),
Guid.Parse("1671ffdc-472b-4f6e-8d19-8160dfee61c6"),
Guid.Parse("bd8f6538-0cb6-4128-80a7-ecb5f9f3784c"),
Guid.Parse("6a77b410-7392-4a49-88b3-54d4c67fc638"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 112,
    Value = 
new System.Guid[3]
{
Guid.Parse("2dd18876-a7d5-4b42-97f5-075b897a0594"),
Guid.Parse("3e322593-ae87-47e9-ad30-7d44a84b74fd"),
Guid.Parse("efd24ecd-9f07-4a79-b0b5-335b46e54e40"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 85,
    Value = 
new System.Guid[3]
{
Guid.Parse("f6e803ff-e1a4-4f38-bb5a-07139615f7ed"),
Guid.Parse("d6f530a8-bf89-41a4-8c74-6de6c9ced0d8"),
Guid.Parse("36ca9b45-db1d-4f0d-8965-75291416b8a0"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d45efb91-6661-43cb-add3-71d6071415b6"),
Guid.Parse("e1bc04b8-46d0-4470-a727-396f3f81b5e1"),
Guid.Parse("d3b39fee-02ba-465b-8791-74d6f65bb0c0"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("aea12f60-5d81-4c23-b16b-21f6f7e90c86"),
Guid.Parse("e465d657-85b8-4a88-840c-3ab1a18c390e"),
Guid.Parse("087e96c1-7777-4062-a166-2e3141fa0f76"),
Guid.Parse("8b0bd84b-4b75-49ed-82fb-2893172de420"),
},
},
            new GuiduuidArray1M
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("3282950a-d1f6-4478-a45f-73db3076624b"),
Guid.Parse("29a172bc-dc22-42ce-b517-0ce0c33350d1"),
Guid.Parse("412960b8-f355-4947-b420-3f193686740f"),
Guid.Parse("789fce7e-7090-4d01-96f0-640cae7877a2"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3d278383-8ffe-4d00-bf31-5ede036d1c98"),
Guid.Parse("93f8f252-9a56-438c-a482-56e6fd093b8f"),
Guid.Parse("ba5a6b2d-a5f7-4e74-ba85-9f361a52b6b1"),
},
},
            new GuiduuidArray1M
{
    Id = 115,
    Value = 
new System.Guid[4]
{
Guid.Parse("88b3a9ad-4dcf-4388-88ad-4ccd984d557f"),
Guid.Parse("19b79bae-1af1-4e41-9042-f7bd578ab6da"),
Guid.Parse("4778d1cb-41e0-4261-a3a6-676ff633a7ac"),
Guid.Parse("390447fe-f1b1-4a02-9415-5173ac4d9bc2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("51f44186-4d8a-4842-86e5-81dde15ccd9e"),
Guid.Parse("9cf6214d-b874-4277-b150-6c687a8c63bd"),
Guid.Parse("7c3481a7-bd78-4437-a79a-2236c4a300af"),
Guid.Parse("e023e505-18f7-4fef-828a-76faccba4b8a"),
},
    NullableValue = null,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("ec267ba5-5f53-4663-9a3b-89d9b2ab53d4"),
Guid.Parse("916fbd0e-fdec-4f02-852b-b21f8d6622c4"),
Guid.Parse("0a3d203f-54cf-4dbf-9c3a-d2e87aa710e1"),
Guid.Parse("2fdd13aa-3f9d-40b2-8e4e-1369f32e8765"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("50b4c876-3d92-4a89-adf5-0dd2a0c5281c"),
Guid.Parse("607c2052-f5cf-409e-a2b3-d0305077e1b5"),
Guid.Parse("231a5d47-be0e-400d-9f1b-ed8998ccfcaf"),
Guid.Parse("11df06f7-1ab6-4081-87bc-ac9b9f328ea4"),
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
Guid.Parse("cb4dbfd4-97a5-4639-bc04-51edfa8b0cc5"),
Guid.Parse("7e35c2e9-30db-44ee-8f1c-723242327d57"),
Guid.Parse("c7678a47-f724-4704-bb24-cf513285e222"),
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
                Assert.That(nullable, Is.Null);
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
Guid.Parse("f2e70f80-8555-4d91-9e5d-4f38850a57c0"),
Guid.Parse("180b3c8a-76cc-4782-86cc-49059d46f7b5"),
Guid.Parse("c7d68e24-e5c3-438d-89a8-266304608993"),
}));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                        Assert.That(models, Has.Count.EqualTo(26));

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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidArray1M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidArray1M.AssertModel(models[0],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidArray1M.AssertModel(models[0],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidArray1M.AssertModel(models[0],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[29], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 11, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 48, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[29], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 41, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[29], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 86, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 11, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 18, query1, 4, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[29], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 91, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidArray1M.AssertModel(models[0],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidArray1M.AssertModel(models[0],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 28, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidArray1M.AssertModel(models[0],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidArray1M.AssertModel(models[0],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[29], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
GuiduuidArray1M.AssertModel(models[0],_testData[10], false);GuiduuidArray1M.AssertModel(models[1],_testData[11], false);GuiduuidArray1M.AssertModel(models[2],_testData[12], false);GuiduuidArray1M.AssertModel(models[3],_testData[13], false);GuiduuidArray1M.AssertModel(models[4],_testData[14], false);GuiduuidArray1M.AssertModel(models[5],_testData[15], false);GuiduuidArray1M.AssertModel(models[6],_testData[16], false);GuiduuidArray1M.AssertModel(models[7],_testData[17], false);GuiduuidArray1M.AssertModel(models[8],_testData[18], false);GuiduuidArray1M.AssertModel(models[9],_testData[19], false);GuiduuidArray1M.AssertModel(models[10],_testData[20], false);GuiduuidArray1M.AssertModel(models[11],_testData[21], false);GuiduuidArray1M.AssertModel(models[12],_testData[22], false);GuiduuidArray1M.AssertModel(models[13],_testData[23], false);GuiduuidArray1M.AssertModel(models[14],_testData[24], false);GuiduuidArray1M.AssertModel(models[15],_testData[25], false);GuiduuidArray1M.AssertModel(models[16],_testData[26], false);GuiduuidArray1M.AssertModel(models[17],_testData[27], false);GuiduuidArray1M.AssertModel(models[18],_testData[28], false);GuiduuidArray1M.AssertModel(models[19],_testData[29], false);
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

                Assert.That(models, Has.Count.EqualTo(2));
GuiduuidArray1M.AssertModel(models[0],_testData[28], false);GuiduuidArray1M.AssertModel(models[1],_testData[29], false);
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

