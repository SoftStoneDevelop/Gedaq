

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
Guid.Parse("4ef9df0b-62c4-4f78-8aee-0fe12c6b56fd"),

Guid.Parse("bd366dc1-1012-4e9c-bedb-3e049a74bd78"),

Guid.Parse("1b5c0c4e-ff6d-41de-bd83-721e38b61d6c"),

Guid.Parse("1688d7ef-bf13-473e-a94d-59deab40bdf2"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("15fa49c9-19ed-459b-8298-9c64de0c6e5d"),

Guid.Parse("066b8876-c303-4684-9f84-c100041e7284"),

Guid.Parse("71e39e5e-a9e8-4787-a1cd-4046dcef880d"),

Guid.Parse("77b92423-5538-43ea-a427-2d385ee77e1e"),

},
},
            new GuiduuidArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8d4c1a27-44ad-4687-81cf-ded4a4526cdf"),

Guid.Parse("efb48f92-1e70-4511-b0d9-7ca15705216b"),

Guid.Parse("4c99a2cf-8d82-4119-951a-f8d5ce99e18b"),

Guid.Parse("77406162-eeaf-4d3b-b204-caaa0ad88f40"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6e08d3be-ba87-4aa3-acbb-708bfed99d90"),

Guid.Parse("17052167-2f5c-45ee-88ec-e621b1d1ad16"),

Guid.Parse("7f98afd0-fe61-41dc-b521-fb6253a2bf3a"),

Guid.Parse("659dfbb0-3606-4251-bf78-6f8e2d9a46d6"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4e4a1d64-d9f9-4370-b14a-f21c7a6b0b44"),

Guid.Parse("7349c83f-7c31-4ca3-8a83-4497377d1f50"),

Guid.Parse("41ec9196-ddfe-47dc-8965-466e799613d3"),

Guid.Parse("257e020e-fbc1-478e-9117-a4483b790b46"),

},
},
            new GuiduuidArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("de690af6-71c2-4eb7-bb62-6323b5702838"),

Guid.Parse("70853b11-0a96-4d22-be4d-fdc9cb06efcf"),

Guid.Parse("1cbee692-3218-43c9-a77f-bb5ce4780df5"),

Guid.Parse("94de6301-c4b1-47df-bfd8-44cad9155213"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8eecf9a3-37f2-490f-a04a-1bf19c908957"),

Guid.Parse("92b8e066-a580-4a07-8def-34efa86b99e2"),

Guid.Parse("c216968b-3662-4f10-9d4a-d7a3dc1b3a26"),

},
},
            new GuiduuidArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("95ff68b9-d958-4689-a54f-3de525869500"),

Guid.Parse("c698610e-a4f8-49f4-861d-6b77f49ef0b4"),

Guid.Parse("a5003465-39ad-4b55-a069-e3d50a3a3c8c"),

Guid.Parse("3336cf56-d9c5-4630-a426-6635e2ba45ee"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2572df67-c5ef-49e2-adc6-749f46edaa1c"),

Guid.Parse("acf3fc63-6671-43e6-be04-250e9a25ab61"),

Guid.Parse("caf33e66-52b1-47c7-bd1f-b06d9a32d35a"),

Guid.Parse("57bc26a1-ffad-44f3-b661-99cc3389cb9f"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("426215b8-8a37-4a9b-a7cc-1bf1fb873035"),

Guid.Parse("17c415da-d2ac-4f75-a7ba-b53e8b6a5164"),

Guid.Parse("7a285d4b-77c8-4a27-a513-ec20ab31bb7b"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d64c5463-0513-45cc-a453-954f62aeb3c7"),

Guid.Parse("595c0685-8bd7-4b45-a429-2be2291e85c9"),

Guid.Parse("301ab6d4-fd3e-47f3-aff6-36dae8c1e94d"),

},
},
            new GuiduuidArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e3276a93-0a45-47e0-9828-78b2cc58fbec"),

Guid.Parse("ce96431c-8194-42fa-90e9-2af489cff199"),

Guid.Parse("95f84065-e6f0-42bc-81ba-b2f427f123c8"),

Guid.Parse("2b8079b9-06c2-4608-9f40-df96b655c955"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ceeb10b5-11cd-4cd9-9377-664c7ebbf9ba"),

Guid.Parse("b776d33c-81d5-43c1-8cdd-e1041737602f"),

Guid.Parse("b84d1fb9-093a-4841-b1c5-39b740be1fc5"),

},
},
            new GuiduuidArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("100d5731-9695-41ef-a365-87250f906e7a"),

Guid.Parse("ea5b68fa-257b-4372-9864-71dfe021352b"),

Guid.Parse("7ffa3e13-2702-41cc-8fb3-aa8d3b6f1f4b"),

Guid.Parse("4386c26b-fffc-4d4b-ba58-73108aa6fe38"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e4a7fcb9-e1b2-4e87-9268-2524e89cc4e3"),

Guid.Parse("9da2fe7f-ef8b-4469-b8cc-2c9bdd7cfbc0"),

Guid.Parse("35d163d2-93ef-41bc-a06f-7548a0a763a6"),

Guid.Parse("f3e6373a-ac8a-4559-a583-6151257ef0cc"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6f1c81a3-ba13-402b-bafb-bf0e348aec4f"),

Guid.Parse("8f73f103-845e-4d35-a906-c5721d15cb48"),

Guid.Parse("3458a652-752a-4980-a748-7f22910bcee5"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("16b9fa4d-1dbf-4507-bb1c-b09adcb57df9"),

Guid.Parse("074e30a0-d2d2-49c7-a788-e333457497e9"),

Guid.Parse("7f1be7e1-47e5-4fad-8ef3-73ebbbfd9ad6"),

},
},
            new GuiduuidArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3a4bd216-35d8-4368-b453-fc37c8398a30"),

Guid.Parse("d4a772aa-da24-4ebe-9178-324929f4fcb0"),

Guid.Parse("c6d6b378-ec2b-4e91-a754-31ea38eb4667"),

Guid.Parse("86b32a13-98e0-41a3-9e85-59b49a076e6e"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6f9f56d9-81a7-459c-8dc2-160ba690ea7d"),

Guid.Parse("39e9c3c2-0b74-4331-b51e-7196e1bf6bfa"),

Guid.Parse("f7ae9f68-0fdc-4d03-9375-ffbb815670ea"),

},
},
            new GuiduuidArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4a8f2ccb-0b10-4f35-978b-063f380c0801"),

Guid.Parse("7a4c8fcd-4db1-4ed9-81bb-0dea22752b81"),

Guid.Parse("a49524ed-9465-4f12-937b-9c0b4081973b"),

Guid.Parse("134ed55f-42ae-4616-93f3-23e6ed060ade"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a9ec9e70-06f1-4bc5-ab96-04d6f77f69df"),

Guid.Parse("3944df06-1e7f-4eec-ad25-082276c61f3b"),

Guid.Parse("d849f35b-0537-4270-b357-7b9df6427d41"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e01f2461-6d08-4b72-923e-42e39b48fdf1"),

Guid.Parse("baee271f-42c5-42b9-a966-7d5d52a08f46"),

Guid.Parse("2cc24fe9-7604-442f-8ed6-a63a5ebac573"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fd3fd401-e4c9-4083-a446-aef81ce16abb"),

Guid.Parse("8be3579e-390e-4d52-9bf5-58c16edc3a47"),

Guid.Parse("2243c407-6162-4c52-bbc1-93c71a3e4c4a"),

},
},
            new GuiduuidArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3d0f891f-009a-43bf-8106-84ab34a77465"),

Guid.Parse("32559d2d-9130-43f8-9db6-2d1aa8f57497"),

Guid.Parse("970b5df0-a7b0-4ad5-8e2e-7b9bce0f105a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("672ea42a-a729-45e5-bddf-6ab4cbd4a6c5"),

Guid.Parse("0d7affdb-55db-43a9-a8e9-98e1c72dddc4"),

Guid.Parse("676d996e-7812-4a3a-b575-3200af6ce623"),

Guid.Parse("bcdf4c45-fd5b-4ede-ab23-2413b796c38e"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f1e93816-634c-4fb1-852c-8da5a92b1574"),

Guid.Parse("402976d4-1a16-4dca-9087-374bab0d76cb"),

Guid.Parse("03f7df12-1b66-45a4-a4b3-3cbcf4730af2"),

Guid.Parse("fafcc96e-bf91-4ce4-a38d-2139f86de911"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7124880f-51ec-432c-b572-0799df4ac1c3"),

Guid.Parse("7d23390e-6c0f-4489-b2ae-f6392d0ffc97"),

Guid.Parse("3410d8dc-c4e0-41fd-a6f1-ed1343fd2f40"),

Guid.Parse("6da910fb-1fe7-47b2-8f70-5fe3153feedc"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("26fc7fca-3e4c-4265-a6be-a6afc4ec5378"),

Guid.Parse("9f58f2a1-5985-4685-bd55-b63209e0b2dd"),

Guid.Parse("7e157975-2a89-4fea-b5b6-093764db17a5"),

Guid.Parse("a317d188-e45d-4e81-9fde-dab4151304f9"),

},
},
            new GuiduuidArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c8d06eca-bee2-4926-8aba-acee16c5190c"),

Guid.Parse("d1ff7896-cc11-496b-9223-c412dae3818b"),

Guid.Parse("ac2375be-d101-4abd-ba0e-d69a9c3a2288"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("abd253b4-bfea-42c5-8061-ca432330540e"),

Guid.Parse("039a84b6-bc20-4485-8ce2-435e643b96a0"),

Guid.Parse("cb626d97-db82-41cb-be9a-8c291627981b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("229aa52c-1de0-46d4-b94e-f084e8f2a415"),

Guid.Parse("2a88a702-4b4d-4262-8976-11df80f305e6"),

Guid.Parse("9ba61b73-28f3-466d-a037-431846f3bf32"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0eb5a4ac-0e4a-4973-b985-72d1d8b9f983"),

Guid.Parse("15781757-d563-4762-ba24-aa189e8f274b"),

Guid.Parse("5a9d3695-ce48-4dab-91c9-321002802a5e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("eb2c4a56-f764-45ec-b511-572f257e731d"),

Guid.Parse("b804c80c-d2f4-4342-a08d-dc8e9224337b"),

Guid.Parse("958e84df-a540-438f-a753-f01e27cf30e1"),

Guid.Parse("d09c5848-1d3d-4c30-92fb-9e9b1b0c7df7"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3bc3e48c-4d30-4df0-8417-507d0a6278d5"),

Guid.Parse("4c9c4c5d-5592-4e3b-9e65-bcb20bd4bd63"),

Guid.Parse("8e92be41-c390-4243-88d9-9ca6172b7d80"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("015905fc-e445-4efc-837d-7b8c72dd873f"),

Guid.Parse("c15729a6-12d9-44aa-8665-7e5d576fc286"),

Guid.Parse("df9f3b3e-89dc-4572-b84c-d620d5273c5e"),

},
},
            new GuiduuidArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5e2c4f06-76fb-4c4f-8bc5-ff602b67d062"),

Guid.Parse("7d303261-2d0a-4f64-9386-dcaac48e65be"),

Guid.Parse("62c1c492-b2f8-4f42-977e-c359e2d0f83f"),

Guid.Parse("347afe43-0762-48d0-83ea-7205aa9ec7f7"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bd1b5503-920f-4c2b-9896-c5d6da94dd32"),

Guid.Parse("c8a88aa0-1acd-43ef-908a-d74e3730c439"),

Guid.Parse("d448daef-7135-4914-95c6-12b44f70bf78"),

},
},
            new GuiduuidArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bea86c15-b03c-4adc-b3ec-27113a0447e6"),

Guid.Parse("6338f336-bb1a-4596-b34c-1eef737db79a"),

Guid.Parse("8ebcfd6c-00da-421a-b418-a76c7c75f401"),

Guid.Parse("de228820-1a21-459f-9cb9-3c6bc3050f12"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e94f9af5-78c1-4d35-ae67-099a285b3744"),

Guid.Parse("143c1170-37c3-406d-a97c-82eb7817d2f2"),

Guid.Parse("e7c297ec-0aa7-41af-b78d-6a56ec5916e0"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("05089e83-5640-43c2-a3e2-979c29d3e2a1"),

Guid.Parse("7cf7a2f7-1835-4aaa-a472-c9697d09bfec"),

Guid.Parse("d93a3679-4ded-4b00-a47b-9f27cd342e39"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("68a43d6b-f8a2-4ea3-9239-e81990343499"),

Guid.Parse("920d9b21-77ff-4f6e-978e-4642157bcdd2"),

Guid.Parse("180a2950-2feb-4e40-942f-eef291d14bf6"),

},
},
            new GuiduuidArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5558a914-d10c-49dd-b1b4-8bb98a02fd20"),

Guid.Parse("b36b0006-1914-4dc2-b448-ab297d021b04"),

Guid.Parse("e9b3ada3-f635-4ed8-89e3-574ed58367a0"),

Guid.Parse("1184bcd1-8a98-4f86-8337-fcc3a5f5cf8d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2a32c799-afcc-4e35-8dba-6d1dd1f32a59"),

Guid.Parse("967c44b6-e2cf-4ea7-b474-ab897d523f32"),

Guid.Parse("00e17be4-ddd6-404e-a4c1-094d9e5fde7f"),

Guid.Parse("5cbdea0f-4120-43b7-a797-ff0dd95c72e8"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("67b96cd0-f9fb-4da4-95ab-1950e1a56a5d"),

Guid.Parse("788036fc-e565-49f5-8f98-7387ee90ffd5"),

Guid.Parse("4777ad4d-7fd8-4715-a6e5-c34953530f23"),

Guid.Parse("60f1f52e-18c3-4a84-bc48-5d58ad39b750"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("696ce005-7f01-468f-9ced-e05d9c0a188b"),

Guid.Parse("7385e6e9-9327-48ab-8d1e-83ae8897b452"),

Guid.Parse("6ed35e12-8841-46f6-92a6-9dd8571070e6"),

},
},
            new GuiduuidArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6322e229-19d8-4d89-82f1-2c989082bd92"),

Guid.Parse("5654565d-3b79-4eeb-8271-83422e6cb875"),

Guid.Parse("8a834dab-28c8-4915-bacb-38f19772ee09"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("74147a41-c2d3-4786-9ad2-477b4ad9293c"),

Guid.Parse("fa881a0d-e691-4bda-96e5-d72bbc5c254c"),

Guid.Parse("3f2510a6-143f-4d0b-ae54-2113717fa7af"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8282e6bf-2d12-4eee-9588-5aa6f1e8290c"),

Guid.Parse("5048a6cc-90aa-4348-8997-416c54d1845b"),

Guid.Parse("d12a60eb-f07d-474e-92dc-b8e97d2b684d"),

Guid.Parse("91c644e7-4069-4f37-93ce-e97a6fd010bf"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4aae38c8-5079-4ff9-811f-a2ee1e71731b"),

Guid.Parse("b84308e1-1e03-4549-86ae-d4a78b322d2b"),

Guid.Parse("cccbb7b9-0226-445b-8ab6-eebbced60193"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("79b5e99d-5e5e-456d-b5c8-cb21d9671695"),

Guid.Parse("fe27b965-1b59-4860-81cf-56e9226110ac"),

Guid.Parse("ad8df189-958b-4972-b41f-20c10956000d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9ff16c87-f9b8-4f31-93b3-e36ec7288041"),

Guid.Parse("965bc17d-d2c7-45c7-b1e8-1ccf7af99d47"),

Guid.Parse("eaf6ed08-50ab-4c77-87e0-1391bdd63823"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6636fb6d-4545-475b-b4a4-55cf0bc594b8"),

Guid.Parse("34c033af-5611-438a-89e4-aa03c18feb69"),

Guid.Parse("4732c943-ef8e-41ef-b37d-5cd709745151"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5eade7ee-918c-4a31-8d8c-530c7f99b0e5"),

Guid.Parse("dd407a4a-a65a-49bf-b37c-717599fd582f"),

Guid.Parse("d866aba2-9604-4c93-9c88-bbed85a86c21"),

Guid.Parse("567e5075-b585-411c-8e49-0aa7f0af1c89"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a031d4a0-f4c3-487a-b33a-65dfee8e37b9"),

Guid.Parse("88842fce-a61d-4dd6-b9c9-4d80b6af551c"),

Guid.Parse("147f0ee1-ce88-4f76-a942-6e46a8b742f3"),

},
},
            new GuiduuidArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fe8bec2c-3fa2-4d45-8071-ba4ed02bbb48"),

Guid.Parse("9b762ce5-39fc-4c77-8813-d784e55691e8"),

Guid.Parse("5657a87e-44c8-4cca-b67f-0c36c32a7ca2"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("81208a1a-5475-4aba-a229-b3105e7f61f0"),

Guid.Parse("bf24b28a-141b-4bcb-a12e-163af7235ad4"),

Guid.Parse("f0c3cae5-ac76-4fc0-9574-786c506fb73e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2d8b82f5-adce-4fc4-89ff-6b36cc5d92ef"),

Guid.Parse("0551182f-c338-4275-be7f-3e48cc962f8d"),

Guid.Parse("950033d7-585f-4ba0-925b-b88a1955f526"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c645e494-5841-4d1c-b4e6-cc323b1585f3"),

Guid.Parse("0f83c4c0-af8c-46f1-9fcd-41aaeb6716e2"),

Guid.Parse("28e8d190-3021-4eec-91b1-bb3c7f27bc87"),

},
},
            new GuiduuidArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ec4df420-4d21-43df-95f5-5fc62ec9ffae"),

Guid.Parse("1244b650-eff4-46b0-8476-b41ab7210bd6"),

Guid.Parse("77437b35-8b92-4d73-8101-10639920dff6"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("49727601-9701-4b23-a8d6-a493aa99bde3"),

Guid.Parse("e6dfc017-f9ab-4744-aea3-b5f0fd463557"),

Guid.Parse("ba3c26ff-3742-4029-aa8b-6b05005ee899"),

},
},
            new GuiduuidArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("88dc85fd-4cd0-4616-b9d5-e9fc76ef31bb"),

Guid.Parse("466d94f2-806d-4e95-98b4-f88b7bae7c63"),

Guid.Parse("ccd04b0e-a509-477d-a11c-1d25a15c8982"),

Guid.Parse("2d6f0411-8da3-4855-ae45-3066358daf59"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("29c9a240-2003-4779-9727-b4ac169907ef"),

Guid.Parse("81b291b0-972d-4b58-a750-c4a951c4ca83"),

Guid.Parse("942f8bd7-cee6-4db5-8fce-aee269a95b86"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("82888d1d-8c03-427c-92f9-2fd573b59569"),

Guid.Parse("c920774c-182c-407b-96d8-0f9395792ad3"),

Guid.Parse("798cd659-eeec-421a-91ce-d378cf88c91e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2cd83ce9-fae0-4c5d-b8ac-f4f03e65027b"),

Guid.Parse("0226ab05-ce3d-4225-9be1-b956e2aef519"),

Guid.Parse("16eacf05-2560-48c3-b859-1c27f78669b4"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ffd6f3e2-842a-4c61-8041-1aa52f5742c6"),

Guid.Parse("37aeed17-afa1-4a76-b86c-fdf48abfd145"),

Guid.Parse("8292014a-262c-49a8-893d-82b0852137d5"),

Guid.Parse("da7fcb42-87a0-4f67-bac0-dd059859e6b2"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5cf636b7-91f5-4083-aa0e-de5e2f6c021c"),

Guid.Parse("693591a5-190b-434e-a8f3-8c025b2e4a1d"),

Guid.Parse("ea8c8f59-ade6-4461-ab84-f1305c115b4f"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("793bdb05-093a-4577-9074-6c91133ae8e1"),

Guid.Parse("53291cb1-28d4-4f46-8e9b-aae571b62aa2"),

Guid.Parse("c99a51b6-0479-45ea-b8c2-d93405fddecf"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("20c03d7c-a18d-4037-a287-ab10332f61e2"),

Guid.Parse("7d85b760-8faa-49d9-b96e-3820fdba68c5"),

Guid.Parse("3abddff2-346d-41de-9016-0a3a46a5010d"),

},
},
            new GuiduuidArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("38beab3d-e1c8-4447-b772-d36c271ec288"),

Guid.Parse("71756705-c2ac-4b29-9b51-e4085b184209"),

Guid.Parse("ac2c0a02-4b5a-4b19-8d45-799808201be3"),

Guid.Parse("e22e3f29-a85d-4dc5-8d89-59b428afca52"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("904e1ac2-527c-4936-9d4c-80ac91043d0b"),

Guid.Parse("fb1bc6e8-0756-43ec-9406-baa4f2df3861"),

Guid.Parse("6456b993-5f34-4a7f-b184-947652980b37"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0209d063-dfc4-4dba-830c-ab05394bb13f"),

Guid.Parse("242cca8f-ecf7-44c6-9fd5-f32c9a001368"),

Guid.Parse("62ee739c-17d8-42ee-bb99-0a217dc7e752"),

Guid.Parse("bfa7c724-c3a1-4a65-b841-45d8db6d2bdf"),

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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                        Assert.That(models, Has.Count.EqualTo(3));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                        Assert.That(models, Has.Count.EqualTo(28));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[2], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[3], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[4], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[5], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[6], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[7], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[8], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[21],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[22],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[23],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[24],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[25],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[26],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[29], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
GuiduuidArray2M.AssertModel(models[0],_testData[28], false);GuiduuidArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
GuiduuidArray2M.AssertModel(models[0],_testData[27], false);GuiduuidArray2M.AssertModel(models[1],_testData[28], false);GuiduuidArray2M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 63, query1, 92, query2))
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
                        Assert.That(models, Has.Count.EqualTo(7));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 16, query1, 57, query2))
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 28, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
GuiduuidArray2M.AssertModel(models[0],_testData[7], false);GuiduuidArray2M.AssertModel(models[1],_testData[8], false);GuiduuidArray2M.AssertModel(models[2],_testData[9], false);GuiduuidArray2M.AssertModel(models[3],_testData[10], false);GuiduuidArray2M.AssertModel(models[4],_testData[11], false);GuiduuidArray2M.AssertModel(models[5],_testData[12], false);GuiduuidArray2M.AssertModel(models[6],_testData[13], false);GuiduuidArray2M.AssertModel(models[7],_testData[14], false);GuiduuidArray2M.AssertModel(models[8],_testData[15], false);GuiduuidArray2M.AssertModel(models[9],_testData[16], false);GuiduuidArray2M.AssertModel(models[10],_testData[17], false);GuiduuidArray2M.AssertModel(models[11],_testData[18], false);GuiduuidArray2M.AssertModel(models[12],_testData[19], false);GuiduuidArray2M.AssertModel(models[13],_testData[20], false);GuiduuidArray2M.AssertModel(models[14],_testData[21], false);GuiduuidArray2M.AssertModel(models[15],_testData[22], false);GuiduuidArray2M.AssertModel(models[16],_testData[23], false);GuiduuidArray2M.AssertModel(models[17],_testData[24], false);GuiduuidArray2M.AssertModel(models[18],_testData[25], false);GuiduuidArray2M.AssertModel(models[19],_testData[26], false);GuiduuidArray2M.AssertModel(models[20],_testData[27], false);GuiduuidArray2M.AssertModel(models[21],_testData[28], false);GuiduuidArray2M.AssertModel(models[22],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSelectModelBatch(connection, 43, 92))
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 6);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
GuiduuidArray2M.AssertModel(models[0],_testData[6], false);GuiduuidArray2M.AssertModel(models[1],_testData[7], false);GuiduuidArray2M.AssertModel(models[2],_testData[8], false);GuiduuidArray2M.AssertModel(models[3],_testData[9], false);GuiduuidArray2M.AssertModel(models[4],_testData[10], false);GuiduuidArray2M.AssertModel(models[5],_testData[11], false);GuiduuidArray2M.AssertModel(models[6],_testData[12], false);GuiduuidArray2M.AssertModel(models[7],_testData[13], false);GuiduuidArray2M.AssertModel(models[8],_testData[14], false);GuiduuidArray2M.AssertModel(models[9],_testData[15], false);GuiduuidArray2M.AssertModel(models[10],_testData[16], false);GuiduuidArray2M.AssertModel(models[11],_testData[17], false);GuiduuidArray2M.AssertModel(models[12],_testData[18], false);GuiduuidArray2M.AssertModel(models[13],_testData[19], false);GuiduuidArray2M.AssertModel(models[14],_testData[20], false);GuiduuidArray2M.AssertModel(models[15],_testData[21], false);GuiduuidArray2M.AssertModel(models[16],_testData[22], false);GuiduuidArray2M.AssertModel(models[17],_testData[23], false);GuiduuidArray2M.AssertModel(models[18],_testData[24], false);GuiduuidArray2M.AssertModel(models[19],_testData[25], false);GuiduuidArray2M.AssertModel(models[20],_testData[26], false);GuiduuidArray2M.AssertModel(models[21],_testData[27], false);GuiduuidArray2M.AssertModel(models[22],_testData[28], false);GuiduuidArray2M.AssertModel(models[23],_testData[29], false);
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

