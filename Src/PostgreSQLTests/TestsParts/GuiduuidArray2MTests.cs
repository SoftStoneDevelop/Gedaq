

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
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("46a75f9a-0ddb-47cd-aa29-4d71ec548448"),

Guid.Parse("28eb7a5e-f13e-44d6-9a6f-6f6351f28f21"),

Guid.Parse("afe481f4-9021-4aa6-a693-1f6bbb13b5f6"),

Guid.Parse("782b5b3e-4013-4ce0-b137-ebe47660c54c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36ebaa4d-ee11-4363-84b9-2ccfa0aadc28"),

Guid.Parse("5c65ec3b-8692-4dd6-9d2f-0d72249a20f5"),

Guid.Parse("c6d641c0-9964-41c6-9278-bc981cc58e31"),

Guid.Parse("5542b8eb-3f4c-4ebf-b8b6-d18eb294738b"),

},
},
            new GuiduuidArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c41ca5ab-ef76-4a70-ad31-511104d12f82"),

Guid.Parse("9451559c-4a3d-4e15-bc19-e8ac47bde8bd"),

Guid.Parse("b369a42a-b3cb-49c7-a170-9fb8dcb8d00a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e4973731-107a-425e-badc-e8d82ef623e2"),

Guid.Parse("a5ca76a5-8734-4116-a178-162c202677b9"),

Guid.Parse("c654c951-c08b-49a0-bcc2-a72f12d51c40"),

Guid.Parse("fb994ef8-ed66-4af3-b808-e7c65ac06872"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e21aeda5-e65d-4b76-b4c9-45b98c4c9fec"),

Guid.Parse("e852a955-b6af-4c21-8317-24a35cfdcac6"),

Guid.Parse("46d82302-496f-42f8-a618-b5ce83e58aff"),

Guid.Parse("53bff23f-f15b-405e-83c8-3cd62ee9eb7a"),

},
},
            new GuiduuidArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("69a19f27-dc82-4cd3-8d9d-f14539309a90"),

Guid.Parse("b9dc3a6d-2388-4e78-89f1-ea6c8c7ec3e7"),

Guid.Parse("796b29be-037a-487c-ba82-d8fa9ff2b35a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2c3130ac-5287-42fc-a5f1-aa8b86fc9dfe"),

Guid.Parse("d2470bd6-cbfb-4d82-9c92-b6095fca9e83"),

Guid.Parse("3d53e3d4-9851-4d5d-b2c0-4b4fb72c8e06"),

},
},
            new GuiduuidArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3459a4f4-7e78-44d0-adbe-78cd57d6d640"),

Guid.Parse("590e0ec5-d541-4bdb-9f5f-ff4ea773bebf"),

Guid.Parse("8357267e-5eec-4ea2-873d-b779bdc91e3f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8ba8427b-6c9c-4aa1-947e-c446be49419a"),

Guid.Parse("3a37c8d7-12f2-48e3-bb79-0f09de72ce0b"),

Guid.Parse("1c25e1a7-c35e-4f21-ac1a-66c6bcb364b9"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("970e6534-02e2-4ad4-83ab-2be5e9ea2945"),

Guid.Parse("564182b2-1276-4d86-b084-ab81145687ae"),

Guid.Parse("0b7949f4-ad0d-46fc-8b12-5d71164762dd"),

},
},
            new GuiduuidArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("237204f1-e335-45de-88c3-df81204d3a5c"),

Guid.Parse("ae31262a-976d-4ee5-9959-cab905dba780"),

Guid.Parse("96ebfd9c-fa08-4b34-927c-431a4faa7a54"),

Guid.Parse("02312737-3cc3-4a35-a915-9165ba0d6404"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a26150f7-0985-4cb6-9d53-bdd4e7a21b38"),

Guid.Parse("cb4491ed-f39e-4588-9757-8d2fcc9c4477"),

Guid.Parse("334947f0-46fd-47cd-a47d-f7f0cf964498"),

Guid.Parse("80a46e11-1539-4f44-893b-ef067c38c3b2"),

},
},
            new GuiduuidArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f9d6e9e9-5e67-4713-890c-e7dd089616ad"),

Guid.Parse("a4fe6da3-6075-42fe-9733-7463d46ddd3c"),

Guid.Parse("8c4d25d5-c39d-4de3-87d7-28a8c8d5862f"),

Guid.Parse("1494e114-2e1b-4266-af22-f20aa9b68e10"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e7e5f710-7568-43de-a15b-776825f16c20"),

Guid.Parse("294a34a2-30f9-4c80-bcdb-5b3f7c75671b"),

Guid.Parse("b6c9e0af-b9c2-4f98-9ab8-5a3614f79b8c"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("afd22dad-dfb0-4b64-b608-268e6b16df9b"),

Guid.Parse("140bcac8-46fe-40e3-b7a7-60cfd02f1d6c"),

Guid.Parse("0102775e-9249-4d60-8133-3b16e71f2aa3"),

Guid.Parse("bbbee663-2bd5-4e5c-91f7-708c56abf2fe"),

},
},
            new GuiduuidArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("32264002-549f-4fa2-a2c2-c567096ca27d"),

Guid.Parse("582b3968-1a7d-43ac-afeb-253e463ee6da"),

Guid.Parse("cf99fb74-5442-4a0e-83f3-684ca7b49f2d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("698bb447-671c-4f1b-bbee-c31607894ba3"),

Guid.Parse("adf00522-b0f0-481f-afaf-589394a9067d"),

Guid.Parse("f2104b5d-f027-49ce-b52f-0eb37e1d86cc"),

},
},
            new GuiduuidArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("63023f13-54d8-4587-ac2f-6da1d6cf6784"),

Guid.Parse("a6f4d639-3ad4-41d8-84ed-dc1fe89ed48c"),

Guid.Parse("8a16f411-39d2-4043-b493-25c9e254683f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bc1f7351-d971-40ad-9b89-a08f08366883"),

Guid.Parse("e94fa03a-8941-4d62-a321-16a934ebee17"),

Guid.Parse("f8de6602-0700-44bb-bdd7-374acfe5bcc9"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("527da1d6-1d02-4406-9657-5c3829b9b920"),

Guid.Parse("26ca1a5f-10fc-4442-b643-e48601420150"),

Guid.Parse("9f043938-8968-4ac3-9023-22d4169374b1"),

Guid.Parse("1d19c4b1-664c-45ff-aed7-42e01b4d78ff"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("33e8aa7a-3eb7-4ea6-8738-b8fb00e026ac"),

Guid.Parse("0b2b5162-ab12-448a-9105-b998af550d93"),

Guid.Parse("a304d0ed-15a8-432d-8d4a-c60d6f7f4339"),

Guid.Parse("59265275-94c5-4fb1-bd0d-e2424f575770"),

},
},
            new GuiduuidArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("66770242-3f72-4c18-9bbb-13e99a108218"),

Guid.Parse("eab1f2f3-0f20-45d9-a647-d6969d8a1d57"),

Guid.Parse("5238fe8a-c7dd-4215-9c77-f0d916785484"),

Guid.Parse("4ce12496-40a1-4a64-b21f-7161d5ab8df2"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0c47d19-8cb5-410d-9560-ccd5a851f1a0"),

Guid.Parse("fda80b33-cbd4-4e20-92ff-053af35bf970"),

Guid.Parse("cba5f9f0-7ccf-411c-b4b7-9a6851a0baba"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3774c89c-6113-4c4f-8330-7ce3e6e3f578"),

Guid.Parse("5fa94199-8734-4e0a-b81e-09b9cbb4fb49"),

Guid.Parse("19748595-a7da-4c49-9a54-8eb98d19aa6a"),

Guid.Parse("a512ffde-9b76-432c-9502-fd36260e5993"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("59ec90e9-0997-46fc-bc47-3144e0af8c76"),

Guid.Parse("3fbccb15-521e-402e-9718-9ef1aa2fa0cc"),

Guid.Parse("bc4f4e34-228f-480b-b8c0-fd46f4b7832a"),

Guid.Parse("ae108d26-2795-44e1-82ba-74251049f689"),

},
},
            new GuiduuidArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20c0d61d-b4b5-4234-b866-b45225bae9e2"),

Guid.Parse("06def4fd-4076-43da-8917-1c12b3610a50"),

Guid.Parse("dbe97b22-6088-4e44-a9a0-7ce004185116"),

Guid.Parse("7de7cd67-d381-44bf-ab12-ab64810e34ef"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20fc8467-3769-4e3f-816f-fecfda18c1d4"),

Guid.Parse("68a3c26b-c25a-48a7-a71b-51786c587d1d"),

Guid.Parse("4ef449e7-b865-4224-89d0-488dcc795fec"),

Guid.Parse("40879cae-6faa-48c7-96fb-d4f265a0ac94"),

},
},
            new GuiduuidArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d2464dc8-d77e-4c10-b24c-31eb83c6ed90"),

Guid.Parse("8502cae0-e517-482e-b452-9a2b28771d2b"),

Guid.Parse("58da4a41-d75e-457c-9242-dca5a4b74f8f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("dc564461-57fb-4abf-9877-dc80b07c1d36"),

Guid.Parse("86556f90-105d-407e-9944-4ad8a3c49404"),

Guid.Parse("385c718c-0a21-4075-9bdd-4fd5b85e3274"),

Guid.Parse("95eeaf2b-65dc-4a56-ab51-69c17e4a834e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2f1b04ed-9776-48f0-9cb9-da0e87a5796d"),

Guid.Parse("6e6b1a14-12cc-450d-ab15-717920cb3a2d"),

Guid.Parse("a3166942-bc34-4dc8-b728-3f0f1e4f27a8"),

Guid.Parse("8efabf1c-f0b7-46c1-bf39-db3c0bb9341d"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a59e6266-73f6-4f75-bd0f-ed032bd0be3f"),

Guid.Parse("df4f65a4-16d3-4f13-a9a5-1e1ef031ffae"),

Guid.Parse("112b7b34-25c9-41e0-9226-cdbf0b801d14"),

},
},
            new GuiduuidArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ca6e7113-08fd-467f-bedb-63c8d9736489"),

Guid.Parse("9f56e7a5-ade4-4997-aaf0-422e22028f36"),

Guid.Parse("3e979069-7871-45d5-a0a6-5b965bff1043"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c5951b00-7a7d-4e20-bff2-a7d233ba9ae6"),

Guid.Parse("8c8201fc-14bc-46cd-9c03-bc6fbafe5945"),

Guid.Parse("0ad11397-faee-4c62-b740-4262788a193e"),

Guid.Parse("e2d36b85-c24b-4e90-9cce-fdcdd37f9a42"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("12b03a3b-9560-4a69-ac99-dc377cd4b7d7"),

Guid.Parse("7267d032-a962-42d2-8949-d3c1644a59d7"),

Guid.Parse("553d6ecb-0e15-42e8-a054-d59ca9521afc"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ce43dcc9-0a75-46e1-940c-4bda86942c66"),

Guid.Parse("b37f143f-fe34-4350-be8e-e9bc53a2777b"),

Guid.Parse("a30e2677-81f0-48ef-9be1-6dc1591bedda"),

},
},
            new GuiduuidArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("67c0dac6-709c-4111-bcf2-6dafec5dc8cf"),

Guid.Parse("e3b09d26-e9cb-4298-849b-5af7c0570c14"),

Guid.Parse("21e7894b-90aa-488d-8642-89235f4d8362"),

Guid.Parse("581a9277-a69e-4e27-b379-2b2e6672c306"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e51a12f0-d832-41a4-a2e2-9969f0c59fa5"),

Guid.Parse("64e5a0e5-ac62-4601-ac86-316b35d8111d"),

Guid.Parse("7ed8e9fc-a41b-4df2-8431-a48a37372093"),

Guid.Parse("8df317ee-ccf1-4d32-bf76-ce4ede1b05dc"),

},
},
            new GuiduuidArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1bddc1da-9768-4f8d-ad55-6e549aed654f"),

Guid.Parse("54fc2c6a-d8c5-46ad-832d-7540786d847e"),

Guid.Parse("2f9a8edd-e899-48a2-975d-066a4f6c2049"),

Guid.Parse("9d168de6-cbd4-46bc-bfd3-e298ac686aca"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8f305bed-faad-4d23-bbfc-83a5daf35048"),

Guid.Parse("45612708-e307-46bb-aa09-1135bf8e209b"),

Guid.Parse("6ed1fa7e-2e70-431d-8428-c6542ad7663c"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("27a6d279-1405-4630-9001-e390ca43e868"),

Guid.Parse("5e7fcd3d-eeee-4d22-b8c1-c628a143982e"),

Guid.Parse("ed22823b-de46-4c3b-997c-529e40c49f0b"),

Guid.Parse("c77d3976-1820-473d-817e-514251fb5151"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f91acab6-1596-4a59-a67f-e798885c8845"),

Guid.Parse("108d1b1b-5034-4596-94a8-6f1f22bd7561"),

Guid.Parse("19576a1b-374c-46cf-9ef5-fe881bf719aa"),

Guid.Parse("f5d3a611-b044-40c3-8252-e733d46fb7ec"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9616511d-2d68-4ed4-b639-2c9621cc80e6"),

Guid.Parse("f6fa8bbc-7794-4a94-a940-ee7e8ab8ef6a"),

Guid.Parse("36b2d09f-6caf-44d5-9060-092dca3cf284"),

Guid.Parse("c37413d0-4025-46a9-8735-2e6cdcc52494"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dbe4e12e-b9af-4f1f-b6b9-e89727b951f9"),

Guid.Parse("5d0f1b22-dcab-4bf6-a819-373724d62941"),

Guid.Parse("62bcb78b-3f1c-487b-b165-7c7186b46b39"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("70ab8dc1-46a3-4734-b097-18f8fbff1778"),

Guid.Parse("717416de-e8e8-49bc-901e-33a420560297"),

Guid.Parse("b53c7841-50a3-499a-a29c-e382b680cfdd"),

},
},
            new GuiduuidArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b03a893a-c8f2-4e80-b621-cd8926621a4a"),

Guid.Parse("945d0a93-aa29-4e37-a9fb-962def9f393a"),

Guid.Parse("d36dbe5d-a5fe-43a8-8f77-f0233d048de5"),

Guid.Parse("4c684fb7-3c71-4386-b4ac-2fbed7757ee4"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("dfcc8736-d346-468f-a648-28548a94b8ce"),

Guid.Parse("c88f7222-b34a-4f03-8617-12593817bada"),

Guid.Parse("2c8fd906-2626-4a9a-886e-c1c23378d4e8"),

Guid.Parse("07ae0452-7cf7-49ab-9013-0d36b60cfd90"),

},
},
            new GuiduuidArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("785aeb2e-5f28-43b0-87bb-6a388aba9ed9"),

Guid.Parse("17587bc4-5328-4088-bfe1-cf0f0f0a8a97"),

Guid.Parse("5561b0ba-cf04-4a5c-8b11-41b008cb647e"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("09cc4d79-1594-4f9d-a5f4-bf5b5aa78a25"),

Guid.Parse("2afd4ad0-a57c-4c35-b911-e4579822f94f"),

Guid.Parse("fdb0851a-e8de-4639-aa39-c972c4dabf70"),

Guid.Parse("4315d0ca-2cc4-464a-8b56-53e80b8a45c4"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b837a272-8e77-47f1-9a1d-6ee83caced74"),

Guid.Parse("eb0d28f5-8148-4c12-82bb-ce277ed37fca"),

Guid.Parse("be6d5ef7-e8fe-4a98-98a5-fa7dc5ca16bf"),

Guid.Parse("e83ad404-8318-4fcb-a79f-e93e48656d31"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6cc0c586-0096-4dee-8b52-8408e1abe90e"),

Guid.Parse("6a771895-f7ff-414d-bdb8-4084d027b022"),

Guid.Parse("cdd2f78c-1ab1-4133-8930-cea9ed997bd5"),

Guid.Parse("f72403cf-e433-4550-9662-4ec58918ef5c"),

},
},
            new GuiduuidArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a86d347-0026-44c9-8f46-1b9b6a08cb82"),

Guid.Parse("e4e840f6-16ba-44f4-8ad1-dd7f14bdaf06"),

Guid.Parse("d945ab1e-44fa-4b72-a54a-c591531c174a"),

Guid.Parse("b3e1e00a-efe9-4478-affd-179803d9399e"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e87191fb-7942-483e-b064-f1eb36dcf26e"),

Guid.Parse("83bb9279-2244-44f8-9d22-33f6075f7445"),

Guid.Parse("0cb6d2d7-b341-4ed1-beea-1fb4c3dabd71"),

Guid.Parse("9c7d3386-dfb7-4a4d-ac68-8569d439da81"),

},
},
            new GuiduuidArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2739d98a-1a6c-420c-936a-8926e7994dac"),

Guid.Parse("1c7e851e-0a27-45af-a6db-c0db2b7d1782"),

Guid.Parse("d224668d-5d5f-4ef3-8541-4ee2ed54e53a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("024eaf89-eace-49b5-8c9c-5a1600a7e584"),

Guid.Parse("9cff8d6a-5bcb-4646-a08c-c5d7883966fa"),

Guid.Parse("46ecb0fc-c930-4aab-98eb-b9af196b27b9"),

Guid.Parse("09cd09a2-3baf-4670-9957-a716f2713e4c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("da6a33fa-69ad-4d86-9e56-6d3b5714c27f"),

Guid.Parse("59e9ad16-12f7-44e5-92b5-bb8dfc45c0ae"),

Guid.Parse("bae7381d-ad47-4d6d-a461-73c9e4bf015d"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fa784376-1e67-4ff2-85f3-f72b848c8e2e"),

Guid.Parse("d0c0d9bc-f6d2-41da-bae5-d58bd70a36da"),

Guid.Parse("f56a6fb8-c8eb-4f29-a00b-a4a0a5bd867e"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9d675fba-a8a8-49c8-907c-a35b56c17fcd"),

Guid.Parse("2c625391-e698-460c-ad30-c5a822362329"),

Guid.Parse("3d5c8630-e726-49c5-a9b1-d30578264dc7"),

Guid.Parse("a94bba8b-3736-4163-85f3-0eb15db2d86a"),

},
},
            new GuiduuidArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("40de1636-4cbe-46b8-a67d-75d807b3512a"),

Guid.Parse("7748803e-f44f-4aff-8011-6ecfd090d6aa"),

Guid.Parse("019fcf51-0d3f-4cb1-babb-149ff1ace06b"),

Guid.Parse("06e21bda-8404-44e4-832e-b21eadcd48ed"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20fe7c62-2a01-48b2-9737-1303ec4741fc"),

Guid.Parse("c03d1bae-325d-4566-8d59-4498f64031c9"),

Guid.Parse("c9ccae17-584a-4a44-bc4e-ac0c892030d8"),

Guid.Parse("a049c842-b9ae-46da-811c-40c193b5190f"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1f7cf4bb-b93c-4f69-9e58-e42ebc03a9a4"),

Guid.Parse("cd6923d3-c9bd-4ccf-9e45-32d55097c854"),

Guid.Parse("be162cd1-4220-403e-a6a2-c52c4f74ad3d"),

Guid.Parse("d5d88728-4efa-4551-bd85-b83a2f9a4d71"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cc7298fb-e4d1-44c6-9600-2cbbb4b31e04"),

Guid.Parse("457cf368-0236-47ae-a4f1-77a2494a419b"),

Guid.Parse("e482e4a3-39ac-49cd-ba72-af27f7807e6c"),

},
},
            new GuiduuidArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5436f5a8-f52a-4f39-8fe8-9d63a8c65694"),

Guid.Parse("bad45e41-c8d5-479a-846d-03d2849b03af"),

Guid.Parse("3cdd52e0-2eaa-4005-a13e-92897fbba566"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7b8adb1f-52b0-414c-9433-81c2ed141494"),

Guid.Parse("999102ae-3360-40ed-873c-893dc7095aa3"),

Guid.Parse("2682e12a-8afb-443f-bf06-5060fbfae9e5"),

Guid.Parse("abd1fc80-b460-435f-97bd-8a1dc264a9ef"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0ff8b230-b89b-48dc-bf2f-35eb3a582eee"),

Guid.Parse("d5fbac5b-d303-4b6f-b49a-7ec005d8fd84"),

Guid.Parse("e9d6c5d0-0cbf-4c4a-a98e-c51951b0cd41"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a09c9fb1-9ecb-4080-97e0-8c713e910652"),

Guid.Parse("a34f0a9d-4414-429d-bfcc-f38aa1fd0056"),

Guid.Parse("078f936c-1b68-49c4-903a-d407f7479d01"),

Guid.Parse("e99b7ac9-6ca0-47fd-abef-af3dddf20ad9"),

},
},
            new GuiduuidArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9826a0ec-78c0-4c67-9247-0fb94f3c4a2b"),

Guid.Parse("d9490733-2f54-4989-92d4-28156f07ca1a"),

Guid.Parse("ef8cfac0-cb01-41f2-9909-97e45b91816e"),

Guid.Parse("5068c575-87b3-4b3f-af02-5da55b37a467"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b5d55a5b-9be4-4761-88b5-99f4ccd6a09c"),

Guid.Parse("19aff7eb-ff12-4435-8eb4-6fa11c8893ef"),

Guid.Parse("d9f8ee67-c716-418d-8a4c-9a06b9a6497f"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("54cadb5e-8085-4d84-bc28-65ee16cd2ed5"),

Guid.Parse("16c121f8-16e9-43cf-aa64-3d60a732604f"),

Guid.Parse("b088e4b9-4d4e-424a-a90a-1bc69de2b727"),

Guid.Parse("19b0a381-0a76-4f18-96a9-b960b963dfd2"),

},
},
            new GuiduuidArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b2355de6-0acc-449a-ad0c-7eb7185c10ae"),

Guid.Parse("3db98cda-5e95-470e-a7d4-f748e94b2fe2"),

Guid.Parse("a9b2cdad-5f6a-4606-9235-42d641f9c469"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bf59c3ff-c55d-48d8-a37d-667dcb7bfac8"),

Guid.Parse("3b59aea1-20b7-4e9f-bd2c-2e99543a1bd8"),

Guid.Parse("f41c5c33-d91b-4dd9-aa1e-67c02e4158bd"),

Guid.Parse("cb3c2e06-4de5-4da7-9f75-815651349f87"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7e37a59d-27d8-4cb4-bc2e-beb0fd392d14"),

Guid.Parse("9788f95b-8faf-4180-a7a2-78c98509c2b4"),

Guid.Parse("a714e760-e8fc-4d18-8bd5-53c51ab12c07"),

Guid.Parse("ebd3fa74-606b-44d8-9b74-1762be769fa7"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("481fdce9-646c-484f-b0b9-1b02b5ce3d91"),

Guid.Parse("4e3ce2d5-fc4f-4206-91a6-3438a8070147"),

Guid.Parse("261885fe-3a5f-495c-8a8a-f6f735894e16"),

Guid.Parse("3d82397d-3055-4737-954f-0d101afbf763"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("917d6328-46c9-42c7-84c9-830b40e1bf19"),

Guid.Parse("f3af6399-832a-4238-be4f-97666e7ca09c"),

Guid.Parse("09116f51-105f-47e2-baca-bf3dc5fec0c0"),

},
},
            new GuiduuidArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("048d6eea-e2eb-4100-9aa1-37325ff8db97"),

Guid.Parse("0b59743b-ea50-4199-9c18-00a019b19f40"),

Guid.Parse("a3d091d9-8a10-4c65-a011-a307d14bfa6c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("627337f0-76cc-4330-b18b-f31ae3312b94"),

Guid.Parse("5ad81570-d1b6-4338-9ac6-5e1e98c0be44"),

Guid.Parse("72a6056b-4998-4166-8c34-6eb2d16ca70a"),

},
},
            new GuiduuidArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b4122b96-a134-4bc3-90b1-17f243ed0f39"),

Guid.Parse("79d3a788-e9b9-4be2-a2ce-8a5cee253b8a"),

Guid.Parse("fc06012d-b3f5-409b-808b-fe321bc8231a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("31314e08-f5ad-4290-93a2-bbf925962e12"),

Guid.Parse("5540071f-9743-4a87-b74e-64416ff5ef83"),

Guid.Parse("dc387777-ee50-4f26-9ecf-47ed82252fc4"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("17fb03ee-482f-4d74-ad2b-bd92812b140e"),

Guid.Parse("7cecc6dc-77ef-46f7-a585-f7253c389e6f"),

Guid.Parse("4e87ea0d-7df0-4346-a860-b3489bd1aea5"),

Guid.Parse("03a745ca-826f-4f4d-93a9-98022fa70edb"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f75f92ce-ca07-47e1-b696-13a64d33527a"),

Guid.Parse("98a80629-4c10-4a18-bf53-cb53ed9e0ca2"),

Guid.Parse("d21cbe85-bedf-404c-90d3-ccae6731dcf3"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8cb1c1a9-50e0-4415-83c7-4eb4aa00cc09"),

Guid.Parse("776feb4f-6edf-4d60-84ae-8e6f2c682857"),

Guid.Parse("664327c8-be2c-4895-a650-43bc9aea16b3"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1ad7dd3c-0cef-43fc-9208-9319b4ed634a"),

Guid.Parse("b39a3109-33fd-4707-ad1e-8e4332643b0d"),

Guid.Parse("f6ef42cc-ebb0-400a-87aa-55d8aec76d1b"),

Guid.Parse("a582cd3b-e99a-4f32-95c4-b36b3e270bed"),

},
},
            new GuiduuidArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("287d0ec2-8b51-42b1-9f45-21391782b134"),

Guid.Parse("bad2684a-8143-49ed-bb47-3c07ef861f26"),

Guid.Parse("a301c1a7-2a70-4b73-812e-0839db810367"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("730095ad-5519-4b95-ac8e-4b4465f4ecc6"),

Guid.Parse("5d79cbaa-9d17-4671-92ba-c808c09565d7"),

Guid.Parse("008b4829-fec4-49e5-b8e0-19a573418939"),

Guid.Parse("3cbf2404-91bf-4afc-ae89-609f439c1fc0"),

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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
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
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[34], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
                parametr1.Value = 99;
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[34], false);
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
                parametr1.Value = 5;
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 122;
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidArray2M.AssertModel(models[0],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidArray2M.AssertModel(models[0],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 92, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 155, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 108, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
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
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 54, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
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
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 5, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[33],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 82, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
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
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 79, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 97, 161))
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
GuiduuidArray2M.AssertModel(models[0],_testData[12], false);GuiduuidArray2M.AssertModel(models[1],_testData[13], false);GuiduuidArray2M.AssertModel(models[2],_testData[14], false);GuiduuidArray2M.AssertModel(models[3],_testData[15], false);GuiduuidArray2M.AssertModel(models[4],_testData[16], false);GuiduuidArray2M.AssertModel(models[5],_testData[17], false);GuiduuidArray2M.AssertModel(models[6],_testData[18], false);GuiduuidArray2M.AssertModel(models[7],_testData[19], false);GuiduuidArray2M.AssertModel(models[8],_testData[20], false);GuiduuidArray2M.AssertModel(models[9],_testData[21], false);GuiduuidArray2M.AssertModel(models[10],_testData[22], false);GuiduuidArray2M.AssertModel(models[11],_testData[23], false);GuiduuidArray2M.AssertModel(models[12],_testData[24], false);GuiduuidArray2M.AssertModel(models[13],_testData[25], false);GuiduuidArray2M.AssertModel(models[14],_testData[26], false);GuiduuidArray2M.AssertModel(models[15],_testData[27], false);GuiduuidArray2M.AssertModel(models[16],_testData[28], false);GuiduuidArray2M.AssertModel(models[17],_testData[29], false);GuiduuidArray2M.AssertModel(models[18],_testData[30], false);GuiduuidArray2M.AssertModel(models[19],_testData[31], false);GuiduuidArray2M.AssertModel(models[20],_testData[32], false);GuiduuidArray2M.AssertModel(models[21],_testData[33], false);GuiduuidArray2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 167);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
GuiduuidArray2M.AssertModel(models[0],_testData[33], false);GuiduuidArray2M.AssertModel(models[1],_testData[34], false);
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
                var models = ((IGuidListuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IGuidListuuidArray)this).ExportModelInner(connection).ToList();
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

