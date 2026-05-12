

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
    internal partial interface IGuidMArrayMArrayD2
    {
    }
    
    internal partial class GuidMArrayMArrayD2 : IGuidMArrayMArrayD2
    {


#region TestData

        private readonly GuidMArrayD2E1M[] _testData = new GuidMArrayD2E1M[]
        {
            new GuidMArrayD2E1M
{
    Id = 1,
    Value = 
new System.Guid[,] { { Guid.Parse("76b9a566-e6fc-441f-89e1-2e257b13e479"), Guid.Parse("2d889999-1766-4ab3-be35-45f864775eb3"), }, { Guid.Parse("14bb1014-1810-479f-947e-1c9f6e75800b"), Guid.Parse("cc794e4f-6993-4e04-907b-5cdb4cb09158"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("b9bec9bb-6219-472d-b639-0afb845ddb4c"), Guid.Parse("2fdfb47b-023c-4bee-b99e-9b3682a84352"), }, { Guid.Parse("ef67355b-aaca-436c-a19e-e937b57dbbd6"), Guid.Parse("456fc69e-8bf6-49c1-89f9-da93e2a85f31"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f369fe1a-b966-43fd-8f80-1ca24cdc69ea"), Guid.Parse("c751e811-8067-4abe-a111-1a47747066ab"), }, { Guid.Parse("bb70c604-4c81-43da-9d7a-6424fda6a44d"), Guid.Parse("3b088ecc-f3ce-4bd4-bf7a-39853feb2737"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("99fcf552-0337-45be-9cd3-b86e2d882740"), Guid.Parse("c54d5c44-d49c-40e1-9bda-f4eb014d5f82"), }, { Guid.Parse("71df4e1b-42e2-4435-a7e7-c63d13cf6bd0"), Guid.Parse("e0022bb7-3f39-478a-94d8-4be9cf22bab4"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Guid[,] { { Guid.Parse("e7cc3c56-c8ab-4fb1-9e5f-deef00135b4a"), Guid.Parse("1bda7a2a-348c-419b-bfc6-b12b5080d8b2"), }, { Guid.Parse("aa89f190-301f-4d8a-b96d-9ec8ce565b77"), Guid.Parse("d20bdaba-9518-4d50-b1a1-b783cc74f01e"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e05d99ed-5195-40cf-b6ba-5c264fd70332"), Guid.Parse("4f2c5ef9-9810-4f0b-81fa-5da53c24ebc2"), }, { Guid.Parse("ed27acae-be23-4717-8615-318c01226dd7"), Guid.Parse("d4415f55-f3f2-42a9-a15b-a07b80225fba"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Guid[,] { { Guid.Parse("04ae9b02-a602-473a-813c-0608c27a5ca3"), Guid.Parse("832e42a3-adfd-4aea-aa8a-291922faf436"), }, { Guid.Parse("ca614af0-4377-40ea-9055-e8fc7d13c270"), Guid.Parse("0b297e7e-dbb6-4a5c-b48f-bc5f8a46da59"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Guid[,] { { Guid.Parse("c02ee371-5179-4649-9b99-1220919ec0ea"), Guid.Parse("0484c7f3-3e3c-43e0-9125-ce93ccc0fc58"), }, { Guid.Parse("ccda25c2-4272-42a4-89fb-fcebb709e03e"), Guid.Parse("b5f5ba42-41ab-4634-a84e-03d04eb46095"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ec280d59-942b-4f2c-939c-d0df25941b01"), Guid.Parse("65a46c98-3748-4588-bf03-8afbff5a6e2f"), }, { Guid.Parse("295ae055-5d5e-4ef1-90af-10ec73b6cdc8"), Guid.Parse("9286eeb1-3a06-40dd-9381-7da9bb26029e"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Guid[,] { { Guid.Parse("bc659679-cea5-444d-ad43-e067dad86445"), Guid.Parse("4a4d4c07-9617-4a01-8dce-f96a1db62d5d"), }, { Guid.Parse("cf156058-f9f8-4168-8a33-92cb280fbc99"), Guid.Parse("a74ac4b4-50bc-4886-ab21-bffe228a7ede"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Guid[,] { { Guid.Parse("d1cdb762-7ef3-4319-aeae-36a9c7a83369"), Guid.Parse("074d40ee-fc65-426d-a78f-c141d901aab2"), }, { Guid.Parse("e0887212-afc9-434e-96ab-891109a7b5df"), Guid.Parse("846b36db-510c-4777-9a00-2dd7ab74e508"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Guid[,] { { Guid.Parse("39589522-2a8f-47e0-955b-a740f32bbf7e"), Guid.Parse("a1b07249-ab0d-47e4-b384-8e900f04a026"), }, { Guid.Parse("b17a124d-b499-4c3a-99f9-ebc189d0f2aa"), Guid.Parse("63461c99-fe45-461d-91b5-f278c414857e"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Guid[,] { { Guid.Parse("806758f8-8c5c-4192-8c3a-009b4f4f887c"), Guid.Parse("04f60c98-c9bc-4f3f-8c89-1d87abc2cb22"), }, { Guid.Parse("18a49630-e38e-41eb-8aa8-85c9589d636a"), Guid.Parse("9a989470-bf16-468e-8420-3fe0d09d213a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0a36be39-32fc-42a3-9a4c-fe8c38a95ba2"), Guid.Parse("2949204d-b5e9-4289-b10b-68dd7f81ab62"), }, { Guid.Parse("3de9ab52-6ba9-4943-a236-15f9bbe87113"), Guid.Parse("04cbfc89-aaf3-459b-922e-f6c89c07aa70"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("20a56c5f-069c-42a5-b4b3-6930aab95976"), Guid.Parse("45ad111c-2bda-410f-94a6-bd1b4963015e"), }, { Guid.Parse("2f0af0dc-ac8a-4497-a3f8-4f5d838737d1"), Guid.Parse("f47faa40-8379-4e55-b001-30b76c0644ef"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Guid[,] { { Guid.Parse("71dd45c9-9a39-4767-8a7e-150a51d11107"), Guid.Parse("b070004e-b6df-4f31-9133-3f7ca50b6cd9"), }, { Guid.Parse("23493aee-91b5-4331-bfd8-35e6452eb4ca"), Guid.Parse("345b228c-ef8b-43ca-b347-b5decbff0c2c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Guid[,] { { Guid.Parse("5ffaf6b6-363d-4338-83c6-63c647b0ac53"), Guid.Parse("bc7e5ac2-ca58-4c44-b5e4-848a16e8d696"), }, { Guid.Parse("2714e7ac-15b0-4e25-a914-5acb7ed4ba42"), Guid.Parse("85049cd1-498a-4af2-b014-903fa6e46ca1"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("62fd0a43-f88c-4a85-8d17-a17ece906b9c"), Guid.Parse("2376fe4c-203a-47d0-a219-bb30770f803b"), }, { Guid.Parse("8a52ef13-d536-4720-8604-ab7ef531900a"), Guid.Parse("f3290a04-b588-418a-8144-1fa588846f5d"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5a63810f-5142-4b26-b0ef-4a66a641dbe0"), Guid.Parse("9011adeb-00f8-46be-8532-c7226dfbe4a8"), }, { Guid.Parse("3c9e23d4-c58c-43d7-a2b6-eb7f52499f75"), Guid.Parse("017f158c-683d-40a4-89de-31d8d17c3749"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Guid[,] { { Guid.Parse("fd80552c-aa95-4df1-a7ea-e1ba602b77af"), Guid.Parse("60216da2-c8a4-479d-b3d3-028c41d3df2e"), }, { Guid.Parse("29176853-1088-42ad-83cd-6267cf9f975f"), Guid.Parse("5d0a69ec-9a02-49a8-bed8-33d0db06eb9f"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Guid[,] { { Guid.Parse("faa190c6-652c-4c77-a430-d28066c62161"), Guid.Parse("99d75522-9e23-4738-af78-19bd6cc80e08"), }, { Guid.Parse("6d452a1d-4c7a-449b-bb87-d9c6fdde76b5"), Guid.Parse("f493191b-2ee2-4601-b1b0-273e7926200c"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Guid[,] { { Guid.Parse("af553140-3026-402d-9a46-48dbcf2326dc"), Guid.Parse("8037b2f3-062e-4573-b599-37ebea6c8754"), }, { Guid.Parse("039a593a-0db8-4f3e-99ca-b2bf145df32e"), Guid.Parse("9d6daaf7-08cb-4092-81cb-56bd4cf146cd"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Guid[,] { { Guid.Parse("3bad3232-406a-4f59-a581-769823b0d860"), Guid.Parse("f08d43cc-7a9b-4615-9ac2-82dfa0970b62"), }, { Guid.Parse("4fcc0d88-89a6-4f9b-8a50-aea7521b7a6f"), Guid.Parse("fa36145c-ec6d-4eea-b66a-0fe4809c1933"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("39508f53-53c6-4e83-9479-c3a23580bce5"), Guid.Parse("e458a04d-c63e-4f90-8e97-79d5525ec5c5"), }, { Guid.Parse("23a50eb3-e018-46ca-9c3b-71b692db931c"), Guid.Parse("d8eb7a7e-54cb-48f4-bf78-8b537ee45806"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1cd70ebd-9eae-4acc-85db-859081bb7cd3"), Guid.Parse("85dcf125-62cb-4cec-bb99-5aff001ad2ed"), }, { Guid.Parse("f3cf6b62-66c7-4a63-bc20-f22a727ad923"), Guid.Parse("dcaba149-1472-4131-b271-db1be550199d"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Guid[,] { { Guid.Parse("b3fb7d08-34e7-4d29-b66a-2b9ed31ecba6"), Guid.Parse("a6ee6129-c7d7-44e4-bf95-2a10c4cdd1c2"), }, { Guid.Parse("549b0be2-9785-4a7f-b70b-b7a5f655b9f4"), Guid.Parse("697b6105-1de1-42dc-b20c-6c8a363ce748"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Guid[,] { { Guid.Parse("a87d6000-6286-460b-a728-442e1891069b"), Guid.Parse("37d8421e-d078-4edd-8898-d3f286adb750"), }, { Guid.Parse("47589a2f-f38e-4519-93fb-edf4a6ea6f2c"), Guid.Parse("a203e0fc-d19f-4c0c-aa5b-c12f63b963f8"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("944c0639-3eec-4995-8b31-8dd38514e711"), Guid.Parse("9be118db-d45b-420a-b988-39398b729cbc"), }, { Guid.Parse("d60ca456-47fd-478b-89bc-cb0a407e1328"), Guid.Parse("a1ed89f6-13ef-4620-b269-4de1d5fa4ef5"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Guid[,] { { Guid.Parse("cbc687bf-2dbe-47be-91d6-6a883caf9d0e"), Guid.Parse("79168cff-b7fe-4e1a-828c-80fd7b783684"), }, { Guid.Parse("767fb1f7-6d18-46d9-b4ea-0ead69743fe1"), Guid.Parse("78638c6c-be82-4ee2-b1cd-dbf69baf2469"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Guid[,] { { Guid.Parse("1614e12a-fa22-4445-bfbd-de3d685f3825"), Guid.Parse("c76eefaf-4740-42b8-8496-4f6f1c86c994"), }, { Guid.Parse("56d1ffef-fdbc-46df-a9ca-412946bf4ad7"), Guid.Parse("7e2933f5-083f-4698-91f2-d1efc7f9108c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("655875cc-8907-4fe7-a95d-baed8e523c29"), Guid.Parse("e348225b-9a74-4eba-9092-8058d90269ef"), }, { Guid.Parse("1ed414c6-7bc2-4f14-9a6e-9ecb624be440"), Guid.Parse("992b5c71-b4dd-4201-96c7-ef612247805c"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Guid[,] { { Guid.Parse("03c05e3b-bcff-486a-9e33-1be2237e52bf"), Guid.Parse("e0ddaa13-0759-4713-9061-b0d7c6993a6a"), }, { Guid.Parse("1e859d6e-de4f-483b-9d46-57ac53acae60"), Guid.Parse("b99c0bd8-abcf-416a-8743-28accf5167a9"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Guid[,] { { Guid.Parse("7bb3cb3a-1077-474e-8b05-f56045de78e5"), Guid.Parse("91dc87c3-edaf-4d9a-9368-5650a91460af"), }, { Guid.Parse("67b2421e-304e-45cc-8e0d-d26f867f4c91"), Guid.Parse("c63d4904-3808-4675-b5f3-b03e6e7b5927"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("709e8d08-b8b9-40bb-a172-a135ef86772c"), Guid.Parse("d1b9cd5b-8a16-4870-9eb6-7d84561bedc2"), }, { Guid.Parse("46357343-0936-40da-8213-3b61f2a332f0"), Guid.Parse("a0babcd4-7c33-43b3-b639-10963e8a62fb"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Guid[,] { { Guid.Parse("70b21d96-352b-4872-b33f-83a9e9039dad"), Guid.Parse("2a8e104e-1b61-4250-b179-e3b715485f35"), }, { Guid.Parse("d9f29019-26b5-49e1-864c-d9d3a1089824"), Guid.Parse("391567f7-1e9c-426c-806d-61d4cfec662d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Guid[,] { { Guid.Parse("a46a99dc-2a52-4a6b-ba12-fe0132559978"), Guid.Parse("ca76944c-b37c-4566-b159-78bb21ce460e"), }, { Guid.Parse("122dd3a7-8092-45bf-883b-8137522678ef"), Guid.Parse("357096e5-d780-46a3-832c-5d82ee537d46"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d42220d5-178d-422c-8095-3bd182a82eef"), Guid.Parse("5f3cc345-541f-479a-aef6-252a0dcd712f"), }, { Guid.Parse("34481381-810c-4214-b881-d9834b5c287a"), Guid.Parse("53eef533-1bfb-48cb-a3ca-9842cf4cb109"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Guid[,] { { Guid.Parse("79659caf-cb2a-49ae-b29b-5de8d6181bee"), Guid.Parse("a5e44498-3f3f-41e1-a57a-43e53955fb97"), }, { Guid.Parse("5a95e161-8c81-4d4f-914d-b7b86bd3da9b"), Guid.Parse("6472b09f-999c-4b85-96c5-83a31b30d708"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("e55e49d3-930a-46dc-87ed-82cdf5edf8e0"), Guid.Parse("e3cae385-82c5-4e3c-92e1-501c75602cb9"), }, { Guid.Parse("47d5fd5f-324a-45ab-bdd2-39ca67e8bb4d"), Guid.Parse("53996527-73d4-471b-97ad-d19ddfeaa1d5"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4bebfaa5-fa4c-4688-bbe1-5088ecaa38ec"), Guid.Parse("ab6af81a-6949-48c3-8594-5ccd6edf7440"), }, { Guid.Parse("484301f2-ba89-4046-906d-4640e200fb24"), Guid.Parse("d03946a1-7a15-406d-9844-a8f8d73ca46b"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("82475df4-e19b-41f5-958d-0fb3505848f8"), Guid.Parse("414c40d7-f303-4a15-b0ea-64ed5ee40084"), }, { Guid.Parse("7296ce7d-01f0-4212-8b60-7baefde41fb3"), Guid.Parse("8366b660-c4ab-4c8e-8a9f-59a36da6c7a4"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.Guid[,] { { Guid.Parse("fd25f127-c65b-4487-beb0-0144ed19fdb1"), Guid.Parse("ea58a0ac-272f-46ef-980d-61bad592d754"), }, { Guid.Parse("24ef5c71-1e2f-4c84-a99b-e4893ee338b1"), Guid.Parse("4fa46a14-c342-4f9b-a20d-33948a24c354"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Guid[,] { { Guid.Parse("e39767d2-c746-4235-9d12-f057e1fe56af"), Guid.Parse("072cf10d-56fe-494b-87cd-1d5eeaff9569"), }, { Guid.Parse("aa702adb-f66e-4319-8c3a-c6ab0c22ac1f"), Guid.Parse("f562101b-f088-4786-98de-7f43abb83c5c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("a2a2df80-4510-4ae4-abb0-b5011b1b31a3"), Guid.Parse("a9f0dafa-dcce-4fdd-bb1d-a82376be5215"), }, { Guid.Parse("c4beadc7-a27a-4843-b094-11305f042e1c"), Guid.Parse("2868a621-3cc9-49c7-a854-d7324b0e8f11"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Guid[,] { { Guid.Parse("e0c6a64b-52ad-4032-9ad7-a7e9be65b7cd"), Guid.Parse("21f70f7a-8466-4d25-bb7b-266a034558e6"), }, { Guid.Parse("dba73e2c-4a6f-4efe-a996-13bc209fe65a"), Guid.Parse("b269970d-c783-47e1-ac35-9d51479ab1c3"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Guid[,] { { Guid.Parse("411b8d6e-f6c9-4ff7-935a-83a5cf05a90e"), Guid.Parse("e17be7c7-a722-44e1-962e-238c54427dbd"), }, { Guid.Parse("b7a6a68a-5555-4670-9f0d-c148fea5f8d0"), Guid.Parse("73cc06f5-1dae-46f5-92fe-2efcc0934af5"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Guid[,] { { Guid.Parse("633bc695-912e-43e4-9511-3db68f3ff82f"), Guid.Parse("6ed893d7-6b4e-4af6-abbe-5f9b41ac278d"), }, { Guid.Parse("7f8f1786-f2f8-4238-8648-850a6ba86138"), Guid.Parse("9d32b8d0-bafc-4463-8976-7f5da10507bc"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Guid[,] { { Guid.Parse("004272ee-44d4-4fbd-a5fc-8b368e61d1b6"), Guid.Parse("70d3c627-2f2f-48b5-9681-895c543518d3"), }, { Guid.Parse("f83138b6-68ba-419a-ba62-996b205128b5"), Guid.Parse("45cf28a1-d849-4277-8464-7a0b4e9a0d7c"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8786b0a4-5ca8-456d-b908-6a8ed5a09527"), Guid.Parse("af9efb6c-4894-4702-a74a-36be772dbd10"), }, { Guid.Parse("5dd61ad0-3037-402f-8bab-a6d73adf9d3a"), Guid.Parse("d2528dfc-c334-46a5-bc3b-f9afbf4a9194"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Guid[,] { { Guid.Parse("4723a076-0f80-490b-8b09-abebebef7301"), Guid.Parse("d8d5987d-0804-42a6-b7ca-b9dc84cce017"), }, { Guid.Parse("cb7c20a3-2da5-4207-8a66-41b0a2839079"), Guid.Parse("2013bc4f-fc15-437f-9883-5f4c6944494f"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Guid[,] { { Guid.Parse("5cb3dbe5-17b2-476a-9e37-830c17855028"), Guid.Parse("e43d5750-222f-4330-b9dc-1cac4dd29d66"), }, { Guid.Parse("db8104b5-7580-4ee9-94ae-36a260148228"), Guid.Parse("8abfde25-5e81-49da-b954-de6be70ca180"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("892d76ae-c7da-4cd8-81a8-8b843d4f7fb7"), Guid.Parse("56dc2a6b-c078-4eb4-a158-ba8f4617ac55"), }, { Guid.Parse("e4e05b2c-bfc6-42e0-8d05-f7fffba0df27"), Guid.Parse("810f02fa-6ff7-4a5d-a626-26a9cdae8b17"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Guid[,] { { Guid.Parse("74fb5859-7a88-42f6-8625-3253ff55ed82"), Guid.Parse("fd5f8f2a-eaa1-4e57-854d-dfc687eff8d2"), }, { Guid.Parse("2c3a0cf4-161b-4b53-9263-6ee3d2732b18"), Guid.Parse("9f70c0f8-1153-475c-b7fa-4536ce793415"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.Guid[,] { { Guid.Parse("06cfdbad-1988-4841-9802-ebfe5a74f31b"), Guid.Parse("74bcf421-72f9-4956-8a14-e98a036210d6"), }, { Guid.Parse("8d104265-3272-44fa-8ed0-086979d26922"), Guid.Parse("929c5a41-7b6a-44e9-9735-73999631af56"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("209963d8-02ca-46c7-a036-436e2080d198"), Guid.Parse("27626cf2-c980-467e-ac2c-4f087706e9f8"), }, { Guid.Parse("801f58d6-1c8d-4dc8-9c3a-d47e6a701d5a"), Guid.Parse("12facaba-3854-4179-af5b-cd3f304e87bb"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ac1809ed-cf3b-4cb4-9bb1-e9b41c4cdd37"), Guid.Parse("0ced9359-1bbd-4dc2-8d55-f804db92f25f"), }, { Guid.Parse("6ca9affa-b0fd-4536-bd55-3d0363a5d943"), Guid.Parse("50037b84-6d1c-443a-b632-438d7a6fb609"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Guid[,] { { Guid.Parse("6f19714b-7cbb-4591-9f1a-7e82700e0e01"), Guid.Parse("80718f0a-f1c0-434a-ad77-6cb67efc622a"), }, { Guid.Parse("97410f48-2936-4c1a-bbfa-5c5237104130"), Guid.Parse("409021ea-d728-4bb7-b844-9fa033f88a4a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Guid[,] { { Guid.Parse("66a05f5e-79a7-40c9-9083-8793465017e0"), Guid.Parse("4afd8aa7-7564-4eda-8ba2-6fa9b4477db7"), }, { Guid.Parse("4aac4678-63b4-445f-b57b-c5cea3070782"), Guid.Parse("ed5cffc1-1f20-4f29-8066-fe08335df2c0"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4f529854-b90a-48b3-99b8-28237373201b"), Guid.Parse("dd5b1fda-0b62-40b7-b0a1-e5bf04562e24"), }, { Guid.Parse("835ce367-3b6d-409e-86c0-f96e823ede66"), Guid.Parse("65317024-2763-4658-81ee-f3412612d8d3"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("566dd15a-307a-4319-9d5e-1ef82b0994cc"), Guid.Parse("502aa783-62e1-4184-b10e-83c62468cfbf"), }, { Guid.Parse("98e8ffe3-543c-49f3-93b9-1e6015996a31"), Guid.Parse("2f0210ce-7444-4d1a-ae19-ecf9486229fb"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Guid[,] { { Guid.Parse("44aa7657-89a4-4171-a970-fba8dd52ecc9"), Guid.Parse("98b4a6a2-8fc3-4558-8ff8-ac2858f1fac7"), }, { Guid.Parse("b4e8a45b-7a84-42b1-ae45-8cec49bb791c"), Guid.Parse("ceeac7ff-831f-4856-b7a0-69e7f9c287b9"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 109,
    Value = 
new System.Guid[,] { { Guid.Parse("6b3a2ed9-3729-4ed8-8900-972ad9206431"), Guid.Parse("6f4cca46-585d-4abe-a732-6e5203d70ab8"), }, { Guid.Parse("05a6235c-47cd-4add-8a1c-0cb8d1878c2a"), Guid.Parse("60c06e60-4a29-4038-94d1-5da81a07f0da"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("fdd82eba-0764-45d6-90d5-49299e4572f6"), Guid.Parse("bb81a3ce-6a2c-4d4c-bfa9-974425516627"), }, { Guid.Parse("34c1def1-641f-462e-856c-6f3854a9a0b8"), Guid.Parse("37e7629a-fea6-4ba2-80de-992b74e7a0c0"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a524516f-8adc-4f6a-ba99-41b57aec943f"), Guid.Parse("5cd3fe82-feeb-4274-94d7-130e4036ceb8"), }, { Guid.Parse("a178ab91-2ef9-44a1-8cb9-081374fbe8ab"), Guid.Parse("2ddea479-697b-43ce-830a-a4468e5be5d7"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Guid[,] { { Guid.Parse("ead06221-90fd-4986-999f-a76073278676"), Guid.Parse("3c37b615-04dc-4dd3-89b3-1e2c130bc079"), }, { Guid.Parse("0791a87c-ca4d-448d-9c61-772edb35585a"), Guid.Parse("9e309e11-6d6c-4489-82d7-1e3d642de5c7"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 116,
    Value = 
new System.Guid[,] { { Guid.Parse("af6563a9-613c-4947-8163-1e8c14b3e6d3"), Guid.Parse("847fb389-0509-459b-8d53-40a89319470d"), }, { Guid.Parse("879f91a3-9f08-4820-9d9d-c91b9538b988"), Guid.Parse("18778938-1d9a-4507-b11c-f90db10d495c"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Guid[,] { { Guid.Parse("9ac18f18-b0bf-4ed7-912a-d301f8513095"), Guid.Parse("c18f5c03-0610-4e4a-82d8-a46ed8fb0fd6"), }, { Guid.Parse("4a101b78-46a9-4d59-9fe6-12372e2ba305"), Guid.Parse("e8ebaef8-9e96-439f-a66e-7273e6c62135"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 121,
    Value = 
new System.Guid[,] { { Guid.Parse("71fadeda-d45f-4246-b94a-2cbf9ea6be1b"), Guid.Parse("70c01e20-f1d6-4d81-bf38-f4f25942dd21"), }, { Guid.Parse("db4d4ced-3ba0-45ce-b557-321447d2fcbf"), Guid.Parse("48709b3d-c602-487d-9cca-abda8e6351cf"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f4473a2b-3c5f-4258-a51f-4c3e2d3f2776"), Guid.Parse("9e1705de-117a-4f4d-a51d-c58012980bab"), }, { Guid.Parse("12fa543c-c0b0-47bf-9dcb-0108fc27d549"), Guid.Parse("ab4f79f0-5d35-4471-84ab-3a7affa64790"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("2365fa84-5a07-4b3e-9ce9-facc63edb1d1"), Guid.Parse("4f8a2bdc-09d6-493f-9368-46158d67a6d5"), }, { Guid.Parse("ebf161e6-6167-41db-8a58-3f9362844274"), Guid.Parse("22e3f44e-11c2-4ef0-b739-dafeaeb547d8"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 108,
    Value = 
new System.Guid[,] { { Guid.Parse("2f06c65b-62a8-40ea-94dd-e5f4070db0d2"), Guid.Parse("9e4977ba-3052-4cfd-85c1-4608ac431cb4"), }, { Guid.Parse("830496a6-d616-4b7d-8879-00275e855273"), Guid.Parse("002f7b83-5820-443b-a323-3f780ee302f8"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Guid[,] { { Guid.Parse("341795f0-3237-4950-bd4a-afb4032b04a1"), Guid.Parse("c86a204b-d7ba-422e-bb2b-b5f7a427b062"), }, { Guid.Parse("668e19b2-3c19-456d-9052-33065f8fde13"), Guid.Parse("d21d5d93-422c-40ac-ba1f-f44993b78559"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("39d3bfe4-b6de-4ee4-b672-3a9d6909cd25"), Guid.Parse("6cbc46d6-b34d-41a6-807a-0d7ba88c62e7"), }, { Guid.Parse("e9e65bbe-2b72-491c-a4d6-cd583ccaf19b"), Guid.Parse("cc10fb24-7dcb-4145-89d5-c61826c8e79a"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("93b85222-75fc-4030-8a8d-5044135fbbd3"), Guid.Parse("99cd09f1-7850-4e4d-ada6-99c6870f9c6f"), }, { Guid.Parse("0b17c1b0-fbe2-4030-b28b-08170870bb92"), Guid.Parse("b545bbd6-be0b-49c2-9143-deffcf053834"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Guid[,] { { Guid.Parse("b17be5ea-54f1-4518-addf-346867bc5b0b"), Guid.Parse("abec12f8-cf15-4582-a4ec-fb8407e6af09"), }, { Guid.Parse("9614874b-7055-43c5-b8fc-253d9391d0ac"), Guid.Parse("d32f4b71-7119-4640-9cf6-d6a45de6906c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 130,
    Value = 
new System.Guid[,] { { Guid.Parse("53743b18-6daf-4093-8327-a5dfe8d82250"), Guid.Parse("4b655f36-cc81-4aca-9393-da088f42cc2b"), }, { Guid.Parse("b2a149a9-aca5-4b6c-aaaf-6ffb7d3b5446"), Guid.Parse("eb2afb6b-7074-4c53-9c86-9b4001761684"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("23be3ee8-8b0a-49e2-a598-df3e7290f426"), Guid.Parse("2c2f0b11-b7b5-4363-b8b6-85762232c813"), }, { Guid.Parse("966d8874-cffa-407f-b86d-cffe0717e969"), Guid.Parse("de414a47-bb90-4c0e-93e3-28a5e96df365"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d004e96c-d44d-4081-a34e-7c58830eb8a5"), Guid.Parse("1af3f1cd-446a-41e6-9656-57c13fed0fd4"), }, { Guid.Parse("9d98f6d1-6958-40ed-b9a0-5d96253230ee"), Guid.Parse("d662c928-9d9b-4482-b6b9-c4b0ab43691e"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Guid[,] { { Guid.Parse("f000e13c-9e93-4f4e-90da-b9dd3daaab41"), Guid.Parse("e7a4c9cb-4b22-49fb-a68a-8b22dd13e702"), }, { Guid.Parse("1aca4280-0a6e-436e-98cb-2944a30dacd4"), Guid.Parse("fc8f31fe-3cad-44c1-9f7d-2e87d2819ca6"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Guid[,] { { Guid.Parse("d19da34a-58f2-4aaa-88b2-280667593298"), Guid.Parse("45c1f55e-3938-4616-b372-c5fe56fedcf1"), }, { Guid.Parse("6c17635e-cfa7-4c5d-bfc0-560053df177e"), Guid.Parse("c69569a6-2f13-4cf7-99d7-14cba9ed913b"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("408daa2e-debe-4c1a-97bb-0074b083cf4c"), Guid.Parse("548fda70-6d0a-4f21-893b-dc365cb83b3c"), }, { Guid.Parse("533a8931-ffcd-4317-9358-4b09bf96efa0"), Guid.Parse("c6f0183c-d089-49b4-9146-4f4051dfb193"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 123,
    Value = 
new System.Guid[,] { { Guid.Parse("86581c46-0215-457b-914c-9c5c8e573e63"), Guid.Parse("a67ad71a-ba1a-45d1-9893-bedd6aefeb1a"), }, { Guid.Parse("38a5c345-97b7-4111-933a-bb418b622ec2"), Guid.Parse("ca985317-2721-4c79-b161-bfc95ac935ac"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Guid[,] { { Guid.Parse("9a7ffe14-ba62-4de1-bfcc-246c29d73609"), Guid.Parse("f9243d73-a076-4336-9cfe-64c061a6413f"), }, { Guid.Parse("6c2e4382-85dd-4e38-9404-d7396781f6d8"), Guid.Parse("70ad68bc-a814-4feb-89cf-f38cc778d366"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("09a00c4a-5dd1-47c1-a4f4-ca73970dbe3f"), Guid.Parse("d9537f02-2e13-4095-bc71-d4262171fdaf"), }, { Guid.Parse("8f19b4d1-2ea6-460a-bb31-d0de4ffe04e5"), Guid.Parse("baa33377-6fd1-4274-b44d-5ecf213c6799"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("54b25b1e-01b6-4d45-b747-a1ea0c3fe71f"), Guid.Parse("b3c7633c-7986-42fc-ae74-d299625baf05"), }, { Guid.Parse("66328ade-91d4-4fcb-adec-a3e96749148d"), Guid.Parse("2f7de3b4-23aa-4c3b-b69e-5ac02f292046"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 132,
    Value = 
new System.Guid[,] { { Guid.Parse("def2eaf3-4afd-45b7-ade7-ca9b3b387ab5"), Guid.Parse("e82591ec-3178-43a8-b88b-daeef050663d"), }, { Guid.Parse("78dc333b-ab0e-443f-ae5f-2ef3729f1c98"), Guid.Parse("fb91b811-3347-4269-8e4b-bf4dd68da7be"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 142,
    Value = 
new System.Guid[,] { { Guid.Parse("6ac938a8-6bbc-4d89-9622-98315741d8ac"), Guid.Parse("216d8760-03b2-4a69-b98f-95c61bdbb742"), }, { Guid.Parse("9d5b9f13-3414-4483-80e4-47b37d8a7684"), Guid.Parse("0e00cadb-f6e0-4342-b290-9d4ff9786761"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("fc555c76-3cef-4fe6-9a31-6f05d47d75e9"), Guid.Parse("d54897cc-bf87-4f69-9399-1d89bd8a4304"), }, { Guid.Parse("725ecb71-dd8c-4574-bdea-d29213c0ac02"), Guid.Parse("e95c6aed-84ea-4c63-82a2-78c999f82aaf"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Guid[,] { { Guid.Parse("760b26d3-6726-4962-9e01-6f4503c6f788"), Guid.Parse("43912565-6518-41bc-827b-4e1d8e5fed3c"), }, { Guid.Parse("d2ed87db-b15c-442f-b642-8ee1f305d93b"), Guid.Parse("123d9989-be43-4310-8e8a-da79d24559c2"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Guid[,] { { Guid.Parse("c5263582-e7cc-4913-b929-0f792f6f6063"), Guid.Parse("39e0878e-be22-4db4-83d4-aada9bb5f2d5"), }, { Guid.Parse("d68698ba-fca9-4926-a38a-1c115692aac4"), Guid.Parse("e62402a6-9a1d-4496-9a66-ac9ff3ac03da"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("bdb17b89-1b3a-46ee-9e67-2a66b99f6359"), Guid.Parse("4dbd2657-0417-41b0-9b09-12a2f914ba11"), }, { Guid.Parse("75b57728-a670-4348-98e5-cb392c0430af"), Guid.Parse("279fb1a2-1777-4254-a1d1-7f3196f028d1"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Guid[,] { { Guid.Parse("c7afe1d7-2398-4db6-82f9-058465d9f254"), Guid.Parse("4e5e8226-a020-439d-8f56-5bab5c4f0142"), }, { Guid.Parse("dc2fb414-def0-406e-98cd-47abab3c64d3"), Guid.Parse("258626dc-18ab-426d-b3e6-0b09f38c66d9"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 155,
    Value = 
new System.Guid[,] { { Guid.Parse("2930d995-e011-421b-87a0-b12d282e1188"), Guid.Parse("a1e304e5-e0b2-4cf6-8041-bd15387abd47"), }, { Guid.Parse("6e45a660-0838-466b-a1d4-9728a791097b"), Guid.Parse("bd6f1842-8e0e-4085-9cc8-2e3f0b18559d"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Guid[,] { { Guid.Parse("9dd263dc-3cc1-44f3-b020-fb7d0d7bc44f"), Guid.Parse("ec43fa7a-236c-4dc9-bf3b-61a35dcb1b7d"), }, { Guid.Parse("00ba72e8-d891-45ad-91a6-a586c7ca9659"), Guid.Parse("be6914a5-81eb-4ca9-9af1-51fa462f5801"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 159,
    Value = 
new System.Guid[,] { { Guid.Parse("d42fe477-0fc1-434b-802d-26ca473a522d"), Guid.Parse("2714bf1e-228f-4611-aa63-f788318b95e9"), }, { Guid.Parse("b1a5acf3-732a-4620-ae2c-24cf881cd5a3"), Guid.Parse("c366e21c-b83a-418b-af19-f7d11e586965"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("277e1c4f-7ef0-4607-81e7-61fb29a07b39"), Guid.Parse("d3a3fd74-8560-4f6e-befa-877c4ddbb30c"), }, { Guid.Parse("1f040428-0983-4f69-9d4c-71566ec2e6b7"), Guid.Parse("023de6ad-ecdf-4ab6-bef8-bf419fc8575c"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 165,
    Value = 
new System.Guid[,] { { Guid.Parse("9125a82d-63cb-4407-a413-0c896751b03e"), Guid.Parse("1cab379c-c295-4c8a-9ff0-5eba172fcdb3"), }, { Guid.Parse("fea4a132-95ed-44e5-82fb-edf4e2c82603"), Guid.Parse("fb1a08b3-3fbf-4216-ad06-a73e97cad738"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 168,
    Value = 
new System.Guid[,] { { Guid.Parse("d6d8cf34-3abf-4f90-bb18-c0c344253c26"), Guid.Parse("06924153-6ca4-4cac-9716-51d37d1572e7"), }, { Guid.Parse("b5fdeb61-9b77-4207-9f59-88581f246d54"), Guid.Parse("70b94e3b-8129-455c-bf7c-f5b5d1aff6f8"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 171,
    Value = 
new System.Guid[,] { { Guid.Parse("a1d2c204-75db-4aef-870c-15c1ccfc8612"), Guid.Parse("f48ffcf9-4afa-435a-b507-c5d9e08e8bad"), }, { Guid.Parse("2df5face-78cd-4a2b-98ec-3ed638ff01c7"), Guid.Parse("ff1ac18b-cfdc-4d75-a20d-33bed33ab0bd"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 171,
    Value = 
new System.Guid[,] { { Guid.Parse("4dbd620f-74b8-45f8-b8ca-03761e9e0cc0"), Guid.Parse("e3ed0ff0-6aab-4294-94cb-5f5a4cabe6d4"), }, { Guid.Parse("578fc5dc-6a7d-4795-bb16-4f9fa7e061f2"), Guid.Parse("9a6b9c75-e58c-4615-84b4-a83603fb4f98"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 176,
    Value = 
new System.Guid[,] { { Guid.Parse("0e79f40e-14b3-49a0-beb6-d19c53b183c8"), Guid.Parse("8db4b348-72e0-4eb3-90ce-e3c99e717e1b"), }, { Guid.Parse("caa70e13-5043-410d-bda1-c59b6d2997c0"), Guid.Parse("5511a041-9303-40a2-9d86-7139e70b9fdf"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 179,
    Value = 
new System.Guid[,] { { Guid.Parse("721504f5-a62c-4286-ba54-772ff4a4ea54"), Guid.Parse("c2a75fce-7e16-4f1f-996f-2055e69aad89"), }, { Guid.Parse("7254c6de-5006-411a-bb2d-df4ad2daa7f1"), Guid.Parse("36954a67-d237-4196-a30e-61c66b010693"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("35d800a9-f2c7-4ef8-b512-5362ce35cc04"), Guid.Parse("b789c631-8768-4163-a2ed-f3ae720de921"), }, { Guid.Parse("20e365d6-0105-435e-930c-1e4d10400da2"), Guid.Parse("8552ef38-7cb6-40f7-b5cb-fab61d199b3f"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 183,
    Value = 
new System.Guid[,] { { Guid.Parse("9b75e1c8-5580-49f3-93bd-49c8fbefb369"), Guid.Parse("60a8267b-c514-491d-a976-1f90f01f900f"), }, { Guid.Parse("c7250b73-8a1d-4426-b802-32d414d09586"), Guid.Parse("08d95329-c3d9-41ac-9645-9bcc1c588c16"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 182,
    Value = 
new System.Guid[,] { { Guid.Parse("d915a2a2-06ab-42d7-8df6-fdb792a866d8"), Guid.Parse("4dba0486-686e-4c98-a883-b2885b8c25f3"), }, { Guid.Parse("90ccfdfc-2cce-46ef-9b7c-adf60bc8168a"), Guid.Parse("ad7e8284-6eae-408d-a1c5-b35543c0ebbd"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1c79c84d-1f0e-4184-a88e-f978a466b312"), Guid.Parse("057f7398-1b9f-4e59-95ab-6c73c3b979f8"), }, { Guid.Parse("cc019e73-dfdc-477a-a7c3-4705f176ff7c"), Guid.Parse("8a7f7cb4-c9ec-4b3c-aa51-6d751b621d42"), }, },
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
INSERT INTO gedaqtests.guidmarrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UUID))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UUID))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
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
                    await ((IGuidMArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IGuidMArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.guidmarrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD2)),
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
                    var models = await ((IGuidMArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidMArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

