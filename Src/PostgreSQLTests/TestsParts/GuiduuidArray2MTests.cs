

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("88892fbf-2ec4-4e58-860d-4dcd62691b6c"),

Guid.Parse("ca510fb4-cf71-4670-a468-52279f4e96f8"),

Guid.Parse("43aeb254-2df8-4aac-a9de-f7d0c68de0db"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1e8817b4-b5a2-4a8a-a714-b825534d601c"),

Guid.Parse("43e44a63-af8f-418a-8fc4-0655e597698e"),

Guid.Parse("6fd9ada0-91a7-4545-9c2f-67bf6303bf1f"),

},
},
            new GuiduuidArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4a6b6293-04a6-4b1b-a2e6-e785ef9141d8"),

Guid.Parse("1bc1ae95-77c0-4244-bb86-0c2c9fa91fe1"),

Guid.Parse("0e98449e-3128-48db-9957-770f5605d98c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("65750702-e862-46ab-b341-2ffea9f22e44"),

Guid.Parse("c19ed8d3-0c79-422a-b55a-bd237ee075ea"),

Guid.Parse("0f3c027b-f860-4056-bb24-9619db993026"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fc4f351d-c18f-48b8-8c65-860d3b1c4d45"),

Guid.Parse("5d42e802-4fad-4924-b472-b820c03dca11"),

Guid.Parse("fac3a695-fbbd-4e19-abba-67e44b0f1d3c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fa79b11b-71f1-477e-b84c-091e182ad98c"),

Guid.Parse("dfeb5c02-b017-4392-9f56-a30ab1ae184f"),

Guid.Parse("1f5cd830-bfd5-4fbf-94f1-ee680aacbeda"),

Guid.Parse("ebb8e5a5-2d8d-4636-b2c2-df0cf4231e70"),

},
},
            new GuiduuidArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6c4aa674-0ad1-4c7c-94a9-1bf1ce82db80"),

Guid.Parse("0ff1c6b6-119b-4126-b936-14a68d349df7"),

Guid.Parse("53597c39-ebba-4fb4-b12d-d96fdc19dc06"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("af22bb89-0486-4156-ad99-abf0a0d24d0f"),

Guid.Parse("f616c198-5e68-49cb-bcaf-e110fb112b3d"),

Guid.Parse("09b34a54-f19a-43e5-a661-f1e6d49c0845"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("361a3630-2304-4c1e-96d9-54409139ec69"),

Guid.Parse("6e2253db-a7d1-44f6-9062-94b34f0ee692"),

Guid.Parse("4a0552ac-fb31-42c9-b5c7-e9ee7d3dbb70"),

Guid.Parse("e2eb7ff4-3b54-46f4-8b11-0dfba979945d"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0b94bbae-bb26-4090-9dd3-a27e94a50c39"),

Guid.Parse("9b8bf07c-808f-416f-875b-591e546b0226"),

Guid.Parse("920fa98a-a14e-476e-bd89-499f2f398042"),

},
},
            new GuiduuidArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9dcca6f6-dc29-4c1d-b6c5-eb6fbe8745a5"),

Guid.Parse("7e1a8d69-288b-43a4-8ba4-e9a64e355af9"),

Guid.Parse("964b6875-f76e-4751-ade0-7fae4e726c0d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("89ac8441-e9cd-405d-9405-5153561ffdb9"),

Guid.Parse("0e5401e7-feb3-423c-ab86-8b57330a48b7"),

Guid.Parse("ce10d83c-f17a-44eb-8314-b0e45065a4a2"),

},
},
            new GuiduuidArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("aac2d502-df35-4ce1-bc71-3161871fe6c8"),

Guid.Parse("4c74f3aa-8a09-4e73-9561-b63a5d045fe1"),

Guid.Parse("ecb0d361-4a7e-420e-aa43-659a74cc3bc8"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6f08e39a-1ff2-4cd2-814a-140fc2f37f5d"),

Guid.Parse("c04cf1a5-3b66-49bc-adf6-92269cb1002a"),

Guid.Parse("1a950345-ae60-40e2-8fde-7fabbe22c6ff"),

Guid.Parse("21d401c3-e022-469a-a0e5-17bbacb295bb"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("84b6a227-07d0-4ba5-bbd7-4462147fc663"),

Guid.Parse("26ff9fca-fb4c-4297-a669-4a84c60da57a"),

Guid.Parse("04fdeaea-697a-41aa-ac8b-83621ec036f1"),

},
},
            new GuiduuidArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("29ec7c4f-aac6-43b9-9fc7-a78ccbfe181c"),

Guid.Parse("5dc4ca1a-c30e-49e5-92cb-f027257961db"),

Guid.Parse("32367d13-1e58-4daf-ab8b-919d1c3a256e"),

Guid.Parse("867a1255-e627-42bc-a8f1-6ad03c1830fa"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9d278e47-52cd-4c36-8d0f-3bfe4dab926e"),

Guid.Parse("08186e3e-e351-4dd9-b1a8-6ca040385e02"),

Guid.Parse("6ace6677-8c2b-4906-bc18-3e1ce6aa099a"),

Guid.Parse("3f2fa0d7-b069-4b81-8805-49af2d7b84d2"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5ab9e114-4538-472e-8a85-a02c54da58e4"),

Guid.Parse("1e3f30c0-25c4-4322-8b8f-7022938f62aa"),

Guid.Parse("5b43dd27-a999-44a7-8e40-5c18e25e83e2"),

Guid.Parse("3dd7f2e6-f0d5-4629-9c0d-e7524f26c34f"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("20f2d4cd-162a-4f12-b267-1716a550864b"),

Guid.Parse("c714c27a-9b50-4e93-b20e-62d6026b23b1"),

Guid.Parse("c4079323-fd09-4572-828d-fb910f59cd0e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("16c81d8b-8129-4eda-b705-c17415c81a68"),

Guid.Parse("3c32446b-bf2b-4397-833a-47f20910ec6a"),

Guid.Parse("6d08b74d-199f-4188-9a19-80f3daecd9c7"),

Guid.Parse("f6212cd8-a6a7-4d7c-bbd1-33804a2a4e83"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("27b2b8a6-d4d7-49c9-a96b-bb8bdbb4fa94"),

Guid.Parse("507d5bfa-a637-49a0-ab7e-2a6023e4caa2"),

Guid.Parse("4f3c2386-9431-4056-a790-38e9c5570ee6"),

Guid.Parse("b12d33dd-6a9c-46ea-974e-edb967bc1ed1"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c13d9723-8c79-4509-98c2-0d16408fd62a"),

Guid.Parse("bf27d3bb-4b12-4b6a-a36a-cbc36f2e4b71"),

Guid.Parse("631f9d84-5960-4b99-9050-cfe83ad435f7"),

Guid.Parse("aa9bf449-c33f-494a-9dee-088098cd2ad9"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("34151b95-7d36-49a7-9ce2-b1abb0717ab2"),

Guid.Parse("38db2b64-1316-41c2-85e9-f2a76e1ae9e1"),

Guid.Parse("5a0b54cc-59e7-443c-a7ca-20a1ea2569d0"),

},
},
            new GuiduuidArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("56faf595-9ce8-4582-ae01-1b8ace2882a3"),

Guid.Parse("2b088fa2-d429-415c-9ffe-3e006ecc9056"),

Guid.Parse("efadebc3-0f53-4bb1-bf70-f317af4aefbd"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5ffb7cc3-7b90-413a-be87-5da7dc98dc0c"),

Guid.Parse("7d1c21d2-1d87-47af-a7b2-22d489f4d0e9"),

Guid.Parse("2f5b7b37-b674-4a8e-9e40-7993d2d0b2c2"),

Guid.Parse("83b41042-787a-4376-8b7a-38edc7ad7e31"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("24bef21c-0489-4a62-b89a-c77d87eaf798"),

Guid.Parse("c5ee1e27-65ac-4ad6-a1df-56635dfd98c5"),

Guid.Parse("59b2eeaa-9910-4c38-9096-d744d7e04cef"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c48a1d22-ee5d-4f5a-90b0-aad5ae0c36c7"),

Guid.Parse("2e93d6a9-094c-432f-a63d-f935f72390cd"),

Guid.Parse("00430182-80ec-4475-88a9-c7f922fc9878"),

},
},
            new GuiduuidArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("34e59248-c5a0-439e-bfb3-5816d1aff325"),

Guid.Parse("20eb3359-4e13-4ea5-ab21-0ee47da9b4c8"),

Guid.Parse("6235baea-54f0-469b-a604-87a052a07b0d"),

Guid.Parse("b2bb32f1-3c8f-40fb-974d-e3ee399cde94"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0b1ef41e-ea4e-4de1-b9e6-c0833c51dcff"),

Guid.Parse("097e1a44-d075-4013-a420-65a772e1f748"),

Guid.Parse("2082f61e-4cfb-4c46-8500-e845dc029877"),

},
},
            new GuiduuidArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5844c917-8c49-412c-a071-a7fc6c5022d3"),

Guid.Parse("de932684-0b9e-4315-8d7b-3fdfbcd4924e"),

Guid.Parse("236a148a-9169-4163-8180-1305fa0cbca6"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f979b1e2-18b4-46a7-bf8c-ee0bd46c8c08"),

Guid.Parse("bb8f8a13-dcd4-4d32-8c68-726722f1295e"),

Guid.Parse("66350e28-c840-4665-a620-4ee76066436c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f30e677b-cbee-4430-b615-767b5b393451"),

Guid.Parse("6c05067e-e1f2-4a5b-9f02-ec8830d4cdd2"),

Guid.Parse("7354b777-c777-410f-9598-903d9d2d33ec"),

Guid.Parse("8dfe7caf-811d-4c81-883e-445b0952fb3b"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b1e6b178-14cb-4e3e-a0d3-9fd9f148b697"),

Guid.Parse("a1d2f232-80da-4862-b12a-3191577d8212"),

Guid.Parse("f24bf25c-be68-441d-a66b-c1adff0fbd52"),

Guid.Parse("8db91552-7fcb-4c14-8b25-7bdaa8128a13"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d2f95b61-e3d0-4bd1-9eed-d33b3b3f8607"),

Guid.Parse("1b78e331-6b7a-419c-ac06-af44ff1d6753"),

Guid.Parse("699293a7-8503-499c-86f5-12b55b5bab5d"),

Guid.Parse("472cd68e-9827-4a39-85d5-71860a742d77"),

},
},
            new GuiduuidArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1d3258f9-7f32-4292-ae8d-8f69c5351be3"),

Guid.Parse("3c624128-8b17-4b18-9c22-5b065c53e504"),

Guid.Parse("ef889bd7-57a3-4459-8a6e-bfa871fc6038"),

Guid.Parse("4138358f-7f4b-42ac-91ba-7f674c090e3a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a5d9d18c-d54b-49b5-a4fd-8a36888a2bc8"),

Guid.Parse("5bcc156b-91e8-47d8-b6ba-35ad8d3c2f9f"),

Guid.Parse("3f2a7419-80d3-4feb-a9ca-e23a983de4bb"),

Guid.Parse("f7283214-8401-4a6e-ae1f-6e15d3620352"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("de472a1a-c46b-4e56-80ef-77bd904c59ea"),

Guid.Parse("6676810f-bf51-48af-b2c6-7c56e821b4de"),

Guid.Parse("0ee053b6-335f-482e-a163-19d97c2a46c2"),

Guid.Parse("62f17eb6-08b1-42c2-8e25-6649b5af1969"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1bde0255-e05c-4354-8a2b-366871d9638d"),

Guid.Parse("6ce89d47-3556-4029-afcf-5e0a1ce25d68"),

Guid.Parse("6c71fb9f-8ce1-4101-a671-01476b640964"),

Guid.Parse("086e511c-9d85-4191-9ca4-76c476945933"),

},
},
            new GuiduuidArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d9e7d404-73a3-43cd-a590-4947b5d4b3f8"),

Guid.Parse("f353a0c4-0a58-4ad5-a9b4-25f7b5e90e54"),

Guid.Parse("f81e162a-9003-498c-85f7-91f54d635bfa"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cc226820-5327-4db5-a95c-14ba8921e9da"),

Guid.Parse("212e1ad4-4c37-4883-8bf1-1f96586e27ac"),

Guid.Parse("4202ee44-3dd8-460a-98c3-6f0c7daca2a6"),

Guid.Parse("e0f7f214-056a-4cc1-9e83-4fc63c4d4737"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b1d2354e-2e5f-456e-b316-550f3dd43e25"),

Guid.Parse("53d3a060-5a25-490f-b60e-ed58455e0f19"),

Guid.Parse("766f2f34-b0ac-4de1-a935-77d41dadd9dc"),

Guid.Parse("f7d1c1b7-484a-4853-a72d-20e0683f1c79"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2f9fa5c4-773c-49db-9b23-3a3e01099a21"),

Guid.Parse("248c4b92-1d4f-48ec-b447-84242e56a2ea"),

Guid.Parse("50b99c1a-ed2d-4381-810e-240e5f79dc2b"),

Guid.Parse("e72c074e-08dd-421d-9009-870137605336"),

},
},
            new GuiduuidArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f7f08b4f-5013-40df-bff2-775e4eb6e3bc"),

Guid.Parse("551c64f5-a092-4a51-8f9c-449e23e971e9"),

Guid.Parse("3a03ccd1-06a0-44b0-935e-ac09407b9041"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4ad2d4af-b2c2-416a-ab58-b1cbaddbfe1c"),

Guid.Parse("fac19c3e-5fbc-4c2b-a235-23c76dec4de6"),

Guid.Parse("33e15187-2038-46ce-a871-19bc73fa2346"),

Guid.Parse("dbd58412-b951-4210-abe2-e5c40869833c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("abd73e8e-2bb3-496f-b4ca-bf62de6fcd70"),

Guid.Parse("a9f4658c-83bb-4233-8f22-151873635e4f"),

Guid.Parse("c15589f3-5dd9-4bba-ad5c-99e32ba8630b"),

Guid.Parse("213b49e7-7edd-45b4-9d9d-f48812ae248e"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("97b9477b-4935-4c51-9728-7425295de3c3"),

Guid.Parse("4886b46a-64c5-4a8d-b222-80c78d6ad57d"),

Guid.Parse("d6c1c048-9abb-4f1e-b5c4-bc4dfd6e8b67"),

},
},
            new GuiduuidArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b8444036-aa5a-4f7f-a928-a0a892164ebc"),

Guid.Parse("c8802750-9591-4b29-9712-e9e1cc7e3f94"),

Guid.Parse("c5ffd298-f8b3-4a51-abd6-e2c91046ab77"),

Guid.Parse("5ba71c4e-2cfc-411a-9c8d-ad38f369c79d"),

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
Guid.Parse("b5586bb1-982c-4f8e-8de8-da526cf5586a"),

Guid.Parse("cff9a9e2-ddbd-4169-9a2f-7f46752075db"),

Guid.Parse("ee06f67a-cfd7-49a5-a454-936cec4d7f4f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5248aee2-6791-43b8-bdc0-8380b5ec06ef"),

Guid.Parse("e24bf478-172d-4da4-861e-fc491c7ed856"),

Guid.Parse("c4aed8ed-9145-439e-accf-32b81f4aa9ac"),

Guid.Parse("fc12fb6d-8ed5-47f9-ac1a-a3c5bcd84aa0"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37fccc15-4398-4e36-988b-ae086ab03be5"),

Guid.Parse("47dd07e5-1d86-4ebf-a180-c8d3e7b3588f"),

Guid.Parse("62ac5685-fb54-4f6e-a089-3409c573c413"),

Guid.Parse("81315ba8-f509-40f6-a449-857b0d57f26c"),

},
},
            new GuiduuidArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a0287f70-d5b9-4d3b-b86c-45b1ae9f0f62"),

Guid.Parse("23d192b1-6ade-42ff-9c81-bd6549c1a983"),

Guid.Parse("8744606c-f0b3-4fd0-a1ff-6b3062148fa4"),

Guid.Parse("a69cc205-8beb-4fc5-8dc2-956794afaf70"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7fb5daf6-7d3d-4895-8e03-8adcbdd1e09e"),

Guid.Parse("dfc975ea-31a6-4a28-9434-f1b4a408cf01"),

Guid.Parse("51a19f12-9ecd-42e9-9480-270cb4443ed2"),

Guid.Parse("d96e01dc-f457-4674-8e04-41e3003b5a7e"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7525959b-ef0a-4b01-ba80-0aa8f2861a4f"),

Guid.Parse("13adfcc5-26aa-45ab-ab15-6eb6437ee8d0"),

Guid.Parse("bad8ec3a-d8aa-4a38-94c1-e64882719dac"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("25bdd318-e271-4822-a22d-b57b447ca15a"),

Guid.Parse("f1b129e2-e209-4240-a488-2d74ff6a8d01"),

Guid.Parse("259e2247-34b4-45c7-b01e-c49fd4b2bfe2"),

},
},
            new GuiduuidArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3764e9ad-bc1c-4a05-8358-c4691322af2a"),

Guid.Parse("294ee3bf-fb0a-41d6-8287-3a627913deee"),

Guid.Parse("0bf9cf98-58f1-47e7-9370-bad73c15ec5b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("89f96fde-4371-4245-815c-319d52949789"),

Guid.Parse("a017e2a8-6a8c-42d6-8be9-c14a7dda9b47"),

Guid.Parse("911c95df-81c7-4a7c-a52b-13d35764189a"),

},
},
            new GuiduuidArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b2999f3a-516b-4fb5-9bdf-4a4eea6ca705"),

Guid.Parse("674ea62b-8a99-4fa3-bdbb-835e65de37fa"),

Guid.Parse("7de80e59-a7b2-4eb0-9740-5ed0e648e1d3"),

Guid.Parse("4e0f198d-ad4b-4d40-b12e-c0fb296b2323"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0b23160d-ee53-493f-a2ed-b8b666f9d60b"),

Guid.Parse("d2e0dc2e-4585-4110-bac6-e091ca22b024"),

Guid.Parse("8738b19e-f31a-4b89-8251-1362b10635af"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08e5f906-c663-48f5-9142-455d61aaf62f"),

Guid.Parse("bc1a0a63-7128-4f96-a5e8-ea3f59247b92"),

Guid.Parse("b39cf3f6-0142-4f4c-b9fd-7c9ee6b0a3c8"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("acccd35a-7230-4a12-9345-8d3d68cc8bfb"),

Guid.Parse("60203415-4582-424c-8fda-543dee43e572"),

Guid.Parse("dce5bd80-0ba9-49d9-923f-bf400c37d688"),

},
},
            new GuiduuidArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("adfe5ab0-a0b3-4415-91a7-7848bf4c5255"),

Guid.Parse("1557dffc-96ec-45e0-b447-6a3c1b03a9d9"),

Guid.Parse("9937abd3-3741-43b7-887c-b1bba1141837"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c5bc3752-abf0-41f0-a2df-755dba3f5ee8"),

Guid.Parse("59cf11a9-f143-433d-ad87-5d80c2f6aa24"),

Guid.Parse("2040deb1-cf47-4e27-b9cc-cc77e4da6b23"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c5ff6715-eb44-4490-bd4e-e3c9ae466c47"),

Guid.Parse("938d8b19-a13a-4630-95ee-4d7a6d66b806"),

Guid.Parse("fa411555-0fb6-48fc-ae07-3872e15d489c"),

Guid.Parse("177ea956-cdb3-4f15-a8f0-f784da612f18"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b00a5cc6-143e-4ff8-ba18-5232b04bdc24"),

Guid.Parse("a42dabab-4e33-4059-bfaf-c1567982ff84"),

Guid.Parse("03a92867-dd38-4e80-8c7f-b2c00c0200e4"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("51a36ca5-9def-45ab-a71d-cf41f7f3f80d"),

Guid.Parse("808423b2-f2db-4bcc-8049-f1419a71dc26"),

Guid.Parse("6ba25ba3-8934-4b23-ba79-78f0d543c0f8"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f877b80-4ac7-4f5b-8aba-a1e3b6ac47f4"),

Guid.Parse("689b63c1-9e87-4acf-885b-39a357c41f7c"),

Guid.Parse("1a7ff6e6-2927-4e54-a1f1-2c74a0f18f9a"),

Guid.Parse("ba5f071b-711d-4f29-b237-76fb30423f7c"),

},
},
            new GuiduuidArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4c8db1c7-a5b3-4565-b1b5-2ee0065ecb22"),

Guid.Parse("4fe76a4c-bbd7-4375-afad-cbd2ad4cd8fb"),

Guid.Parse("91f4a38a-bd7f-4b5f-aedf-82a371e63f17"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f86554cf-05a4-4bc6-b459-693a19116e93"),

Guid.Parse("95b85f18-f92a-4945-bf79-c46a7bb06135"),

Guid.Parse("83edb7b5-52ea-41b1-ae5e-7b5521ec961e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("10867809-c36b-4bfa-ba11-df6086321ad7"),

Guid.Parse("32b9eb3f-0ebc-47d2-ad3f-237423be9091"),

Guid.Parse("2fb2d402-ead7-432f-84db-e80a97f98ed1"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d6e67c88-548f-49cd-903d-fea5c7cfa618"),

Guid.Parse("f64b8664-006f-40fd-975b-0cf11c0d0734"),

Guid.Parse("61e270f0-ff68-430d-8d30-697fa32edd69"),

Guid.Parse("818b17ad-a813-4f66-8cea-5badee2f25fc"),

},
},
            new GuiduuidArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("96a0ad2b-a304-40b3-991d-1cd0fb221db0"),

Guid.Parse("e2b7f4ad-d2c0-4073-8952-87381491c3f9"),

Guid.Parse("0db39a59-159c-4579-9bf5-ef2a2ddbe5d2"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("52d0d3f3-9148-4d92-8817-62f267ccd65d"),

Guid.Parse("f6fff516-0e72-4d99-a47d-162e0dcee60c"),

Guid.Parse("f9a16ad3-22f1-4699-b275-bdf3518912e1"),

Guid.Parse("7d0f189b-d201-484f-8006-feb09eab6130"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3c148c36-f44d-4d8f-b5df-e4b10d1f7bf8"),

Guid.Parse("d42d04b7-b18f-4395-9e5f-d9074c4d4ccb"),

Guid.Parse("8290ec99-fbcc-42b5-9b26-5603808dba22"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6e126ecf-7f04-49ef-bdcc-ed3086ec38e7"),

Guid.Parse("b9f7194b-16f3-43dd-b8c4-054391ccb671"),

Guid.Parse("f345e7da-4c98-405d-b2ed-c404e28978a0"),

Guid.Parse("02b23c2f-a47b-41f2-a482-85cc40b64553"),

},
},
            new GuiduuidArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ca194956-8d42-420e-8f12-0651a3f45d18"),

Guid.Parse("a065733a-47a7-4e6f-b8e5-3abe88cb4018"),

Guid.Parse("3a45aa29-cbf8-444b-b7a4-6c5f60711b88"),

Guid.Parse("698d1ead-cd6f-4e36-b865-c8892b6d51af"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1904b692-b303-4988-ac1c-10cc30377bc9"),

Guid.Parse("011a446c-3caf-4fbf-9b18-7ce752f0b911"),

Guid.Parse("5f324e0c-d6cc-4f80-a54f-9126fdb76098"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("993591c2-501a-494f-911c-83f5263c2e9c"),

Guid.Parse("0924ecf4-874e-4500-bb94-17ebe43dace6"),

Guid.Parse("3b1f4f97-70ce-4a76-b2c1-04a85c433b0f"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f7d6238e-829c-4336-8c32-e4797878f3fd"),

Guid.Parse("6f79aea0-b56d-4c6a-9b80-879aada3f8e1"),

Guid.Parse("3da5fbeb-007a-4132-9051-5ce839ea42c8"),

Guid.Parse("e4b6c81a-f783-43f0-9936-dfb0d906dea1"),

},
},
            new GuiduuidArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e78bcc65-ceb4-4f87-91f1-1df37cd6b6df"),

Guid.Parse("c5a6bd2c-0f58-43a8-b9a1-681ee1926c8e"),

Guid.Parse("051dda01-0a44-451c-a506-ddb7331f9be1"),

},
    ModelInner = null,
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

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 170;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 155;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidArray2M.AssertModel(models[0],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidArray2M.AssertModel(models[0],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidArray2M.AssertModel(models[0],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidArray2M.AssertModel(models[0],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 109, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 139, query1, 166, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 80, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 172, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 43, query1, 166, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 96, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 24, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 172, query1, 170, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 69, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidArray2M.AssertModel(models[0],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidArray2M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 143, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidArray2M.AssertModel(models[0],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidArray2M.AssertModel(models[0],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[34], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
GuiduuidArray2M.AssertModel(models[0],_testData[17], false);GuiduuidArray2M.AssertModel(models[1],_testData[18], false);GuiduuidArray2M.AssertModel(models[2],_testData[19], false);GuiduuidArray2M.AssertModel(models[3],_testData[20], false);GuiduuidArray2M.AssertModel(models[4],_testData[21], false);GuiduuidArray2M.AssertModel(models[5],_testData[22], false);GuiduuidArray2M.AssertModel(models[6],_testData[23], false);GuiduuidArray2M.AssertModel(models[7],_testData[24], false);GuiduuidArray2M.AssertModel(models[8],_testData[25], false);GuiduuidArray2M.AssertModel(models[9],_testData[26], false);GuiduuidArray2M.AssertModel(models[10],_testData[27], false);GuiduuidArray2M.AssertModel(models[11],_testData[28], false);GuiduuidArray2M.AssertModel(models[12],_testData[29], false);GuiduuidArray2M.AssertModel(models[13],_testData[30], false);GuiduuidArray2M.AssertModel(models[14],_testData[31], false);GuiduuidArray2M.AssertModel(models[15],_testData[32], false);GuiduuidArray2M.AssertModel(models[16],_testData[33], false);GuiduuidArray2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 131);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
GuiduuidArray2M.AssertModel(models[0],_testData[24], false);GuiduuidArray2M.AssertModel(models[1],_testData[25], false);GuiduuidArray2M.AssertModel(models[2],_testData[26], false);GuiduuidArray2M.AssertModel(models[3],_testData[27], false);GuiduuidArray2M.AssertModel(models[4],_testData[28], false);GuiduuidArray2M.AssertModel(models[5],_testData[29], false);GuiduuidArray2M.AssertModel(models[6],_testData[30], false);GuiduuidArray2M.AssertModel(models[7],_testData[31], false);GuiduuidArray2M.AssertModel(models[8],_testData[32], false);GuiduuidArray2M.AssertModel(models[9],_testData[33], false);GuiduuidArray2M.AssertModel(models[10],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
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

                await ((IGuidListuuidArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
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

                ((IGuidListuuidArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidListuuidArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidListuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models = await ((IGuidListuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI), typeof(GuiduuidArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models1 = new List<GuiduuidArray2MI>();
                var models2 = new List<GuiduuidArray2MI>();
                await ((IGuidListuuidArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MI>();
                var models2 = new List<GuiduuidArray2MI>();
                ((IGuidListuuidArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models = await ((IGuidListuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

