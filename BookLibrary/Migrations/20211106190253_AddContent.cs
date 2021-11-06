using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibrary.Migrations
{
    public partial class AddContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ae0ff72-40b1-4eeb-9756-4a381bec43d2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("28ba4b77-356d-4636-8cb4-fdabd8e44fc2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("30c2c17c-065d-4ea8-bcbd-47fcaeb20899"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3cfd6b02-3c50-4a03-b7c5-1f0e71e70275"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e636e50-8b7b-49a0-9c00-e6a07df8fbb9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53c7d64c-020d-4167-9150-712caf4a8f4e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b8b8f70-a9e1-4a46-a384-d57fe377fe3c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f3c257d-8f14-43d0-acc7-97cee713633a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("75136734-684d-4ae6-bc7d-d2b5bb2b3537"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ba3f20ef-1f26-44b6-b8ee-363a99203d15"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e52bff9d-c1d6-4005-99b6-3f9c06db31f5"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Content", "Name", "Picture" },
                values: new object[,]
                {
                    { new Guid("eb72d0c3-0211-473d-a051-bf6cdddaaf96"), "Roberto Bolaño Ávalos", "https://www.negrophonic.com/pdfs/Bolano,%20Roberto%20-%202666.pdf", "2666", "2666.jpg" },
                    { new Guid("394f2e59-838e-4d9d-86e8-2fbffea88f72"), "Gabriel García Márquez", "https://giove.isti.cnr.it/demo/eread/Libri/sad/LoveInTheTimeOfCholera.pdf", "Love in the Time of Cholera", "LoveInTheTimeOfCholera.jpg" },
                    { new Guid("4b222ca7-8832-4cd9-8fa6-682a5d4c119a"), "Francis Scott Key Fitzgerald", "https://www.planetebook.com/free-ebooks/the-great-gatsby.pdf", "The Great Gatsby", "TheGreatGatsby.jpg" },
                    { new Guid("7eb03376-ab63-4b21-8032-ae8ff5a42174"), "Haruki Murakami", "", "Norwegian Wood", "NorwegianWood.jpg" },
                    { new Guid("043f6f90-422a-47d9-9f5d-5d76cab66519"), "George Orwell", "https://www.planetebook.com/free-ebooks/1984.pdf", "1984", "1984.jpg" },
                    { new Guid("90a9de8d-536a-49f3-9547-adc52ad2695d"), "Yu Hua", "", "To Live", "ToLive.jpg" },
                    { new Guid("52a66281-d115-44f6-a2d7-82b27dcf9d52"), "Marcel Proust", "https://uberty.org/wp-content/uploads/2015/12/Proust-1.pdf", "In Search of Lost time", "InSearchOfLostTime.jpg" },
                    { new Guid("494520bc-f09b-40a7-b3a5-b7d9104ad145"), "Boris Pasternak", "http://userfiles.educatorpages.com/userfiles/kmcmillan/Doctor%20Zhivago.pdf", "Doctor Zhivago", "DoctorZhivago.jpg" },
                    { new Guid("33d53eab-8dff-4db3-8558-b08d37755757"), "Jean-Paul Sartre", "http://www.kkoworld.com/kitablar/jan_pol_satr_urekbulanma-eng.pdf", "La Nausee", "La Nausee.jpg" },
                    { new Guid("47cfcfa3-2e08-4c7c-bf94-514767c4a0b4"), "Edgar Allan Poe", "https://www.ibiblio.org/ebooks/Poe/Raven.pdf", "The Raven", "TheRaven.jpg" },
                    { new Guid("0496bcaa-7fe0-4f70-bf36-60b827456b23"), "Kate DiCamillo", "", "The Miraculous Journey of Edward Tulane", "TheMiraculousJourneyOfEdwardTulane.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("043f6f90-422a-47d9-9f5d-5d76cab66519"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0496bcaa-7fe0-4f70-bf36-60b827456b23"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("33d53eab-8dff-4db3-8558-b08d37755757"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("394f2e59-838e-4d9d-86e8-2fbffea88f72"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("47cfcfa3-2e08-4c7c-bf94-514767c4a0b4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("494520bc-f09b-40a7-b3a5-b7d9104ad145"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4b222ca7-8832-4cd9-8fa6-682a5d4c119a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("52a66281-d115-44f6-a2d7-82b27dcf9d52"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7eb03376-ab63-4b21-8032-ae8ff5a42174"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90a9de8d-536a-49f3-9547-adc52ad2695d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eb72d0c3-0211-473d-a051-bf6cdddaaf96"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Content", "Name", "Picture" },
                values: new object[,]
                {
                    { new Guid("0ae0ff72-40b1-4eeb-9756-4a381bec43d2"), "Roberto Bolaño Ávalos", "", "2666", "2666.jpg" },
                    { new Guid("75136734-684d-4ae6-bc7d-d2b5bb2b3537"), "Gabriel García Márquez", "", "Love in the Time of Cholera", "LoveInTheTimeOfCholera.jpg" },
                    { new Guid("28ba4b77-356d-4636-8cb4-fdabd8e44fc2"), "Francis Scott Key Fitzgerald", "", "The Great Gatsby", "TheGreatGatsby.jpg" },
                    { new Guid("53c7d64c-020d-4167-9150-712caf4a8f4e"), "Haruki Murakami", "", "Norwegian Wood", "NorwegianWood.jpg" },
                    { new Guid("30c2c17c-065d-4ea8-bcbd-47fcaeb20899"), "George Orwell", "", "1984", "1984.jpg" },
                    { new Guid("5f3c257d-8f14-43d0-acc7-97cee713633a"), "Yu Hua", "", "To Live", "ToLive.jpg" },
                    { new Guid("ba3f20ef-1f26-44b6-b8ee-363a99203d15"), "Marcel Proust", "", "In Search of Lost time", "InSearchOfLostTime.jpg" },
                    { new Guid("e52bff9d-c1d6-4005-99b6-3f9c06db31f5"), "Boris Pasternak", "", "Doctor Zhivago", "DoctorZhivago.jpg" },
                    { new Guid("4e636e50-8b7b-49a0-9c00-e6a07df8fbb9"), "Jean-Paul Sartre", "", "La Nausee", "La Nausee.jpg" },
                    { new Guid("3cfd6b02-3c50-4a03-b7c5-1f0e71e70275"), "Edgar Allan Poe", "", "The Raven", "TheRaven.jpg" },
                    { new Guid("5b8b8f70-a9e1-4a46-a384-d57fe377fe3c"), "Kate DiCamillo", "", "The Miraculous Journey of Edward Tulane", "TheMiraculousJourneyOfEdwardTulane.jpg" }
                });
        }
    }
}
