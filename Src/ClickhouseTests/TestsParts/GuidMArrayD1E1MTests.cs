

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IGuidMArrayMArrayD1
    {
    }
    
    internal partial class GuidMArrayMArrayD1 : IGuidMArrayMArrayD1
    {


#region TestData

        private readonly GuidMArrayD1E1M[] _testData = new GuidMArrayD1E1M[]
        {
            new GuidMArrayD1E1M
{
    Id = 1,
    Value = 
new System.Guid[4]
{
Guid.Parse("d5c47d29-ce5b-493e-b8ba-ee8ad1e76804"),
Guid.Parse("f128d754-3692-4be3-a9d3-00fe3bcb904c"),
Guid.Parse("7919be93-f43d-40a6-8015-2b869a881572"),
Guid.Parse("1fe2f4ff-7a0e-4bba-9aaa-e395ac1689cd"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("b9019732-d635-4fdd-9e70-37cab28aa028"),
Guid.Parse("9efd8d9e-c62c-4701-8ccb-7ab540b33d15"),
Guid.Parse("ddb395a0-2aa0-433f-9a41-ae503ce12d17"),
Guid.Parse("5fbc17e0-26d5-4eeb-af29-89ffc67c6934"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0ddd9786-92d2-464b-b115-423a0ac8b190"),
Guid.Parse("17f100b2-53fd-4f0b-804c-c6627a6ef104"),
Guid.Parse("58704063-edbc-4c06-8cb9-39ce4aa3410f"),
},
},
            new GuidMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Guid[3]
{
Guid.Parse("540eb034-554e-4d70-97e1-21c618a3a8e3"),
Guid.Parse("655df650-902a-45c8-94f4-4c42274a46a4"),
Guid.Parse("4ca7d074-d81b-46e5-97c7-421778a2dbe6"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("58d0db1f-364f-4e38-b75e-730fc9335b28"),
Guid.Parse("36e5442a-64fb-4765-a74e-f6d462ac281e"),
Guid.Parse("a6f313f4-31e8-4900-ae5b-9b1ca8bbca15"),
Guid.Parse("5cd21fe5-2039-4042-9132-6f9a5214d067"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d005bff0-62ab-479b-b43a-fa249fba0090"),
Guid.Parse("43e4d772-aff1-4ab8-9efc-36812c0fe600"),
Guid.Parse("6cc86801-c630-4e23-b46e-52fb94f565a7"),
},
},
            new GuidMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("35c2fd83-c030-4aef-9fd0-e7d8879190e5"),
Guid.Parse("e6b6d6dd-836b-45bc-8434-e898fbc3d357"),
Guid.Parse("1dcde80e-80cf-4d15-8f7e-784857c6bd2a"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("12d2e3c3-3530-42c2-80a0-c03f7fac04f9"),
Guid.Parse("e81bc9d5-a77f-4115-b0ad-dc31e106c26f"),
Guid.Parse("7dd9d697-9bab-479d-85c7-c7e0721ef8d4"),
Guid.Parse("a100fcdf-748f-44fe-a717-1793e59edeea"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("00a886d9-323d-49f4-a1ef-36a9ae715ce7"),
Guid.Parse("83f4ed1f-7c03-4674-bf7e-b4149d30fa20"),
Guid.Parse("7e0dce79-26ab-4c50-bfa5-6d0d2df8ccfa"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Guid[4]
{
Guid.Parse("23d82dbc-d186-4a7d-abbc-d803a7e035d4"),
Guid.Parse("cdbcc00c-88c5-44de-a008-65ae3c148ec1"),
Guid.Parse("c9b2e643-9f4a-4765-8481-dbf3b43bc6ca"),
Guid.Parse("321f8b78-c0e1-4259-940c-6f23a9fad7dc"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Guid[3]
{
Guid.Parse("7629b12a-4392-419f-9980-5b7d1dabd107"),
Guid.Parse("636d97c2-f8c5-40bc-a8d6-6f29be9c3f11"),
Guid.Parse("5816ca9e-8bc0-48c4-9a79-13bbf7b9b8ea"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b84412c2-8159-4827-8b75-d91d8dd7f2f7"),
Guid.Parse("e73f3f6f-d14c-4056-b18f-6ced89672b82"),
Guid.Parse("651f1300-53bb-4d96-97d3-8da0e7ea090d"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("aa295bc1-9f55-41ac-84ca-a044f5f8bc36"),
Guid.Parse("31d6c1ca-9ecc-4135-980f-bc6823c14813"),
Guid.Parse("dbceb542-1c52-4a87-938a-c294e6cabb0b"),
},
},
            new GuidMArrayD1E1M
{
    Id = 27,
    Value = 
new System.Guid[3]
{
Guid.Parse("5fa4c4b7-5a05-4f1e-ae2d-083cbb06d3ce"),
Guid.Parse("f79ca3bb-db0e-4994-b474-6ab3f0f5c92d"),
Guid.Parse("e0368b63-1bbf-4599-91bb-74329116e3c0"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("9b6b7f96-e2c4-461d-937e-55e74e3c9868"),
Guid.Parse("96fe9d43-6b8d-4ca3-8307-5dba1fe8c01a"),
Guid.Parse("8e68a7bf-6655-48bb-88ca-55ea73525944"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5af83bf8-9f01-4fba-af50-d3f745f0c800"),
Guid.Parse("32e73883-5579-4f44-87b3-b7ee4c08e562"),
Guid.Parse("99823c87-2ff5-49eb-8238-e1a9ae0cf463"),
Guid.Parse("cb78f8b6-2123-42de-8db1-f0b11fd04f1b"),
},
},
            new GuidMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("ceabb066-d115-4b52-9561-51dc56d5aa88"),
Guid.Parse("128aa613-c29c-4f81-a927-7d497a76567d"),
Guid.Parse("ed8e5c5e-9548-4554-b5cf-ca348a9f54aa"),
Guid.Parse("5504d159-2339-48eb-bf3f-2301ef8122a8"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Guid[4]
{
Guid.Parse("f90c57b2-4118-49a0-a8fe-3d4e295b6fc1"),
Guid.Parse("758786cd-2dc7-4a8b-839a-e35a20f3fcf2"),
Guid.Parse("883f65a8-b785-4cd8-83be-fa6df12b3416"),
Guid.Parse("ee4ece76-e056-4ed2-a056-f48425728d41"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1bef87f9-26ec-4234-9c4f-42da93dc25a1"),
Guid.Parse("5e75181e-10a0-4262-b9eb-f38d70450b6b"),
Guid.Parse("8b47d8d8-d391-472b-9c29-0b6b9ba22165"),
Guid.Parse("a9b12d5d-458b-45de-80de-3a0316238ac4"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Guid[3]
{
Guid.Parse("56009438-04ad-45e5-9dbc-17e86fa82100"),
Guid.Parse("4c533afe-2d5b-4ddd-bd48-7c861fbc0a18"),
Guid.Parse("f3a46c3d-23a8-40f5-aa9c-50de26eccc67"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("3e6a4678-1c7e-4d74-a432-7d4e64432b6d"),
Guid.Parse("af52f767-0255-4d7b-b105-812e0dadcc43"),
Guid.Parse("f34ff5ec-282a-4af1-a962-88973a48d787"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6cae6662-7e88-4183-8af6-4731dadb12c2"),
Guid.Parse("66d195c3-f9be-4c5f-bd94-b96a0afb3ab7"),
Guid.Parse("60aab611-0f78-434f-af09-0a77c1d134bc"),
Guid.Parse("d4121d6c-e67a-4e98-87c0-9dc341c88ae9"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Guid[3]
{
Guid.Parse("efdc0387-6af3-4a76-82f1-a3559fc8ad83"),
Guid.Parse("480f9884-433a-414a-b4fb-68e74c42fdfc"),
Guid.Parse("34caec5d-a8d3-41a1-b8fb-889f4b306455"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("5f2df572-7e40-4144-ac0e-303f6ff4878c"),
Guid.Parse("1bcfe7f1-63c6-4b4b-a08a-b1f9955dd5b5"),
Guid.Parse("95e1a1b3-cb95-4274-a215-75bc46839f45"),
Guid.Parse("81e289d8-7106-448b-851c-2c189814628c"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("16c4ffba-ef80-4d96-af42-f672ef0aa161"),
Guid.Parse("7888c09e-621a-4aee-b678-d937ad0a0760"),
Guid.Parse("53e01399-be2d-404e-99cf-7cee0c432f19"),
},
},
            new GuidMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Guid[3]
{
Guid.Parse("4d1e3750-4562-44df-84dd-4a4685cdbae8"),
Guid.Parse("eb01f197-5cef-47a9-b72a-0b239ef89035"),
Guid.Parse("40fba94b-7a3b-44c1-904f-f34c3284d8a2"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("ce582064-81b7-4251-940e-e2bed3a7b7cb"),
Guid.Parse("479b9579-2ae2-4b46-ba33-d55cc8fdac36"),
Guid.Parse("ec951785-9485-4c34-939b-0b89fb12c1e8"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e2854012-2006-422d-a77f-897aaa585e09"),
Guid.Parse("510321c6-286f-4bd9-9468-3aecc6660b7c"),
Guid.Parse("43099ee1-7846-43ee-b913-3e8a67f3e913"),
Guid.Parse("b3e9be2c-65a4-4f44-baa9-b5d60fe0f881"),
},
},
            new GuidMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Guid[4]
{
Guid.Parse("3ad23ab1-c565-4d7a-aa2f-83d2a122c8d1"),
Guid.Parse("59b9bbc0-13f2-4377-bc31-7a1555f8c3d5"),
Guid.Parse("95303285-bd64-415e-ae41-9daeddbc428d"),
Guid.Parse("94227577-8db2-4ccf-b90a-c3f0e71b83db"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Guid[4]
{
Guid.Parse("3310d947-c9fc-41fe-9323-0e85a1586b71"),
Guid.Parse("ca79b669-0e90-4e95-bb2d-3fb8a497830b"),
Guid.Parse("63c5a964-635b-42dc-9e8a-fff58d6d49b3"),
Guid.Parse("36d1d3fa-43a3-4699-a712-49b5b65eed7e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("dabeecb0-5f64-4d98-a8ae-75f324500d14"),
Guid.Parse("bee29a3e-4577-4bfb-9df6-6ec937e44ef5"),
Guid.Parse("c13bac65-bfce-492d-97da-af278a74a99b"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("e415ba60-4e03-44cc-8f15-0bf9421fa3cd"),
Guid.Parse("f256eff0-4e07-42c4-a7c9-f7569bdbb229"),
Guid.Parse("28a708e1-b591-4c91-8b73-dba0bcb5edb7"),
Guid.Parse("e38b1a9d-d572-45d5-9a46-d58daabcce5b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("cc1be9a3-2b0c-492e-acd5-a84b81f2974d"),
Guid.Parse("fd974041-925a-41d5-8dce-5a040b22193e"),
Guid.Parse("39690f8b-7014-4828-a9ba-9d0f8c3fab3e"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5f06002f-adce-4703-9644-38e07beaf619"),
Guid.Parse("446af0e2-d3bf-4efd-9ba3-2c30d4ba466a"),
Guid.Parse("c2fcd544-426a-462e-927c-aecd5909b0d0"),
Guid.Parse("a01b98ee-e84d-422d-ab9c-3cc3392feb09"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("cc3c530d-a644-4ab8-9a43-202aa2f47425"),
Guid.Parse("0a67b581-a28d-463b-bf4c-a167367bee68"),
Guid.Parse("9240fac1-bab8-41bd-ba1e-8d325d7cde34"),
Guid.Parse("6520943c-c2b6-44bc-96a4-83d590e87246"),
},
},
            new GuidMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Guid[4]
{
Guid.Parse("28adf9bd-a554-4053-88f7-8fdac18e9978"),
Guid.Parse("df5897a5-0eaf-4329-a23d-a28213b64739"),
Guid.Parse("d12df5f0-b8d6-4c9a-821d-f7d31e22ad50"),
Guid.Parse("09bc2ea4-195a-4b73-88c6-b4674ac7b440"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Guid[4]
{
Guid.Parse("262492f9-4d1b-4dac-b5d4-d849730c8c93"),
Guid.Parse("0a2f35e8-4409-45d4-a27a-88608eb138f1"),
Guid.Parse("3e3ac201-9585-4b3f-bb24-f93055ddde07"),
Guid.Parse("893bf0b6-dcd7-4514-b53e-0714eef985dc"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f522c9b2-2518-4532-9d45-471750067821"),
Guid.Parse("83edd147-71f0-44e6-a776-dac9dbda1522"),
Guid.Parse("6272dcf0-dae3-48cf-a286-95227f66a937"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01a9abd9-2fef-4641-bfec-09bb672cb057"),
Guid.Parse("8a2f1904-2f49-4b0c-a860-a34128444122"),
Guid.Parse("549b418e-8588-45ef-a8a2-940df50596e7"),
},
},
            new GuidMArrayD1E1M
{
    Id = 69,
    Value = 
new System.Guid[4]
{
Guid.Parse("a02cba99-1968-4355-af2b-16e62c799be7"),
Guid.Parse("f8de8d3e-8570-49c6-880a-bf8ca203f68c"),
Guid.Parse("8d7e46de-9ed3-4ff0-9cc3-286fd24b8048"),
Guid.Parse("6256efa6-ea3b-4051-86a3-ac9d619d9782"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("12ff5a7a-64c8-4572-a30b-d3d77d50eb3e"),
Guid.Parse("b1a05cc3-feb2-49b7-b29e-c98a2d5966e2"),
Guid.Parse("5e2da308-de9c-493c-aa1f-f22a08573e41"),
Guid.Parse("12f61adc-df8d-47b3-b298-9781f06e1132"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0c4b2e2e-ab0a-4d48-8933-de5c71c54777"),
Guid.Parse("f90732de-3387-4a6d-865e-db51ab8ec538"),
Guid.Parse("7d3faaa4-89e2-4d04-9096-0a2f42330321"),
Guid.Parse("658c61b0-f89b-40d5-81d0-f4c6d74f54f9"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("64f46a24-a6aa-4c6c-8ceb-388b264766d6"),
Guid.Parse("f39959bb-bae4-4133-816a-d564b66d83e8"),
Guid.Parse("719525c3-75ac-49dc-95f9-2e2508c59a98"),
},
},
            new GuidMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("4ab43981-ecfc-4a76-acd3-9b8ec509efdf"),
Guid.Parse("ca064db5-6063-466f-9e02-19c12081b8ae"),
Guid.Parse("e16caa34-cda1-4976-bdf5-b977d18cc10c"),
Guid.Parse("e15cbbf3-3b6a-456b-ac30-c4cb2745bcd3"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Guid[3]
{
Guid.Parse("18fdbbac-e42d-490b-b290-4eba48e6ea75"),
Guid.Parse("dcdacba0-5107-46c7-8fe9-8cd41130cda5"),
Guid.Parse("9bb0d9b7-561f-48c9-899c-ca0c06d432c6"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Guid[4]
{
Guid.Parse("8b7d3fcc-e56a-40e0-abb9-fc6000bcbd52"),
Guid.Parse("943309ae-b361-4a4d-8e69-8c762c26f5e7"),
Guid.Parse("52d449e8-4dc1-4ec2-8c72-e98876ca5806"),
Guid.Parse("db2317f5-b219-4e27-93da-9b1fea9e37a3"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Guid[3]
{
Guid.Parse("11c04261-f6b0-47ce-9213-22a597321f02"),
Guid.Parse("e9bab18d-1fa9-49f7-b343-f856123962d1"),
Guid.Parse("e04cf4ed-4b9d-4f87-81eb-0785a9400ae7"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("89fe512e-a0ff-4238-b4ec-3e05b4481f8a"),
Guid.Parse("7e922bb7-0fe1-40b0-8737-ca54d44546d8"),
Guid.Parse("93173148-5d6a-4fbf-8d3a-35ee17341805"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("850b2a5d-ace9-433f-be6a-c10f18d7d655"),
Guid.Parse("b4a1b0ad-6058-4366-bf9f-2cd681d7435d"),
Guid.Parse("b8aa3820-b5df-446c-a115-55489149fb11"),
Guid.Parse("acdf0f5a-3278-4431-9452-219a9bae5279"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("06ad13d0-a462-4506-9584-8f677a100e7f"),
Guid.Parse("299f54b5-5a63-4b6b-a8bb-bfa319801e71"),
Guid.Parse("8978a5d4-f22b-4961-bb83-d4bd03a712a6"),
},
},
            new GuidMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("d5cbac1a-6113-497a-9678-898a0f53b2ab"),
Guid.Parse("2f2c6433-3336-402b-9039-45806c2de1b9"),
Guid.Parse("c9f5e005-3222-40b0-b571-3a9f0f2e2559"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("5f42ef4b-db4f-4e3e-a43c-834c6d142f8f"),
Guid.Parse("91d34d90-eed6-4bd2-994f-5daea6924205"),
Guid.Parse("22a0b45c-e06b-4678-9366-d3c113e77563"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ddc26a13-465d-4ce1-9ef7-026254ebe9b6"),
Guid.Parse("910f6541-bf2f-4b3a-bfb4-c7b05c180a22"),
Guid.Parse("e0b6ce1b-a682-481c-906f-01133631acba"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8b0ee020-d940-41fd-874c-ca3eb788a8a3"),
Guid.Parse("68d0c7ce-8a05-41e3-961c-a287c4dcfb4e"),
Guid.Parse("78dbf403-94d0-4758-b132-d5537dfae0f9"),
},
},
            new GuidMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("729aeed3-4691-4100-8d4d-13ac637aa284"),
Guid.Parse("ce02a5ad-ce62-4799-a52c-585b80833dcd"),
Guid.Parse("90aa1274-b229-40c8-b1bc-6dfe4f38eac0"),
Guid.Parse("7c86b725-513d-4abd-8f0e-4d73c9816931"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("31e0f56c-6d71-4d90-89a7-1ce26b4e6672"),
Guid.Parse("cdf2c29e-fa19-4d28-87ac-e29e40c34a05"),
Guid.Parse("21b8d8c0-aaa0-4793-9731-671caf91083f"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c18b36c4-89c9-4e6c-9d0d-ed213368c37a"),
Guid.Parse("e18dd94f-c389-42e7-90b9-6a164944eda9"),
Guid.Parse("f72a61be-42b9-4fc7-b4fd-3e0ec8b89ae4"),
Guid.Parse("f261375b-37f3-4d17-b094-eba88ae3da98"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Guid[4]
{
Guid.Parse("3b60677a-5d9d-414d-ab25-da20dafb685b"),
Guid.Parse("38856513-eca0-4a0c-869e-c4727fcf3b05"),
Guid.Parse("6d58cbef-b93c-4809-99d4-dafbd4de7356"),
Guid.Parse("344c87dd-6477-42cf-98e5-6081eb910704"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Guid[3]
{
Guid.Parse("be91ca11-7581-4de7-adce-9633b3c429a3"),
Guid.Parse("64bcb9ea-a14f-4aaa-a132-545e2d609268"),
Guid.Parse("b7894955-c083-47b0-ae19-0add564a43a0"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6bcb0b34-ca1d-40b5-bb6f-97ea3fc79c59"),
Guid.Parse("3ed5f278-b556-408d-8a62-b88a022a9594"),
Guid.Parse("60a55696-0af9-4897-bbe2-8226788f5cdc"),
},
},
            new GuidMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Guid[4]
{
Guid.Parse("e162182c-04be-49c8-b5f8-5af4c8b828bb"),
Guid.Parse("07e3b784-57a1-4053-b718-3fdf1ceda969"),
Guid.Parse("53926bd2-1cb3-4e0c-af48-bcbb73e8676a"),
Guid.Parse("72003f5c-a768-4943-891a-f75e43c9bd50"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 83,
    Value = 
new System.Guid[4]
{
Guid.Parse("9cc9cf5c-bfed-4e87-8d91-453dce499f5f"),
Guid.Parse("080954db-bcff-4126-bdc4-017b39571109"),
Guid.Parse("fd898958-277a-4b73-8025-54d6d5e77eec"),
Guid.Parse("9395c090-2d49-488b-a4e0-c91fbfcd8c7a"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("806bccfe-11ef-40e8-a14a-8c268a09a58a"),
Guid.Parse("47ec1751-6684-4089-9d0f-eb551560623f"),
Guid.Parse("ac0a3cb4-e03e-4b39-b766-e6fdd2294f38"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("b28b12c9-756f-4ae0-83e0-3845a2e6b256"),
Guid.Parse("531325ce-f14e-4f6d-a7cf-07896b799408"),
Guid.Parse("a30fc27c-0bd7-42cc-bf37-deae2e0d9e1f"),
Guid.Parse("ff6fdc4e-308f-458f-9fd3-780b00af288f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("32ee529c-7a41-427b-9e07-7de8839769c1"),
Guid.Parse("875f3eaa-f779-4188-8468-30adf024be87"),
Guid.Parse("7408a0c1-bb42-4e92-9e71-98674eea2363"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Guid[3]
{
Guid.Parse("1d788b0f-4199-4c86-8ad1-bc1d3f3b812f"),
Guid.Parse("67359a97-dd4b-48bc-b921-12fd68eb8ab8"),
Guid.Parse("de2c63e4-f91f-48c2-b547-574565839b88"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Guid[3]
{
Guid.Parse("84d2c8c1-3e7f-4820-a0af-5c30f0f8cd1a"),
Guid.Parse("de8349f6-a63e-479b-9a64-71e469565079"),
Guid.Parse("2c0487bf-ef14-453a-a87c-9cf0bd7582b2"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("be787f28-778c-4ec1-88de-67076ca5666b"),
Guid.Parse("6a29afae-95cf-4798-b999-8db6c2fe3a61"),
Guid.Parse("8e8df5cd-e981-4f7a-835a-f95cf83c3453"),
Guid.Parse("d6191529-a9cf-4251-82c2-04e4c091f8bf"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Guid[4]
{
Guid.Parse("0ca0254e-a36a-4dc2-85a9-f64a01f5a6f6"),
Guid.Parse("e911d8bb-2f4f-4642-9601-ec405cabc7aa"),
Guid.Parse("5d0a4d92-1b3a-4ce7-b7f4-7319c3a1ca61"),
Guid.Parse("50ba00c7-19e7-4e44-8596-e1c20f360f76"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.Guid[4]
{
Guid.Parse("75aa1137-5d8f-4fd8-9988-fc60abe9dd01"),
Guid.Parse("e18a128c-1296-45ec-99b4-8a27b52e159e"),
Guid.Parse("681d2b35-e5e7-4542-b831-272f674801ac"),
Guid.Parse("ccfb8b26-f58f-4e30-81a1-8956f1791671"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("cc440808-798c-4f1d-87d8-f57e14202394"),
Guid.Parse("e74cf4ea-4c5f-400f-b067-9d4ad45e3c85"),
Guid.Parse("bacccd32-dd12-494f-9048-018a4ce48c28"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fe6492de-93fc-4120-9131-91bcad9eda40"),
Guid.Parse("30f417aa-f44f-4a7e-9982-cc33ef1a4e67"),
Guid.Parse("5ad43c1e-046a-4df5-bf6a-8a643c105c30"),
Guid.Parse("ca13bfa9-16b4-4fc3-97db-6f8367826bba"),
},
},
            new GuidMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Guid[4]
{
Guid.Parse("0b16304e-9b79-464c-8eeb-3efd716f66d2"),
Guid.Parse("e845a49c-4783-4215-a943-b5451fc5ae6d"),
Guid.Parse("62f9cf71-289b-4de9-9566-3f96f9d4bbbd"),
Guid.Parse("177ab11c-0419-4ef3-aa64-5cd8fa52d4e7"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.Guid[4]
{
Guid.Parse("89276ca1-3a32-4d64-9897-ac1be29ad815"),
Guid.Parse("e0143189-bd6a-4a9e-b160-50ab28cce39c"),
Guid.Parse("78a56dbb-989f-49ea-a153-27044d7ace78"),
Guid.Parse("2a03874f-8dce-4cb7-accb-82ea5f24ab67"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fb1455c4-8a70-4c29-8d0f-5f98b55d56a5"),
Guid.Parse("e6986fb7-ea0c-431e-beb7-e7669b47ea4a"),
Guid.Parse("550d8113-ba62-4fb3-9b34-dd8624c67296"),
},
},
            new GuidMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Guid[3]
{
Guid.Parse("c3d8ed30-f774-46b4-92f9-2ec16de32b0a"),
Guid.Parse("281021d7-33d5-48f2-977c-3dade52b914d"),
Guid.Parse("ec35fe8f-fc5b-46e4-8c61-83dbdfd67f69"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 101,
    Value = 
new System.Guid[3]
{
Guid.Parse("ecbdbddc-3ef4-41b2-a57a-5d6bfe6944b3"),
Guid.Parse("ec6943b4-4c96-4ba0-a338-54fdd696d7d8"),
Guid.Parse("5eea9bc8-f972-4a2e-870f-4a4642eafb7a"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4f80e812-8ec7-473d-b31c-5352ace4f7af"),
Guid.Parse("37ca6751-90d3-4937-bae0-919967fa8610"),
Guid.Parse("24299a29-ff9f-4f52-a649-66b20d135a30"),
Guid.Parse("bccfa102-0e19-4cf1-ba4b-c4fdcb1c7406"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2f689c00-6cda-4d6a-8b94-3a1b37ffa479"),
Guid.Parse("590711ef-7a9c-4ad0-9088-ced2fc72b3f1"),
Guid.Parse("df1519eb-970d-46d9-a756-b76592900001"),
Guid.Parse("3fb54ced-4159-4886-a386-8e5f91e1aa52"),
},
},
            new GuidMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Guid[3]
{
Guid.Parse("02542aed-df4d-4647-92ff-99b174bfb1ad"),
Guid.Parse("e27273f5-beff-41e1-aaaa-80655b8b97cd"),
Guid.Parse("2ce5f2a8-83fd-49cb-8ded-5d4d819d05f4"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.Guid[4]
{
Guid.Parse("5ee5d49a-5553-4808-a96a-67700156c052"),
Guid.Parse("197dd2d0-72cf-4b01-92a6-16507efc219e"),
Guid.Parse("919b4e81-d1c9-41ee-a11e-5208e0d8a3f1"),
Guid.Parse("f9284f37-1a01-468a-91e9-1200ac38a81f"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("88ac6439-8d7d-49d7-bf0f-8c7564c94891"),
Guid.Parse("9ce6d3e6-27fb-4e54-923c-3207a2f5c79a"),
Guid.Parse("d9acfa76-c5ee-449a-9f39-d24c2e8c5bd5"),
Guid.Parse("ea9922fe-3861-4ae5-acdb-a4768b59fa85"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Guid[4]
{
Guid.Parse("9ed59151-f6b7-47de-8281-ab089ac84cca"),
Guid.Parse("a33552f9-d2b6-4aeb-986b-d2aaa2818ca5"),
Guid.Parse("6e81a3db-8f2a-4e3c-914f-156214c25c7b"),
Guid.Parse("85a70fde-55bb-4a15-a055-de1a05f06eee"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 112,
    Value = 
new System.Guid[4]
{
Guid.Parse("11db7d2b-f302-4c3b-819c-6ef5373bc768"),
Guid.Parse("7d3f7140-61ec-4644-9896-863919f72723"),
Guid.Parse("9ee72df7-eec0-465a-97c4-304db1ea7290"),
Guid.Parse("0cf29504-3106-48f0-8b27-50b38be52c7e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8f383569-0520-47d6-ac08-b4abe46d2f4c"),
Guid.Parse("1841cae7-df5c-4b43-ba6b-deac703f6f55"),
Guid.Parse("6296b7b8-eb98-4a52-9e0b-2eba71be2195"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Guid[3]
{
Guid.Parse("ff468b7c-e784-45f4-a52a-7ccdb9459527"),
Guid.Parse("aba509ce-c236-4334-b67f-b9a1b1fa27bd"),
Guid.Parse("444dd924-998f-4d32-88d9-894c48106773"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 118,
    Value = 
new System.Guid[3]
{
Guid.Parse("86f845e6-7099-4a42-916f-f4307f2731f3"),
Guid.Parse("d013b00e-891f-4f98-b3de-54f3bd5a22a7"),
Guid.Parse("6b9bdb83-c9d1-4478-945f-6a3c44d0dca4"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Guid[3]
{
Guid.Parse("44e6f05d-57e2-43a7-a3fd-01c534bcbfbd"),
Guid.Parse("f95b2122-c468-4b32-94b2-bb3c7f473d81"),
Guid.Parse("b02a8465-dfce-4357-a4aa-c44591f9569b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 122,
    Value = 
new System.Guid[4]
{
Guid.Parse("7db1171c-f02e-4d8a-b8b7-300604a81991"),
Guid.Parse("19f90d1b-c92a-47bf-96a9-ca926039e522"),
Guid.Parse("14bbd569-30fb-432f-9b1e-c0f5562dca1d"),
Guid.Parse("3bd6b44f-6049-4858-9b59-e93f0557a54d"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e63d5bbc-954f-4a42-b706-4f72a3a171d8"),
Guid.Parse("36702faf-c831-49e6-af08-d340f3a33d0f"),
Guid.Parse("7b1f2f2c-394a-4bc6-a04c-b37a6d374505"),
Guid.Parse("bf6d398b-de06-431d-8355-bfb3d9707a7b"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Guid[4]
{
Guid.Parse("9e800e30-f901-4d60-8691-06f634743f0b"),
Guid.Parse("2548a8cc-a020-4c2c-9149-8a6f6ed6d224"),
Guid.Parse("1d52b3d3-c487-4c4b-89d7-94cff0a778b7"),
Guid.Parse("75e20c11-0b20-43b8-9b77-a0e8a5d3796f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 123,
    Value = 
new System.Guid[4]
{
Guid.Parse("cbc1f978-fd0d-4269-926e-288e09e2d5b8"),
Guid.Parse("9b4d86ea-0aa3-4b0d-bdd9-214aa4ecd676"),
Guid.Parse("fdc61823-eae1-4d3b-814b-f3c58d572397"),
Guid.Parse("aa673672-a1d4-4391-a5dc-a2adda30d1a4"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5d110225-cd22-4493-b0a7-7e6fafb5164c"),
Guid.Parse("acec6eff-5263-4bff-b910-28f4c2289bbd"),
Guid.Parse("32142b74-9cac-4c7c-b930-901b6a9a1a52"),
},
},
            new GuidMArrayD1E1M
{
    Id = 159,
    Value = 
new System.Guid[3]
{
Guid.Parse("8b221eed-8000-4544-af9c-9a2dfd75528d"),
Guid.Parse("d9487a03-0c76-41f7-a963-a512fd031559"),
Guid.Parse("df7f8f63-ce24-4b98-b656-7fe9a2613eaa"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 125,
    Value = 
new System.Guid[3]
{
Guid.Parse("71aff7d6-4ae5-47b7-b1a6-7a3c5ae2b264"),
Guid.Parse("b110e53f-b337-425d-9858-0d8c282e8862"),
Guid.Parse("ffb4e5ef-232e-4d1a-a7d9-7f0e9893a432"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("04a1fd8b-0bed-4eb0-bebd-d496d2d3b9eb"),
Guid.Parse("7371c8dc-1b31-4320-aff3-0afc58edb621"),
Guid.Parse("dc7a56aa-927f-49fc-afe3-918b99385ff2"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0baa8aa3-b22c-4902-9fc6-5792cf23921d"),
Guid.Parse("37e25400-032c-49fd-829f-07624a20a7e1"),
Guid.Parse("4b39c3a6-c59f-4389-9e50-6f4b1c3daf52"),
Guid.Parse("cf9abc73-8d17-4151-9f69-ae7e07019d34"),
},
},
            new GuidMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Guid[3]
{
Guid.Parse("0bd35c89-bf13-417a-a184-3aee15539d43"),
Guid.Parse("16397cc1-414b-4feb-9468-0d39489edb9a"),
Guid.Parse("59064be4-5278-4d8d-af59-adea3f284f40"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 134,
    Value = 
new System.Guid[3]
{
Guid.Parse("bc938f44-f9f0-4a28-984d-edc4f9b178f7"),
Guid.Parse("0dc7cf31-8a63-41ff-8797-ea6e7a54eb1e"),
Guid.Parse("10ba89df-58e9-492f-8faa-172bf4f24ef8"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("849ae297-e937-45b3-9d34-e78345a5daaf"),
Guid.Parse("7086ae95-eeb0-4e4e-aef8-ae5fcd9a9adf"),
Guid.Parse("8d4a93a4-19c3-4ddf-858e-078f754af380"),
},
},
            new GuidMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Guid[3]
{
Guid.Parse("07befd92-4669-476c-a114-f345ca14aeed"),
Guid.Parse("4b210661-f556-4c20-a9fb-30b2755768e0"),
Guid.Parse("667ac6c7-efb5-47e7-b848-5b0a9083c1eb"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 137,
    Value = 
new System.Guid[4]
{
Guid.Parse("4b8a8c9c-f7bc-423d-b9c1-24ce4460e554"),
Guid.Parse("ac8888c5-7620-4f25-98b3-b5e64030c734"),
Guid.Parse("1966581c-d790-48fc-a029-3df473ede52b"),
Guid.Parse("d0b839d4-e4f5-46d3-9a0d-afc1db0ace55"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("200cbd0f-6d4b-49e9-a23d-7d8ae1ab3922"),
Guid.Parse("1bbc297e-a265-4e4e-836e-52bbf507b0b9"),
Guid.Parse("a85d9cfb-186f-41dc-ad69-7e29c985d40b"),
},
},
            new GuidMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Guid[4]
{
Guid.Parse("a37e7d1b-15f8-4097-85ec-9b4a25309799"),
Guid.Parse("8b82fc9c-1fe6-48a8-944e-00346b1fc943"),
Guid.Parse("f11bc8c7-1117-4ba8-b00f-6a576b9de0a1"),
Guid.Parse("59529d4c-1b22-4881-a8c3-92955fa5b35f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 138,
    Value = 
new System.Guid[3]
{
Guid.Parse("17abe219-c221-455c-847a-cdddf0003296"),
Guid.Parse("582fb3e4-0b1b-4ac2-9f67-f3ebae32d214"),
Guid.Parse("5bf73e46-21b3-45b8-9166-2c0358fd9977"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("97d328ca-1f7c-4592-9b53-134bf34d476c"),
Guid.Parse("d35acf1f-589e-458c-8637-c06694540059"),
Guid.Parse("55bfdb5c-d6a4-4ac8-b674-50a5eb1c1b07"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 177,
    Value = 
new System.Guid[3]
{
Guid.Parse("21814063-e3d2-42ea-ba3e-f42c25c616be"),
Guid.Parse("cccc6cc5-95da-42f4-83c3-e8b7db868a85"),
Guid.Parse("a7529e4d-4dfe-47e8-959d-33aee86fb0ea"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 144,
    Value = 
new System.Guid[4]
{
Guid.Parse("2c736d8b-51ea-4167-9231-1ddb60f7ea6c"),
Guid.Parse("32b3b08c-f364-4b76-8f1a-2ef4e9dd01ab"),
Guid.Parse("922a1d6d-4592-471f-aa7a-1cd286ba9501"),
Guid.Parse("5300c587-faf9-4d03-ad1d-05cace067eb7"),
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidmarrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UUID)}, 
    {mi_id:Int32},
    {mi_value:Array(UUID)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IGuidMArrayMArrayD1)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IGuidMArrayMArrayD1)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.guidmarrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IGuidMArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IGuidMArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

