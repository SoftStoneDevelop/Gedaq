

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("af50ff4b-8f70-4a6e-9ed7-6192780cb2c3"),

Guid.Parse("c4385655-5864-4d89-930e-4a1dd9bd0939"),

Guid.Parse("bb9c5cdb-a6f8-4f67-ad21-1a1e71b8bcda"),

Guid.Parse("2c488131-04e3-450b-8108-3d3736d8ec25"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8b317614-a9c3-4e8b-970d-1c7621cfac5c"),

Guid.Parse("c4ee6f30-6851-4895-b90f-ea53c366ded7"),

Guid.Parse("e5602505-2133-483d-a70a-6fcb49e18e14"),

Guid.Parse("f38f2bb8-d748-4e7d-87cf-7eab6fcfbf86"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("04b2d62d-bdaf-4693-8d5a-500771a41f91"),

Guid.Parse("a3530523-65c0-46a6-a7a8-fce22cc2ac4b"),

Guid.Parse("6f827f6d-6bff-4396-82e5-c59ec17c2516"),

Guid.Parse("61ee3db6-5b8f-4c46-8232-836e7782f27e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("86c0cdc1-21ad-410c-87c5-7dec86f91736"),

Guid.Parse("76716edb-1841-472a-8dcf-ade45a723ce0"),

Guid.Parse("29e70d2b-d9c3-4617-9119-8a8a8a523611"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5bfab30a-482b-4599-9cf2-8a58cbe2db66"),

Guid.Parse("14b24fd7-8ff8-4681-b345-6da803e63192"),

Guid.Parse("1e180103-1080-48f2-bc27-3eda877ad844"),

},
},
            new GuiduuidArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d7199e40-0517-4cc5-9fb9-c2834c6a0e30"),

Guid.Parse("6da538f7-bb9b-4ea6-b0a8-0c438e9a6a39"),

Guid.Parse("019a96a8-f7ce-4185-beda-7049268ef057"),

Guid.Parse("f7a84e50-a5a8-4927-8153-fce64739fd55"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0c465ef6-89f7-4cf6-9d85-9606c038b718"),

Guid.Parse("8cd6c854-82f8-4e8a-ad7c-d341d43b8065"),

Guid.Parse("70497dd6-1a74-48b0-93bf-3b378b4f51e5"),

Guid.Parse("3acd22e0-6c25-4703-aaf2-9085965a578f"),

},
},
            new GuiduuidArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("686f3455-e338-4130-a588-444b529f9145"),

Guid.Parse("cadae69a-b3d5-4a69-9e61-54a3fb926d9b"),

Guid.Parse("4fe842b6-6422-4f3a-8b80-578700067708"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8ac91dc1-22fe-4cd1-9fb2-0a871da10771"),

Guid.Parse("ea52f9a8-e2de-4671-9933-07be10484b02"),

Guid.Parse("90098331-2446-4653-b4b5-de280920c83a"),

Guid.Parse("ea3f5589-21c1-415d-a462-e722d070b13d"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("02d3c7b3-0553-43c1-ba4f-66110f1c6c9d"),

Guid.Parse("b98a26a1-8257-42b8-a31b-4d50f31d9219"),

Guid.Parse("e63ac315-8967-4036-9e6b-9dda843cd446"),

Guid.Parse("b66b43b1-5bb4-46b2-ad24-839fd449c283"),

},
},
            new GuiduuidArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("65db9d1c-c7e3-4517-8724-7093853b7368"),

Guid.Parse("98e9f383-9a07-4a55-a83c-c1ac7dcfa382"),

Guid.Parse("cc0d587e-d64d-416c-8264-cf9257a8200a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("81b7f67f-677d-46f8-a337-c785ae7362cf"),

Guid.Parse("0f5ba56a-2fb6-4f71-9858-88bda3e29523"),

Guid.Parse("1bb8a761-7648-4b3b-a376-94583fc04d61"),

Guid.Parse("a89249ee-e8b8-4d37-b399-3e87957bb54d"),

},
},
            new GuiduuidArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("04ad964f-e7ac-4575-ab9b-3be0ea83128b"),

Guid.Parse("2d1bf93a-5ee6-48a4-8e0f-8e4738c31cb6"),

Guid.Parse("882a1e43-701d-40de-baf7-942d5cf3b64f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b735dd09-779a-406f-85a9-fa65109e79fd"),

Guid.Parse("9f895497-ed74-4261-9838-896c04f4f08f"),

Guid.Parse("ab025981-e50d-4d68-a956-276cf2c547df"),

Guid.Parse("5041b607-5556-47a6-b6ea-c92fce29a662"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ceba72f9-5f22-4690-83df-4598b6e9e361"),

Guid.Parse("16e30657-575e-4233-90d3-2b540019c05d"),

Guid.Parse("f91c84ee-6246-4803-9337-8697d318e799"),

Guid.Parse("16e02ff9-733d-4375-9a8c-143e564676da"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f5137fd5-065a-4629-a4bf-2b365175832b"),

Guid.Parse("15ae8ecd-3afe-466c-8cb4-c47af7830d69"),

Guid.Parse("fdfa1271-b390-45a3-8010-6d0fbba2db80"),

},
},
            new GuiduuidArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bd21f31a-9568-4682-a126-9ba375640c89"),

Guid.Parse("008a1add-fa5a-456b-a85b-4f94da81b598"),

Guid.Parse("c29961b6-2e4e-470e-8870-0a8ef8ed5cf3"),

Guid.Parse("bec19545-af22-4e7e-affa-b312ce7b27bc"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("79a8508c-bd96-4f33-bd63-d51b0ff54ecb"),

Guid.Parse("af962bfb-6560-4157-9981-25ab6b236b0b"),

Guid.Parse("4d20b2da-9e81-4daa-ac39-7d0736aa6c10"),

Guid.Parse("28276cd3-b088-4388-9abd-d75c9ccf9672"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b854743f-787b-4a81-a20e-e8fbdda1b4b8"),

Guid.Parse("588774e3-9324-4578-be86-29d2eb147832"),

Guid.Parse("c339a04a-6e2a-4926-843c-36552f840258"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b34603dd-c9fd-4da4-9902-75106bb5ad49"),

Guid.Parse("231fbb5c-cfc4-4dda-991e-6abf213fbb38"),

Guid.Parse("49dec55e-28c6-43ff-8955-12fefd28b380"),

Guid.Parse("80a4c462-a8a9-44e8-acad-6cccee348244"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eabf94c6-3b90-48a2-9184-f16f8bcf1fe2"),

Guid.Parse("d016ebe0-792c-4fd3-a1af-28a6e83a6da0"),

Guid.Parse("1ff19847-9305-4a21-bbf4-b6bb33edb869"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("309e3fcb-64b1-40f6-9a3a-917c0b6f154f"),

Guid.Parse("f435ae07-04a1-471e-817e-6acfa82209a4"),

Guid.Parse("6f295e2f-c45e-423a-9b17-d8b4c59ec4d8"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("467bd706-07b8-4cca-b894-70bc04e98d34"),

Guid.Parse("070eba02-60f1-4a93-9b8f-0bae7d52b4d6"),

Guid.Parse("f5997dc2-9e62-4639-8747-f95cdef06cae"),

Guid.Parse("fe3d74bc-2026-4f70-a0db-91c152ecb8c0"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("12b4338b-d732-4c3b-9123-8cb54b0a4857"),

Guid.Parse("a9ca973d-4a45-4890-8c5a-36f5471e934e"),

Guid.Parse("5761a481-e5eb-49bf-b886-37609892b169"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("965033a7-1db6-4398-9794-d626ba249c22"),

Guid.Parse("f3b9784a-ec9e-4c5c-90f0-f6d675093410"),

Guid.Parse("89882c3e-93a8-4744-8cd9-2ccd5d8fbdc3"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d2d8271d-4e12-4f0f-b216-2ede7edd9488"),

Guid.Parse("d0e6fac7-68d2-4729-9388-ec6a83794573"),

Guid.Parse("a0984f93-4da2-4ae8-9966-4253a1440e47"),

Guid.Parse("18a4f1d9-6e57-448f-b13d-f400788b0f76"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("974b99ad-7404-422b-bdf0-6485b4a67560"),

Guid.Parse("f3259631-d090-413d-a3b1-93148a402e26"),

Guid.Parse("cb3f8e6d-d398-49d8-b8c0-7c580ecf772d"),

Guid.Parse("0c923081-0106-4961-9360-7e46d91d1bdb"),

},
},
            new GuiduuidArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("49b3ad5a-62e4-4960-b879-70791d2d6505"),

Guid.Parse("07138258-4836-42b5-92e6-0778fb094993"),

Guid.Parse("1bec190a-422e-476c-bc84-5e576eae09be"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3d198a9-195a-4d4a-a41f-1db43f286762"),

Guid.Parse("56718d8e-5d25-4942-80d4-6263e603deb3"),

Guid.Parse("0f6fef97-d399-4ed6-af45-07b0c994a431"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("15e63a4c-9d86-46af-a2ee-69f1695c7e7f"),

Guid.Parse("5d41329b-f126-4a5b-b478-a381ef711b46"),

Guid.Parse("5acb95a7-fc9f-46b3-aa5c-fff5e0ae1e0c"),

},
},
            new GuiduuidArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ee36f78e-2b58-4e2f-a505-a0f124cf0eae"),

Guid.Parse("784a3924-6821-4915-a162-14f6e5c9a678"),

Guid.Parse("ba9f670d-f288-478f-b3c6-1c1652ccb3c9"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9c04b90f-496d-44d0-a8b9-1076d0ec8af5"),

Guid.Parse("768d909d-417f-4d7d-9cdf-88be5df198b5"),

Guid.Parse("2e8fc35c-9f61-4dc5-8239-3d06236fff66"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3da3d217-040c-49b9-bf89-6d27e9035ba7"),

Guid.Parse("8d2cf100-8a1c-4242-b96e-ad99f674b998"),

Guid.Parse("f860edbd-8f5f-4afb-bc67-0075ff4b5662"),

Guid.Parse("37d92ecf-df13-4654-90cd-70e2fd241a6b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1ae669f5-4f6f-455a-8727-ec3ada8996c5"),

Guid.Parse("7a77d657-2ccd-4eec-ab81-b10fb62eede5"),

Guid.Parse("749fd599-05c5-4dd5-8cac-f8e9dfd244e6"),

Guid.Parse("49b2f5d0-8858-492e-a0eb-eff334c3c25f"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("773c036a-dca5-4d07-955c-75add69cdcb6"),

Guid.Parse("fed10e8b-1b6d-4b5d-be4c-ae0d7babe4dd"),

Guid.Parse("6a48b1fa-2240-43f2-8124-876446f0e08d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("45412002-e3bd-4d95-8919-17a7547d99fc"),

Guid.Parse("a91c1260-f0ee-4ed8-ac1d-aaae4fba21a3"),

Guid.Parse("f97859b0-0c3f-4b44-a5d3-5d955373f914"),

Guid.Parse("1541623f-8230-4f4a-86b2-922e8be22c03"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("667b93dd-fd08-4b4e-b357-ec032de53b91"),

Guid.Parse("53df57bc-fcfb-4f54-9d14-31e2eb72189d"),

Guid.Parse("18438c27-9659-4416-9c09-3cb58defa64f"),

Guid.Parse("34d343ed-1968-48c1-9669-43290281d1a7"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1e6d1702-8b33-4290-898a-e57c1ec54c95"),

Guid.Parse("36486f70-9012-453e-8791-fa81af8f09c6"),

Guid.Parse("c9035e1a-e415-4924-ad72-cef77ec25c51"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26d09ef9-b5eb-4e90-89b8-23cce47189ab"),

Guid.Parse("13aabf26-2dd1-4126-8691-bebdedceb43b"),

Guid.Parse("d1938076-4b8b-4ff4-98ff-1b519e1b807f"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("57c88f16-0662-4441-a848-e19989b57a96"),

Guid.Parse("796b7667-c0ba-40ab-9fce-fa3670b90442"),

Guid.Parse("9dac6a19-7a8e-4732-8a58-62afab9e3331"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1e4eb058-b0af-45f1-8432-71345ebc4916"),

Guid.Parse("9fc07b1f-a767-46e5-953b-0dcf47d188d5"),

Guid.Parse("36f22e2d-9c63-468b-a80b-01b0b247bc13"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bae959eb-cf29-4417-8fd4-d07c41cbbe60"),

Guid.Parse("ebefbb38-bf69-4f84-b87e-b6e5206e95c9"),

Guid.Parse("fe81684a-2a91-45fa-a77e-d9faa4c0075f"),

Guid.Parse("aef17fb0-0262-4b55-8a16-6e8485a8bc01"),

},
},
            new GuiduuidArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("21d00f93-0c0b-4266-8ec3-27115c660c7d"),

Guid.Parse("9c282bdb-08c8-405c-ad5d-1dfa265a15c7"),

Guid.Parse("b401d401-4264-4f51-b83e-bbd62a1a1dd4"),

Guid.Parse("ba508104-060c-4a1c-9608-c0cdf309e95e"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("be137652-1950-4080-8cb0-914166a70fec"),

Guid.Parse("9513c555-e26a-4818-9f49-2b2a68a69b99"),

Guid.Parse("768c5d81-d38d-4a76-aefb-971525d3a532"),

Guid.Parse("75f9f77d-a2b6-4749-98dc-1051f2f97688"),

},
},
            new GuiduuidArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0985e85-ba00-4c48-94a7-0dc7b904ae7c"),

Guid.Parse("f64b8318-66d4-4ec5-b95c-f7f004713157"),

Guid.Parse("8d3d58d2-d965-42bc-93e6-94d3ba6060e0"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("78f52923-68f4-41cb-acc6-a272079fe9f9"),

Guid.Parse("b5259665-bca5-4977-ae9b-7c03c9c47be2"),

Guid.Parse("1cbe006a-e1d9-4add-ac18-3b292bd72a19"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9df4856e-87b5-44b3-a083-2671b45aaa7a"),

Guid.Parse("aabbca96-d4a0-4be6-b182-20b164573f55"),

Guid.Parse("fc795255-43cf-4346-a929-2588225e35d3"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("306255d9-23ab-413e-a912-6ba1486b3c18"),

Guid.Parse("0dd66671-64f4-49cb-ae3f-edac2aae4d74"),

Guid.Parse("b90a220e-d530-4e50-bf49-b5586e2e7559"),

Guid.Parse("df772f0c-36a5-4502-b12a-97ea59813099"),

},
},
            new GuiduuidArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab56427f-4e06-497e-9a69-64be21fc321d"),

Guid.Parse("08769eb7-3939-485e-b2a2-6f22dab10d9f"),

Guid.Parse("50b6c907-9efb-4d19-965a-5fe408ce56d3"),

Guid.Parse("9ad43a94-b8fe-431f-ae46-cbab3ba77537"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c8e9a2e1-534a-493d-821f-10ab71dc54d5"),

Guid.Parse("5ae4ef59-943d-4803-83aa-171324e87057"),

Guid.Parse("f81af59c-a5e5-4714-b3bf-6c6d9f7cdc0c"),

},
},
            new GuiduuidArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b6b6c391-43d0-4ad0-a453-bd83e08f8946"),

Guid.Parse("5affb0bd-3f6f-4365-a026-5a8cf204333b"),

Guid.Parse("f5c80779-518a-4261-bd26-20d4691aaacd"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27b16e01-66cb-42fa-99ef-72521834997d"),

Guid.Parse("14d4c56c-d02a-4f49-a78c-150edeeb5625"),

Guid.Parse("33aa0fcb-ea97-45af-9264-7826e075359a"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("964dabe5-c35a-441f-b6e7-e7a960a551f6"),

Guid.Parse("033ca44c-c445-40c3-9af0-d00c6a858028"),

Guid.Parse("f716a0df-665e-4da1-b6a1-2feec0c5e839"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f34a30ef-e142-4f9c-a438-9d15ce14671e"),

Guid.Parse("f1cf36ea-3826-4ec3-b984-ce7c689c5dbb"),

Guid.Parse("eb21a962-51cb-40b2-a515-4b813e5732b0"),

Guid.Parse("1f5e140a-e002-4d28-848c-68150d5cc166"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ffd10be5-e3f1-4f16-a221-8b7319531b97"),

Guid.Parse("6013e2df-5c2f-462b-a8b3-ace6847d8c8a"),

Guid.Parse("8ea42464-be85-450d-8f97-bf58780e9757"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f3d9f539-d3dd-467c-9e8f-2c856bf4aaf6"),

Guid.Parse("ac89ab95-6459-4685-8b64-56484c37555a"),

Guid.Parse("52bc50a6-eb25-4317-a04c-20a260327888"),

Guid.Parse("e79a3598-583b-49b7-991a-923cf66becfe"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3acc5798-9e9b-41d4-9f33-e36f2ac1c6a2"),

Guid.Parse("00bb4218-e6a6-4eac-b92a-ad9538600132"),

Guid.Parse("7f664fa6-e3ef-48c5-88c0-40dd65034a84"),

Guid.Parse("fb4417a9-f469-4528-ad52-d2f8b558b46c"),

},
},
            new GuiduuidArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("192ab171-e360-4c23-be38-8eb6f221c443"),

Guid.Parse("b43a2373-15b2-4d63-aa8c-b3e123e6db14"),

Guid.Parse("770bc206-1ba3-43ba-bd51-fcface438e7f"),

Guid.Parse("38eeda5e-4e31-408b-9169-cd709e2086a3"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d42ffd95-10e4-4ff6-8493-8c6046418113"),

Guid.Parse("8bf561ae-3ddc-4658-a46e-3e2c64c7fbde"),

Guid.Parse("112a6e49-5b6e-49a3-9caf-c7e7573e7c33"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a76b2755-926a-4de2-ae10-c843157dc15c"),

Guid.Parse("87512d0c-1a56-4cb5-8a00-bf3e39ff1eb1"),

Guid.Parse("d70d8359-1383-41fc-9b55-19d1b34040e5"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7f151f19-b825-4a5b-a6cc-03ea5ed63a3f"),

Guid.Parse("66eac4fb-8a7e-4f82-a6b8-e1c3e124f856"),

Guid.Parse("fb7d29b8-e28a-4cca-92aa-c30ccc5c1a3d"),

Guid.Parse("414b1c18-deff-4926-9bf0-bcff0afbb69a"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("383d1986-e920-47a3-8ac5-549602fab68d"),

Guid.Parse("134dc17c-8254-4c8f-92ab-12d470b6d20e"),

Guid.Parse("ac9c1bb6-e306-4cf9-9efe-c553e7b7fa5e"),

},
},
            new GuiduuidArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("369dd765-b056-4d70-8cc9-3a9eecfee51d"),

Guid.Parse("d5a6c9ac-ea6c-4776-a85c-29921098edaf"),

Guid.Parse("0b900ce8-95fd-43bf-8ae3-94a0fd768c5c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("050e3225-d9de-459c-904c-25072d4859a5"),

Guid.Parse("a26713a2-e962-40d6-af19-698ba0ac670b"),

Guid.Parse("a96b08ce-8861-4200-a883-a94a36abd7a0"),

Guid.Parse("7c7a6fec-c560-4d90-ba2c-73379d8e60b5"),

},
},
            new GuiduuidArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b4b4c27a-25f5-4611-977d-7b9afffaadb1"),

Guid.Parse("80b8840b-ce58-4b6a-9b99-6c28e343e9ef"),

Guid.Parse("db8ecf5c-af5e-4cdd-a1c9-7e744e5c7f54"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1f759f72-7eb9-41ba-a19b-0abc2346ac05"),

Guid.Parse("ea29766a-8dca-41ce-8092-4fe8d7cdc907"),

Guid.Parse("857e6ae3-0483-4463-b224-5620b1322ff3"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("80cdfb07-fe01-4d29-9f7b-8415e1b000f5"),

Guid.Parse("0ea6613a-693f-403f-8d4c-ce0a5b9589d7"),

Guid.Parse("11cf5d42-3635-4bab-8373-eaabeae75c40"),

},
},
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidListuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((IGuidListuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((IGuidListuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[1], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[2], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[3], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[4], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[5], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[6], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[7], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[8], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[21],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[22],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[23],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[24],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[25],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[26],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[27],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[2], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[3], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[4], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[5], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[6], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[7], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[8], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[21],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[22],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[23],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[24],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[25],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[26],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[29], false);
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
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
GuiduuidArray2M.AssertModel(models[0],_testData[11], false);GuiduuidArray2M.AssertModel(models[1],_testData[12], false);GuiduuidArray2M.AssertModel(models[2],_testData[13], false);GuiduuidArray2M.AssertModel(models[3],_testData[14], false);GuiduuidArray2M.AssertModel(models[4],_testData[15], false);GuiduuidArray2M.AssertModel(models[5],_testData[16], false);GuiduuidArray2M.AssertModel(models[6],_testData[17], false);GuiduuidArray2M.AssertModel(models[7],_testData[18], false);GuiduuidArray2M.AssertModel(models[8],_testData[19], false);GuiduuidArray2M.AssertModel(models[9],_testData[20], false);GuiduuidArray2M.AssertModel(models[10],_testData[21], false);GuiduuidArray2M.AssertModel(models[11],_testData[22], false);GuiduuidArray2M.AssertModel(models[12],_testData[23], false);GuiduuidArray2M.AssertModel(models[13],_testData[24], false);GuiduuidArray2M.AssertModel(models[14],_testData[25], false);GuiduuidArray2M.AssertModel(models[15],_testData[26], false);GuiduuidArray2M.AssertModel(models[16],_testData[27], false);GuiduuidArray2M.AssertModel(models[17],_testData[28], false);GuiduuidArray2M.AssertModel(models[18],_testData[29], false);
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
                var models = ((IGuidListuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
GuiduuidArray2M.AssertModel(models[0],_testData[26], false);GuiduuidArray2M.AssertModel(models[1],_testData[27], false);GuiduuidArray2M.AssertModel(models[2],_testData[28], false);GuiduuidArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
GuiduuidArray2M.AssertModel(models[0],_testData[19], false);GuiduuidArray2M.AssertModel(models[1],_testData[20], false);GuiduuidArray2M.AssertModel(models[2],_testData[21], false);GuiduuidArray2M.AssertModel(models[3],_testData[22], false);GuiduuidArray2M.AssertModel(models[4],_testData[23], false);GuiduuidArray2M.AssertModel(models[5],_testData[24], false);GuiduuidArray2M.AssertModel(models[6],_testData[25], false);GuiduuidArray2M.AssertModel(models[7],_testData[26], false);GuiduuidArray2M.AssertModel(models[8],_testData[27], false);GuiduuidArray2M.AssertModel(models[9],_testData[28], false);GuiduuidArray2M.AssertModel(models[10],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 93, query1, 4, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[1], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[2], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[3], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[4], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[5], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[6], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[7], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[8], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[21],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[22],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[23],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[24],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[25],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[26],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[27],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[28],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 13, query1, 144, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[2], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[3], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[4], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[5], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[6], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[7], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[8], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[21],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[22],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[23],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[24],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[25],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[26],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[29], false);
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
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 28, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
GuiduuidArray2M.AssertModel(models[0],_testData[4], false);GuiduuidArray2M.AssertModel(models[1],_testData[5], false);GuiduuidArray2M.AssertModel(models[2],_testData[6], false);GuiduuidArray2M.AssertModel(models[3],_testData[7], false);GuiduuidArray2M.AssertModel(models[4],_testData[8], false);GuiduuidArray2M.AssertModel(models[5],_testData[9], false);GuiduuidArray2M.AssertModel(models[6],_testData[10], false);GuiduuidArray2M.AssertModel(models[7],_testData[11], false);GuiduuidArray2M.AssertModel(models[8],_testData[12], false);GuiduuidArray2M.AssertModel(models[9],_testData[13], false);GuiduuidArray2M.AssertModel(models[10],_testData[14], false);GuiduuidArray2M.AssertModel(models[11],_testData[15], false);GuiduuidArray2M.AssertModel(models[12],_testData[16], false);GuiduuidArray2M.AssertModel(models[13],_testData[17], false);GuiduuidArray2M.AssertModel(models[14],_testData[18], false);GuiduuidArray2M.AssertModel(models[15],_testData[19], false);GuiduuidArray2M.AssertModel(models[16],_testData[20], false);GuiduuidArray2M.AssertModel(models[17],_testData[21], false);GuiduuidArray2M.AssertModel(models[18],_testData[22], false);GuiduuidArray2M.AssertModel(models[19],_testData[23], false);GuiduuidArray2M.AssertModel(models[20],_testData[24], false);GuiduuidArray2M.AssertModel(models[21],_testData[25], false);GuiduuidArray2M.AssertModel(models[22],_testData[26], false);GuiduuidArray2M.AssertModel(models[23],_testData[27], false);GuiduuidArray2M.AssertModel(models[24],_testData[28], false);GuiduuidArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
GuiduuidArray2M.AssertModel(models[0],_testData[7], false);GuiduuidArray2M.AssertModel(models[1],_testData[8], false);GuiduuidArray2M.AssertModel(models[2],_testData[9], false);GuiduuidArray2M.AssertModel(models[3],_testData[10], false);GuiduuidArray2M.AssertModel(models[4],_testData[11], false);GuiduuidArray2M.AssertModel(models[5],_testData[12], false);GuiduuidArray2M.AssertModel(models[6],_testData[13], false);GuiduuidArray2M.AssertModel(models[7],_testData[14], false);GuiduuidArray2M.AssertModel(models[8],_testData[15], false);GuiduuidArray2M.AssertModel(models[9],_testData[16], false);GuiduuidArray2M.AssertModel(models[10],_testData[17], false);GuiduuidArray2M.AssertModel(models[11],_testData[18], false);GuiduuidArray2M.AssertModel(models[12],_testData[19], false);GuiduuidArray2M.AssertModel(models[13],_testData[20], false);GuiduuidArray2M.AssertModel(models[14],_testData[21], false);GuiduuidArray2M.AssertModel(models[15],_testData[22], false);GuiduuidArray2M.AssertModel(models[16],_testData[23], false);GuiduuidArray2M.AssertModel(models[17],_testData[24], false);GuiduuidArray2M.AssertModel(models[18],_testData[25], false);GuiduuidArray2M.AssertModel(models[19],_testData[26], false);GuiduuidArray2M.AssertModel(models[20],_testData[27], false);GuiduuidArray2M.AssertModel(models[21],_testData[28], false);GuiduuidArray2M.AssertModel(models[22],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSelectModelBatch(connection, 93, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
GuiduuidArray2M.AssertModel(models[0],_testData[18], false);GuiduuidArray2M.AssertModel(models[1],_testData[19], false);GuiduuidArray2M.AssertModel(models[2],_testData[20], false);GuiduuidArray2M.AssertModel(models[3],_testData[21], false);GuiduuidArray2M.AssertModel(models[4],_testData[22], false);GuiduuidArray2M.AssertModel(models[5],_testData[23], false);GuiduuidArray2M.AssertModel(models[6],_testData[24], false);GuiduuidArray2M.AssertModel(models[7],_testData[25], false);GuiduuidArray2M.AssertModel(models[8],_testData[26], false);GuiduuidArray2M.AssertModel(models[9],_testData[27], false);GuiduuidArray2M.AssertModel(models[10],_testData[28], false);GuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
GuiduuidArray2M.AssertModel(models[0],_testData[17], false);GuiduuidArray2M.AssertModel(models[1],_testData[18], false);GuiduuidArray2M.AssertModel(models[2],_testData[19], false);GuiduuidArray2M.AssertModel(models[3],_testData[20], false);GuiduuidArray2M.AssertModel(models[4],_testData[21], false);GuiduuidArray2M.AssertModel(models[5],_testData[22], false);GuiduuidArray2M.AssertModel(models[6],_testData[23], false);GuiduuidArray2M.AssertModel(models[7],_testData[24], false);GuiduuidArray2M.AssertModel(models[8],_testData[25], false);GuiduuidArray2M.AssertModel(models[9],_testData[26], false);GuiduuidArray2M.AssertModel(models[10],_testData[27], false);GuiduuidArray2M.AssertModel(models[11],_testData[28], false);GuiduuidArray2M.AssertModel(models[12],_testData[29], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
GuiduuidArray2M.AssertModel(models[0],_testData[23], false);GuiduuidArray2M.AssertModel(models[1],_testData[24], false);GuiduuidArray2M.AssertModel(models[2],_testData[25], false);GuiduuidArray2M.AssertModel(models[3],_testData[26], false);GuiduuidArray2M.AssertModel(models[4],_testData[27], false);GuiduuidArray2M.AssertModel(models[5],_testData[28], false);GuiduuidArray2M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 140);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
GuiduuidArray2M.AssertModel(models[0],_testData[26], false);GuiduuidArray2M.AssertModel(models[1],_testData[27], false);GuiduuidArray2M.AssertModel(models[2],_testData[28], false);GuiduuidArray2M.AssertModel(models[3],_testData[29], false);
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

