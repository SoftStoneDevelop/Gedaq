

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8efa7892-17f2-4d54-b364-57ed1ef78d37"),

Guid.Parse("4117992b-a8b0-4b2f-b459-69004b2f2939"),

Guid.Parse("af0b4acb-0d6b-4672-bd1d-406b34a54121"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("08962c84-782f-4dd7-8436-1f2555d5ed11"),

Guid.Parse("7942dab0-abab-423d-9841-318ba15a0c9d"),

Guid.Parse("97f057c5-4406-4c9f-ac2e-2fd9a54a7119"),

Guid.Parse("9e8642d9-69ab-4aad-af6e-f471f355becd"),

},
},
            new GuiduuidArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8bc31a89-70c6-47b6-b358-bb389cef5580"),

Guid.Parse("034098b2-c1f4-4437-8e05-8eebfe0f9d82"),

Guid.Parse("615efac7-5e94-44c4-8fe2-b579dcab6c8c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ec372892-856b-4748-942b-ca3a780ad796"),

Guid.Parse("790a9270-2bf4-4551-bdc1-896194c60e90"),

Guid.Parse("b8c60761-f699-4f9f-b34e-c7f969acd633"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e3fa32eb-d778-4d33-9ad2-6164f31ee002"),

Guid.Parse("5ddfa1ea-e4f4-42f8-bf46-da5b8e851ba5"),

Guid.Parse("caca6824-cf96-4e61-8347-73b25ffae016"),

Guid.Parse("ded677e3-3207-4f9b-853b-5299aec52ad1"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cae95b17-9d03-4b34-8430-65e45330a69a"),

Guid.Parse("9c7fa9c3-3de0-4f7a-8029-55aac3dbf0c8"),

Guid.Parse("f4b450aa-1a35-4943-b11e-d23161222b88"),

Guid.Parse("7d29b87d-905e-4822-b5e7-242eeaefd7b0"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ef595f99-a828-4bbd-976f-d1a3b5c841dc"),

Guid.Parse("97ec1efc-745e-4209-9654-8043ea059113"),

Guid.Parse("6a125cf9-dd6d-4002-9890-84ce98a6a184"),

Guid.Parse("7855d179-c91c-463c-9b10-61ccc4b8e875"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("527b7382-e549-460c-9f74-5f9b8e218344"),

Guid.Parse("c0519c56-f174-4d57-a611-640308fd956c"),

Guid.Parse("11764a0e-0520-4ad3-9962-50ea1abcc975"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fde93bd7-de3c-4824-94a9-9a42ea22e85e"),

Guid.Parse("826af7ef-c885-4c4f-8406-67572c47e706"),

Guid.Parse("a10ddeb8-284e-46e3-8361-f07dbc2cccef"),

},
},
            new GuiduuidArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("322daf2f-ff6d-4922-a3b5-3e217c90e385"),

Guid.Parse("8aeb95a5-7f19-47c5-a2eb-aeb780acc08b"),

Guid.Parse("d17c64ff-bf00-4265-b34a-3c82028a789d"),

Guid.Parse("cb02e5b4-7766-4d18-b100-3f96147d1b85"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ff80c4fe-4134-4cd0-93d2-724f8e774706"),

Guid.Parse("1332a5f6-47a8-467b-8dad-19f1a79cd7eb"),

Guid.Parse("473581d6-3125-4f3e-a4eb-4ab4c27cf0dd"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("33b5cd76-a560-4ad0-a7fb-86da0e58291c"),

Guid.Parse("50d38887-348a-41c3-9e07-8e2496f9c5c8"),

Guid.Parse("6db99b27-5a62-4559-8f66-c45f33573d65"),

Guid.Parse("47411b01-70e9-4140-a522-3fa9204c4443"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("04257d57-7371-4629-a36c-8d86c1f92da4"),

Guid.Parse("0a174ef1-31f5-4600-8512-5b2427271aa4"),

Guid.Parse("6f0e2719-1c12-4f57-b970-498e0432db94"),

Guid.Parse("bad67dff-f13b-4b02-b355-232bbf167a01"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("11344961-677b-4da1-960a-941b5e140242"),

Guid.Parse("d852bc4a-5d11-487f-90ee-b3d6ca7d5f81"),

Guid.Parse("ed5e9cf3-86a1-485e-a5fd-c06d73355ebf"),

Guid.Parse("520b8ec8-5aa6-4a06-9234-a0ec5a76c40d"),

},
},
            new GuiduuidArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6c1e119c-111e-4052-a8a6-ba143e2b2278"),

Guid.Parse("5433e23c-391d-40fc-867a-f360c00564f0"),

Guid.Parse("fcb7caf7-b271-4fea-b09d-c2d4b0f23146"),

Guid.Parse("f8b76a5b-8bb7-491d-889e-f7c64c7d7fab"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c6364a59-6c7d-4553-af58-72ee7e7aaa4c"),

Guid.Parse("f7648b45-eb73-486c-a58a-efee2f831822"),

Guid.Parse("dce40134-c85a-4b5b-8ff3-6a10022acd2c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("68bf440e-c889-434e-ac4e-56ae31d4aac4"),

Guid.Parse("f15fdd90-47d0-4900-9857-fbecff1af229"),

Guid.Parse("a4f52132-6402-4ca8-a6b1-512a61b5ace2"),

Guid.Parse("6fd66e6a-f8b5-4035-8261-92bcae4cf5f3"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2c4aeeb9-5c49-4711-aa02-2d27d226317e"),

Guid.Parse("6de90b81-a373-48d3-a3a8-60d708d7a0d1"),

Guid.Parse("cc7ff610-f986-446c-872a-6a429c3e32f6"),

},
},
            new GuiduuidArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d03f065b-067f-48ba-9ff4-abb6a7cefeb3"),

Guid.Parse("3070853d-e318-4678-bfa7-68633850a6bf"),

Guid.Parse("9604662b-abfe-41cd-b990-2842d2ec2827"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("caeeb10b-e326-4a0f-9018-b1fcdb75153d"),

Guid.Parse("43c20dfe-4089-4f80-81d6-d9f319041cdd"),

Guid.Parse("35e59e5e-11d1-4acc-a5f8-63f242f49fe6"),

Guid.Parse("d43c2a07-c873-4470-bd1d-88f37d4a2615"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("19fe3814-f447-4e96-a1ee-e944bf2ec066"),

Guid.Parse("76907c81-0961-4cbf-8ee0-fd919268e875"),

Guid.Parse("80c99ab2-0c8d-4a0e-a13a-a883fb04783c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a224a53b-40ef-4975-b8bd-f716b612b0a4"),

Guid.Parse("4b42908c-d209-4f63-8a21-a918529346ad"),

Guid.Parse("92364de9-4538-403d-b5fc-15b9176fcbff"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f616d373-2f8d-452c-a70f-1a2cc1fbc554"),

Guid.Parse("09fa5eec-3c2b-4eac-bba9-4f1c2cf99d7a"),

Guid.Parse("24d03c7c-29f6-44a1-a774-678a61ddd3bb"),

},
},
            new GuiduuidArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("561b750b-9600-4c00-aee3-ad57f6830905"),

Guid.Parse("bdfe2779-fc93-40f6-b4c5-f810168b8a3f"),

Guid.Parse("f4611c32-4405-4e4a-9261-3b71395506fc"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fc46c3f0-c491-4314-9714-d1f080a50b23"),

Guid.Parse("c4cfeda2-66fd-47a7-a273-cf4d30ccc827"),

Guid.Parse("5bf4f426-8339-4480-b310-9c37a8f0d676"),

Guid.Parse("30bc9d61-38f2-4248-aae5-d0b8171d3754"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e9d7bfba-885b-41fc-995f-057fd818ac24"),

Guid.Parse("efe0ae02-1161-4b2a-bbd9-a3e4764eb370"),

Guid.Parse("ca2ca6be-1571-495d-8f9a-e71491cc09ca"),

Guid.Parse("49543695-49c6-44e0-bfdb-39910ae3be6f"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("beb7cbc4-befe-487a-9bd5-3a1f4a48c847"),

Guid.Parse("1c841c77-a7ba-4651-9b5a-7ea7a5206e31"),

Guid.Parse("3440fc99-7427-4e17-a50c-d0c3ab0d88b7"),

Guid.Parse("a53a07d2-1833-4dcd-8875-061849ab0625"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("03918646-5278-46d6-bd5c-690fe8533150"),

Guid.Parse("fe9a257f-7d40-4636-a03f-10d7e3043af2"),

Guid.Parse("df28bb69-06f8-40d8-919e-9783695d5054"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f4627354-d85f-48e0-80e4-22cecb61ea02"),

Guid.Parse("34364b99-5b16-473b-87f5-1277db8a539a"),

Guid.Parse("8251f4fc-d09d-413c-a421-d04106ed543e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b8f7a5b5-3e20-4ee7-b787-c06a680319fd"),

Guid.Parse("36c654d4-9d5b-49f6-a4c2-a68da60ad2ee"),

Guid.Parse("c8523b69-f224-467d-9b7d-4b863610c16b"),

Guid.Parse("ba5f0ef9-99d3-4df9-94a2-a77a868b736c"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d5aa7cf8-59a2-44c8-a2f9-4f50cc215d0a"),

Guid.Parse("ed12b071-861e-43b3-854a-4c0b35988218"),

Guid.Parse("70bb8c12-1f83-4285-924e-4306b299fc3b"),

},
},
            new GuiduuidArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bf12a8ce-af4a-4f94-89e0-885a7949f1c2"),

Guid.Parse("e386c446-b5f8-4872-b7bb-d763ae5107a7"),

Guid.Parse("881ef02d-6d56-4714-b711-11e23ce5829d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("faeba1e6-d282-42ff-8535-4c2cc331435c"),

Guid.Parse("28175a9e-8dff-4361-a906-791e7f1d3953"),

Guid.Parse("025adf7e-906a-4dfc-90ca-95993655af25"),

Guid.Parse("ea796752-1ece-4231-abf8-6776ff1acc6d"),

},
},
            new GuiduuidArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e90dd2bc-367f-42f6-847e-d9a02176eae1"),

Guid.Parse("c4ccdb37-09ea-4e91-88d9-fb17dc7b8e0b"),

Guid.Parse("ef6bcf31-ce50-4f29-bfa9-b8243b1bbc96"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("52e6a8d0-2b9c-49e7-80dc-e4611cb23d59"),

Guid.Parse("206eee82-7efc-4275-b97a-66c2c2682faf"),

Guid.Parse("751941b8-1d37-4ce2-bea7-80b3864e19ea"),

Guid.Parse("b215160e-3fbd-41c0-8f0f-a4a3fbf87975"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1971094-5a23-4768-b5e4-5372b8d150fb"),

Guid.Parse("aa628009-b288-4ee5-8b17-f09c67565450"),

Guid.Parse("22619ce1-7b50-45d4-9a21-91fad18f077b"),

Guid.Parse("dd1e526c-7ba0-4a69-b653-df6e94d066cb"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a5d540ab-1422-4bef-803b-6ecb4e7eef89"),

Guid.Parse("b640ae57-b7bd-43a8-a84a-81a81a64764b"),

Guid.Parse("57e8af2e-4a29-4139-a1b5-8b1334f8853f"),

Guid.Parse("05b8dc3c-e725-4f5d-8826-6cf205528cbe"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("333316d0-2aa0-4930-b247-a3182220e934"),

Guid.Parse("daf32e36-d5e6-4f88-9597-0f1cbf909a38"),

Guid.Parse("4a0c61e8-3b99-4ef2-9c23-e4829e3600da"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("12ecc62b-3d9a-4682-b487-5dec97e6f668"),

Guid.Parse("b0c43bab-20d7-42fd-ab7a-2d43953e2ebc"),

Guid.Parse("97a297a6-4ada-48f1-b92f-0e6a8c109b58"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c0115506-c939-4e7d-820b-5e37bcbf4ecc"),

Guid.Parse("a91bbd0d-2ba4-4ca2-ba1a-23efd463c58c"),

Guid.Parse("6e06ae81-dd45-4821-bc5b-292f6502fb17"),

Guid.Parse("ff6322ec-d6ae-4371-930b-e1f78493c2ce"),

},
},
            new GuiduuidArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5fcad5d7-8e36-4208-955a-539f7f964aca"),

Guid.Parse("1e1b8ed9-8819-4791-8706-bb18de5b39f0"),

Guid.Parse("da0a3456-849b-4196-ac2b-b34c2d186c51"),

Guid.Parse("7f44164a-004b-4e87-9ddc-7abb71e636cd"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ea013dd3-a329-42b0-9e16-260d013493f2"),

Guid.Parse("1591ddc5-a837-4ed7-8816-c04cafa79363"),

Guid.Parse("9a4a2faa-2480-45c1-ae48-207ff44ab9b4"),

Guid.Parse("2a54bd3a-6e8a-40f9-a00e-796542588fc0"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9d2525eb-3049-4e9a-8759-6e99df39ce96"),

Guid.Parse("0ee29479-ed81-421c-8b0b-a438d036233e"),

Guid.Parse("0fd0ec33-86c1-4098-8341-c03f92db2ffb"),

Guid.Parse("a2299e5e-ddc3-4cdf-ae01-a8e3344def22"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6a394cb7-bbd1-4286-81fa-62a493def417"),

Guid.Parse("a79e4999-b2ea-458f-9d54-433bfb61824e"),

Guid.Parse("73e8f1ff-d219-4227-a86e-38e6d5455e4f"),

Guid.Parse("4450f069-c5d6-4235-b086-a9840b7aa325"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("06eee814-48e9-44db-b822-b048547a2522"),

Guid.Parse("f14c0e6e-dfb0-4914-8a75-a9b9d0034321"),

Guid.Parse("fea06e73-a83b-4c14-864a-d17eeeb70b23"),

Guid.Parse("4719f390-b471-4031-a389-d3dbe361d03a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("60ea5a66-abc2-48a4-882b-781dd5ac7ba5"),

Guid.Parse("87efe937-d6bb-40f9-8cf9-99cb6dad9732"),

Guid.Parse("e5e88982-8fb4-4ab6-b620-de977604c88a"),

},
},
            new GuiduuidArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("836924a9-a98a-42f3-8977-30cfa140d05e"),

Guid.Parse("fd6d6cfd-9740-44b3-9b7a-7aa00cccf32d"),

Guid.Parse("a0231374-7337-4dc0-8c64-6f529ec5dc91"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eafd98d6-05d8-45ac-9aed-0a1f2675be60"),

Guid.Parse("addd1e22-a030-42de-abcc-9b4d134ed0a4"),

Guid.Parse("09f51e82-0e32-4200-a006-0eaeb4e4ee83"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e17c7e88-10d4-44e2-b7e2-efee50252c3f"),

Guid.Parse("f931bbbd-da8b-4a27-9e46-0556c10e2eea"),

Guid.Parse("4d1e990c-f256-4b97-8b04-f86d9138cc6c"),

},
},
            new GuiduuidArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("32eb72a6-41cc-41bc-995b-3ecaf94763d4"),

Guid.Parse("e7d6047b-ba1c-49e3-94ef-d89d829580ed"),

Guid.Parse("ad51b5f6-572e-4bed-a5ba-5143bc86ef60"),

Guid.Parse("f66f5ce7-170f-4d3e-8f38-38282c74bff8"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("21e32628-0d7f-4450-9e63-372fea06cdcc"),

Guid.Parse("36555c4f-a47f-4793-93d1-5fb4f51fced6"),

Guid.Parse("6363b5f2-3ff5-4b65-9076-c3287623336d"),

Guid.Parse("e9b926c4-a6e0-4f57-9899-c68197541cec"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("46e9a3d3-2a7a-4cbf-9875-185c2d3faa1b"),

Guid.Parse("81b664ed-ee41-443d-a2c2-747ce0e9d431"),

Guid.Parse("3c02c4df-52e8-4547-840c-54b89cd272d8"),

Guid.Parse("4ce974ce-5aa8-4339-9147-e8148bb06c37"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20a951bf-27e0-48ac-8518-dd987b21e333"),

Guid.Parse("79d1d056-ca56-4f20-bdd6-8f795fbd952b"),

Guid.Parse("a2e27159-795f-4ef2-899a-2b593666ba8b"),

Guid.Parse("7d4f08aa-f6c6-4d06-90ce-38d2fe27b537"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("219a6512-01f7-4a5f-b6e4-655f6efbd0a6"),

Guid.Parse("53c455c0-e4b4-4142-ae96-7cfd6da4bfb6"),

Guid.Parse("1024922e-5c88-4c3a-b966-6f1848318d02"),

},
},
            new GuiduuidArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("90f346d0-d328-45b0-9c9a-56a94a6e8569"),

Guid.Parse("196d8305-e925-40dd-993e-6483f7a89737"),

Guid.Parse("6f977f59-da20-4cca-9091-0bfa5db8e064"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d3aa3ed7-fe34-4dce-8792-bca6fbbf699a"),

Guid.Parse("5247e322-f4fe-4b8d-a35e-14f97cb7e8c9"),

Guid.Parse("51ddf556-ad4c-4c0f-bcda-adfa856d9f28"),

Guid.Parse("f7eace34-7ddf-490d-bde4-d3bf0542a2ec"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e362374f-582a-42f7-8225-14fa894f620c"),

Guid.Parse("5835ac84-fa52-42d9-adb6-957667c7e888"),

Guid.Parse("cf26b454-2fa6-450a-acfe-41c8b32cbbd6"),

Guid.Parse("58d4bc87-fdfa-4d02-b696-dca3915bf340"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27562090-526f-44af-b0e4-d213f37f44cb"),

Guid.Parse("ef6ec463-cba6-44b0-8e24-eebf5c64bdeb"),

Guid.Parse("64263de9-67bd-4524-9fb4-b00db44a8f98"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0fa73f4b-67c0-4938-8117-c17521e65e00"),

Guid.Parse("003e5bf6-1f49-4a75-998c-51786e5b6e63"),

Guid.Parse("1d4f531a-1b33-4570-9552-1d3149098abd"),

},
},
            new GuiduuidArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8ddd9bd9-b4ea-4bb0-912c-470705aaaecb"),

Guid.Parse("05bc0efe-040b-4580-8867-6ce231f3ea49"),

Guid.Parse("ea7ae557-9502-4982-ba01-b14c27e4bfb7"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d6459901-e0dc-4b3e-86ea-5e3d33aab073"),

Guid.Parse("10ebba97-994b-4ff3-9b63-4631fd7c2d93"),

Guid.Parse("d880a341-87c3-4823-947c-f7f9e2c26f35"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("be907b7e-8b6f-40d0-b7c2-d3d248b9c1a0"),

Guid.Parse("70f980b3-e276-4f51-ac8c-1215fada7be1"),

Guid.Parse("35d4533b-69b2-4525-b13a-ec13420a5e66"),

Guid.Parse("b8bf559c-e4d0-48f6-ba2d-8fb3f9b29459"),

},
},
            new GuiduuidArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("65bc4c6f-acb9-4c44-a82b-aa82d8cb27df"),

Guid.Parse("70169605-5a13-47f0-abb6-d4f9120e6300"),

Guid.Parse("1c4e3e98-1521-4079-93f7-9f0eadb0060c"),

Guid.Parse("cdbe1583-d686-48c8-bdcf-dc00a15a84e5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d6e9a9ac-38be-49bc-a070-88c73ea9cff6"),

Guid.Parse("4bf74f42-d530-4de1-b6ca-2bbb54ed5f4d"),

Guid.Parse("8f0a7928-57fe-45c0-8d4f-b43f512ea803"),

Guid.Parse("b5ebc167-cf8f-4082-a88c-8a1b5d03350c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("572e5789-d6e7-4abb-92eb-61db04abb1c1"),

Guid.Parse("718d14d1-1b8e-4b3d-b9e5-5bf71ff11534"),

Guid.Parse("93167873-1e06-4121-8f12-4c5476046b42"),

Guid.Parse("13c1a479-7071-45fb-b03e-e11299bbc928"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b5c0dedb-14fc-4800-aef8-d49475fcf302"),

Guid.Parse("4d2c7a84-b398-4ca1-bd59-26472708e821"),

Guid.Parse("0362328a-63ae-4852-a25b-1f7c89bf9f8a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bc3ad7ca-fd4c-4cd3-a698-6367af8f5eca"),

Guid.Parse("3ab3e003-2054-42d3-b14d-a674a75deb74"),

Guid.Parse("9e7cf97b-26a4-47b7-9eba-257b449434c7"),

Guid.Parse("9051bfc7-9790-4cba-8377-4eab283ddede"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f21bc957-3a23-4b91-9bdc-482cb3fe3914"),

Guid.Parse("925dcc06-498f-4ee4-b9b1-06409cbd0de8"),

Guid.Parse("b5cd7f0b-a8a1-4441-b66b-d427cb614e20"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e1d5da26-f860-4026-a00a-0fc6b257e668"),

Guid.Parse("a5c1df42-f327-4416-9570-3305688d7e5c"),

Guid.Parse("2e3dee69-35fc-499f-93be-82b39f6eb629"),

},
},
            new GuiduuidArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3e64fa0-04d4-4dc1-8660-08fcc3ecab49"),

Guid.Parse("e5dd4cab-2367-4649-8836-ad7f36dbc7eb"),

Guid.Parse("9b742feb-62ec-4d0f-9f8f-6b44d67bff87"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2230f4a6-6d93-4001-9f2b-2f307b6576b3"),

Guid.Parse("42c33d04-cacf-438a-8397-5b09c746aa22"),

Guid.Parse("985a783c-872a-4ba0-8e87-bc43656d0fef"),

Guid.Parse("fa2306bf-e345-4677-97a5-016d64e0c30f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("04adcfa7-198e-4dad-8951-d980ea38add8"),

Guid.Parse("0b2acabc-e187-4f4c-ab90-d91954fc7259"),

Guid.Parse("0e9e7fe6-dd95-4829-841d-13a1c76afd40"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cad323fa-050a-43ff-9e61-2a0bb9ccdcf8"),

Guid.Parse("df3b9cef-29c4-409e-abe8-1066d6926541"),

Guid.Parse("37970d91-0739-4b6b-8d58-3c4cd0555d75"),

},
},
            new GuiduuidArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ec33d4fd-1abf-4651-8c3b-1ed2563b616c"),

Guid.Parse("0eff139b-0b4c-4345-9a02-708c347799fe"),

Guid.Parse("1d960bb5-336c-4019-899c-fb2ea95cc835"),

Guid.Parse("010e16e2-c570-4bf4-88cb-7725ddc8fa24"),

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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidArray2M.AssertModel(models[0],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidArray2M.AssertModel(models[0],_testData[2], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[3], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[4], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[29],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[30],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[31],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 119, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 137, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 47, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 37, query1, 158, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 15, query1, 145, query2))
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 23, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 40, query1, 106, query2))
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 47, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidArray2M.AssertModel(models[0],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 112, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        GuiduuidArray2M.AssertModel(models[0],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 47);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
GuiduuidArray2M.AssertModel(models[0],_testData[16], false);GuiduuidArray2M.AssertModel(models[1],_testData[17], false);GuiduuidArray2M.AssertModel(models[2],_testData[18], false);GuiduuidArray2M.AssertModel(models[3],_testData[19], false);GuiduuidArray2M.AssertModel(models[4],_testData[20], false);GuiduuidArray2M.AssertModel(models[5],_testData[21], false);GuiduuidArray2M.AssertModel(models[6],_testData[22], false);GuiduuidArray2M.AssertModel(models[7],_testData[23], false);GuiduuidArray2M.AssertModel(models[8],_testData[24], false);GuiduuidArray2M.AssertModel(models[9],_testData[25], false);GuiduuidArray2M.AssertModel(models[10],_testData[26], false);GuiduuidArray2M.AssertModel(models[11],_testData[27], false);GuiduuidArray2M.AssertModel(models[12],_testData[28], false);GuiduuidArray2M.AssertModel(models[13],_testData[29], false);GuiduuidArray2M.AssertModel(models[14],_testData[30], false);GuiduuidArray2M.AssertModel(models[15],_testData[31], false);GuiduuidArray2M.AssertModel(models[16],_testData[32], false);GuiduuidArray2M.AssertModel(models[17],_testData[33], false);GuiduuidArray2M.AssertModel(models[18],_testData[34], false);
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

