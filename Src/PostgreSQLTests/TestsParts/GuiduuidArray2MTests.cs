

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("416c0d66-2c2e-4f63-97c5-a54e8f00fb5d"),

Guid.Parse("50621d6d-08b3-4cac-b89b-f19ead4d13c2"),

Guid.Parse("5662055e-09e0-4630-b121-bbc04e534f44"),

Guid.Parse("b3665852-6f79-4eaa-96b7-cd79ed6563bc"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ea3512c5-3105-4c89-ac0a-c50c82813494"),

Guid.Parse("5fc0fa50-de78-40a5-9b26-e1d169753152"),

Guid.Parse("3eff3186-39c8-4c4f-bba4-3d793d6523f8"),

},
},
            new GuiduuidArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0c80086a-cc16-4173-8f9c-d5508ddb2bf4"),

Guid.Parse("7240f5e6-a590-4a81-8724-883a3c41177a"),

Guid.Parse("4dfdf10b-b8a4-4bfa-9258-e25948aa034a"),

Guid.Parse("bf5b0ff7-d26f-4a17-aea8-01cb62cf320d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d0d85825-7723-4505-b783-ff09f2cce478"),

Guid.Parse("7c430349-c787-4788-8d57-eb001a79f64d"),

Guid.Parse("fb157279-27c9-478a-8175-d8d7bbe31f2b"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64faedcd-433f-4485-9c63-18339321a70d"),

Guid.Parse("e2aad0d0-e61f-4800-9f56-280492a4c7fa"),

Guid.Parse("657bd62d-a8e7-4694-a206-9163a2eb0dda"),

},
},
            new GuiduuidArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9b1f1bbb-76e3-481b-81e0-93de839fb94a"),

Guid.Parse("a6b57d6d-7380-4406-817c-51d583119a6d"),

Guid.Parse("5c6fccc9-6c5c-4dcb-ae19-26dc18298543"),

Guid.Parse("fec21e66-4fb5-480a-a34a-c949110ab05d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("66537352-b9ea-4694-92db-38a5c2fdc7e4"),

Guid.Parse("94e97ece-752d-4f43-a22a-c049dfd5d312"),

Guid.Parse("302ac65d-18d6-4f5d-9ab0-d7d3ae8b88eb"),

},
},
            new GuiduuidArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c27900f6-7fd9-4f28-ba61-e79eb5820404"),

Guid.Parse("bc3df6a5-ea46-4c16-b65e-44b2b321fc62"),

Guid.Parse("7cd02054-5bb0-4196-ab8d-8819a8b31b73"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7b7b223c-aab8-4743-a068-42912b364373"),

Guid.Parse("510f7dbc-13c0-4fd6-a4fa-bb0a670bcdf2"),

Guid.Parse("30597397-77eb-4508-89a5-67acac939969"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a9977fc5-c9f7-41df-9e53-156c46b83e71"),

Guid.Parse("9dd6a5f5-aac2-4a1f-9742-300d59c39494"),

Guid.Parse("7ee9087a-81e4-4edd-88ba-a528d6b3eb02"),

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
Guid.Parse("d17cf8ce-30a8-4a80-acc5-da81b9db41cc"),

Guid.Parse("def2a830-6455-4ac3-837b-2945425a8cd9"),

Guid.Parse("e22ca140-f655-41f3-9e0c-fe6f49380625"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6cb3525c-43d5-48f5-b667-f9e7c3cde552"),

Guid.Parse("b747ba12-0f4d-4e2d-aec9-c43bc16048d0"),

Guid.Parse("7e55a19e-e0e9-4311-b29c-3e966375777e"),

Guid.Parse("060944a9-4a64-44c1-91dd-651ec044f945"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fcee94b3-791a-4c77-8bf2-b4242ec2497d"),

Guid.Parse("a6452a9f-443b-4368-ad18-44778efdf188"),

Guid.Parse("6720feb5-c5f3-46a0-83dc-22c77527cbe4"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("998bb9cf-a4f2-477e-90eb-3a84d97f9650"),

Guid.Parse("bb3eb2ba-8747-4b5b-a905-54926b2f1e97"),

Guid.Parse("06164633-5aa7-460a-b634-e081d6e7a61a"),

Guid.Parse("761025b8-6c01-4b80-94d6-43b08aa5c2d6"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("31be2c75-b272-4fec-993a-eedbe4eab64f"),

Guid.Parse("60912769-c43a-4777-aa34-2df30b40da32"),

Guid.Parse("02940f35-8601-48da-998a-c4f9cf2e7b1e"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ced82bad-ff80-40bf-9472-115564327690"),

Guid.Parse("c3dc0a57-8946-47dc-b066-1d8fb144b66e"),

Guid.Parse("1a7f28dc-8504-454c-9d0b-a87887a39730"),

Guid.Parse("f20fa331-3787-4235-9620-d7db5317541d"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("07ce01f8-056a-4a6a-b91b-67c7b65bf9c6"),

Guid.Parse("3f6b2ae3-2203-4f9f-869b-e0baaee84f14"),

Guid.Parse("d1ba8111-8d2f-4656-8e31-097de9b6f528"),

Guid.Parse("b92a18be-38fa-4362-89cd-7d01bca96803"),

},
},
            new GuiduuidArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("57e2e4bd-119b-47cc-899e-9253ff094a8d"),

Guid.Parse("514efbd0-7725-40c6-9697-f6ee6aa8a5c5"),

Guid.Parse("9ad5313e-6ee0-48af-a453-8e804e46ecb5"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("884fb2d9-2f71-44b8-879d-06370e7e9c52"),

Guid.Parse("b87e6d48-d327-4eec-adaa-9c47eea2eb3a"),

Guid.Parse("358a287b-a39c-405b-85ea-145bf332191b"),

Guid.Parse("ae10b79d-639b-43ee-82dd-f31213e6d082"),

},
},
            new GuiduuidArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7ca5300a-95bc-4607-ae4e-47c60ab4a72d"),

Guid.Parse("28aacafa-5839-4d18-b845-fffe5ae6d1ee"),

Guid.Parse("231ac198-c078-4539-b209-32a9bdad6ec8"),

Guid.Parse("be2220ff-f0f9-4633-8c7c-c09ef0c03965"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9d30bf2a-862a-4b1e-8c4e-ecd52528b431"),

Guid.Parse("0875e3d5-bc04-46e8-8320-f507b639b3ed"),

Guid.Parse("54fa5565-63ce-4d13-a6b6-5957ef810c54"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("992bafa8-10da-4f70-8624-3a2257f34f58"),

Guid.Parse("697c6d87-dc54-4b22-8f95-fb6dca7f9467"),

Guid.Parse("609ef301-17c4-42a8-8ae3-aa886cea2806"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4a49a9a1-39fd-4a44-aba0-87b696144178"),

Guid.Parse("81f8ebbd-0aca-4a73-bc5d-b661d3bed794"),

Guid.Parse("8fe3e955-4135-4dfd-b435-82bb180bf0b9"),

},
},
            new GuiduuidArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d0ebaf70-a8dd-4b23-9370-b72c8d3fa5ee"),

Guid.Parse("ec4e7cea-c294-4833-beb5-e69b548821e1"),

Guid.Parse("9beb9dcb-52c3-4b5f-a226-bc70a7aa603d"),

Guid.Parse("4871d952-d53c-4c6e-9ad1-235f56d19ca4"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8d96d866-df6b-4d3c-a710-043d67015988"),

Guid.Parse("f9e4ce77-bd89-4b79-b8d6-59e51a88653d"),

Guid.Parse("b68b82a3-4e22-4cf4-8ac6-42f0b47fb6dc"),

Guid.Parse("124383fa-67ea-4677-b147-04f9040de3cd"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5725bbc6-f8ea-4e18-8eb9-f6db8da88858"),

Guid.Parse("3fd3a983-ea8b-4030-ab29-edc4dd052ee9"),

Guid.Parse("1e4baf63-75ce-41b0-b999-851307d81db4"),

Guid.Parse("4ee0767f-8d54-4086-b62e-2fd21f429de7"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0d21836e-c428-4ed1-bc6e-46e9b26fa870"),

Guid.Parse("336168a5-a495-4457-9030-3b8171ba1b12"),

Guid.Parse("f5483a8b-7a78-49b0-a700-237ca4531bec"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7287d93d-225a-42bc-9152-8dbba17f70b6"),

Guid.Parse("8c8401a6-34c0-4362-b8d0-7082c97c8c5c"),

Guid.Parse("2f9d39fd-cdf4-48d1-987f-4872b38817d3"),

Guid.Parse("91439865-fad9-40f1-9e7f-ef0b7f662cb4"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("95250651-9ccb-4838-b780-b02dddad4358"),

Guid.Parse("f919d9ba-ad53-4402-b47a-c43a1806580b"),

Guid.Parse("cec0c6fb-4bea-4176-acfe-b32e8e62b7e2"),

Guid.Parse("18dc900e-ebf8-4a29-bdc5-b39d541323cc"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("800c1271-a499-4a72-8385-a944296cb910"),

Guid.Parse("eed9c030-91e2-4d26-b17e-03f75081cc6e"),

Guid.Parse("c29d880c-3819-4576-bbc1-c09fa48676e3"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8a197d8f-21c5-468d-bc16-b6d49a5b9a15"),

Guid.Parse("48167d97-66d6-4c78-b852-9aad4c3758e3"),

Guid.Parse("8bee584b-ae6c-47ce-bb90-796c8b87fc0c"),

Guid.Parse("2b779efe-ee0f-45f2-8a4b-f0c2d1c757c5"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("70390c62-6202-4eef-b5ad-e6388829165a"),

Guid.Parse("5cb7eaa8-a7ee-4dae-93bd-2ed7f8111a89"),

Guid.Parse("caeb7e00-87da-4575-919e-0c4e679f3743"),

},
},
            new GuiduuidArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c20b37fc-af6a-468a-b8f6-2aa4d3134e93"),

Guid.Parse("b67e3401-b80b-4104-9b3d-ac747ba88cf1"),

Guid.Parse("7d22869f-bb27-49cd-95de-ce149a92a26b"),

Guid.Parse("d74c5cec-dbf1-42f9-82eb-94ac28fb6f80"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d9201288-61a8-43a5-92ab-afa43b880b51"),

Guid.Parse("3aa0ab96-407f-4218-ae4f-09990082a5f8"),

Guid.Parse("2dc687ad-03f7-43a2-8991-5509bb735f6a"),

Guid.Parse("a0b1a2f6-b803-4f75-8a2f-413252e69ec7"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("86f2eee3-55d0-4264-82cf-51697ad848d4"),

Guid.Parse("c254dd1c-61d2-41d3-afd2-05f08008caf8"),

Guid.Parse("c2721c6e-fc49-450e-962d-a6dc68d68aba"),

},
},
            new GuiduuidArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f6192096-ea96-44f3-9d95-2889b09eda36"),

Guid.Parse("79bcd7c2-4a95-4c22-b01e-88a3bb59770e"),

Guid.Parse("5300a5e7-8e5b-4187-823b-f63b819c8227"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("30cfe259-0f3b-4c2c-96e2-88e2b53daa4e"),

Guid.Parse("65615b8d-ec12-4059-aa61-7cce21d5c97a"),

Guid.Parse("fa826bed-5cae-4bc0-9203-97bb08092416"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("da3f131c-e2d6-43e1-95a4-5373176dc36d"),

Guid.Parse("f2b1af23-b76a-44d7-8b31-ebd215c4f211"),

Guid.Parse("f1593583-3f0c-41e8-aa91-7f9d6abb4f4c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("47c1a370-5147-40c0-9376-afe02632da55"),

Guid.Parse("3971ddce-b718-4681-baa1-5148b7aff8d3"),

Guid.Parse("fdbe2db2-51e7-4ed2-8810-430505f38a6d"),

Guid.Parse("1c5f2ee3-2696-4805-ba44-b49a5d90bf7c"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("68591a47-cdb8-4ba6-837e-2ecd50b34218"),

Guid.Parse("acd472f0-79f3-40f1-a8bd-6fae6c784b27"),

Guid.Parse("92c3faaa-51de-4632-a10e-026edab04c0f"),

Guid.Parse("ba43d773-654a-4e4f-84c3-3454ca4d3734"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5b5afa7a-f2ad-4dda-a7ed-edce38191bbd"),

Guid.Parse("7537080a-f1c5-4394-99fc-1a2df098e369"),

Guid.Parse("fc4e1790-d0f4-4e95-8c2d-788845f9daf5"),

Guid.Parse("96cf8910-1956-4630-91c6-0ffad6fdc80b"),

},
},
            new GuiduuidArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1afc6024-ee3d-493d-92e1-70328d33230f"),

Guid.Parse("1877369f-626d-4c03-9f46-5371ce8fbe37"),

Guid.Parse("01b75f8c-5aab-411b-89b4-3050d3b5a737"),

Guid.Parse("560cb10a-1f67-42e5-80b7-6c0bca3a92c8"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a283648f-8dc7-4a81-99be-79b26a4e85ee"),

Guid.Parse("2c776297-fdf6-4274-ba5f-3693055ef3d9"),

Guid.Parse("03058db7-0db4-4ca7-b83f-b04dde538210"),

Guid.Parse("bd85a1dc-73a4-4173-a0ab-fa10c9c12eb9"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6b3f32fe-5d53-4f6c-b8c2-11e1bb26ec80"),

Guid.Parse("dbdf3bcc-0b0a-4deb-a4bf-2ca4417093f7"),

Guid.Parse("f521a289-8b4f-4d1a-9f4c-3eef466acecd"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a9c2cee6-6c0b-4e69-b2b7-fac5df92e381"),

Guid.Parse("876be32c-be13-4ada-843f-b47704b4c645"),

Guid.Parse("6e0b3371-f473-4489-8044-84dac5ad8827"),

Guid.Parse("fa28a102-decd-4c48-ac8b-0cdfa56b15db"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c13bd08d-27ab-4763-bcbd-22d21e0258fb"),

Guid.Parse("6ae91b70-71af-4656-8d06-1234d62700e5"),

Guid.Parse("5ad5d701-6a70-4217-b99b-71b372555721"),

Guid.Parse("d4460f62-8f3e-4a1d-9230-4740b3dc2a7b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f403a222-c52b-4204-8c13-3b12108507d8"),

Guid.Parse("08cb94f7-10e0-46d4-a859-50feedaa2ab6"),

Guid.Parse("c8146fd7-a050-40e1-aeaf-a94f0daca542"),

Guid.Parse("6b3c1945-336f-4061-aa6d-61a306a53d93"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d9de8e8a-896c-4a56-a4ef-2f8a50700c29"),

Guid.Parse("b454065d-1df6-4b0a-b317-b4d7460bb05b"),

Guid.Parse("f2a643ef-39dc-4202-b387-ed382ce5d06c"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c28f84cc-b120-4090-a7ca-af35bb1b9cf6"),

Guid.Parse("e49cc19b-56ff-4f03-a954-119daec2dc74"),

Guid.Parse("13ab869e-b722-47f0-86b7-92a47eb6794c"),

Guid.Parse("0d0d0f7d-80e8-470c-b1c4-e7c7d210b049"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8737a9f7-11ec-4ea0-913e-c414c592555c"),

Guid.Parse("8e5af1ce-80b9-4c0a-ab28-af38615654ef"),

Guid.Parse("69b8ed38-afe1-450b-b0f2-7a406c1924ab"),

Guid.Parse("7a7533ec-b407-4c41-84bc-3965ef42298f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("779787f2-1680-4b26-a5d3-f81904ee9b90"),

Guid.Parse("a4f6ef97-02aa-4a86-a5f2-d8c891659131"),

Guid.Parse("de0cc3cd-7e4e-4c30-9734-762e7fabc590"),

Guid.Parse("23c854a3-8c71-42d6-9f42-88c47cd22d71"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cce5011d-61a3-4a38-a42c-2c95df980379"),

Guid.Parse("a6c3922f-bb88-4d4b-9beb-a582043dd7ff"),

Guid.Parse("43187986-c9a5-4eeb-824e-0ef11ac791cc"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("38c4efca-6bf2-4105-9c3a-84493a4f6bb4"),

Guid.Parse("8ccf2008-64ce-4478-94e3-1a8edb7aced3"),

Guid.Parse("2db8ee13-d910-420d-8136-deebd82f34be"),

},
},
            new GuiduuidArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4c49f7a0-9015-4870-8765-da14938683c9"),

Guid.Parse("f5bea54a-819c-42f3-b572-77e4d44ade96"),

Guid.Parse("583418bf-d527-4acc-b81e-4fefef959fd2"),

Guid.Parse("19445140-f358-4e4d-8413-3f7c6a294ee0"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b2c58167-7d3e-48cb-8468-2ba94167fb15"),

Guid.Parse("8c76fa5f-edc5-4a66-874c-0ed62ae865f6"),

Guid.Parse("173eb357-b1f3-41c9-937b-01701466f45d"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a5827c3c-d362-4f06-a353-d1d4f6b17a06"),

Guid.Parse("020780fd-ed08-4409-bcd1-e83221adb0f9"),

Guid.Parse("f8f4bcee-586e-405f-aa91-9361a039fe7e"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("62b0afcf-233a-44d0-bd27-c5eda4c03531"),

Guid.Parse("26171337-d417-4fe8-94b1-25e6a9ba0cc3"),

Guid.Parse("67eb8a93-48ff-4cc1-b2fd-246d583e1dcc"),

Guid.Parse("35efdbb6-bf52-45cd-a8ea-97f0e472d14e"),

},
},
            new GuiduuidArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("240c2d18-e8af-4c70-a206-c04fd0d86928"),

Guid.Parse("ef38d0f9-5ac2-479d-88fc-4850ce5e26cc"),

Guid.Parse("68f782ce-7763-4580-bb66-19fc71190e56"),

Guid.Parse("1ba95996-2c8e-439d-bae5-a8ef1d7fd1b8"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bd0c1d66-bd82-432e-ac1d-65ca5aa6cd7d"),

Guid.Parse("5d5e8476-ee24-413f-8442-2c993105b8d1"),

Guid.Parse("1f4b3733-a427-4298-8d08-f5cb1cea304b"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0db3fe7f-72a2-40ac-8b02-21032456fbfb"),

Guid.Parse("1bfbac47-1922-4c61-90cc-77dc4f65265d"),

Guid.Parse("7e88ba42-e552-41f1-8b0f-c3a05851c234"),

Guid.Parse("b0fd49f6-896e-44ae-b1e1-071532511967"),

},
},
            new GuiduuidArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a86141ba-e5c9-491f-8f24-558febad5c52"),

Guid.Parse("be4d0126-1c15-4a60-9e26-fc2f0f2d38cc"),

Guid.Parse("17be9b50-0f76-4e85-87d2-613c18b44b79"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0587fdb2-6d16-486b-8844-021ec3275d31"),

Guid.Parse("813400f0-7119-475c-9bbd-0ef84d2b1b92"),

Guid.Parse("aca71258-6e51-453a-ad16-48f9b946b53b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("48bec126-9610-4895-a3a1-31332ca9d974"),

Guid.Parse("0d750ac7-157d-4c1c-af03-6ae3ad34a2f6"),

Guid.Parse("20fb5c9c-1bae-4e8b-b994-21d069a742c6"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cd2140f8-6ed9-4c63-b2c4-7877f86abec1"),

Guid.Parse("c5ddfa8e-e044-455e-b4e8-089023af2a23"),

Guid.Parse("139db179-35fc-4c58-af20-298e846ead1d"),

Guid.Parse("6bca427b-48ef-4540-86b0-77e03b2119c4"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("334b41e5-ec7d-4ce8-9da1-de2017630d97"),

Guid.Parse("4c7b1e17-d0ac-4d28-8da5-0930d1eece63"),

Guid.Parse("fd4ec516-d282-4b30-abf1-38d7bc01ccbf"),

Guid.Parse("27686428-1512-4281-a615-108e63bf7eb5"),

},
},
            new GuiduuidArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8f86e3ba-c073-4b66-b9cd-5e69f6595c82"),

Guid.Parse("19222e5a-a211-4f65-8f30-19984cbea92f"),

Guid.Parse("fc850a4c-cbe0-40cf-a83d-2d220fe1fcb1"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bbbb882d-493c-4679-82a6-fe5880d2559c"),

Guid.Parse("e0a81ad2-b4be-4178-9cd3-db65d21d44cf"),

Guid.Parse("609e2333-e9b3-481b-9a75-216af7bd6b59"),

},
},
            new GuiduuidArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5094719a-c1f0-4012-be56-5131592db142"),

Guid.Parse("a4048bde-a675-4e3d-9130-e29f7fce012c"),

Guid.Parse("037b778f-e1c9-4181-90e8-3093bf907607"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9902fd20-ab2e-455d-9010-350849a7e022"),

Guid.Parse("467f1c35-1f19-47dd-81e4-34575c64359c"),

Guid.Parse("40100b1d-21c8-4fec-8687-de16484326e3"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ecc0bbb2-c683-46c0-b233-db98d25d8665"),

Guid.Parse("5c0a2dc8-c66f-4c0f-91cb-a9c8b1db3f29"),

Guid.Parse("5003624f-81c2-4c12-9f00-2766b87b69c3"),

Guid.Parse("6f5be22d-6ba0-4b10-b859-043f9872759a"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a2ede33-b886-4eb6-9877-9898191cb304"),

Guid.Parse("1b996d34-801a-4e51-b277-694ac8f46072"),

Guid.Parse("e848515a-a606-401f-90c9-1a47b7a4967a"),

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
Guid.Parse("d4991c18-5618-42a6-aecb-f74cce1806be"),

Guid.Parse("4e9e5fc1-c4bf-4b3b-946c-f2f37e531092"),

Guid.Parse("1ad122a4-ee15-4855-89e7-d414cad1cd6c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("728fb9d0-01b5-402f-b08e-17d833530669"),

Guid.Parse("e83dc16d-651b-40ba-832b-e3b5a269da4e"),

Guid.Parse("8e31cc06-28b0-484c-829c-6a06dc6a81f3"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("273f242d-0638-44d6-8915-e75f17356a81"),

Guid.Parse("df6ff03c-cc4d-4350-a5bd-873085de8584"),

Guid.Parse("be795e4a-5653-4c55-b490-8fd56ee6dc4f"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fee93e9c-54f9-453d-aaba-9f8fe45146fa"),

Guid.Parse("4290a002-93dc-4f28-9e27-106e8a54799d"),

Guid.Parse("c17cc90d-2af9-462a-a4a7-3760d69c74f2"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ea2d6bfd-6856-48a6-9c7a-1e2c00661028"),

Guid.Parse("f0cd31dd-18b0-433e-9c00-f67001e1c3c8"),

Guid.Parse("7ad3aa7d-b1c4-440a-b357-97f1410dc667"),

Guid.Parse("9a5806c0-2f7f-40d9-9fdc-2072275fec33"),

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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 165;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
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
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
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
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidArray2M.AssertModel(models[0],_testData[3], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[4], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[29],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[30],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidArray2M.AssertModel(models[0],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidArray2M.AssertModel(models[0],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        GuiduuidArray2M.AssertModel(models[21],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 156, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 144, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
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
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 128, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 174, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 46, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 21, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 7, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 173, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidArray2M.AssertModel(models[0],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidArray2M.AssertModel(models[0],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 115, 173))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        GuiduuidArray2M.AssertModel(models[11],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidArray2M.AssertModel(models[0],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[34], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                GuiduuidArray2M.AssertModel(models[0],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                GuiduuidArray2M.AssertModel(models[0],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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

