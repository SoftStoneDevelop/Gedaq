

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
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("022d623e-f1a0-4adf-9e21-e7c4bf311b4a"),

Guid.Parse("2029764e-e3b4-4877-b866-902f08b34ef0"),

Guid.Parse("5f41ed95-c1cc-4385-ae1d-64cba9abda26"),

Guid.Parse("9912f68b-931f-43a9-96fe-008fe1735543"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b9a6ab37-6780-4909-b498-72b0ba87caa3"),

Guid.Parse("e4a7a402-250e-43a8-9129-ac6118c1a31e"),

Guid.Parse("ceac0e8d-ad26-4507-bb7d-abbdbb0d8bac"),

},
},
            new GuiduuidArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("08461277-b751-4583-b400-e2fc1ddd5273"),

Guid.Parse("2132ee4c-e2e3-4e10-bf59-d7e8ae15e092"),

Guid.Parse("6b544c76-e6dd-40ad-9c82-c991bcc20fe0"),

Guid.Parse("8ff1d9f8-766b-4fb1-a378-9bfaa6ee3a2d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("15d57751-e199-4d47-a4a8-116dbee1ca94"),

Guid.Parse("bb5409b8-26a0-4cbd-89dc-6b645e3165fb"),

Guid.Parse("3cb18196-3d0b-4c1c-b50e-6d95310ac897"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8df717d9-c229-44f3-8796-7dbe1ecfc1f4"),

Guid.Parse("27a6f4bb-e695-4208-a595-fc4e41440b82"),

Guid.Parse("a33314e3-6b9b-42b3-80da-626e199575f4"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("47f81dd8-0e42-4563-8bf6-96968bda04e3"),

Guid.Parse("12cab4f9-5386-4850-b4ab-140b1ebb4569"),

Guid.Parse("54e54e3c-4d4a-469d-88e0-24010165de67"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("88728e75-da66-4be7-8d5f-31bd69fe07d0"),

Guid.Parse("01a69c51-057b-48c9-8fba-5e8d50c892fc"),

Guid.Parse("fd1ce762-12b1-498a-a2d7-22d9b30fb746"),

},
},
            new GuiduuidArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c056cf7d-7794-4fa8-ac14-7415a803be5e"),

Guid.Parse("862c36ea-e638-41f5-adba-e7d78e660dcd"),

Guid.Parse("b3bbb9bc-a80a-455a-a690-6e338289e200"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f6e00643-4cdd-4a0c-888f-589f3be11da9"),

Guid.Parse("e3b01816-df79-4c8a-a26b-6b940b215a67"),

Guid.Parse("384fad7b-cced-4f8c-ab1a-81e1a2ded8b8"),

Guid.Parse("aaa786f6-7f14-495d-91c0-69c314b51446"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ba072eb7-6202-4ba0-9c62-8f6d50744992"),

Guid.Parse("738294cf-b499-49e4-a336-9638aafc9c05"),

Guid.Parse("48b4e07c-93b4-48da-ab67-e58df371b12b"),

Guid.Parse("0a43e129-ba11-4b74-bd6e-46672c880294"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6f30a488-e2e9-449c-9995-b14272c7412b"),

Guid.Parse("695087f1-228f-4aa1-b634-e296a27af267"),

Guid.Parse("ba608b28-6a56-4314-9cc6-86402f7990fb"),

},
},
            new GuiduuidArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b73ddcbc-6346-4c4c-9520-013ae83d3410"),

Guid.Parse("97c186bc-8ef8-4c08-b8bf-597e0052ea73"),

Guid.Parse("2b5b2d06-c4fd-43d4-a790-e8b5f7d9bb54"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("52e6d0b4-65fe-49b1-ade1-9750323a031d"),

Guid.Parse("ac951eba-3002-495c-9381-e7ee3192ecf5"),

Guid.Parse("d63fc682-52f8-4b90-a589-c72767eb3ce7"),

Guid.Parse("2cde5a23-4ebb-4b6f-8447-b245b9b05572"),

},
},
            new GuiduuidArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3520cb56-14b2-4d27-877d-90cbdab5ada1"),

Guid.Parse("dbe1b13b-822a-40f3-a5d6-1b9cc2bdf2d3"),

Guid.Parse("76ff59a4-761f-4a52-a612-0bb3d3196cb0"),

Guid.Parse("3b547b41-c2a4-44bc-b37e-88f82a37c98d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("42f6bc0b-271d-4131-a14e-1b35e621cf0a"),

Guid.Parse("a0c57011-aa15-4b0d-aea6-0bf7b60af748"),

Guid.Parse("6c95fb8a-b736-4eab-a829-21b6c9eed7dc"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3892e2d2-f7d3-4335-b6ff-63213527e9fd"),

Guid.Parse("c46c9fa1-ea17-44a1-9600-4daa7516e0ea"),

Guid.Parse("1f8db7f5-7db4-4b07-af20-a117bcc66384"),

Guid.Parse("fcf37b65-9ac1-464d-8395-c098fba51e1d"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ca9f17b0-b042-41c2-a40a-959e8103d6bd"),

Guid.Parse("c7a14cfc-ce37-4b31-be82-865665f574a5"),

Guid.Parse("4d59d7fa-d037-4e3f-8246-886f351d0a11"),

},
},
            new GuiduuidArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8e69ec17-02ed-49b9-b6a8-28a9cbce480f"),

Guid.Parse("542f4d98-995a-49e7-9450-050d54735f58"),

Guid.Parse("74e15cff-3919-46ff-8381-9a1ded5ec6ad"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e4c97881-32ae-40bf-beb2-382ea5a7e8dd"),

Guid.Parse("02a8ce58-48a1-4ee1-ac25-cffb9261b52f"),

Guid.Parse("f7508c6e-7e88-488a-8bd0-61dc3ae190a7"),

},
},
            new GuiduuidArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("59dd3ce9-6ba7-4ade-be13-7df6a0144a47"),

Guid.Parse("d9d7b82d-80c9-4b0c-bc3b-eca333448f1b"),

Guid.Parse("00b00f51-959c-48e7-9db5-a745893bcf65"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4887ce70-cd25-4bcf-a8fd-48a26eb272e1"),

Guid.Parse("c03ebea8-ebf7-4946-8b9e-4bdbeb59c48b"),

Guid.Parse("c3e5c098-a56c-4339-a1cf-7fa21d99fa3b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfbc0788-b5ca-4fca-94e1-3519f4788afd"),

Guid.Parse("0d01ea95-96a4-474d-913a-ebb62286b1a7"),

Guid.Parse("bfeb053f-248d-473b-ba18-05fdbb70912a"),

Guid.Parse("992c158c-61a4-4b85-ba1e-284b5004ba66"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("52960f96-3727-4dc0-8a05-169fc91dd95c"),

Guid.Parse("084ed52a-12c3-49f5-bfd5-0dbb61061a2c"),

Guid.Parse("b105c99f-3050-4e1c-8655-7b332fd946a2"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e05468d5-8bf9-4ea9-b70c-c618cec28719"),

Guid.Parse("46b4d706-9bda-488c-88d8-e646a7dc3ed1"),

Guid.Parse("b884dc58-a65f-40bc-8895-0fedd7aafe57"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ff9c3bb0-b3cf-4aee-8b14-ef8155869f6c"),

Guid.Parse("de347d35-cdce-4815-8688-137986de4d77"),

Guid.Parse("ec10edfc-940a-4967-8200-7d5753f9a5db"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f8f0efa7-f2af-4f59-b059-7236b0ae40a0"),

Guid.Parse("4cb46a6a-75f3-4286-871e-c95da35e2cc9"),

Guid.Parse("a20bd396-336f-4c49-a4f4-2636270e6824"),

Guid.Parse("6d2af4ff-69c4-4269-bc90-74f0644d4577"),

},
},
            new GuiduuidArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("eae3c7ff-dd8c-4dbe-a196-eb8104fd4365"),

Guid.Parse("43137adf-3d52-4f35-9f8a-e5dae5da2c35"),

Guid.Parse("558fda7a-b282-4d4d-a79b-9056b6ec2d86"),

Guid.Parse("408c4a88-8a43-47d0-a101-818fe673a8d3"),

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
Guid.Parse("f5ce70fb-3952-40bb-9e74-ff1504a654c5"),

Guid.Parse("eb8f655c-99b0-4ce5-ad48-aad7ac59547b"),

Guid.Parse("1c0e248e-f288-4dc4-a4ad-b17f24ab1171"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e09394f1-7ed9-45e4-a8b2-47957a2eb177"),

Guid.Parse("fbdf1111-f95b-42a8-8965-aedfe66a721a"),

Guid.Parse("187a49ef-f722-4ee2-9310-8d15a08f2ccc"),

Guid.Parse("d11790f3-56e1-452b-8b73-cac9526a3be5"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2b26c127-40dd-4f0a-a8cb-4d75cd0a1c79"),

Guid.Parse("40206331-1cb7-4bbb-9d4e-172b3cde729c"),

Guid.Parse("e1a2c026-6eca-427e-a6fe-a339da8db602"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("abc60e45-0c2b-48c9-ba3a-83d18f3f1d00"),

Guid.Parse("3a3b2588-641d-43f2-97c1-e6fe3d339d0e"),

Guid.Parse("d4e8a214-0752-4f17-940a-6d338b6faaed"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9f8895c4-7966-4944-98fc-aa384a870b78"),

Guid.Parse("47d3b14f-4963-4f29-bb51-16198a70bb8a"),

Guid.Parse("2c141bcd-b5f1-441e-b50b-303d12c5cd6a"),

},
},
            new GuiduuidArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ae6cbecd-1534-4e9e-a85b-1618960b6fd7"),

Guid.Parse("6b29d2cc-4dbe-4b23-ab39-f5bfc12c61d8"),

Guid.Parse("0562fd71-3e4f-4b29-a9b7-1c6423148ffb"),

Guid.Parse("1781b3bb-3ef9-4b17-a8f7-c677c52ac76f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("62ad4364-ac37-4660-afb5-b1ae92e8bf03"),

Guid.Parse("01ccc9de-c46a-45cf-acba-c598bca477f5"),

Guid.Parse("f5996c07-1adc-47ef-b087-eb94d8fab267"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("592eead3-3160-48cf-9add-830d8006d81b"),

Guid.Parse("9405f015-bc0c-49ce-88b5-3a12634bf32b"),

Guid.Parse("9d89e7ce-dd39-4ef8-89ee-782be9458402"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("78ccdbd7-e5fe-4074-824e-4c6e30d247df"),

Guid.Parse("1923c7e1-5e85-44a0-ab78-90bb41cebea3"),

Guid.Parse("8f1e0125-e6d7-4cc9-aa8d-86776d205d07"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b6d103c4-28f4-48d2-896d-220dd7134bd1"),

Guid.Parse("fa4a11c0-3b71-49da-8337-3cfc44e03adb"),

Guid.Parse("3e17e464-d167-485f-a10a-04f2345fdea9"),

Guid.Parse("aed77439-fc99-4f18-a937-16d2caf454d7"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f181ece8-cc9e-4633-bc6a-5f41ef87fe3d"),

Guid.Parse("658e6369-ee34-4735-8fa9-24dbed1d638f"),

Guid.Parse("be26ce6f-4e72-4e4c-bc2a-192e949b3751"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bf633afc-42a2-47d5-bb2b-85d3c71b4920"),

Guid.Parse("5be601f6-4ae4-4257-98f5-e9a4bcfd3ca6"),

Guid.Parse("6eac26cd-2908-46e9-8217-665e740b8af2"),

},
},
            new GuiduuidArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8f08b14c-6079-4fad-be81-906ea48dcf3b"),

Guid.Parse("f8a641ae-8e44-4e18-82ee-f5f170313040"),

Guid.Parse("ccc0ff6b-602c-4eaf-a482-b1c092e07bbc"),

Guid.Parse("2d2ca3cc-cab0-4a65-a3c5-698e8dbb2d99"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("43d2c2b8-14da-48c2-802d-3feb42e04ba6"),

Guid.Parse("bea4d8e4-077f-4d05-bacf-b3c19bf6886c"),

Guid.Parse("b38c0529-9c76-4219-b4db-75b2f58a6366"),

},
},
            new GuiduuidArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1fb573e0-0444-4f9a-80a2-1f6fa6026be5"),

Guid.Parse("09adf5c8-31a2-4589-9539-8e5b490b3aa7"),

Guid.Parse("0b162643-6e94-43af-9ac9-756541ad1c98"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ac97a779-2e08-49c6-8764-5651813cc677"),

Guid.Parse("c7c1b658-e585-48ec-8ed5-9e209196ee4c"),

Guid.Parse("cae369ad-1562-4c7d-a72a-50aadbb6b615"),

Guid.Parse("46fb601f-17c6-4953-ac4a-950358698f78"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d22f7b8f-05fb-487a-804c-c5abf343c1d0"),

Guid.Parse("7d0376cd-9739-497f-88c0-c57a60b72d02"),

Guid.Parse("b94017ef-27af-4100-bc62-403489cf9bf8"),

Guid.Parse("c038ca2a-7d55-4adb-b38e-5f241a48ad05"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("af0f146c-d405-4b72-ba96-91997fc1df2f"),

Guid.Parse("6190ab5d-08b9-4fd0-8cdd-3ba58a214a6a"),

Guid.Parse("430cb271-2eb3-461d-b54e-80c155f1a3dc"),

Guid.Parse("4278f194-80f2-4583-898e-8e18057c6413"),

},
},
            new GuiduuidArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e7a2ad00-46fc-4e16-8603-0501746d5241"),

Guid.Parse("49914641-e11b-4f99-8ce5-39dd71a9be99"),

Guid.Parse("4b2ffbce-a5e0-4719-93c4-f8a92ded079f"),

Guid.Parse("80d1d903-b8c7-4ea4-863e-17c41df69578"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ba681d87-4da9-421e-8d49-cc5a79020ed8"),

Guid.Parse("5c98db5a-1575-485a-99f6-fba647443805"),

Guid.Parse("d423a285-cf0e-4257-83ce-c7df8deff0bc"),

Guid.Parse("dc945def-69c8-4002-83fd-dff2fd1f184b"),

},
},
            new GuiduuidArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("aa2f0d8d-1296-4f16-a451-171f7a00387d"),

Guid.Parse("16ac5c6d-4bc3-4540-96cd-f501541e6f80"),

Guid.Parse("92776cdd-52c4-4efc-9b03-fb4babc4bccc"),

Guid.Parse("3a450513-5ffd-464f-b588-e81ceed7d2d9"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("88785cda-819c-4d09-a81f-c8762205f08a"),

Guid.Parse("d6111bf8-8f22-4753-b19a-e8f23102a362"),

Guid.Parse("d9b88251-d832-4fe6-970a-7f236c4803e7"),

Guid.Parse("7190c950-cff3-4332-936e-10feca9feca6"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e42a1634-50c7-4a0b-828c-ac7e103a6a32"),

Guid.Parse("7fd3425b-6315-48d2-91f2-278731c34d23"),

Guid.Parse("de6fb74c-4891-4f66-87a1-47d6e64aed79"),

Guid.Parse("6d09da1b-af4b-44b2-8711-3bbfd25e292c"),

},
},
            new GuiduuidArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fdc502e1-d540-4084-9ee6-39dd97c6fa54"),

Guid.Parse("c18ee35d-0233-4c81-8700-d661c1fbe646"),

Guid.Parse("2627c201-7e9d-4de5-b0ab-7d618084c784"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c172805f-bd24-49d6-8251-1d8bec21490d"),

Guid.Parse("7c731301-38d0-4f4d-86f3-66e7ec0c86d4"),

Guid.Parse("b9972813-1bc8-4035-8884-8a2a5535852b"),

Guid.Parse("5e7bc758-0a8f-42fc-9e34-73f62cd2f4d8"),

},
},
            new GuiduuidArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9f3b717d-3b25-4bba-8179-94ae73067b84"),

Guid.Parse("c38b8164-fe8b-49a6-bd2c-91e2da8e52a4"),

Guid.Parse("cd1576aa-4235-41f8-ba0a-3d1b8b3d3d86"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fe350f74-9356-432e-88c8-368f340373cf"),

Guid.Parse("d1fa2211-b56f-4e3f-95d0-e0c2eb645c55"),

Guid.Parse("aae79cfd-c4ba-4d49-a683-6bf16ec07fa1"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3be39919-6605-4b04-87b2-2dca05f525bd"),

Guid.Parse("e0789496-7643-4185-aefc-7a2078ecae1c"),

Guid.Parse("083a8e1b-c64b-4a41-914a-e393d22b2103"),

Guid.Parse("a90c0755-a947-4981-a650-5cea8bcb489a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9280f310-14b9-4f89-b000-f3effa092d23"),

Guid.Parse("75ca3961-0ba6-4538-94f2-7ed2e0510d2f"),

Guid.Parse("06f57c19-ec07-46c7-bf69-4a9aab78a536"),

Guid.Parse("c42fc5d4-a30f-40e9-972d-efc9ac6b3b6b"),

},
},
            new GuiduuidArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("905fbbf3-f813-4187-bc8f-6f240495465f"),

Guid.Parse("0ecc0f71-1d65-40ce-94b4-c4e5bc6ceebd"),

Guid.Parse("3e62f1f4-82c7-435b-80a1-3dd08da67d86"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb30819d-ac1f-40e4-8c20-a38e83491008"),

Guid.Parse("33b8f830-e7d5-454e-bbc0-34a82cb2c048"),

Guid.Parse("316d2426-5b55-469a-8027-f85e593f1e76"),

Guid.Parse("9f0eb3d1-6044-4ef7-badf-5e325a04c3b2"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cfcf36c9-40e6-4b86-ae48-f754b216794a"),

Guid.Parse("79792e17-2a28-445f-b3e3-5e04f1c0dbf5"),

Guid.Parse("2ec3b03c-ec49-469d-b321-0d5d7ee485ac"),

Guid.Parse("bdb93625-7dd8-45f6-a70a-ccb842c0f8c8"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("728dd271-c587-4fc6-ac08-f6898cc6df09"),

Guid.Parse("12e61acc-0f56-4863-a4f3-b6624437cc26"),

Guid.Parse("6929e33b-15ae-408d-b0b6-3beb799fba38"),

},
},
            new GuiduuidArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("047be1a4-2ec0-4d28-b9fe-ee2c81fbedd6"),

Guid.Parse("42a69782-3dbb-4502-bbff-6c5bc6930e0a"),

Guid.Parse("5853438b-d3f5-44ca-8875-e248a6d7838e"),

Guid.Parse("9a76a6e1-911c-4400-9f49-b6cec39202cd"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("538d4d45-d26f-48e6-99fe-fc58b8364060"),

Guid.Parse("b662e847-281d-441a-afc9-84ae966ec026"),

Guid.Parse("28b55676-4214-4339-a7c8-b2634dad9743"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ae6c3f99-649e-48fb-9755-d1e02148bf6e"),

Guid.Parse("9433ff65-21e3-4f9b-8a4c-33ac4f99b484"),

Guid.Parse("a65f8679-6c20-4f84-a11a-02671cc4c566"),

Guid.Parse("97860688-fa16-4e05-be91-3f54953af3e2"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8219fcb3-2826-4647-9659-1a24d12058ee"),

Guid.Parse("dce7b661-d9c7-42b6-888a-6f12007d30b4"),

Guid.Parse("2a22e179-9f4c-4928-9a8b-fbb82c054d0e"),

Guid.Parse("2c8a162d-1d6c-4d0c-af4b-12c09962c325"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2755c2cf-d753-421f-b0e9-e49de155265e"),

Guid.Parse("5aedbc40-d227-4fb2-b975-8c2219e34cf9"),

Guid.Parse("e6f34bd7-0301-422e-918f-851fae7a4821"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71b0ff02-7266-4831-aee0-3dd7927051ab"),

Guid.Parse("47e47488-e714-42f7-a41f-1a50ea4fe304"),

Guid.Parse("40583bf6-76c4-4a2d-bdc7-116fc9c6762e"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2c2ff4ba-e865-4fa6-b7d2-d225de6da4b7"),

Guid.Parse("1094f42f-8dd8-4dc1-874d-38fc872ecb9c"),

Guid.Parse("e00e0690-8231-4562-b2ab-b4183d2da998"),

Guid.Parse("6b68274d-8bea-46a6-be73-3e80bbc5828e"),

},
},
            new GuiduuidArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("aa71d53d-d0cb-4b8a-a706-2d23817b4e1a"),

Guid.Parse("107b8f33-2032-4b57-bdbc-fc22dd3774a9"),

Guid.Parse("39415dc8-4f0f-4eda-9e05-e8451014f557"),

Guid.Parse("6ddad7c6-0982-4309-9edb-154419831dfd"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c74dba27-558b-4741-af4a-fc3fcb3bd533"),

Guid.Parse("a402caac-1b61-434d-87f8-449e62b5a559"),

Guid.Parse("a8276555-4a23-44c4-9649-d42e53e83f0a"),

Guid.Parse("b2b21b68-9d70-4c91-be8c-bcd5dd1a717a"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e848459e-71e8-4a5d-b1c0-eb1114c2f00c"),

Guid.Parse("c4c8ed9e-0cb2-49a3-8f95-b4265b8598b5"),

Guid.Parse("07a6a64c-e8d8-4656-b5e2-b3049819bb57"),

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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IGuidListuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IGuidListuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IGuidListuuidArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IGuidListuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[29], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IGuidListuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
GuiduuidArray2M.AssertModel(models[0],_testData[8], false);GuiduuidArray2M.AssertModel(models[1],_testData[9], false);GuiduuidArray2M.AssertModel(models[2],_testData[10], false);GuiduuidArray2M.AssertModel(models[3],_testData[11], false);GuiduuidArray2M.AssertModel(models[4],_testData[12], false);GuiduuidArray2M.AssertModel(models[5],_testData[13], false);GuiduuidArray2M.AssertModel(models[6],_testData[14], false);GuiduuidArray2M.AssertModel(models[7],_testData[15], false);GuiduuidArray2M.AssertModel(models[8],_testData[16], false);GuiduuidArray2M.AssertModel(models[9],_testData[17], false);GuiduuidArray2M.AssertModel(models[10],_testData[18], false);GuiduuidArray2M.AssertModel(models[11],_testData[19], false);GuiduuidArray2M.AssertModel(models[12],_testData[20], false);GuiduuidArray2M.AssertModel(models[13],_testData[21], false);GuiduuidArray2M.AssertModel(models[14],_testData[22], false);GuiduuidArray2M.AssertModel(models[15],_testData[23], false);GuiduuidArray2M.AssertModel(models[16],_testData[24], false);GuiduuidArray2M.AssertModel(models[17],_testData[25], false);GuiduuidArray2M.AssertModel(models[18],_testData[26], false);GuiduuidArray2M.AssertModel(models[19],_testData[27], false);GuiduuidArray2M.AssertModel(models[20],_testData[28], false);GuiduuidArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
GuiduuidArray2M.AssertModel(models[0],_testData[23], false);GuiduuidArray2M.AssertModel(models[1],_testData[24], false);GuiduuidArray2M.AssertModel(models[2],_testData[25], false);GuiduuidArray2M.AssertModel(models[3],_testData[26], false);GuiduuidArray2M.AssertModel(models[4],_testData[27], false);GuiduuidArray2M.AssertModel(models[5],_testData[28], false);GuiduuidArray2M.AssertModel(models[6],_testData[29], false);
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

                var models =  ((IGuidListuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
GuiduuidArray2M.AssertModel(models[0],_testData[9], false);GuiduuidArray2M.AssertModel(models[1],_testData[10], false);GuiduuidArray2M.AssertModel(models[2],_testData[11], false);GuiduuidArray2M.AssertModel(models[3],_testData[12], false);GuiduuidArray2M.AssertModel(models[4],_testData[13], false);GuiduuidArray2M.AssertModel(models[5],_testData[14], false);GuiduuidArray2M.AssertModel(models[6],_testData[15], false);GuiduuidArray2M.AssertModel(models[7],_testData[16], false);GuiduuidArray2M.AssertModel(models[8],_testData[17], false);GuiduuidArray2M.AssertModel(models[9],_testData[18], false);GuiduuidArray2M.AssertModel(models[10],_testData[19], false);GuiduuidArray2M.AssertModel(models[11],_testData[20], false);GuiduuidArray2M.AssertModel(models[12],_testData[21], false);GuiduuidArray2M.AssertModel(models[13],_testData[22], false);GuiduuidArray2M.AssertModel(models[14],_testData[23], false);GuiduuidArray2M.AssertModel(models[15],_testData[24], false);GuiduuidArray2M.AssertModel(models[16],_testData[25], false);GuiduuidArray2M.AssertModel(models[17],_testData[26], false);GuiduuidArray2M.AssertModel(models[18],_testData[27], false);GuiduuidArray2M.AssertModel(models[19],_testData[28], false);GuiduuidArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
GuiduuidArray2M.AssertModel(models[0],_testData[4], false);GuiduuidArray2M.AssertModel(models[1],_testData[5], false);GuiduuidArray2M.AssertModel(models[2],_testData[6], false);GuiduuidArray2M.AssertModel(models[3],_testData[7], false);GuiduuidArray2M.AssertModel(models[4],_testData[8], false);GuiduuidArray2M.AssertModel(models[5],_testData[9], false);GuiduuidArray2M.AssertModel(models[6],_testData[10], false);GuiduuidArray2M.AssertModel(models[7],_testData[11], false);GuiduuidArray2M.AssertModel(models[8],_testData[12], false);GuiduuidArray2M.AssertModel(models[9],_testData[13], false);GuiduuidArray2M.AssertModel(models[10],_testData[14], false);GuiduuidArray2M.AssertModel(models[11],_testData[15], false);GuiduuidArray2M.AssertModel(models[12],_testData[16], false);GuiduuidArray2M.AssertModel(models[13],_testData[17], false);GuiduuidArray2M.AssertModel(models[14],_testData[18], false);GuiduuidArray2M.AssertModel(models[15],_testData[19], false);GuiduuidArray2M.AssertModel(models[16],_testData[20], false);GuiduuidArray2M.AssertModel(models[17],_testData[21], false);GuiduuidArray2M.AssertModel(models[18],_testData[22], false);GuiduuidArray2M.AssertModel(models[19],_testData[23], false);GuiduuidArray2M.AssertModel(models[20],_testData[24], false);GuiduuidArray2M.AssertModel(models[21],_testData[25], false);GuiduuidArray2M.AssertModel(models[22],_testData[26], false);GuiduuidArray2M.AssertModel(models[23],_testData[27], false);GuiduuidArray2M.AssertModel(models[24],_testData[28], false);GuiduuidArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 22, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[5], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[6], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[7], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[8], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[21],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[22],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[23],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[4], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[5], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[6], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[7], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[8], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[21],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[22],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[23],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[24],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[25],_testData[29], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 67, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 114, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
GuiduuidArray2M.AssertModel(models[0],_testData[25], false);GuiduuidArray2M.AssertModel(models[1],_testData[26], false);GuiduuidArray2M.AssertModel(models[2],_testData[27], false);GuiduuidArray2M.AssertModel(models[3],_testData[28], false);GuiduuidArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
GuiduuidArray2M.AssertModel(models[0],_testData[11], false);GuiduuidArray2M.AssertModel(models[1],_testData[12], false);GuiduuidArray2M.AssertModel(models[2],_testData[13], false);GuiduuidArray2M.AssertModel(models[3],_testData[14], false);GuiduuidArray2M.AssertModel(models[4],_testData[15], false);GuiduuidArray2M.AssertModel(models[5],_testData[16], false);GuiduuidArray2M.AssertModel(models[6],_testData[17], false);GuiduuidArray2M.AssertModel(models[7],_testData[18], false);GuiduuidArray2M.AssertModel(models[8],_testData[19], false);GuiduuidArray2M.AssertModel(models[9],_testData[20], false);GuiduuidArray2M.AssertModel(models[10],_testData[21], false);GuiduuidArray2M.AssertModel(models[11],_testData[22], false);GuiduuidArray2M.AssertModel(models[12],_testData[23], false);GuiduuidArray2M.AssertModel(models[13],_testData[24], false);GuiduuidArray2M.AssertModel(models[14],_testData[25], false);GuiduuidArray2M.AssertModel(models[15],_testData[26], false);GuiduuidArray2M.AssertModel(models[16],_testData[27], false);GuiduuidArray2M.AssertModel(models[17],_testData[28], false);GuiduuidArray2M.AssertModel(models[18],_testData[29], false);
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
                var models =  ((IGuidListuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSelectModelBatch(connection, 90, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
GuiduuidArray2M.AssertModel(models[0],_testData[21], false);GuiduuidArray2M.AssertModel(models[1],_testData[22], false);GuiduuidArray2M.AssertModel(models[2],_testData[23], false);GuiduuidArray2M.AssertModel(models[3],_testData[24], false);GuiduuidArray2M.AssertModel(models[4],_testData[25], false);GuiduuidArray2M.AssertModel(models[5],_testData[26], false);GuiduuidArray2M.AssertModel(models[6],_testData[27], false);GuiduuidArray2M.AssertModel(models[7],_testData[28], false);GuiduuidArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
GuiduuidArray2M.AssertModel(models[0],_testData[12], false);GuiduuidArray2M.AssertModel(models[1],_testData[13], false);GuiduuidArray2M.AssertModel(models[2],_testData[14], false);GuiduuidArray2M.AssertModel(models[3],_testData[15], false);GuiduuidArray2M.AssertModel(models[4],_testData[16], false);GuiduuidArray2M.AssertModel(models[5],_testData[17], false);GuiduuidArray2M.AssertModel(models[6],_testData[18], false);GuiduuidArray2M.AssertModel(models[7],_testData[19], false);GuiduuidArray2M.AssertModel(models[8],_testData[20], false);GuiduuidArray2M.AssertModel(models[9],_testData[21], false);GuiduuidArray2M.AssertModel(models[10],_testData[22], false);GuiduuidArray2M.AssertModel(models[11],_testData[23], false);GuiduuidArray2M.AssertModel(models[12],_testData[24], false);GuiduuidArray2M.AssertModel(models[13],_testData[25], false);GuiduuidArray2M.AssertModel(models[14],_testData[26], false);GuiduuidArray2M.AssertModel(models[15],_testData[27], false);GuiduuidArray2M.AssertModel(models[16],_testData[28], false);GuiduuidArray2M.AssertModel(models[17],_testData[29], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
GuiduuidArray2M.AssertModel(models[0],_testData[3], false);GuiduuidArray2M.AssertModel(models[1],_testData[4], false);GuiduuidArray2M.AssertModel(models[2],_testData[5], false);GuiduuidArray2M.AssertModel(models[3],_testData[6], false);GuiduuidArray2M.AssertModel(models[4],_testData[7], false);GuiduuidArray2M.AssertModel(models[5],_testData[8], false);GuiduuidArray2M.AssertModel(models[6],_testData[9], false);GuiduuidArray2M.AssertModel(models[7],_testData[10], false);GuiduuidArray2M.AssertModel(models[8],_testData[11], false);GuiduuidArray2M.AssertModel(models[9],_testData[12], false);GuiduuidArray2M.AssertModel(models[10],_testData[13], false);GuiduuidArray2M.AssertModel(models[11],_testData[14], false);GuiduuidArray2M.AssertModel(models[12],_testData[15], false);GuiduuidArray2M.AssertModel(models[13],_testData[16], false);GuiduuidArray2M.AssertModel(models[14],_testData[17], false);GuiduuidArray2M.AssertModel(models[15],_testData[18], false);GuiduuidArray2M.AssertModel(models[16],_testData[19], false);GuiduuidArray2M.AssertModel(models[17],_testData[20], false);GuiduuidArray2M.AssertModel(models[18],_testData[21], false);GuiduuidArray2M.AssertModel(models[19],_testData[22], false);GuiduuidArray2M.AssertModel(models[20],_testData[23], false);GuiduuidArray2M.AssertModel(models[21],_testData[24], false);GuiduuidArray2M.AssertModel(models[22],_testData[25], false);GuiduuidArray2M.AssertModel(models[23],_testData[26], false);GuiduuidArray2M.AssertModel(models[24],_testData[27], false);GuiduuidArray2M.AssertModel(models[25],_testData[28], false);GuiduuidArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
GuiduuidArray2M.AssertModel(models[0],_testData[8], false);GuiduuidArray2M.AssertModel(models[1],_testData[9], false);GuiduuidArray2M.AssertModel(models[2],_testData[10], false);GuiduuidArray2M.AssertModel(models[3],_testData[11], false);GuiduuidArray2M.AssertModel(models[4],_testData[12], false);GuiduuidArray2M.AssertModel(models[5],_testData[13], false);GuiduuidArray2M.AssertModel(models[6],_testData[14], false);GuiduuidArray2M.AssertModel(models[7],_testData[15], false);GuiduuidArray2M.AssertModel(models[8],_testData[16], false);GuiduuidArray2M.AssertModel(models[9],_testData[17], false);GuiduuidArray2M.AssertModel(models[10],_testData[18], false);GuiduuidArray2M.AssertModel(models[11],_testData[19], false);GuiduuidArray2M.AssertModel(models[12],_testData[20], false);GuiduuidArray2M.AssertModel(models[13],_testData[21], false);GuiduuidArray2M.AssertModel(models[14],_testData[22], false);GuiduuidArray2M.AssertModel(models[15],_testData[23], false);GuiduuidArray2M.AssertModel(models[16],_testData[24], false);GuiduuidArray2M.AssertModel(models[17],_testData[25], false);GuiduuidArray2M.AssertModel(models[18],_testData[26], false);GuiduuidArray2M.AssertModel(models[19],_testData[27], false);GuiduuidArray2M.AssertModel(models[20],_testData[28], false);GuiduuidArray2M.AssertModel(models[21],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

