

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
    Id = 1,
    Value = 
new System.Guid[4]
{
Guid.Parse("140a0647-4667-4c0b-8d97-7b045d104967"),
Guid.Parse("71a4f767-1b29-420b-a2b8-f63498ec5c95"),
Guid.Parse("c444324b-04a4-4b10-9cfd-0b61d8e03a9a"),
Guid.Parse("5353557b-9d7f-4625-a203-c86e6f86f651"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("e41ce00e-9265-4631-a2ff-0d48d185c12e"),
Guid.Parse("b32be8c9-01a9-4e52-a95b-0794f2ba9bfe"),
Guid.Parse("0b9c268c-d651-45a8-b921-cc3958561540"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("0def5890-edcb-4427-9808-98e6bb791f6e"),
Guid.Parse("88abd2b0-dfc3-4c3b-8fe6-a68bdde22506"),
Guid.Parse("abbbc651-500b-4342-9b53-5686b4d6f956"),
Guid.Parse("7d2ff3c9-d6ae-4b36-adc9-7ac15eb9669f"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Guid[3]
{
Guid.Parse("fc0cd0f0-e40d-4641-9d90-97211261af00"),
Guid.Parse("c7a10adc-e11e-409d-b66d-ec2bea6a9291"),
Guid.Parse("33b54c47-9abb-474b-80b1-85b726461738"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Guid[3]
{
Guid.Parse("bb8af867-f8d2-405c-b5d3-275d447a9654"),
Guid.Parse("73d26ea4-573d-4ab4-9a8e-5c00f0eb53cd"),
Guid.Parse("d2c31f9c-abb8-43ef-9616-8a0ce135b6ac"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("6020aa67-8fbc-4fbc-8a0d-4b24744b22f0"),
Guid.Parse("e2d4ff68-92cb-4165-bb49-1bdca8a76484"),
Guid.Parse("b7f3d5a7-c0cc-49d6-91ea-ddd7aebfd05b"),
Guid.Parse("b2733836-4c0a-4399-be29-efc147f3acfc"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("83b9531f-14da-497d-b219-f6b5494c6205"),
Guid.Parse("5cc3549b-bf04-45de-a71a-711838b86e9a"),
Guid.Parse("59097e4b-56ef-4c9b-8957-7bf19299be24"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Guid[4]
{
Guid.Parse("7831b5f2-ffa6-4811-8c68-bf5305591ee6"),
Guid.Parse("048f7d45-dcf4-4b02-9ab6-1cbbd0ce4027"),
Guid.Parse("cd1fbe25-04c7-4b27-981f-0d9babcc1973"),
Guid.Parse("2643edc7-a9eb-4c9c-9cac-ea8079cd020f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f7f591b9-7c6c-4b08-85cc-fc264b8c0e08"),
Guid.Parse("5c3d7de7-4ae0-4d02-8544-6fe2b0a5133a"),
Guid.Parse("0578ff29-d7bc-4c7c-9b14-30a8b85656d2"),
Guid.Parse("fc0a9067-1a85-4450-9b6a-bcf87f27c4ce"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Guid[4]
{
Guid.Parse("70d847f6-6136-4683-b3dd-bfb1e1721319"),
Guid.Parse("1ea83a74-48e3-455a-9a2a-132147af4f6d"),
Guid.Parse("d1250bf7-b55e-4937-b29a-77f6e5062ca8"),
Guid.Parse("5cb57b2d-a056-4e5d-9d0e-a4fd27f2c546"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("91899cc8-5a14-4ad7-9c26-d88e38332bf7"),
Guid.Parse("5ade54d3-b682-45f2-b381-8436f35c8bc8"),
Guid.Parse("7d9abc19-a56c-4631-9ad0-68e253ea7064"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5b85283e-a470-454a-a594-1f2ae4e708cc"),
Guid.Parse("2a90dfff-757d-47ac-b720-f07b08c809f2"),
Guid.Parse("0d43ea18-eb40-4910-a0fd-8559e8e07d13"),
Guid.Parse("f354ed53-e4ff-4b3e-94c4-3895216441b8"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Guid[4]
{
Guid.Parse("eb7a3888-08ff-419d-8bb8-7df049518059"),
Guid.Parse("c334a81b-d4c1-4024-9bad-1841b3f704d3"),
Guid.Parse("67dba545-f50c-4401-929b-ebc747be6ab7"),
Guid.Parse("19655f87-48b6-4efb-8625-9a65c8e9691a"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Guid[4]
{
Guid.Parse("436610be-4c61-4e05-a077-882481423973"),
Guid.Parse("4850ad89-b1f1-4a28-bfda-d8421c3012a2"),
Guid.Parse("1b9b1b44-caec-46db-9c9d-1e1ec5efb831"),
Guid.Parse("7aa2965e-4bff-48e4-aa24-7e9b56bb0f4f"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("f6e62d62-5005-44b9-a0e7-2feccb479f6e"),
Guid.Parse("c48e2abb-bc13-4e38-ae0c-43de35f6b1e6"),
Guid.Parse("fd7b81b5-9c51-46c5-a1b0-834c8eb44e28"),
Guid.Parse("b69e9fd1-a5ea-4542-9c21-1a1b77c6c750"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("dc3f3dbf-0523-452b-a244-1d4c789d41ab"),
Guid.Parse("76ac640d-1c1d-445e-9bcb-91ad275807e3"),
Guid.Parse("086a0e4e-fbdc-441c-83e6-de1bdc80a475"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Guid[3]
{
Guid.Parse("4d24c2fa-f18b-4483-bc04-1cee30045a1f"),
Guid.Parse("0cd42936-dd50-4ab6-b130-77ef65f7a67a"),
Guid.Parse("9f3f2d20-917f-4b0b-9268-23d6f283dd0e"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Guid[3]
{
Guid.Parse("eeed9779-94c1-4afd-a484-e7dac444a7ee"),
Guid.Parse("228eddae-ab11-4ded-b059-9f970be397de"),
Guid.Parse("05ca5fb5-08ff-4b0d-a2df-b76de8c03de0"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Guid[4]
{
Guid.Parse("0642dd6a-b33e-4ed0-9acd-0e892ccae316"),
Guid.Parse("6012f2f1-ff8d-4b0a-a64f-5c8d9923247a"),
Guid.Parse("f63ad5b0-e24f-4b24-b247-89e446d434f3"),
Guid.Parse("517236e4-1ce0-4231-8126-cc0d94b7d594"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("541d914f-bb8d-409d-b5c9-cca8b0cf44a1"),
Guid.Parse("8ba3720d-e892-455c-90e3-bcbcde65c3cf"),
Guid.Parse("2b528338-8ca4-4ea7-995d-f2843eb01f6e"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0b81c637-2982-430b-892f-1bfa9b510c59"),
Guid.Parse("85aa2ce4-d9a7-4d47-8fd0-be3bde6b32d4"),
Guid.Parse("ddcb54d7-452a-4f72-adab-907f49e92473"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 57,
    Value = 
new System.Guid[3]
{
Guid.Parse("6ac637da-468a-47b7-8b85-a7c603d915ff"),
Guid.Parse("9291efac-20ab-4658-be18-f56889166ce3"),
Guid.Parse("56f20ad1-fd23-40da-8eb6-693c7a0d9530"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("52601ffa-1236-4900-b787-6657db3f8e2d"),
Guid.Parse("86fcbc62-8b87-4373-99a9-ca6b2be07ccf"),
Guid.Parse("48d1b507-1ea0-441f-8f19-ec4d201daa0b"),
Guid.Parse("2748934a-8eae-47da-adad-b2252167dbb5"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Guid[3]
{
Guid.Parse("5054d761-e78a-44e9-ae88-184e795f1fb9"),
Guid.Parse("5341ce8f-1eb4-48e0-b776-be1cfbfe09b5"),
Guid.Parse("9ef62ca2-a365-4a3e-a57a-9cb618702be8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d602803e-d726-4fd4-a722-58a22e9495c9"),
Guid.Parse("0037e5fd-80e5-4ff8-8ce1-334fd82a05c6"),
Guid.Parse("f41671b8-d466-46ee-98aa-b7a147561e42"),
Guid.Parse("8279ba7c-b4c6-43d8-98d9-9114a9599801"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 69,
    Value = 
new System.Guid[3]
{
Guid.Parse("c056bf32-901a-41db-8444-cddd40780ef1"),
Guid.Parse("f3134177-f51b-4fe5-a254-05b3b8a7eab7"),
Guid.Parse("807b5d85-cebf-4f7a-8d29-2bd1fd20cf9a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9ffe9f6f-99d3-4b45-ab47-601ed94fc1fb"),
Guid.Parse("3eed8e55-ced9-434e-9f5c-53d08abc2854"),
Guid.Parse("760f48ee-eaef-46a2-9567-14324f0c54ce"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Guid[4]
{
Guid.Parse("445cd212-489d-4dcb-8f7c-d8cacdc7c81a"),
Guid.Parse("4b5d078b-f50e-4e28-b042-c33eed599e7c"),
Guid.Parse("7f5cc184-77f5-40de-a1d7-9e694d921e01"),
Guid.Parse("e6daf1eb-4ea8-462d-a84b-f049a181b65f"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("76f2da85-4534-42e7-af26-286aebae023e"),
Guid.Parse("6719d441-8e25-47ba-b66a-5eb3fef39de3"),
Guid.Parse("f3681db9-8726-4bd3-8233-9a762f969043"),
Guid.Parse("91d51098-8cb3-4c13-9312-78489aa22a38"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5e2add3f-e5bb-4393-af0b-bcf2395caea9"),
Guid.Parse("387c3e90-8466-4706-876e-34cd8ba14dd4"),
Guid.Parse("3d549a7e-68ba-44bc-95fa-505c09b0bc1c"),
Guid.Parse("46e4c72a-abb2-471a-b345-e120f4d4edc0"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("e1bd3a5f-d088-41f0-844d-e1a1a118f2fc"),
Guid.Parse("17b6e3d1-bd09-4e3d-8647-11d2aac256c0"),
Guid.Parse("3dd7b593-c008-40b9-9dd6-2d4c733eaf5e"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Guid[4]
{
Guid.Parse("4236b219-f2bc-43a2-aaba-6476691a766c"),
Guid.Parse("6a2fb099-c04d-4eda-880f-cb3ce0d322f7"),
Guid.Parse("d0d56541-1e22-4840-82e5-32c2416f0d77"),
Guid.Parse("96861a27-c4ef-4523-b4e1-823e1af55c18"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("17eab215-e8ab-453d-bb60-1a951a29eafc"),
Guid.Parse("a08606fc-7979-48ea-84c8-8f42b6dd5cef"),
Guid.Parse("076d8f52-2487-4e29-8c20-72eb0f848f3b"),
Guid.Parse("9a515e56-8ecd-4c20-8ed1-d47cfa00c8d7"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Guid[4]
{
Guid.Parse("4342a8b3-dbee-4d55-b20a-f00c386c8b24"),
Guid.Parse("5b014590-d906-43b5-8ab7-9fb901d3f9b3"),
Guid.Parse("a8fe69ac-df0e-4939-a617-bfe673134ed6"),
Guid.Parse("5ad41917-68bf-480b-8449-563b36faa81b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f86a0705-155a-434b-8597-03ab630ef340"),
Guid.Parse("9534a049-7578-4970-aa1a-84133295daec"),
Guid.Parse("25bfc46f-1506-44ae-96d8-0b57a8e4d54e"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Guid[3]
{
Guid.Parse("764780fa-e769-46d1-9f29-6a1364fbf8bb"),
Guid.Parse("6efce84c-fb9b-4b87-8e6c-94d21f971b07"),
Guid.Parse("b839c9e1-ddb0-41e1-9666-ab4c31abab5b"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("a2272f85-06a1-42ab-bd6f-5226b43571ea"),
Guid.Parse("8279f2f4-a8f2-4773-b77e-bc7f51396f8f"),
Guid.Parse("39f1a15a-010b-43eb-beaa-b0a6af73e145"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("171a3f29-127d-45a4-8044-f6fd55c96e63"),
Guid.Parse("52308aca-84ed-41fc-a179-c6257fb0775e"),
Guid.Parse("4e489b5b-455d-4683-b831-c0f2063dc822"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Guid[4]
{
Guid.Parse("1c373a45-3a28-4728-9e95-29d5d6e79de6"),
Guid.Parse("73187231-6fb4-47a7-a3f1-8adf2043b7d5"),
Guid.Parse("c634eae7-32e4-477e-a25f-4ee143d5fc5a"),
Guid.Parse("cd5a50e0-8036-4359-ac96-793d68cde0f9"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b85f5ee5-d02f-4e66-845c-fdaf279a47b3"),
Guid.Parse("8acb76c7-7944-43c6-933a-fce8d16484b0"),
Guid.Parse("d89c10ba-c3a6-488a-9609-bb295ab10239"),
Guid.Parse("6165d884-eea8-488d-a69f-3c81cdb99687"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Guid[3]
{
Guid.Parse("df8ba3a9-95f8-46e5-a61c-5fe4adf0a4e4"),
Guid.Parse("88a0a793-e2ed-4c1d-9fe7-7a51a7148e7a"),
Guid.Parse("bc72bae1-67b1-4df4-b5ff-297f3b3c8df2"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Guid[3]
{
Guid.Parse("53aafd38-5b38-4c46-9e8c-7811533a3627"),
Guid.Parse("f3a0998c-7125-4a8c-80c8-6105db5e695d"),
Guid.Parse("aa9bf666-5aac-4ae6-b74a-85580b3e5815"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 101,
    Value = 
new System.Guid[3]
{
Guid.Parse("bf061c37-d565-49d7-adf8-10a7da04e794"),
Guid.Parse("c47a61e0-90cf-41b8-bdaf-9386c0603159"),
Guid.Parse("d5ca6584-3576-4b10-ad6b-e39fc82dcf30"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3aa493ff-f866-4502-b6c7-834149d67471"),
Guid.Parse("546aa188-b598-4e7e-b36d-40642249fe30"),
Guid.Parse("2091c188-ce7d-4815-aa94-197d7705222f"),
Guid.Parse("744557cf-b407-4331-8e19-b189f03b3f37"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Guid[3]
{
Guid.Parse("45c3a57d-5577-4765-bdfd-4d86af6fcacb"),
Guid.Parse("c374a5ba-7035-417f-87a3-42bfc63c0834"),
Guid.Parse("ec54084d-65de-4446-9d93-8f6fa39ad62f"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Guid[3]
{
Guid.Parse("2c2d1263-7719-4f45-8cf6-9ed84d14d3e4"),
Guid.Parse("42dd4b8e-9100-47f5-99d7-dc616701b77f"),
Guid.Parse("c3615afb-2744-4a01-9724-03614a686173"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("406b5a6c-bdf3-4246-8a69-c2a170d6198a"),
Guid.Parse("0432a1b0-175f-4ce2-bc65-2806ce1b5fb5"),
Guid.Parse("18118e5b-5faa-4ba4-b327-347b18e353d9"),
Guid.Parse("401e604f-5317-4827-8536-bec3bc3e3cb7"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("56015d85-de1f-41fa-8935-37fc0f526e7f"),
Guid.Parse("ebf5d8e1-956a-4958-9828-02dd3ee5bf64"),
Guid.Parse("a92b5ebe-23a5-4cb7-b960-e978871968f0"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("92a0727c-2a25-4e68-b470-a2ae908a4cc0"),
Guid.Parse("51bac8ec-0d33-4a55-a6c6-cfd33df2c3ae"),
Guid.Parse("7ca9eb49-eb26-4556-9c49-25e3bc7e4b41"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c65fb5b5-4678-4bf4-9f60-bf3e9cb2e666"),
Guid.Parse("7435144d-70d1-4cd1-b23c-ab24e46c938a"),
Guid.Parse("a1666e6b-5b06-4290-86e7-41d57ad05f33"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Guid[4]
{
Guid.Parse("a170ca2a-ea59-4bcc-bf55-8594d7667e4b"),
Guid.Parse("2c7897c4-399b-4870-b3cb-a46a67a2df58"),
Guid.Parse("0bcfd414-af60-438e-9f1f-13711a9e18f2"),
Guid.Parse("810de9ea-bbe6-4563-bbfd-31018e1bee62"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("913205f7-03e7-47ec-b35d-89fe358fab22"),
Guid.Parse("70cd08bb-69b3-4b7f-8a6c-3c9169e5c626"),
Guid.Parse("0ebb3af8-cf71-403f-9bc2-8a506d57577a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d1d02732-09e4-466c-91a5-2c1a14113a77"),
Guid.Parse("2b597d00-d72c-4ba2-90f0-d7e2d8e87abd"),
Guid.Parse("033f6b85-b9cb-48d7-b1f9-cef38947c940"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("5a586c32-fbae-4c14-a118-aef73fef4c67"),
Guid.Parse("5c86821e-de3c-49f8-991d-fe5e5d454a84"),
Guid.Parse("cd98e994-9eb8-44ab-9477-187c2b23436f"),
Guid.Parse("039f2c81-b766-46c1-96fa-31d3d731a951"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 127,
    Value = 
new System.Guid[3]
{
Guid.Parse("2f42435a-8ebc-4899-a235-29f296b54e73"),
Guid.Parse("c7b92cb0-b53b-452b-8c83-4f56f6c27fd2"),
Guid.Parse("ea9dc594-f3fa-4e6b-ac63-2de14b470069"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Guid[3]
{
Guid.Parse("19386311-8d7d-43a4-8030-091131786d8d"),
Guid.Parse("25c22f39-6338-4bdb-9881-cc40a607d02b"),
Guid.Parse("1ee2b894-3d78-47a3-94c3-db550354bb18"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d66c31b0-cbb2-40ca-a2c5-bf0e5c1c92e6"),
Guid.Parse("35adeff7-a9ff-41a7-9dd3-99408758ad6a"),
Guid.Parse("5cb5e42b-fe98-4c27-bee7-7337c0a42b09"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Guid[4]
{
Guid.Parse("def04bf2-36ab-4af3-b1cf-4021821bed84"),
Guid.Parse("8f6d99e3-1b84-46cb-b695-348b1f5f61ee"),
Guid.Parse("3c9e12c7-572d-4df4-ac14-9353bf8a48a4"),
Guid.Parse("6d6a76a8-9e46-4c2e-bde4-b4eff0714445"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Guid[4]
{
Guid.Parse("7fca8595-b8fd-46b5-8e24-ebda83831f97"),
Guid.Parse("d4a23dc1-dbcf-40df-bc96-ebccd21fc5d5"),
Guid.Parse("db28f466-d818-4a90-9b6f-74945d293807"),
Guid.Parse("046caaff-6dfa-477c-8fb3-1a2068fd47ee"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("35c86813-cd18-4f38-b779-a395b9383b20"),
Guid.Parse("0b94a97d-4adc-4bec-b421-5562c2946cbd"),
Guid.Parse("54d8eb51-8ee9-465a-a716-8176f54458fb"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("44c4028e-a5a2-4009-add7-59d6d8cbcd3f"),
Guid.Parse("fe7e3ab4-ffbb-42c9-83b3-fcee6edbd2d1"),
Guid.Parse("191fbcf5-8cda-4da1-9c2c-d29584f3cb1f"),
Guid.Parse("94c947b9-43bb-4c01-ac63-b5bd814195b8"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Guid[4]
{
Guid.Parse("330bb850-3fe7-40d3-b2a5-21a8784c963f"),
Guid.Parse("fcd69a67-b080-45fc-86ec-d0e22e1084c7"),
Guid.Parse("39186f28-e98e-4484-a29b-686578fba730"),
Guid.Parse("265adecc-e764-4b70-b6b3-2e3734babc6e"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Guid[4]
{
Guid.Parse("6eb44d58-019b-4d41-9b90-57c63297b918"),
Guid.Parse("3139ae0d-9cfc-49bc-b722-e7416f0c70b8"),
Guid.Parse("16a700bd-a30b-435c-a8d4-8e73309059fb"),
Guid.Parse("80dab51b-0f51-457d-b924-1ae2b1d1ede3"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Guid[3]
{
Guid.Parse("32f3fbf8-499b-47d7-9eff-637e200cebbf"),
Guid.Parse("616b2ab8-0905-4995-a4c9-dbccf8eb96f8"),
Guid.Parse("74b3df96-acc8-4abe-874b-f21407396fd9"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e2268751-a04c-4f14-b803-5322f8193969"),
Guid.Parse("64919d29-0380-469f-b31c-e9d7fdab6fa7"),
Guid.Parse("4f570d9a-8eeb-421a-8f67-0a537df8be88"),
Guid.Parse("1f5bea19-b9d5-4f6e-ab8c-ec094b740087"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Guid[4]
{
Guid.Parse("cb20a54e-ae47-4410-96a4-3812daa63e66"),
Guid.Parse("932e4857-4058-4f0e-b6a7-4837d267feb2"),
Guid.Parse("01ba7553-d17d-4a69-82ed-beee22b7db7d"),
Guid.Parse("e7fe6181-59ae-4601-9bbd-691032987053"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Guid[3]
{
Guid.Parse("bb6e3d0e-e21f-487b-a030-3a4aa4c9a107"),
Guid.Parse("8cac7003-7b77-4af6-b9d0-908b7bd39932"),
Guid.Parse("6eb59bf7-f22a-458b-9450-2ee02558b7d3"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Guid[3]
{
Guid.Parse("08fa3a0a-0cfb-4356-8591-02232a436622"),
Guid.Parse("62ae1cf7-0ed9-412b-b6f4-22f852c6edb8"),
Guid.Parse("6e8b5fe1-b32d-4c2d-820e-923074182861"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Guid[4]
{
Guid.Parse("945d89f7-0acb-4845-83ed-d0c88b745b40"),
Guid.Parse("03856408-611b-4ea7-a6c4-7b615e577a2f"),
Guid.Parse("6e481fb3-eed4-4d01-b7f9-74f7d3ee4c41"),
Guid.Parse("dbbe3b17-bc5f-4e4f-959b-a3ccd7cc87e0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Guid[3]
{
Guid.Parse("c1ae1d01-9cc4-40a1-a278-08d78de3b620"),
Guid.Parse("39e96673-fe6d-4111-b73e-853e18c41e24"),
Guid.Parse("69dea140-368c-49a3-86a5-4610e54381ee"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Guid[4]
{
Guid.Parse("db4d60d3-57a6-4833-8fb3-3b9de46acc89"),
Guid.Parse("c2da6858-eeac-4ec7-9be6-d0da7712279e"),
Guid.Parse("7d7c00d7-3f52-46f5-97af-4f1bb22021d2"),
Guid.Parse("5a502f4c-4e30-4be3-8dcb-f2c7e914bc01"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e2e5f6fa-51cb-4887-b22d-49e2d5d64876"),
Guid.Parse("fe9a598a-8a4c-465d-8614-14d06f12157c"),
Guid.Parse("7dac9402-cbe3-4501-a87c-24365f313256"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 169,
    Value = 
new System.Guid[3]
{
Guid.Parse("1fe0ee7a-f283-4052-9949-2ddda0f48b50"),
Guid.Parse("5b355011-e827-436c-a3e8-6386678c0b0a"),
Guid.Parse("4e7ab8c0-d1ef-4861-97df-82e1bb49eb30"),
},
    ModelInner = null,
    NullableValue = null,
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
Guid.Parse("f7f591b9-7c6c-4b08-85cc-fc264b8c0e08"),
Guid.Parse("5c3d7de7-4ae0-4d02-8544-6fe2b0a5133a"),
Guid.Parse("0578ff29-d7bc-4c7c-9b14-30a8b85656d2"),
Guid.Parse("fc0a9067-1a85-4450-9b6a-bcf87f27c4ce"),
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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("dc3f3dbf-0523-452b-a244-1d4c789d41ab"),
Guid.Parse("76ac640d-1c1d-445e-9bcb-91ad275807e3"),
Guid.Parse("086a0e4e-fbdc-441c-83e6-de1bdc80a475"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("0b81c637-2982-430b-892f-1bfa9b510c59"),
Guid.Parse("85aa2ce4-d9a7-4d47-8fd0-be3bde6b32d4"),
Guid.Parse("ddcb54d7-452a-4f72-adab-907f49e92473"),
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
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 121, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 95, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 14, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 51, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 1, query1, 50, query2))
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
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 127, query1, 157, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 120, query1, 1, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 121, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 161, 127))
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 84, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

