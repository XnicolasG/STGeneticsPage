using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace STGeneticsPage.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "17180121-f6bc-412e-9ab0-98c7aed3f5a6");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "24fbca3a-305c-4e66-b307-49dc0360044f");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "40760cbe-aee9-4a2d-98ea-1b2d045f7e80");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "4597d205-64df-42f7-9fef-44e1303e1db8");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "4cc857b0-7837-4a61-9808-ed7708898258");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "5dff69da-bc64-46d2-ad11-7eaa49ef20ce");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "6a78857b-71b0-45d7-b6e4-615c83cb2a77");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "6aa56b8a-9337-4b18-b4b5-c23b543a7fd1");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "715fd883-e3d7-4e63-9907-68e407780d0f");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "82c27db8-8b9f-4987-b22d-f17fda9bc579");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "83891bd2-a3cc-48cf-9e6a-0727f67b671c");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "8cce5d2d-6db9-4e98-aceb-859ce546162e");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "8e246acf-b6c2-430a-8773-5beddf888069");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "94c7a75b-4aff-4ef0-9b75-240c08b91309");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "9530a454-996f-4fd6-8ea6-ee0e51360456");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "9706a3c5-9946-4d2f-ba41-232f7b1a2328");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "ac92da03-f94b-4936-8c8b-9700dc5b30f2");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "d2ec1d4c-0892-4a5d-8795-01508f7d3a3e");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "fd3bc03d-3263-4dab-b976-5a5b3a450f0f");

            migrationBuilder.InsertData(
                table: "AnimalsT",
                columns: new[] { "AnimalId", "Breed", "DateOfBirth", "Name", "Price", "Sex", "Status" },
                values: new object[,]
                {
                    { "0ad48506-38d7-44c8-81c2-0c1dffbee40b", "Brahman", new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duke", 4600, "Male", "Active" },
                    { "1c6b6c07-dc0f-401c-a24f-2b1dd5a2b7cb", "Red Angus", new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ButterCup", 4500, "Female", "Active" },
                    { "31a7b5eb-4e59-48be-96aa-41c06b4bf8b3", "Piedmontese", new DateTime(2012, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delilah", 2000, "Female", "Inactive" },
                    { "3eb97735-38cf-40a3-aa2f-2ba2574f5c24", "Limousin", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor", 5100, "Male", "Active" },
                    { "4219235b-d5b2-438d-8efe-b66b5eb76c7d", "Charolais", new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aurora", 6600, "Female", "Active" },
                    { "49d6b945-1064-490d-9fe3-b3bd3fe1e943", "Red Angus", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ginger", 2600, "Female", "Active" },
                    { "5540c710-f517-4b25-bac8-486e19a835ea", "Watusi", new DateTime(2014, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlas", 2300, "Male", "Inactive" },
                    { "5c39c817-7d0f-4474-ad56-9ae47e390622", "Gelbvieh", new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maximus", 3200, "Male", "Active" },
                    { "6c238b1d-a75b-45ed-9f6c-dacaf3acfb46", "Gelbvieh", new DateTime(2010, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hazel", 900, "Female", "Inactive" },
                    { "6c3397f7-412e-451c-bdfc-e7db94886512", "Limousin", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clover", 3800, "Female", "Active" },
                    { "746c9918-5c72-4f5f-a470-7f189d18384a", "Holstein", new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lola", 2000, "Female", "Active" },
                    { "7c53ab9c-8a05-492d-942f-f255a549ca00", "Red Angus", new DateTime(2013, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daisy", 1500, "Female", "Inactive" },
                    { "842de971-3d0a-473a-b1cc-524fe87376a3", "Piedmontese", new DateTime(2011, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bella", 1400, "Female", "Inactive" },
                    { "8de9d525-3a8c-4164-8834-fc3caab0decd", "Shorthorn", new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maisie", 2000, "Female", "Active" },
                    { "a788828d-f243-40c8-94be-35dfb956e7e1", "Simmental", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky", 3000, "Male", "Active" },
                    { "b59fd15f-d75c-4f72-b897-916d492cfd12", "Hereford", new DateTime(2011, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maverick", 1400, "Male", "Inactive" },
                    { "bb49a8c4-0b86-4370-a6aa-006205d64f34", "Simmental", new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brutus", 6100, "Male", "Active" },
                    { "c6c72693-4c9b-42e6-92ca-7148a5e60ef0", "Watusi", new DateTime(2017, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titan", 6400, "Male", "Active" },
                    { "ce4ff762-dcc7-4aa2-9c86-a4c93d61d409", "Red Angus", new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molly", 4700, "Female", "Active" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "0ad48506-38d7-44c8-81c2-0c1dffbee40b");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "1c6b6c07-dc0f-401c-a24f-2b1dd5a2b7cb");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "31a7b5eb-4e59-48be-96aa-41c06b4bf8b3");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "3eb97735-38cf-40a3-aa2f-2ba2574f5c24");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "4219235b-d5b2-438d-8efe-b66b5eb76c7d");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "49d6b945-1064-490d-9fe3-b3bd3fe1e943");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "5540c710-f517-4b25-bac8-486e19a835ea");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "5c39c817-7d0f-4474-ad56-9ae47e390622");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "6c238b1d-a75b-45ed-9f6c-dacaf3acfb46");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "6c3397f7-412e-451c-bdfc-e7db94886512");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "746c9918-5c72-4f5f-a470-7f189d18384a");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "7c53ab9c-8a05-492d-942f-f255a549ca00");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "842de971-3d0a-473a-b1cc-524fe87376a3");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "8de9d525-3a8c-4164-8834-fc3caab0decd");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "a788828d-f243-40c8-94be-35dfb956e7e1");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "b59fd15f-d75c-4f72-b897-916d492cfd12");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "bb49a8c4-0b86-4370-a6aa-006205d64f34");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "c6c72693-4c9b-42e6-92ca-7148a5e60ef0");

            migrationBuilder.DeleteData(
                table: "AnimalsT",
                keyColumn: "AnimalId",
                keyValue: "ce4ff762-dcc7-4aa2-9c86-a4c93d61d409");

            migrationBuilder.InsertData(
                table: "AnimalsT",
                columns: new[] { "AnimalId", "Breed", "DateOfBirth", "Name", "Price", "Sex", "Status" },
                values: new object[,]
                {
                    { "17180121-f6bc-412e-9ab0-98c7aed3f5a6", "Hereford", new DateTime(2011, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maverick", 1400, "Male", "Inactive" },
                    { "24fbca3a-305c-4e66-b307-49dc0360044f", "Gelbvieh", new DateTime(2010, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hazel", 900, "Female", "Inactive" },
                    { "40760cbe-aee9-4a2d-98ea-1b2d045f7e80", "Red Angus", new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ButterCup", 4500, "Female", "Active" },
                    { "4597d205-64df-42f7-9fef-44e1303e1db8", "Piedmontese", new DateTime(2011, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bella", 1400, "Female", "Inactive" },
                    { "4cc857b0-7837-4a61-9808-ed7708898258", "Red Angus", new DateTime(2013, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daisy", 1500, "Female", "Inactive" },
                    { "5dff69da-bc64-46d2-ad11-7eaa49ef20ce", "Holstein", new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lola", 2000, "Female", "Active" },
                    { "6a78857b-71b0-45d7-b6e4-615c83cb2a77", "Watusi", new DateTime(2017, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titan", 6400, "Male", "Active" },
                    { "6aa56b8a-9337-4b18-b4b5-c23b543a7fd1", "Simmental", new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brutus", 6100, "Male", "Active" },
                    { "715fd883-e3d7-4e63-9907-68e407780d0f", "Red Angus", new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ginger", 2600, "Female", "Active" },
                    { "82c27db8-8b9f-4987-b22d-f17fda9bc579", "Shorthorn", new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maisie", 2000, "Female", "Active" },
                    { "83891bd2-a3cc-48cf-9e6a-0727f67b671c", "Charolais", new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aurora", 6600, "Female", "Active" },
                    { "8cce5d2d-6db9-4e98-aceb-859ce546162e", "Limousin", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor", 5100, "Male", "Active" },
                    { "8e246acf-b6c2-430a-8773-5beddf888069", "Simmental", new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky", 3000, "Male", "Active" },
                    { "94c7a75b-4aff-4ef0-9b75-240c08b91309", "Limousin", new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clover", 3800, "Female", "Active" },
                    { "9530a454-996f-4fd6-8ea6-ee0e51360456", "Red Angus", new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molly", 4700, "Female", "Active" },
                    { "9706a3c5-9946-4d2f-ba41-232f7b1a2328", "Brahman", new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duke", 4600, "Male", "Active" },
                    { "ac92da03-f94b-4936-8c8b-9700dc5b30f2", "Piedmontese", new DateTime(2012, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delilah", 2000, "Female", "Inactive" },
                    { "d2ec1d4c-0892-4a5d-8795-01508f7d3a3e", "Gelbvieh", new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maximus", 3200, "Male", "Active" },
                    { "fd3bc03d-3263-4dab-b976-5a5b3a450f0f", "Watusi", new DateTime(2014, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlas", 2300, "Male", "Inactive" }
                });
        }
    }
}
