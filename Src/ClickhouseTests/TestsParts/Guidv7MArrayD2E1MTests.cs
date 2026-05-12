

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
    internal partial interface IGuidv7MArrayMArrayD2
    {
    }
    
    internal partial class Guidv7MArrayMArrayD2 : IGuidv7MArrayMArrayD2
    {


#region TestData

        private readonly Guidv7MArrayD2E1M[] _testData = new Guidv7MArrayD2E1M[]
        {
            new Guidv7MArrayD2E1M
{
    Id = 2,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-765b-8d28-fd648ee2ba27"), Guid.Parse("019e1b50-15ac-7de6-94e0-56834804ab76"), }, { Guid.Parse("019e1b50-15ac-7d79-8797-171b3117c6b1"), Guid.Parse("019e1b50-15ac-7c05-8f79-ada27dff576a"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7460-9b91-5e4ebc871b07"), Guid.Parse("019e1b50-15ac-79ff-9778-42a5be9a632e"), }, { Guid.Parse("019e1b50-15ac-7057-878c-362999948a57"), Guid.Parse("019e1b50-15ac-7f5d-86f1-68bb8647c53c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-70c9-a1a6-5a6ec10fb82c"), Guid.Parse("019e1b50-15ac-7f56-96ba-3bcfb0fb2379"), }, { Guid.Parse("019e1b50-15ac-73ce-8183-1be86d1e3671"), Guid.Parse("019e1b50-15ac-7b41-898f-4097f1603736"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-750b-8b74-36e1f47611b2"), Guid.Parse("019e1b50-15ac-74b5-baf1-8ba24cb532d0"), }, { Guid.Parse("019e1b50-15ac-7ba6-aea9-514351d3bbc8"), Guid.Parse("019e1b50-15ac-7695-9cf7-956a4f868bd7"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 11,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7979-bd79-0fc564a704a0"), Guid.Parse("019e1b50-15ac-73ce-b26b-a17737cbdcef"), }, { Guid.Parse("019e1b50-15ac-7b41-894d-96d1356be62f"), Guid.Parse("019e1b50-15ac-7923-bdb2-b56def37f4d0"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-749a-bfb7-fbb00b9b6cd9"), Guid.Parse("019e1b50-15ac-7c29-9ea1-226c62ad7c68"), }, { Guid.Parse("019e1b50-15ac-7cd0-8142-7944f48afa69"), Guid.Parse("019e1b50-15ac-7944-aea0-c70ead557fc5"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-75de-8dfd-6574737a7644"), Guid.Parse("019e1b50-15ac-7a7c-8a6c-35409edd95c2"), }, { Guid.Parse("019e1b50-15ac-7a84-b18b-3c4b4770d09b"), Guid.Parse("019e1b50-15ac-74f9-bf6f-f0490c273bdc"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7c14-afcc-94e76070c8bb"), Guid.Parse("019e1b50-15ac-72ed-8eb8-58c5eb007ff1"), }, { Guid.Parse("019e1b50-15ac-70c4-934c-8085ddc0dd48"), Guid.Parse("019e1b50-15ac-7272-9496-91fab9bef30a"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 17,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-70c8-bab7-5bdb53aa40e6"), Guid.Parse("019e1b50-15ac-70d9-8cb9-4760d4d8b00e"), }, { Guid.Parse("019e1b50-15ac-7a7c-96a1-d522c35ff3a4"), Guid.Parse("019e1b50-15ac-7d0c-9254-de2386107706"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7c24-be25-ca15c2a592d6"), Guid.Parse("019e1b50-15ac-7689-8fad-fe8a455dcd91"), }, { Guid.Parse("019e1b50-15ac-7ead-81ed-3b51cb03ffe7"), Guid.Parse("019e1b50-15ac-7b2d-a08d-7548b9c5d04d"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7b61-aacf-f0cd9d5a4ff5"), Guid.Parse("019e1b50-15ac-7284-a626-ac730cd9e233"), }, { Guid.Parse("019e1b50-15ac-7da3-aa71-ea0e12f6c782"), Guid.Parse("019e1b50-15ac-7d01-9a8e-a7b8f17950b6"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7394-b40a-e589c5ebb01f"), Guid.Parse("019e1b50-15ac-7615-8965-71a2efd0b9c6"), }, { Guid.Parse("019e1b50-15ac-72f5-8ed0-eec4f56963a5"), Guid.Parse("019e1b50-15ac-78da-912f-4440e16008fe"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-74d7-a442-48b30b41aeeb"), Guid.Parse("019e1b50-15ac-781c-8943-38533f87e5a2"), }, { Guid.Parse("019e1b50-15ac-725d-8f6b-6bcf3bf22bb0"), Guid.Parse("019e1b50-15ac-7fa2-8aad-55ee2010612f"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7359-a2a5-bf787f5ed827"), Guid.Parse("019e1b50-15ac-79b1-8f24-859a6d28db2b"), }, { Guid.Parse("019e1b50-15ac-79c6-9f5b-64efbc51891e"), Guid.Parse("019e1b50-15ac-7be2-bc7a-670bbe80675f"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 30,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-797f-b7ed-126159ef4c5f"), Guid.Parse("019e1b50-15ac-736a-bb6e-7624ba32b2b1"), }, { Guid.Parse("019e1b50-15ac-7ce0-830c-029902489472"), Guid.Parse("019e1b50-15ac-7b29-a069-e005c2df91a8"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7c4f-8f13-c963dd682e2c"), Guid.Parse("019e1b50-15ac-7cb5-9b29-f9e75d53796d"), }, { Guid.Parse("019e1b50-15ac-7328-a181-23b2c117a590"), Guid.Parse("019e1b50-15ac-7e13-b093-9adc75c4d7e5"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7e6f-99d6-b12e3e153cfc"), Guid.Parse("019e1b50-15ac-7569-9724-232062b6ecbf"), }, { Guid.Parse("019e1b50-15ac-779e-bafd-ae269ca53338"), Guid.Parse("019e1b50-15ac-7bd6-9c7c-3cd762677dc6"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 35,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-77a3-9ae1-9dfc66c3b256"), Guid.Parse("019e1b50-15ac-78a0-9672-b0ecaa67cb83"), }, { Guid.Parse("019e1b50-15ac-7efb-b36f-9ae44f6c007c"), Guid.Parse("019e1b50-15ac-77ad-aef5-24b62faaf256"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7cf4-a876-1a7758ee4bc5"), Guid.Parse("019e1b50-15ac-7c79-a4e4-a06bdfc68342"), }, { Guid.Parse("019e1b50-15ac-7861-8420-79e079b1630f"), Guid.Parse("019e1b50-15ac-7753-a4c6-21359efb83d6"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-71ec-9bd7-f616576d2666"), Guid.Parse("019e1b50-15ac-76ac-98f0-14f0d1f8a4b8"), }, { Guid.Parse("019e1b50-15ac-75cc-946d-0b59130b9592"), Guid.Parse("019e1b50-15ac-718a-82d9-b614bca8cc20"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 37,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7c27-846a-6206ed31bd05"), Guid.Parse("019e1b50-15ac-790c-9312-dd8108853cda"), }, { Guid.Parse("019e1b50-15ac-7625-9c0f-23f1142a348c"), Guid.Parse("019e1b50-15ac-7364-8c51-a725c01d424a"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 29,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-708e-992e-d5a6ddc8163c"), Guid.Parse("019e1b50-15ac-7fd3-8aa5-f3b30338820f"), }, { Guid.Parse("019e1b50-15ac-7241-9621-0c6176a62067"), Guid.Parse("019e1b50-15ac-7b79-bf20-ab74466b5656"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7e9a-b4fd-ec185bd2e587"), Guid.Parse("019e1b50-15ac-70c3-a419-c2388bf3e24a"), }, { Guid.Parse("019e1b50-15ac-74e8-971e-1a879b48636f"), Guid.Parse("019e1b50-15ac-7153-8e5d-c99675cd7906"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 41,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7b0c-bf7d-08eaf87d471a"), Guid.Parse("019e1b50-15ac-75ed-9c83-e41d28b80ead"), }, { Guid.Parse("019e1b50-15ac-7956-8e9b-d43f156e3fca"), Guid.Parse("019e1b50-15ac-71e5-b8e5-5d9a0304f032"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7745-98b3-808ff8bb6f10"), Guid.Parse("019e1b50-15ac-78ce-83fa-616ebac7a0f8"), }, { Guid.Parse("019e1b50-15ac-75cc-b72b-1c15ed719460"), Guid.Parse("019e1b50-15ac-7ca9-9b19-d565932387c9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7f45-9b49-0dc2ae5254a2"), Guid.Parse("019e1b50-15ac-7431-a033-67498abec764"), }, { Guid.Parse("019e1b50-15ac-7952-913e-840ea903f42a"), Guid.Parse("019e1b50-15ac-73f1-ab04-7ec569d558bd"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7d68-907c-7168c5bad6a7"), Guid.Parse("019e1b50-15ac-7d29-9f06-69f23d359ac0"), }, { Guid.Parse("019e1b50-15ac-7b65-944f-bbaa47cd9f61"), Guid.Parse("019e1b50-15ac-7407-b2e5-d4a319d1d9e1"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 42,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-79bd-aa04-685a5539aade"), Guid.Parse("019e1b50-15ac-7317-aa93-92e1ca625285"), }, { Guid.Parse("019e1b50-15ac-7364-ab03-a72b92ef69ef"), Guid.Parse("019e1b50-15ac-7b86-8cca-aeb2a9d01d73"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7c2c-b29e-866945844fdc"), Guid.Parse("019e1b50-15ac-7466-ab74-03a7cddbf9f5"), }, { Guid.Parse("019e1b50-15ac-7788-9ba7-c476c7f47f1b"), Guid.Parse("019e1b50-15ac-7a96-86ce-590f15dd04a5"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7ce7-9604-b0c54ac1fd4c"), Guid.Parse("019e1b50-15ac-7792-b5ec-2bef4898ce60"), }, { Guid.Parse("019e1b50-15ac-70e6-b3b8-23722ba2a022"), Guid.Parse("019e1b50-15ac-7b50-afcd-69b47fbe2c3b"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-712e-b4ab-9ba915281ba1"), Guid.Parse("019e1b50-15ac-7dda-8a8a-21f2e3d7527d"), }, { Guid.Parse("019e1b50-15ac-7fac-b43e-174a970ae28c"), Guid.Parse("019e1b50-15ac-70e4-9225-bd2873153f54"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 47,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7732-9ce7-20d6913171a5"), Guid.Parse("019e1b50-15ac-79d3-a344-21c9217cea38"), }, { Guid.Parse("019e1b50-15ac-7db4-837d-0fe198cc1d91"), Guid.Parse("019e1b50-15ac-71de-ad47-79bcaf70f60e"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7650-b3ad-e4b7371a5f25"), Guid.Parse("019e1b50-15ac-7161-8d73-f8e327488b6b"), }, { Guid.Parse("019e1b50-15ac-7d2b-82dd-b3ea7ea55436"), Guid.Parse("019e1b50-15ac-7c17-ae90-e1f15addd0ae"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7886-a50b-fb66b0f5be45"), Guid.Parse("019e1b50-15ac-7fe3-96e8-f882d0bc6b41"), }, { Guid.Parse("019e1b50-15ac-7cfc-8a2f-fbb0beab505b"), Guid.Parse("019e1b50-15ac-7d48-831d-45e313d35787"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7436-835d-2513dda2864f"), Guid.Parse("019e1b50-15ac-70da-911e-beab51450f6c"), }, { Guid.Parse("019e1b50-15ac-7f0c-b510-5c9e1b8e6260"), Guid.Parse("019e1b50-15ac-7e32-aae1-dbd7d6793c3e"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 48,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7102-a965-7be961fb9d1f"), Guid.Parse("019e1b50-15ac-76bc-b86d-2eae825197b6"), }, { Guid.Parse("019e1b50-15ac-7625-9c3f-751822475491"), Guid.Parse("019e1b50-15ac-7f3e-9dfc-00f6f7a02e5c"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-749f-9023-384c38b3c88d"), Guid.Parse("019e1b50-15ac-777d-8651-83a4a33a072a"), }, { Guid.Parse("019e1b50-15ac-76da-a097-8727c5b4fe54"), Guid.Parse("019e1b50-15ac-7849-b30b-009c31cb274e"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 54,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7728-8635-bc3dad9c2710"), Guid.Parse("019e1b50-15ac-7cbe-bd7c-77f61b987fce"), }, { Guid.Parse("019e1b50-15ac-7cf6-a6f0-86cb2369f606"), Guid.Parse("019e1b50-15ac-7887-b0f6-1fcc27040b20"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-71cc-b599-0cf75f27414d"), Guid.Parse("019e1b50-15ac-7513-9926-c8752691ae37"), }, { Guid.Parse("019e1b50-15ac-79d3-b746-040d20385d5a"), Guid.Parse("019e1b50-15ac-768c-9e10-dd78f1be5893"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 57,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7843-8af3-0b4bafa84dcf"), Guid.Parse("019e1b50-15ac-73e7-9c94-df5c575546ad"), }, { Guid.Parse("019e1b50-15ac-707d-b00c-5505315b8205"), Guid.Parse("019e1b50-15ac-7a92-a295-ef5104ddc974"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7d0d-a0fb-457fa2c941c6"), Guid.Parse("019e1b50-15ac-7a59-bab4-9c3bdc5d5cf1"), }, { Guid.Parse("019e1b50-15ac-769e-954d-67d2a00ed69d"), Guid.Parse("019e1b50-15ac-7898-a12d-aaabf9ba6698"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7ebe-a2b0-f90f5c26b20e"), Guid.Parse("019e1b50-15ac-787b-8ba5-4f719c1fb603"), }, { Guid.Parse("019e1b50-15ac-7c93-94cb-93cfced2eea4"), Guid.Parse("019e1b50-15ac-7b61-abf0-d915a20f6f11"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-75b3-8df3-a9b1dcd6e395"), Guid.Parse("019e1b50-15ac-7c51-9b10-ce7c37ce0491"), }, { Guid.Parse("019e1b50-15ac-76c4-b2a7-210b1ad5246d"), Guid.Parse("019e1b50-15ac-70c4-ba09-0691ed9a018e"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7efd-8705-b17a42897d70"), Guid.Parse("019e1b50-15ac-7d07-9b71-c840a85a718d"), }, { Guid.Parse("019e1b50-15ac-7543-b094-73e1ffdac9df"), Guid.Parse("019e1b50-15ac-7617-a9f9-28841db58024"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-74a0-b34a-3e8d4ca40b78"), Guid.Parse("019e1b50-15ac-7bdb-8c91-410280bac2c7"), }, { Guid.Parse("019e1b50-15ac-76f5-857d-666cd9253ae2"), Guid.Parse("019e1b50-15ac-7089-8bcc-90754147ef53"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 70,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7c3d-b10b-7faaecd95e85"), Guid.Parse("019e1b50-15ac-78fa-8447-5d0988a6b91e"), }, { Guid.Parse("019e1b50-15ac-7b85-8ae5-8ddb7ef90479"), Guid.Parse("019e1b50-15ac-777e-a27f-d53f178676b3"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7786-a30a-3d6e681d19b7"), Guid.Parse("019e1b50-15ac-706c-b99a-18541f5b33fe"), }, { Guid.Parse("019e1b50-15ac-76c7-8c2a-04f302d9efd3"), Guid.Parse("019e1b50-15ac-7510-a1bc-e75e381cd361"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 74,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-75ec-abb9-b3e8198dd4a3"), Guid.Parse("019e1b50-15ac-7968-89b7-98b06da4732f"), }, { Guid.Parse("019e1b50-15ac-71e0-8a57-8d33a20dc6e7"), Guid.Parse("019e1b50-15ac-7bcb-8592-be7a4e753bae"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7ec0-a48c-ac7721436c92"), Guid.Parse("019e1b50-15ac-7e5a-bff9-adf5e4db15ea"), }, { Guid.Parse("019e1b50-15ac-7011-9ab9-f9fe9dd447f0"), Guid.Parse("019e1b50-15ac-7fa3-b628-2ed929b4ea7f"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7b86-8abe-1f76ac2af40d"), Guid.Parse("019e1b50-15ac-7281-b01e-ad2d813f6d1a"), }, { Guid.Parse("019e1b50-15ac-7bb3-9785-752a503f439a"), Guid.Parse("019e1b50-15ac-73df-845c-da1474e7a764"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 83,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7179-b6c0-5147e8139973"), Guid.Parse("019e1b50-15ac-721a-9e93-02ee7d1f9a60"), }, { Guid.Parse("019e1b50-15ac-730d-84d5-0c0744879a40"), Guid.Parse("019e1b50-15ac-774e-bbc3-bfaf70b2866f"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7fe2-8eac-d2267b6ebe85"), Guid.Parse("019e1b50-15ac-7b80-97f4-c533646f42a2"), }, { Guid.Parse("019e1b50-15ac-7b6c-b6ba-a33ccb0cc809"), Guid.Parse("019e1b50-15ac-7db6-a509-a36aa2ad82e0"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7fd9-b42d-67d635fa1870"), Guid.Parse("019e1b50-15ac-7f97-bafa-b7f59179a580"), }, { Guid.Parse("019e1b50-15ac-771f-8623-da2f81305edb"), Guid.Parse("019e1b50-15ac-7c7d-baac-979199cbf448"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 86,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7425-95d4-78a93f209c11"), Guid.Parse("019e1b50-15ac-748c-8b5f-49977e7bec61"), }, { Guid.Parse("019e1b50-15ac-799b-baca-6198c12c2b48"), Guid.Parse("019e1b50-15ac-7b58-9c32-41a5204b4934"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-77d4-831c-9b118ced3d4c"), Guid.Parse("019e1b50-15ac-701e-b9e2-7d97beded8ff"), }, { Guid.Parse("019e1b50-15ac-7ce7-a7aa-b4200c150f73"), Guid.Parse("019e1b50-15ac-7090-a09d-a0a47cbce4a4"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 95,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7528-97cf-d7dec34b8d6f"), Guid.Parse("019e1b50-15ac-70da-860d-7b39ad5f3fcb"), }, { Guid.Parse("019e1b50-15ac-7d46-85c2-fc3425cd652f"), Guid.Parse("019e1b50-15ac-7a60-bd8a-5d8bf807645e"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-78bf-89a4-b0457ee73abd"), Guid.Parse("019e1b50-15ac-7bc6-a2de-648fc1690f43"), }, { Guid.Parse("019e1b50-15ac-7c19-a606-0a2dd72a4d9e"), Guid.Parse("019e1b50-15ac-766f-a2d2-f64f6343a1ad"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 103,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-714b-8ad6-58924b5ce962"), Guid.Parse("019e1b50-15ac-7358-859a-cc7af9e56f1e"), }, { Guid.Parse("019e1b50-15ac-7b53-bdc8-dae4c7d06e5d"), Guid.Parse("019e1b50-15ac-7a53-a068-7b3d0dcba34a"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7869-9a2a-d6d661261ceb"), Guid.Parse("019e1b50-15ac-7b86-bd4d-25848cc61c1c"), }, { Guid.Parse("019e1b50-15ac-7467-92f2-6c0d795f74c5"), Guid.Parse("019e1b50-15ac-78ff-b378-f73c021abf7c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-77dd-b127-317683612208"), Guid.Parse("019e1b50-15ac-79da-a76a-6b435389dffd"), }, { Guid.Parse("019e1b50-15ac-79c7-b5bc-6e8740b44a97"), Guid.Parse("019e1b50-15ac-70d5-9c1a-69dc19e967f0"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 107,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7ee7-817e-407f512d0bd5"), Guid.Parse("019e1b50-15ac-7c60-8591-a91cbf5d827c"), }, { Guid.Parse("019e1b50-15ac-76d2-9e66-bc6bad84019b"), Guid.Parse("019e1b50-15ac-77f2-9e48-b1cc23d08ed8"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-72aa-9a21-7256d752692d"), Guid.Parse("019e1b50-15ac-78a2-ab34-5e584c827583"), }, { Guid.Parse("019e1b50-15ac-742b-b2ec-069114e53daa"), Guid.Parse("019e1b50-15ac-741b-8f9b-51a0218883f2"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7fa9-9958-4707681df00b"), Guid.Parse("019e1b50-15ac-7c78-b942-011696342bee"), }, { Guid.Parse("019e1b50-15ac-735d-86f3-a0ef4ccd19fc"), Guid.Parse("019e1b50-15ac-7490-a8bb-3fcbbd277771"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 109,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-75ef-b1da-7e3209dec376"), Guid.Parse("019e1b50-15ac-7d4a-a142-381c87e3d3d8"), }, { Guid.Parse("019e1b50-15ac-78cc-8485-3aca75124ecf"), Guid.Parse("019e1b50-15ac-70da-8d0b-bd5773042080"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 118,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7458-954a-623901b71a58"), Guid.Parse("019e1b50-15ac-7f5f-90bf-a2a00daeb6d6"), }, { Guid.Parse("019e1b50-15ac-7747-9462-e16f0c49a600"), Guid.Parse("019e1b50-15ac-79e5-b8b9-c59e85422727"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7eff-a57f-a191af5582cb"), Guid.Parse("019e1b50-15ac-7c16-8713-392d7aafe5f7"), }, { Guid.Parse("019e1b50-15ac-7b28-8301-7ec9dcd622f0"), Guid.Parse("019e1b50-15ac-7832-96c3-88de19149b72"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 112,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-705f-a36d-3eb20b826f17"), Guid.Parse("019e1b50-15ac-7490-955d-022f60226281"), }, { Guid.Parse("019e1b50-15ac-76c4-92a0-b8d29a38904a"), Guid.Parse("019e1b50-15ac-744b-9209-0962c59a85e5"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7c7e-aa43-a74ff9a02fb1"), Guid.Parse("019e1b50-15ac-7682-9a12-73044b8407be"), }, { Guid.Parse("019e1b50-15ac-7935-8c85-d609198ca8ac"), Guid.Parse("019e1b50-15ac-7b9a-80e6-a93662f2e208"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-74b4-bcfb-f11da2307d0f"), Guid.Parse("019e1b50-15ac-7a56-bd4b-39b53ac39309"), }, { Guid.Parse("019e1b50-15ac-7f2d-a9d7-ed96708f5bfb"), Guid.Parse("019e1b50-15ac-7181-9a63-3c5bb3fe4ce7"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-779d-80f3-0b409058c408"), Guid.Parse("019e1b50-15ac-7f38-a391-8f8038389b13"), }, { Guid.Parse("019e1b50-15ac-7208-999a-fa078eeb8bdc"), Guid.Parse("019e1b50-15ac-7195-9869-ee39f785e63d"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 115,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-717c-97d0-e5adccc223e0"), Guid.Parse("019e1b50-15ac-7efe-9372-655c976558a4"), }, { Guid.Parse("019e1b50-15ac-7224-9df9-a7f5d20f4755"), Guid.Parse("019e1b50-15ac-74c2-b178-199b5d4184d1"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7571-9e27-21d6e58b74c3"), Guid.Parse("019e1b50-15ac-7673-8446-d02ad6ca96b4"), }, { Guid.Parse("019e1b50-15ac-7117-bdb3-2c179f47702d"), Guid.Parse("019e1b50-15ac-7719-8c83-3a70c97640fa"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7f22-9843-470ae32d4aec"), Guid.Parse("019e1b50-15ac-7cce-99f3-e1c77759f7cb"), }, { Guid.Parse("019e1b50-15ac-75ac-95c2-588baafb6368"), Guid.Parse("019e1b50-15ac-7996-9aa7-a91e76c2ba20"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 117,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-751c-9612-6f7485013f1e"), Guid.Parse("019e1b50-15ac-7dbb-9c73-79fb07ec48d0"), }, { Guid.Parse("019e1b50-15ac-7420-8aa4-41d969494ece"), Guid.Parse("019e1b50-15ac-759c-8471-c234d2938345"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 129,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7b7c-b48f-023bf4fbe4c0"), Guid.Parse("019e1b50-15ac-77a2-8b0c-fd7d499df8df"), }, { Guid.Parse("019e1b50-15ac-7409-87cc-4d8ba2b0282f"), Guid.Parse("019e1b50-15ac-74fe-898b-e92bc2bf690a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-76a6-977c-01066746d941"), Guid.Parse("019e1b50-15ac-7003-b33e-fc60c9b84d09"), }, { Guid.Parse("019e1b50-15ac-764c-a9d5-d60901b8c1aa"), Guid.Parse("019e1b50-15ac-7376-94cc-832a16af841a"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-729f-b6a6-73801b1bf792"), Guid.Parse("019e1b50-15ac-7507-8ca5-7fd4f6f48262"), }, { Guid.Parse("019e1b50-15ac-7272-b4d8-5e2390f8a738"), Guid.Parse("019e1b50-15ac-7aa2-a442-94e9f7d18978"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 124,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-71e5-aee4-7694a4264340"), Guid.Parse("019e1b50-15ac-7b7f-b22a-a4a9ce8c8c4c"), }, { Guid.Parse("019e1b50-15ac-7b3d-bfc4-91f808b2a16a"), Guid.Parse("019e1b50-15ac-7d5b-aae1-b4a222d53ca5"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 137,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7f9e-a4f0-eb613b84be8d"), Guid.Parse("019e1b50-15ac-7c09-a4e8-bcd748cb2981"), }, { Guid.Parse("019e1b50-15ac-7064-bf53-77e6bee67960"), Guid.Parse("019e1b50-15ac-7a1c-83f7-037d7f6eb4c9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-71f6-a439-cb213176de41"), Guid.Parse("019e1b50-15ac-70ec-b733-51f91e1135a3"), }, { Guid.Parse("019e1b50-15ac-7f9a-86dd-98f5744b1c60"), Guid.Parse("019e1b50-15ac-74ed-9d05-caa38a77f0b5"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 129,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-71f9-987d-bf7b498d8a32"), Guid.Parse("019e1b50-15ac-7ff1-a11a-4a8587449c2a"), }, { Guid.Parse("019e1b50-15ac-7a04-8cc3-48f2de5cd9fd"), Guid.Parse("019e1b50-15ac-73e0-810b-31e2f7d4a97a"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7442-ae00-510e5be51e22"), Guid.Parse("019e1b50-15ac-7782-8c6e-47fd55628dbd"), }, { Guid.Parse("019e1b50-15ac-7ec9-bd30-26251e49cf63"), Guid.Parse("019e1b50-15ac-7d5c-85da-0207e7a031c3"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-72ba-8d36-5422691be7a3"), Guid.Parse("019e1b50-15ac-7af2-b0a6-4fdc8647576f"), }, { Guid.Parse("019e1b50-15ac-78b6-bc23-44e092c01e6c"), Guid.Parse("019e1b50-15ac-7294-8d3f-334f99fade78"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 132,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7312-ae97-cbe3ccb50f96"), Guid.Parse("019e1b50-15ac-7e72-be00-977810898879"), }, { Guid.Parse("019e1b50-15ac-72b5-9f33-4a501a9a382b"), Guid.Parse("019e1b50-15ac-76bf-bd8e-47303e3e5a6b"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-76a8-9581-9fcc386c3a97"), Guid.Parse("019e1b50-15ac-7eb3-87f0-c66493526e44"), }, { Guid.Parse("019e1b50-15ac-7d29-94a9-dfb99f9843c8"), Guid.Parse("019e1b50-15ac-7912-aca4-e1342051a578"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 133,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7d1a-b74c-7ea437926ff5"), Guid.Parse("019e1b50-15ac-7619-b9d5-ebbc0ff1339b"), }, { Guid.Parse("019e1b50-15ac-7687-9c28-4f57e88b409e"), Guid.Parse("019e1b50-15ac-7d55-8d38-2d816223493c"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 159,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7eef-bac6-9eb409f45774"), Guid.Parse("019e1b50-15ac-7c18-bb4e-2aee90220a10"), }, { Guid.Parse("019e1b50-15ac-7a58-b468-ad2b73a57eef"), Guid.Parse("019e1b50-15ac-7529-94ac-3bdf7ea14077"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7fa3-a555-ec29563a5f80"), Guid.Parse("019e1b50-15ac-7dfd-8dba-023714f88a18"), }, { Guid.Parse("019e1b50-15ac-7c46-a0ee-9afaf38ccc93"), Guid.Parse("019e1b50-15ac-7db7-a8c8-d9d3b7802f84"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7a3c-94ad-e976fd21fe29"), Guid.Parse("019e1b50-15ac-7ab2-b415-90877d709d3a"), }, { Guid.Parse("019e1b50-15ac-7ed9-8207-bc5d886250c6"), Guid.Parse("019e1b50-15ac-7e7c-9b20-74211b15b552"), }, },
},
            new Guidv7MArrayD2E1M
{
    Id = 135,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7d9e-a8e3-7751414eaada"), Guid.Parse("019e1b50-15ac-70fc-9723-9038f1343707"), }, { Guid.Parse("019e1b50-15ac-762e-bd3d-fcafbf729bcf"), Guid.Parse("019e1b50-15ac-7a8f-877a-6c5db247ff17"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 166,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7229-b57c-b6660b87b0c5"), Guid.Parse("019e1b50-15ac-7b56-86e3-ec7c02394ac2"), }, { Guid.Parse("019e1b50-15ac-7a22-9ebb-eaad93a45194"), Guid.Parse("019e1b50-15ac-70cf-889a-667948c8219c"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 140,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7d7c-8d49-7b632d759aff"), Guid.Parse("019e1b50-15ac-7e77-ad06-0c80801b555c"), }, { Guid.Parse("019e1b50-15ac-76dd-9c6d-3ecfd7edbc1d"), Guid.Parse("019e1b50-15ac-7caf-8d92-1257e8bdd07a"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 168,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7393-b2e7-5c246e67b83c"), Guid.Parse("019e1b50-15ac-7c3c-a910-cd3dc4d3b049"), }, { Guid.Parse("019e1b50-15ac-75b1-bcdd-d6e40940ceef"), Guid.Parse("019e1b50-15ac-7fcf-a51e-4ed0baee26b6"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-73e0-9b92-6685be3846fa"), Guid.Parse("019e1b50-15ac-72ce-947e-1b93d9c044b5"), }, { Guid.Parse("019e1b50-15ac-7576-b602-b1a07ecdf5c9"), Guid.Parse("019e1b50-15ac-702a-a882-51dfc83853ae"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 148,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7d86-8fb6-ee1491767325"), Guid.Parse("019e1b50-15ac-77cd-831c-c554bf548630"), }, { Guid.Parse("019e1b50-15ac-79ef-98ab-4867a8295973"), Guid.Parse("019e1b50-15ac-7356-9568-6089dc18120a"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 177,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7e56-af85-51cbcbb8cf33"), Guid.Parse("019e1b50-15ac-7437-b87c-8540d6159d85"), }, { Guid.Parse("019e1b50-15ac-7f5b-82ad-3b0cea53dd17"), Guid.Parse("019e1b50-15ac-7bc7-9dc3-df169b55c954"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-75e6-a465-4400a8b586f9"), Guid.Parse("019e1b50-15ac-7e1a-8d08-64698e889126"), }, { Guid.Parse("019e1b50-15ac-70d8-aa48-e6640aa0a811"), Guid.Parse("019e1b50-15ac-7008-a81d-e9277e1b4170"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 151,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-70c0-b5be-a68eb21521a9"), Guid.Parse("019e1b50-15ac-703c-9537-e3d5a24f0ef9"), }, { Guid.Parse("019e1b50-15ac-7bdb-a62c-fbf947caed00"), Guid.Parse("019e1b50-15ac-7d7b-a170-281744d19657"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 178,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7721-9925-66738563f4ef"), Guid.Parse("019e1b50-15ac-7f15-993f-a3b8571f6b07"), }, { Guid.Parse("019e1b50-15ac-7350-bc89-a0d7defd1b84"), Guid.Parse("019e1b50-15ac-7565-bf8d-df3cd7c9003c"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 160,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7472-8b58-4ff18f3d1603"), Guid.Parse("019e1b50-15ac-7062-ab91-4eb30ed5cdd0"), }, { Guid.Parse("019e1b50-15ac-7da0-b314-eec807830cad"), Guid.Parse("019e1b50-15ac-740a-a806-c9f6ad20372a"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 182,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7835-b5ae-bc14b836588c"), Guid.Parse("019e1b50-15ac-74ca-bcf4-083fe24efed2"), }, { Guid.Parse("019e1b50-15ac-7561-beec-dda5c44294af"), Guid.Parse("019e1b50-15ac-709e-9ba5-44fd6dcb203f"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-77cb-a3a1-e2039ecf1b81"), Guid.Parse("019e1b50-15ac-7bb5-89ab-60ed02a82ec7"), }, { Guid.Parse("019e1b50-15ac-7e9f-aec8-87dcfe29cdc2"), Guid.Parse("019e1b50-15ac-7182-93cb-624eaa2e7156"), }, },
},
    NullableValue = null,
},
            new Guidv7MArrayD2E1M
{
    Id = 165,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-75c5-83c5-762d68e5fc0f"), Guid.Parse("019e1b50-15ac-7a5c-9259-bccace54fcd3"), }, { Guid.Parse("019e1b50-15ac-7176-9b59-0788b9517698"), Guid.Parse("019e1b50-15ac-7e47-ad85-c8276afb2ea4"), }, },
    ModelInner = new Guidv7MArrayD2E1MI
{
    Id = 184,
    Value = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7025-9cb1-31c1800e7e14"), Guid.Parse("019e1b50-15ac-7967-90a1-d2f6a6ebdda6"), }, { Guid.Parse("019e1b50-15ac-7ff6-ad92-3756d7e167d1"), Guid.Parse("019e1b50-15ac-7a7e-926f-180e11aa129b"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("019e1b50-15ac-7ecd-88a7-c1c0a74ba9c0"), Guid.Parse("019e1b50-15ac-7f57-8531-aa73a25859c2"), }, { Guid.Parse("019e1b50-15ac-7f14-b1bd-3ace710c6402"), Guid.Parse("019e1b50-15ac-7706-9398-4845374dcaaf"), }, },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidv7marrayd2e1m(
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
            asPartInterface: typeof(IGuidv7MArrayMArrayD2)),
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
                    await ((IGuidv7MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IGuidv7MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.guidv7marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Guidv7MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidv7MArrayMArrayD2)),
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
                    var models = await ((IGuidv7MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Guidv7MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidv7MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Guidv7MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

