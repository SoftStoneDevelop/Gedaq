

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
    internal partial interface IGuidMArrayuuidMMArrayD2
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD2 : IGuidMArrayuuidMMArrayD2
    {


#region TestData

        private readonly GuiduuidMMArrayD2E1M[] _testData = new GuiduuidMMArrayD2E1M[]
        {
            new GuiduuidMMArrayD2E1M
{
    Id = 1,
    Value = 
new System.Guid[,] { { Guid.Parse("80df577d-457c-45a3-a8c4-9e9af2d9698b"), Guid.Parse("2eb8e6ff-8c05-4263-9405-c92e5e240d24"), }, { Guid.Parse("df321a27-5ff4-4afa-be74-bb229764f109"), Guid.Parse("a177bf1b-3807-4980-bd54-9747ded9b951"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("489b5e52-8f26-4f87-8cdd-57808e3af93d"), Guid.Parse("c89b0dc7-ebf1-4efa-9e3c-0b9729b065c3"), }, { Guid.Parse("a60ea792-62c5-4158-ac8b-68255c4bdfdf"), Guid.Parse("f8bcc298-a71b-43a3-a36a-56ed376d9b53"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Guid[,] { { Guid.Parse("dc7528b4-409a-44a7-be75-d93506dfaf7b"), Guid.Parse("377d608c-222f-41eb-8b86-6a85266277a9"), }, { Guid.Parse("77271b11-d09c-496f-9c8f-b92fbcffbd67"), Guid.Parse("2ba76622-dd65-49e9-b26b-5c233fdfd586"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Guid[,] { { Guid.Parse("5bfef3a5-5207-4aa6-b233-0f2d4fa7d8d0"), Guid.Parse("faed8a7a-307b-4170-85b0-7512ef56236e"), }, { Guid.Parse("ae616bd9-8000-40a8-b83e-03e5558fc6db"), Guid.Parse("d58f1868-c3dc-4fba-b291-af6668ab0f4e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("2158c32f-ff46-4ab4-8481-26e42e2b9143"), Guid.Parse("cd14495f-4aaa-4020-bc1c-70f1ffd941d2"), }, { Guid.Parse("84816a27-5747-44ad-adfd-d492e35f3e66"), Guid.Parse("efa32136-fd13-47c3-9525-e38f21c92b40"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b97d3c1b-d5a9-428a-8ecd-02f8dfdabfee"), Guid.Parse("b79964f9-ab9f-456f-b3e0-db2d36530d00"), }, { Guid.Parse("4c64e46d-40a1-4377-8085-ec197157ea6f"), Guid.Parse("25f8b7db-f701-4c95-8ae4-8e8bed5a3134"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 11,
    Value = 
new System.Guid[,] { { Guid.Parse("706a0606-489e-47a9-bb72-6251261bbb73"), Guid.Parse("b5aa65d4-d5aa-4ba2-b554-8ce06839e950"), }, { Guid.Parse("a6a238b0-2438-4519-a478-9cffecad646a"), Guid.Parse("debac6a0-aafe-4b0c-a5b3-ce6206bb1515"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("63e6bb47-694f-4d00-bdd4-890076c59b09"), Guid.Parse("1f5ba87a-bb9c-4c20-b5e6-2bf6e33c28f6"), }, { Guid.Parse("2d6a16fc-8581-4b00-b64a-f465985a8f3c"), Guid.Parse("b9fd0236-08ad-4863-a0b2-36da61eae9d3"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 18,
    Value = 
new System.Guid[,] { { Guid.Parse("67a00219-e1aa-40b0-9fe0-cb4847c97f7c"), Guid.Parse("fd479a07-176e-47ff-90f9-f155f4268602"), }, { Guid.Parse("85a17a7e-4943-48bd-addd-dac0e5028e16"), Guid.Parse("a0ce1183-ad35-4ec2-9209-7fd4700d897e"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Guid[,] { { Guid.Parse("72bdab98-4067-4c95-8dcd-fc7a1cd69710"), Guid.Parse("054b52c7-96c8-4def-8191-f3498e91f30a"), }, { Guid.Parse("1e2ad2a0-3032-400a-86a0-5bf86c1e5392"), Guid.Parse("118c11b6-6a6a-4a97-8d9f-d9c411839d71"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c544b4ab-97e4-4414-9efe-d0c3b09c1708"), Guid.Parse("37fa5e83-1751-46af-b9a5-f07d11f820f5"), }, { Guid.Parse("245c34c2-0ea4-4844-991e-286e813403dc"), Guid.Parse("d1541b57-c950-4b62-aba9-12c02c8a9dfc"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f1343340-eb61-4d7b-97b7-2fed022a9eb6"), Guid.Parse("43cd480d-cbd9-4b14-87b3-632f974afc61"), }, { Guid.Parse("950a5baf-ab7e-4699-a7b1-49f2bc9bd178"), Guid.Parse("fa46aae2-7f79-4ac9-b630-9364cf08282b"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Guid[,] { { Guid.Parse("1b4257e5-9249-4532-8afb-c81c46cfa1cb"), Guid.Parse("dbb8eeaa-7061-4aa2-bb62-f663957690f5"), }, { Guid.Parse("2da52ef9-c262-4b4a-80ef-9e75b4d60469"), Guid.Parse("61a0b567-4aa7-4bcf-aa02-174b5b43d90d"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Guid[,] { { Guid.Parse("464a840c-3c6c-4583-b8e8-077b2f1e1f1d"), Guid.Parse("8a45c89e-9efa-452b-838b-503e612d91fd"), }, { Guid.Parse("e2904a91-1dfa-475a-be3e-3c73b642b822"), Guid.Parse("b17b95c9-081d-477e-a847-6a8790e2f6fd"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("f0b4dc00-b48f-464d-bfe9-449385a34a0e"), Guid.Parse("e031586c-e07a-4533-9cdd-46da4bb0c54e"), }, { Guid.Parse("b02cefe6-28f4-495d-b4d7-2bed4e85913b"), Guid.Parse("4d549f86-ebf1-4741-836a-a6ea623453e8"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Guid[,] { { Guid.Parse("1cb2b744-6653-4fcd-8379-4536903ac36b"), Guid.Parse("33e204d5-0e4f-4b4b-a7a9-0d3125dad8ed"), }, { Guid.Parse("886484d7-8f4b-46f2-8e60-f22b7edcd697"), Guid.Parse("d479df49-28af-44e7-9caa-bc6338748e1a"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 42,
    Value = 
new System.Guid[,] { { Guid.Parse("c6bbf7a6-ec37-41d1-b20d-95201f4d931c"), Guid.Parse("e6d1da9b-e608-49cc-bac8-7ec6e23bd5bb"), }, { Guid.Parse("c854fa88-d603-444b-a262-d16f4dfc3fce"), Guid.Parse("48f0b763-1bfa-4111-b6ca-4fa475f32241"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Guid[,] { { Guid.Parse("a00b2331-6753-4a4b-a89b-370d61a74b44"), Guid.Parse("eee19e5c-b7cd-4027-b693-4b951702d1df"), }, { Guid.Parse("9bdccfdc-e237-43a6-9c73-8ea9101a5a6b"), Guid.Parse("d23c52ad-178f-41dc-8540-02205ad24a5b"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c7ee9edd-8583-415b-8fe6-0e9ce382386f"), Guid.Parse("7cb17eb4-0587-4103-a5b9-794908322562"), }, { Guid.Parse("7206e16d-7ff0-4b07-9b3b-d696a16a7755"), Guid.Parse("ecdd78b6-ec05-4b0d-b09e-4376a845484c"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Guid[,] { { Guid.Parse("fedeb7e9-5f57-41d7-95a5-6f082cb91ed6"), Guid.Parse("2c1edaed-ff87-43a6-ae96-b805fcf460b4"), }, { Guid.Parse("c63dfdbd-d27e-4b80-97f9-ae1dc4f1cace"), Guid.Parse("854b5eeb-0777-4d94-b9da-9701d71fbecd"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f40e118f-50e0-4428-a91f-db9578d6891f"), Guid.Parse("7759fceb-9c3b-4e31-aefa-f9f99707cf1a"), }, { Guid.Parse("6137e4dc-e114-4eeb-aa0f-5133c322fa70"), Guid.Parse("bc27551d-ef9c-4033-9eae-5c459d968ee6"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Guid[,] { { Guid.Parse("e5561822-a6a1-4fd4-bcd8-261afab6871d"), Guid.Parse("7f42f32e-f172-4595-a760-7a1e1b6fbe7e"), }, { Guid.Parse("23e12711-72f9-45ad-8cad-1beda5a35323"), Guid.Parse("7adfb7dd-7124-4b14-9cb0-648d4e4327d8"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Guid[,] { { Guid.Parse("350add1e-e419-43e5-8529-00ee5918a1ac"), Guid.Parse("e6db20ab-cc9d-4e18-9582-630d363a7475"), }, { Guid.Parse("079ecb1a-1815-4411-aa49-5c50e665aa20"), Guid.Parse("e0c6ca28-77c3-4b63-ba45-608f672971a3"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Guid[,] { { Guid.Parse("f893587c-14af-4bc2-8332-422f3f473b37"), Guid.Parse("0956cc5b-25cf-4ca3-9725-6dd34b493069"), }, { Guid.Parse("1d2cdee7-3e65-4b81-be0a-ed490ad31512"), Guid.Parse("0c9afd20-5c5d-4276-aea7-b41b6b8113c4"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Guid[,] { { Guid.Parse("0b4c2506-a9a5-43b9-9495-bd3f27c16d2f"), Guid.Parse("e5d420fd-6031-4a98-89b0-174fed43d444"), }, { Guid.Parse("2b9b01e7-4eb9-46e8-914d-d244f634b0cf"), Guid.Parse("fdc4b9c6-9eba-4a90-9672-a595661bb9db"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Guid[,] { { Guid.Parse("fce647c1-bf45-440d-9cc5-6c2e7e510a69"), Guid.Parse("9a58fa30-7f89-41aa-8e30-0d8a6932d345"), }, { Guid.Parse("ec839841-b165-45f4-876b-728a6b92bcd9"), Guid.Parse("be80ced5-bb03-4609-a32a-ab645435e79f"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("360b84e2-b2be-4861-b6b9-e3aec2b8c157"), Guid.Parse("81e9bc88-dc1a-4ed4-922d-150c503eb975"), }, { Guid.Parse("4c101dde-e731-4548-8dd8-dfae1cc2bd1e"), Guid.Parse("63ab0b42-03ae-448e-befb-26dbd3f47d44"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c67e1faf-f5e0-4da7-8daf-07329e3fd88d"), Guid.Parse("a2c6aa25-3c7d-4fcd-9902-7d969538c94c"), }, { Guid.Parse("4a95b807-aba8-4806-ac9c-82cecdb6a765"), Guid.Parse("026b3d0a-1e32-4f73-9ad6-32ef959a3b12"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Guid[,] { { Guid.Parse("1ab2c72f-3350-4969-8972-719cd8d8ef51"), Guid.Parse("ceaa25bc-fecf-45bd-9a4d-e589e9202654"), }, { Guid.Parse("8fb4db9a-8164-4f69-9e56-87a3bc622e2c"), Guid.Parse("1d95e7e0-2a0b-4acc-a13f-552a24abfc48"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Guid[,] { { Guid.Parse("aa63283f-fffd-4419-baf4-5f12a80eec64"), Guid.Parse("0d244619-e0b9-4e5b-a428-ab4340bfd12b"), }, { Guid.Parse("ec60d268-611c-49e0-a8c2-85f545c04e3c"), Guid.Parse("fdc0cd5f-b492-4d51-987b-460d4574b5a0"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Guid[,] { { Guid.Parse("6f48f51b-4cd3-4423-87f5-a564293db411"), Guid.Parse("463b5acc-a0c0-44fa-b18d-3b3894a94fb1"), }, { Guid.Parse("06680f86-c1d6-4157-9cf3-afe35e3f5d78"), Guid.Parse("7b45be49-b826-4bd1-aafd-cc4cc2a74848"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c33cea5b-130b-4d20-85ba-5554dbb7da31"), Guid.Parse("eabc3af6-9425-419c-a3fe-0639dc190d51"), }, { Guid.Parse("892b36e4-beef-4198-b3ed-cf373a6b6c12"), Guid.Parse("acfaf327-3ee9-4ad9-9f59-308632c798bc"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 75,
    Value = 
new System.Guid[,] { { Guid.Parse("83edb996-6039-4551-95b2-6c6964407d96"), Guid.Parse("2612b1a1-7918-437a-aa46-15a86dfe4736"), }, { Guid.Parse("2ac8ae4e-b776-4a74-b106-1168fa03d30b"), Guid.Parse("99d73f2d-15e0-4ff2-a55d-9b2e81de0958"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Guid[,] { { Guid.Parse("c9bdabed-3852-4b8a-a3a6-a8c9151e77e6"), Guid.Parse("5a0cf38a-8b8f-45f6-8167-62fbf504e924"), }, { Guid.Parse("06398035-2ba2-4e67-8191-2b8406445d71"), Guid.Parse("28c425d7-1ea4-4b21-b8d4-29b5b8604cd0"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Guid[,] { { Guid.Parse("8419d1c2-f0fd-4ef3-8c3b-aed73d6dbae3"), Guid.Parse("3b1a5486-4214-475c-b0f9-f515d57ca668"), }, { Guid.Parse("a6d1e53b-2832-4524-b7a3-8483827c4229"), Guid.Parse("99d5eb31-47a6-4e27-9bc3-324e24478fbf"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f337bec7-24fb-466a-8c12-7caf3d179977"), Guid.Parse("c30c56ad-2641-4190-88c7-d53b96ffc5ea"), }, { Guid.Parse("0e2e9bad-10a1-4d16-b9ca-271b461a8205"), Guid.Parse("f4b832b1-979e-47c6-ae42-3fb9981f322d"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("0262ece1-b426-4706-b2c1-7e7ac0332b21"), Guid.Parse("5092e259-5320-4265-b04f-9759c81f68ee"), }, { Guid.Parse("4d56ea6a-5b8f-4b99-a61a-25bc67cc305b"), Guid.Parse("a9225b16-7ee0-4909-b740-5aee48c528f4"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Guid[,] { { Guid.Parse("231bd88c-da1a-4a4c-a1a9-75c42ba1d6d0"), Guid.Parse("37b92287-25f1-46ce-b289-1a8513d8026a"), }, { Guid.Parse("92e0f63c-4139-41aa-a15a-a33d380d0f3a"), Guid.Parse("62118e9e-f072-430a-b1ba-16e398808dd1"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Guid[,] { { Guid.Parse("d1205735-3235-4e46-bf2b-ced6cad154fb"), Guid.Parse("be93e562-2715-422f-b73a-4d6acb8332c6"), }, { Guid.Parse("feb51c73-e31b-4816-8cbf-add8b52915a5"), Guid.Parse("644402a0-b013-47f8-ad17-e84fb7678485"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1ca0d9c0-5f74-4ede-802a-0e11fea0a226"), Guid.Parse("c9b23711-8e8b-470d-8116-b6bbf639fb68"), }, { Guid.Parse("f260d6ab-b969-4b3d-af86-3dbd5caccca7"), Guid.Parse("f24e7cf9-fe71-419d-90a6-74c5f565d4c0"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 89,
    Value = 
new System.Guid[,] { { Guid.Parse("af26edb6-ccdf-4d9f-b86e-d021ef7b1a75"), Guid.Parse("36435954-3c00-4dd6-bbb0-78d2d792dbbc"), }, { Guid.Parse("9999e988-f5d5-499d-bbe1-736949c31620"), Guid.Parse("07068594-125a-4c25-8559-909c6c8cfc55"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("9c49bc4d-8ae8-4ec0-9583-e0977ef14175"), Guid.Parse("b12e24ab-c1c9-4b78-9cc0-bad70385d3b0"), }, { Guid.Parse("eb30d786-975a-43cf-ab90-54fa26892288"), Guid.Parse("10cd81f6-710c-49fd-a280-012ec1eea4be"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Guid[,] { { Guid.Parse("2f0b1364-58dc-41f9-b6c9-2625fdf7948d"), Guid.Parse("aa87a2ca-a87a-4328-936c-cb19ff7a7727"), }, { Guid.Parse("2baef0d9-c82b-45be-a6ee-c3ea924e3dd9"), Guid.Parse("fd7b486e-aa4a-47de-a281-4df8f75883ed"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Guid[,] { { Guid.Parse("2e3b23c7-33a6-42fc-8d58-0d2b58d6abcd"), Guid.Parse("937f5cd5-68fe-4099-875b-5e3dd6e13b65"), }, { Guid.Parse("14759ee8-e9fb-4816-9822-3c98f07bbbb1"), Guid.Parse("b00ff096-a09e-4b64-9f37-3f57eede50ce"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Guid[,] { { Guid.Parse("fe774e10-984e-4e42-91e3-2993c5a271f8"), Guid.Parse("1bdf9741-f703-45de-b466-e265c17ab84a"), }, { Guid.Parse("638cee35-adb7-4322-8e9d-c2b91c4c8d64"), Guid.Parse("3807e906-1b70-43ef-be31-4afe79ab5b97"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Guid[,] { { Guid.Parse("93c90ea5-95e2-4a11-a3d0-4d48b1b38d9b"), Guid.Parse("5c270e26-a360-4dc9-83f6-92f4f02103bc"), }, { Guid.Parse("530e1e8f-a45e-45aa-b744-0ca11e0e791c"), Guid.Parse("3da73272-218e-448c-a504-19861a1d70b8"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Guid[,] { { Guid.Parse("f4c01d78-fbfc-4d59-9e23-57f412fb1549"), Guid.Parse("d2e2a04f-36f5-4691-a413-f627cd145f21"), }, { Guid.Parse("d91cb9e4-745a-48f9-b15b-90be01ac0fcd"), Guid.Parse("53a684cd-b518-41e4-bed9-d7c6b6fd3402"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ad953527-c263-4f81-b0e4-7b0a0a281b7b"), Guid.Parse("17872528-8151-40a3-b54b-32d8e31f950c"), }, { Guid.Parse("9576bd8c-0ff7-4fe9-a7e9-dca7012d340e"), Guid.Parse("ee51238a-eee4-4160-b731-86fde272d27d"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1a620cea-7c8f-4682-ad10-c1bbeda4c422"), Guid.Parse("a7062bac-bed3-4000-bcc8-4eb030db659b"), }, { Guid.Parse("1dd2c3fd-11da-4658-8fab-ad0e6e754377"), Guid.Parse("85f1d31b-3aed-4f61-b5a9-5a42b20999b0"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Guid[,] { { Guid.Parse("97f31b6b-8819-4d3a-8577-3e85e831e6ae"), Guid.Parse("532888f1-9006-45d5-a9ae-65ec0c7f8dc0"), }, { Guid.Parse("03bea096-8881-4e8f-a3c8-21bb2e2d91b3"), Guid.Parse("c5b7b72b-8fa1-44cb-a988-bf0a08b63ff5"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Guid[,] { { Guid.Parse("535cc765-c1f9-43e1-8d7f-3bbb753c4bea"), Guid.Parse("31e7a052-a243-45f1-9864-ea9348d929d3"), }, { Guid.Parse("c811357d-ad79-4bbd-b010-e3329ea47dc6"), Guid.Parse("5b73ca09-fd0c-4e6a-8014-e166d39db5ce"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Guid[,] { { Guid.Parse("cd19b86c-5fd9-4247-94fb-6927e40d96e9"), Guid.Parse("5c054197-90b7-479c-9d56-696ba7c232cf"), }, { Guid.Parse("e59c07c1-2abd-45fd-bdf6-8ff2cea3d44a"), Guid.Parse("9df8b6c6-29e5-496c-971f-0f4f1d8f38af"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8c7147e1-eb23-4a1f-8690-587f71fdf061"), Guid.Parse("4de7a27d-e8c3-44f6-b5c8-0aa0ab2221d7"), }, { Guid.Parse("9c59e6a2-f1ee-4941-8b11-c226d4323a00"), Guid.Parse("7944b79d-281d-49a1-87f0-7fbd2b8de691"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("06568adf-29b8-4433-b4f1-26cdcac70b87"), Guid.Parse("2acd5372-45ef-409c-afb9-39dae2b0d817"), }, { Guid.Parse("7bad916d-ba84-4c68-9f77-25c626dc606e"), Guid.Parse("09346252-3145-41bd-b354-0906c94c6e0c"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Guid[,] { { Guid.Parse("6420b4b9-d51a-4a51-a1e4-96897958f077"), Guid.Parse("d45d9637-b046-4f33-b901-067cc77d8995"), }, { Guid.Parse("464e5640-4490-4cd2-a336-4aa348ddcd39"), Guid.Parse("75c8c9fc-c4db-4fbd-94f2-be05a43b4c80"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ca158b08-ca81-4555-8d5e-ba70b6afe47e"), Guid.Parse("0f8689cd-5865-419d-b710-0c9c18cd68e9"), }, { Guid.Parse("16a2363c-3c71-47ca-b0c1-4a801fce2ffb"), Guid.Parse("f3211353-4434-4429-a1b9-c4edab96aab4"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Guid[,] { { Guid.Parse("6cd68b28-27b8-45e2-8d86-2c09e882e5b0"), Guid.Parse("678855ce-d196-4be5-90a0-92e2a2111c94"), }, { Guid.Parse("e62105b4-4b30-4eac-a1bc-0a540358f894"), Guid.Parse("2087eedc-2608-423f-b261-35011e39d4d4"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Guid[,] { { Guid.Parse("b9e1ce33-eeae-4cea-98fc-1c635c7567cf"), Guid.Parse("12c7c0b4-4a41-4a4e-b54e-f0651399d5dc"), }, { Guid.Parse("1539be17-fbbe-4faf-b5d9-a4ad433e23cc"), Guid.Parse("6c946f9e-2414-4c63-ae82-300c1a0e7b11"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("da5dd00d-b697-4f8e-b319-9eaaeff63102"), Guid.Parse("b302a761-6c5c-4945-a504-6e968b7ecf3a"), }, { Guid.Parse("f0279771-746a-41a7-bc40-3c57a4677ea4"), Guid.Parse("ad366049-dc59-46a7-8784-2c1aab02b536"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("60b4fa9f-094b-4733-8bcd-f1d915308251"), Guid.Parse("e9b0543f-c166-464d-9a1e-5d49797c44d4"), }, { Guid.Parse("12a91b43-045a-4899-8380-e16bdcc5026d"), Guid.Parse("0799d60e-613b-48d3-9bd1-41ca7351c1db"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Guid[,] { { Guid.Parse("fc959cf9-b62b-40ac-a9d0-b2cc8f85fc6b"), Guid.Parse("5c8fd67a-945e-437b-8175-79a222d4ea0d"), }, { Guid.Parse("6347d6ed-fa18-47e8-8b19-66c4fa701a3e"), Guid.Parse("48820493-e452-4193-aef6-be2a82d4668f"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 139,
    Value = 
new System.Guid[,] { { Guid.Parse("3b33fbcb-5355-47dd-b874-31820a7756e1"), Guid.Parse("cbac78b7-f1ea-4ade-99bc-9ce81c26f541"), }, { Guid.Parse("f6d59572-76ad-4c20-88ac-57eeb262a5e1"), Guid.Parse("6741bc98-8453-4477-9592-b59d410221d1"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Guid[,] { { Guid.Parse("05dc27dc-0917-4eab-981b-7a91eb4ecf89"), Guid.Parse("5f9ce745-723f-417b-b2b9-68ccfc60356e"), }, { Guid.Parse("d1ea37e8-7f83-4651-8122-64f4590fa7bb"), Guid.Parse("68a97ca0-8f06-4179-9553-533838e900bb"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("bfa4913c-7ba8-48b4-add8-410ef90be74b"), Guid.Parse("5bbd69b2-3fd6-4cbf-a904-114c7fa78e37"), }, { Guid.Parse("894af484-3a8c-4481-9125-2132dd82fefc"), Guid.Parse("dbce264f-4516-4d23-81f4-b56423e671fb"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0e9b965c-3a53-49b1-8017-ebb77370e4db"), Guid.Parse("1f2aab07-3331-4c99-9e6e-666e24e50484"), }, { Guid.Parse("a1a37ff3-546c-4bb9-894e-3fbe34c02f31"), Guid.Parse("fc911424-663f-4422-a6d4-fd4ecd361eb3"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Guid[,] { { Guid.Parse("dc163bc5-a004-4e06-a85f-ca4258e471a2"), Guid.Parse("f2e7309c-feac-4b22-a1b9-478276a0f8b4"), }, { Guid.Parse("e0a880ef-de7f-424a-8c4e-57b7f8792051"), Guid.Parse("cf39e332-852f-4765-90d7-dd6be642bd56"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Guid[,] { { Guid.Parse("75c9ec20-087f-4d15-bc72-5c98be5d9c12"), Guid.Parse("940c0cb5-96f6-4911-b775-1232fee6f0b4"), }, { Guid.Parse("6c4b3101-76c9-4bed-82ab-f02e7dc8bdbd"), Guid.Parse("289c22e9-e571-45ad-82f7-762c97e5d3cb"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Guid[,] { { Guid.Parse("6b6d7bbd-4223-4112-96db-1c69ba55261a"), Guid.Parse("2cbe6f87-63a9-41d9-a782-67a4a93e55ad"), }, { Guid.Parse("baf4f25a-6e8a-4d12-bbf8-99748f3de125"), Guid.Parse("f0946edd-c4f2-4209-b4fa-7883ec9b3ab8"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("dbc26c9b-4703-4177-8f57-c0682ae55109"), Guid.Parse("61441e21-a2ad-4fce-9c1d-41c75e3e7aed"), }, { Guid.Parse("aa78c0ff-1327-43f2-8c70-fd0fea48937b"), Guid.Parse("3279c072-5270-47a0-9da8-8512d1b69b0e"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7bdb7eef-9bdd-414b-8e0d-42b8f2e2483a"), Guid.Parse("98690a00-21e4-48fd-8bfb-7503ea38e70b"), }, { Guid.Parse("9792efd2-a2af-4c60-90e3-805d3edb3e7d"), Guid.Parse("3c44807c-72c7-460e-a3f1-5f8219b40303"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Guid[,] { { Guid.Parse("f5ea1e4e-8332-4dc1-a05c-ea3809019c2b"), Guid.Parse("a8b60480-5b24-4ede-a76a-35b5d551c261"), }, { Guid.Parse("654a1903-074a-4d6f-935b-eb9511399afc"), Guid.Parse("6f11d1e9-3134-40c8-ab05-47208ff9693b"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("794fb540-dfbe-47db-bfb3-145d7664ba23"), Guid.Parse("454e29a2-7a68-4238-8348-ea94c89cb12c"), }, { Guid.Parse("0164a2be-c9f3-4191-94c5-cf27d0dd871b"), Guid.Parse("f97821dd-b432-41d2-aea8-f124b0a434a6"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Guid[,] { { Guid.Parse("252c4f3f-93fc-48ea-bbbf-6d70673b4c8d"), Guid.Parse("28f523c1-f6d6-4ba7-85d4-5fd17d69b758"), }, { Guid.Parse("f2bf740e-9ca3-4ef3-99ea-641d7e338126"), Guid.Parse("3fdddd1e-4f56-4d41-97c2-15e6fd697cab"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Guid[,] { { Guid.Parse("d1b9a602-17eb-43cf-967e-b886911858fe"), Guid.Parse("478e8d37-ecfb-4d61-9c4c-d03f20344423"), }, { Guid.Parse("81ac71bc-e87a-4761-8400-0fc82168aa08"), Guid.Parse("944bc2af-ec03-4806-9dcb-17a6b60befa1"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("298fd879-740b-4f0f-94c1-bae383a5048a"), Guid.Parse("2c0ef40a-ff2d-40c0-8f83-7baf711634ae"), }, { Guid.Parse("31322e4e-be31-41ab-8421-52c22a007b10"), Guid.Parse("78a62fae-89e0-441c-8110-dcac4fc4607b"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b455a5a1-2e03-4e16-ab71-7b616b8e6364"), Guid.Parse("eb362aeb-de3a-4339-a801-c3c6deb69817"), }, { Guid.Parse("a07ecc2c-8f4f-4e64-9b8f-54f2d81f36f4"), Guid.Parse("19afca60-49cb-49a4-b551-564ee829c1b7"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Guid[,] { { Guid.Parse("fdea9049-1211-46de-ae26-b76199099d65"), Guid.Parse("4df77f0b-426a-4fc5-963c-379c8617bfde"), }, { Guid.Parse("d4ce91af-17ae-4b46-ab85-76d4e487a2cc"), Guid.Parse("aefb0c98-9aa1-46a9-a528-bd71ef25904f"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("04b7fdec-738e-4be9-aeec-036bb25d8d13"), Guid.Parse("1f784827-d038-49f7-aeac-bc6872be3e98"), }, { Guid.Parse("480dee55-a458-4fd9-ae64-1fd8c0f2c148"), Guid.Parse("c90cc17b-9872-4618-9ad6-981ae881a78e"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Guid[,] { { Guid.Parse("ad866a84-4abf-44fb-80b8-21a451bd34b3"), Guid.Parse("5b015ad8-d6b5-4cc1-b4be-a6d876306163"), }, { Guid.Parse("cd082183-f140-42dd-a6f5-fa153c971d4a"), Guid.Parse("305179ff-a9bc-463a-8297-44ae514dd0f4"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 98,
    Value = 
new System.Guid[,] { { Guid.Parse("52951f39-e6d4-4f54-867c-4501b0418536"), Guid.Parse("4839f951-5e11-4753-8e33-7b7a6cf351d5"), }, { Guid.Parse("f5bb91cc-1c21-4a86-8ce4-ea7da0245891"), Guid.Parse("41f69249-30d9-43bc-b9e6-7a2474f02bb6"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b429b2ae-476b-4d6a-b9e3-d7f4b157c514"), Guid.Parse("4932b28e-ac27-44bb-abc4-13ae93a4716f"), }, { Guid.Parse("8b81b6a1-348a-4a6f-837b-396234146c58"), Guid.Parse("4e4b79e8-e7dd-48c1-886f-7eeaf97395aa"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("724afeaa-a6bb-4a8a-8a27-68f93703da7c"), Guid.Parse("2197cb52-fd58-41c8-8c7d-0c1dea5e5a3d"), }, { Guid.Parse("fbc0c6be-3146-4173-babd-2831d5c3e9b0"), Guid.Parse("4a7b3857-1a5e-4287-9016-47f9d9b3aee8"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Guid[,] { { Guid.Parse("1a677dcd-6199-42aa-bd17-a9b31534da99"), Guid.Parse("557315c5-9323-48ae-962d-71c1995daa94"), }, { Guid.Parse("b4a1451d-1869-4e9b-8a38-dfcdb0264377"), Guid.Parse("24b4b601-16c0-40fd-9543-674f21cb9af8"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b3b19707-8b23-496e-b77f-625b13736c93"), Guid.Parse("d29a9518-6422-46fa-aca0-6dda5e3a1de4"), }, { Guid.Parse("47304347-6ce3-44c0-a44c-7b33b35fa4da"), Guid.Parse("e67a107d-53de-4ead-a124-ca3ccebe7d9d"), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
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

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
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
                System.Guid[,] nullable = null;
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("f40e118f-50e0-4428-a91f-db9578d6891f"), Guid.Parse("7759fceb-9c3b-4e31-aefa-f9f99707cf1a"), }, { Guid.Parse("6137e4dc-e114-4eeb-aa0f-5133c322fa70"), Guid.Parse("bc27551d-ef9c-4033-9eae-5c459d968ee6"), }, }));
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("c67e1faf-f5e0-4da7-8daf-07329e3fd88d"), Guid.Parse("a2c6aa25-3c7d-4fcd-9902-7d969538c94c"), }, { Guid.Parse("4a95b807-aba8-4806-ac9c-82cecdb6a765"), Guid.Parse("026b3d0a-1e32-4f73-9ad6-32ef959a3b12"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD2E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD2E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 56;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 159, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 152, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 11, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 11, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 9, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 157, query1, 157, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 49, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 25, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 148, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMMArrayD2E1M),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
FROM public.binary_guiduuidmmarrayd2e1m m
LEFT JOIN public.binary_guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI), typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

